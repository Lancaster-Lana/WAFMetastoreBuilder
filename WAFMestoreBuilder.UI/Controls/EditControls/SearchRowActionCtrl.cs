using System.Collections.Generic;
using System.Linq;
using WAFMetastoreBuilder.WAFMetastoreElements;
using Action = WAFMetastoreBuilder.WAFMetastoreElements.Action;

namespace WAFMetastoreBuilder.UI
{
	public partial class SearchRowActionCtrl : BaseWAFCtrl
	{
		private SearchRowAction _action;

		#region Ctor

		public SearchRowActionCtrl(WafXMLDesignerControl parentCtrl)
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
				_action = (SearchRowAction)elementData;

				cmbAction.Text = _action.Name;
				//BindingHelper.LoadSecurityFromSource(lbSecurity, _action.Security);
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_action == null)
				_action = new SearchRowAction();//if new

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

		/// <summary>
		/// Get already added actions
		/// </summary>
		/// <returns></returns>
		private IList<string> GetCurrentSearchRowActions()
		{
			var parentSearch = ParentDesignerCtrl.CurrentSearch;
			return (parentSearch != null && parentSearch.SearchRowActions != null) 
							? parentSearch.SearchRowActions.Select(a => a.Name).ToList() 
							: null;
		}

		#endregion
	}
}
