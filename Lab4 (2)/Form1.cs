//Lab 4
//CIS 199-01
//Due 2/16/2016
//By: Rakesh R. Mahbubani

//This program uses IF statements to compare the user's GPA and test score in order to decide if they are accepted or rejected.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4__2_
{
    public partial class acceptOrReject : Form
    {
        //declare double variables to store the information the user inputs
        double GPA;
        double Test;

        //declare private int variables for the counters
        private int acceptTotal = 0;
        private int rejectTotal = 0;

        public acceptOrReject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //connects the double variables to their respective text boxes
            GPA = double.Parse(gpaTextBox.Text);
            Test = double.Parse(testTextBox.Text);

            if (GPA >= 3.0 && Test >= 60)
            {
                MessageBox.Show("Accept"); //shows the message "Accept"
                acceptTotal += 1; //increases the accept total by 1
                acceptTotalLabel.Text = acceptTotal.ToString(); //displays the new accept total in the label
            }
            else if (GPA < 3.0 && Test >= 80)
            {
                MessageBox.Show("Accept"); //shows the message "Accept"
                acceptTotal += 1; //increases the accept total by 1
                acceptTotalLabel.Text = acceptTotal.ToString(); //displays the new accept total in the label
            }
            else
            { 
                MessageBox.Show("Reject"); //shows the message "Reject"
                rejectTotal += 1; //increases the reject total by 1
                rejectTotalLabel.Text = rejectTotal.ToString(); //displays the new reject total in the label
            }

        }

        private void acceptOrReject_Load(object sender, EventArgs e)
        {

        }
    }
}
