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

        BindingSource bsEmployees = new BindingSource();

        private void FromEmployees_Load(object sender, EventArgs e)
        {
            ReadEmployeesFromDb();
           // gvEmployees.Rows[0].Selected = true;
        }

        private void ReadEmployeesFromDb()
        {
           // gvEmployees.Columns.Clear();
            var employees = DataAccess.ReadActiveEmployees();
           
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
            gvEmployees.Columns["IsActive"].Visible = false;
            gvEmployees.Columns["IdPerson"].Visible = false;
            gvEmployees.Columns["CellPhone"].Visible = false;
            gvEmployees.Columns["Address"].Visible = false;
            gvEmployees.Columns["City"].Visible = false;
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
            if (FormOrders.CanCreateNewForm)
            {                
                FormOrders frm = new FormOrders();
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
            if (gvEmployees.CurrentRow != null)
            {
                var obj = gvEmployees.CurrentRow.DataBoundItem;
                // var emp = obj as Employee;
                var emp = (Employee)obj;


                var frm = new FormOrders(emp.IdEmployee);
                frm.RoditeljskaForma = this;
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Morate odabrati nkog zaposlenog.");
            }
        }

        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            
            List<int> IDs = new List<int>(); // id-evi zaposlenih koji su selektovani
            List<int> indexs = new List<int>();
            foreach (DataGridViewRow row in gvEmployees.Rows)
            {
                DataGridViewCell selected = row.Cells["Select"];
                if (selected.Value != null && (bool)selected.Value == true) // da li je Select cekirano
                {  
                    // Console.WriteLine(row.Cells["Id"].Value);
                    DataGridViewCell idCells = row.Cells["IdEmployee"];
                    IDs.Add((int)(idCells.Value));

                    int idIndex = row.Index;
                    indexs.Add(idIndex);

                }
            }
            //B DataAccess.DeleteEmployees(IDs);

            // Update
            DataAccess.ArchiveEmployees(IDs);
            //// ponovo ucitaj aktivne zaposlene
            // List<Employee> employees = DataAccess.ReadActiveEmployees();
            // bsEmployees.DataSource = employees;
            // gvEmployees.DataSource = bsEmployees;

            // ReadEmployeesFromDb();

            foreach (int idIndex in indexs.OrderByDescending(p => p).ToList())
            {
                gvEmployees.Rows.RemoveAt(idIndex);
            }

        }

        private void btnDetailsEmployee_Click(object sender, EventArgs e)
        {
            new FormDetailsEmployee().ShowDialog();
        }

        private void btnCreateNewEmployee_Click(object sender, EventArgs e)
        {
            new FormNewEmployee().ShowDialog();
            // ucitam sve employees iz baze

            List<Employee> employees = DataAccess.ReadActiveEmployees();
            bsEmployees.DataSource = employees;
            gvEmployees.DataSource = bsEmployees;
        }
    }
}
