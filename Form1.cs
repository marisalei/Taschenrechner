using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class TaschenrechnerGrafik : Form
    {
        private String _input = "";
        private double _result = 0;
        private String _inputWithComma = "";
        private double _inputnumber = 0;
        private double _number1 = 0;
        //ggf noch einbauen:
        //private double _number2 = 0;
        private char _operator = 'd';
        
        public TaschenrechnerGrafik()
        {
            InitializeComponent();
            KlammerAufButton.Enabled = false;
            KlammerZuButton.Enabled = false;
            WurzelButton.Enabled = false;
            EingabeTextbox.Enabled = false;

        }

        private void Nummer1button_Click(object sender, EventArgs e)
        {
            _input = _input + "1";
            _inputWithComma = _inputWithComma + "1";
            _inputnumber = Double.Parse(_inputWithComma);
            EingabeTextbox.Text = _input;
        }

        private void Nummer2button_Click(object sender, EventArgs e)
        {
            _input = _input + "2";
            _inputWithComma = _inputWithComma + "2";
            _inputnumber = Double.Parse(_inputWithComma);
            EingabeTextbox.Text = _input;
        }

        private void Nummer3button_Click(object sender, EventArgs e)
        {
            _input = _input + "3";
            _inputWithComma = _inputWithComma + "3";
            _inputnumber = Double.Parse(_inputWithComma);
            EingabeTextbox.Text = _input;
        }

        private void Nummer4button_Click(object sender, EventArgs e)
        {
            _input = _input + "4";
            _inputWithComma = _inputWithComma + "4";
            _inputnumber = Double.Parse(_inputWithComma);
            EingabeTextbox.Text = _input;
        }

        private void Nummer5button_Click(object sender, EventArgs e)
        {
            _input = _input + "5";
            _inputWithComma = _inputWithComma + "5";
            _inputnumber = Double.Parse(_inputWithComma);
            EingabeTextbox.Text = _input;
        }

        private void Nummer6button_Click(object sender, EventArgs e)
        {
            _input = _input + "6";
            _inputWithComma = _inputWithComma + "6";
            _inputnumber = Double.Parse(_inputWithComma);
            EingabeTextbox.Text = _input;
        }

        private void Nummer7button_Click(object sender, EventArgs e)
        {
            _input = _input + "7";
            _inputWithComma = _inputWithComma + "7";
            _inputnumber = Double.Parse(_inputWithComma);
            EingabeTextbox.Text = _input;
        }

        private void Nummer8button_Click(object sender, EventArgs e)
        {
            _input = _input + "8";
            _inputWithComma = _inputWithComma + "8";
            _inputnumber = Double.Parse(_inputWithComma);
            EingabeTextbox.Text = _input;
        }

        private void Nummer9button_Click(object sender, EventArgs e)
        {
            _input = _input + "9";
            _inputWithComma = _inputWithComma + "9";
            _inputnumber = Double.Parse(_inputWithComma);
            EingabeTextbox.Text = _input;
        }

        private void Nummer0button_Click(object sender, EventArgs e)
        {
            _input = _input + "0";
            _inputWithComma = _inputWithComma + "0";
            _inputnumber = Double.Parse(_inputWithComma);
            EingabeTextbox.Text = _input;
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            if (NoError())
            {
                _operator = '+';
                _input = _input + "+";
                EingabeTextbox.Text = _input;
            }

        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (NoError())
            {
                _operator = '-';
                _input = _input + "-";
                EingabeTextbox.Text = _input;
            }
        }

        private void MultiplikationButton_Click(object sender, EventArgs e)
        {
            if (NoError())
            {
                _operator = '*';
                _input = _input + "*";
                EingabeTextbox.Text = _input;
            }
        }

        private void DivisonButton_Click(object sender, EventArgs e)
        {
            if (NoError())
            {
                _operator = '/';
                _input = _input + "/";
                EingabeTextbox.Text = _input;
            }
        }

        private void WurzelButton_Click(object sender, EventArgs e)
        {

        }

        private void KlammerAufButton_Click(object sender, EventArgs e)
        {

        }

        private void KlammerZuButton_Click(object sender, EventArgs e)
        {

        }

        private void KommaButton_Click(object sender, EventArgs e)
        {
            _input = _input + ",";
            _inputWithComma = _inputWithComma + ",";
            EingabeTextbox.Text = _input;
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void AllClearButton_Click_1(object sender, EventArgs e)
        {
            clear();
            EingabeTextbox.Text = _input;
        }

        public bool NoError()
        {
            if (_number1 == 0 && _inputnumber != 0)
            {
                _number1 = _inputnumber;
                _inputnumber = 0;
                _inputWithComma = "";
                return true;
            }
            else if (_number1 != 0)
            {
                clear();
                EingabeTextbox.Text = "Nur zwei Zahlen verrechnen";
                
            }
            else if (_inputnumber == 0)
            {
                clear();
                EingabeTextbox.Text = "Eingabe darf nicht leer sein";
                
            }
            return false;
        }

        private void calculate()
        {
            switch (_operator)
            {
                case '+':
                    _result = _number1 + _inputnumber;
                    EingabeTextbox.Text = ""+ _result;
                    clear();
                    break;

                case '-':
                    _result = _number1 - _inputnumber;
                    EingabeTextbox.Text = "" + _result;
                    clear();
                    break;

                case '*':
                    _result = _number1 * _inputnumber;
                    EingabeTextbox.Text = "" + _result;
                    clear();
                    break;

                case '/':
                    _result = _number1 / _inputnumber;
                    EingabeTextbox.Text = "" + _result;
                    clear();
                    break;

                case 'd':
                    EingabeTextbox.Text = "keine Rechenfunktion gewählt";
                    clear();
                    break;


            }
        }

        private void clear()
        {
            _input = "";
            _operator = 'd';
            _inputnumber = 0;
            _inputWithComma = "";
            _number1 = 0;
            _result = 0;
        }
    }
}
