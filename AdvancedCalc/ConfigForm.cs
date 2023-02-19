using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class ConfigForm : Form
    {
        private MainForm _parentForm;

        public ConfigForm()
        {
            InitializeComponent();
        }

        public ConfigForm(MainForm mainForm)
        {
            _parentForm = mainForm;
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
        }

        /// <summary>
        /// ДОДЕЛАТЬ сделать универсальным
        /// </summary>
        private void trackBar_SetColor_BeforeChanget()
        {
            Color setedColor = _parentForm.GetColorPanel();
            trackBar_RedColor.Value = setedColor.R;
            trackBar_BlueColor.Value = setedColor.B;
            trackBar_GreenColor.Value = setedColor.G;
        }



        private void trackBar_Color_ValueChanget(object sender, EventArgs e)
        {
            Color panelColor = Color.FromArgb(
                                            trackBar_RedColor.Value,
                                            trackBar_GreenColor.Value,
                                            trackBar_BlueColor.Value);

            groupBoxConfigColor.BackColor = panelColor;
            _parentForm.ChangeColorPanel(panelColor);
            _parentForm.ChangeColorMenuStrip(panelColor);
            _parentForm.ChangeColorMainForm(panelColor);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
