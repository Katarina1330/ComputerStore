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
                    return true;
                else
                    return false;
            }

        }

        List<int> inStoreProductsIDs = new List<int>();

        private void FormDetailsProduct_Load(object sender, EventArgs e)
        {
            List<Product> products = DataAccess.ReadAllProduct(true);
            BindingSource bsDetailsProduct = new BindingSource();
            bsDetailsProduct.DataSource = products;
            gvDetailsProduct.DataSource = bsDetailsProduct;

            gvDetailsProduct.Columns["PriceProduct"].DefaultCellStyle.Format = "N2";

            foreach (Product product in products)
            {
                if (product.InStore == true)
                    inStoreProductsIDs.Add(product.IdProduct);
            }
            // lambda izrazi
            //inStoreProductsIDs = products.Where(p => p.InStore == true).Select(p => p.IdProduct).ToList();
        }

        private void FormDetailsProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            counter--;
        }

        private void btnInStoreOK_Click(object sender, EventArgs e)
        {
            List<int> newInStoreProductsIDs = new List<int>();
            foreach (DataGridViewRow row in gvDetailsProduct.Rows)
            {
                Product product = (Product)row.DataBoundItem;
                if (product != null && product.InStore == true
                    && inStoreProductsIDs.Contains(product.IdProduct) == false)
                    newInStoreProductsIDs.Add(product.IdProduct);
            }
            DataAccess.ProductInStore(newInStoreProductsIDs);
            this.Close();
            //List<int> IDs = new List<int>();
            //List<int> indexs = new List<int>();

            ////////////////////if (gvDetailsProduct.CurrentRow != null)
            ////////////////////{
            ////////////////////    Object obj = gvDetailsProduct.CurrentRow.DataBoundItem;
            ////////////////////    Product product = (Product)obj;
            ////////////////////    DataAccess.ProductInStore(product.IdProduct);
            ////////////////////}

            ////////////////////this.Close();

            //foreach (DataGridViewRow row in gvDetailsProduct.Rows)
            //{
            //    DataGridViewCell selectedCell = row.Cells["InStore"];
            //    if (selectedCell != null && (bool)selectedCell.Selected == true)
            //    {
            //        DataGridViewCell idCell = row.Cells["IdProduct"];
            //        IDs.Add((int)idCell.Value);


            //    }

            //}

            //DataAccess.ProductInStore(IDs);


        }



        // proci kroz sve redove data grid view-a
        // izdvojiti samo selektovane
        // Slican kod je u FormEmployees.cs, linija 175
        // isto pravi kolekciju (listu) ID-eva
        // List<int> IDs = new List<int>(); // id-evi proizvoda koji su selektovani
        // bazi saljes update upit ...set isActive = 1 where idProduct in ()
    }
}
