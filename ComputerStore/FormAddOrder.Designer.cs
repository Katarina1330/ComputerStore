namespace ComputerStore
{
    partial class FormAddOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPriceOrder = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOrder = new System.Windows.Forms.DateTimePicker();
            this.cmbCashRegister = new System.Windows.Forms.ComboBox();
            this.cmbNameEmployee = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cash Register";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price Order";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name Employee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Name Customer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Details";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 233);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Quantity";
            // 
            // txtPriceOrder
            // 
            this.txtPriceOrder.Location = new System.Drawing.Point(132, 87);
            this.txtPriceOrder.Name = "txtPriceOrder";
            this.txtPriceOrder.ReadOnly = true;
            this.txtPriceOrder.Size = new System.Drawing.Size(200, 20);
            this.txtPriceOrder.TabIndex = 10;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(132, 168);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(200, 20);
            this.txtDetails.TabIndex = 13;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(132, 197);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(200, 20);
            this.txtQuantity.TabIndex = 14;
            // 
            // dateTimePickerDateOrder
            // 
            this.dateTimePickerDateOrder.Location = new System.Drawing.Point(132, 25);
            this.dateTimePickerDateOrder.Name = "dateTimePickerDateOrder";
            this.dateTimePickerDateOrder.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDateOrder.TabIndex = 16;
            // 
            // cmbCashRegister
            // 
            this.cmbCashRegister.FormattingEnabled = true;
            this.cmbCashRegister.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbCashRegister.Location = new System.Drawing.Point(132, 54);
            this.cmbCashRegister.Name = "cmbCashRegister";
            this.cmbCashRegister.Size = new System.Drawing.Size(200, 21);
            this.cmbCashRegister.TabIndex = 17;
            // 
            // cmbNameEmployee
            // 
            this.cmbNameEmployee.FormattingEnabled = true;
            this.cmbNameEmployee.Location = new System.Drawing.Point(132, 113);
            this.cmbNameEmployee.Name = "cmbNameEmployee";
            this.cmbNameEmployee.Size = new System.Drawing.Size(200, 21);
            this.cmbNameEmployee.TabIndex = 18;
            this.cmbNameEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbNameEmployee_SelectedIndexChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(19, 272);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 29);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 29);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(132, 225);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(200, 21);
            this.cmbProduct.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date Order";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Location = new System.Drawing.Point(132, 140);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(200, 20);
            this.txtNameCustomer.TabIndex = 12;
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.Enabled = false;
            this.btnSaveProduct.Location = new System.Drawing.Point(19, 307);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(118, 29);
            this.btnSaveProduct.TabIndex = 22;
            this.btnSaveProduct.Text = "Save product";
            this.btnSaveProduct.UseVisualStyleBackColor = true;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // FormAddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 366);
            this.Controls.Add(this.btnSaveProduct);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbNameEmployee);
            this.Controls.Add(this.cmbCashRegister);
            this.Controls.Add(this.dateTimePickerDateOrder);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.txtNameCustomer);
            this.Controls.Add(this.txtPriceOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAddOrder";
            this.Text = "FormAddOrder";
            this.Load += new System.EventHandler(this.FormAddOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPriceOrder;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOrder;
        private System.Windows.Forms.ComboBox cmbCashRegister;
        private System.Windows.Forms.ComboBox cmbNameEmployee;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.Button btnSaveProduct;
    }
}