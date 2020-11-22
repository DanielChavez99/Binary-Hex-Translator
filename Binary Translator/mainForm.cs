using System;
using System.Windows.Forms;

namespace Binary_Translator
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void translateButton_Click(object sender, EventArgs e)
        {
            Translate();
        }

        private void Translate()
        {
            int number = -1;

            try
            {
                number = int.Parse(inputTextBox.Text);
            }
            catch (FormatException e)
            {
            }
            

            if (number == 0)
            {
                binaryOutput.Text = "0";
                hexOutput.Text = "0";
            }
            else if (number > 0)
            {
                binaryOutput.Text = binary(number, "");
                hexOutput.Text = hex(number, "");
            }
            else
            {
                binaryOutput.Text = "INVALID: Please enter a positive integer";
                hexOutput.Text = "INVALID: Please enter a positive integer";
            }
        }

        private void Clear()
        {
            inputTextBox.Text = "";
            binaryOutput.Text = "";
            hexOutput.Text = "";
        }

        private String binary(int x, String number)
        {
            if (x > 0)
            {
                if (x % 2 == 0)
                    number = "0" + number;
                else
                    number = "1" + number;

                return binary(x / 2, number);
            }

            return number;
        }

        private String hex(int x, String number)
        {
            if (x > 0)
            {
                switch (x % 16)
                {
                    case 10:
                        number = "A" + number;
                        break;
                    case 11:
                        number = "B" + number;
                        break;
                    case 12:
                        number = "C" + number;
                        break;
                    case 13:
                        number = "D" + number;
                        break;
                    case 14:
                        number = "E" + number;
                        break;
                    case 15:
                        number = "F" + number;
                        break;
                    default:
                        number = (x % 16) + number;
                        break;
                }

                return hex(x / 16, number);
            }

            return number;
        }

        private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                Translate();
                e.SuppressKeyPress = true;
            }
        }

        private void inputTextBox_Click(object sender, EventArgs e)
        {
            if(inputTextBox.Text.Equals("Enter a positive integer"))
                inputTextBox.Text = "";
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
