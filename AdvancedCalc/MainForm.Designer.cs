namespace SimpleCalc
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.настройкиЦветаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.DarkGray;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.видToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(344, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.Checked = true;
            this.видToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартныйToolStripMenuItem,
            this.инженерныйToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            this.видToolStripMenuItem.Click += new System.EventHandler(this.видToolStripMenuItem_Click);
            // 
            // стандартныйToolStripMenuItem
            // 
            this.стандартныйToolStripMenuItem.Checked = true;
            this.стандартныйToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.стандартныйToolStripMenuItem.Name = "стандартныйToolStripMenuItem";
            this.стандартныйToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.стандартныйToolStripMenuItem.Text = "Стандартный";
            this.стандартныйToolStripMenuItem.Click += new System.EventHandler(this.стандартныйToolStripMenuItem_Click);
            // 
            // инженерныйToolStripMenuItem
            // 
            this.инженерныйToolStripMenuItem.Name = "инженерныйToolStripMenuItem";
            this.инженерныйToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.инженерныйToolStripMenuItem.Text = "Инженерный";
            this.инженерныйToolStripMenuItem.Click += new System.EventHandler(this.инженерныйToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиЦветаToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.BackColor = System.Drawing.Color.LightGray;
            this.textBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult.ForeColor = System.Drawing.Color.Gray;
            this.textBoxResult.Location = new System.Drawing.Point(0, 27);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(344, 70);
            this.textBoxResult.TabIndex = 1;
            this.textBoxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.BackColor = System.Drawing.Color.DarkGray;
            this.panel.Location = new System.Drawing.Point(0, 103);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(344, 341);
            this.panel.TabIndex = 2;
            // 
            // настройкиЦветаToolStripMenuItem
            // 
            this.настройкиЦветаToolStripMenuItem.Name = "настройкиЦветаToolStripMenuItem";
            this.настройкиЦветаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.настройкиЦветаToolStripMenuItem.Text = "Настройки цвета";
            this.настройкиЦветаToolStripMenuItem.Click += new System.EventHandler(this.настройкиЦветаToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(344, 441);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Продвинутый калькулятор";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripMenuItem видToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инженерныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиЦветаToolStripMenuItem;
    }
}

