using System;
using System.Linq;
using System.Windows.Forms;

namespace MD380_Manager.CustomControls
{
    public partial class NumericMenuHangTimeUpDown : NumericUpDown
    {
        public NumericMenuHangTimeUpDown()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void UpdateEditText()
        {
            if (Value == 0)
                Text = "Hang";
            else
                base.UpdateEditText();
        }
    }
}
