using System;
using System.Collections;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	public partial class LinkedFormCtrl : BaseWAFCtrl
	{
		LinkedForm _linkForm;

		public LinkedFormCtrl(WafXMLDesignerControl parentCtrl)
			: base(parentCtrl)
		{
			InitializeComponent();
		}

		#region Methods

		protected override void LoadDataToCtrl(BaseXMLElement elementData)
		{
			base.LoadDataToCtrl(elementData);

			if (elementData is LinkedForm)
			{
				_linkForm = (LinkedForm)elementData;

				cmbTableName.Text = _linkForm.TableName;

				//BindingHelper.LoadFormsFromSource(cmbFormName, GetTableForms(_linkForm.TableName));
				cmbFormName.Text = _linkForm.FormName;
				//BindingHelper.LoadTableFieldsFromSource(cmbFKColumn, GetTableColumns(_linkForm.TableName));
				cmbFKColumn.Text = _linkForm.FKColumn;
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_linkForm == null)
				_linkForm = new LinkedForm(); //for new

			_linkForm.FormName = cmbFormName.Text;
			_linkForm.TableName = cmbTableName.Text;
			_linkForm.FKColumn = cmbFKColumn.Text;

			return _linkForm;
		}

		protected override void InitDefaultData()
		{
			base.InitDefaultData();

			BindingHelper.LoadItemsFromSource(cmbTableName, GetAllTables());
		}

		private IList GetAllTables()
		{
			return ParentDesignerCtrl.GetAllTables();
		}

		private IList GetTableForms(string tablename)
		{
			return ParentDesignerCtrl.GetTableForms(tablename);
		}

		private IList GetTableColumns(string tablename)
		{
			return ParentDesignerCtrl.GetTableColumns(tablename);
		}

		#endregion

		#region Handlers

		private void cmbTableName_SelectedValueChanged(object sender, EventArgs e)
		{
			var tableName = cmbTableName.Text.Trim();//_linkForm.TableName

			BindingHelper.LoadFormsFromSource(cmbFormName, GetTableForms(tableName));
			//cmbFormName.Text = _linkForm.FormName;
			BindingHelper.LoadTableFieldsFromSource(cmbFKColumn, GetTableColumns(tableName), true);
			//cmbFKColumn.Text = _linkForm.FKColumn;
		}

		private void lnkParentTable_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			var selectedTbl = cmbTableName.Text;
			GoToTableElement(selectedTbl);
		}

		private void lnkParentForm_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			var selectedTbl = cmbTableName.Text;
			var selectedForm = cmbFormName.Text;
			GoToFormElement(selectedTbl, selectedForm);
		}
	}

		#endregion
}

