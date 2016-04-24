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
            this.gvDetailsProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvDetailsProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDetailsProduct.Location = new System.Drawing.Point(12, 24);
            this.gvDetailsProduct.Name = "gvDetailsProduct";
            this.gvDetailsProduct.Size = new System.Drawing.Size(459, 219);
            this.gvDetailsProduct.TabIndex = 0;
            this.gvDetailsProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvDetailsProduct_CellContentClick);
            // 
            // FormDetailsProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 284);
            this.Controls.Add(this.gvDetailsProduct);
            this.MinimumSize = new System.Drawing.Size(400, 300);
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