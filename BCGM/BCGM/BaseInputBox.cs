using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BCGM
{
    public partial class BaseInputBox : Form
    {
        public BaseInputBox(bool bInt)
        {
            InitializeComponent();
            uneInput.MaskInput = "nnnnnn";
            uneInput.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Integer;
        }

        public decimal InputValue; 

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            GetInputValue();
        }

        private void GetInputValue()
        {
            if (uneInput.Value == null || string.IsNullOrEmpty(uneInput.Value.ToString()))
            {
                MessageBox.Show(@"无效的输入");
                return;
            }
            decimal.TryParse(uneInput.Value.ToString(), out InputValue);
            DialogResult = DialogResult.Yes;
        }
    }
}
