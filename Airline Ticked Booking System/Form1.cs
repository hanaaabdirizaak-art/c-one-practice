using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_Ticked_Booking_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
        }






        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        private void btnclear_Click_1(object sender, EventArgs e)
        {

        }

        private void btncalculate_Click_1(object sender, EventArgs e)
        {
            // Get passenger name
            string passengerName = txtPassengerName.Text.Trim();

            if (passengerName == "")
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            // Declare variables
            int age;
            int tickets;
            double baggageWeight;

            // Validate age
            if (!int.TryParse(txtPassengerAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            // Validate number of tickets
            if (!int.TryParse(txtNumberOfTickets.Text, out tickets))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                return;
            }

            // Validate baggage weight
            if (!double.TryParse(txtBaggageWeight.Text, out baggageWeight))
            {
                MessageBox.Show("Please enter a valid baggage weight.");
                return;
            }
            // Check passenger age
            if (age < 1 || age > 100)
            {
                MessageBox.Show("Age must be between 1 and 100.");
                return;
            }

            // Check number of tickets
            if (tickets < 1 || tickets > 5)
            {
                MessageBox.Show("Tickets must be between 1 and 5.");
                return;
            }

            // Check baggage weight
            if (baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show("Baggage must be between 0 and 50 kg.");
                return;
            }
            // Check travel class
            if (!rdoFirstClass.Checked &&
                !rdoNormalClass.Checked &&
                !rdoBusinessClass.Checked)
            {
                MessageBox.Show("Please select a travel class.");
                return;
            }

            // Reject First Class for children below 12
            if (age < 12 && rdoFirstClass.Checked)
            {
                MessageBox.Show(
                    "Passengers below 12 cannot book First Class.");
                return;
            }

            // Declare variables
            double ticketPrice;
            string travelClass;

            // Set ticket price
            if (rdoFirstClass.Checked)
            {
                ticketPrice = 500;
                travelClass = "First Class";
            }
            else if (rdoNormalClass.Checked)
            {
                ticketPrice = 200;
                travelClass = "Normal Class";
            }
            else
            {
                ticketPrice = 350;
                travelClass = "Business Class";
            }
            // Calculate basic ticket cost
            double basicCost = ticketPrice * tickets;
            // Calculate ticket discount
            double ticketDiscount = 0;

            if (tickets == 5)
            {
                ticketDiscount = basicCost * 0.10;
            }
            else if (tickets >= 3)
            {
                ticketDiscount = basicCost * 0.05;
            }
            // Calculate age discount
            double ageDiscount = 0;

            if (age < 12)
            {
                ageDiscount = basicCost * 0.20;
            }
            else if (age >= 60)
            {
                ageDiscount = basicCost * 0.10;
            }

            // Calculate total discount
            double totalDiscount = ticketDiscount + ageDiscount;

            if (totalDiscount > basicCost)
            {
                totalDiscount = basicCost;
            }
            // Calculate travel insurance
            double insuranceCost = 0;

            if (chkInsurance.Checked)
            {
                insuranceCost = 25 * tickets;
            }
            // Calculate baggage charge
            double baggageCharge = 0;

            if (baggageWeight > 20)
            {
                baggageCharge = (baggageWeight - 20) * 10;
            }
            // Calculate final cost
            double finalCost = basicCost - totalDiscount
                               + insuranceCost + baggageCharge;


            MessageBox.Show("Booking completed successfully!");

            txtBookingDetails.Text =
        "BOOKING APPROVED\r\n\r\n" +
        "Passenger Name: " + passengerName + "\r\n" +
        "Age: " + age + "\r\n" +
        "Travel Class: " + travelClass + "\r\n" +
        "Number of Tickets: " + tickets + "\r\n" +
        "Baggage Weight: " + baggageWeight + " kg\r\n" +
        "Basic Cost: " + basicCost.ToString("C") + "\r\n" +
        "Ticket Discount: " + ticketDiscount.ToString("C") + "\r\n" +
        "Age Discount: " + ageDiscount.ToString("C") + "\r\n" +
        "Total Discount: " + totalDiscount.ToString("C") + "\r\n" +
        "Insurance Cost: " + insuranceCost.ToString("C") + "\r\n" +
        "Baggage Charge: " + baggageCharge.ToString("C") + "\r\n" +
        "Final Cost: " + finalCost.ToString("C");

            MessageBox.Show("Booking completed successfully!");
        }




        private void button2_Click(object sender, EventArgs e)
        {
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtNumberOfTickets.Clear();
            txtBaggageWeight.Clear();
            

            rdoFirstClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;

            chkInsurance.Checked = false;

            MessageBox.Show("All fields cleared successfully!");
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}




