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
    public partial class ProductPage : Form
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        BindingSource bsProducts = new BindingSource();

        private void Product_Page_Load(object sender, EventArgs e)
        {
            var products = DataAccess.ReadAllProduct();
            bsProducts.DataSource = products;
            gvProduct.DataSource = bsProducts;

            var colSelect = new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Select",
                Width = 50
            };
            gvProduct.Columns.Add(colSelect);
        }

        private void btnFirstProduct_Click(object sender, EventArgs e)
        {
            bsProducts.MoveFirst();
        }

        private void btnPreviousProduct_Click(object sender, EventArgs e)
        {
            bsProducts.MovePrevious();
        }

        private void btnNextProduct_Click(object sender, EventArgs e)
        {
            bsProducts.MoveNext();
        }

        private void btnLastProduct_Click(object sender, EventArgs e)
        {
            bsProducts.MoveLast();
        }
    }
}
