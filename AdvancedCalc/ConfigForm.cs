using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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

        /// <summary>
        /// Коструктор конфиг формы которому передается ссылка текущей формы для доступа к ее методам
        /// </summary>
        /// <param name="mainForm"></param>
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
                else if ((comboBox_SelectElement.SelectedItem).ToString() == "цвет кнопки сброса")
                {
                    selectedColor = Color.FromArgb(
                                    trackBar_RedColor.Value,
                                    trackBar_GreenColor.Value,
                                    trackBar_BlueColor.Value);
                    _parentForm.ChangeColorButtonByTag(selectedColor, "CButton");
                }
                else if ((comboBox_SelectElement.SelectedItem).ToString() == "цвет кнопок операций")
                {
                    selectedColor = Color.FromArgb(
                                    trackBar_RedColor.Value,
                                    trackBar_GreenColor.Value,
                                    trackBar_BlueColor.Value);
                    _parentForm.ChangeColorButtonByTag(selectedColor, "OpButton");
                }
                else if ((comboBox_SelectElement.SelectedItem).ToString() == "цвет текста всех кнопок")
                {
                    selectedColor = Color.FromArgb(
                                    trackBar_RedColor.Value,
                                    trackBar_GreenColor.Value,
                                    trackBar_BlueColor.Value);
                    _parentForm.ChangeColorTextButton(selectedColor);
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
                else if (((comboBox_SelectElement.SelectedItem).ToString() == "цвет кнопки сброса"))
                {
                    setedColor = _parentForm.GetColorButtonByTag("CButton");
                    trackBar_RedColor.Value = setedColor.R;
                    trackBar_BlueColor.Value = setedColor.B;
                    trackBar_GreenColor.Value = setedColor.G;
                }
                else if (((comboBox_SelectElement.SelectedItem).ToString() == "цвет кнопок операций"))
                {
                    setedColor = _parentForm.GetColorButtonByTag("OpButton");
                    trackBar_RedColor.Value = setedColor.R;
                    trackBar_BlueColor.Value = setedColor.B;
                    trackBar_GreenColor.Value = setedColor.G;
                }
                else if (((comboBox_SelectElement.SelectedItem).ToString() == "цвет текста всех кнопок"))
                {
                    setedColor = _parentForm.GetColorTextButton();
                    trackBar_RedColor.Value = setedColor.R;
                    trackBar_BlueColor.Value = setedColor.B;
                    trackBar_GreenColor.Value = setedColor.G;
                }


            }
        }

        /// <summary>
        /// Выбор элемента для изменения его параметров шрифта и размера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_txtConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_txtConfig.SelectedItem == null)
            {
                comboBox_SelectFont.Enabled = false;
                comboBox_FontSize.Enabled = false;
            }
            else
            {
                comboBox_SelectFont.Enabled = true;
                comboBox_FontSize.Enabled = true;

                if ((comboBox_txtConfig.SelectedItem).ToString() == "шрифт кнопок")
                {
                    comboBox_SelectFont.SelectedItem = _parentForm.GetButtonFontName();
                    comboBox_FontSize.SelectedItem = (_parentForm.GetButtonFontSize()).ToString();
                }
                else if ((comboBox_txtConfig.SelectedItem).ToString() == "шрифт табло")
                {
                    comboBox_SelectFont.SelectedItem = _parentForm.GetTextBoxFontName();
                    comboBox_FontSize.SelectedItem = (_parentForm.GetTextBoxFontSize()).ToString();
                }
            }
        }

        /// <summary>
        /// Изменения шрифта выбраного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SelectFont_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_txtConfig.SelectedItem == null)
            {
                comboBox_SelectFont.Enabled = false;
                comboBox_FontSize.Enabled = false;
            }
            else
            {
                comboBox_SelectFont.Enabled = true;
                comboBox_FontSize.Enabled = true;

                if ((comboBox_txtConfig.SelectedItem).ToString() == "шрифт кнопок")
                {
                    string font = comboBox_SelectFont.SelectedItem.ToString();
                    float size = float.Parse((_parentForm.GetButtonFontSize()).ToString());
                    _parentForm.ChangeFontNameAndSizeButton(font, size);
                }
                else if ((comboBox_txtConfig.SelectedItem).ToString() == "шрифт табло")
                {
                    string font = comboBox_SelectFont.SelectedItem.ToString();
                    float size = float.Parse((_parentForm.GetTextBoxFontSize()).ToString());
                    _parentForm.ChangeFontNameAndSizeTextBox(font, size);
                }
            }
        }

        private void comboBox_FontSize_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_txtConfig.SelectedItem == null)
            {
                comboBox_SelectFont.Enabled = false;
                comboBox_FontSize.Enabled = false;
            }
            else
            {
                comboBox_SelectFont.Enabled = true;
                comboBox_FontSize.Enabled = true;

                if ((comboBox_txtConfig.SelectedItem).ToString() == "шрифт кнопок")
                {
                    string font = _parentForm.GetButtonFontName();
                    float size = float.Parse(comboBox_FontSize.SelectedItem.ToString());
                    _parentForm.ChangeFontNameAndSizeButton(font, size);
                }
                else if ((comboBox_txtConfig.SelectedItem).ToString() == "шрифт табло")
                {
                    string font = _parentForm.GetTextBoxFontName();
                    float size = float.Parse(comboBox_FontSize.SelectedItem.ToString());
                    _parentForm.ChangeFontNameAndSizeTextBox(font, size);
                }
            }
        }

        private void button_saveChanges_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            
            configFile.AppSettings.Settings.Remove("user_Button_Num_Color");
            configFile.AppSettings.Settings.Remove("user_Button_C_Color");
            configFile.AppSettings.Settings.Remove("user_Button_Op_Color");
            configFile.AppSettings.Settings.Remove("user_Button_Text_Color");

            configFile.AppSettings.Settings.Add
                        (
                        "user_Button_Num_Color", 
                        (_parentForm.GetColorButtonByTag("NumButton")).ToArgb().ToString()
                        );
            configFile.AppSettings.Settings.Add
                        (
                        "user_Button_C_Color",
                        (_parentForm.GetColorButtonByTag("CButton")).ToArgb().ToString()
                        );
            configFile.AppSettings.Settings.Add
                        (
                        "user_Button_Op_Color",
                        (_parentForm.GetColorButtonByTag("OpButton")).ToArgb().ToString()
                        );
            configFile.AppSettings.Settings.Add
                        (
                        "user_Button_Text_Color",
                        _parentForm.GetColorTextButton().ToArgb().ToString()
                        );


            ////for debug
            ////MessageBox.Show($"SAVEchange CLick: {settings["user_Button_Num_Color"].Value}");
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            MessageBox.Show("Настройки сохранены");
        }

        private void button_resetToDefault_Click(object sender, EventArgs e)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            ////Перезапись параметров программы
            configFile.AppSettings.Settings["user_Button_Num_Color"].Value = 
                (Color.FromName(ConfigurationManager.AppSettings["default_Button_Num_Color"])).ToString();

            configFile.AppSettings.Settings["user_Button_C_Color"].Value =
                (Color.FromName(ConfigurationManager.AppSettings["default_Button_C_Color"])).ToString();

            configFile.AppSettings.Settings["user_Button_Op_Color"].Value =
                (Color.FromName(ConfigurationManager.AppSettings["default_Button_Op_Color"])).ToString();

            configFile.AppSettings.Settings["user_Button_Text_Color"].Value =
                (Color.FromName(ConfigurationManager.AppSettings["default_Button_Text_Color"])).ToString();

            ////Установка дефолтных параметров в элементы
            _parentForm.ChangeColorButtonByTag((Color.FromName(ConfigurationManager.AppSettings["default_Button_Num_Color"])), "NumButton");

            _parentForm.ChangeColorButtonByTag((Color.FromName(ConfigurationManager.AppSettings["default_Button_C_Color"])), "CButton");

            _parentForm.ChangeColorButtonByTag((Color.FromName(ConfigurationManager.AppSettings["default_Button_Op_Color"])), "OpButton");

            _parentForm.ChangeColorTextButton(Color.FromName(ConfigurationManager.AppSettings["default_Button_Text_Color"]));
        }
    }
}
