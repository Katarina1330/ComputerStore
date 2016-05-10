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
    public partial class FormProductPage : Form
    {
        public FormProductPage()
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

        BindingSource bsProducts = new BindingSource();

        private void Product_Page_Load(object sender, EventArgs e)
        {
            ReadProductFromDb();
        }

        private void ReadProductFromDb(string opcioniParametar = null)
        {
            List<Product> products = null;
            if (opcioniParametar == null)
                products = DataAccess.ReadAllProduct(false);
            else
                products = DataAccess.ReadProductSearch(opcioniParametar);

            gvProduct.Columns.Clear();
            bsProducts.DataSource = products;
            gvProduct.DataSource = bsProducts;

            var colSelect = new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Select",
                Name = "Select",
                Width = 50,
                TrueValue = true,
                FalseValue = false
            };
            gvProduct.Columns.Add(colSelect);
            gvProduct.Columns["InStore"].Visible = false;
            gvProduct.Columns["MadeIn"].Visible = false;
            gvProduct.Columns["BuyFromCompany"].Visible = false;
            gvProduct.Columns["CellPhoneCompany"].Visible = false;
            gvProduct.Columns["PriceProduct"].DefaultCellStyle.Format = "N2";
            gvProduct.Columns["NameProduct"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gvProduct.Columns["PriceProduct"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void btnShowOrdersProduct_Click(object sender, EventArgs e)
        {
            if (FormOrders.CanCreateNewForm)
            {
                var frm = new FormOrders();
                frm.RoditeljskaForma = this;
                frm.ShowDialog();
            }
            else
            {
               var response = MessageBox.Show("Form Orders is already opened. Do you want to close this form?"
                   , "Form Orders", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(response == DialogResult.Yes)
                {
                    this.Close();
                    if (!(RoditeljskaForma is FormOrders))
                        RoditeljskaForma.Close();

                }
            }
        }

        private void btnShowEmployeesProduct_Click(object sender, EventArgs e)
        {
            //if(FormEmployees.CanCreateNewFormMethod())
            //{

            //}

            //if (FormEmployees.Counter == 0)
            if (FormEmployees.CanCreateNewForm)
            {
                // kreiranje nove Emp. forme
                var frm = new FormEmployees();
                frm.RoditeljskaForma = this;
                frm.ShowDialog();
            }
            else
            {
                // ne dozvoljavam novu formu
               var response = MessageBox.Show("Form Employees is already opened. Do you want to close this form?"
                   , "Form Employees", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(response == DialogResult.Yes)
                {
                    this.Close();
                    if (!(RoditeljskaForma is FormEmployees))
                        RoditeljskaForma.Close();
                }
            }
        }

        public Form RoditeljskaForma { get; set; }

        private void FormProductPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            counter--;
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            List<int> IDs = new List<int>();
            List<int> indexs = new List<int>();

            foreach (DataGridViewRow row in gvProduct.Rows)
            {
                DataGridViewCell selected = row.Cells["Select"];
                if (selected.Value != null && (bool)selected.Value == true)
                {
                    DataGridViewCell idCell = row.Cells["IdProduct"];
                    IDs.Add((int)idCell.Value);

                    int idIndex = row.Index;
                    indexs.Add(idIndex);
                }
            }

            DataAccess.ArchiveProducts(IDs);

            foreach (int idIndex in indexs.OrderByDescending(p => p).ToList())
            {
                gvProduct.Rows.RemoveAt(idIndex);
            }
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            new FormDetailsProduct().ShowDialog();

            List<Product> product = DataAccess.ReadAllProduct(false);
            bsProducts.DataSource = product;
            gvProduct.DataSource = bsProducts;
        }

        private void textSearchProduct_TextChanged(object sender, EventArgs e)
        {
            ReadProductFromDb(textSearchProduct.Text);
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
           if(gvProduct.CurrentRow != null)
            {
                Object obj = gvProduct.CurrentRow.DataBoundItem;
                Product product = (Product)obj;

                FormEditProduct frm = new FormEditProduct(product.IdProduct, product.NameProduct);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Morate odabrati neki proizvod.");
            }

            List<Product> product2 = DataAccess.ReadAllProduct(false);
            bsProducts.DataSource = product2;
            gvProduct.DataSource = bsProducts;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct frm = new FormAddProduct();
            frm.ShowDialog();

            List<Product> products = DataAccess.ReadAllProduct(false);
            bsProducts.DataSource = products;
            gvProduct.DataSource = bsProducts;
        }
    }
}
