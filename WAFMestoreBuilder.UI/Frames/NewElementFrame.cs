using System.Drawing;
using System.Windows.Forms;

namespace WAFMetastoreBuilder.UI
{
	
	/// <summary>
	/// Modal dialog with menu "save\edit\delete" commands for element of Metastore xml 
	/// </summary>
	public partial class NewElementFrame : Form
	{
		private BaseWAFCtrl _editCtrl = null;

		private NewElementFrame()
		{
			InitializeComponent();
		}

		public NewElementFrame(BaseWAFCtrl ctrl)
			: this()
		{
			_editCtrl = ctrl;
			_editCtrl.Command = CommandType.New;
			Size = new Size(_editCtrl.Size.Width +20, _editCtrl.Size.Height + 60);
			_editCtrl.Dock = DockStyle.Fill;
			Controls.Add(_editCtrl);
		}

        public NewElementFrame(WAFMetastoreElements.BaseXMLElement data)
			: this()
		{
			_editCtrl.LoadData(data);
		}
	}
}