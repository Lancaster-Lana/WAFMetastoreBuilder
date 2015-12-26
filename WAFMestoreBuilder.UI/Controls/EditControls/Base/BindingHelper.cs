
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	/// <summary>
	/// Binding methods (list control with source data : collections, etc )
	/// </summary>
	public static class BindingHelper
	{
		/// <summary>
		/// Load Table actions
		/// </summary>
		/// <param name="lstBox"></param>
		/// <param name="source"></param>
		internal static void LoadActionsFromSource(ListControl lstBox, IList source)
		{
			LoadItemsFromSource(lstBox, source);
		}

		/// <summary>
		/// Load Form\Search menu actions
		/// </summary>
		/// <param name="lstBox"></param>
		/// <param name="source"></param>
		internal static void LoadMenuActionsFromSource(ListControl lstBox, IList source)
		{
			LoadItemsFromSource(lstBox, source);
		}

		/// <summary>
		/// Load Form\Search tab actions
		/// </summary>
		/// <param name="lstBox"></param>
		/// <param name="source"></param>
		internal static void LoadTabActionsFromSource(ListControl lstBox, IList source)
		{
			LoadItemsFromSource(lstBox, source);
		}

		/// <summary>
		/// Load Form\Search row actions
		/// </summary>
		/// <param name="lstBox"></param>
		/// <param name="source"></param>
		internal static void LoadRowActionsFromSource(ListControl lstBox, IList source)
		{
			LoadItemsFromSource(lstBox, source);
		}

		internal static void LoadTableFieldsFromSource(ListControl lstBox, IList source, bool addEmptyItem = false)
		{
			LoadItemsFromSource(lstBox, source, addEmptyItem);
		}

		internal static void LoadFormFieldsFromSource(ListControl lstBox, IList source)
		{
			LoadItemsFromSource(lstBox, source);
		}

		internal static void LoadFormsFromSource(ListControl lstBox, IList source)
		{
			LoadItemsFromSource(lstBox, source);
		}

		internal static void LoadSearchesFromSource(ListControl lstBox, IList source)
		{
			LoadItemsFromSource(lstBox, source);
		}

		internal static void LoadLinkFormsFromSource(ListControl lstBox, IList source)
		{
			LoadItemsFromSource(lstBox, source, false, "Description"); //there no  Name field in LinkedForm
		}

		internal static void LoadFieldsFromSource(ListControl lstBox, IList source)
		{
			LoadItemsFromSource(lstBox, source);
		}

		internal static void LoadSearchFieldsFromSource(ListControl lstBox, IList source)
		{
			LoadItemsFromSource(lstBox, source);
		}

		internal static void LoadItemsFromSource(ListControl lstBox, IList source, bool addEmptyItem = false, string customDisplayField = "Name")
		{
			lstBox.DisplayMember = lstBox.ValueMember = customDisplayField;

			List<string> sourceStrings = null;

			//Set list datasource
			if (source != null && addEmptyItem)
			{
				sourceStrings = source.OfType<BaseXMLElement>().Select(el => el.Name).ToList();
				//sourceStrings.Sort();
				sourceStrings.Insert(0, "");
				lstBox.DataSource = sourceStrings;
			}
			else
				lstBox.DataSource = source;

			lstBox.Invalidate(true);
		}
		
		/// <summary>
		/// Search, Form, actions securoty
		/// </summary>
		/// <param name="lstBox"></param>
		/// <param name="source"></param>
		internal static void LoadSecurityFromSource(ListBox lstBox, IList source)
		{
			if (source != null && source.Count > 0)
			{
				lstBox.DisplayMember = "Action";
			}
			lstBox.DataSource = source;
			lstBox.Invalidate();
		}
	}
}

		//internal static void LoadItemsFromSource(ListControl lstBox, IList source, bool addEmptyItem = false)
		//{
		//	lstBox.DisplayMember = lstBox.ValueMember = "Name";

		//	if (source != null && addEmptyItem)
		//	{
		//		var sourceStrings = source.OfType<BaseXMLElement>().Select(el => el.Name).ToList();
		//		sourceStrings.Insert(0, "");
		//		lstBox.DataSource = sourceStrings;
		//	}
		//	else
		//		lstBox.DataSource = source;

		//	lstBox.Invalidate(true);
		//}
