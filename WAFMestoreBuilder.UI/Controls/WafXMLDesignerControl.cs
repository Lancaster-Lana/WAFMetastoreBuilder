
using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;
using Action = WAFMetastoreBuilder.WAFMetastoreElements.Action;
using Form = WAFMetastoreBuilder.WAFMetastoreElements.Form;

namespace WAFMetastoreBuilder.UI
{
	/// <summary>
	/// Container control with 2 panels:
	/// 1st - navigation tree of Metastore xml nodes
	/// 2d -  content data of editable  metastore xmlElement (table, form, field, action, etc.)
	/// </summary>
	public partial class WafXMLDesignerControl : UserControl
	{
		#region Events

		// Call methods from Entity Class after select TreeNodes
		private event Action<ElementType> NewEvent;
		private event Action<BaseXMLElement> DeleteEvent;
		private event Action<BaseXMLElement> EditEvent;

		#endregion

		#region Properties

		/// <summary>
		/// Current deserialized Metastore data (loaded from XML file)
		/// </summary>
		public Metastore CurrentMetastore { get; set; }

		/// <summary>
		/// TODO: Get parent table for current editable node
		/// </summary>
		public Table CurrentTable
		{
			get
			{
				var currentNode = CurrentNode;
				do
				{
					if (currentNode.Tag is Table) return (Table)currentNode.Tag;
					currentNode = currentNode.Parent;
				}
				while (currentNode != null);

				return null;
			}
		}



		public TreeNode CurrentFormNode
		{
			get
			{
				var formNode = CurrentNode;
				do
				{
					if (formNode.Tag is Form) return formNode;
					formNode = formNode.Parent;
				}
				while (formNode != null);

				return null;
			}
		}

		/// <summary>
		/// Get parent Form node for current editable node
		/// </summary>
		public Form CurrentForm
		{
			get
			{
				return CurrentFormNode != null ? (Form)CurrentFormNode.Tag : null;
				//var currentNode = CurrentNode;
				//do
				//{
				//	if (currentNode.Tag is Form) return (Form)currentNode.Tag;
				//	currentNode = currentNode.Parent;
				//}
				//while (currentNode != null);

				//return null;
			}
		}

		/// <summary>
		/// Get parent Search for current editable node
		/// </summary>
		public Search CurrentSearch
		{
			get
			{
				var currentNode = CurrentNode;
				do
				{
					if (currentNode.Tag is Search) return (Search)currentNode.Tag;
					currentNode = currentNode.Parent;
				}
				while (currentNode != null);

				return null;
			}
		}


		/// <summary>
		/// Selected node of Metastore XML Tree
		/// </summary>
		public TreeNode CurrentNode
		{
			get
			{
				return this.metastoreXMLTreeView.SelectedNode;
			}
		}

		/// <summary>
		/// GUI contol with element data (that correspond to selected tree node) 
		/// </summary>
		public BaseWAFCtrl EditableWAFCtrl { get; set; }

		/// <summary>
		/// Parent XML element to the current editable element
		/// </summary>
		public BaseXMLElement CurrentParent
		{
			get
			{
				if (CurrentNode == null) return null;

				if (EditableWAFCtrl.Command == CommandType.New)
					return CurrentNode.Tag as BaseXMLElement;
				return CurrentNode.Parent.Tag as BaseXMLElement;
			}
		}

		public BaseXMLElement CurrentElement
		{
			get
			{
				if (CurrentNode == null) return null;
				return CurrentNode.Tag as BaseXMLElement;
			}
		}

		#endregion

		#region Constructors

		public WafXMLDesignerControl()
		{
			InitializeComponent();
		}

		private void WafXMLDesignerControl_Load(object sender, EventArgs e)
		{
			try
			{
				EditableWAFCtrl = new BaseWAFCtrl();
				InitEvents();	//Event Add, Delete, Update XML elements
			}
			catch (Exception ex)
			{
				ShowError(ex.Message);
			}
		}

		private void InitEvents()
		{
			NewEvent += OnCreateElement;
			DeleteEvent += OnDeleteElement;
			EditEvent += BeginEditElement;
		}

		#endregion

		#region Methods

		#region Getting editable GUI control by metastore element\type

