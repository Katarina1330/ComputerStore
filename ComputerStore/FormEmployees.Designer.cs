using System.Windows.Forms;

namespace ComputerStore
{
    partial class FormEmployees
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchEmployee = new System.Windows.Forms.TextBox();
            this.btnPreviousEmployee = new System.Windows.Forms.Button();
            this.btnNextEmployee = new System.Windows.Forms.Button();
            this.btnLastEmployee = new System.Windows.Forms.Button();
            this.gvEmployees = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemEmployeesOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFirstEmployee = new System.Windows.Forms.Button();
            this.btnAddOrderEmployee = new System.Windows.Forms.Button();
            this.btnDetailsEmployee = new System.Windows.Forms.Button();
            this.btnEditEmployee = new System.Windows.Forms.Button();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.btnShowOrdersEmployee = new System.Windows.Forms.Button();
            this.btnShowProductsEmployee = new System.Windows.Forms.Button();
            this.btnCreateNewEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployees)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // txtSearchEmployee
            // 
            this.txtSearchEmployee.Location = new System.Drawing.Point(59, 16);
            this.txtSearchEmployee.Name = "txtSearchEmployee";
            this.txtSearchEmployee.Size = new System.Drawing.Size(152, 20);
            this.txtSearchEmployee.TabIndex = 1;
            this.txtSearchEmployee.TextChanged += new System.EventHandler(this.txtSearchEmployee_TextChanged);
            // 
            // btnPreviousEmployee
            // 
            this.btnPreviousEmployee.Location = new System.Drawing.Point(349, 202);
            this.btnPreviousEmployee.Name = "btnPreviousEmployee";
            this.btnPreviousEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousEmployee.TabIndex = 2;
            this.btnPreviousEmployee.Text = "Previous";
            this.btnPreviousEmployee.UseVisualStyleBackColor = true;
            this.btnPreviousEmployee.Click += new System.EventHandler(this.btnPreviousEmployee_Click);
            // 
            // btnNextEmployee
            // 
            this.btnNextEmployee.Location = new System.Drawing.Point(442, 202);
            this.btnNextEmployee.Name = "btnNextEmployee";
            this.btnNextEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnNextEmployee.TabIndex = 3;
            this.btnNextEmployee.Text = "Next";
            this.btnNextEmployee.UseVisualStyleBackColor = true;
            this.btnNextEmployee.Click += new System.EventHandler(this.btnNextEmployee_Click);
            // 
            // btnLastEmployee
            // 
            this.btnLastEmployee.Location = new System.Drawing.Point(534, 202);
            this.btnLastEmployee.Name = "btnLastEmployee";
            this.btnLastEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnLastEmployee.TabIndex = 3;
            this.btnLastEmployee.Text = "Last";
            this.btnLastEmployee.UseVisualStyleBackColor = true;
            this.btnLastEmployee.Click += new System.EventHandler(this.btnLastEmployee_Click);
            // 
            // gvEmployees
            // 
            this.gvEmployees.AllowUserToAddRows = false;
            this.gvEmployees.AllowUserToDeleteRows = false;
            this.gvEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEmployees.ContextMenuStrip = this.contextMenuStrip1;
            this.gvEmployees.Location = new System.Drawing.Point(15, 53);
            this.gvEmployees.Name = "gvEmployees";
            this.gvEmployees.RowHeadersVisible = false;
            this.gvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvEmployees.Size = new System.Drawing.Size(608, 121);
            this.gvEmployees.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemEmployeesOrders});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 26);
            // 
            // MenuItemEmployeesOrders
            // 
            this.MenuItemEmployeesOrders.Name = "MenuItemEmployeesOrders";
            this.MenuItemEmployeesOrders.Size = new System.Drawing.Size(170, 22);
            this.MenuItemEmployeesOrders.Text = "Employees\' orders";
            this.MenuItemEmployeesOrders.Click += new System.EventHandler(this.MenuItemEmployeesOrders_Click);
            // 
            // btnFirstEmployee
            // 
            this.btnFirstEmployee.Location = new System.Drawing.Point(257, 202);
            this.btnFirstEmployee.Name = "btnFirstEmployee";
            this.btnFirstEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnFirstEmployee.TabIndex = 5;
            this.btnFirstEmployee.Text = "First";
            this.btnFirstEmployee.UseVisualStyleBackColor = true;
            this.btnFirstEmployee.Click += new System.EventHandler(this.btnFirstEmployee_Click);
            // 
            // btnAddOrderEmployee
            // 
            this.btnAddOrderEmployee.Location = new System.Drawing.Point(534, 253);
            this.btnAddOrderEmployee.Name = "btnAddOrderEmployee";
            this.btnAddOrderEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrderEmployee.TabIndex = 6;
            this.btnAddOrderEmployee.Text = "Add Order";
            this.btnAddOrderEmployee.UseVisualStyleBackColor = true;
            this.btnAddOrderEmployee.Click += new System.EventHandler(this.btnAddOrderEmployee_Click);
            // 
            // btnDetailsEmployee
            // 
            this.btnDetailsEmployee.Location = new System.Drawing.Point(442, 253);
            this.btnDetailsEmployee.Name = "btnDetailsEmployee";
            this.btnDetailsEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnDetailsEmployee.TabIndex = 7;
            this.btnDetailsEmployee.Text = "Details";
            this.btnDetailsEmployee.UseVisualStyleBackColor = true;
            this.btnDetailsEmployee.Click += new System.EventHandler(this.btnDetailsEmployee_Click);
            // 
            // btnEditEmployee
            // 
            this.btnEditEmployee.Location = new System.Drawing.Point(349, 253);
            this.btnEditEmployee.Name = "btnEditEmployee";
            this.btnEditEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnEditEmployee.TabIndex = 8;
            this.btnEditEmployee.Text = "Edit";
            this.btnEditEmployee.UseVisualStyleBackColor = true;
            this.btnEditEmployee.Click += new System.EventHandler(this.btnEditEmployee_Click);
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.Location = new System.Drawing.Point(257, 252);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmployee.TabIndex = 9;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // btnShowOrdersEmployee
            // 
            this.btnShowOrdersEmployee.Location = new System.Drawing.Point(15, 202);
            this.btnShowOrdersEmployee.Name = "btnShowOrdersEmployee";
            this.btnShowOrdersEmployee.Size = new System.Drawing.Size(132, 23);
            this.btnShowOrdersEmployee.TabIndex = 10;
            this.btnShowOrdersEmployee.Text = "Show Orders";
            this.btnShowOrdersEmployee.UseVisualStyleBackColor = true;
            this.btnShowOrdersEmployee.Click += new System.EventHandler(this.btnShowOrdersEmployee_Click);
            // 
            // btnShowProductsEmployee
            // 
            this.btnShowProductsEmployee.Location = new System.Drawing.Point(15, 231);
            this.btnShowProductsEmployee.Name = "btnShowProductsEmployee";
            this.btnShowProductsEmployee.Size = new System.Drawing.Size(132, 23);
            this.btnShowProductsEmployee.TabIndex = 11;
            this.btnShowProductsEmployee.Text = "Show Products";
            this.btnShowProductsEmployee.UseVisualStyleBackColor = true;
            this.btnShowProductsEmployee.Click += new System.EventHandler(this.btnShowProductsEmployee_Click);
            // 
            // btnCreateNewEmployee
            // 
            this.btnCreateNewEmployee.Location = new System.Drawing.Point(15, 260);
            this.btnCreateNewEmployee.Name = "btnCreateNewEmployee";
            this.btnCreateNewEmployee.Size = new System.Drawing.Size(132, 23);
            this.btnCreateNewEmployee.TabIndex = 12;
            this.btnCreateNewEmployee.Text = "Create New Employee";
            this.btnCreateNewEmployee.UseVisualStyleBackColor = true;
            this.btnCreateNewEmployee.Click += new System.EventHandler(this.btnCreateNewEmployee_Click);
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 329);
            this.Controls.Add(this.btnPreviousEmployee);
            this.Controls.Add(this.btnCreateNewEmployee);
            this.Controls.Add(this.btnShowProductsEmployee);
            this.Controls.Add(this.btnShowOrdersEmployee);
            this.Controls.Add(this.btnDeleteEmployee);
            this.Controls.Add(this.btnEditEmployee);
            this.Controls.Add(this.btnDetailsEmployee);
            this.Controls.Add(this.btnAddOrderEmployee);
            this.Controls.Add(this.btnFirstEmployee);
            this.Controls.Add(this.gvEmployees);
            this.Controls.Add(this.btnLastEmployee);
            this.Controls.Add(this.btnNextEmployee);
            this.Controls.Add(this.txtSearchEmployee);
            this.Controls.Add(this.label1);
            this.Name = "FormEmployees";
            this.Text = "Employees  Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEmployees_FormClosed);
            this.Load += new System.EventHandler(this.FromEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployees)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchEmployee;
        private System.Windows.Forms.Button btnPreviousEmployee;
        private System.Windows.Forms.Button btnNextEmployee;
        private System.Windows.Forms.Button btnLastEmployee;
        private System.Windows.Forms.DataGridView gvEmployees;
        private System.Windows.Forms.Button btnFirstEmployee;
        private System.Windows.Forms.Button btnAddOrderEmployee;
        private System.Windows.Forms.Button btnDetailsEmployee;
        private System.Windows.Forms.Button btnEditEmployee;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.Button btnShowOrdersEmployee;
        private System.Windows.Forms.Button btnShowProductsEmployee;
        private System.Windows.Forms.Button btnCreateNewEmployee;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem MenuItemEmployeesOrders;
    }
}

