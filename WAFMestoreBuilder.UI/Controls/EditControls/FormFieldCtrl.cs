using System;
using System.Collections.Generic;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	public partial class FormFieldCtrl : BaseWAFCtrl
	{
		private FormField _field;

		#region Ctor

		public FormFieldCtrl(WafXMLDesignerControl parentCtrl)
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
				_field = (FormField)elementData;

				BindingHelper.LoadSecurityFromSource(lbSecurity, _field.Security);
				cbReadOnly.Checked = (bool)_field.ReadOnly;
				cbRequired.Checked = (bool)_field.Required;

				cmbName.Text = _field.Name;
				txtAttributeName.Text = _field.AttributeName;
				txtLabel.Text = _field.Label;
				txtRequiredErrorText.Text = _field.RequiredErrorText;

				//txtReqularExpression.Text = _field.ReqularExpression;
				//txtReqularExpressionErrorText.Text = _field.ReqularExpressionErrorText;

				cmbFieldType.Text = _field.FieldType.ToString();
                cmbFieldTarget.Text = _field.FieldTarget.ToString();
				cmbFieldSource.Text = _field.FieldSource.ToString();// != null ? _field.FieldSource.ToString() : string.Empty;

				//unneccessary
				cmbValidValuesType.Text = _field.ValidValuesType.ToString();
				txtValidValues.Text = _field.ValidValues;
				txtValue.Text = _field.Value;

				cbHideOnEditForm.Checked = _field.HideOnEditForm;

				cbUseForConcurrency.Checked = _field.UseForConcurrency;

				ckbFK_JoinToSelectDisplay.Checked = _field.FK_JoinToSelectDisplay;

				txtFK_DBTABLE.Text = _field.FK_DBTable;
				txtDBColumnName.Text = _field.DBColumnName;

				txtFKPrimaryKeyColName.Text = _field.FK_PrimaryKeyColName;
				txtFKPrimaryValueColName.Text = _field.FK_PrimaryValueColName;
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_field == null)//if new element
				_field = new FormField();

			_field.Security = (List<Security>)lbSecurity.DataSource;

			_field.Name = cmbName.Text;
			_field.AttributeName = txtAttributeName.Text;
			_field.Label = txtLabel.Text;

			_field.Required = cbRequired.Checked;
			_field.ReadOnly = cbReadOnly.Checked;

			FieldTypeEnum fieldType;
			_field.FieldType = Enum.TryParse(cmbFieldType.Text, true, out fieldType) 
												? fieldType 
												: FieldTypeEnum.None;
            FieldTargetEnum fieldTarget;
            _field.FieldTarget = Enum.TryParse(cmbFieldTarget.Text, true, out fieldTarget)
                                                ? fieldTarget
                                                : FieldTargetEnum.None;
			FieldSourceEnum fieldSource;
			_field.FieldSource = Enum.TryParse(cmbFieldSource.Text, true, out fieldSource) 
												? fieldSource 
												: FieldSourceEnum.FieldSourceNone;


			//unneccessary
			FieldValidValuesTypeEnum validValueType;
			_field.ValidValuesType = //cmbValidValuesType.Text.Trim();
												 Enum.TryParse(cmbValidValuesType.Text, true, out validValueType) 
												? validValueType 
												: FieldValidValuesTypeEnum.FieldValidValuesTypeCustomSql;

			_field.ValidValues = txtValidValues.Text;

			_field.Value = txtValue.Text;
			_field.HideOnEditForm = cbHideOnEditForm.Checked;
			_field.UseForConcurrency = cbUseForConcurrency.Checked;
			_field.FK_JoinToSelectDisplay = ckbFK_JoinToSelectDisplay.Checked;

			//DB
			_field.FK_DBTable = txtFK_DBTABLE.Text;
			_field.DBColumnName = txtDBColumnName.Text;

			_field.FK_PrimaryKeyColName= txtFKPrimaryKeyColName.Text;
			_field.FK_PrimaryValueColName = txtFKPrimaryValueColName.Text;

			return _field;
		}

		/// <summary>
		/// To Create New Control
		/// </summary>
		protected override void InitDefaultData()
		{
			base.InitDefaultData();

			BindingHelper.LoadItemsFromSource(cmbFieldType, Enum.GetNames(typeof(FieldTypeEnum)));
            BindingHelper.LoadItemsFromSource(cmbFieldTarget, Enum.GetNames(typeof(FieldTargetEnum)));
            BindingHelper.LoadItemsFromSource(cmbFieldSource, Enum.GetNames(typeof(FieldSourceEnum)));//TODO: the same as FieldTargetEnum
			BindingHelper.LoadItemsFromSource(cmbValidValuesType, Enum.GetNames(typeof(FieldValidValuesTypeEnum)));

			BindingHelper.LoadFieldsFromSource(cmbName, GetParentTableFields());
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