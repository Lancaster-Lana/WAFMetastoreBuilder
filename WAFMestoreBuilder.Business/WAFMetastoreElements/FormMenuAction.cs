using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace WAFMetastoreBuilder.WAFMetastoreElements
{
	[Serializable, XmlRoot("FORMMENUACTION")]
	public class FormMenuAction : BaseXMLElement, IComparable//Action
	{
		//[XmlAttribute("NAME")]
		//public string Name { get; set; }

		//[XmlAttribute("LABEL")]
		//public string Label { get; set; }
		[XmlElement(typeof(Security), ElementName = "SECURITY")]
		public List<Security> Security { get; set; }


		public override string ToXML()
		{
			var sb = new StringBuilder();
			sb.Append("<FORMMENUACTION NAME='" + this.Name + "' >");
			return sb.ToString(); 
		}

		public override string ToString()
		{
			return ToXML();
		}

		public int CompareTo(object obj)
		{
			if (obj == null) return -1;
			return String.Compare(Name, ((FormMenuAction)obj).Name, StringComparison.Ordinal);
		}

		#region  Elements Methods

		public void AddSecurity(Security security)
		{
			if (this.Security == null)
				this.Security = new List<Security>();

			this.Security.Add(security);
		}

		public void RemoveSecurity(Security security)
		{
			if (this.Security != null)
				this.Security.Remove(security);
		}

		#endregion
	}
}
