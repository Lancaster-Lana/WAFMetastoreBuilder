using System;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	public partial class SecurityCtrl : BaseWAFCtrl
	{
		private Security _security;

		#region Ctor

		public SecurityCtrl(WafXMLDesignerControl parentCtrl)
			: base(parentCtrl)
		{
			InitializeComponent();
		}

		#endregion

		#region Overrides methods

		protected override void InitDefaultData()
		{
			base.InitDefaultData();

			BindingHelper.LoadItemsFromSource(cmbAction, Enum.GetNames(typeof(SecurityActionEnum)));
			BindingHelper.LoadItemsFromSource(cmbPrivOperator, Enum.GetNames(typeof(SecurityOpEnum)));
		}

		protected override void LoadDataToCtrl(BaseXMLElement elementData)
		{
			base.LoadDataToCtrl(elementData);

			if (elementData != null)
			{
				_security = (Security)elementData;

				cmbAction.Text = _security.Action.ToString();
				ckbAllowAny.Checked = _security.AllowAny;
				txtComment.Text = _security.Comment;

				//Set priviligies
				if (_security.Priv != null)
				{
					txtPrivField1.Text = _security.Priv.Field1;
					txtPrivField2.Text = _security.Priv.Field2;
					cmbPrivOperator.Text = _security.Priv.Operator.ToString();
					txtPrivValue.Text = _security.Priv.Value;
				}
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_security == null)
				_security = new Security();//if new

			SecurityActionEnum scurityaction;
			_security.Action = Enum.TryParse(cmbAction.Text.Trim(), true, out scurityaction)
												? scurityaction
												: SecurityActionEnum.None;

			_security.AllowAny = ckbAllowAny.Checked;

			if (!string.IsNullOrEmpty(txtPrivField1.Text.Trim()) || !string.IsNullOrEmpty(txtPrivValue.Text.Trim()))
			{
				_security.Priv = new Permission();//if new

				_security.Priv.Field1 = txtPrivField1.Text;
				_security.Priv.Field2 = txtPrivField2.Text;

				SecurityOpEnum privOpertor;
				_security.Priv.Operator = Enum.TryParse(cmbPrivOperator.Text.Trim(), true, out privOpertor)
														? privOpertor
														: SecurityOpEnum.None;

				_security.Priv.Value = txtPrivValue.Text;
			}

			_security.Comment = txtComment.Text;

			return _security;
		}

		#endregion
	}
}

