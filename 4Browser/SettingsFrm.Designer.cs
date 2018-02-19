namespace _4Browser
{
    partial class SettingsFrm
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
            this.BtnAbort = new System.Windows.Forms.Button();
            this.BtnOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtUrls4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrls3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrls2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrls1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAbort
            // 
            this.BtnAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnAbort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAbort.Location = new System.Drawing.Point(588, 328);
            this.BtnAbort.Name = "BtnAbort";
            this.BtnAbort.Size = new System.Drawing.Size(75, 23);
            this.BtnAbort.TabIndex = 25;
            this.BtnAbort.Text = "&Annuler";
            this.BtnAbort.UseVisualStyleBackColor = true;
            this.BtnAbort.Click += new System.EventHandler(this.BtnAbort_Click);
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnOk.Location = new System.Drawing.Point(507, 328);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 23);
            this.BtnOk.TabIndex = 24;
            this.BtnOk.Text = "&Gem";
            this.BtnOk.UseVisualStyleBackColor = true;
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(239, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "&Skift side efter sek.";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(342, 326);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown1.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox1.Location = new System.Drawing.Point(15, 327);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Start i &kiosk tilstand";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtUrls4
            // 
            this.txtUrls4.AcceptsReturn = true;
            this.txtUrls4.Location = new System.Drawing.Point(342, 183);
            this.txtUrls4.Multiline = true;
            this.txtUrls4.Name = "txtUrls4";
            this.txtUrls4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUrls4.Size = new System.Drawing.Size(321, 137);
            this.txtUrls4.TabIndex = 20;
            this.txtUrls4.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(339, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Url\'s for browser &4";
            // 
            // txtUrls3
            // 
            this.txtUrls3.AcceptsReturn = true;
            this.txtUrls3.Location = new System.Drawing.Point(15, 183);
            this.txtUrls3.Multiline = true;
            this.txtUrls3.Name = "txtUrls3";
            this.txtUrls3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUrls3.Size = new System.Drawing.Size(321, 137);
            this.txtUrls3.TabIndex = 18;
            this.txtUrls3.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(12, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Url\'s for browser &3";
            // 
            // txtUrls2
            // 
            this.txtUrls2.AcceptsReturn = true;
            this.txtUrls2.Location = new System.Drawing.Point(342, 26);
            this.txtUrls2.Multiline = true;
            this.txtUrls2.Name = "txtUrls2";
            this.txtUrls2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUrls2.Size = new System.Drawing.Size(321, 137);
            this.txtUrls2.TabIndex = 16;
            this.txtUrls2.WordWrap = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(339, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Url\'s for browser &2";
            // 
            // txtUrls1
            // 
            this.txtUrls1.AcceptsReturn = true;
            this.txtUrls1.Location = new System.Drawing.Point(15, 26);
            this.txtUrls1.Multiline = true;
            this.txtUrls1.Name = "txtUrls1";
            this.txtUrls1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUrls1.Size = new System.Drawing.Size(321, 137);
            this.txtUrls1.TabIndex = 14;
            this.txtUrls1.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Url\'s for browser &1";
            // 
            // SettingsFrm
            // 
            this.AcceptButton = this.BtnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnAbort;
            this.ClientSize = new System.Drawing.Size(672, 361);
            this.Controls.Add(this.BtnAbort);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtUrls4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrls3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUrls2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrls1);
            this.Controls.Add(this.label1);
            this.Name = "SettingsFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Instillinger";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAbort;
        private System.Windows.Forms.Button BtnOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtUrls4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrls3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrls2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrls1;
        private System.Windows.Forms.Label label1;
    }
}