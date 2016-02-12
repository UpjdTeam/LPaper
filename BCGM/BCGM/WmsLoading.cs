using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace BCGM
{
    public partial class WmsLoading : DevExpress.XtraEditors.XtraForm
    {
        public WmsLoading()
        {
            InitializeComponent();
        }

        private void BMSLoading_Load(object sender, EventArgs e)
        {
            timerLoading.Enabled = true;
            WmsFunction.GridFilter_Customizer();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            var bwmMain = new WmsMain();
            bwmMain.Show();
            timerLoading.Enabled = false;
            //timerLoading.Dispose();
            DialogResult = DialogResult.OK;
        }
    }
}