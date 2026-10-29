using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.IO;
using System.Windows.Forms;
namespace assignment.home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnwrite_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            string content = txtContent.Text;

            if (string.IsNullOrWhiteSpace(fileName))
            {
                MessageBox.Show("Enter file name!");
                return;
            }

            File.WriteAllText(fileName, content);
            MessageBox.Show("File written successfully!");
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;

            if (File.Exists(fileName))
            {
                txtContent.Text = File.ReadAllText(fileName);
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;

            if (File.Exists(fileName))
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this file?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    File.Delete(fileName);
                    txtContent.Clear();
                    MessageBox.Show("File deleted successfully!");
                }
            }
            else
            {
                MessageBox.Show("File not found!");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
    
    

