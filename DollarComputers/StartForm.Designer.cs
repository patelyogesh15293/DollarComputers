namespace DollarComputers
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.productsTableAdapter1 = new DollarComputers.comp1004namesDataSetTableAdapters.productsTableAdapter();
            this.StartFormLabel = new System.Windows.Forms.Label();
            this.StartButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // StartFormLabel
            // 
            this.StartFormLabel.AutoSize = true;
            this.StartFormLabel.Location = new System.Drawing.Point(125, 46);
            this.StartFormLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StartFormLabel.Name = "StartFormLabel";
            this.StartFormLabel.Size = new System.Drawing.Size(243, 20);
            this.StartFormLabel.TabIndex = 0;
            this.StartFormLabel.Text = "Order Your Computer Today!!";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(116, 262);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(252, 36);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start a New Order";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(116, 346);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(252, 32);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(116, 304);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(252, 36);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Open a Saved Order";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DollarComputers.Properties.Resources.dollarcomputer;
            this.pictureBox1.Location = new System.Drawing.Point(157, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 162);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 402);
            this.ControlBox = false;
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.StartFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Dollar Computer!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private comp1004namesDataSetTableAdapters.productsTableAdapter productsTableAdapter1;
        private System.Windows.Forms.Label StartFormLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button SaveButton;
    }
}