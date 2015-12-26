using System;
using System.Collections.Generic;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;
using Action = WAFMetastoreBuilder.WAFMetastoreElements.Action;

namespace WAFMetastoreBuilder.UI
{
	public partial class FormRowActionCtrl : BaseWAFCtrl
	{
		private FormRowAction _action;

		#region Ctor

		public FormRowActionCtrl(WafXMLDesignerControl parentCtrl)
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
				_action = (FormRowAction)elementData;

				//BindingHelper.LoadSecurityFromSource(lbSecurity, _action.Security);

				cmbAction.Text = _action.Name;
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_action == null)
				_action = new FormRowAction();//if new

			_action.Name = cmbAction.Text;
			//_action.Security = (List<Security>)lbSecurity.DataSource;

			return _action;
		}

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

		private List<FormRowAction> GetCurrentFormRowActions()
		{
			var parentForm = ParentDesignerCtrl.CurrentForm;
			return parentForm != null ? parentForm.FormRowActions : null;
		}

		#endregion
	}
}
