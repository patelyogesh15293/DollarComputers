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
            MessageBox.Show("Your selected data is printing....!!!!!");
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

        /// <summary>
        /// Finish button clicked event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FinishButton_Click(object sender, EventArgs e)
        {
            // Message box for message
            MessageBox.Show("Thank you for shopping with DollarCoputer" + "\n" +
                "Your order will be processed in 7-10 business day", "Data gathering error " ,MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Declare Message box button varialbe
            MessageBoxButtons result = MessageBoxButtons.OK;
            
            // If condition for check result
            if (result == MessageBoxButtons.OK)
            {
                Application.Exit();// Terminate application
            }
        }

        /// <summary>
        /// On load event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderForm_Load(object sender, EventArgs e)
        {
            // Fill all user selected data
            ConditionTextBox.Text = Program.computerProducts.condition;
            ManufacturerTextBox.Text = Program.computerProducts.manufacturer;
            ModelTextBox.Text = Program.computerProducts.model;
            PlatformTextBox.Text = Program.computerProducts.platform;
            PictureBox.Image = Properties.Resources.SelectedComputer;

            LCDSizeTextBox.Text = Program.computerProducts.screensize;
            MemoryTextBox.Text = Program.computerProducts.RAM_size;
            CPUBrandTextBox.Text = Program.computerProducts.CPU_brand;
            CPUTypeTextBox.Text = Program.computerProducts.CPU_type;
            CPUNumberTextBox.Text = Program.computerProducts.CPU_number;
            CPUSpeedTextBox.Text = Program.computerProducts.CPU_speed;
            HDDTextBox.Text = Program.computerProducts.HDD_size;
            GPUTypeTextBox.Text = Program.computerProducts.GPU_Type;
            WebcamTextBox.Text = Program.computerProducts.webcam;
            OSTextBox.Text = Program.computerProducts.OS;

            //Calculate Total Amount of Computer
            double price = Math.Round(Convert.ToDouble(Program.computerProducts.cost),2);
            double calculateTax = Math.Round(price * 0.13,2);
            double totalPrice =  price + calculateTax;

            //Display all Amount in appropriate Textboxes
            PriceTextBox.Text = "$" + price.ToString();
            TaxTextBox.Text = "$" + calculateTax.ToString();
            TotalTextBox.Text = "$" + totalPrice.ToString();
        }
    }
}
