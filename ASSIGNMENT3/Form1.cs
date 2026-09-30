using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Read the input data
            string customerName = txtCustumer.Text;
            double previousReading = Convert.ToDouble(txtprevious.Text);
            double currentReading = Convert.ToDouble(txtcurrent.Text);
            double unitPrice = Convert.ToDouble(txtunitprice.Text);

            // 2. Calculate electricity usage
            double usageUnits = currentReading - previousReading;

            // 3. Calculate subtotal and tax (7%)
            double subtotal = usageUnits * unitPrice;
            double taxAmount = subtotal * 0.07;

            // 4. Calculate the total bill (including $5 fixed charge)
            double totalBill = subtotal + taxAmount + 5;

            // 5. Display the results in the output TextBoxes
            txtElectricityUsage.Text = usageUnits.ToString();
            txtTaxAmount.Text = "$" + taxAmount.ToString("0.00");
            txtTotalBill.Text = "$" + totalBill.ToString("0.00");
        }
    }
}