		private BaseWAFCtrl GetControlByElementType(ElementType elementType)
		{
			switch (elementType)
			{
				case ElementType.metastore:
					return new MetastoreCtrl(this);

				case ElementType.include:
					return new IncludeCtrl(this);
				case ElementType.metastorestring:
					return new MetastoreStringCtrl(this);
				case ElementType.systemstring:
					return new SystemStringCtrl(this);

				case ElementType.table:
					return new TableCtrl(this);
				case ElementType.tablefield:
					return new TableFieldCtrl(this);
				case ElementType.action:
					return new TableActionCtrl(this);

				case ElementType.search:
					return new SearchCtrl(this);
				case ElementType.searchfield:
					return new SearchFieldCtrl(this);
				case ElementType.searchmenuaction:
					return new SearchMenuActionCtrl(this);
				case ElementType.searchtabaction:
					return new SearchTabActionCtrl(this);
				case ElementType.searchrowaction:
					return new SearchRowActionCtrl(this);

				case ElementType.form:
					return new FormCtrl(this);
				case ElementType.formfield:
					return new FormFieldCtrl(this);
				case ElementType.formmenuaction:
					return new FormMenuActionCtrl(this);
				case ElementType.formtabuaction:
					return new FormTabActionCtrl(this);
				case ElementType.formrowaction:
					return new FormRowActionCtrl(this);
				case ElementType.linkedForm:
					return new LinkedFormCtrl(this);
				case ElementType.security:
					return new SecurityCtrl(this);
			}
			return new BaseWAFCtrl();
		}

		private BaseWAFCtrl GetControlByElementType(BaseXMLElement item)
		{
			if (item is Metastore)
			{
				return new MetastoreCtrl(this);
			}
			else if (item is Include)
			{
				return new IncludeCtrl(this);
			}
			else if (item is MetastoreString)
			{
				return new MetastoreStringCtrl(this);
			}
			else if (item is SystemString)
			{
				return new SystemStringCtrl(this);
			}

			else if (item is Table)
			{
				return new TableCtrl(this);
			}
			else if (item is TableField)
			{
				return new TableFieldCtrl(this);
			}
			else if (item is Action)
			{
				//if (item is FormMenuAction)
				//	return new FormMenuActionCtrl(this); //form action
				return new TableActionCtrl(this); //table action
			}

			else if (item is Search)
			{
				return new SearchCtrl(this);
			}
			else if (item is SearchField)
			{
				return new SearchFieldCtrl(this);
			}
			else if (item is SearchMenuAction)
			{
				return new SearchMenuActionCtrl(this);
			}
			else if (item is SearchRowAction)
			{
				return new SearchRowActionCtrl(this);
			}
			else if (item is SearchTabAction)
			{
				return new SearchTabActionCtrl(this);
			}

			else if (item is Form)
			{
				if (item is LinkedForm)
					return new LinkedFormCtrl(this);
				else
					return new FormCtrl(this);
			}
			else if (item is FormField)
			{
				return new FormFieldCtrl(this);
			}
			else if (item is FormMenuAction)
			{
				return new FormMenuActionCtrl(this); //form action
			}
			else if (item is FormTabAction)
			{
				return new FormTabActionCtrl(this); //table action
			}
			else if (item is FormRowAction)
			{
				return new FormRowActionCtrl(this); //table action
			}

			else if (item is Security)
			{
				return new SecurityCtrl(this);
			}

			//any control fits to selected element type 
			return null; //return new BaseWAFCtrl();
		}

		/// <summary>
		/// Get short description of parent element. For example: TABLE "CUSTOMER", FORM "CANDIDATE"
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		internal string GetParentElementDescription(CommandType command = CommandType.Update)
		{
			var parentElement = ((command == CommandType.New) ? CurrentNode.Tag : CurrentNode.Parent.Tag) as BaseXMLElement;

			var description = parentElement != null
															 ? "parent : " + parentElement.GetType().Name.ToUpper() + " " + parentElement.Name
															 : "";
			return description;
		}

		/// <summary>
		/// 
		/// </summary>
		private void RefreshElementData(BaseXMLElement elementData)
		{
			//TODO: to force whole process of edited data loading. It tends like refresh 
			if (EditEvent != null)
				EditEvent(elementData);

			////1. OR update data in current element control (table, form)
			//EditableWAFCtrl.Data = elementData;
			//EditableWAFCtrl.Invalidate(true);

			////2. OR Force rebuilding all subNodes for element 
			//TreeNode theNode = GetElementNode(elementData);
			//RefreshNode(theNode);
		}

