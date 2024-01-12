//Name: Dustin Shaw
//Program: CIS 330 Assignment #2 Score Calculator
//Date: 09/18/2022

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DustinShaw_Assignment2
{
    public partial class Form1 : Form
    {
        //variables to store the total and the count
        int score;
        int scoreTotal;
        int scoreCount;
        int avg;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //converting the Text data from the user
            score = Convert.ToInt32(txtScore.Text);

            //Tallying the total score
            scoreTotal = scoreTotal + score;

            //adding to the score count
            scoreCount++;

            //finding the average of the scores 
            avg = scoreTotal / scoreCount;

            //converting values back to be displayed to the form
            txtScoreTotal.Text = scoreTotal.ToString();
            txtScoreCount.Text = scoreCount.ToString();
            txtAverage.Text = avg.ToString();


            //shift the focus back to the score text box
            txtScore.Focus();
        }

        private void btnClearScores_Click(object sender, EventArgs e)
        {
            //clear the text boxes to zero when the clear button is pressed
            score = 0;
            scoreTotal = 0;
            scoreCount = 0;
            avg = 0;

            //converts the zeroed out values back to the form displayed
            txtScore.Text = score.ToString();
            txtScoreTotal.Text = scoreTotal.ToString();
            txtScoreCount.Text = scoreCount.ToString();
            txtAverage.Text = avg.ToString();

            //shifts focus back the the score text box
            txtScore.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //closes the form when the exit button is clicked
            this.Close();
        }
    }
}
