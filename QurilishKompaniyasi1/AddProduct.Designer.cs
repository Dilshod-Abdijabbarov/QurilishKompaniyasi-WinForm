
namespace QurilishKompaniyasi1
{
    partial class AddProductForm3
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
            this.components = new System.ComponentModel.Container();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ProductTextBox = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.Label();
            this.KompanyName = new System.Windows.Forms.Label();
            this.CompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryTextBox = new System.Windows.Forms.TextBox();
            this.Quantitylabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductidtextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.Lime;
            this.AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddProduct.Location = new System.Drawing.Point(503, 238);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(121, 33);
            this.AddProduct.TabIndex = 2;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ProductTextBox
            // 
            this.ProductTextBox.Location = new System.Drawing.Point(192, 42);
            this.ProductTextBox.Multiline = true;
            this.ProductTextBox.Name = "ProductTextBox";
            this.ProductTextBox.Size = new System.Drawing.Size(262, 31);
            this.ProductTextBox.TabIndex = 3;
            // 
            // ProductName
            // 
            this.ProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductName.AutoSize = true;
            this.ProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductName.Location = new System.Drawing.Point(40, 50);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(106, 20);
            this.ProductName.TabIndex = 4;
            this.ProductName.Text = "ProductName";
            this.ProductName.Click += new System.EventHandler(this.label1_Click);
            // 
            // KompanyName
            // 
            this.KompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KompanyName.AutoSize = true;
            this.KompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KompanyName.Location = new System.Drawing.Point(40, 102);
            this.KompanyName.Name = "KompanyName";
            this.KompanyName.Size = new System.Drawing.Size(118, 20);
            this.KompanyName.TabIndex = 6;
            this.KompanyName.Text = "CompanyName";
            this.KompanyName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // CompanyNameTextBox
            // 
            this.CompanyNameTextBox.Location = new System.Drawing.Point(192, 94);
            this.CompanyNameTextBox.Multiline = true;
            this.CompanyNameTextBox.Name = "CompanyNameTextBox";
            this.CompanyNameTextBox.Size = new System.Drawing.Size(262, 31);
            this.CompanyNameTextBox.TabIndex = 5;
            this.CompanyNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Price
            // 
            this.Price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price.Location = new System.Drawing.Point(40, 199);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(44, 20);
            this.Price.TabIndex = 8;
            this.Price.Text = "Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(192, 191);
            this.PriceTextBox.Multiline = true;
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(262, 31);
            this.PriceTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(40, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Category";
            // 
            // CategoryTextBox
            // 
            this.CategoryTextBox.Location = new System.Drawing.Point(192, 240);
            this.CategoryTextBox.Multiline = true;
            this.CategoryTextBox.Name = "CategoryTextBox";
            this.CategoryTextBox.Size = new System.Drawing.Size(262, 31);
            this.CategoryTextBox.TabIndex = 9;
            // 
            // Quantitylabel
            // 
            this.Quantitylabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantitylabel.AutoSize = true;
            this.Quantitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Quantitylabel.Location = new System.Drawing.Point(40, 150);
            this.Quantitylabel.Name = "Quantitylabel";
            this.Quantitylabel.Size = new System.Drawing.Size(68, 20);
            this.Quantitylabel.TabIndex = 12;
            this.Quantitylabel.Text = "Quantity";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(192, 142);
            this.QuantityTextBox.Multiline = true;
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(262, 31);
            this.QuantityTextBox.TabIndex = 13;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(QurilishKompaniyasi1.Models.Product);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(503, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(40, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Update Productid";
            // 
            // ProductidtextBox
            // 
            this.ProductidtextBox.Location = new System.Drawing.Point(192, 303);
            this.ProductidtextBox.Multiline = true;
            this.ProductidtextBox.Name = "ProductidtextBox";
            this.ProductidtextBox.Size = new System.Drawing.Size(262, 31);
            this.ProductidtextBox.TabIndex = 15;
            // 
            // AddProductForm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 366);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductidtextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.Quantitylabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CategoryTextBox);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.KompanyName);
            this.Controls.Add(this.CompanyNameTextBox);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.ProductTextBox);
            this.Controls.Add(this.AddProduct);
            this.Name = "AddProductForm3";
            this.Text = "AddProductForm3";
            this.Load += new System.EventHandler(this.AddProductForm3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.TextBox ProductTextBox;
        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.Label KompanyName;
        private System.Windows.Forms.TextBox CompanyNameTextBox;
        private System.Windows.Forms.Label Price;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryTextBox;
        private System.Windows.Forms.Label Quantitylabel;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductidtextBox;
    }
}