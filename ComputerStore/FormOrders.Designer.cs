using System.Windows.Forms;

namespace ComputerStore
{
    partial class FormOrders
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
            this.gvOrders = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchOrders = new System.Windows.Forms.TextBox();
            this.btnFirstOrders = new System.Windows.Forms.Button();
            this.btnPreviousOrders = new System.Windows.Forms.Button();
            this.btnNextOrders = new System.Windows.Forms.Button();
            this.btnLastOrders = new System.Windows.Forms.Button();
            this.btnDeleteOrders = new System.Windows.Forms.Button();
            this.btnEditOrders = new System.Windows.Forms.Button();
            this.btnDetailsOrders = new System.Windows.Forms.Button();
            this.btnShowProductsOrders = new System.Windows.Forms.Button();
            this.btnShowEmployeesOrders = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.gvOrderItems = new System.Windows.Forms.DataGridView();
            this.btnFirstOrderItems = new System.Windows.Forms.Button();
            this.btnPreviousOrderItems = new System.Windows.Forms.Button();
            this.btnNextOrderItems = new System.Windows.Forms.Button();
            this.btnLastOrderItems = new System.Windows.Forms.Button();
            this.btnDeleteOrderItems = new System.Windows.Forms.Button();
            this.btnEditOrderItems = new System.Windows.Forms.Button();
            this.btnDetailsOrderItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderItems)).BeginInit();
            this.SuspendLayout();
            // 
            // gvOrders
            // 
            this.gvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrders.Location = new System.Drawing.Point(12, 51);
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.RowHeadersVisible = false;
            this.gvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvOrders.Size = new System.Drawing.Size(630, 148);
            this.gvOrders.TabIndex = 0;
            this.gvOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrders_CellContentClick);
            this.gvOrders.SelectionChanged += new System.EventHandler(this.gvOrders_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // txtSearchOrders
            // 
            this.txtSearchOrders.Location = new System.Drawing.Point(59, 18);
            this.txtSearchOrders.Name = "txtSearchOrders";
            this.txtSearchOrders.Size = new System.Drawing.Size(153, 20);
            this.txtSearchOrders.TabIndex = 3;
            // 
            // btnFirstOrders
            // 
            this.btnFirstOrders.Location = new System.Drawing.Point(281, 205);
            this.btnFirstOrders.Name = "btnFirstOrders";
            this.btnFirstOrders.Size = new System.Drawing.Size(75, 23);
            this.btnFirstOrders.TabIndex = 4;
            this.btnFirstOrders.Text = "First";
            this.btnFirstOrders.UseVisualStyleBackColor = true;
            this.btnFirstOrders.Click += new System.EventHandler(this.btnFirstOrders_Click);
            // 
            // btnPreviousOrders
            // 
            this.btnPreviousOrders.Location = new System.Drawing.Point(374, 205);
            this.btnPreviousOrders.Name = "btnPreviousOrders";
            this.btnPreviousOrders.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousOrders.TabIndex = 5;
            this.btnPreviousOrders.Text = "Previous";
            this.btnPreviousOrders.UseVisualStyleBackColor = true;
            this.btnPreviousOrders.Click += new System.EventHandler(this.btnPreviousOrders_Click);
            // 
            // btnNextOrders
            // 
            this.btnNextOrders.Location = new System.Drawing.Point(467, 205);
            this.btnNextOrders.Name = "btnNextOrders";
            this.btnNextOrders.Size = new System.Drawing.Size(75, 23);
            this.btnNextOrders.TabIndex = 6;
            this.btnNextOrders.Text = "Next";
            this.btnNextOrders.UseVisualStyleBackColor = true;
            this.btnNextOrders.Click += new System.EventHandler(this.btnNextOrders_Click);
            // 
            // btnLastOrders
            // 
            this.btnLastOrders.Location = new System.Drawing.Point(567, 205);
            this.btnLastOrders.Name = "btnLastOrders";
            this.btnLastOrders.Size = new System.Drawing.Size(75, 23);
            this.btnLastOrders.TabIndex = 7;
            this.btnLastOrders.Text = "Last";
            this.btnLastOrders.UseVisualStyleBackColor = true;
            this.btnLastOrders.Click += new System.EventHandler(this.btnLastOrders_Click);
            // 
            // btnDeleteOrders
            // 
            this.btnDeleteOrders.Location = new System.Drawing.Point(374, 243);
            this.btnDeleteOrders.Name = "btnDeleteOrders";
            this.btnDeleteOrders.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrders.TabIndex = 8;
            this.btnDeleteOrders.Text = "Delete";
            this.btnDeleteOrders.UseVisualStyleBackColor = true;
            // 
            // btnEditOrders
            // 
            this.btnEditOrders.Location = new System.Drawing.Point(467, 243);
            this.btnEditOrders.Name = "btnEditOrders";
            this.btnEditOrders.Size = new System.Drawing.Size(75, 23);
            this.btnEditOrders.TabIndex = 9;
            this.btnEditOrders.Text = "Edit";
            this.btnEditOrders.UseVisualStyleBackColor = true;
            // 
            // btnDetailsOrders
            // 
            this.btnDetailsOrders.Location = new System.Drawing.Point(567, 243);
            this.btnDetailsOrders.Name = "btnDetailsOrders";
            this.btnDetailsOrders.Size = new System.Drawing.Size(75, 23);
            this.btnDetailsOrders.TabIndex = 10;
            this.btnDetailsOrders.Text = "Details";
            this.btnDetailsOrders.UseVisualStyleBackColor = true;
            // 
            // btnShowProductsOrders
            // 
            this.btnShowProductsOrders.Location = new System.Drawing.Point(12, 215);
            this.btnShowProductsOrders.Name = "btnShowProductsOrders";
            this.btnShowProductsOrders.Size = new System.Drawing.Size(106, 23);
            this.btnShowProductsOrders.TabIndex = 11;
            this.btnShowProductsOrders.Text = "Show Products";
            this.btnShowProductsOrders.UseVisualStyleBackColor = true;
            this.btnShowProductsOrders.Click += new System.EventHandler(this.btnShowProductsOrders_Click);
            // 
            // btnShowEmployeesOrders
            // 
            this.btnShowEmployeesOrders.Location = new System.Drawing.Point(12, 244);
            this.btnShowEmployeesOrders.Name = "btnShowEmployeesOrders";
            this.btnShowEmployeesOrders.Size = new System.Drawing.Size(106, 23);
            this.btnShowEmployeesOrders.TabIndex = 12;
            this.btnShowEmployeesOrders.Text = "Show Employees";
            this.btnShowEmployeesOrders.UseVisualStyleBackColor = true;
            this.btnShowEmployeesOrders.Click += new System.EventHandler(this.btnShowEmployeesOrders_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(464, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "To";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(312, 18);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(485, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(157, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // gvOrderItems
            // 
            this.gvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrderItems.Location = new System.Drawing.Point(12, 290);
            this.gvOrderItems.Name = "gvOrderItems";
            this.gvOrderItems.RowHeadersVisible = false;
            this.gvOrderItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvOrderItems.Size = new System.Drawing.Size(627, 93);
            this.gvOrderItems.TabIndex = 17;
            // 
            // btnFirstOrderItems
            // 
            this.btnFirstOrderItems.Location = new System.Drawing.Point(281, 401);
            this.btnFirstOrderItems.Name = "btnFirstOrderItems";
            this.btnFirstOrderItems.Size = new System.Drawing.Size(75, 23);
            this.btnFirstOrderItems.TabIndex = 18;
            this.btnFirstOrderItems.Text = "First";
            this.btnFirstOrderItems.UseVisualStyleBackColor = true;
            this.btnFirstOrderItems.Click += new System.EventHandler(this.btnFirstOrderItems_Click);
            // 
            // btnPreviousOrderItems
            // 
            this.btnPreviousOrderItems.Location = new System.Drawing.Point(374, 401);
            this.btnPreviousOrderItems.Name = "btnPreviousOrderItems";
            this.btnPreviousOrderItems.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousOrderItems.TabIndex = 19;
            this.btnPreviousOrderItems.Text = "Previous";
            this.btnPreviousOrderItems.UseVisualStyleBackColor = true;
            this.btnPreviousOrderItems.Click += new System.EventHandler(this.btnPreviousOrderItems_Click);
            // 
            // btnNextOrderItems
            // 
            this.btnNextOrderItems.Location = new System.Drawing.Point(467, 400);
            this.btnNextOrderItems.Name = "btnNextOrderItems";
            this.btnNextOrderItems.Size = new System.Drawing.Size(75, 23);
            this.btnNextOrderItems.TabIndex = 20;
            this.btnNextOrderItems.Text = "Next";
            this.btnNextOrderItems.UseVisualStyleBackColor = true;
            this.btnNextOrderItems.Click += new System.EventHandler(this.btnNextOrderItems_Click);
            // 
            // btnLastOrderItems
            // 
            this.btnLastOrderItems.Location = new System.Drawing.Point(567, 400);
            this.btnLastOrderItems.Name = "btnLastOrderItems";
            this.btnLastOrderItems.Size = new System.Drawing.Size(75, 23);
            this.btnLastOrderItems.TabIndex = 21;
            this.btnLastOrderItems.Text = "Last";
            this.btnLastOrderItems.UseVisualStyleBackColor = true;
            this.btnLastOrderItems.Click += new System.EventHandler(this.btnLastOrderItems_Click);
            // 
            // btnDeleteOrderItems
            // 
            this.btnDeleteOrderItems.Location = new System.Drawing.Point(374, 443);
            this.btnDeleteOrderItems.Name = "btnDeleteOrderItems";
            this.btnDeleteOrderItems.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOrderItems.TabIndex = 22;
            this.btnDeleteOrderItems.Text = "Delete";
            this.btnDeleteOrderItems.UseVisualStyleBackColor = true;
            this.btnDeleteOrderItems.Click += new System.EventHandler(this.btnDeleteOrderItems_Click);
            // 
            // btnEditOrderItems
            // 
            this.btnEditOrderItems.Location = new System.Drawing.Point(467, 443);
            this.btnEditOrderItems.Name = "btnEditOrderItems";
            this.btnEditOrderItems.Size = new System.Drawing.Size(75, 23);
            this.btnEditOrderItems.TabIndex = 23;
            this.btnEditOrderItems.Text = "Edit";
            this.btnEditOrderItems.UseVisualStyleBackColor = true;
            // 
            // btnDetailsOrderItems
            // 
            this.btnDetailsOrderItems.Location = new System.Drawing.Point(564, 443);
            this.btnDetailsOrderItems.Name = "btnDetailsOrderItems";
            this.btnDetailsOrderItems.Size = new System.Drawing.Size(75, 23);
            this.btnDetailsOrderItems.TabIndex = 24;
            this.btnDetailsOrderItems.Text = "Details";
            this.btnDetailsOrderItems.UseVisualStyleBackColor = true;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 496);
            this.Controls.Add(this.btnDetailsOrderItems);
            this.Controls.Add(this.btnEditOrderItems);
            this.Controls.Add(this.btnDeleteOrderItems);
            this.Controls.Add(this.btnLastOrderItems);
            this.Controls.Add(this.btnNextOrderItems);
            this.Controls.Add(this.btnPreviousOrderItems);
            this.Controls.Add(this.btnFirstOrderItems);
            this.Controls.Add(this.gvOrderItems);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowEmployeesOrders);
            this.Controls.Add(this.btnShowProductsOrders);
            this.Controls.Add(this.btnDetailsOrders);
            this.Controls.Add(this.btnEditOrders);
            this.Controls.Add(this.btnDeleteOrders);
            this.Controls.Add(this.btnLastOrders);
            this.Controls.Add(this.btnNextOrders);
            this.Controls.Add(this.btnPreviousOrders);
            this.Controls.Add(this.btnFirstOrders);
            this.Controls.Add(this.txtSearchOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvOrders);
            this.Name = "FormOrders";
            this.Text = "Orders Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOrders_FormClosed);
            this.Load += new System.EventHandler(this.FormOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchOrders;
        private System.Windows.Forms.Button btnFirstOrders;
        private System.Windows.Forms.Button btnPreviousOrders;
        private System.Windows.Forms.Button btnNextOrders;
        private System.Windows.Forms.Button btnLastOrders;
        private System.Windows.Forms.Button btnDeleteOrders;
        private System.Windows.Forms.Button btnEditOrders;
        private System.Windows.Forms.Button btnDetailsOrders;
        private System.Windows.Forms.Button btnShowProductsOrders;
        private System.Windows.Forms.Button btnShowEmployeesOrders;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView gvOrderItems;
        private Button btnFirstOrderItems;
        private Button btnPreviousOrderItems;
        private Button btnNextOrderItems;
        private Button btnLastOrderItems;
        private Button btnDeleteOrderItems;
        private Button btnEditOrderItems;
        private Button btnDetailsOrderItems;
    }
}