namespace BCPDA
{
    partial class PDALogin
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            Infragistics.Win.UltraWinEditors.EditorButton editorButton1 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinEditors.EditorButton editorButton2 = new Infragistics.Win.UltraWinEditors.EditorButton();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            this.utxtPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utxtUser = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.label2 = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.utxtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUser)).BeginInit();
            this.SuspendLayout();
            // 
            // utxtPassword
            // 
            this.utxtPassword.AutoSize = false;
            appearance1.Image = global::BCPDA.Properties.Resources.LoginForm_password;
            editorButton1.Appearance = appearance1;
            this.utxtPassword.ButtonsLeft.Add(editorButton1);
            this.utxtPassword.Location = new System.Drawing.Point(43, 187);
            this.utxtPassword.Name = "utxtPassword";
            this.utxtPassword.PasswordChar = '*';
            this.utxtPassword.Size = new System.Drawing.Size(199, 29);
            this.utxtPassword.TabIndex = 10;
            this.utxtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.utxtPassword_KeyDown);
            // 
            // utxtUser
            // 
            this.utxtUser.AutoSize = false;
            appearance2.Image = global::BCPDA.Properties.Resources.LoginForm_user;
            editorButton2.Appearance = appearance2;
            this.utxtUser.ButtonsLeft.Add(editorButton2);
            this.utxtUser.Location = new System.Drawing.Point(43, 140);
            this.utxtUser.Name = "utxtUser";
            this.utxtUser.Size = new System.Drawing.Size(199, 29);
            this.utxtUser.TabIndex = 11;
            this.utxtUser.Text = "Demo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(20, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "产品生产管理系统PDA端";
            // 
            // lblLogin
            // 
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogin.Image = global::BCPDA.Properties.Resources.LoginForm_login_btn;
            this.lblLogin.Location = new System.Drawing.Point(44, 249);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(196, 45);
            this.lblLogin.TabIndex = 12;
            this.lblLogin.Text = " 登陆";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblLogin_MouseLeave);
            this.lblLogin.MouseHover += new System.EventHandler(this.lblLogin_MouseEnter);
            // 
            // PDALogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.utxtPassword);
            this.Controls.Add(this.utxtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLogin);
            this.Name = "PDALogin";
            this.Load += new System.EventHandler(this.PDALogin_Load);
            this.Controls.SetChildIndex(this.lblLogin, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.utxtUser, 0);
            this.Controls.SetChildIndex(this.utxtPassword, 0);
            ((System.ComponentModel.ISupportInitialize)(this.utxtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.utxtUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtPassword;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor utxtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLogin;

    }
}
