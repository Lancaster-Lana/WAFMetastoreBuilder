using System;
using System.Xml.Serialization;

namespace WAFMetastoreBuilder.ENUMS
{
	[Serializable, XmlRoot("DBTABFORMSUBMISSION", IsNullable = true)]
	public enum FormSubmissionEnum
	{
		[NonSerialized]
		UseDefault,
		NewFormSubmission,
		UseParentFormSubmission
	}
}