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
    public partial class FormDetailsEmployee : Form
    {
        public FormDetailsEmployee()
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


        private void gvDetailsEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormDetailsEmployee_Load(object sender, EventArgs e)
        {
            List<Employee> employees = DataAccess.ReadAllEmployes();
            BindingSource bsDetailsEmployee = new BindingSource();
            bsDetailsEmployee.DataSource = employees;
            gvDetailsEmployee.DataSource = bsDetailsEmployee;

            gvDetailsEmployee.Columns["IdTitle"].Visible = false;
            gvDetailsEmployee.Columns["EmployeeName"].Visible = false;
        }

        private void FormDetailsEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            counter--;
        }
    }
}
