using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WAFMetastoreBuilder.UI
{
	public partial class WafXMLDesignerForm : Form
	{

		#region Ctor

		public WafXMLDesignerForm()
		{
			InitializeComponent();
		}

		#endregion

		#region Menu Handlers

		private void openToolStripButton_Click(object sender, EventArgs e)
		{
			using (var fd = new OpenFileDialog())
			{
				fd.Filter = "*.xml|*.xml";
				if (fd.ShowDialog() == DialogResult.OK)
				{
					var file = fd.OpenFile();
					//var sr = new StreamReader(file);
					//string firstline = sr.ReadLine();
					//string fetchXMLStr = sr.ReadToEnd();

					var doc = new XmlDocument();
					doc.Load(file);
					var metastoreElem = doc.DocumentElement;
					bool defaultNamespaceAttribute = metastoreElem.Attributes.Cast<XmlAttribute>().Count(a => a.Name.Equals("xmlns")) > 0;

					//get root element and deserialize by classes
					string xmlBodyStr = metastoreElem.OuterXml;

					this.metastoreXMLControl.LoadWAFMetadataXML(xmlBodyStr, defaultNamespaceAttribute);
					file.Close();
				}
			}
		}

		private void saveToolStripButton_Click(object sender, EventArgs e)
		{
			using (var fd = new SaveFileDialog())
			{
				fd.Filter = "*.xml|*.xml";
				if (fd.ShowDialog() == DialogResult.OK)
					this.metastoreXMLControl.SaveToXMLFile(fd.FileName); // Save all metastore data to XML;           
			}
		}

		private void newToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				metastoreXMLControl.NewTemplate();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#endregion
	}
}