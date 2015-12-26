using System;
using System.Collections.Generic;
using WAFMetastoreBuilder.WAFMetastoreElements;
using Action = WAFMetastoreBuilder.WAFMetastoreElements.Action;

namespace WAFMetastoreBuilder.UI
{
	public partial class FormTabActionCtrl : BaseWAFCtrl
	{
		private FormTabAction _action;

		#region Ctor

		public FormTabActionCtrl(WafXMLDesignerControl parentCtrl)
			: base(parentCtrl)
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		protected override void LoadDataToCtrl(BaseXMLElement elementData)
		{
			base.LoadDataToCtrl(elementData);

			if (elementData != null)
			{
				_action = (FormTabAction)elementData;

				//BindingHelper.LoadSecurityFromSource(lbSecurity, _action.Security);
				cmbAction.Text = _action.Name;
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_action == null)
				_action = new FormTabAction();//if new

			_action.Name = cmbAction.Text;
			//_action.Security = (List<Security>)lbSecurity.DataSource;

			return _action;
		}

		/// <summary>
		/// To Create New Control
		/// </summary>
		protected override void InitDefaultData()
		{
			base.InitDefaultData();

			List<Action> allActions = GetParentTableActions();
			//IList<string> usedActions = GetCurrentSearchRowActions();
			//IList availableActions = allActions.SkipWhile(aa => usedActions.Contains(aa.Name)).ToList();
			//display only unused actions
			//BindingHelper.LoadActionsFromSource(cmbAction, availableActions);
			BindingHelper.LoadActionsFromSource(cmbAction, allActions);
		}

		private List<Action> GetParentTableActions()
		{
			var parentTable = ParentDesignerCtrl.CurrentTable;
			return parentTable != null ? parentTable.Actions : null;
		}

		private List<FormTabAction> GetCurrentFormTabActions()
		{
			var parentForm = ParentDesignerCtrl.CurrentForm;
			return parentForm != null ? parentForm.FormTabActions  : null;
		}
		#endregion
	}
}
