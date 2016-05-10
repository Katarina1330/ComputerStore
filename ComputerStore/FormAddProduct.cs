using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerStore
{
    public partial class FormAddProduct : Form
    {
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.NameProduct = txtNameProduct.Text;
            product.PriceProduct = Convert.ToDecimal(txtPriceProduct.Text);
            product.Description = txtDescription.Text;
            product.Brand = txtBrand.Text;
            product.MadeIn = txtMadeIn.Text;
            product.BuyFromCompany = txtBuyFromCompany.Text;
            product.CellPhoneCompany = txtCellPhoneCompany.Text;

            DataAccess.InsertProduct(product);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
