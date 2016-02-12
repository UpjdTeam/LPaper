using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace BCGM
{
    public partial class WmsLogin : DevExpress.XtraEditors.XtraForm
    {
        
        /// <summary>
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

        public WmsLogin()
        {
            InitializeComponent();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"确定退出吗？", @"是否确定？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
                DialogResult.Yes)
                return;
            Application.Exit();

            
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

            //记住账套信息
            if (utxtAccount.Value == null || WmsConstring == null)
            {
                MessageBox.Show(@"账套、服务器选择有误！", @"注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                Account = utxtAccount.Text;
                Server = utxtServer.Text;
                Properties.Settings.Default.cUser = utxtUser.Text;
                Properties.Settings.Default.cServer = Server;
                Properties.Settings.Default.cAccount = Account;
                Properties.Settings.Default.Save();

                Lname = dr["uName"].ToString(); //把登陆名和登陆服务器保存到静态变量中
                Ltime = udDate.DateTime;
                Lrole = dr["uRole"].ToString();
                LCode = dr["uCode"].ToString();
                dr.Close();
                Hide();
                var bmsloading = new WmsLoading();
                bmsloading.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"用户名或密码错误，请联系管理员！", @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       

        private void BMSLogin_Load(object sender, EventArgs e)
        {
            utxtServer.Text = Properties.Settings.Default.cServer;
            utxtAccount.Text = Properties.Settings.Default.cAccount;
            utxtUser.Text = Properties.Settings.Default.cUser;
            WmsConstring = Properties.Settings.Default.BCGM_2014ConnectionString;
        }
        
        
        /// <summary>
        /// 拆分连接字符串得到数据库服务器和数据库
        /// </summary>
        /// <param name="constr"></param>
        public void SpitConstr(string constr)
        {
            utxtServer.Text = constr.Substring(constr.IndexOf("e=", StringComparison.Ordinal) + 2, 
                constr.IndexOf(";I", StringComparison.Ordinal) - constr.IndexOf("e=", StringComparison.Ordinal) - 2);
            utxtAccount.Text = constr.Substring(constr.IndexOf("g=", StringComparison.Ordinal) + 2, constr.IndexOf(";P", StringComparison.Ordinal) - constr.IndexOf("g=", StringComparison.Ordinal) - 2); //对应数据库
        }

        
        private void utxtPassword_EditorButtonClick(object sender, Infragistics.Win.UltraWinEditors.EditorButtonEventArgs e)
        {
            if (string.IsNullOrEmpty(WmsConstring))
            {
                MessageBox.Show(@"服务器填写错误，或者服务器端未配置正确！", @"注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var bmp = new BaseModifyPwd();
            bmp.ShowDialog();
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