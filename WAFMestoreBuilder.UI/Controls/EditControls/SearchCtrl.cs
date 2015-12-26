using System;
using System.Collections.Generic;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	public partial class SearchCtrl : BaseWAFCtrl
	{
		private Search _search;

		#region Ctor

		public SearchCtrl(WafXMLDesignerControl parentCtrl)
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
				_search = (Search)elementData;

				BindingHelper.LoadSecurityFromSource(lbSecurity, _search.SearchSecurity);
				cmbSecureConnection.Text = _search.SecureConnection.ToString();

				BindingHelper.LoadSearchFieldsFromSource(lbSearchFields, _search.SearchFields);

				BindingHelper.LoadMenuActionsFromSource(lbSearchMenuActions, _search.SearchMenuActions);
				BindingHelper.LoadRowActionsFromSource(lbSearchRowActions, _search.SearchRowActions);
				BindingHelper.LoadTabActionsFromSource(lbSearchTabActions, _search.SearchTabActions);

				txtName.Text = _search.Name;
				txtTitle.Text = _search.Title;

				txtXSLTName.Text = _search.XsltName;

				txtSearchRulesServer.Text = _search.SearchRulesServer;
				txtSearchSubmitURL.Text = _search.SearchSubmitURL;

				cbCoutRows.Checked = _search.CountRows;
				ddFetchSize.Value = _search.FetchSize;
				txtOrderClause.Text = _search.OrderClause;

				ckbHideEmailLink.Checked = _search.HideEmailLink;
				ckbHideHelpLink.Checked = _search.HideHelpLink;
				ckbHidePrintLink.Checked = _search.HidePrintLink;

				ckbShowSearchPageTop.Checked = _search.ShowSearchPageTop;
				ckbShowSearchPageBottom.Checked = _search.ShowSearchPageBottom;
				ckbShowSortColumns.Checked = _search.ShowSortColumns;
				ckbShowActionsMenuTop.Checked = _search.ShowActionsMenuTop;

				ckbShowActionsMenuBottom.Checked = _search.ShowActionsMenuBottom;
				ckbShowActionsTab.Checked = _search.ShowActionsTab;
				ckbShowCSVLink.Checked = _search.ShowCsvLink;
				ckbShowFetchNextN.Checked = _search.ShowFetchNextN;
				txtNavigateColumnName.Text = _search.NavigateColumnName;
				txtResultNavigateForm.Text = _search.ResultNavigateForm;
				txtResultEmptyMessage.Text = _search.ResultEmptyMessage;

				ckbAutoExecute.Checked = _search.AutoExecute;
				txtResultTitle.Text = _search.ResultTitle;
				ckbRememberSearchValues.Checked = _search.RememberSearchValues;
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_search == null)
				_search = new Search();//if new

			_search.Name = txtName.Text;
			_search.Title = txtTitle.Text;

			_search.SearchSecurity = (List<Security>)lbSecurity.DataSource;

			SecureConnectionEnum secureConnection;
			_search.SecureConnection = Enum.TryParse(cmbSecureConnection.Text.Trim(), true, out secureConnection)
															 ? secureConnection
															 : SecureConnectionEnum.KeepDefault;

			_search.SearchFields = (List<SearchField>)lbSearchFields.DataSource;

			_search.SearchMenuActions = (List<SearchMenuAction>)lbSearchMenuActions.DataSource;
			_search.SearchRowActions = (List<SearchRowAction>)lbSearchRowActions.DataSource;
			_search.SearchTabActions = (List<SearchTabAction>)lbSearchTabActions.DataSource;

			_search.XsltName = txtXSLTName.Text;

			_search.SearchRulesServer = txtSearchRulesServer.Text;
			_search.SearchSubmitURL = txtSearchSubmitURL.Text;

			_search.CountRows = cbCoutRows.Checked;

			_search.OrderClause = txtOrderClause.Text;

			_search.HideEmailLink = ckbHideEmailLink.Checked;
			_search.HideHelpLink = ckbHideHelpLink.Checked;
			_search.HidePrintLink = ckbHidePrintLink.Checked;

			_search.ShowSearchPageTop = ckbShowSearchPageTop.Checked;
			_search.ShowSearchPageBottom = ckbShowSearchPageBottom.Checked;
			_search.ShowSortColumns = ckbShowSortColumns.Checked;

			_search.ShowActionsMenuTop = ckbShowActionsMenuTop.Checked;
			_search.ShowActionsMenuBottom = ckbShowActionsMenuBottom.Checked;
			_search.ShowActionsTab = ckbShowActionsTab.Checked;
			_search.ShowCsvLink = ckbShowCSVLink.Checked;

			_search.AutoExecute = ckbAutoExecute.Checked;
			_search.FetchSize = (int)ddFetchSize.Value;
			_search.ShowFetchNextN = ckbShowFetchNextN.Checked;

			_search.ResultTitle = txtResultTitle.Text;
			_search.RememberSearchValues = ckbRememberSearchValues.Checked;
			_search.NavigateColumnName = txtNavigateColumnName.Text;
			_search.ResultNavigateForm = txtResultNavigateForm.Text;
			_search.ResultEmptyMessage = txtResultEmptyMessage.Text;

			return _search;
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
			ParentDesignerCtrl.OnCreateElement(ElementType.searchfield);
		}

		private void btnEditField_Click(object sender, EventArgs e)
		{
			var searchfield = lbSearchFields.SelectedItem as SearchField;
			ParentDesignerCtrl.OnEditElement(searchfield);
		}

		private void btnDeleteField_Click(object sender, EventArgs e)
		{
			var searchfield = lbSearchFields.SelectedItem as SearchField;
			ParentDesignerCtrl.OnDeleteElement(searchfield);
		}

		private void btnAddSearchMenuAction_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.searchmenuaction);
		}

		private void btnEditSearchMenuAction_Click(object sender, EventArgs e)
		{
			var menuaction = lbSearchMenuActions.SelectedItem as SearchMenuAction;
			ParentDesignerCtrl.OnEditElement(menuaction);
		}

		private void btnDeleteSearchMenuAction_Click(object sender, EventArgs e)
		{
			var menuaction = lbSearchMenuActions.SelectedItem as SearchMenuAction;
			ParentDesignerCtrl.OnDeleteElement(menuaction);
		}

		private void btnAddSearchRowAction_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.searchrowaction);
		}

		private void btnEditSearchRowAction_Click(object sender, EventArgs e)
		{
			var rowaction = lbSearchRowActions.SelectedItem as SearchRowAction;
			ParentDesignerCtrl.OnEditElement(rowaction);
		}

		private void btnDeleteSearchRowAction_Click(object sender, EventArgs e)
		{
			var rowction = lbSearchRowActions.SelectedItem as SearchRowAction;
			ParentDesignerCtrl.OnDeleteElement(rowction);
		}

		private void btnAddSearchTabAction_Click(object sender, EventArgs e)
		{
			ParentDesignerCtrl.OnCreateElement(ElementType.searchtabaction);
		}

		private void btnEditSearchTabAction_Click(object sender, EventArgs e)
		{
			var tabaction = lbSearchTabActions.SelectedItem as SearchTabAction;
			ParentDesignerCtrl.OnEditElement(tabaction);
		}

		private void btnDeleteSearchTabAction_Click(object sender, EventArgs e)
		{
			var tabction = lbSearchTabActions.SelectedItem as SearchTabAction;
			ParentDesignerCtrl.OnDeleteElement(tabction);
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

