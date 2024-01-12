using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmSalesTax : Form
    {
        public frmSalesTax()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if(IsValidData())
            {
                this.SaveData();
            }

        }

        //Saves the data from the sales tax form as the new changed sales tax

        private void SaveData()
        {
            string msg = null;

            msg = txtSalesTaxPct.Text;

            this.Tag = msg;
            this.DialogResult = DialogResult.OK;

        }

        //Checks if the data entered is correct
        public bool IsValidData()
        {
            return
            IsPresent(txtSalesTaxPct, "Sales tax pct") &&
            IsDecimal(txtSalesTaxPct, "Sales tax pct") &&
            IsWithinRange(txtSalesTaxPct, "Sales tax pct", 0, 10);
        }

        //Checks that a value has been entered for sales tax
        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        //checks that the value entered is a decimal
        public bool IsDecimal(TextBox textBox, string name)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        //checks that the value entered as sales tax is within range allowed
        public bool IsWithinRange(TextBox textBox, string name,
        decimal min, decimal max)
        {
            decimal number = Convert.ToDecimal(textBox.Text);
            if (number <= min || number >= max)
            {
                MessageBox.Show(name + " must be between " + min +
                " and " + max + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
