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
            this.comboBox_SelectElement = new System.Windows.Forms.ComboBox();
            this.trackBar_BlueColor = new System.Windows.Forms.TrackBar();
            this.trackBar_GreenColor = new System.Windows.Forms.TrackBar();
            this.trackBar_RedColor = new System.Windows.Forms.TrackBar();
            this.groupBox_ConfigText = new System.Windows.Forms.GroupBox();
            this.comboBox_FontSize = new System.Windows.Forms.ComboBox();
            this.comboBox_SelectFont = new System.Windows.Forms.ComboBox();
            this.comboBox_txtConfig = new System.Windows.Forms.ComboBox();
            this.groupBoxConfigColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BlueColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_GreenColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_RedColor)).BeginInit();
            this.groupBox_ConfigText.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConfigColor
            // 
            this.groupBoxConfigColor.Controls.Add(this.comboBox_SelectElement);
            this.groupBoxConfigColor.Controls.Add(this.trackBar_BlueColor);
            this.groupBoxConfigColor.Controls.Add(this.trackBar_GreenColor);
            this.groupBoxConfigColor.Controls.Add(this.trackBar_RedColor);
            this.groupBoxConfigColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxConfigColor.Location = new System.Drawing.Point(0, 0);
            this.groupBoxConfigColor.Name = "groupBoxConfigColor";
            this.groupBoxConfigColor.Size = new System.Drawing.Size(348, 183);
            this.groupBoxConfigColor.TabIndex = 0;
            this.groupBoxConfigColor.TabStop = false;
            this.groupBoxConfigColor.Text = "Конфигуратор цвета";
            // 
            // comboBox_SelectElement
            // 
            this.comboBox_SelectElement.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_SelectElement.FormattingEnabled = true;
            this.comboBox_SelectElement.Items.AddRange(new object[] {
            "цвет подложки калькулятора",
            "цвет табло",
            "цвет текста табло",
            "цвет цифровых кнопок",
            "цвет кнопки сброса",
            "цвет кнопок операций",
            "цвет текста всех кнопок"});
            this.comboBox_SelectElement.Location = new System.Drawing.Point(3, 151);
            this.comboBox_SelectElement.Name = "comboBox_SelectElement";
            this.comboBox_SelectElement.Size = new System.Drawing.Size(342, 21);
            this.comboBox_SelectElement.TabIndex = 3;
            this.comboBox_SelectElement.Tag = "";
            this.comboBox_SelectElement.Text = "Выбирите елемент для изменения цвета";
            this.comboBox_SelectElement.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // trackBar_BlueColor
            // 
            this.trackBar_BlueColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_BlueColor.Enabled = false;
            this.trackBar_BlueColor.Location = new System.Drawing.Point(3, 106);
            this.trackBar_BlueColor.Maximum = 255;
            this.trackBar_BlueColor.Name = "trackBar_BlueColor";
            this.trackBar_BlueColor.Size = new System.Drawing.Size(342, 45);
            this.trackBar_BlueColor.TabIndex = 2;
            this.trackBar_BlueColor.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_BlueColor.ValueChanged += new System.EventHandler(this.trackBar_Color_ValueChanget);
            // 
            // trackBar_GreenColor
            // 
            this.trackBar_GreenColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_GreenColor.Enabled = false;
            this.trackBar_GreenColor.Location = new System.Drawing.Point(3, 61);
            this.trackBar_GreenColor.Maximum = 255;
            this.trackBar_GreenColor.Name = "trackBar_GreenColor";
            this.trackBar_GreenColor.Size = new System.Drawing.Size(342, 45);
            this.trackBar_GreenColor.TabIndex = 1;
            this.trackBar_GreenColor.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_GreenColor.ValueChanged += new System.EventHandler(this.trackBar_Color_ValueChanget);
            // 
            // trackBar_RedColor
            // 
            this.trackBar_RedColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.trackBar_RedColor.Enabled = false;
            this.trackBar_RedColor.Location = new System.Drawing.Point(3, 16);
            this.trackBar_RedColor.Maximum = 255;
            this.trackBar_RedColor.Name = "trackBar_RedColor";
            this.trackBar_RedColor.Size = new System.Drawing.Size(342, 45);
            this.trackBar_RedColor.TabIndex = 0;
            this.trackBar_RedColor.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar_RedColor.ValueChanged += new System.EventHandler(this.trackBar_Color_ValueChanget);
            // 
            // groupBox_ConfigText
            // 
            this.groupBox_ConfigText.Controls.Add(this.comboBox_FontSize);
            this.groupBox_ConfigText.Controls.Add(this.comboBox_SelectFont);
            this.groupBox_ConfigText.Controls.Add(this.comboBox_txtConfig);
            this.groupBox_ConfigText.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox_ConfigText.Location = new System.Drawing.Point(0, 183);
            this.groupBox_ConfigText.Name = "groupBox_ConfigText";
            this.groupBox_ConfigText.Size = new System.Drawing.Size(348, 99);
            this.groupBox_ConfigText.TabIndex = 1;
            this.groupBox_ConfigText.TabStop = false;
            this.groupBox_ConfigText.Text = "Конфигуратор шрифтов";
            // 
            // comboBox_FontSize
            // 
            this.comboBox_FontSize.Enabled = false;
            this.comboBox_FontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_FontSize.FormattingEnabled = true;
            this.comboBox_FontSize.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "8.25",
            "9",
            "12",
            "14",
            "16",
            "20",
            "25",
            "30",
            "35",
            "40",
            "42",
            "44",
            "50",
            "55"});
            this.comboBox_FontSize.Location = new System.Drawing.Point(220, 55);
            this.comboBox_FontSize.Name = "comboBox_FontSize";
            this.comboBox_FontSize.Size = new System.Drawing.Size(122, 21);
            this.comboBox_FontSize.TabIndex = 2;
            this.comboBox_FontSize.Text = "Размер шрифта";
            // 
            // comboBox_SelectFont
            // 
            this.comboBox_SelectFont.Enabled = false;
            this.comboBox_SelectFont.FormattingEnabled = true;
            this.comboBox_SelectFont.Items.AddRange(new object[] {
            "Microsoft Sans Serif",
            "Arial",
            "Times New Roman"});
            this.comboBox_SelectFont.Location = new System.Drawing.Point(3, 55);
            this.comboBox_SelectFont.Name = "comboBox_SelectFont";
            this.comboBox_SelectFont.Size = new System.Drawing.Size(211, 21);
            this.comboBox_SelectFont.TabIndex = 1;
            this.comboBox_SelectFont.Text = "Шрифт";
            // 
            // comboBox_txtConfig
            // 
            this.comboBox_txtConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox_txtConfig.FormattingEnabled = true;
            this.comboBox_txtConfig.Items.AddRange(new object[] {
            "шрифт табло",
            "шрифт кнопок"});
            this.comboBox_txtConfig.Location = new System.Drawing.Point(3, 16);
            this.comboBox_txtConfig.Name = "comboBox_txtConfig";
            this.comboBox_txtConfig.Size = new System.Drawing.Size(342, 21);
            this.comboBox_txtConfig.TabIndex = 0;
            this.comboBox_txtConfig.SelectedIndexChanged += new System.EventHandler(this.comboBox_txtConfig_SelectedIndexChanged);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 445);
            this.Controls.Add(this.groupBox_ConfigText);
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
            this.groupBox_ConfigText.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConfigColor;
        private System.Windows.Forms.TrackBar trackBar_BlueColor;
        private System.Windows.Forms.TrackBar trackBar_GreenColor;
        private System.Windows.Forms.TrackBar trackBar_RedColor;
        private System.Windows.Forms.ComboBox comboBox_SelectElement;
        private System.Windows.Forms.GroupBox groupBox_ConfigText;
        private System.Windows.Forms.ComboBox comboBox_txtConfig;
        private System.Windows.Forms.ComboBox comboBox_FontSize;
        private System.Windows.Forms.ComboBox comboBox_SelectFont;
    }
}