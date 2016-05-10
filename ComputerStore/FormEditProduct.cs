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
    public partial class FormEditProduct : Form
    {
        public FormEditProduct()
        {
            InitializeComponent();
        }

        public FormEditProduct(int idProduct, string nameProduct)
        {
            InitializeComponent();
            this.idProduct = idProduct;
            this.Text = "FormEditProduct" + '-' + nameProduct;
        }

         private int idProduct;

        private void FormEditProduct_Load(object sender, EventArgs e)
        {
            Product product = DataAccess.GetProductById(idProduct);

            txtIdProduct.Text = Convert.ToString(product.IdProduct);
            txtIdProduct.ReadOnly = true;
            txtNameProduct.Text = product.NameProduct;
            txtNameProduct.ReadOnly = true;
            txtPriceProduct.Text = Convert.ToString(product.PriceProduct);
            txtDescription.Text = product.Description;
            txtBrand.Text = product.Brand;
            txtMadeIn.Text = product.MadeIn;
            txtBuyFromCompany.Text = product.BuyFromCompany;
            txtCellPhoneCompany.Text = product.CellPhoneCompany;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.IdProduct = Convert.ToInt32( txtIdProduct.Text);
            product.NameProduct = txtNameProduct.Text;
            product.PriceProduct = Convert.ToDecimal(txtPriceProduct.Text);
            product.Description = txtDescription.Text;
            product.Brand = txtBrand.Text;
            product.MadeIn = txtMadeIn.Text;
            product.BuyFromCompany = txtBuyFromCompany.Text;
            product.CellPhoneCompany = txtCellPhoneCompany.Text;

            DataAccess.EditProduct(product);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
