namespace ComputerStore
{
    partial class Product_Page
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
            this.label1 = new System.Windows.Forms.Label();
            this.textSearchProduct = new System.Windows.Forms.TextBox();
            this.gvProduct = new System.Windows.Forms.DataGridView();
            this.btnShowOrdersProduct = new System.Windows.Forms.Button();
            this.btnFirstProduct = new System.Windows.Forms.Button();
            this.btnPreviousProduct = new System.Windows.Forms.Button();
            this.btnNextProduct = new System.Windows.Forms.Button();
            this.btnLastProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnShowEmployeesProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quick Search";
            // 
            // textSearchProduct
            // 
            this.textSearchProduct.Location = new System.Drawing.Point(91, 12);
            this.textSearchProduct.Name = "textSearchProduct";
            this.textSearchProduct.Size = new System.Drawing.Size(124, 20);
            this.textSearchProduct.TabIndex = 1;
            // 
            // gvProduct
            // 
            this.gvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvProduct.Location = new System.Drawing.Point(16, 46);
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.Size = new System.Drawing.Size(594, 136);
            this.gvProduct.TabIndex = 2;
            this.gvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnShowOrdersProduct
            // 
            this.btnShowOrdersProduct.Location = new System.Drawing.Point(16, 203);
            this.btnShowOrdersProduct.Name = "btnShowOrdersProduct";
            this.btnShowOrdersProduct.Size = new System.Drawing.Size(99, 23);
            this.btnShowOrdersProduct.TabIndex = 3;
            this.btnShowOrdersProduct.Text = "Show Orders";
            this.btnShowOrdersProduct.UseVisualStyleBackColor = true;
            // 
            // btnFirstProduct
            // 
            this.btnFirstProduct.Location = new System.Drawing.Point(140, 203);
            this.btnFirstProduct.Name = "btnFirstProduct";
            this.btnFirstProduct.Size = new System.Drawing.Size(91, 23);
            this.btnFirstProduct.TabIndex = 4;
            this.btnFirstProduct.Text = "First";
            this.btnFirstProduct.UseVisualStyleBackColor = true;
            // 
            // btnPreviousProduct
            // 
            this.btnPreviousProduct.Location = new System.Drawing.Point(273, 203);
            this.btnPreviousProduct.Name = "btnPreviousProduct";
            this.btnPreviousProduct.Size = new System.Drawing.Size(96, 23);
            this.btnPreviousProduct.TabIndex = 5;
            this.btnPreviousProduct.Text = "Previous";
            this.btnPreviousProduct.UseVisualStyleBackColor = true;
            // 
            // btnNextProduct
            // 
            this.btnNextProduct.Location = new System.Drawing.Point(399, 203);
            this.btnNextProduct.Name = "btnNextProduct";
            this.btnNextProduct.Size = new System.Drawing.Size(97, 23);
            this.btnNextProduct.TabIndex = 6;
            this.btnNextProduct.Text = "Next";
            this.btnNextProduct.UseVisualStyleBackColor = true;
            // 
            // btnLastProduct
            // 
            this.btnLastProduct.Location = new System.Drawing.Point(525, 201);
            this.btnLastProduct.Name = "btnLastProduct";
            this.btnLastProduct.Size = new System.Drawing.Size(84, 23);
            this.btnLastProduct.TabIndex = 7;
            this.btnLastProduct.Text = "Last";
            this.btnLastProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(525, 247);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(83, 23);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(399, 247);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(97, 23);
            this.btnDetails.TabIndex = 9;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(273, 246);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(96, 23);
            this.btnEditProduct.TabIndex = 10;
            this.btnEditProduct.Text = "Edit";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(140, 246);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(91, 23);
            this.btnDeleteProduct.TabIndex = 11;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnShowEmployeesProduct
            // 
            this.btnShowEmployeesProduct.Location = new System.Drawing.Point(16, 247);
            this.btnShowEmployeesProduct.Name = "btnShowEmployeesProduct";
            this.btnShowEmployeesProduct.Size = new System.Drawing.Size(99, 23);
            this.btnShowEmployeesProduct.TabIndex = 12;
            this.btnShowEmployeesProduct.Text = "Show Employees";
            this.btnShowEmployeesProduct.UseVisualStyleBackColor = true;
            // 
            // Product_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 287);
            this.Controls.Add(this.btnShowEmployeesProduct);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnLastProduct);
            this.Controls.Add(this.btnNextProduct);
            this.Controls.Add(this.btnPreviousProduct);
            this.Controls.Add(this.btnFirstProduct);
            this.Controls.Add(this.btnShowOrdersProduct);
            this.Controls.Add(this.gvProduct);
            this.Controls.Add(this.textSearchProduct);
            this.Controls.Add(this.label1);
            this.Name = "Product_Page";
            this.Text = "Product_Page";
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textSearchProduct;
        private System.Windows.Forms.DataGridView gvProduct;
        private System.Windows.Forms.Button btnShowOrdersProduct;
        private System.Windows.Forms.Button btnFirstProduct;
        private System.Windows.Forms.Button btnPreviousProduct;
        private System.Windows.Forms.Button btnNextProduct;
        private System.Windows.Forms.Button btnLastProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnShowEmployeesProduct;
    }
}