
using System;
using System.Collections.Generic;
using System.Linq;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;
using Action = WAFMetastoreBuilder.WAFMetastoreElements.Action;

namespace WAFMetastoreBuilder.UI
{
	public partial class TableCtrl : BaseWAFCtrl
	{
		private Table _table;

		#region Properties

		public List<Action> Actions
		{
			get
			{
				return lbActions.Items.Cast<Action>().ToList();
			}
		}

		public List<TableField> Fields
		{
			get
			{
				return lbFields.Items.Cast<TableField>().ToList();
			}
		}

		public List<Form> Forms
		{
			get
			{
				return lbForms.Items.Cast<Form>().ToList();
			}
		}

		public List<Search> Searches
		{
			get
			{
				return lbSearch.Items.Cast<Search>().ToList();
			}
		}

		#endregion

		#region Ctor

		public TableCtrl(WafXMLDesignerControl parentCtrl)
			: base(parentCtrl)
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		protected override void LoadDataToCtrl(BaseXMLElement elementData)
		{
			base.LoadDataToCtrl(elementData);

			if (elementData is Table)
			{
				_table = (Table)elementData;
				cmbTableName.Text = _table.Name;
				cmbDBTableName.Text = _table.DBTableName;
				cmbDBTableType.Text = _table.DBTableType.ToString();
				ckbReadOnly.Checked = _table.Readonly;

				txtComment.Text = _table.Comment;
				txtAttachment.Text = _table.Attachment;

				txtXMLGeneratorServer.Text = _table.XMLGeneratorServer;
				txtHTMLGeneratorServer.Text = _table.HTMLGeneratorServer;
				txtBusinessRulesServer.Text = _table.BusinessRulesServer;
				txtSearchRulesServer.Text = _table.SearchRulesServer;

				cmbPrimaryKeyType.Text = _table.PrimaryKeyType.ToString();
				txtPrimaryKeyColName.Text = _table.PrimaryKeyColName;
				txtPrimaryValueColName.Text = _table.PrimaryValueColName;

				txtFKSuggestSearch.Text = _table.FK_SuggestSearch;

				BindingHelper.LoadActionsFromSource(lbActions, _table.Actions);
				BindingHelper.LoadItemsFromSource(cmbSearchAction, _table.Actions);

				BindingHelper.LoadFormFieldsFromSource(lbFields, _table.Fields);
				BindingHelper.LoadItemsFromSource(cmbSearchField, _table.Fields);

				BindingHelper.LoadFormsFromSource(lbForms, _table.Forms);
				BindingHelper.LoadItemsFromSource(cmbSearchForm, _table.Forms);

				BindingHelper.LoadSearchesFromSource(lbSearch, _table.Searches);
				BindingHelper.LoadItemsFromSource(cmbSearchName, _table.Searches);
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_table == null)
				_table = new Table();//if new

			_table.Name = cmbTableName.Text;
			_table.DBTableName = cmbDBTableName.Text;
			_table.Readonly = ckbReadOnly.Checked;

			DBTableTypeEnum dbTableType;
			_table.DBTableType = Enum.TryParse(cmbDBTableType.Text.Trim(), true, out dbTableType)
													? dbTableType
													: DBTableTypeEnum.DBTableTypeUnspecified;



			PrimaryKeyTypeEnum pkType;
			_table.PrimaryKeyType = Enum.TryParse(cmbPrimaryKeyType.Text.Trim(), true, out pkType)
													? pkType
													: PrimaryKeyTypeEnum.PKeyNone;

			_table.PrimaryKeyColName = txtPrimaryKeyColName.Text;
			_table.PrimaryValueColName = txtPrimaryValueColName.Text;
			_table.FK_SuggestSearch = txtFKSuggestSearch.Text;

			_table.XMLGeneratorServer = txtXMLGeneratorServer.Text;
			_table.HTMLGeneratorServer = txtHTMLGeneratorServer.Text;
			_table.BusinessRulesServer = txtBusinessRulesServer.Text;
			_table.SearchRulesServer = txtSearchRulesServer.Text;

			_table.Attachment = txtAttachment.Text;
			_table.Comment = txtComment.Text;

			_table.Actions = Actions;
			_table.Fields = Fields;
			_table.Forms = Forms;
			_table.Searches = Searches;

			return _table;
		}

		protected override void InitDefaultData()
		{
			cmbTableName.Text = string.Empty;

			BindingHelper.LoadItemsFromSource(cmbDBTableType, Enum.GetNames(typeof(DBTableTypeEnum)));
			BindingHelper.LoadItemsFromSource(cmbPrimaryKeyType, Enum.GetNames(typeof(PrimaryKeyTypeEnum)));
		}

		#endregion

		#region Handlers

		private void btnAddAction_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.action);
		}

		private void btnEditAction_Click(object sender, EventArgs e)
		{
			var tableAction = lbActions.SelectedItem as Action;
			if (tableAction != null)
				ParentDesignerCtrl.OnEditElement(tableAction);
		}

		private void btnDeleteAction_Click(object sender, EventArgs e)
		{
			var tableAction = lbActions.SelectedItem as Action;
			if (tableAction != null)
				ParentDesignerCtrl.OnDeleteElement(tableAction);
		}

		private void addFieldButton_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.tablefield);
		}

		private void editFieldButton_Click(object sender, EventArgs e)
		{
			var tableField = lbFields.SelectedItem as TableField;
			if (tableField != null)
				ParentDesignerCtrl.OnEditElement(tableField);
		}

		private void btnDeleteField_Click(object sender, EventArgs e)
		{
			var tableField = lbFields.SelectedItem as TableField;
			if (tableField != null)
				ParentDesignerCtrl.OnDeleteElement(tableField);
		}

		private void btnAddForm_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.form);
		}

		private void btnEditForm_Click(object sender, EventArgs e)
		{
			var form = lbForms.SelectedItem as Form;
			if (form != null)
				ParentDesignerCtrl.OnEditElement(form);
		}

		private void btnDeleteForm_Click(object sender, EventArgs e)
		{
			var form = lbForms.SelectedItem as Form;
			if (form != null)
				ParentDesignerCtrl.OnDeleteElement(form);
		}

		private void btnAddSearch_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.search);
		}

		private void btnEditSearch_Click(object sender, EventArgs e)
		{
			var search = lbSearch.SelectedItem as Search;
			if (search != null)
				ParentDesignerCtrl.OnEditElement(search);
		}

		private void btnDeleteSearch_Click(object sender, EventArgs e)
		{
			var search = lbSearch.SelectedItem as Search;
			if (search != null)
				ParentDesignerCtrl.OnDeleteElement(search);
		}

		#endregion

	}
}

