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
    public partial class FormDetailsProduct : Form
    {
        public FormDetailsProduct()
        {
            InitializeComponent();
            counter++;
        }

        private static int counter = 0;

        public static bool CanCreateNewForm
        {
            get
            {
                if (counter == 0)
                    return  true;
                else
                    return  false;
            }

        }

        private void gvDetailsProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDetailsProduct_Load(object sender, EventArgs e)
        {
            List<Product> products = DataAccess.ReadAllProduct(true);
            BindingSource bsDetailsProduct = new BindingSource();
            bsDetailsProduct.DataSource = products;
            gvDetailsProduct.DataSource = bsDetailsProduct;
        }

        private void FormDetailsProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            counter--;
        }
    }
}
