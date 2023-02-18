namespace SimpleCalc
{
    partial class AboutForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_AboutForm = new System.Windows.Forms.TextBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "О продвинутом калькуляторе";
            // 
            // textBox_AboutForm
            // 
            this.textBox_AboutForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AboutForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_AboutForm.Enabled = false;
            this.textBox_AboutForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AboutForm.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBox_AboutForm.HideSelection = false;
            this.textBox_AboutForm.Location = new System.Drawing.Point(13, 36);
            this.textBox_AboutForm.Multiline = true;
            this.textBox_AboutForm.Name = "textBox_AboutForm";
            this.textBox_AboutForm.ReadOnly = true;
            this.textBox_AboutForm.Size = new System.Drawing.Size(315, 203);
            this.textBox_AboutForm.TabIndex = 1;
            this.textBox_AboutForm.Text = "Благодарим за использования програмы \"Продвинутый калькулятор\".\r\n\r\nСкачать самую " +
    "последнюю версию можно по ссылке\r\nна\r\n 🅿🆁🅾🅶🆁🅰🅼🅸🅽🅶   🅱🆈   🅲🅴🆉🅽.🆅" +
    "🅸\r\n";
            this.textBox_AboutForm.TextChanged += new System.EventHandler(this.textBox_AboutForm_TextChanged);
            // 
            // button_Ok
            // 
            this.button_Ok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Ok.Location = new System.Drawing.Point(135, 245);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(88, 23);
            this.button_Ok.TabIndex = 2;
            this.button_Ok.Text = "ОК";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.linkLabel1.Location = new System.Drawing.Point(37, 186);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 23);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Tag = "linkGitHub";
            this.linkLabel1.Text = "GitHub";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 280);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.textBox_AboutForm);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_AboutForm;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}