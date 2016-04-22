namespace ComputerStore
{
    partial class FormDetailsProduct
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
            this.gvDetailsProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetailsProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDetailsProduct
            // 
            this.gvDetailsProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetailsProduct.Location = new System.Drawing.Point(12, 56);
            this.gvDetailsProduct.Name = "gvDetailsProduct";
            this.gvDetailsProduct.Size = new System.Drawing.Size(386, 150);
            this.gvDetailsProduct.TabIndex = 0;
            this.gvDetailsProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetailsProduct_CellContentClick);
            // 
            // FormDetailsProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.gvDetailsProduct);
            this.Name = "FormDetailsProduct";
            this.Text = "FormDetailsProduct";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDetailsProduct_FormClosed);
            this.Load += new System.EventHandler(this.FormDetailsProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDetailsProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDetailsProduct;
    }
}