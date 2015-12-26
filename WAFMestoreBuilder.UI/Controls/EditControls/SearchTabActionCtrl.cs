using System;
using System.Collections.Generic;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;
using Action = WAFMetastoreBuilder.WAFMetastoreElements.Action;

namespace WAFMetastoreBuilder.UI
{
	public partial class SearchTabActionCtrl : BaseWAFCtrl
	{
		private SearchTabAction _action;

		#region Ctor

		public SearchTabActionCtrl(WafXMLDesignerControl parentCtrl)
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
				_action = (SearchTabAction)elementData;
				cmbAction.Text = _action.Name;
				//BindingHelper.LoadSecurityFromSource(lbSecurity, _action.Security);
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_action == null)
				_action = new SearchTabAction();//if new
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
			var parentSearch = ParentDesignerCtrl.CurrentTable;
			return parentSearch != null ? parentSearch.Actions : null;
		}

		private List<SearchTabAction> GetCurrentSearchTabActions()
		{
			var parentSearch = ParentDesignerCtrl.CurrentSearch;
			return parentSearch != null ? parentSearch.SearchTabActions : null;
		}

		#endregion
	}
}
