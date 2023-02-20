using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class MainForm : Form
    {

        private ConfigForm _configForm = null;
        private readonly string[] _buttonNames_SimplyCalc =
        {
            "±", "x²", "⬅", "C",
            "1/x", "%", "√", "×",
            "1",   "2", "3", "/",
            "4",  "5",  "6", "+",
            "7", "8", "9", "-",
            "0" ,",", "="
        };
        private readonly string[] _buttonNames_AdvandcedCalc =
        {
            "𝝅","|x|","±", "x²", "⬅", "C",
            "log","ln","1/x", "%", "√", "×",
            "10^x","x^y", "1",  "2", "3", "/",
            "asin()","sin()","4",  "5",  "6", "+",
            "acos()","cos()","7", "8", "9", "-",
            "atan()","tan()","0" ,",", "="
        };

        private List<Button> _buttonList = new List<Button>();
        private const int _bitDepth = 8;
        private string _currOperation = "";
        private string _leftOperand = "";
        private string _rigthOperand = "";

        public MainForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            this.Load += MainForm_Load;
            InitButtons();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Инициализация кодом кнопок калькулятора
        /// </summary>
        private void InitButtons()
        {
            string[] _buttonNames = null;
            int ind = 0;
            int indDown = 0;
            int posX = 4;
            int posY = 4;

            ///Проверка в каком виде сейчас находимся и какие батоны отрисовывать
            if (стандартныйToolStripMenuItem.Checked == true)
            {
                indDown = 4;
                _buttonNames = _buttonNames_SimplyCalc;
            }
            else if (инженерныйToolStripMenuItem.Checked == true)
            {
                indDown = 6;
                _buttonNames = _buttonNames_AdvandcedCalc;
            }
            foreach (string nameButton in _buttonNames)
            {
                Button tmp = new Button();

                if (nameButton == "," || nameButton == "=" || nameButton == "0")
                    tmp.Size = new Size(109, 50);
                else
                    tmp.Size = new Size(81, 50);

                if (CheckIsStringNum(nameButton))
                {
                    //tmp.BackColor = Color.LemonChiffon;
                    //tmp.BackColor = Color.FromName(GetInfoFromConfigFileByKey("user_Button_Num_Color"));


                    //tmp.BackColor = Color.FromName(
                    //    GetInfoFromConfigFileByKey("user_Button_Num_Color")
                    //    );

                    tmp.BackColor = 
                        Color.FromArgb(
                                int.Parse(GetInfoFromConfigFileByKey("user_Button_Num_Color"))
                                );

                    MessageBox.Show(
                        tmp.BackColor.ToString());


                    tmp.Tag = "NumButton";
                }
                else if (nameButton == "C")
                {
                    tmp.BackColor = Color.LightCyan;
                    tmp.Tag = "CButton";
                }
                else
                {
                    tmp.BackColor = Color.PeachPuff;
                    tmp.Tag = "OpButton";
                }

                tmp.Text = nameButton;

                tmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));


                tmp.Location = new Point(posX, posY);
                posX = posX + tmp.Size.Width + 4;

                ind++;

                if (ind % indDown == 0)
                {
                    posY += tmp.Size.Height + 4;
                    posX = 4;
                }

                panel.Controls.Add(tmp);
                _buttonList.Add(tmp);
                tmp.Click += Btn_Click;
            }
        }
        /// <summary>
        /// Очищает с панели кнопки
        /// </summary>
        private void ClearButtons()
        {
            panel.Controls.Clear();
            _buttonList.Clear();
        }

        /// <summary>
        /// Проверяет есть ли в строке цифры
        /// </summary>
        /// <param name="s">Строка которую требуется проверить</param>
        /// <returns>Если есть цифры то правде, иначе ложь</returns>
        private bool CheckIsStringNum(string s)
        {
            if (s == "1" || s == "2" || s == "3" || s == "4" || s == "5" ||
                s == "6" || s == "7" || s == "8" || s == "9" || s == "0")
                return true;
            else
                return false;
        }
        /// <summary>
        /// Действие при нажатии кнопок на панеле калькулятора
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            switch (btn.Text)
            {
                case ("C"):
                    {
                        _leftOperand = string.Empty;
                        _rigthOperand = string.Empty;
                        _currOperation = string.Empty;
                        textBoxResult.Text = "0";
                        break;
                    }
                case ("0"):
                    {
                        CheckAndAddNum("0");
                        break;
                    }
                case ("1"):
                    {
                        CheckAndAddNum("1");
                        break;
                    }
                case ("2"):
                    {
                        CheckAndAddNum("2");
                        break;
                    }
                case ("3"):
                    {
                        CheckAndAddNum("3");
                        break;
                    }
                case ("4"):
                    {
                        CheckAndAddNum("4");
                        break;
                    }
                case ("5"):
                    {
                        CheckAndAddNum("5");
                        break;
                    }
                case ("6"):
                    {
                        CheckAndAddNum("6");
                        break;
                    }
                case ("7"):
                    {
                        CheckAndAddNum("7");
                        break;
                    }
                case ("8"):
                    {
                        CheckAndAddNum("8");
                        break;
                    }
                case ("9"):
                    {
                        CheckAndAddNum("9");
                        break;
                    }
                case ("⬅"):
                    {
                        if (_leftOperand != string.Empty && _rigthOperand == string.Empty)
                        {
                            if (_leftOperand.Length > 1)
                                _leftOperand = _leftOperand.Remove(_leftOperand.Length - 1);
                            else
                                _leftOperand = "0";

                            textBoxResult.Text = _leftOperand;
                        }
                        else if (_leftOperand != string.Empty && _rigthOperand != string.Empty && _currOperation != string.Empty)
                        {
                            if (_rigthOperand.Length > 1)
                                _rigthOperand = _rigthOperand.Remove(_rigthOperand.Length - 1);
                            else
                                _leftOperand = "0";

                            textBoxResult.Text = _rigthOperand;
                        }
                        break;
                    }
                case "×":
                    {
                        _currOperation = "*";
                        textBoxResult.Text = "";
                        break;
                    }
                case "/":
                    {
                        _currOperation = "/";
                        textBoxResult.Text = "";
                        break;
                    }
                case "+":
                    {
                        _currOperation = "+";
                        textBoxResult.Text = "";
                        break;
                    }
                case "-":
                    {
                        _currOperation = "-";
                        textBoxResult.Text = "";
                        break;
                    }
                case "x^y":
                    {
                        _currOperation = "^";
                        textBoxResult.Text = "";
                        break;
                    }
                case "=":
                    {
                        DoOperationAfterEqual();
                        break;
                    }
                case ",":
                    {
                        CheckAndAddNum(",");
                        break;
                    }
                case "±":
                    {
                        if (_leftOperand != string.Empty && _rigthOperand == string.Empty)
                        {
                            if (_leftOperand[0] != '-')
                                _leftOperand = _leftOperand.Insert(0, "-");
                            else
                                _leftOperand = _leftOperand.TrimStart('-');

                            textBoxResult.Text = _leftOperand;
                        }
                        else if (_leftOperand != string.Empty && _rigthOperand != string.Empty && _currOperation != string.Empty)
                        {
                            if (_rigthOperand[0] != '-')
                                _rigthOperand = _rigthOperand.Insert(0, "-");
                            else
                                _rigthOperand = _rigthOperand.TrimStart('-');

                            textBoxResult.Text = _rigthOperand;
                        }
                        break;
                    }
                case "x²":
                    {
                        DoOperationWithOperand("x²", ref (WhichOperandToDo()));
                        break;
                    }
                case "1/x":
                    {
                        DoOperationWithOperand("1/x", ref (WhichOperandToDo()));
                        break;
                    }
                case "√":
                    {
                        DoOperationWithOperand("√", ref (WhichOperandToDo()));
                        break;
                    }
                case "%":
                    {
                        _currOperation += "%";
                        textBoxResult.Text += "%";
                        break;
                    }
                case "𝝅":
                    {
                        CheckAndAddNum((Math.PI).ToString());
                        break;
                    }
                case "|x|":
                    {
                        DoOperationWithOperand("|x|", ref (WhichOperandToDo()));
                        break;
                    }
                case "log":
                    {
                        DoOperationWithOperand("log", ref (WhichOperandToDo()));
                        break;
                    }
                case "ln":
                    {
                        DoOperationWithOperand("ln", ref (WhichOperandToDo()));
                        break;
                    }
                case "10^x":
                    {
                        DoOperationWithOperand("10^x", ref (WhichOperandToDo()));
                        break;
                    }
                case "sin()":
                    {
                        DoOperationWithOperand("sin()", ref (WhichOperandToDo()));
                        break;
                    }
                case "cos()":
                    {
                        DoOperationWithOperand("cos()", ref (WhichOperandToDo()));
                        break;
                    }
                case "tan()":
                    {
                        DoOperationWithOperand("tan()", ref (WhichOperandToDo()));
                        break;
                    }
                case "asin()":
                    {
                        DoOperationWithOperand("asin()", ref (WhichOperandToDo()));
                        break;
                    }
                case "acos()":
                    {
                        DoOperationWithOperand("acos()", ref (WhichOperandToDo()));
                        break;
                    }
                case "atan()":
                    {
                        DoOperationWithOperand("atan()", ref (WhichOperandToDo()));
                        break;
                    }
            }

        }

        /// <summary>
        /// Проверить и добавить в строку цифру
        /// </summary>
        /// <param name="action"></param>
        private void CheckAndAddNum(string action)
        {
            if (_currOperation.Length == 0)      //left
            {
                if (_leftOperand.Length < _bitDepth)
                {
                    if (_leftOperand == "0")
                        _leftOperand = action;
                    else
                        _leftOperand += action;

                    textBoxResult.Text = _leftOperand;
                }
            }
            else
            {                              //right
                if (_rigthOperand.Length < _bitDepth)
                {
                    if (_rigthOperand == "0")
                        _rigthOperand = action;
                    else
                        _rigthOperand += action;

                    textBoxResult.Text = _rigthOperand;
                }
            }
        }
        /// <summary>
        /// Выполнить выбраную операцию после нажатия "="
        /// </summary>
        private void DoOperationAfterEqual()
        {
            double lOper = 0.0;
            double rOper = 0.0;
            double result = 0.0;

            switch (_currOperation)
            {
                case "*":
                    {
                        if (IsRightOperandNull())
                            break;

                        lOper = double.Parse(_leftOperand);
                        rOper = double.Parse(_rigthOperand);
                        result = lOper * rOper;
                        textBoxResult.Text = result.ToString();
                        _leftOperand = result.ToString();
                        _rigthOperand = string.Empty;
                        _currOperation = string.Empty;
                        break;
                    }
                case "+":
                    {
                        if (IsRightOperandNull())
                            break;

                        lOper = double.Parse(_leftOperand);
                        rOper = double.Parse(_rigthOperand);
                        result = lOper + rOper;
                        textBoxResult.Text = result.ToString();
                        _leftOperand = result.ToString();
                        _rigthOperand = string.Empty;
                        _currOperation = string.Empty;
                        break;
                    }
                case "/":
                    {
                        if (IsRightOperandNull())
                            break;

                        lOper = double.Parse(_leftOperand);
                        rOper = double.Parse(_rigthOperand);
                        result = lOper / rOper;
                        textBoxResult.Text = result.ToString();
                        _leftOperand = result.ToString();
                        _rigthOperand = string.Empty;
                        _currOperation = string.Empty;
                        break;
                    }
                case "-":
                    {
                        if (IsRightOperandNull())
                            break;

                        lOper = double.Parse(_leftOperand);
                        rOper = double.Parse(_rigthOperand);
                        result = lOper - rOper;
                        textBoxResult.Text = result.ToString();
                        _leftOperand = result.ToString();
                        _rigthOperand = string.Empty;
                        _currOperation = string.Empty;
                        break;
                    }
                case "-%":
                    {
                        if (IsRightOperandNull())
                            break;


                        lOper = double.Parse(_leftOperand);
                        rOper = double.Parse(_rigthOperand);
                        result = lOper - ((lOper * rOper) / 100);
                        textBoxResult.Text = result.ToString();
                        _leftOperand = result.ToString();
                        _rigthOperand = string.Empty;
                        _currOperation = string.Empty;
                        break;
                    }
                case "+%":
                    {
                        if (IsRightOperandNull())
                            break;


                        lOper = double.Parse(_leftOperand);
                        rOper = double.Parse(_rigthOperand);
                        result = lOper + ((lOper * rOper) / 100);
                        textBoxResult.Text = result.ToString();
                        _leftOperand = result.ToString();
                        _rigthOperand = string.Empty;
                        _currOperation = string.Empty;
                        break;
                    }
                case "*%":
                    {
                        if (IsRightOperandNull())
                            break;

                        lOper = double.Parse(_leftOperand);
                        rOper = double.Parse(_rigthOperand);
                        result = lOper * ((lOper * rOper) / 100);
                        textBoxResult.Text = result.ToString();
                        _leftOperand = result.ToString();
                        _rigthOperand = string.Empty;
                        _currOperation = string.Empty;
                        break;
                    }
                case "/%":
                    {
                        if (IsRightOperandNull())
                            break;

                        lOper = double.Parse(_leftOperand);
                        rOper = double.Parse(_rigthOperand);
                        result = lOper / ((lOper * rOper) / 100);
                        textBoxResult.Text = result.ToString();
                        _leftOperand = result.ToString();
                        _rigthOperand = string.Empty;
                        _currOperation = string.Empty;
                        break;
                    }
                case "^":
                    {
                        if (IsRightOperandNull())
                            break;

                        lOper = double.Parse(_leftOperand);
                        rOper = double.Parse(_rigthOperand);
                        result = Math.Pow(lOper, rOper);
                        textBoxResult.Text = result.ToString();
                        _leftOperand = result.ToString();
                        _rigthOperand = string.Empty;
                        _currOperation = string.Empty;
                        break;
                    }

            }
        }

        /// <summary>
        /// Проверяет правый операнд
        /// </summary>
        /// <returns>Если НУЛ - ПРАВДА, ИНАЧЕ - ЛОЖЬ</returns>
        private bool IsRightOperandNull()
        {
            if (_rigthOperand.Length == 0)
            {
                textBoxResult.Text = "0";
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Проверяет левый операнд на пустоту
        /// </summary>
        /// <returns>Если НУЛ - ПРАВДА, ИНАЧЕ - ЛОЖЬ</returns>
        private bool IsLeftOperandNull()
        {
            if (_leftOperand.Length == 0)
            {
                textBoxResult.Text = "0";
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Производит операцию с операндом переданым по ссылке
        /// </summary>
        /// <param name="action">Стринговая операция</param>
        /// <param name="operand">ссылка на операнд</param>
        private void DoOperationWithOperand(string action, ref string operand)
        {
            double num;

            switch (action)
            {
                case "x²":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num *= num;
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "1/x":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num = 1 / num;
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "√":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num = Math.Sqrt(num);
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "|x|":
                    {
                        num = double.Parse(operand);
                        if (num < 0) num *= -1;
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "log":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num = Math.Log10(num);
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "ln":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num = Math.Log(num);
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "10^x":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num = Math.Pow(10, num);
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "sin()":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num = Math.Sin(num);
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "cos()":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num = Math.Cos(num);
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "tan()":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num = Math.Tan(num);
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "asin()":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num = Math.Asin(num);
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "acos()":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num = Math.Acos(num);
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }
                case "atan()":
                    {
                        if (IsLeftOperandNull())
                            break;
                        num = double.Parse(operand);
                        num = Math.Atan(num);
                        operand = num.ToString();
                        textBoxResult.Text = operand;
                        break;
                    }




            }
        }
        /// <summary>
        /// Определяет над каким операндом работать
        /// </summary>
        /// <param name="action">Передает действие</param>
        private ref string WhichOperandToDo()
        {
            if (_leftOperand != string.Empty && _rigthOperand == string.Empty)
                return ref _leftOperand;
            else
                return ref _rigthOperand;
        }

        /// <summary>
        /// Действие при нажатии о программе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.StartPosition = FormStartPosition.CenterParent;
            aboutForm.ShowDialog();
        }

        private void видToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            стандартныйToolStripMenuItem.Checked = true;
            инженерныйToolStripMenuItem.Checked = false;

            ClearButtons();
            textBoxResult.Text = string.Empty;

            this.Size = new Size(
                int.Parse(ConfigurationManager.AppSettings["simpleModeWidth"]),
                int.Parse(ConfigurationManager.AppSettings["simpleModeHight"])
            );
            InitButtons();
        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            стандартныйToolStripMenuItem.Checked = false;
            инженерныйToolStripMenuItem.Checked = true;

            ClearButtons();
            textBoxResult.Text = string.Empty;


            this.Size = new Size(
                    int.Parse(ConfigurationManager.AppSettings["advandcedModeWidth"]),
                    int.Parse(ConfigurationManager.AppSettings["advandcedModeHight"])
                );
            InitButtons();
        }

        private void настройкиЦветаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_configForm == null)
            {
                _configForm = new ConfigForm(this);
                _configForm.StartPosition = FormStartPosition.Manual;
            }

            _configForm.Location = new Point(
                this.Location.X + this.Size.Width - 16,
                this.Location.Y
            );

            _configForm.Show();
        }

        ///////Методы установки цвета формы
        /// <summary>
        /// Метод устанавливает цвет подложки
        /// </summary>
        /// <param name="color">Требует цвет</param>
        public void ChangeColorPanel(Color color)
        {
            this.panel.BackColor = color;
        }
        /// <summary>
        /// Метод устанавливает цвет подложки меню
        /// </summary>
        /// <param name="color">Требует цвет</param>
        public void ChangeColorMenuStrip(Color color)
        {
            this.menuStrip.BackColor = color;
        }
        /// <summary>
        /// Метод устанавливает цвет основной формы
        /// </summary>
        /// <param name="color"></param>
        public void ChangeColorMainForm(Color color)
        {
            this.BackColor = color;
        }
        /// <summary>
        /// Метод устанавливает цвет табло
        /// </summary>
        /// <param name="color">Цвет типа "Color"</param>
        public void ChangeColorTextBox(Color color)
        {
            this.textBoxResult.BackColor = color;
        }
        /// <summary>
        /// Метод устанавливает цвет теста табло
        /// </summary>
        /// <param name="color">Цвет типа "Color"</param>
        public void ChangeColorTextBoxText(Color color)
        {
            this.textBoxResult.ForeColor = color;
        }
        /// <summary>
        /// Метод устанавливает цвет кнопок по тєгу
        /// </summary>
        /// <param name="color">Цвет типа Color</param>
        /// <param name="tag">тег кнопки</param>
        public void ChangeColorButtonByTag(Color color, string tag)
        {
            foreach (Button b in _buttonList)
            {
                if ((string)b.Tag == tag)
                    b.BackColor = color;
            }
        }
        /// <summary>
        /// Метод устанавливает цвет текста кнопок
        /// </summary>
        /// <param name="color">Цвет типа Color</param>
        public void ChangeColorTextButton(Color color)
        {
            foreach (Button b in _buttonList)
            {
                b.ForeColor = color;
            }
        }

        /////// Методы получение цвета формы
        /// <summary>
        /// Метод возвращает цвет подложки
        /// </summary>
        /// <returns>Вернет текущий цвет подложки</returns>
        public Color GetColorPanel()
        {
            return this.panel.BackColor;
        }
        /// <summary>
        /// Метод возвращает цвет подложки меню
        /// </summary>
        /// <returns></returns>
        public Color GetColorMenuStrip()
        {
            return this.menuStrip.BackColor;
        }
        /// <summary>
        /// Метод возвращает цвет подложки основной формы
        /// </summary>
        /// <returns>Цвет типа Color</returns>
        public Color GetColorMainForm()
        {
            return this.BackColor;
        }
        /// <summary>
        /// Метод возвращает цвет табло
        /// </summary>
        /// <returns>Цвет типа Color</returns>
        public Color GetColorTextBox()
        {
            return this.textBoxResult.BackColor;
        }
        /// <summary>
        /// Метод возвращает цвет текста табло
        /// </summary>
        /// <returns>Цвет типа Color</returns>
        public Color GetColorTextBoxText()
        {
            return this.textBoxResult.ForeColor;
        }
        /// <summary>
        /// Метод возвращает цвет кнопок по тєгу
        /// </summary>
        /// <param name="tag">тег кнопки</param>
        /// <returns>Цвет типа Color</returns>
        public Color GetColorButtonByTag(string tag)
        {
            return _buttonList.Find(b => (string)b.Tag == tag).BackColor;            //return _buttonList.Find(b => b.Tag == "NumButton").BackColor;
        }
        /// <summary>
        /// Метод возвращает цвет текста кнопок
        /// </summary>
        /// <returns>Цвет типа Color</returns>
        public Color GetColorTextButton()
        {
            return _buttonList.Find(b => b.Tag != null).ForeColor;
        }

        ///////Методы возвращения от элемента размер и низвание шрифта
        /// <summary>
        /// Метод возвращает название шрифта кнопок
        /// </summary>
        /// <returns>Строка с названием шрифта</returns>
        public string GetButtonFontName()
        {
            return _buttonList[0].Font.Name;
        }
        /// <summary>
        /// Метод возвращает размер шрифта кнопок
        /// </summary>
        /// <returns>Размер в виде флоат</returns>
        public float GetButtonFontSize()
        {
            return _buttonList[0].Font.Size;
        }
        /// <summary>
        /// Метод возвращает название шрифта табла
        /// </summary>
        /// <returns>Строка с названием шрифта</returns>
        public string GetTextBoxFontName()
        {
            return textBoxResult.Font.Name;
        }
        /// <summary>
        /// Метод возвращает размер шрифта табло
        /// </summary>
        /// <returns>Размер в виде флоат</returns>
        public float GetTextBoxFontSize()
        {
            return textBoxResult.Font.Size;
        }

        ///////Методы сетят элементу размер и новый шрифт
        /// <summary>
        /// Метод в батонах изменяет размер шрифта и сам шрифт
        /// </summary>
        /// <param name="font">Шрифт в виде стринга</param>
        /// <param name="size">Размер в виде флоат</param>
        public void ChangeFontNameAndSizeButton(string font, float size)
        {
            foreach (Button b in _buttonList)
            {
                b.Font = new System.Drawing.Font(font, size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            }
        }
        /// <summary>
        /// Метод в ТекстБоксе изменяет размер шрифта и сам шрифт
        /// </summary>
        /// <param name="font">Шрифт в виде стринга</param>
        /// <param name="size">Размер в виде флоат</param>
        public void ChangeFontNameAndSizeTextBox(string font, float size) 
        {
            textBoxResult.Font = new System.Drawing.Font(font, size, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        }

        public string GetInfoFromConfigFileByKey(string key)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;

            return configFile.AppSettings.Settings[key].Value;
        }

    }
}
