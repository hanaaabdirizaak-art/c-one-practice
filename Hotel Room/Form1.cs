using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Hotel_Room
{
    public partial class lstBookingDetails : Form
    {
        public lstBookingDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            string guestName = txtGuestName.Text.Trim();

            if (guestName == "")
            {
                MessageBox.Show("Guest name cannot be empty.");
                txtGuestName.Focus();
                return;
            }
            int age, nights, guests;

            if (!int.TryParse(txtGuestAge.Text, out age))
            {
                MessageBox.Show("Enter a valid guest age.");
                txtGuestAge.Focus();
                return;
            }

            if (age < 18 || age > 90)
            {
                MessageBox.Show("Age must be between 18 and 90.");
                txtGuestAge.Focus();
                return;
            }
            if (!int.TryParse(txtNights.Text, out nights))
            {
                MessageBox.Show("Enter a valid number of nights.");
                txtNights.Focus();
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30.");
                txtNights.Focus();
                return;
            }
            if (!int.TryParse(txtNumberOfGuests.Text, out guests))
            {
                MessageBox.Show("Enter a valid number of guests.");
                txtNumberOfGuests.Focus();
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Guests must be between 1 and 6.");
                txtNumberOfGuests.Focus();
                return;
            }
            string roomType = "";
            double rate = 0;
            int maxGuests = 0;

            if (rtbstandard.Checked)
            {
                roomType = "Standard";
                rate = 50;
                maxGuests = 2;
            }
            else if (rbnormal.Checked)
            {
                roomType = "Normal";
                rate = 80;
                maxGuests = 4;
            }
            else if (rbhight.Checked)
            {
                roomType = "High";
                rate = 130;
                maxGuests = 6;
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            if (guests > maxGuests)
            {
                MessageBox.Show(roomType + " room can accommodate only "
                    + maxGuests + " guests.");
                return;
            }
            double roomCost = rate * nights;

            double discountRate = 0;

            if (nights >= 10)
                discountRate = 0.12;
            else if (nights >= 5)
                discountRate = 0.05;

            double discount = roomCost * discountRate;
            double total = roomCost - discount;


            double breakfastCost = 0;

            if (chkBreakfast.Checked)
            {
                breakfastCost = 10 * guests * nights;
                total += breakfastCost;
            }

            double surcharge = 0;

            if (guests > 4)
            {
                surcharge = total * 0.05;
                total += surcharge;
            }

            double seniorDiscount = 0;

            if (age >= 60)
            {
                seniorDiscount = total * 0.05;
                total -= seniorDiscount;
            }

            txtBookingDetails.Text =
        "BOOKING APPROVED\r\n\r\n" +
        "Guest Name: " + guestName + "\r\n" +
        "Guest Age: " + age + "\r\n" +
        "Room Type: " + roomType + "\r\n" +
        "Number of Guests: " + guests + "\r\n" +
        "Number of Nights: " + nights + "\r\n" +
        "Rate Per Night: " + rate.ToString("C") + "\r\n" +
        "Room Cost: " + roomCost.ToString("C") + "\r\n" +
        "Night Discount: " + discount.ToString("C") + "\r\n" +
        "Breakfast Cost: " + breakfastCost.ToString("C") + "\r\n" +
        "Service Surcharge: " + surcharge.ToString("C") + "\r\n" +
        "Senior Discount: " + seniorDiscount.ToString("C") + "\r\n" +
        "--------------------------\r\n" +
        "TOTAL COST: " + total.ToString("C");
        }


        



       


















        private void btnClear_Click(object sender, EventArgs e)
        {
        }
           
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }

        private void rbstandard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rtbBookingDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            // Clear input fields
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNights.Clear();
            txtNumberOfGuests.Clear();

            // Clear room selection
            rtbstandard.Checked = false;
            rbhight.Checked = false;
            rbhight.Checked = false;

            // Clear breakfast
            chkBreakfast.Checked = false;

            // Clear booking details
            txtBookingDetails.Items.Clear();

            txtGuestName.Focus();
        }

        private void txtGuestName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtnumberofguest_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }

    }


        
    

