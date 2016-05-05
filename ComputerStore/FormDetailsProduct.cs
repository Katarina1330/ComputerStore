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

        private void FormDetailsProduct_Load(object sender, EventArgs e)
        {
            List<Product> products = DataAccess.ReadAllProduct(true);
            BindingSource bsDetailsProduct = new BindingSource();
            bsDetailsProduct.DataSource = products;
            gvDetailsProduct.DataSource = bsDetailsProduct;

            gvDetailsProduct.Columns["PriceProduct"].DefaultCellStyle.Format = "N2";
        }

        private void FormDetailsProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            counter--;
        }

        // proci kroz sve redove data grid view-a
        // izdvojiti samo selektovane
        // Slican kod je u FormEmployees.cs, linija 175
        // isto pravi kolekciju (listu) ID-eva
        // List<int> IDs = new List<int>(); // id-evi proizvoda koji su selektovani
        // bazi saljes update upit ...set isActive = 1 where idProduct in ()
    }
}
