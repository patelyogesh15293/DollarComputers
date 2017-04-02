﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DollarComputers
{
    public partial class StartForm : Form
    {
        // deaclare next form object
        private SelectForm mySelectForm = new SelectForm();

        // Create a private variables for open file 
        private StreamReader _reader;

        public StartForm()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Handler for clic start new order button event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartButton_Click(object sender, EventArgs e)
        {
            mySelectForm.previousForm = this;
            this.Hide(); // Hide current form
            mySelectForm.Show(); // show next form         
        }

        /// <summary>
        /// Event handler for click exit button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // terminate application
        }

        /// <summary>
        /// Event Handler for open button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm myProductForm = new ProductInfoForm();
            this.Close();
            myProductForm.Show();
        }
    }
}
