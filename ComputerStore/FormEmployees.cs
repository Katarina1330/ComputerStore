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
    public partial class FormEmployees : Form
    {
        public FormEmployees()
        {
            InitializeComponent();
            counter++;
            //MessageBox.Show("Broj formi: " + counter);
        }

        private static int counter = 0;
        public static int Counter
        {
            get { return counter; }
        }

        public static bool CanCreateNewForm
        {
            // get { return counter == 0; }
            get
            {
                if (counter == 0)
                    return true;
                else
                    return false;
            }
        }

        //public static bool CanCreateNewFormMethod()
        //{
        //    if (counter == 0)
        //        return true;
        //    else
        //        return false;
        //}

        BindingSource bsEmployees = new BindingSource();

        private void FromEmployees_Load(object sender, EventArgs e)
        {
            var employees = DataAccess.ReadAllEmployees();

            //var list = new BindingList<Employee>(employees);
            //gvEmployees.DataSource = list;
            // list.Add(new Employee() { Id = 123, FirstName = "mica" });

            bsEmployees.DataSource = employees;
            // bsEmployees.Filter = "FirstName = 'Pera'";
            // bsEmployees.Sort = "LastName";
            gvEmployees.DataSource = bsEmployees;

            var colSelect = new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Select",
                Width = 50
            };
            gvEmployees.Columns.Add(colSelect);

        }

        private void btnFirstEmployee_Click(object sender, EventArgs e)
        {
            bsEmployees.MoveFirst();
        }

        private void btnNextEmployee_Click(object sender, EventArgs e)
        {
            bsEmployees.MoveNext();
        }

        private void btnLastEmployee_Click(object sender, EventArgs e)
        {
            bsEmployees.MoveLast();
        }

        private void btnPreviousEmployee_Click(object sender, EventArgs e)
        {
            bsEmployees.MovePrevious();
        }

        private void btnShowOrdersEmployee_Click(object sender, EventArgs e)
        {
            // new FormOrders().ShowDialog();
            if (FormOrders.CanCreateNewForm)
            {

                var frm = new FormOrders();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Form Orders is already opened.");
            }
        }

        private void btnShowProductsEmployee_Click(object sender, EventArgs e)
        {
            if (FormProductPage.CanCreateNewForm)
            {
                var frm = new FormProductPage();
                frm.ShowDialog();
             }
            else
            {
                MessageBox.Show("Form Products is already opened.");
            }
        }
    }
}
