using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        private Double result = 0;
        private string op = "";
        public MainForm()
        {
            InitializeComponent();
        }



        private void inputNumber(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            outTextBox.Text += btn.Text;

        }
        private void inputOperator(object sender, EventArgs e)
        {
            Button btn = (Button)sender;



            if (outTextBox.Text != "")
            {

                switch (op)
                {


                    case "+":
                        this.result += Double.Parse(outTextBox.Text);
                        break;
                    case "-":
                        this.result -= Double.Parse(outTextBox.Text);
                        break;
                    case "×":
                        this.result *= Double.Parse(outTextBox.Text);
                        break;
                    case "÷":
                        this.result /= Double.Parse(outTextBox.Text);
                        break;
                    case "":
                        this.result = Double.Parse(outTextBox.Text);
                        break;
                    default: break;

                }
                
                if (btn.Text != "D")
                { 
                    outTextBox.Text = "";
                    this.op = btn.Text;
                }
                   
            }

            if (btn.Text == "D" && outTextBox.Text != ""&&op!="=")
            {
                outTextBox.Text = outTextBox.Text.Substring(0, outTextBox.Text.Length - 1);
            }

            else if (btn.Text == "C")
            {
                op = "";
                result = 0;
                outTextBox.Text = "";
            }
            else if (btn.Text == "=")
            {
                op = "=";
                outTextBox.Text = result.ToString();

            }

        }
    }
        
}
