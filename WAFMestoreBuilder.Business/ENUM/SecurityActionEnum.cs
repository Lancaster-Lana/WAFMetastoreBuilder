using System;
using System.Xml.Serialization;

namespace WAFMetastoreBuilder.ENUMS
{
	[Serializable, XmlRoot("ACTION", IsNullable = true)]
	public enum SecurityActionEnum
	{
		[NonSerialized]
		None,
		ActionAny,
		ActionSearchDisplay,
		ActionSearchExecute,
		ActionRecordCreate,
		ActionRecordRead,
		ActionRecordUpdate,
		ActionRecordDelete,
		ActionRecordDisplay,
		ActionFieldDisplay,
		ActionFieldModify,
		ActionFieldSearch,
		ActionActionDisplay,
	}
}