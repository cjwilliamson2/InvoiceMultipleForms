using System.Diagnostics.Tracing;

namespace InvoiceMultipleForms
{
    public partial class frmInvoiceTotal : Form
    {
        decimal taxPercentage = 0.0775m; //Default tax rate

        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            try
            {
                decimal workingTotal = Convert.ToDecimal(txtProductTotal.Text);
                decimal discount = workingTotal * 0.1m;
                decimal subtotal = workingTotal - discount;
                decimal taxed = subtotal * taxPercentage;
                decimal total = taxed + subtotal;

                txtDiscountAmount.Text = discount.ToString("c");
                txtSubtotal.Text = subtotal.ToString("c");
                txtTax.Text = taxed.ToString("c");
                txtTotal.Text = total.ToString("c");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePercent_Click(object sender, EventArgs e)
        {
            Form salesTax = new frmSalesTax();
            DialogResult result = salesTax.ShowDialog();

            if (result == DialogResult.OK)
            {
                taxPercentage = Convert.ToDecimal(salesTax.Tag)/100;
                lblTax.Text = $"Tax ({taxPercentage*100}%):";
            }
        }
    }
}