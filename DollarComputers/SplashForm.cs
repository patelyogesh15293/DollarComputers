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
