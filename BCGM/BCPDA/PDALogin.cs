using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BCPDA
{
    public partial class PDALogin : BCPDA.BasePage
    {
        // <summary>
        /// 条形码系统数据库连接字符串
        /// </summary>
        public static string WmsConstring;

        /// <summary>
        /// U8账套数据库连接字符串
        /// </summary>
        public static string U8Constring;

        /// <summary>
        /// 金蝶连接字符串
        /// </summary>
        public static string KisConString;

        /// <summary>
        /// 登陆用户名
        /// </summary>
        public static string Lname;

        /// <summary>
        /// 登陆用户角色
        /// </summary>
        public static string Lrole;


        public static string LCode;

        /// <summary>
        /// 登陆时间
        /// </summary>
        public static DateTime Ltime;

        public static string Account;

        public static string Server;

        public PDALogin()
        {
            InitializeComponent();
        }

        private void PDALogin_Load(object sender, EventArgs e)
        {
            BExit = false;
            WmsConstring = Properties.Settings.Default.PDACON;
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            lblLogin.Image = Properties.Resources.LoginForm_login_btn_hover;
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.Image = Properties.Resources.LoginForm_login_btn;
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            OK_Login();
        }

        private void OK_Login()
        {

            if (string.IsNullOrEmpty(WmsConstring))
            {
                MessageBox.Show(@"服务器填写错误，或者服务器端未配置正确！", @"注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            lblLogin.Image = Properties.Resources.LoginForm_login_btn_click;

            if (string.IsNullOrEmpty(utxtUser.Text.Trim()) || string.IsNullOrEmpty(utxtPassword.Text))
            {
                MessageBox.Show(@"用户名和密码必填！", @"注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            var con = new SqlConnection(WmsConstring);
            var cmd = new SqlCommand
            {
                Connection = con,
                CommandText =
                    "select uName,uRole,uCode from BUser where (uName=@uName or uCode=@uName) and uPassword=@uPassword"
            };

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@uName", utxtUser.Text);
            cmd.Parameters.AddWithValue("@uPassword", WmsFunction.GetMd5Hash(utxtPassword.Text));
            con.Open();
            var dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            if (dr.Read()) //直接登陆
            {
                Account = "";
                Server = "";
                Properties.Settings.Default.cUser = utxtUser.Text;
                Properties.Settings.Default.cServer = Server;
                Properties.Settings.Default.cAccount = Account;
                Properties.Settings.Default.Save();

                Lname = dr["uName"].ToString(); //把登陆名和登陆服务器保存到静态变量中
                Ltime =DateTime.Now;
                Lrole = dr["uRole"].ToString();
                LCode = dr["uCode"].ToString();
                dr.Close();
                Hide();
                var pdaMain = new PDAMain(this);
                pdaMain.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"用户名或密码错误，请联系管理员！", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void utxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                OK_Login();
            }
        }
    }
}
