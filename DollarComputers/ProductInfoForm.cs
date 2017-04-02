using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        //private variable for fetch product ID
        private Int32 _productID;

        private StreamWriter _writer;
        private StreamReader _reader;
        public SelectForm previousForm { get; set; }
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add form load event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            if (Program.computerProducts.productID == 0)
            {
                this.Show();
                openToolStripMenuItem_Click(sender, e);
            }
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

        /// <summary>
        /// Next button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            //Create an Object of OrderForm
            OrderForm myOrderForm = new OrderForm();
            myOrderForm.previousForm = this;

            //Hides this productInfoForm
            this.Hide();

            //Display the next OrderForm
            myOrderForm.Show();
        }

        /// <summary>
        /// Cancel Button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); // for terminate application
        }

        /// <summary>
        /// Select another product button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectButton_Click(object sender, EventArgs e)
        {
            SelectForm mySelectForm = new SelectForm();
            mySelectForm.Show();
            this.Close();
        }

        private void selectProductStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectButton_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string filename;

            productSaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.* ";
            productSaveFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            result = productSaveFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                filename = productSaveFileDialog.FileName;
                try
                {
                    this._writer = new StreamWriter(filename,true);
                    
                    _writer.WriteLine(IDTextBox.Text);
                    _writer.WriteLine(ConditionTextBox.Text);
                    _writer.WriteLine(CostTextBox.Text);
                    _writer.WriteLine(PlatformTextBox.Text);
                    _writer.WriteLine(OSTextBox.Text);
                    _writer.WriteLine(ManufacturerTextBox.Text);
                    _writer.WriteLine(ModelTextBox.Text);
                    _writer.WriteLine(MemoryTextBox.Text);
                    _writer.WriteLine(LCDSizeTextBox.Text);
                    _writer.WriteLine(HDDTextBox.Text);
                    _writer.WriteLine(CPUBrandTextBox.Text);
                    _writer.WriteLine(CPUNumberTextBox.Text);
                    _writer.WriteLine(GPUTypeTextBox.Text);
                    _writer.WriteLine(CPUTypeTextBox.Text);
                    _writer.WriteLine(CPUSpeedTextBox.Text);
                    _writer.WriteLine(WebcamTextBox.Text);

                    this._writer.Close();

                    MessageBox.Show("You got save your data", "sucess",
                         MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);
                    MessageBox.Show("Error writing file", "file error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string filename;

            productOpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.* ";
            productOpenFileDialog.InitialDirectory = Directory.GetCurrentDirectory();

            result = productOpenFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                filename = productOpenFileDialog.FileName;
                try
                {
                    this._reader = new StreamReader(filename);

                    if (_reader.Peek() != -1)
                    {
                        IDTextBox.Text = this._reader.ReadLine();
                        ConditionTextBox.Text = this._reader.ReadLine();
                        CostTextBox.Text = this._reader.ReadLine();
                        PlatformTextBox.Text = this._reader.ReadLine();
                        OSTextBox.Text = this._reader.ReadLine();
                        ManufacturerTextBox.Text = this._reader.ReadLine();
                        ModelTextBox.Text = this._reader.ReadLine();
                        MemoryTextBox.Text = this._reader.ReadLine();
                        LCDSizeTextBox.Text = this._reader.ReadLine();
                        HDDTextBox.Text = this._reader.ReadLine();
                        CPUBrandTextBox.Text = this._reader.ReadLine();
                        CPUNumberTextBox.Text = this._reader.ReadLine();
                        GPUTypeTextBox.Text = this._reader.ReadLine();
                        CPUTypeTextBox.Text = this._reader.ReadLine();
                        CPUSpeedTextBox.Text = this._reader.ReadLine();
                        WebcamTextBox.Text = this._reader.ReadLine();

                        _productID = Convert.ToInt32(IDTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Error writing file", "file error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    this._reader.Close();
                }
                catch (Exception exception)
                {
                    Debug.WriteLine(exception.Message);

                    MessageBox.Show("Error writing file", "file error",
                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Program.computerProducts = (from product in dbProductContext.products
                                            where product.productID == _productID
                                            select product).FirstOrDefault();
                //try
                //{
                //    Program.computerProducts = (from product in dbProductContext.products
                //                                where product.productID == _productID
                //                                select product).FirstOrDefault();
                //}
                //catch
                //{
                //    MessageBox.Show("Sorry!! Your saved file is no longer available",
                //        "Error reading file", MessageBoxButtons.RetryCancel, MessageBoxIcon.Question);
                //}

            }
        }
    }
}
