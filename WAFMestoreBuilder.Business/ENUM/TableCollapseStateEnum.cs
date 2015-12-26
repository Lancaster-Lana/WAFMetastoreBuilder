using System;
using System.Xml.Serialization;

namespace WAFMetastoreBuilder.ENUMS
{
	[Serializable, XmlRoot("TABLECOLLAPSESTATE", IsNullable = true)]
	public enum TableCollapseStateEnum
	{
		[NonSerialized]
    None, //TODO:
		NotCollapsible = 0,
		Collapsed = 1,
		Expanded = 2
	}
}