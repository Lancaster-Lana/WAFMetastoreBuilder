using System;
using System.Collections.Generic;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;
using Action = WAFMetastoreBuilder.WAFMetastoreElements.Action;

namespace WAFMetastoreBuilder.UI
{
	public partial class TableActionCtrl : BaseWAFCtrl
	{
		private Action _action;

		#region Ctor

		public TableActionCtrl(WafXMLDesignerControl parentCtrl)
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
				_action = (Action)elementData;

				BindingHelper.LoadSecurityFromSource(lbSecurity, _action.Security);
				cmbSecureConnection.Text = _action.SecureConnection.ToString();

				txtName.Text = _action.Name;
				cmbAction.Text = _action.ActionName;
				txtNextActionName.Text = _action.NextActionName; //EditManagerHelper.LoadActionsFromSource(cmbNextActionName, _field.);
				txtLabel.Text = _action.Label;
				txtTitle.Text = _action.Title;
				txtDescription.Text = _action.Description;
				cmbTableName.Text = _action.TableName;
				cmbFormName.Text = _action.FormName;
				txtUrl.Text = _action.Url;
				cbSubmitEditForm.Checked = _action.SubmitEditForm;
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_action == null)
				_action = new Action();//if new

			_action.Security = (List<Security>)lbSecurity.DataSource;
			SecureConnectionEnum secureConnection;
			_action.SecureConnection = Enum.TryParse(cmbSecureConnection.Text, true, out secureConnection)
																 ? secureConnection
																 : SecureConnectionEnum.KeepDefault;
			_action.Name = txtName.Text;
			_action.ActionName = cmbAction.Text;
			_action.NextActionName = txtNextActionName.Text;

			_action.Label = txtLabel.Text;
			_action.Title = txtTitle.Text;
			_action.Description = txtDescription.Text;
			_action.TableName = cmbTableName.Text;
			_action.FormName = cmbFormName.Text;
			_action.SubmitEditForm = cbSubmitEditForm.Checked;
			_action.Url = txtUrl.Text;

			return _action;
		}

		/// <summary>
		/// To Create New Control
		/// </summary>
		protected override void InitDefaultData()
		{
			base.InitDefaultData();

			BindingHelper.LoadItemsFromSource(cmbSecureConnection, Enum.GetNames(typeof(SecureConnectionEnum)));
			//BindingHelper.LoadItemsFromSource(cmbNextAction, Enum.GetNames(typeof(ActionType)));
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
