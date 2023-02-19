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

        private void trackBar_Color_ValueChanget(object sender, EventArgs e)
        {
            Color setedColor = _parentForm.GetColorPanel();
            trackBar_RedColor.Site = setedColor.R;


            Color panelColor = Color.FromArgb(
                                            trackBar_RedColor.Value,
                                            trackBar_GreenColor.Value,
                                            trackBar_BlueColor.Value);

            groupBoxConfigColor.BackColor = panelColor;
            _parentForm.ChangeColorPanel(panelColor);

        }

    }
}
