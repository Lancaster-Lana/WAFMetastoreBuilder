using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	public enum CommandType { New = 0, Update = 1 }

	/// <summary>
	/// Editable GUI control for metastore XML element 
	/// to dispaly, save, cancel operations
	/// </summary>
	public partial class BaseWAFCtrl : UserControl
	{
		#region Events

		private event System.Action CancelElementEvent;
		private event System.Action AddNewElementEvent;
		private event System.Action UpdateElementEvent;

		#endregion

		#region Properties

		/// <summary>
		/// Container control with navigation tree by element of metastore
		/// </summary>
		public WafXMLDesignerControl ParentDesignerCtrl { get; set; }

		/// <summary>
		/// Current edited element (selected TreeNode with its Tag Element data)
		/// </summary>
		private BaseXMLElement _subElement = null;// Metastore data element (action, field, form, etc.)
		public BaseXMLElement Data
		{
			get
			{
				if (DesignMode) return null;

				if (_subElement != null) return _subElement;

				var editedElementData = ParentDesignerCtrl.CurrentNode.Tag as BaseXMLElement;
				return editedElementData;
			}
			set
			{
				if (DesignMode) return;

				if (value == null) //is Metastore)
				{
					_subElement = null; // means we edit not subnode, but node from TreeView

					if ((ParentDesignerCtrl != null) && (ParentDesignerCtrl.CurrentNode != null) && (Command == CommandType.Update))
					{
						var editedElementData = ParentDesignerCtrl.CurrentNode.Tag as BaseXMLElement;
						LoadDataToCtrl(editedElementData);
					}
				}
				else
				{
					_subElement = value;
					LoadDataToCtrl(_subElement);
				}
				IsDataLoaded = true; //set for dirty data check
			}
		}

		[Browsable(true)]
		[Category("Custom Properties")]
		public string Title
		{
			get { return titleLabel.Text; }
			set { titleLabel.Text = value; }
		}

		[Browsable(true)]
		[Category("Custom Properties")]
		public string ParentElementLink
		{
			get { return lnkParentElement.Text; }
			set
			{
				lnkParentElement.Text = value;
			}
		}

		/// <summary>
		/// Current GUI action: add, edit, remove element
		/// </summary>
		[DefaultValue(CommandType.Update)]
		public CommandType Command { get; set; }

		//[DefaultValue(false)]
		private bool _isDirty = false;
		public bool IsDirty
		{
			get
			{
				return _isDirty;
			}
			set
			{
				_isDirty = value;
				btnSave.Enabled = btnCancel.Enabled = value;
			}
		}

		/// <summary>
		/// If Load data to control already called
		/// </summary>
		[DefaultValue(false)]
		private bool _isDataLoaded = false;
		public bool IsDataLoaded
		{
			get
			{
				return _isDataLoaded;
			}
			set
			{
				_isDataLoaded = value;
				if (_isDataLoaded)
					this.AddOnChangeHandlerToInputControls(); //subscribe on changes
			}

		}

		#endregion

		#region Ctor

		public BaseWAFCtrl()
		{
			InitializeComponent();

			//Subscribe on events
			AddNewElementEvent += OnAdd;
			UpdateElementEvent += OnUpdate;
			CancelElementEvent += OnCancelChanges;

			//Init navigation to the parent element
			lnkParentElement.Click += (o, e) => GoToParentElement();

			//For dirty data checks 
			this.IsDataLoaded = false;
		}

		public BaseWAFCtrl(WafXMLDesignerControl parentCtrl)
			: this()
		{
			ParentDesignerCtrl = parentCtrl;
		}

		#endregion

		#region Methods

		#region Virtual protected methods (to be overriden in child GUI  control classes)

		/// <summary>
		/// Validate all nessecary fields for save command
		/// </summary>
		protected virtual bool IsValid
		{
			get
			{
				//TODO:
				return true;
			}
		}

		/// <summary>
		/// Fill up element control with default data (comboboxes, listboxes predefined data)
		/// </summary>
		protected virtual void InitDefaultData()
		{
			//Title = "New " + Title;
		}

		/// <summary>
		///  Fill up gui control with xmlElement data
		/// </summary>
		/// <param name="elementData"></param>
		protected virtual void LoadDataToCtrl(BaseXMLElement elementData)
		{
			////set for dirty data check
			//IsDataLoaded = true;
			//INIT parent element navigation (to tree node)
			ParentElementLink = ParentDesignerCtrl.GetParentElementDescription();
		}

		/// <summary>
		/// Return data from edited control
		/// </summary>
		/// <returns></returns>
		protected virtual BaseXMLElement GetDataFromCtrl()
		{
			return Data;
		}

		#endregion

		#region Event handlers

		/// <summary>
		/// Changed parent for current Table, Form, Search, etc
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected void GoToParentElement()
		{
			if (Command != CommandType.New) //if new -we see modal window (no need to nav)
				ParentDesignerCtrl.NavigateToParentElement();
		}

		protected void GoToTableElement(string tableName)
		{
			ParentDesignerCtrl.NavigateTableByName(tableName);
		}

		protected void GoToFormElement(string tableName, string formName)
		{
			ParentDesignerCtrl.NavigateFormByName(tableName, formName);
		}

		/// <summary>
		/// Event handler to add a new element to Metastore XML
		/// </summary>
		protected virtual void OnAdd()
		{
			var newElementData = GetDataFromCtrl();

			//1. In case if new query is creating
			if (newElementData is Metastore)
			{
				ParentDesignerCtrl.CurrentMetastore = newElementData as Metastore;
				TreeNode rootNode = ParentDesignerCtrl.BuildMetastoreTree(ParentDesignerCtrl.CurrentMetastore);
				ParentDesignerCtrl.NavigateNode(rootNode);
			}
			else //2. sub elements is creating
			{
				TreeNode currentParentNode = ParentDesignerCtrl.CurrentNode;

				if (currentParentNode != null)
				{
					//Current parent node for adding new element to
					var toElement = currentParentNode.Tag as BaseXMLElement;

					//1. Add a new element to current metastore
					if (toElement is Metastore)
					{
						var parentMetastore = (Metastore)toElement;
						if (newElementData is Include)
						{
							parentMetastore.AddInclude(newElementData as Include);
							//Get fake parent INCLUDES node
							var rootIncludesNode = currentParentNode.Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Name.Equals("INCLUDES"));
							currentParentNode = rootIncludesNode ?? currentParentNode;
						}
						else if (newElementData is MetastoreString)
						{
							parentMetastore.AddString(newElementData as MetastoreString);
							//Get fake parent STRINGS node
							var rootStringsNode = currentParentNode.Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Name.Equals("STRINGS"));
							currentParentNode = rootStringsNode ?? currentParentNode;
						}
						else if (newElementData is SystemString)
						{
							parentMetastore.AddSystemString(newElementData as SystemString);
							//Get fake parent SYSTEMSTRINGS node
							var rootSystemStringsNode = currentParentNode.Nodes.Cast<TreeNode>().FirstOrDefault(n => n.Name.Equals("SYSTEMSTRINGS"));
							currentParentNode = rootSystemStringsNode ?? currentParentNode;
						}
						else if (newElementData is Table)
							parentMetastore.AddTable(newElementData as Table);
					}

					//2. Add a new element to current TABLE
				  if (toElement is Table)
					{
						var parentTable = (Table)toElement;
                        if (newElementData is WAFMetastoreElements.Action)
                            parentTable.AddAction(newElementData as WAFMetastoreElements.Action);
						else if (newElementData is TableField)
							parentTable.AddField(newElementData as TableField);
                        else if (newElementData is WAFMetastoreElements.Form)
                            parentTable.AddForm(newElementData as WAFMetastoreElements.Form);
						else if (newElementData is Search)
							parentTable.AddSearch(newElementData as Search);
					}
					//2.1 table action
                  else if (toElement is WAFMetastoreElements.Action)
					{
                        var parentAction = (WAFMetastoreElements.Action)toElement;
						if (newElementData is Security)
							parentAction.AddSecurity(newElementData as Security);
					}					
					//2.2 table field
                  else if (toElement is TableField)
					{
                        var parentField = (TableField)toElement;
						if (newElementData is Security)
							parentField.AddSecurity(newElementData as Security);
					}
					
					//3. Add a new element to current FORM
                  if (toElement is WAFMetastoreElements.Form)
					{
                        var parentForm = (WAFMetastoreElements.Form)toElement;

						if (newElementData is Security)
							parentForm.AddSecurity(newElementData as Security);
						else if (newElementData is FormField)
							parentForm.AddFormField(newElementData as FormField);

						else if (newElementData is FormMenuAction)
							parentForm.AddFormMenuAction(newElementData as FormMenuAction);
						else if (newElementData is FormRowAction)
							parentForm.AddFormRowAction(newElementData as FormRowAction);
						else if (newElementData is FormTabAction)
							parentForm.AddFormTabAction(newElementData as FormTabAction);

						else if (newElementData is LinkedForm)
							parentForm.AddLinkedForm(newElementData as LinkedForm);
					}
					//3.1 form field
                  else if (toElement is FormField)
					{
                        var parentFormField = (FormField)toElement;
						if (newElementData is Security)
							parentFormField.AddSecurity(newElementData as Security);
					}
					//3.2 form menu action
                  else if (toElement is FormMenuAction)
					{
                        var parentFormMenuAction = (FormMenuAction)toElement;
						if (newElementData is Security)
							parentFormMenuAction.AddSecurity(newElementData as Security);
					}

					//4. Add a new element to current SEARCH
				  if (toElement is Search)
					{
						var parentSearch = (Search) toElement;

						if (newElementData is Security)
							parentSearch.AddSecurity(newElementData as Security);
						if (newElementData is SearchField)
							parentSearch.AddSearchField(newElementData as SearchField);
						else if (newElementData is SearchMenuAction)
							parentSearch.AddSearchMenuAction(newElementData as SearchMenuAction);
						else if (newElementData is SearchRowAction)
							parentSearch.AddSearchRowAction(newElementData as SearchRowAction);
						else if (newElementData is SearchTabAction)
							parentSearch.AddSearchTabAction(newElementData as SearchTabAction);
					}
					//4.1 search field
					else if (toElement is SearchField)
					{
						var parentSearchField = (SearchField)toElement;
						if (newElementData is Security)
							parentSearchField.AddSecurity(newElementData as Security);
					}
					//4.2 search action
                  else if (toElement is SearchMenuAction)
					{
                        var parentSearchMenuAction = (SearchMenuAction)toElement;
						if (newElementData is Security)
							parentSearchMenuAction.AddSecurity(newElementData as Security);
					}

					//2. Add new element to parent TreeNode
					TreeNode createdElementNode = ParentDesignerCtrl.AddElementToTreeViewNode(currentParentNode, newElementData);
					ParentDesignerCtrl.NavigateNode(createdElementNode); //ParentCtrl.NavigateNode(currentParentNode);
				}
			}
		}

		/// <summary>
		/// Event handler to update element data
		/// </summary>
		protected virtual void OnUpdate()
		{
			var updatedData = GetDataFromCtrl();
			ParentDesignerCtrl.OnUpdate(updatedData); //ParentCtrl.OnUpdateCurrentNode(Data);
		}

		/// <summary>
		/// Event handler to cancel data changes
		/// </summary>
		protected virtual void OnCancelChanges()
		{
			switch (Command)
			{
				//If cancel button clicked, close modal window for "New Element". So, nothing happen
				case CommandType.New:
					//ParentCtrl.CancelAddingNewElement();
					break;

				case CommandType.Update:
					LoadDataToCtrl(Data);//Reload original data if control reverted
					break;
			}
		}

		#endregion

		#region Public (external call) methods for (re)load data to control

		public void BeginAdd()
		{
			Command = CommandType.New;
			btnSave.Text = "Save";

			//Fill up with default data
			InitDefaultData();

			//set for dirty
			//IsDataLoaded = true;
			// Init parent link description
			ParentElementLink = ParentDesignerCtrl.GetParentElementDescription(Command);
		}

		public void BeginEdit(BaseXMLElement elementData)
		{
			//Fill combos, lists, etc	
			InitDefaultData();

			Command = CommandType.Update;
			btnSave.Text = "Update";

			//Fill up data into control
			Data = elementData; //LoadDataToCtrl(elementData);
		}

		/// <summary>
		/// External call (modal window)
		/// </summary>
		/// <param name="data"></param>
		public void LoadData(BaseXMLElement data)
		{
			try
			{
				LoadDataToCtrl(data);
				IsDataLoaded = true;//set for dirty data check
			}
			catch (Exception ex)
			{
				IsDataLoaded = false;
				throw ex;
			}
		}

		///// <summary>
		///// Refresh Element control data with current element data
		///// </summary>
		//protected void UpdateView()
		//{
		//	LoadDataToCtrl(Data);
		//	Invalidate(true);
		//}

		#endregion

		#endregion

		#region Handlers

		#region Menu commands (save, update) handlers

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (IsValid)
			{
				SaveChanges();
				IsDirty = false;
			}
			else
			{
				MessageBox.Show("Fill up all fields", "Warings: Validation failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			CancelChanges();
			IsDirty = false;
		}

		#endregion

		#region Methods for menu commands handlers

		/// <summary>
		/// Apply changes after GUI commands New\Update called (from context menu, or "Create\Update" buttons click)
		/// </summary>
		private void SaveChanges()
		{
			//Call suitable handler 
			switch (Command)
			{
				case CommandType.New:
					if (AddNewElementEvent != null)
						AddNewElementEvent(); //raise new element event
					// Refresh Common view - TreeView 
					//   UpdateView();
					break;

				case CommandType.Update:
					if (UpdateElementEvent != null)
						UpdateElementEvent(); //raise update event
					break;
			}
		}

		/// <summary>
		/// Revert changes made in control
		/// </summary>
		private void CancelChanges()
		{
			if (CancelElementEvent != null)
				CancelElementEvent();
		}

		#endregion

		#endregion
	}
}