namespace BCGM
{
    partial class WmsLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WmsLogin));
            Infragistics.Win.UltraWinEditors.EditorButton editorButton1 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton2 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton3 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton4 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton5 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton6 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton7 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton8 = new Infragistics.Win.UltraWinEditors.EditorButton("btnConSet");
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton9 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            this.lblExit = new System.Windows.Forms.Label();
            this.Tooltip = new DevExpress.Utils.ToolTipController(this.components);
            this.udDate = new Infragistics.Win.UltraWinEditors.UltraDateTimeEditor();
            this.ultraTextEditor5 = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtUser = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtServer = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.uPanelMain = new Infragistics.Win.Misc.UltraPanel();
            this.utxtAccount = new Infragistics.Win.UltraWinEditors.UltraComboEditor();
            this.lblLogin = new System.Windows.Forms.Label();
            this.ultraFormattedLinkLabel1 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.udDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtServer)).BeginInit();
            this.uPanelMain.ClientArea.SuspendLayout();
            this.uPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.utxtAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Image = ((System.Drawing.Image)(resources.GetObject("lblExit.Image")));
            this.lblExit.Location = new System.Drawing.Point(462, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(26, 13);
            this.lblExit.TabIndex = 3;
            this.Tooltip.SetToolTip(this.lblExit, "退出？");
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // udDate
            // 
            this.udDate.AutoSize = false;
            appearance1.Image = global::BCGM.Properties.Resources.LoginForm_time;
            editorButton1.Appearance = appearance1;
            this.udDate.ButtonsLeft.Add(editorButton1);
            this.udDate.Location = new System.Drawing.Point(16, 174);
            this.udDate.Name = "udDate";
            this.udDate.Size = new System.Drawing.Size(315, 29);
            this.udDate.TabIndex = 5;
            this.Tooltip.SetTitle(this.udDate, "日期");
            this.Tooltip.SetToolTip(this.udDate, "选择您的登陆日期");
            // 
            // ultraTextEditor5
            // 
            this.ultraTextEditor5.AutoSize = false;
            appearance2.Image = global::BCGM.Properties.Resources.LoginForm_cn;
            editorButton2.Appearance = appearance2;
            this.ultraTextEditor5.ButtonsLeft.Add(editorButton2);
            appearance3.Image = global::BCGM.Properties.Resources.LoginForm_dropdown;
            editorButton3.Appearance = appearance3;
            editorButton3.Width = 18;
            this.ultraTextEditor5.ButtonsRight.Add(editorButton3);
            this.ultraTextEditor5.Location = new System.Drawing.Point(16, 141);
            this.ultraTextEditor5.Name = "ultraTextEditor5";
            this.ultraTextEditor5.Size = new System.Drawing.Size(315, 29);
            this.ultraTextEditor5.TabIndex = 4;
            this.ultraTextEditor5.Text = "CN";
            this.Tooltip.SetTitle(this.ultraTextEditor5, "语言");
            this.Tooltip.SetToolTip(this.ultraTextEditor5, "选择您的语言");
            // 
            // utxtPassword
            // 
            this.utxtPassword.AutoSize = false;
            appearance4.Image = global::BCGM.Properties.Resources.LoginForm_password;
            editorButton4.Appearance = appearance4;
            this.utxtPassword.ButtonsLeft.Add(editorButton4);
            editorButton5.Text = "修改密码";
            editorButton5.Width = 70;
            this.utxtPassword.ButtonsRight.Add(editorButton5);
            this.utxtPassword.Location = new System.Drawing.Point(16, 75);
            this.utxtPassword.Name = "utxtPassword";
            this.utxtPassword.PasswordChar = '*';
            this.utxtPassword.Size = new System.Drawing.Size(315, 29);
            this.utxtPassword.TabIndex = 0;
            this.Tooltip.SetTitle(this.utxtPassword, "密码");
            this.Tooltip.SetToolTip(this.utxtPassword, "请输入您的密码");
            this.utxtPassword.EditorButtonClick += new Infragistics.Win.UltraWinEditors.EditorButtonEventHandler(this.utxtPassword_EditorButtonClick);
            this.utxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.utxtPassword_KeyDown);
            // 
            // utxtUser
            // 
            this.utxtUser.AutoSize = false;
            appearance5.Image = global::BCGM.Properties.Resources.LoginForm_user;
            editorButton6.Appearance = appearance5;
            this.utxtUser.ButtonsLeft.Add(editorButton6);
            this.utxtUser.Location = new System.Drawing.Point(16, 42);
            this.utxtUser.Name = "utxtUser";
            this.utxtUser.Size = new System.Drawing.Size(315, 29);
            this.utxtUser.TabIndex = 1;
            this.Tooltip.SetTitle(this.utxtUser, "用户名");
            this.Tooltip.SetToolTip(this.utxtUser, "请输入您的用户名");
            // 
            // utxtServer
            // 
            appearance6.BackColor = System.Drawing.Color.White;
            this.utxtServer.Appearance = appearance6;
            this.utxtServer.AutoSize = false;
            this.utxtServer.BackColor = System.Drawing.Color.White;
            appearance7.Image = global::BCGM.Properties.Resources.LoginForm_server;
            editorButton7.Appearance = appearance7;
            this.utxtServer.ButtonsLeft.Add(editorButton7);
            appearance8.Image = global::BCGM.Properties.Resources.LoginForm_dropdown;
            editorButton8.Appearance = appearance8;
            editorButton8.Key = "btnConSet";
            editorButton8.Width = 18;
            this.utxtServer.ButtonsRight.Add(editorButton8);
            this.utxtServer.Location = new System.Drawing.Point(16, 9);
            this.utxtServer.Name = "utxtServer";
            this.utxtServer.Size = new System.Drawing.Size(315, 29);
            this.utxtServer.TabIndex = 2;
            this.Tooltip.SetTitle(this.utxtServer, "服务器");
            this.Tooltip.SetToolTip(this.utxtServer, "请选择你业务系统的服务器");
            // 
            // uPanelMain
            // 
            appearance9.BackColor = System.Drawing.Color.White;
            appearance9.BorderColor = System.Drawing.Color.Silver;
            this.uPanelMain.Appearance = appearance9;
            this.uPanelMain.BorderStyle = Infragistics.Win.UIElementBorderStyle.Rounded4;
            // 
            // uPanelMain.ClientArea
            // 
            this.uPanelMain.ClientArea.Controls.Add(this.utxtAccount);
            this.uPanelMain.ClientArea.Controls.Add(this.udDate);
            this.uPanelMain.ClientArea.Controls.Add(this.ultraTextEditor5);
            this.uPanelMain.ClientArea.Controls.Add(this.utxtPassword);
            this.uPanelMain.ClientArea.Controls.Add(this.utxtUser);
            this.uPanelMain.ClientArea.Controls.Add(this.utxtServer);
            this.uPanelMain.Location = new System.Drawing.Point(75, 127);
            this.uPanelMain.Name = "uPanelMain";
            this.uPanelMain.Size = new System.Drawing.Size(350, 216);
            this.uPanelMain.TabIndex = 0;
            // 
            // utxtAccount
            // 
            this.utxtAccount.AutoSize = false;
            appearance10.Image = global::BCGM.Properties.Resources.LoginForm_defalt;
            editorButton9.Appearance = appearance10;
            this.utxtAccount.ButtonsLeft.Add(editorButton9);
            this.utxtAccount.Location = new System.Drawing.Point(16, 107);
            this.utxtAccount.Name = "utxtAccount";
            this.utxtAccount.Size = new System.Drawing.Size(315, 29);
            this.utxtAccount.TabIndex = 3;
            this.utxtAccount.Text = "BCGM_2014";
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Image = global::BCGM.Properties.Resources.LoginForm_login_btn;
            this.lblLogin.Location = new System.Drawing.Point(152, 369);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(196, 45);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = " 登陆";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblLogin_MouseLeave);
            this.lblLogin.MouseHover += new System.EventHandler(this.lblLogin_MouseEnter);
            // 
            // ultraFormattedLinkLabel1
            // 
            appearance11.BackColor = System.Drawing.Color.Transparent;
            appearance11.FontData.BoldAsString = "False";
            appearance11.FontData.ItalicAsString = "False";
            appearance11.FontData.Name = "Tahoma";
            appearance11.FontData.SizeInPoints = 9F;
            appearance11.FontData.StrikeoutAsString = "False";
            appearance11.FontData.UnderlineAsString = "False";
            appearance11.TextHAlignAsString = "Center";
            this.ultraFormattedLinkLabel1.Appearance = appearance11;
            this.ultraFormattedLinkLabel1.Location = new System.Drawing.Point(99, 433);
            this.ultraFormattedLinkLabel1.Name = "ultraFormattedLinkLabel1";
            this.ultraFormattedLinkLabel1.Size = new System.Drawing.Size(303, 19);
            this.ultraFormattedLinkLabel1.TabIndex = 7;
            this.ultraFormattedLinkLabel1.TabStop = true;
            this.ultraFormattedLinkLabel1.Value = "Copyright @ 2015 Powered By <a title=\"ZhangLing\" href=\"https://www.baidu.com/\">ZE" +
    "RO</a> 保留所有权利.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(77, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "条码+移动采集的产品信息化管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(163, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "基于条码技术+移动信息采集技术";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(371, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "V1.0";
            // 
            // WmsLogin
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::BCGM.Properties.Resources.BackgroundImageStore;
            this.ClientSize = new System.Drawing.Size(500, 475);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ultraFormattedLinkLabel1);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.uPanelMain);
            this.Controls.Add(this.lblExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::BCGM.Properties.Resources.scanicon;
            this.LookAndFeel.SkinName = "Office 2007 Blue";
            this.Name = "WmsLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMS登陆";
            this.Load += new System.EventHandler(this.BMSLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.udDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraTextEditor5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtServer)).EndInit();
            this.uPanelMain.ClientArea.ResumeLayout(false);
            this.uPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.utxtAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExit;
        private DevExpress.Utils.ToolTipController Tooltip;
        private Infragistics.Win.Misc.UltraPanel uPanelMain;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtServer;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor5;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtPassword;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtUser;
        private Infragistics.Win.UltraWinEditors.UltraDateTimeEditor udDate;
        private System.Windows.Forms.Label lblLogin;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedLinkLabel ultraFormattedLinkLabel1;
        private Infragistics.Win.UltraWinEditors.UltraComboEditor utxtAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}