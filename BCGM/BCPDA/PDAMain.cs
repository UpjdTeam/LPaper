using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BCPDA
{
    public partial class PDAMain : BCPDA.BasePage
    {
        private PDALogin pdaLogin;
        public PDAMain(PDALogin pLogin)
        {
            InitializeComponent();
            pdaLogin = pLogin;
        }

        private void PDAMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            pdaLogin.Show();
        }

        private void PDAMain_Load(object sender, EventArgs e)
        {
            BExit = true;
        }
    }
}
