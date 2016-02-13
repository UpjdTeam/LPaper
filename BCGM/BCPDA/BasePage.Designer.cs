namespace BCPDA
{
    partial class BasePage
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
            this.pcExit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pcExit
            // 
            this.pcExit.Image = global::BCPDA.Properties.Resources.exit;
            this.pcExit.Location = new System.Drawing.Point(244, 12);
            this.pcExit.Name = "pcExit";
            this.pcExit.Size = new System.Drawing.Size(16, 16);
            this.pcExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcExit.TabIndex = 0;
            this.pcExit.TabStop = false;
            this.pcExit.Click += new System.EventHandler(this.pcExit_Click);
            // 
            // BasePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.pcExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = global::BCPDA.Properties.Resources.tumblr4;
            this.Name = "BasePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasePage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BasePage_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BasePage_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BasePage_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pcExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcExit;

    }
}