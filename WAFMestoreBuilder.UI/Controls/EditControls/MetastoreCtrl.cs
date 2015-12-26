using System.Collections.Generic;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	public partial class MetastoreCtrl : BaseWAFCtrl
	{
		private Metastore _metastore;

		#region Ctor

		public MetastoreCtrl(WafXMLDesignerControl parentCtrl)
			: base(parentCtrl)
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		protected override void LoadDataToCtrl(BaseXMLElement elementData)
		{
			if (elementData != null)
			{
				_metastore = (Metastore)elementData;
				txtAppName.Text = _metastore.AppName;

				BindingHelper.LoadItemsFromSource(lbIncludes, _metastore.Includes);
				BindingHelper.LoadItemsFromSource(cmbSearchInclude, _metastore.Includes);

				BindingHelper.LoadItemsFromSource(lbTables, _metastore.Tables);
				BindingHelper.LoadItemsFromSource(cmbSearchTable, _metastore.Tables);

				BindingHelper.LoadItemsFromSource(lbStrings, _metastore.Strings);
				BindingHelper.LoadItemsFromSource(cmbSearchString, _metastore.Strings);

				BindingHelper.LoadItemsFromSource(lbSystemStrings, _metastore.SystemStrings);
				BindingHelper.LoadItemsFromSource(cmbSearchSystemString, _metastore.SystemStrings);
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_metastore == null)
				_metastore = new Metastore();//if new

			_metastore.AppName = txtAppName.Text;

			_metastore.Includes = (List<Include>)lbIncludes.DataSource;
			_metastore.Tables = (List<Table>)lbTables.DataSource;
			_metastore.Strings = (List<MetastoreString>)lbStrings.DataSource;
			_metastore.SystemStrings = (List<SystemString>)lbSystemStrings.DataSource;

			return _metastore;
		}

		#endregion

		#region Handlers

		private void btnAddInclude_Click(object sender, System.EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.include);
		}

		private void btnEditInclude_Click(object sender, System.EventArgs e)
		{
			var include = lbIncludes.SelectedItem as Include;
			if (include != null)
				ParentDesignerCtrl.OnEditElement(include);
		}

		private void btnDeleteInclude_Click(object sender, System.EventArgs e)
		{
			var include = lbIncludes.SelectedItem as Include;
			if (include != null)
				ParentDesignerCtrl.OnDeleteElement(include);
		}

		private void btnAddTable_Click(object sender, System.EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.table);
		}

		private void btnEditTable_Click(object sender, System.EventArgs e)
		{
			var table = lbTables.SelectedItem as Table;
			if (table != null)
				ParentDesignerCtrl.OnEditElement(table);
		}

		private void btnDeleteTable_Click(object sender, System.EventArgs e)
		{
			var table = lbTables.SelectedItem as Table;
			if (table != null)
				ParentDesignerCtrl.OnDeleteElement(table);
		}

		private void btnAddString_Click(object sender, System.EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.metastorestring);
		}

		private void btnEditString_Click(object sender, System.EventArgs e)
		{
			var metastring = lbStrings.SelectedItem as MetastoreString;
			if (metastring != null)
				ParentDesignerCtrl.OnEditElement(metastring);
		}

		private void btnDeleteString_Click(object sender, System.EventArgs e)
		{
			var metastring = lbStrings.SelectedItem as MetastoreString;
			if (metastring != null)
				ParentDesignerCtrl.OnDeleteElement(metastring);
		}

		private void btnAddSystemString_Click(object sender, System.EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.systemstring);
		}

		private void btnEditSystemString_Click(object sender, System.EventArgs e)
		{
			var systemstring = lbSystemStrings.SelectedItem as SystemString;
			if (systemstring != null)
				ParentDesignerCtrl.OnEditElement(systemstring);
		}

		private void btnDeleteSystemString_Click(object sender, System.EventArgs e)
		{
			var systemstring = lbSystemStrings.SelectedItem as SystemString;
			if (systemstring != null)
				ParentDesignerCtrl.OnDeleteElement(systemstring);
		}

		#endregion
	}
}

