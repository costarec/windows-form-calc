using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            //MessageBox.Show("Button: " + button.Text, "Clicked: " + button.Text);
            display.Text = display.Text + button.Text;
        }

        private void mathOperatorButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MessageBox.Show("Button: " + button.Text, "Clicked: " + button.Text);

        }

        private void calcOperationButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            switch (display.Text)
            {
                case "+":
                    AddOperation();
                    break;
                case "-":
                    SubtractOperation();
                    break;
                case "*":
                    MultiplyOperation();
                    break;
                case "/":
                    DivideOperation();
                    break;
                default:

                    break;
            }
        }
        private void decimalPointButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            display.Text = display.Text + button.Text;
        }

        private void DivideOperation()
        {
            throw new NotImplementedException();
        }

        private void MultiplyOperation()
        {
            throw new NotImplementedException();
        }

        private void SubtractOperation()
        {
            throw new NotImplementedException();
        }

        private void AddOperation()
        {
            throw new NotImplementedException();
        }

    }
}
