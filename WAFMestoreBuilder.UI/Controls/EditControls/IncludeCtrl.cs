using System;
using System.Windows.Forms;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
    public partial class IncludeCtrl : BaseWAFCtrl
    {
        private Include _include;

        #region Ctor

        public IncludeCtrl(WafXMLDesignerControl parentCtrl)
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
                _include = (Include)elementData;

                //EditManagerHelper.LoadConditionsFromSource(conditionsListBox, _field.Filters);
                //EditManagerHelper.LoadFieldsFromSource(subFiltersListBox, _field.);

                txtName.Text = _include.FileName;
            }
        }

        protected override BaseXMLElement GetDataFromCtrl()
        {
            if (_include == null)
                _include = new Include();//if new

            _include.FileName = txtName.Text;
            return _include;
        }

        private void btnOpenIncludePath_Click(object sender, EventArgs e)
        {
            var filePathForm = new OpenFileDialog();
            if (filePathForm.ShowDialog() == DialogResult.OK)
            {
                txtName.Text = filePathForm.FileName;
            }
        }

        #endregion
    }
}

