namespace WinSorting
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.cobInt = new System.Windows.Forms.ComboBox();
            this.cmbString = new System.Windows.Forms.ComboBox();
            this.CmbName = new System.Windows.Forms.ComboBox();
            this.BtnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 31);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(332, 167);
            this.txtName.TabIndex = 0;
            // 
            // cobInt
            // 
            this.cobInt.FormattingEnabled = true;
            this.cobInt.Location = new System.Drawing.Point(74, 258);
            this.cobInt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cobInt.Name = "cobInt";
            this.cobInt.Size = new System.Drawing.Size(70, 20);
            this.cobInt.TabIndex = 1;
            // 
            // cmbString
            // 
            this.cmbString.FormattingEnabled = true;
            this.cmbString.Location = new System.Drawing.Point(227, 257);
            this.cmbString.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbString.Name = "cmbString";
            this.cmbString.Size = new System.Drawing.Size(70, 20);
            this.cmbString.TabIndex = 2;
            // 
            // CmbName
            // 
            this.CmbName.FormattingEnabled = true;
            this.CmbName.Location = new System.Drawing.Point(356, 257);
            this.CmbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbName.Name = "CmbName";
            this.CmbName.Size = new System.Drawing.Size(70, 20);
            this.CmbName.TabIndex = 3;
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(464, 149);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(82, 49);
            this.BtnOK.TabIndex = 4;
            this.BtnOK.Text = "BtnOK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "numeric sorting";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "alphabetical order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "input text：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.CmbName);
            this.Controls.Add(this.cmbString);
            this.Controls.Add(this.cobInt);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cobInt;
        private System.Windows.Forms.ComboBox cmbString;
        private System.Windows.Forms.ComboBox CmbName;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

