using System;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualBasic.CompilerServices;

namespace FetchXMLBuilder.Business
{
	[Serializable, XmlRoot("link-entity")]
	public class LinkedForm : Form
	{
		#region Fields

		// Entity _parentEntity = null; // Entity or Linked Entity - we don't know

		private string _linkAlias = string.Empty;
		private string _linkFrom = string.Empty;
		private string _linkTo = string.Empty;
		private string _linkType = string.Empty;

		#endregion

		#region Properties

		[XmlAttribute(AttributeName = "alias")]
		public string LinkAlias
		{
			get { return _linkAlias; }
			set { _linkAlias = value; }
		}

		[XmlAttribute(AttributeName = "from")]
		public string LinkFrom
		{
			get { return _linkFrom; }
			set { _linkFrom = value; }
		}

		[XmlAttribute(AttributeName = "to")]
		public string LinkTo
		{
			get { return _linkTo; }
			set { _linkTo = value; }
		}

		[XmlAttribute(AttributeName = "link-type")]
		public string LinkType
		{
			get { return _linkType; }
			set { _linkType = value; }
		}

		/*
		public new Entity Parent
		{
				get { return _parentEntity; }
				set { _parentEntity = value; }
		}
		*/

		#endregion

		#region Methods

		public LinkedEntity()
			: this(string.Empty)
		{
		}

		public LinkedEntity(string name)
			: base(name)
		{
		}


		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("link-entity name='" + this.Name + "'");
			sb.Append(" from='" + this.LinkFrom + "'");
			sb.Append(" to='" + this.LinkTo + "'");
			sb.Append(" link-type='" + this.LinkType + "'");

			return sb.ToString();
			/*
			if ((this.LinkAlias != null) && (this.LinkAlias.Length > 0))
			{
					return this.LinkAlias;
			}
			return this.Name;
			*/
		}

		public override string ToXML()
		{
			string text = "<link-entity name='" + this.Name + "' ";
			if (!string.IsNullOrEmpty(this.LinkFrom))
			{
				text = text + "from='" + this.LinkFrom + "' ";
			}
			if (!string.IsNullOrEmpty(this.LinkTo))
			{
				text = text + "to='" + this.LinkTo + "' ";
			}
			if (!string.IsNullOrEmpty(this.LinkAlias))
			{
				text = text + "alias='" + this.LinkAlias + "' ";
			}
			string linkType = this.LinkType;
			if (Operators.CompareString(linkType, "natural", false) == 0)
			{
				text = text + "link-type='natural' ";
			}
			else if (Operators.CompareString(linkType, "inner", false) == 0)
			{
				text = text + "link-type='inner' ";
			}
			else if (Operators.CompareString(linkType, "outer", false) == 0)
			{
				text = text + "link-type='outer' ";
			}
			text = text + ">";
			if (base.AllAttributes)
			{
				text = text + "<all-attributes />";
			}
			if (!base.AllAttributes & base.NoAttributes)
			{
				text = text + "<no-attrs />";
			}
			if (!base.AllAttributes & !base.NoAttributes)
			{
				text = this.Actions.Aggregate(text, (current, attribute) => current + attribute.ToXML());
			}
			try
			{
				text = this.Filters.Aggregate(text, (current, filter) => current + filter.ToXML());
			}
			finally
			{
				/*
				IEnumerator<Filter> enumerator2 = Filters.GetEnumerator();
				if (enumerator2 != null)
				{
						enumerator2.Dispose();
				}*/
			}
			try
			{
				text = this.Orders.Aggregate(text, (current, order) => current + order.ToXML());
			}
			finally
			{
				/*
				IEnumerator<Order> enumerator3 = Orders.GetEnumerator();
				if (enumerator3 != null)
				{
						enumerator3.Dispose();
				}*/
			}
			text = this.LinkedEntities.Aggregate(text, (current, entity) => current + entity.ToXML());
			return (text + "</link-entity>");
		}

		#endregion
	}
}