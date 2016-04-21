namespace ComputerStore
{
    partial class FormDetailsEmployee
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
            this.gvDetailsEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetailsEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDetailsEmployee
            // 
            this.gvDetailsEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetailsEmployee.Location = new System.Drawing.Point(12, 52);
            this.gvDetailsEmployee.Name = "gvDetailsEmployee";
            this.gvDetailsEmployee.Size = new System.Drawing.Size(386, 150);
            this.gvDetailsEmployee.TabIndex = 0;
            this.gvDetailsEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetailsEmployee_CellContentClick);
            // 
            // FormDetailsEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.gvDetailsEmployee);
            this.Name = "FormDetailsEmployee";
            this.Text = "FormDetailsEmployee";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDetailsEmployee_FormClosed);
            this.Load += new System.EventHandler(this.FormDetailsEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetailsEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDetailsEmployee;
    }
}