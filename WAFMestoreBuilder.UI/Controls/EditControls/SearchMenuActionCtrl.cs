using System.Collections.Generic;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	public partial class SearchMenuActionCtrl : BaseWAFCtrl
	{
		private SearchMenuAction _field;

		#region Ctor

		public SearchMenuActionCtrl(WafXMLDesignerControl parentCtrl)
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
				_field = (SearchMenuAction)elementData;

				//BindingHelper.LoadSecurityFromSource(lbSecurity, _field.Security);

				cmbActionName.Text = _field.Name;
				txtSearchName.Text = _field.SearchName;
				txtLabel.Text = _field.Label;

				txtTableName.Text = _field.TableName;
				cmbAction.Text = _field.Action;
				txtURL.Text = _field.Url;

				ckbSubmitSearchForm.Checked = _field.SubmitSearchForm;
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_field == null)
				_field = new SearchMenuAction();//if new

			//_field.Security = (List<Security>)lbSecurity.DataSource;

			_field.Name = cmbActionName.Text;

			_field.SearchName = txtSearchName.Text;
			_field.Label = txtLabel.Text;

			_field.TableName = txtTableName.Text;
			_field.Action = cmbAction.Text;
			_field.Url = txtURL.Text;

			_field.SubmitSearchForm = ckbSubmitSearchForm.Checked;

			return _field;
		}


		protected override void InitDefaultData()
		{
			base.InitDefaultData();

			BindingHelper.LoadActionsFromSource(cmbActionName, GetParentTableActions());
		}

		private List<Action> GetParentTableActions()
		{
			var parentTable = ParentDesignerCtrl.CurrentTable;
			return parentTable != null ? parentTable.Actions : null;
		}

		private List<SearchMenuAction> GetCurrentSearchMenuActions()
		{
			var parentSearch = ParentDesignerCtrl.CurrentSearch;
			return parentSearch != null ? parentSearch.SearchMenuActions : null;
		}

		#endregion
	}
}

