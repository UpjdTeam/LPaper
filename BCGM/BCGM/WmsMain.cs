using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Infragistics.Win.UltraWinExplorerBar;
using System.Reflection;

namespace BCGM
{
    public partial class WmsMain : Form
    {

        /// <summary>
        /// 表示是否弹出提示关闭当前应用程序
        /// 1表示不弹出.
        /// </summary>
        public static int Iclose;

        public WmsMain()
        {
            InitializeComponent();
        }

        private void BwmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Iclose == 1)
                return;
            e.Cancel = MessageBox.Show(@"确定退出吗？", @"是否退出？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void BwmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BwmMain_Load(object sender, EventArgs e)
        {
            Text = @"条码+移动采集的产品信息化管理系统                    @" +Properties.Settings.Default.Company;
            //显示主窗体
            var bwmMainChild = new WmsMainChild { MdiParent = this };
            bwmMainChild.Show();
            //设置状态栏显示内容
            uStatusBar.Panels[4].MarqueeInfo.Start();
            WmsFunction.GridFilter_Customizer();
            uStatusBar.Panels["tssl_Lname"].Text = @"操作员：" + WmsLogin.Lname;

            uStatusBar.Panels["tssl_Lserver"].Text = @"BarServer：" + WmsLogin.Server ;

            uStatusBar.Panels["cCompany"].Text = Properties.Settings.Default.Company;
            //获取角色权限
            GetMenuAuthority();
            if (WmsLogin.Lname.Equals("Demo"))
            {
                uExplorerBar.Groups["维护中心"].Visible = true;
                uExplorerBar.Groups["维护中心"].Items["用户管理"].Visible = true;
                uExplorerBar.Groups["维护中心"].Items["角色权限管理"].Visible = true;
            }
        }
        /// <summary>
        /// 获取登录用户角色权限
        /// </summary>
        private void GetMenuAuthority()
        {
            //开始读取权限,先显示Group再显示Items
            foreach (var iGroup in uExplorerBar.Groups)
            {
                foreach (var eItem in iGroup.Items)
                {
                    eItem.Visible = CanOperator(eItem.Key);
                }
            }
        }


        /// <summary>
        /// 是否有权限操作
        /// </summary>
        /// <returns></returns>
        private bool CanOperator(string cKey)
        {
            var cmd = new SqlCommand("select * from RoleFunction where rCode=@rCode and fCode=@fCode and isnull(bRight,0)=1");
            cmd.Parameters.AddWithValue("@rCode", WmsLogin.Lrole);
            cmd.Parameters.AddWithValue("@fCode", cKey);
            var wf = new WmsFunction(WmsLogin.WmsConstring);
            return wf.BoolExistTable(cmd);
        }

        private void uExplorerBar_ItemClick(object sender, ItemEventArgs e)
        {
            var cClass = WmsFunction.GetMenuClass(e.Item.Key);
            if (string.IsNullOrEmpty(cClass))
            {
                return;
            }
            var f = ExistForm(e.Item.Key);
            if (f == null) MenuDoubleClick(cClass);
            else f.Activate();
        }

        /// <summary>
        /// 通过点击的菜单来显示窗体
        /// </summary>
        /// <param name="cClass">str是表示当前点击的菜单对于的类名</param>
        public void MenuDoubleClick(string cClass)
        {
            var t = Type.GetType(cClass);
            if (t == null) return;
            try
            {
                var obj = Activator.CreateInstance(t);
                t.InvokeMember("MdiParent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, obj, new object[] { this });
                t.InvokeMember("Show", BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, obj, null);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
        /// <summary>
        /// 判断对应窗体是否已经打开
        /// </summary>
        /// <param name="str">传入当前查询的窗体的名称</param>
        /// <returns>返回已经存在的窗体</returns>
        private Form ExistForm(string str)
        {
            return MdiChildren.FirstOrDefault(f => f.Text == str);
        }

        private void MdiManager_InitializeContextMenu(object sender, Infragistics.Win.UltraWinTabbedMdi.MdiTabContextMenuEventArgs e)
        {
            foreach (Infragistics.Win.IGControls.IGMenuItem item in e.ContextMenu.MenuItems)
            {
                switch (item.Text)
                {
                    case "&Close":
                        item.Text = @"关闭";
                        break;
                    case "New Hori&zontal Tab Group":
                        item.Text = @"新建横向分组";
                        break;
                    case "New &Vertical Tab Group":
                        item.Text = @"新建坚向分组";
                        break;
                    case "Move to Ne&xt Tab Group":
                        item.Text = @"下一分组";
                        break;
                    case "Move to P&revious Tab Group":
                        item.Text = @"上一分组";
                        break;
                    case "C&ancel":
                        item.Text = @"取消";
                        break;
                }
            }
        }

        private void MdiManager_TabClosing(object sender, Infragistics.Win.UltraWinTabbedMdi.CancelableMdiTabEventArgs e)
        {
            //主界面不允许关闭
            if (e.Tab.Form.Text.Equals("主界面"))
                e.Cancel = true;
        }

        private void tsbConnect_Click(object sender, EventArgs e)
        {
            //using (var ab = new AboutJaran())
            //{
            //    ab.ShowDialog();
            //}
        }

       

        private void uStatusBar_ButtonClick(object sender, Infragistics.Win.UltraWinStatusBar.PanelEventArgs e)
        {
            using (var ab = new AboutVersion())
            {
                ab.ShowDialog();
            }
        }

        private void tsbRelogin_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tsmRelogin_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void tsbMenu_Click(object sender, EventArgs e)
        {
            uSplitterLeft.Collapsed = !uSplitterLeft.Collapsed;
        }

        private void 刷新权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetMenuAuthority();
        }
    }
}
