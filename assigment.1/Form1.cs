using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment._1
{
    public partial class Ibloutput : Form
    {
        public Ibloutput()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            string student_name, department;
            int student_Id, semester;
            string fullinfo;

            student_name=txtname.Text;  
            student_Id = int.Parse(txtstudentid.Text);
            department = txtdepartment.Text;
            semester = int.Parse(txtsemester.Text);




            fullinfo= student_name+","+student_Id+","+department;
           

            lbloutput.Text = fullinfo;














        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtname.Text = "" ;
            txtstudentid.Text = "";
            txtdepartment.Text = " ";
            txtsemester.Text = "";
            lbloutput.Text = "  ";









        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();



        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
