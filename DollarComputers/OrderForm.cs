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
    public partial class OrderForm : Form
    {
        public Form previousForm;
        public OrderForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handler for about clicked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a object for about form 
            AboutBox myAboutBox = new AboutBox();

            //Show about box
            myAboutBox.ShowDialog();
        }

        /// <summary>
        /// Handler for print button clicked event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show a message box with message 
            MessageBox.Show("Your slected data is printing....!!!!!");
        }

        /// <summary>
        /// Exit tool trip menu button clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Terminate running application
        }

        /// <summary>
        /// Back tools strip menu button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">
        /// previous selected data 
        /// </param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Create a private object for product info form
            ProductInfoForm myProductForm = new ProductInfoForm();
            this.Hide(); // hide orderd form 
            
            // shows product form 
            myProductForm.Show();
            
        }

        /// <summary>
        /// Back button clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            // Create a private object for product info form
            ProductInfoForm myProductForm = new ProductInfoForm();
            this.Hide(); // hide orderd form 

            // shows product form 
            myProductForm.Show();
        }

        /// <summary>
        /// Cancel button clicked event handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Terminate running application
        }
    }
}
