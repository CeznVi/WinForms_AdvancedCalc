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
                    tmp.BackColor = Color.LemonChiffon;
                else if (nameButton == "C")
                    tmp.BackColor = Color.LightCyan;
                else
                    tmp.BackColor = Color.PeachPuff;

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
                        result = lOper - ((lOper * rOper)/100);
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


        private void DoOperationWithOperand(string action, ref string operand)
        {
            double num;

            switch (action)
            {
                case "x²":
                    {
                        if(IsLeftOperandNull())
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

        private void MainForm_Load(object sender, EventArgs e)
        {
           

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

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

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
            стандартныйToolStripMenuItem.Checked= false;
            инженерныйToolStripMenuItem.Checked = true;

            ClearButtons();
            textBoxResult.Text = string.Empty;


            this.Size = new Size(
                    int.Parse(ConfigurationManager.AppSettings["advandcedModeWidth"]),
                    int.Parse(ConfigurationManager.AppSettings["advandcedModeHight"])
                );
            InitButtons();
        }
    }
}
