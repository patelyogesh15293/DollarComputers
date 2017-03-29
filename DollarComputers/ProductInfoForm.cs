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
    public partial class ProductInfoForm : Form
    {
        //Create a db context object of database
        private ProductsContext dbProductContext = new ProductsContext();

        public SelectForm previousForm { get; set; }
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            // Populate data of product section
            IDTextBox.Text = Program.computerProducts.productID.ToString();
            ConditionTextBox.Text = Program.computerProducts.condition;
            CostTextBox.Text = "$" + Math.Round(Convert.ToDouble(Program.computerProducts.cost), 2).ToString();

            //Populate data of product info section
            PlatformTextBox.Text = Program.computerProducts.platform;
            ManufacturerTextBox.Text = Program.computerProducts.manufacturer;
            OSTextBox.Text = Program.computerProducts.OS;
            ModelTextBox.Text = Program.computerProducts.model;

            //Populate Techniacl specification data
            MemoryTextBox.Text = Program.computerProducts.RAM_size;
            CPUBrandTextBox.Text = Program.computerProducts.CPU_brand;
            CPUTypeTextBox.Text = Program.computerProducts.CPU_type;

            LCDSizeTextBox.Text = Program.computerProducts.screensize;
            CPUNumberTextBox.Text = Program.computerProducts.CPU_number;
            CPUSpeedTextBox.Text = Program.computerProducts.CPU_speed;

            HDDTextBox.Text = Program.computerProducts.HDD_size;
            GPUTypeTextBox.Text = Program.computerProducts.GPU_Type;
            WebcamTextBox.Text = Program.computerProducts.webcam;
        }

    }
}
