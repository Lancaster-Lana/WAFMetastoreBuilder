using System;
using WAFMetastoreBuilder.ENUMS;
using WAFMetastoreBuilder.WAFMetastoreElements;

namespace WAFMetastoreBuilder.UI
{
    public partial class SystemStringCtrl : BaseWAFCtrl
    {
        private SystemString _systemString;

        #region Ctor

        public SystemStringCtrl(WafXMLDesignerControl parentCtrl)
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
                _systemString = (SystemString)elementData;

                //EditManagerHelper.LoadConditionsFromSource(conditionsListBox, _field.Filters);
                //EditManagerHelper.LoadFieldsFromSource(subFiltersListBox, _field.);

                txtName.Text = _systemString.Name;
                txtValue.Text = _systemString.Value;
            }
        }

        protected override BaseXMLElement GetDataFromCtrl()
        {
            if (_systemString == null)
                _systemString = new SystemString();//if new

            _systemString.Name = txtName.Text;
            _systemString.Value = txtValue.Text;
            return _systemString;
        }

        #endregion

    }
}