		private void ShowError(string errMessage)
		{
			MessageBox.Show(errMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		#endregion

		#region Fetch data from current metastore element

		internal IList GetAllTables()
		{
			var mainMetastore = CurrentMetastore;
			return mainMetastore != null ? mainMetastore.Tables : null;
		}

		internal IList GetTableColumns(string tablename)
		{
			var mainMetastore = CurrentMetastore;
			var table = mainMetastore.Tables.FirstOrDefault(t => t.Name.Equals(tablename));
			return table != null ? table.Fields : null;
		}

		internal IList GetTableForms(string tablename)
		{
			var mainMetastore = CurrentMetastore;
			var table = mainMetastore.Tables.FirstOrDefault(t => t.Name.Equals(tablename));
			return table != null ? table.Forms : null;
		}

		internal IList GetCurrentTableForms()
		{
			var parentTable = CurrentTable;
			return parentTable != null ? parentTable.Forms : null;
		}

		#endregion

		#region Event Handlers methods in main menu

		public void NewTemplate()
		{
			metastoreXMLTreeView.Nodes.Clear();
			if (NewEvent != null)
				NewEvent(ElementType.metastore);
		}

		public bool LoadWAFMetadataXML(string xml, bool defaultNamespaceAttribute = false)
		{
			try
			{
				CurrentMetastore = Metastore.Deserialize(xml, defaultNamespaceAttribute);
				BuildMetastoreTree(CurrentMetastore);
			}
			catch (Exception ex)
			{
				ShowError("Cannot parse input string " + ex.StackTrace);
				return false;
			}
			return true;
		}

		/// <summary>
		/// Save current metastore to XML file
		/// </summary>
		/// <param name="fileName"></param>
		public void SaveToXMLFile(string fileName)
		{
			try
			{
				CurrentMetastore.SaveToXMLFile(fileName, true); //BaseXMLElement.Serialize(CurrentMetastore, fileName);
			}
			catch (Exception ex)
			{
				ShowError(ex.Message);
			}
		}

		/// <summary>
		/// Save current element to XML file
		/// </summary>
		/// <param name="element"></param>
		/// <param name="fileName"></param>
		public void SaveCurrentElementToXMLFile(string fileName)
		{
			var currentElement = CurrentNode.Tag as BaseXMLElement;
			SaveToXMLFile(currentElement, fileName);
		}

		public void SaveToXMLFile(BaseXMLElement element, string fileName)
		{
			element.SaveToXMLFile(fileName);
		}

		#endregion

		#region Event Handlers to add\edit\remove element in Metastore XML

		public void OnCreateElement(ElementType elementType)
		{
			//1. Init control by element type
			var newEditableWAFCtrl = GetControlByElementType(elementType);

			//2.Load data to control
			//EditableWAFCtrl.Action = ActionType.New;
			newEditableWAFCtrl.BeginAdd();
			newEditableWAFCtrl.IsDataLoaded = true; // for new element default data already loaded

			//3. Show New dialog
			var newForm = new NewElementFrame(newEditableWAFCtrl);
			if (newForm.ShowDialog() == DialogResult.OK)
			{
				//TODO: Update info about newly added element (in Metastore and navigationTree)
				var data = newEditableWAFCtrl.Data;
				RefreshElementData(data);
			}
			newForm.Close();
		}

		public void OnDeleteElement(BaseXMLElement item)
		{
			// Update xml element data
			//1 Update Metastore subElements data
			if (item is Include)
				CurrentMetastore.RemoveInclude((Include)item);
			else if (item is MetastoreString)
				CurrentMetastore.RemoveString((MetastoreString)item);
			else if (item is SystemString)
				CurrentMetastore.RemoveSystemString((SystemString)item);
			else if (item is Table)
				CurrentMetastore.RemoveTable((Table)item);

			//2. Update table subElements data
			if (item is TableField)
				CurrentTable.RemoveField((TableField)item);
			else if (item is Action)
			{
				//if (item is FormMenuAction)
				//	CurrentForm.RemoveFormMenuAction((FormMenuAction)item);
				//else
				CurrentTable.RemoveAction((Action)item);
			}
			//3. Form subElements
			else if (item is Form)
			{
				if (item is LinkedForm)
					CurrentForm.RemoveLinkedForm((LinkedForm)item);
				else
					CurrentTable.RemoveForm((Form)item);
			}
			else if (item is FormField)
				CurrentForm.RemoveFormField((FormField)item);
			else if (item is FormMenuAction)
				CurrentForm.RemoveFormMenuAction((FormMenuAction)item);
			else if (item is FormRowAction)
				CurrentForm.RemoveFormRowAction((FormRowAction)item);
			else if (item is FormTabAction)
				CurrentForm.RemoveFormTabAction((FormTabAction)item);

			//4. Search subElements
			else if (item is Search)
				CurrentTable.RemoveSearch((Search)item);
			else if (item is SearchField)
				CurrentSearch.RemoveSearchField((SearchField)item);
			else if (item is SearchMenuAction)
				CurrentSearch.RemoveSearchMenuAction((SearchMenuAction)item);
			else if (item is SearchRowAction)
				CurrentSearch.RemoveSearchRowAction((SearchRowAction)item);
			else if (item is SearchTabAction)
				CurrentSearch.RemoveSearchTabAction((SearchTabAction)item);

			//5.TODO: Remove SECURITY from table, form, search, actions
			else if (item is Security)
			{
				var security = (Security)item;
				//dynamic parentElement = CurrentElement;
			  //parentElement.RemoveSecurity(security);

				if (CurrentElement is Table) //table
					((Table)CurrentElement).RemoveSecurity(security);
				if (CurrentElement is Action) //table action
					((Action)CurrentElement).RemoveSecurity(security);
				if (CurrentElement is TableField) //table field
					((TableField)CurrentElement).RemoveSecurity(security);

				if (CurrentElement is Form)
					((Form)CurrentElement).RemoveSecurity(security);
				if (CurrentElement is FormField)
					((FormField)CurrentElement).RemoveSecurity(security);
				if (CurrentElement is FormMenuAction)
					((FormMenuAction)CurrentElement).RemoveSecurity(security);

				if (CurrentElement is Search)
					((Search)CurrentElement).RemoveSecurity(security);
				if (CurrentElement is SearchField)
					((SearchField)CurrentElement).RemoveSecurity(security);
				if (CurrentElement is SearchMenuAction)
					((SearchMenuAction)CurrentElement).RemoveSecurity(security);
			}

			//2. REMOVE this node from tree view and navigate previous one
			RemoveElementTreeNode(item); //RefreshNode(CurrentNode);	
		}

		public void OnUpdate(BaseXMLElement data)
		{
			if (CurrentNode != null)
			{
				//1.Update Tree View
				CurrentNode.Tag = data;
				CurrentNode.Text = data.ToString();

				//2. Update Metastore subElements Data
				if (data is Include)
				{
					var metastore = CurrentParent as Metastore;
					if (metastore != null)
					{
						int currIncludeIndex = metastore.Includes.IndexOf((Include)data);
						if (currIncludeIndex > -1)
						{
							metastore.Includes[currIncludeIndex] = data as Include;
						}
					}
				}
				else if (data is MetastoreString)
				{
					var metastore = CurrentParent as Metastore;
					if (metastore != null)
					{
						int currStringIndex = metastore.Strings.IndexOf((MetastoreString)data);
						if (currStringIndex > -1)
						{
							metastore.Strings[currStringIndex] = data as MetastoreString;
						}
					}
				}
				else if (data is SystemString)
				{
					var metastore = CurrentParent as Metastore;
					if (metastore != null)
					{
						int currSSIndex = metastore.SystemStrings.IndexOf((SystemString)data);
						if (currSSIndex > -1)
						{
							metastore.SystemStrings[currSSIndex] = data as SystemString;
						}
					}
				}
				//2. Update Table and its subElements Data
				if (data is Table)
				{
					//TODO:
					var metastore = CurrentParent as Metastore;
					if (metastore != null)
					{
						int currTableIndex = metastore.Tables.IndexOf((Table)data);
						if (currTableIndex > -1)
						{
							metastore.Tables[currTableIndex] = data as Table;
						}
					}
				}
				else if (data is Action)
				{
					var table = CurrentParent as Table;
					if (table != null)
					{
						int currActionIndex = table.Actions.IndexOf((Action)data);
						if (currActionIndex > -1)
						{
							table.Actions[currActionIndex] = data as Action;
						}
					}
				}
				else if (data is TableField)
				{
					var table = CurrentParent as Table;
					if (table != null)
					{
						int currFieldIndex = table.Fields.IndexOf((TableField)data);
						if (currFieldIndex > -1)
						{
							table.Fields[currFieldIndex] = data as TableField;
						}
					}
				}
				//TODO:
				else if (data is Form)
				{
					if (CurrentParent is Table)
					{
						var parentEntity = (Table)CurrentParent;
						int currFormIndex = parentEntity.Forms.IndexOf((Form)data);
						parentEntity.Forms[currFormIndex] = data as Form;
					}
					else if (CurrentParent is Form)
					{
						var parentForm = (Form)CurrentParent;
						if (data is LinkedForm)//LinkedForm
						{
							int currLinkedFormIndex = parentForm.LinkedForms.IndexOf((LinkedForm)data);
							parentForm.LinkedForms[currLinkedFormIndex] = data as LinkedForm;
						}
					}
				}
				else if (data is Search)
				{
					if (CurrentParent is Table)
					{
						var parentTable = (Table)CurrentParent;

						int currSearchIndex = parentTable.Searches.IndexOf((Search)data);

						if (currSearchIndex > -1)
						{
							parentTable.Searches[currSearchIndex] = data as Search;
						}
					}
				}
				else if (data is SearchField)
				{
					var search = CurrentParent as Search;
					if (search != null)
					{
						int currFieldIndex = search.SearchFields.IndexOf((SearchField)data);
						if (currFieldIndex > -1)
						{
							search.SearchFields[currFieldIndex] = data as SearchField;
						}
					}
				}
				else if (data is SearchMenuAction)
				{
					var search = CurrentParent as Search;
					if (search != null)
					{
						int currSearchMenuActionIndex = search.SearchMenuActions.IndexOf((SearchMenuAction)data);
						if (currSearchMenuActionIndex > -1)
						{
							search.SearchMenuActions[currSearchMenuActionIndex] = data as SearchMenuAction;
						}
					}
				}
				else if (data is SearchRowAction)
				{
					var search = CurrentParent as Search;
					if (search != null)
					{
						int currSearchRowActionIndex = search.SearchRowActions.IndexOf((SearchRowAction)data);
						if (currSearchRowActionIndex > -1)
						{
							search.SearchRowActions[currSearchRowActionIndex] = data as SearchRowAction;
						}
					}
				}
				else if (data is SearchTabAction)
				{
					var search = CurrentParent as Search;
					if (search != null)
					{
						int currSearchTabActionIndex = search.SearchTabActions.IndexOf((SearchTabAction)data);
						if (currSearchTabActionIndex > -1)
						{
							search.SearchTabActions[currSearchTabActionIndex] = data as SearchTabAction;
						}
					}
				}
			}
		}

		public void OnEditElement(BaseXMLElement item)
		{
			//Force navigate tree node 
			NavigateElementNode(item);
		}

		private void BeginEditElement(BaseXMLElement item)
		{
			//1. Clear previous control
			mainSplitContainer.Panel2.Controls.Clear();

			//2. Load suitable GUI control by element type
			EditableWAFCtrl = GetControlByElementType(item);

			//add editable control to the informational panel
			if (EditableWAFCtrl != null)
			{
				mainSplitContainer.Panel2.Controls.Add(EditableWAFCtrl);
				EditableWAFCtrl.Dock = DockStyle.Fill;

				// Load data to control 
				EditableWAFCtrl.BeginEdit(item);
			}
		}

		#endregion

		#region Event Handlers for content menu in Metastore XML Tree

		private void InitContextMenu(BaseXMLElement selectedItem)
		{
			//refreshToolStripMenuItem.Visible =
			deleteToolStripMenuItem.Visible =
			saveToXMLToolStripMenuItem.Visible =
			selectedItem != null;

			if (selectedItem is Metastore)
			{
				//deleteToolStripMenuItem.Visible = true;

				newToolStripMenuItem.Visible = true;

				//Metastore menus
				newIncludeToolStripMenuItem.Visible =
				newStringToolStripMenuItem.Visible =
				newSystemStringToolStripMenuItem.Visible =
				newTableToolStripMenuItem.Visible = true;

				//Table related  sub-menus
				newActionToolStripMenuItem.Visible = false;
				newFieldToolStripMenuItem.Visible = false;

				//Form related  sub-menus
				newFormToolStripMenuItem.Visible = false;
				newFormMenuActionStripMenuItem.Visible = false;
				newFormFieldToolStripMenuItem.Visible = false;
				newLinkedFormToolStripMenuItem.Visible = false;

				//Search related sub-menus
				newSearchToolStripMenuItem.Visible = false;
				newSearchFieldToolStripMenuItem.Visible = false;
			}
			else if (selectedItem is Table)
			{
				//deleteToolStripMenuItem.Visible = true;

				newToolStripMenuItem.Visible = true;

				//Metastore menus
				newIncludeToolStripMenuItem.Visible =
				newStringToolStripMenuItem.Visible =
				newSystemStringToolStripMenuItem.Visible =
				newTableToolStripMenuItem.Visible = false; //cannot be table under table

				//Table menus
				newActionToolStripMenuItem.Visible = true;
				newFieldToolStripMenuItem.Visible = true;
				newFormToolStripMenuItem.Visible = true;
				newSearchToolStripMenuItem.Visible = true;

				//Form related sub-menus
				newFormMenuActionStripMenuItem.Visible = false;
				newFormFieldToolStripMenuItem.Visible = false;
				newLinkedFormToolStripMenuItem.Visible = false;

				//Search related sub-menus
				newSearchFieldToolStripMenuItem.Visible = false;
			}
			else if (selectedItem is Search)
			{
				//deleteToolStripMenuItem.Visible = true;

				//Search menus
				newToolStripMenuItem.Visible = true;
				newSearchFieldToolStripMenuItem.Visible = true;
				newSearchToolStripMenuItem.Visible = false;

				//Metastore menus
				newIncludeToolStripMenuItem.Visible =
				newStringToolStripMenuItem.Visible =
				newSystemStringToolStripMenuItem.Visible =
				newTableToolStripMenuItem.Visible = false;

				//Table related sub-menus
				newActionToolStripMenuItem.Visible = false;
				newFieldToolStripMenuItem.Visible = false;

				//Form related sub-menus
				newFormToolStripMenuItem.Visible = false;
				newFormMenuActionStripMenuItem.Visible = false;
				newFormFieldToolStripMenuItem.Visible = false;
				newLinkedFormToolStripMenuItem.Visible = false;
			}
			else if (selectedItem is Form)
			{
				deleteToolStripMenuItem.Visible = true;

				newToolStripMenuItem.Visible =
				newFormMenuActionStripMenuItem.Visible =
				newFormFieldToolStripMenuItem.Visible =
				newLinkedFormToolStripMenuItem.Visible = !(selectedItem is LinkedForm);
				newFormToolStripMenuItem.Visible = false;

				//Metastore menus
				newIncludeToolStripMenuItem.Visible =
				newStringToolStripMenuItem.Visible =
				newSystemStringToolStripMenuItem.Visible =
				newTableToolStripMenuItem.Visible = false;

				//Search menus
				newSearchFieldToolStripMenuItem.Visible = false;
				newSearchToolStripMenuItem.Visible = false;
				//newSearchActionStripMenuItem.Visible = false;

				//Table related sub-menus
				newTableToolStripMenuItem.Visible = false;
				newActionToolStripMenuItem.Visible = false;
				newFieldToolStripMenuItem.Visible = false;
			}
			else if (selectedItem is Action || selectedItem is FormMenuAction
						|| selectedItem is TableField || selectedItem is FormField || selectedItem is SearchField)
			{
				newToolStripMenuItem.Visible = false;
			}
			else
			{
				//Context menu visible only if selected item is defined (not empty)
				//fetchXMLTreeContextMenuStrip.Visible = false;
				newToolStripMenuItem.Visible = false;
				//	actionToolStripMenuItem.Visible = false;
				//	fieldToolStripMenuItem.Visible = true;
				//	formToolStripMenuItem.Visible = true;
				//	linkedFormToolStripMenuItem.Visible = false;
			}
		}

		private void metastoreXMLTreeView_BeforeSelect(object sender, TreeViewCancelEventArgs e)
		{
			if (CurrentNode != null)
			{
				CurrentNode.BackColor = Color.White;
			}
		}

		private void metastoreXMLTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			//1.
			CurrentNode.BackColor = Color.LightBlue;
			// mainSplitContainer.Panel2.Controls.Clear();

			//2.
			if (EditEvent != null)
			{
				var nodeData = GetSelectedNodeData();

				//2.1 Init TreeView Context Menu
				InitContextMenu(nodeData);

				//2.2  Load edited data
				EditEvent(nodeData);
			}
		}

		private void newTableToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.table);
		}

