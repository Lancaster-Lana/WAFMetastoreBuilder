
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	public partial class FormMenuActionCtrl : BaseWAFCtrl
	{
		#region Ctor

		public FormMenuActionCtrl(WafXMLDesignerControl parentCtrl)
			: base(parentCtrl)
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		protected override void InitDefaultData()
		{
			//var allActions = GetParentTableActions();
			//EditManagerHelper.LoadActionsFromSource(lbAvailableActions, allActions);
			//EditManagerHelper.LoadActionsFromSource(lbVisibleActions, _);
		}

		protected override void OnLoad(System.EventArgs e)
		{
			base.OnLoad(e);
			InitActions();
		}

		private void InitActions()
		{
			//1 Load visible MenuActions to target list
			var visibleMenuActions = GetCurrentFormActions();
			if (visibleMenuActions != null)
			{
				visibleMenuActions.Sort();
				BindingHelper.LoadActionsFromSource(lbVisibleActions, visibleMenuActions);
			}
			else
				visibleMenuActions = new List<FormMenuAction>();

			//2. All available parent table actions, but not visible in form menu
			List<Action> availableParentTableActions = GetParentTableActions();	// WAFMetastoreHelper.GetTableActions(ParentCtrl.CurrentTable.Name);//
			//exclude used actions
			if (availableParentTableActions != null)
			{
				availableParentTableActions =
					availableParentTableActions.Where(action => !visibleMenuActions.Exists(ma => ma.Name.Equals(action.Name))).ToList();
				availableParentTableActions.Sort();
				BindingHelper.LoadActionsFromSource(lbAvailableActions, availableParentTableActions);

				//if (availableParentTableActions.Count == 0)
				//	MessageBox.Show("You cannot choose action, because parent table does not have any !", "Warning",
				//		MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		protected override void LoadDataToCtrl(BaseXMLElement element)
		{
			base.LoadDataToCtrl(element);

			if (element is FormMenuAction)
			{
				//deselect the first list 
				lbAvailableActions.SelectedIndex = -1;

				//Navigate current menu action in the second list
				var action = (FormMenuAction)element;
				lbVisibleActions.SelectedValue = action.Name;
			}
		}

		//protected override BaseXMLElement GetDataFromCtrl()
		//{
		//	var visibleLst = (List<FormMenuAction>)lbVisibleActions.DataSource;
		//	return base.GetDataFromCtrl();
		//}

		/// <summary>
		/// Specific implementation
		/// </summary>
		protected override void OnAdd()
		{
			OnUpdate();
		}

		protected override void OnUpdate()
		{
			//Selected and removed actions lists
			var visibleLst = (List<FormMenuAction>)lbVisibleActions.DataSource;
			var restAvailableLst = (List<Action>)lbAvailableActions.DataSource;

			//Current Form and its node (in Metastore XML tree)
			TreeNode currFormNode = ParentDesignerCtrl.CurrentFormNode; //(Command == CommandType.New) ? ParentDesignerCtrl.CurrentNode.Parent : ParentDesignerCtrl.CurrentNode;
			var currentForm = ParentDesignerCtrl.CurrentForm; //parent form data
	
			//1. Reload form menu actions lists
			IList<string> restActionsNames = restAvailableLst.Select(a => a.Name).ToList();
			currentForm.RemoveFormMenuActions(restActionsNames);//	ParentCtrl.OnDeleteElement(unusedmenuaction);				//RemoveElementTreeNode

			//2. Add new menu actions
			//currentForm.ClearFormMenuActions();
			currentForm.AddFormMenuActions(visibleLst);

			////TreeNode createdElementNode = null; // last new node - for navigation
			//foreach (var menuaction in visibleLst)
			//{
			//	if (!currentForm.FormMenuActions.Contains(menuaction))
			//	{
			//		currentForm.AddFormMenuAction(menuaction);

			//		//Add every new element to parent TreeNode
			//		//createdElementNode = ParentDesignerCtrl.AddElementToTreeViewNode(currFormNode, menuaction);
			//	}
			//}

			//3. Navigate parent(or new) form node.
			ParentDesignerCtrl.RefreshElementNode(currFormNode, currentForm);// refresh Form node by rebuild of all elements
			//ParentDesignerCtrl.NavigateNode(currFormNode);
		}

		private List<Action> GetParentTableActions()
		{
			var parentTable = ParentDesignerCtrl.CurrentTable;
			return parentTable != null ? parentTable.Actions : null;
		}

		private List<FormMenuAction> GetCurrentFormActions()
		{
			var parentForm = ParentDesignerCtrl.CurrentForm;
			return parentForm != null ? parentForm.FormMenuActions : null;
		}

		#endregion

		#region Handlers

		private void addButton_Click(object sender, System.EventArgs e)
		{
			var action = lbAvailableActions.SelectedItem as Action;

			if (action != null)
			{
				//1.Refresh target (menuactions) list 
				var visibleAttrs = new List<FormMenuAction>();
				if (lbVisibleActions.DataSource != null)
					visibleAttrs.AddRange((List<FormMenuAction>)lbVisibleActions.DataSource);
				visibleAttrs.Add(new FormMenuAction() { Name = action.Name });
				visibleAttrs.Sort();
				BindingHelper.LoadActionsFromSource(lbVisibleActions, visibleAttrs);

				//2. Refresh source (tabel actions) list       
				var availableAttrs = new List<Action>();
				if (lbAvailableActions.DataSource != null)
					availableAttrs.AddRange((List<Action>)lbAvailableActions.DataSource);
				availableAttrs.Remove(action);//((List<Action>) lbAvailableActions.DataSource).Remove(action);
				BindingHelper.LoadActionsFromSource(lbAvailableActions, availableAttrs);
			}
		}

		private void removeButton_Click(object sender, System.EventArgs e)
		{
			var menuaction = lbVisibleActions.SelectedItem as FormMenuAction;

			if(menuaction == null) return;
			
			//1. Refresh source (tabel actions) list       
			var availableActions = new List<Action>();
			if (lbAvailableActions.DataSource != null)
				availableActions.AddRange((List<Action>)lbAvailableActions.DataSource);
			availableActions.Add(new Action(menuaction.Name));
			availableActions.Sort();
			BindingHelper.LoadActionsFromSource(lbAvailableActions, availableActions);

			//2.Refresh target (menuactions) list 
			if (lbVisibleActions.DataSource != null)
			{
				var visibleActions = ((List<FormMenuAction>)lbVisibleActions.DataSource).Where(a => !a.Name.Equals(menuaction.Name)).ToList();
				//visibleActions.AddRange(visibleActions);
				//visibleActions.Remove((FormMenuAction)action.Name);
				BindingHelper.LoadActionsFromSource(lbVisibleActions, visibleActions);
			}
		}

		#endregion
	}
}
