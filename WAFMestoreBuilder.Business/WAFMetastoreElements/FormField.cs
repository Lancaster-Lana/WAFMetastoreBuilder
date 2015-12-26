using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;
using WAFMetastoreBuilder.ENUMS;

namespace WAFMetastoreBuilder.WAFMetastoreElements
{
	/// <summary>
	///Form Field
	/// </summary>
	[Serializable, XmlRoot("FORMFIELD")]
	public class FormField : BaseXMLElement
	{
		[XmlElement(typeof(Security), ElementName = "SECURITY")]
		public List<Security> Security { get; set; }

		[XmlAttribute(AttributeName = "LABEL")]
		[DefaultValue("")]	//to ignore empty string serialization
		public string Label { get; set; }

		[XmlAttribute(AttributeName = "ATTRIBUTENAME")]
		[DefaultValue("")]	//to ignore empty string serialization
		public string AttributeName { get; set; }

		[XmlAttribute(AttributeName = "FIELDTYPE")]
		public FieldTypeEnum FieldType { get; set; }

        [XmlAttribute(AttributeName = "FIELDTARGET")]
        [DefaultValue(FieldTargetEnum.None)]
        public FieldTargetEnum FieldTarget { get; set; }

		[XmlAttribute(AttributeName = "FIELDSOURCE")]
		public FieldSourceEnum FieldSource { get; set; }

		[XmlAttribute(AttributeName = "HIDE_ON_EDIT_FORM")]
		[DefaultValue(false)]
		public bool HideOnEditForm { get; set; }

		[XmlAttribute(AttributeName = "USE_FOR_CONCURRENCY")]
		[DefaultValue(false)]
		public bool UseForConcurrency { get; set; }

		[XmlAttribute(AttributeName = "READONLY")]
		[DefaultValue(true)]
		public bool ReadOnly { get; set; }

		[XmlAttribute(AttributeName = "REQUIRED")]
		[DefaultValue(true)]
		public bool Required { get; set; }

		[XmlAttribute(AttributeName = "REQUIREDERRORTEXT")]
		[DefaultValue("")]	//to ignore empty string serialization
		public string RequiredErrorText { get; set; }

		[XmlAttribute(AttributeName = "VALUE")]
		[DefaultValue("")]	//to ignore empty string serialization
		public string Value { get; set; }

		[XmlAttribute(AttributeName = "VALIDVALUESTYPE")] //[XmlElement(IsNullable = true)]
		public FieldValidValuesTypeEnum ValidValuesType { get; set; }

		[XmlAttribute(AttributeName = "VALIDVALUES")]
		[DefaultValue("")]	//to ignore empty string serialization
		public string ValidValues { get; set; }

		[XmlAttribute(AttributeName = "DBCOLUMNNAME")]
		[DefaultValue("")]	//to ignore empty string serialization
		public string DBColumnName { get; set; }

		[XmlAttribute(AttributeName = "FK_DBTABLE")]
		[DefaultValue("")]	//to ignore empty string serialization
		public string FK_DBTable { get; set; }

		[XmlAttribute(AttributeName = "FK_PRIMARYKEYCOLNAME")]
		[DefaultValue("")]	//to ignore empty string serialization
		public string FK_PrimaryKeyColName { get; set; }

		[XmlAttribute(AttributeName = "FK_PRIMARYVALUECOLNAME")]
		[DefaultValue("")]	//to ignore empty string serialization
		public string FK_PrimaryValueColName { get; set; }

		[XmlAttribute(AttributeName = "FK_JOIN_TO_SELECT_DISPLAY")]
		[DefaultValue(false)]
		public bool FK_JoinToSelectDisplay { get; set; }

		//[XmlElement("SECURITY")]
		//public Security SecurityLevel { get; set; }

		//[XmlAttribute(AttributeName = "WIDTH")]
		//public int Width { get; set; }

