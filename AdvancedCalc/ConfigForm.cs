using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        }


        /// <summary>
        /// Метод управления трекбарами цвета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackBar_Color_ValueChanget(object sender, EventArgs e)
        {
            if (comboBox_SelectElement.SelectedItem == null)
            {
                trackBar_RedColor.Enabled = false;
                trackBar_GreenColor.Enabled = false;
                trackBar_BlueColor.Enabled = false;
            }
            else
            {
                trackBar_RedColor.Enabled = true;
                trackBar_GreenColor.Enabled = true;
                trackBar_BlueColor.Enabled = true;

                Color selectedColor;
                if ((comboBox_SelectElement.SelectedItem).ToString() == "цвет подложки калькулятора")
                {
                    selectedColor = Color.FromArgb(
                                    trackBar_RedColor.Value,
                                    trackBar_GreenColor.Value,
                                    trackBar_BlueColor.Value);

                    groupBoxConfigColor.BackColor = selectedColor;
                    _parentForm.ChangeColorPanel(selectedColor);
                    _parentForm.ChangeColorMenuStrip(selectedColor);
                    _parentForm.ChangeColorMainForm(selectedColor);
                    this.BackColor = selectedColor;  
                }
                else if ((comboBox_SelectElement.SelectedItem).ToString() == "цвет табло")
                {
                    selectedColor = Color.FromArgb(
                                    trackBar_RedColor.Value,
                                    trackBar_GreenColor.Value,
                                    trackBar_BlueColor.Value);

                    _parentForm.ChangeColorTextBox(selectedColor);
                }
                else if ((comboBox_SelectElement.SelectedItem).ToString() == "цвет текста табло")
                {
                    selectedColor = Color.FromArgb(
                                    trackBar_RedColor.Value,
                                    trackBar_GreenColor.Value,
                                    trackBar_BlueColor.Value);

                    _parentForm.ChangeColorTextBoxText(selectedColor);
                }
                else if ((comboBox_SelectElement.SelectedItem).ToString() == "цвет цифровых кнопок")
                {
                    selectedColor = Color.FromArgb(
                                    trackBar_RedColor.Value,
                                    trackBar_GreenColor.Value,
                                    trackBar_BlueColor.Value);

                    _parentForm.ChangeColorButtonByTag(selectedColor, "NumButton");
                }
            }

        }

        /// <summary>
        /// Выбор елемента для изменения цветом трекбаром
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SelectElement.SelectedItem == null)
            {
                trackBar_RedColor.Enabled = false;
                trackBar_GreenColor.Enabled = false;
                trackBar_BlueColor.Enabled = false;
            }
            else
            {
                trackBar_RedColor.Enabled = true;
                trackBar_GreenColor.Enabled = true;
                trackBar_BlueColor.Enabled = true;

                Color setedColor;
                if ((comboBox_SelectElement.SelectedItem).ToString() == "цвет подложки калькулятора")
                {
                    setedColor = _parentForm.GetColorPanel();
                    trackBar_RedColor.Value = setedColor.R;
                    trackBar_BlueColor.Value = setedColor.B;
                    trackBar_GreenColor.Value = setedColor.G;
                }
                else if (((comboBox_SelectElement.SelectedItem).ToString() == "цвет табло"))
                {
                    setedColor = _parentForm.GetColorTextBox();
                    trackBar_RedColor.Value = setedColor.R;
                    trackBar_BlueColor.Value = setedColor.B;
                    trackBar_GreenColor.Value = setedColor.G;
                }
                else if (((comboBox_SelectElement.SelectedItem).ToString() == "цвет текста табло"))
                {
                    setedColor = _parentForm.GetColorTextBoxText();
                    trackBar_RedColor.Value = setedColor.R;
                    trackBar_BlueColor.Value = setedColor.B;
                    trackBar_GreenColor.Value = setedColor.G;
                }
                else if (((comboBox_SelectElement.SelectedItem).ToString() == "цвет цифровых кнопок"))
                {
                    setedColor = _parentForm.GetColorButtonByTag("NumButton");
                    trackBar_RedColor.Value = setedColor.R;
                    trackBar_BlueColor.Value = setedColor.B;
                    trackBar_GreenColor.Value = setedColor.G;
                }

                
            }
        }

    }
}
