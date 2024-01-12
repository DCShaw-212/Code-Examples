using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DustinShaw_Assignment1
{
    public partial class frmCalculateGrade : Form
    {
        public frmCalculateGrade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the number grade that the user enters in the Number Grade Text box
            //declare and intialize the variable that will hold the letter grade
            decimal numGrade = Convert.ToDecimal(txtNumberGrade.Text);
            String letterGrade = "";
            //if else statement to set the letter grade A = 90 - 100%, B = 80 - 89%, C = 70 - 79%, D = 60 - 69%, E = 60% or below
            if (numGrade >= 90)
            {
                letterGrade = "A";
            }
            else if (numGrade >= 80 && numGrade <= 89)
            {
                letterGrade = "B";
            }
            else if (numGrade >= 70 && numGrade <= 79)
            {
                letterGrade = "C";
            }
            else if (numGrade >=  60 && numGrade <= 69)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "E";
            }
            //add a statement to display the letter grade in the Letter Grade text box
            txtLetterGrade.Text = letterGrade;
            //add a state to move the focus back to the number grade text box
            txtNumberGrade.Focus();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //statement to the event handler to close the form
            this.Close();
        }
    }
}
