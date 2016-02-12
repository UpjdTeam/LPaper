using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace BCGM
{
    public partial class WmsMainChild : Form
    {
        public WmsMainChild()
        {
            InitializeComponent();
        }

        private void NaMainChild_Load(object sender, EventArgs e)
        {
            BackgroundImageLayout = ImageLayout.Stretch;
            BackgroundImage = Properties.Resources.title_banner;
        }
    }
}