		//[XmlAttribute(AttributeName = "DISPLAYWIDTH")]
		//public int DisplayWidth { get; set; }

		//[XmlAttribute(AttributeName = "DISPLAYHEIGHT")]
		//public int DisplayHeight { get; set; }

		//[XmlAttribute(AttributeName = "REGULAREXPRESSION")]
		//public string ReqularExpression { get; set; }

		//[XmlAttribute(AttributeName = "REGULAREXPRESSIONERRORTEXT")]
		//public string ReqularExpressionErrorText { get; set; }

		public FormField()
		{

		}

		public override string ToXML()
		{
			var sb = new StringBuilder();
			sb.Append("<FORMFIELD NAME='" + this.Name + "' >");
			return sb.ToString(); //return Entity.Serialize(this);
		}

		public override string ToString()
		{
			return ToXML();
		}

		#region  Non serializable variables and properties.

		//protected SortedList<string, CustomProperty> _customProperties = new SortedList<string, CustomProperty>();
		//protected SortedList<string, CustomAttribute> _customAttributes = new SortedList<string, CustomAttribute>();

		//private static SortedList<string, CustomProperty> _listOfCustProps = new SortedList<string, CustomProperty>();
		//private static SortedList<string, CustomAttribute> _listOfCustAttrs = new SortedList<string, CustomAttribute>();

		/// <summary>
		/// Get type from attributes node
		/// </summary>
		/*  
		 * //protected string _attributetype = "NText";
		private string AttributeType
		{
				get { return _attributetype; }
				set { _attributetype = value; }
		}*/

		///// <summary>
		/////List of unknown attributes of the analizing field.
		///// </summary>
		//[XmlIgnore]
		//public SortedList<string, CustomAttribute> CustomAttributes
		//{
		//	get { return _customAttributes; }
		//	set { _customAttributes = value; }
		//}

		///// <summary>
		/////List of unknown properties of the analizing field.
		///// </summary>
		//[XmlIgnore]
		//public SortedList<string, CustomProperty> CustomProperties
		//{
		//	get { return _customProperties; }
		//	set { _customProperties = value; }
		//}


		/// <summary>
		/// It is property name for all custom attributes of field (a list of custom attributes)
		/// </summary>
		/// <returns></returns>
		public static string GetCustomAttributeCollectionName()
		{
			return "CustomAttributes";
		}

		/// <summary>
		/// It is property name for all custom properties of field (a list of custom properties )
		/// </summary>
		/// <returns></returns>
		public static string GetCustomPropertyCollectionName()
		{
			return "CustomProperties";
		}

		static void xmlSerializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
		{//TODO:
			//_listOfCustAttrs.Add(e.Attr.Name, new CustomAttribute(e.Attr.Name, e.Attr.GetType(), e.Attr.Value));
		}

		private static void xmlSerializer_UnknownElement(object sender, XmlElementEventArgs e)
		{
			//_listOfCustProps.Add(e.Element.Name, new CustomProperty(e.Element.Name, e.Element.OuterXml));
		}

		#endregion

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
/*
		public virtual bool CompareTo(TableField toField, out DifferPropertiesDictionary diffList)
		{
			Type tp = typeof(TableField);
			return CompareHelper.GetDifferProperties(this, toField, tp, out diffList);
		}

		public static object Load(string XmlString, string attrTypeName)
		{
			Type fieldType = CompareHelper.GetFieldTypeByAttributeTypeName(attrTypeName);
			return Deserialize(XmlString, fieldType);
		}*/

//public static object Deserialize(string xmlString, Type fieldAttrType)
//{
//	try
//	{
//		xmlString = "<?xml version=\"1.0\" ?>" + xmlString;
//		TextReader sr = new StringReader(xmlString);
//		var xmlSerializer = new XmlSerializer(typeof(TableField));

//		var field = (TableField)xmlSerializer.Deserialize(sr);
//		return field;
//	}
//	catch (Exception ex)
//	{

//	}
//	return null;
//}