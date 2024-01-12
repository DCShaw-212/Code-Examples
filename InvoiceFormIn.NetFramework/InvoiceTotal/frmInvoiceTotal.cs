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
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        decimal SalesTaxPct = 7.75m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal productTotal = Convert.ToDecimal(txtProductTotal.Text);
            decimal discountPercent = .0m;

            if (productTotal < 100)
                discountPercent = .0m;
            else if (productTotal >= 100 && productTotal < 250)
                discountPercent = .1m;
            else if (productTotal >= 250)
                discountPercent = .25m;

            decimal discountAmount = productTotal * discountPercent;
            decimal subtotal = productTotal - discountAmount;
            decimal tax = subtotal * SalesTaxPct / 100;
            decimal total = subtotal + tax;

            txtDiscountAmount.Text = discountAmount.ToString("c");      
            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = tax.ToString("c");
            txtTotal.Text = total.ToString("c");

            txtProductTotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //When the Change Percent Button is clicked, a new dialog window is open.
        //Here the user can set a new sales tax value
        //New label is displayed to show the currently set sale tax amount
        private void btnChangePercent_Click(object sender, EventArgs e)
        {
            Form salesTaxForm = new frmSalesTax();

            DialogResult okButton = salesTaxForm.ShowDialog();

            if (okButton == DialogResult.OK)
            {
                
            }
        }

    
    }
}