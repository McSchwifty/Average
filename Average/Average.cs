// Andrew MAckinnon
// Oct 23 2015
// ICS3UR
// Finds average of a group of numbers
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average
{
    public partial class frmAverage : Form
    {
        // Public Varibles
        int clickCounter;
        int totalNumber;
        public frmAverage()
        {
            InitializeComponent();
        }

        private void frmAverage_Load(object sender, EventArgs e)
        {
            clickCounter = 0;
            totalNumber = 0;
        }

        private void btnEnterNumber_Click(object sender, EventArgs e)
        {
            // Varibles
            int newNumber; 
            clickCounter++;
            
            // Input

            newNumber = Convert.ToInt32(this.txtNumbers.Text);

            // Process

            if( newNumber == -1)
            {
                MessageBox.Show("The average has been calculated");
                this.btnEnterNumber.Enabled = false;
                this.txtNumbers.Visible = false;
            }
            if (newNumber < -1 || newNumber > 100)
            {
                MessageBox.Show("This input is invalid.");
                this.txtNumbers.Clear();
            }
            else
            {
                totalNumber = totalNumber + newNumber;
                this.lblAverage.Text = ("The runner average is: " + Convert.ToString(totalNumber / clickCounter));
                this.txtNumbers.Clear();
            }





        }
    }
}
