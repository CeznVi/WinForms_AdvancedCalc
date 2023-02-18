namespace SimpleCalc
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.groupBoxConfigColor = new System.Windows.Forms.GroupBox();
            this.trackBar_BlueColor = new System.Windows.Forms.TrackBar();
            this.trackBar_GreenColor = new System.Windows.Forms.TrackBar();
            this.trackBar_RedColor = new System.Windows.Forms.TrackBar();
            this.groupBoxConfigColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BlueColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_GreenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RedColor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxConfigColor
            // 
            this.groupBoxConfigColor.Controls.Add(this.trackBar_BlueColor);
            this.groupBoxConfigColor.Controls.Add(this.trackBar_GreenColor);
            this.groupBoxConfigColor.Controls.Add(this.trackBar_RedColor);
            this.groupBoxConfigColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxConfigColor.Location = new System.Drawing.Point(0, 0);
            this.groupBoxConfigColor.Name = "groupBoxConfigColor";
            this.groupBoxConfigColor.Size = new System.Drawing.Size(348, 315);
            this.groupBoxConfigColor.TabIndex = 0;
            this.groupBoxConfigColor.TabStop = false;
            this.groupBoxConfigColor.Text = "Конфигуратор цвета";
            // 
            // trackBar_BlueColor
            // 
            this.trackBar_BlueColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_BlueColor.Location = new System.Drawing.Point(3, 106);
            this.trackBar_BlueColor.Maximum = 255;
            this.trackBar_BlueColor.Name = "trackBar_BlueColor";
            this.trackBar_BlueColor.Size = new System.Drawing.Size(342, 45);
            this.trackBar_BlueColor.TabIndex = 2;
            this.trackBar_BlueColor.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // trackBar_GreenColor
            // 
            this.trackBar_GreenColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_GreenColor.Location = new System.Drawing.Point(3, 61);
            this.trackBar_GreenColor.Maximum = 255;
            this.trackBar_GreenColor.Name = "trackBar_GreenColor";
            this.trackBar_GreenColor.Size = new System.Drawing.Size(342, 45);
            this.trackBar_GreenColor.TabIndex = 1;
            this.trackBar_GreenColor.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // trackBar_RedColor
            // 
            this.trackBar_RedColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_RedColor.Location = new System.Drawing.Point(3, 16);
            this.trackBar_RedColor.Maximum = 255;
            this.trackBar_RedColor.Name = "trackBar_RedColor";
            this.trackBar_RedColor.Size = new System.Drawing.Size(342, 45);
            this.trackBar_RedColor.TabIndex = 0;
            this.trackBar_RedColor.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 445);
            this.Controls.Add(this.groupBoxConfigColor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Text = "Настройки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBoxConfigColor.ResumeLayout(false);
            this.groupBoxConfigColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BlueColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_GreenColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RedColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConfigColor;
        private System.Windows.Forms.TrackBar trackBar_BlueColor;
        private System.Windows.Forms.TrackBar trackBar_GreenColor;
        private System.Windows.Forms.TrackBar trackBar_RedColor;
    }
}