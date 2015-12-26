using System;
using System.Collections.Generic;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;


namespace WAFMetastoreBuilder.UI
{
    public partial class TableFieldCtrl : BaseWAFCtrl
    {
        private TableField _field;

        #region Ctor

        public TableFieldCtrl(WafXMLDesignerControl parentCtrl)
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
                _field = (TableField)elementData;

                BindingHelper.LoadSecurityFromSource(lbSecurity, _field.Security);

                txtName.Text = _field.Name;
                txtAttributeName.Text = _field.AttributeName;
                txtLabel.Text = _field.Label;
                txtComment.Text = _field.Comment;

                cbReadOnly.Checked = _field.ReadOnly;
                cbRequired.Checked = _field.Required;

                cmbFieldType.Text = _field.FieldType.ToString();
                cmbFieldTarget.Text = _field.FieldTarget.ToString();
                txtFieldSource.Text = _field.FieldSource;

                //unneccessary
                cmbValidValuesType.Text = _field.ValidValuesType.ToString();
                txtValidValues.Text = _field.ValidValues;

                txtDBColumnName.Text = _field.DBColumnName;
                txtFKAdditionalWhereClause.Text = _field.FK_AdditionalWhereClause;
                txtFKOrderClause.Text = _field.FK_OrderClause;

                txtReqularExpression.Text = _field.ReqularExpression;
                txtReqularExpressionErrorText.Text = _field.ReqularExpressionErrorText;

                cmbSearchType.Text = _field.SearchType.ToString();
                ckbExcludeOnSearchForm.Checked = _field.ExcludeOnSearchForm;
                ckbExcludeOnSearchWhere.Checked = _field.ExcludeOnSearchWhere;
            }
        }

        protected override BaseXMLElement GetDataFromCtrl()
        {
            if (_field == null)
                _field = new TableField();//if new

            _field.Security = (List<Security>)lbSecurity.DataSource;

            _field.Name = txtName.Text;
            _field.AttributeName = txtAttributeName.Text;
            _field.Label = txtLabel.Text;
            _field.Comment = txtComment.Text;

            _field.ReadOnly = cbReadOnly.Checked;
            _field.Required = cbRequired.Checked;

            FieldTypeEnum fieldType;
            _field.FieldType = Enum.TryParse(cmbFieldType.Text, true, out fieldType)
                                                ? fieldType
                                                : FieldTypeEnum.None;
            _field.FieldSource = txtFieldSource.Text;

            FieldValidValuesTypeEnum validValueType;
            _field.ValidValuesType = //cmbValidValuesType.Text.Trim();
                                                Enum.TryParse(cmbValidValuesType.Text, true, out validValueType)
                                                ? validValueType
                                                : FieldValidValuesTypeEnum.None;
            FieldTargetEnum fieldTarget;
            _field.FieldTarget = Enum.TryParse(cmbFieldTarget.Text, true, out fieldTarget)
                                                ? fieldTarget
                                                : FieldTargetEnum.None;

            _field.ValidValues = txtValidValues.Text;

            _field.DBColumnName = txtDBColumnName.Text;
            _field.FK_AdditionalWhereClause = txtFKAdditionalWhereClause.Text;
            _field.FK_OrderClause = txtFKOrderClause.Text;

            _field.ReqularExpression = txtReqularExpression.Text;
            _field.ReqularExpressionErrorText = txtReqularExpressionErrorText.Text;

            SearchTypeEnum searchType;
            _field.SearchType = Enum.TryParse(cmbSearchType.Text, true, out searchType)
                                                ? searchType
                                                : SearchTypeEnum.None;

            _field.ExcludeOnSearchForm = ckbExcludeOnSearchForm.Checked;
            _field.ExcludeOnSearchWhere = ckbExcludeOnSearchWhere.Checked;

            return _field;
        }

        /// <summary>
        /// To Create New Control
        /// </summary>
        protected override void InitDefaultData()
        {
            base.InitDefaultData();

            BindingHelper.LoadItemsFromSource( cmbFieldType, Enum.GetNames(typeof(FieldTypeEnum)));
            BindingHelper.LoadItemsFromSource( cmbFieldTarget , Enum.GetNames(typeof(FieldTargetEnum)));
            BindingHelper.LoadItemsFromSource( cmbValidValuesType, Enum.GetNames(typeof(FieldValidValuesTypeEnum)));
            BindingHelper.LoadItemsFromSource( cmbSearchType, Enum.GetNames(typeof(SearchTypeEnum)));
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

