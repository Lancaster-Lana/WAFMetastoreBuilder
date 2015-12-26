using System;
using System.Collections.Generic;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	public partial class SearchFieldCtrl : BaseWAFCtrl
	{
		private SearchField _field;

		#region Ctor

		public SearchFieldCtrl(WafXMLDesignerControl parentCtrl)
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
				_field = (SearchField) elementData;

        //TODO: security
				BindingHelper.LoadItemsFromSource(cmbSecureConnection, Enum.GetNames(typeof(SecureConnectionEnum)));
				cmbFieldName.Text = _field.Name;
			  txtLabel.Text = _field.Label;
                cmbSearchType.Text = _field.SearchType.ToString();
				ckbExcludeOnSearchForm.Checked = _field.ExcludeOnSearchForm;
                ckbExcludeOnSearchResults.Checked = _field.ExcludeOnSearchResults;
                ckbHideOnSearchForm.Checked = _field.HideOnSearchForm;
                ckbHideOnEditForm.Checked = _field.HideOnEditForm;
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_field == null)
				_field = new SearchField();//if new

			_field.Security = (List<Security>)lbSecurity.DataSource;
			_field.Name = cmbFieldName.Text;
            _field.Label = txtLabel.Text;
             SearchTypeEnum searchType;
            _field.SearchType = Enum.TryParse(cmbSearchType.Text, true, out searchType)
                                                ? searchType
                                                : SearchTypeEnum.None;

			_field.ExcludeOnSearchForm = ckbExcludeOnSearchForm.Checked;
            _field.ExcludeOnSearchResults = ckbExcludeOnSearchResults.Checked;
            _field.HideOnSearchForm = ckbHideOnSearchForm.Checked;
            _field.HideOnEditForm = ckbHideOnEditForm.Checked;
		
			return _field;
		}

		/// <summary>
		/// To Create New Control
		/// </summary>
		protected override void InitDefaultData()
		{
			base.InitDefaultData();

			BindingHelper.LoadFieldsFromSource(cmbFieldName, GetParentTableFields());
            BindingHelper.LoadItemsFromSource(cmbSearchType, Enum.GetNames(typeof(SearchTypeEnum)));
		}

		private List<TableField> GetParentTableFields()
		{
			var parentTable = ParentDesignerCtrl.CurrentTable;
			return parentTable != null ? parentTable.Fields : null;
		}

		private void btnAddSecurity_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.security);
		}

		private void btnEditSecurity_Click(object sender, EventArgs e)
		{
			var security = lbSecurity.SelectedItem as Security;
			if (security != null)
				ParentDesignerCtrl.OnEditElement(security);
		}

		private void btnDeleteSecurity_Click(object sender, EventArgs e)
		{
			var security = lbSecurity.SelectedItem as Security;
			if (security != null)
				ParentDesignerCtrl.OnDeleteElement(security);
		}

		#endregion
	}
}

