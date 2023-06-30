namespace Northwind.WebFormsUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Product = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxCategoryIdAdd = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxUnitsInStock = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitAdd = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceAdd = new System.Windows.Forms.TextBox();
            this.tbxProduckNameAdd = new System.Windows.Forms.TextBox();
            this.lblUnitsInStockAdd = new System.Windows.Forms.Label();
            this.lblQuantityPerUnitAdd = new System.Windows.Forms.Label();
            this.lblUnitPriceAdd = new System.Windows.Forms.Label();
            this.lblCategoryIdAdd = new System.Windows.Forms.Label();
            this.lblProducyNameAdd = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbxCategoryIdUpdate = new System.Windows.Forms.ComboBox();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.tbxUnitsInStockUpdate = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnitUpdate = new System.Windows.Forms.TextBox();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.tbxProductNameUpdate = new System.Windows.Forms.TextBox();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.lblQuantityPerUnitUpdate = new System.Windows.Forms.Label();
            this.lblUnitPriceUpdate = new System.Windows.Forms.Label();
            this.lblCategoryIdUpdate = new System.Windows.Forms.Label();
            this.lblProductNameUpdate = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.Product.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(24, 254);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.RowHeadersWidth = 51;
            this.dgwProduct.RowTemplate.Height = 24;
            this.dgwProduct.Size = new System.Drawing.Size(719, 123);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Location = new System.Drawing.Point(24, 30);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(744, 72);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kateforiye Göre Ara";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(102, 31);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(266, 24);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(7, 31);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 16);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori Adı";
            // 
            // Product
            // 
            this.Product.Controls.Add(this.tbxProductName);
            this.Product.Controls.Add(this.lblProduct);
            this.Product.Location = new System.Drawing.Point(24, 120);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(744, 90);
            this.Product.TabIndex = 2;
            this.Product.TabStop = false;
            this.Product.Text = "Ürüne Göre Ara";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(102, 43);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(266, 22);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(10, 43);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(58, 16);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "Ürün Adı";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxCategoryIdAdd);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbxUnitsInStock);
            this.groupBox1.Controls.Add(this.tbxQuantityPerUnitAdd);
            this.groupBox1.Controls.Add(this.tbxUnitPriceAdd);
            this.groupBox1.Controls.Add(this.tbxProduckNameAdd);
            this.groupBox1.Controls.Add(this.lblUnitsInStockAdd);
            this.groupBox1.Controls.Add(this.lblQuantityPerUnitAdd);
            this.groupBox1.Controls.Add(this.lblUnitPriceAdd);
            this.groupBox1.Controls.Add(this.lblCategoryIdAdd);
            this.groupBox1.Controls.Add(this.lblProducyNameAdd);
            this.groupBox1.Location = new System.Drawing.Point(24, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 208);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Ürün Ekle";
            // 
            // cbxCategoryIdAdd
            // 
            this.cbxCategoryIdAdd.FormattingEnabled = true;
            this.cbxCategoryIdAdd.Location = new System.Drawing.Point(131, 53);
            this.cbxCategoryIdAdd.Name = "cbxCategoryIdAdd";
            this.cbxCategoryIdAdd.Size = new System.Drawing.Size(261, 24);
            this.cbxCategoryIdAdd.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(245, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add New Product";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxUnitsInStock
            // 
            this.tbxUnitsInStock.Location = new System.Drawing.Point(131, 142);
            this.tbxUnitsInStock.Name = "tbxUnitsInStock";
            this.tbxUnitsInStock.Size = new System.Drawing.Size(261, 22);
            this.tbxUnitsInStock.TabIndex = 9;
            // 
            // tbxQuantityPerUnitAdd
            // 
            this.tbxQuantityPerUnitAdd.Location = new System.Drawing.Point(131, 112);
            this.tbxQuantityPerUnitAdd.Name = "tbxQuantityPerUnitAdd";
            this.tbxQuantityPerUnitAdd.Size = new System.Drawing.Size(261, 22);
            this.tbxQuantityPerUnitAdd.TabIndex = 8;
            // 
            // tbxUnitPriceAdd
            // 
            this.tbxUnitPriceAdd.Location = new System.Drawing.Point(131, 84);
            this.tbxUnitPriceAdd.Name = "tbxUnitPriceAdd";
            this.tbxUnitPriceAdd.Size = new System.Drawing.Size(261, 22);
            this.tbxUnitPriceAdd.TabIndex = 7;
            // 
            // tbxProduckNameAdd
            // 
            this.tbxProduckNameAdd.Location = new System.Drawing.Point(131, 24);
            this.tbxProduckNameAdd.Name = "tbxProduckNameAdd";
            this.tbxProduckNameAdd.Size = new System.Drawing.Size(261, 22);
            this.tbxProduckNameAdd.TabIndex = 5;
            // 
            // lblUnitsInStockAdd
            // 
            this.lblUnitsInStockAdd.AutoSize = true;
            this.lblUnitsInStockAdd.Location = new System.Drawing.Point(13, 149);
            this.lblUnitsInStockAdd.Name = "lblUnitsInStockAdd";
            this.lblUnitsInStockAdd.Size = new System.Drawing.Size(81, 16);
            this.lblUnitsInStockAdd.TabIndex = 4;
            this.lblUnitsInStockAdd.Text = "UnitsInStock";
            // 
            // lblQuantityPerUnitAdd
            // 
            this.lblQuantityPerUnitAdd.AutoSize = true;
            this.lblQuantityPerUnitAdd.Location = new System.Drawing.Point(13, 119);
            this.lblQuantityPerUnitAdd.Name = "lblQuantityPerUnitAdd";
            this.lblQuantityPerUnitAdd.Size = new System.Drawing.Size(99, 16);
            this.lblQuantityPerUnitAdd.TabIndex = 3;
            this.lblQuantityPerUnitAdd.Text = "QuantityPerUnit";
            // 
            // lblUnitPriceAdd
            // 
            this.lblUnitPriceAdd.AutoSize = true;
            this.lblUnitPriceAdd.Location = new System.Drawing.Point(13, 91);
            this.lblUnitPriceAdd.Name = "lblUnitPriceAdd";
            this.lblUnitPriceAdd.Size = new System.Drawing.Size(61, 16);
            this.lblUnitPriceAdd.TabIndex = 2;
            this.lblUnitPriceAdd.Text = "UnitPrice";
            // 
            // lblCategoryIdAdd
            // 
            this.lblCategoryIdAdd.AutoSize = true;
            this.lblCategoryIdAdd.Location = new System.Drawing.Point(13, 61);
            this.lblCategoryIdAdd.Name = "lblCategoryIdAdd";
            this.lblCategoryIdAdd.Size = new System.Drawing.Size(73, 16);
            this.lblCategoryIdAdd.TabIndex = 1;
            this.lblCategoryIdAdd.Text = "CategoryId";
            // 
            // lblProducyNameAdd
            // 
            this.lblProducyNameAdd.AutoSize = true;
            this.lblProducyNameAdd.Location = new System.Drawing.Point(13, 31);
            this.lblProducyNameAdd.Name = "lblProducyNameAdd";
            this.lblProducyNameAdd.Size = new System.Drawing.Size(90, 16);
            this.lblProducyNameAdd.TabIndex = 0;
            this.lblProducyNameAdd.Text = "ProductName";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbxCategoryIdUpdate);
            this.groupBox2.Controls.Add(this.btnProductUpdate);
            this.groupBox2.Controls.Add(this.tbxUnitsInStockUpdate);
            this.groupBox2.Controls.Add(this.tbxQuantityPerUnitUpdate);
            this.groupBox2.Controls.Add(this.tbxUnitPriceUpdate);
            this.groupBox2.Controls.Add(this.tbxProductNameUpdate);
            this.groupBox2.Controls.Add(this.lblUnitsInStock);
            this.groupBox2.Controls.Add(this.lblQuantityPerUnitUpdate);
            this.groupBox2.Controls.Add(this.lblUnitPriceUpdate);
            this.groupBox2.Controls.Add(this.lblCategoryIdUpdate);
            this.groupBox2.Controls.Add(this.lblProductNameUpdate);
            this.groupBox2.Location = new System.Drawing.Point(465, 418);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 208);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün Güncelle";
            // 
            // cbxCategoryIdUpdate
            // 
            this.cbxCategoryIdUpdate.FormattingEnabled = true;
            this.cbxCategoryIdUpdate.Location = new System.Drawing.Point(131, 53);
            this.cbxCategoryIdUpdate.Name = "cbxCategoryIdUpdate";
            this.cbxCategoryIdUpdate.Size = new System.Drawing.Size(261, 24);
            this.cbxCategoryIdUpdate.TabIndex = 11;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(245, 179);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(147, 23);
            this.btnProductUpdate.TabIndex = 10;
            this.btnProductUpdate.Text = "Update To Product";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            this.btnProductUpdate.Click += new System.EventHandler(this.btnProductUpdate_Click);
            // 
            // tbxUnitsInStockUpdate
            // 
            this.tbxUnitsInStockUpdate.Location = new System.Drawing.Point(131, 142);
            this.tbxUnitsInStockUpdate.Name = "tbxUnitsInStockUpdate";
            this.tbxUnitsInStockUpdate.Size = new System.Drawing.Size(261, 22);
            this.tbxUnitsInStockUpdate.TabIndex = 9;
            // 
            // tbxQuantityPerUnitUpdate
            // 
            this.tbxQuantityPerUnitUpdate.Location = new System.Drawing.Point(131, 112);
            this.tbxQuantityPerUnitUpdate.Name = "tbxQuantityPerUnitUpdate";
            this.tbxQuantityPerUnitUpdate.Size = new System.Drawing.Size(261, 22);
            this.tbxQuantityPerUnitUpdate.TabIndex = 8;
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(131, 84);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(261, 22);
            this.tbxUnitPriceUpdate.TabIndex = 7;
            // 
            // tbxProductNameUpdate
            // 
            this.tbxProductNameUpdate.Location = new System.Drawing.Point(131, 24);
            this.tbxProductNameUpdate.Name = "tbxProductNameUpdate";
            this.tbxProductNameUpdate.Size = new System.Drawing.Size(261, 22);
            this.tbxProductNameUpdate.TabIndex = 5;
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(13, 149);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(81, 16);
            this.lblUnitsInStock.TabIndex = 4;
            this.lblUnitsInStock.Text = "UnitsInStock";
            // 
            // lblQuantityPerUnitUpdate
            // 
            this.lblQuantityPerUnitUpdate.AutoSize = true;
            this.lblQuantityPerUnitUpdate.Location = new System.Drawing.Point(13, 119);
            this.lblQuantityPerUnitUpdate.Name = "lblQuantityPerUnitUpdate";
            this.lblQuantityPerUnitUpdate.Size = new System.Drawing.Size(99, 16);
            this.lblQuantityPerUnitUpdate.TabIndex = 3;
            this.lblQuantityPerUnitUpdate.Text = "QuantityPerUnit";
            // 
            // lblUnitPriceUpdate
            // 
            this.lblUnitPriceUpdate.AutoSize = true;
            this.lblUnitPriceUpdate.Location = new System.Drawing.Point(13, 91);
            this.lblUnitPriceUpdate.Name = "lblUnitPriceUpdate";
            this.lblUnitPriceUpdate.Size = new System.Drawing.Size(61, 16);
            this.lblUnitPriceUpdate.TabIndex = 2;
            this.lblUnitPriceUpdate.Text = "UnitPrice";
            // 
            // lblCategoryIdUpdate
            // 
            this.lblCategoryIdUpdate.AutoSize = true;
            this.lblCategoryIdUpdate.Location = new System.Drawing.Point(13, 61);
            this.lblCategoryIdUpdate.Name = "lblCategoryIdUpdate";
            this.lblCategoryIdUpdate.Size = new System.Drawing.Size(73, 16);
            this.lblCategoryIdUpdate.TabIndex = 1;
            this.lblCategoryIdUpdate.Text = "CategoryId";
            // 
            // lblProductNameUpdate
            // 
            this.lblProductNameUpdate.AutoSize = true;
            this.lblProductNameUpdate.Location = new System.Drawing.Point(13, 31);
            this.lblProductNameUpdate.Name = "lblProductNameUpdate";
            this.lblProductNameUpdate.Size = new System.Drawing.Size(90, 16);
            this.lblProductNameUpdate.TabIndex = 0;
            this.lblProductNameUpdate.Text = "ProductName";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(778, 354);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(142, 23);
            this.btnDeleteProduct.TabIndex = 13;
            this.btnDeleteProduct.Text = "Delete The Product";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 638);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.Product.ResumeLayout(false);
            this.Product.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox Product;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUnitsInStockAdd;
        private System.Windows.Forms.Label lblQuantityPerUnitAdd;
        private System.Windows.Forms.Label lblUnitPriceAdd;
        private System.Windows.Forms.Label lblCategoryIdAdd;
        private System.Windows.Forms.Label lblProducyNameAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxUnitsInStock;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitAdd;
        private System.Windows.Forms.TextBox tbxUnitPriceAdd;
        private System.Windows.Forms.TextBox tbxProduckNameAdd;
        private System.Windows.Forms.ComboBox cbxCategoryIdAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbxCategoryIdUpdate;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.TextBox tbxUnitsInStockUpdate;
        private System.Windows.Forms.TextBox tbxQuantityPerUnitUpdate;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.TextBox tbxProductNameUpdate;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.Label lblQuantityPerUnitUpdate;
        private System.Windows.Forms.Label lblUnitPriceUpdate;
        private System.Windows.Forms.Label lblCategoryIdUpdate;
        private System.Windows.Forms.Label lblProductNameUpdate;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}

