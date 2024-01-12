//Name: Dustin Shaw
//Program: Assignment 3: Simple Calculator
//Date: 09/25/2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DustinShaw_Assignment3
{
    public partial class frmSimpleCalculator : Form
    {
        public frmSimpleCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //initialized variables to convert the users input into workable values
            decimal operandOne = Convert.ToDecimal(txtOperand1.Text);
            decimal operandTwo = Convert.ToDecimal(txtOperand2.Text);
            string op = (txtOperator.Text).ToString();

            //intializing result to be displayed later to the user
            decimal result = 0;

            //running Calculate method on result to give us a value on what the user has selected
            result = Calculate(operandOne, op, operandTwo);

            //Round result to three decimal places 
            result = Math.Round(result, 4);

            //converting result to be displayed for the user
            txtResult.Text = result.ToString();

            //shift focus back to the operand 1
            txtOperand1.Focus();


        }

        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            //initializing the return value
            decimal result = 0;

            //checking to see if the user selected multiplication
            if (operator1 == "x" || operator1 == "*" || operator1 == "X")
            {
                result = operand1 * operand2;
            }
            //checking to see if the user has selected division
            else if (operator1 == "/")
            {
                result = operand1 / operand2;
            }
            //checking to see if the user has selected addition
            else if (operator1 == "+")
            {
                result = operand1 + operand2;
            }
            //checking to see if the user has selected subtraction
            else if (operator1 == "-")
            {
                result = operand1 - operand2;
            }

            //returning result to the method
            return result;

        }

        //closes the program when the exit button is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //clears the result whenever a change is made to the text boxes
        private void ClearResult(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
