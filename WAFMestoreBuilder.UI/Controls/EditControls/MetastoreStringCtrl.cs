
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
	public partial class MetastoreStringCtrl : BaseWAFCtrl
	{
		private MetastoreString _string;

		#region Ctor

		public MetastoreStringCtrl(WafXMLDesignerControl parentCtrl)
			: base(parentCtrl)
		{
			InitializeComponent();
		}

		#endregion

		#region Methods

		protected override void LoadDataToCtrl(BaseXMLElement elementData)
		{
		    base.LoadDataToCtrl(elementData);

			if (elementData != null)
			{
				_string = (MetastoreString)elementData;

				txtName.Text = _string.Name;
				txtValue.Text = _string.Value;
			}
		}

		protected override BaseXMLElement GetDataFromCtrl()
		{
			if (_string == null)
				_string = new MetastoreString();//if new

			_string.Name = txtName.Text;
			_string.Value = txtValue.Text;
			return _string;
		}

		#endregion

	}
}

