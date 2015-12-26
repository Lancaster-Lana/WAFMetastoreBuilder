using System;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace WAFMetastoreBuilder.WAFMetastoreElements
{
	//[SerializableAttribute, XmlRoot]
	//public enum AttributeRequiredLevel { None, SystemRequired, Required, Recommended, ReadOnly }

	[Serializable, XmlRoot("FORMROWACTION")]
	public class FormRowAction : BaseXMLElement, IComparable
	{
		public FormRowAction()
		{
		}

		public FormRowAction(string name)
		{
			this.Name = name;
		}

		public override string ToXML()
		{
			var sb = new StringBuilder();
			sb.Append("<FORMROWACTION NAME='" + this.Name + "' >");
			return sb.ToString(); //return Entity.Serialize(this);
		}

		public override string ToString()
		{
			return ToXML();
		}

		public int CompareTo(object obj)
		{
			if (obj == null) return -1;
			return String.Compare(Name, ((FormRowAction)obj).Name, StringComparison.Ordinal);
		}
	}
}