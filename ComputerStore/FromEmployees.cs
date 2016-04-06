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
    public partial class FromEmployees : Form
    {
        public FromEmployees()
        {
            InitializeComponent();
        }

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
    }
}
