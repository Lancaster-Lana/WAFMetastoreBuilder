using System;
using System.Collections.Generic;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	public partial class FormCtrl : BaseWAFCtrl
	{
		private Form _form;

		#region Ctor

		public FormCtrl(WafXMLDesignerControl parentCtrl)
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
				_form = (Form)elementData;

				txtName.Text = _form.Name;
				txtTitle.Text = _form.Title;

				cbReadOnly.Checked = _form.Readonly;

				txtTableNewForm.Text = _form.TableNewForm;
				txtTableNavigateForm.Text = _form.TableNavigateForm;
				txtTableNavigateColForm.Text = _form.TableNavigateColForm;

				txtXsltName.Text = _form.XsltName;
				txtXMLGeneratorServer.Text = _form.XMLGeneratorServer;
				txtBusinessRulesServer.Text = _form.BusinessRulesServer;

				BindingHelper.LoadSecurityFromSource(lbSecurity, _form.Security);
				cmbSecureConnection.Text = _form.SecureConnection.ToString();
				BindingHelper.LoadFormFieldsFromSource(lbFormFields, _form.FormFields);
				txtFocusField.Text = _form.FocusField;
				BindingHelper.LoadMenuActionsFromSource(lbFormMenuActions, _form.FormMenuActions);
				BindingHelper.LoadRowActionsFromSource(lbFormRowActions, _form.FormRowActions);
				BindingHelper.LoadTabActionsFromSource(lbFormTabActions, _form.FormTabActions);
				//EditManagerHelper.LoadFormMenuActionsFromSource(lbDefaultMenuActions, _form.DefaultMenuActions);
				BindingHelper.LoadLinkFormsFromSource(lbLinkedForms, _form.LinkedForms);


				txtWhereClause.Text = _form.WhereClause;
				txtOrderClause.Text = _form.OrderClause;
				ddGridColumnsCount.Value = _form.GridColumnsCount;

				ckbHideEmailLink.Checked = _form.HideEmailLink;
				ckbHidePrintLink.Checked = _form.HidePrintLink;
				ckbHideHelpLink.Checked = _form.HideHelpLink;

				ckbShowAddNewRow.Checked = _form.ShowAddNewRow;
				ckbShowDelete.Checked = _form.ShowDelete;
				ckbShowSortColumns.Checked = _form.ShowSortColumns;

				//ckbSHOW_ACTIONS_MENU_TOP.Checked = _form.ShowActionsMenuTop;
				ckbShowActionsMenuBottom.Checked = _form.ShowActionsMenuBottom;
				ckbShowReqiredInstructionBottom.Checked = _form.ShowRequiredInstructionBottom;

				ckbShowActionsTab.Checked = _form.ShowActionsTab;
				txtSeletedTab.Text = _form.SelectedTab;
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_form == null)
				_form = new Form();//if new

			_form.Name = txtName.Text;
			_form.Title = txtTitle.Text;
			_form.Readonly = cbReadOnly.Checked;

			_form.TableNewForm = txtTableNewForm.Text;
			_form.TableNavigateForm = txtTableNavigateForm.Text;
			_form.TableNavigateColForm = txtTableNavigateColForm.Text;

			_form.XsltName = txtXsltName.Text;
			_form.XMLGeneratorServer = txtXMLGeneratorServer.Text;
			_form.BusinessRulesServer = txtBusinessRulesServer.Text;

			_form.Security = (List<Security>)lbSecurity.DataSource;

			SecureConnectionEnum secureConnection;
			_form.SecureConnection = Enum.TryParse(cmbSecureConnection.Text.Trim(), true, out secureConnection)
															 ? secureConnection
															 : SecureConnectionEnum.KeepDefault;


			_form.FormFields = (List<FormField>)lbFormFields.DataSource;
			_form.FocusField = txtFocusField.Text;
			//_form.DefaultMenuActions = lbDefaultMenuActions.DataSource;
			_form.LinkedForms = (List<LinkedForm>)lbLinkedForms.DataSource;

			_form.FormMenuActions = (List<FormMenuAction>)lbFormMenuActions.DataSource;
			_form.FormTabActions = (List<FormTabAction>)lbFormTabActions.DataSource;
			_form.FormRowActions = (List<FormRowAction>)lbFormRowActions.DataSource;

			_form.WhereClause = txtWhereClause.Text;
			_form.OrderClause = txtOrderClause.Text;
			_form.GridColumnsCount = (int)ddGridColumnsCount.Value;

			_form.HideEmailLink = ckbHideEmailLink.Checked;
			_form.HidePrintLink = ckbHidePrintLink.Checked;
			_form.HideHelpLink = ckbHideHelpLink.Checked;

			_form.ShowAddNewRow = ckbShowAddNewRow.Checked;
			_form.ShowDelete = ckbShowDelete.Checked;
			_form.ShowSortColumns = ckbShowSortColumns.Checked;
			//_form.ShowActionsMenuTop = ckbSHOW_ACTIONS_MENU_TOP.Checked;

			_form.ShowActionsMenuBottom = ckbShowActionsMenuBottom.Checked;
			_form.ShowRequiredInstructionBottom = ckbShowReqiredInstructionBottom.Checked;

			_form.ShowActionsTab = ckbShowActionsTab.Checked;
			_form.SelectedTab = txtSeletedTab.Text;
			return _form;
		}

		protected override void InitDefaultData()
		{
			base.InitDefaultData();

			BindingHelper.LoadItemsFromSource(cmbSecureConnection, Enum.GetNames(typeof(SecureConnectionEnum)));
		}

		#endregion

		#region Handlers

		private void btnAddField_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.formfield);
		}

		private void btnEditField_Click(object sender, EventArgs e)
		{
			var field = lbFormFields.SelectedItem as FormField;
			ParentDesignerCtrl.OnEditElement(field);
		}

		private void btnDeleteField_Click(object sender, EventArgs e)
		{
			var formField = lbFormFields.SelectedItem as FormField;
			if (formField != null)
				ParentDesignerCtrl.OnDeleteElement(formField);
		}

		private void btnAddMenuAction_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.formmenuaction);
		}

		//private void btnEditMenuAction_Click(object sender, EventArgs e)
		//{
		//	var formmenuaction = lbFormMenuActions.SelectedItem as FormMenuAction;
		//	ParentCtrl.OnEditElement(formmenuaction);//NavigateSubNode
		//}

		private void btnDeleteMenuAction_Click(object sender, EventArgs e)
		{
			var formmenuaction = lbFormMenuActions.SelectedItem as FormMenuAction;
			if (formmenuaction != null)
				ParentDesignerCtrl.OnDeleteElement(formmenuaction);
		}

		private void btnAddLinkedForm_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.linkedForm);
		}

		private void btnEditLinkedForm_Click(object sender, EventArgs e)
		{
			var linkedform = lbLinkedForms.SelectedItem as LinkedForm;
			if (linkedform != null)
				ParentDesignerCtrl.OnEditElement(linkedform);
		}

		private void btnDeleteLinkedForm_Click(object sender, EventArgs e)
		{
			var linkedform = lbLinkedForms.SelectedItem as LinkedForm;
			if (linkedform != null)
				ParentDesignerCtrl.OnDeleteElement(linkedform);
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


		private void btnOpenXslt_Click(object sender, EventArgs e)
		{
			var filePathForm = new System.Windows.Forms.OpenFileDialog();
			if (filePathForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				txtXsltName.Text = filePathForm.FileName;
			}
		}

		private void btnAddFormRowAction_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.formrowaction);
		}

		private void btnEditFormRowAction_Click(object sender, EventArgs e)
		{
			var rowaction = lbFormRowActions.SelectedItem as FormRowAction;
			ParentDesignerCtrl.OnEditElement(rowaction);
		}

		private void btnDeleteFormRowAction_Click(object sender, EventArgs e)
		{
			var menuaction = lbFormRowActions.SelectedItem as FormRowAction;
			if (menuaction != null)
				ParentDesignerCtrl.OnDeleteElement(menuaction);
		}

		private void btnAddFormTabAction_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.formtabuaction);
		}

		private void btnEditFormTabAction_Click(object sender, EventArgs e)
		{
			var tabaction = lbFormTabActions.SelectedItem as FormTabAction;
			ParentDesignerCtrl.OnEditElement(tabaction);
		}

		private void btnDeleteFormTabAction_Click(object sender, EventArgs e)
		{
			var tabaction = lbFormTabActions.SelectedItem as FormTabAction;
			if (tabaction != null)
				ParentDesignerCtrl.OnDeleteElement(tabaction);
		}

		#endregion
	}
}