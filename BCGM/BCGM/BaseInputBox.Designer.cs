namespace BCGM
{
    partial class BaseInputBox
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
            this.uneInput = new Infragistics.Win.UltraWinEditors.UltraNumericEditor();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uneInput)).BeginInit();
            this.SuspendLayout();
            // 
            // uneInput
            // 
            this.uneInput.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uneInput.Location = new System.Drawing.Point(11, 26);
            this.uneInput.MaskInput = "nnnnnn.nnnn";
            this.uneInput.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uneInput.Name = "uneInput";
            this.uneInput.NumericType = Infragistics.Win.UltraWinEditors.NumericType.Decimal;
            this.uneInput.Size = new System.Drawing.Size(161, 31);
            this.uneInput.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(178, 26);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 31);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "确定";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // BaseInputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(265, 85);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.uneInput);
            this.Icon = global::BCGM.Properties.Resources.scanicon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BaseInputBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "格式输入框";
            ((System.ComponentModel.ISupportInitialize)(this.uneInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinEditors.UltraNumericEditor uneInput;
        private System.Windows.Forms.Button btnSubmit;
    }
}