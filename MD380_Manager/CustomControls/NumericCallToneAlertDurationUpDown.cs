using System;
using System.Linq;
using System.Windows.Forms;

namespace MD380_Manager
{
    public partial class NumericCallToneAlertDurationUpDown : NumericUpDown
    {
        public NumericCallToneAlertDurationUpDown()
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
                Text = "Continue";
            else
                base.UpdateEditText();
        }
    }
}
