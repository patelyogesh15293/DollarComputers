// Appllication Name:   Dollar Computer
// Author's Name:       Yogeshkumar Patel
// Student ID:          200334362
// Date:                March 07, 2017
// Description:         This application is shows different computers details for 
//                      user and it make user to save their data and also provide 
//                      facility for open previous record. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarComputers
{
    public partial class SplashForm : Form
    {
        private StartForm myStartForm = new StartForm();
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            // Enabled timer
            SplashTimer.Enabled = false;
            // Hide the splash form
            this.Hide();
            // Show selection form
            myStartForm.Show();
        }
    }
}