		private void newSearchToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.search);
		}

		private void newSearchFieldToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.search);
		}

		private void actionToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.action);
		}

		private void fieldToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.tablefield);
		}

		private void formToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.form);
		}

		private void formMenuActionStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.formmenuaction);
		}

		private void formFieldToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.formfield);
		}

		private void linkFormToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.linkedForm);
		}

		private void newIncludeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.include);
		}

		private void newStringToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.metastorestring);

		}
		private void newSystemStringToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (NewEvent != null)
				NewEvent(ElementType.systemstring);
		}

		private void saveToXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var fd = new SaveFileDialog())
			{
				fd.Filter = "*.xml|*.xml";
				if (fd.ShowDialog() == DialogResult.OK)
				{
					this.SaveCurrentElementToXMLFile(fd.FileName);

					if (MessageBox.Show("Open saved file ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					{
						//var stream = fd.OpenFile();
						LoadFileInNotepad(fd.FileName);
					}
				}

			}
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Full rebuild the current node and its subnodes 
			RefreshCurrentNode();
		}

		private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
		{
			if (DialogResult.Yes ==
					MessageBox.Show("Are you sure to remove the node ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
			{
				if (DeleteEvent != null)
				{
					var nodeData = GetSelectedNodeData();
					DeleteEvent(nodeData);
				}
			}
		}

		#endregion

		#region Tree methods : build tree\add\remove node

		public TreeNode BuildMetastoreTree(Metastore metastore)
		{
			metastoreXMLTreeView.Nodes.Clear();

			//1. Metastore root node
			var rootNode = new TreeNode(metastore.ToString());
			rootNode.Tag = metastore;
			metastoreXMLTreeView.Nodes.Add(rootNode);

			//2. Add includes
			var includeNode = AddFakeElementToTreeViewNode(rootNode, "INCLUDES");
			if (metastore.Includes != null)
				foreach (var include in metastore.Includes)
					AddElementToTreeViewNode(includeNode, include);

			//3. Build Tables and their subnodes
			if (metastore.Tables != null)
				foreach (var table in metastore.Tables)
				{
					var tableNode = AddElementToTreeViewNode(rootNode, table);
					BuildTableSubNodes(tableNode, table);//build recursively
				}

			//4. Build metastore strings nodes
			var stringsNode = AddFakeElementToTreeViewNode(rootNode, "STRINGS");
			if (metastore.Strings != null)
				foreach (var str in metastore.Strings)
					AddElementToTreeViewNode(stringsNode, str);

			var systemStringsNode = AddFakeElementToTreeViewNode(rootNode, "SYSTEMSTRINGS");
			if (metastore.SystemStrings != null)
				foreach (var str in metastore.SystemStrings)
					AddElementToTreeViewNode(systemStringsNode, str);

			//5. Navigate root metastore node
			//NavigateNode(rootNode);

			//6.Expand tree
			rootNode.Expand();

			return rootNode;
		}

		private void BuildTableSubNodes(TreeNode tableNode, Table table)
		{
			//1. Add fields
			foreach (var field in table.Fields)
				AddElementToTreeViewNode(tableNode, field); //and SECURITY

			//2. Add actions
			foreach (var action in table.Actions)
				AddElementToTreeViewNode(tableNode, action); //and SECURITY

			//3. Add Forms
			foreach (var form in table.Forms)
			{
				var rootFormNode = AddElementToTreeViewNode(tableNode, form);
				BuildFormSubNodes(rootFormNode, form);
			}

			//4. Add Searches
			foreach (var search in table.Searches)
			{
				var rootSearchNode = AddElementToTreeViewNode(tableNode, search);
				BuildSearchSubNodes(rootSearchNode, search);
			}
		}

		private void BuildSearchSubNodes(TreeNode searchNode, Search search)
		{
			//1. Add search security
			foreach (var security in search.SearchSecurity)
				AddElementToTreeViewNode(searchNode, security);
			//2. Add search fields
			foreach (var field in search.SearchFields)
				AddElementToTreeViewNode(searchNode, field);

			//3.1 Add search menu actions
			foreach (var menuaction in search.SearchMenuActions)
				AddElementToTreeViewNode(searchNode, menuaction);
			//3.2 Add search row actions
			foreach (var rowaction in search.SearchRowActions)
				AddElementToTreeViewNode(searchNode, rowaction);
			//3.3 Add search tab actions
			foreach (var tabaction in search.SearchTabActions)
				AddElementToTreeViewNode(searchNode, tabaction);
		}

		private void BuildFormSubNodes(TreeNode formNode, Form form)
		{
			//1. Add form security
			foreach (var security in form.Security)
				AddElementToTreeViewNode(formNode, security);

			//2. Add form fields
			foreach (var field in form.FormFields)
				AddElementToTreeViewNode(formNode, field);

			//3.1 Add form menu actions
			foreach (var menuaction in form.FormMenuActions)
				AddElementToTreeViewNode(formNode, menuaction);
			//3.2 Add form row actions
			foreach (var rowaction in form.FormRowActions)
				AddElementToTreeViewNode(formNode, rowaction);
			//3.3 Add form tab actions
			foreach (var tabaction in form.FormTabActions)
				AddElementToTreeViewNode(formNode, tabaction);

			//4. Add Linked Forms
			foreach (var linkedForm in form.LinkedForms)
			{
				var rootFormNode = AddElementToTreeViewNode(formNode, linkedForm);
				BuildLinkedFormSubNodes(rootFormNode, linkedForm);
			}
		}

		private void BuildLinkedFormSubNodes(TreeNode rootLinkEntityNode, LinkedForm linkedForm)
		{
			BuildFormSubNodes(rootLinkEntityNode, linkedForm);
		}

		private BaseXMLElement GetSelectedNodeData()
		{
			if (metastoreXMLTreeView.SelectedNode != null)
			{
				var item = metastoreXMLTreeView.SelectedNode.Tag as BaseXMLElement;
				return item;
			}
			return null;
		}

		private TreeNode GetElementNode(BaseXMLElement elem, TreeNode fromCurrentNode = null, bool searchFromRoot = false)
		{
			// look from the root TreeNode of treeView 
			if (searchFromRoot)
			{
				var rootNode = metastoreXMLTreeView.Nodes[0];
				var metastoreSubNodes = rootNode.Nodes.Find(elem.Name, true);
				//metastoreXMLTreeView.Nodes.Cast<TreeNode>().FirstOrDefault(childNode => childNode.Tag != null && childNode.Tag.Equals(elem));

				return metastoreSubNodes.Any()
							? metastoreSubNodes[0]
							: GetElementNode(elem, rootNode); //recursion by subnodes
			}
			//else
			if (fromCurrentNode == null)
				fromCurrentNode = CurrentNode; // Set to currently selected node

			if (fromCurrentNode != null)
			{
				if (fromCurrentNode.Tag != null && fromCurrentNode.Tag.Equals(elem))
					return fromCurrentNode;

				foreach (TreeNode subNode in fromCurrentNode.Nodes.AsParallel())
				{
					var node = GetElementNode(elem, subNode);
					if (node != null)
						return node;
				}
			}

			return null;
		}

		public TreeNode AddElementToTreeViewNode(TreeNode parentNode, BaseXMLElement childElement)
		{
			var childNode = parentNode.Nodes.Add(childElement.ToString());
			childNode.Tag = childElement;
			return childNode;
		}

		private TreeNode AddFakeElementToTreeViewNode(TreeNode parentNode, string nodename)
		{
			var childNode = parentNode.Nodes.Add(nodename, nodename);
			childNode.Tag = nodename;
			return childNode;
		}

		private void RemoveElementTreeNode(BaseXMLElement element)
		{
			//1. remove from tree
			TreeNode node = GetElementNode(element);

			if (node != null)
			{
				//save previous node
				var prevNode = node.Parent; //CurrentNode.PrevNode ?? CurrentNode.Parent;
				//deselect navigation in tree
				NavigateNode(null);
				//remove node
				RemoveTreeNode(node);

				//2. Navigate previous node
				NavigateNode(prevNode);
			}
		}

		private void RemoveTreeNode(TreeNode node)
		{
			metastoreXMLTreeView.Nodes.Remove(node);
			metastoreXMLTreeView.Invalidate();
		}


		/// <summary>
		///TODO: Update control by rebuilding all nodes from current node (if add\remove)
		/// (slow operation)
		/// </summary>
		/// <param name="node"></param>
		private void RefreshCurrentNode()
		{
			TreeNode node = CurrentNode;
			if (node == null) return;

			//Rebuild sub nodes
			var elementData = node.Tag as BaseXMLElement;

			RefreshElementNode(node, elementData);

			//if (elementData != null)
			//{
			//	//Clear child nodes
			//	node.Nodes.Clear();

			//	if (elementData is Metastore)
			//		BuildMetastoreTree((Metastore)elementData);
			//	if (elementData is Table)
			//		BuildTableSubNodes(node, (Table)elementData);
			//	if (elementData is Search)
			//		BuildSearchSubNodes(node, (Search)elementData);
			//	if (elementData is Form)
			//	{
			//		if (elementData is LinkedForm)
			//			BuildLinkedFormSubNodes(node, (LinkedForm)elementData);
			//		else
			//			BuildFormSubNodes(node, (Form)elementData);
			//	}
			//	//Refresh node tag with element data
			//	node.Tag = elementData;

			//	//Navigate node
			//	NavigateNode(node);
			//}
		}

		internal void RefreshElementNode(TreeNode node, BaseXMLElement elementData)
		{
			if (node == null) return;

			//Rebuild sub nodes
			if (elementData != null)
			{
				//Clear child nodes
				node.Nodes.Clear();

				if (elementData is Metastore)
					BuildMetastoreTree((Metastore)elementData);
				if (elementData is Table)
					BuildTableSubNodes(node, (Table)elementData);
				if (elementData is Search)
					BuildSearchSubNodes(node, (Search)elementData);
				if (elementData is Form)
				{
					if (elementData is LinkedForm)
						BuildLinkedFormSubNodes(node, (LinkedForm)elementData);
					else
						BuildFormSubNodes(node, (Form)elementData);
				}
				//Refresh node tag with element data
				node.Tag = elementData;

				//Navigate node
				NavigateNode(node);
			}
		}

		public void NavigateNode(TreeNode node)
		{
			metastoreXMLTreeView.SelectedNode = node;
			metastoreXMLTreeView.Refresh();
		}

		/// <summary>
		/// Find element of the node and navigate it
		/// </summary>
		/// <param name="element"></param>
		public void NavigateElementNode(BaseXMLElement element, bool searchFromRoot = false)
		{
			var node = GetElementNode(element, null, searchFromRoot);
			NavigateNode(node);
		}

		/// <summary>
		/// Navigate to the tree node that is parrent to the current
		/// </summary>
		public void NavigateToParentElement()
		{
			if (CurrentNode != null && CurrentNode.Parent != null)
				NavigateNode(CurrentNode.Parent);
			//NavigateElementNode(CurrentParent);
		}

		public void NavigateTableByName(string tableName)
		{
			var tableElement = CurrentMetastore.Tables.FirstOrDefault(t => t.Name.Equals(tableName));
			NavigateElementNode(tableElement, true);
		}

		public void NavigateFormByName(string tableName, string formName)
		{
			var tableElement = CurrentMetastore.Tables.FirstOrDefault(t => t.Name.Equals(tableName));
			var formElement = tableElement.Forms.FirstOrDefault(t => t.Name.Equals(formName));
			NavigateElementNode(formElement, true);
		}

		#endregion

		#region Other

		private static string _notepadpath = "";

		public static string Notepadpath
		{
			get
			{
				if (string.IsNullOrEmpty(_notepadpath))
				{
					_notepadpath = @"C:\Windows\System32\Notepad.exe";
				}
				return _notepadpath;
			}
		}

		private void LoadFileInNotepad(string path)
		{
			try
			{
				// Start wordpad
				var wordPad = new System.Diagnostics.Process();
				if (!string.IsNullOrEmpty(Notepadpath))
				{
					wordPad.StartInfo.FileName = Notepadpath;
					//@"C:\Program Files\Windows NT\Accessories\WORDPAD.EXE";
					wordPad.StartInfo.Arguments = path;
					wordPad.StartInfo.UseShellExecute = false;
					wordPad.Start();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}


		#endregion

		#endregion
	}
}