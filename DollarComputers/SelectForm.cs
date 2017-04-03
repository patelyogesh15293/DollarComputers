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
    public partial class SelectForm : Form
    {
        public Form previousForm;

        ProductInfoForm myProductInfoForm = new ProductInfoForm();
        //Create a db context object of database
        private ProductsContext dbProductContext = new ProductsContext();

        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            // select all the product information from table of the name DB            
            List<product> ProductList = (from product in dbProductContext.products
                                         select product).ToList();

            DollarComputerGridView.DataSource = ProductList;
        }

        /// <summary>
        /// Event handler for next button clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            myProductInfoForm.previousForm = this;
            this.Hide(); // Hide current form
            myProductInfoForm.Show(); // show next form 

        }

        /// <summary>
        /// Cancel button clicked handler 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Event for selection change in grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DollarComputerGridView_SelectionChanged(object sender, EventArgs e)
        {
            myProductInfoForm.previousForm = this;

            this.DollarComputerGridView.CurrentRow.Selected = true;

            Program.computerProducts = (product)DollarComputerGridView.CurrentRow.DataBoundItem;

            SelectionTextBox.Text = Program.computerProducts.manufacturer
                + "   " + Program.computerProducts.model + "   " + "$" + 
                Math.Round(Convert.ToDouble(Program.computerProducts.cost),2);
                
        }
    }
}
