using System;
using System.ComponentModel;
using System.Xml.Serialization;
using System.IO;
using System.Text;

namespace WAFMetastoreBuilder.WAFMetastoreElements
{
	[Serializable, XmlRoot("FORMTABACTION")]
	public class FormTabAction : BaseXMLElement, IComparable
	{
		public FormTabAction()
		{
		}

		public FormTabAction(string name)
		{
			this.Name = name;
		}

		public override string ToXML()
		{
			var sb = new StringBuilder();
			sb.Append("<FORMTABACTION NAME='" + this.Name + "' >");
			return sb.ToString(); 
		}

		public override string ToString()
		{
			return ToXML();
		}

		public int CompareTo(object obj)
		{
			if (obj == null) return -1;
			return String.Compare(Name, ((FormTabAction)obj).Name, StringComparison.Ordinal);
		}
	}
}