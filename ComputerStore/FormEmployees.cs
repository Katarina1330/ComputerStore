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
            ReadEmployeesFromDb();
        }

        private void ReadEmployeesFromDb()
        {
            gvEmployees.Columns.Clear();
            var employees = DataAccess.ReadActiveEmployees();
            //foreach (var emp in employees)
            //{
            //}
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
                Name = "Select",
                Width = 50,
                TrueValue = true,
                FalseValue = false
            };
            gvEmployees.Columns.Add(colSelect);
            gvEmployees.Columns["IdTitle"].Visible = false;
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
                frm.RoditeljskaForma = this;
                frm.ShowDialog();
               // Console.Write("");
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

        private void btnShowProductsEmployee_Click(object sender, EventArgs e)
        {
            if (FormProductPage.CanCreateNewForm)
            {
                var frm = new FormProductPage();
                frm.RoditeljskaForma = this;
                frm.ShowDialog();
             }
            else
            {
               var response = MessageBox.Show("Form Products is already opened. Do you want to close this form?"
                   ,"Form Product Page", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(response == DialogResult.Yes)
                {
                    this.Close();
                    if (!(RoditeljskaForma is FormProductPage))
                        RoditeljskaForma.Close();
                }
            }
        }

        public Form RoditeljskaForma { get; set; }

        private void FormEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            counter--;
        }

        private void MenuItemEmployeesOrders_Click(object sender, EventArgs e)
        {
            var obj = gvEmployees.CurrentRow.DataBoundItem;
            // var emp = obj as Employee;
            var emp = (Employee)obj;
           
           
            var frm = new FormOrders(emp.Id);
            frm.RoditeljskaForma = this;
            frm.ShowDialog();
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            //var clms = gvEmployees.Columns;
            //gvEmployees.Rows[0]
            List<int> IDs = new List<int>(); // id-evi zaposlenih koji su selektovani
            foreach (DataGridViewRow row in gvEmployees.Rows)
            {
                DataGridViewCell selected = row.Cells["Select"];
                if (selected.Value != null && (bool)selected.Value == true) // da li je Select cekirano
                {  
                    // Console.WriteLine(row.Cells["Id"].Value);
                    DataGridViewCell idCell = row.Cells["Id"];
                    IDs.Add((int)idCell.Value);
                }
            }
            //B DataAccess.DeleteEmployees(IDs);
            
            DataAccess.ArchiveEmployees(IDs);
            //// ponovo ucitaj sve zaposlene
            //List<Employee> employees = DataAccess.ReadAllEmployees();
            //bsEmployees.DataSource = employees;
            //gvEmployees.DataSource = bsEmployees;

            ReadEmployeesFromDb();
        }
    }
}
