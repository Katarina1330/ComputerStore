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
    public partial class FormEditEmployee : Form
    {
        public FormEditEmployee()
        {
            InitializeComponent();
        }

       // (Employee emp)
        public FormEditEmployee(int idEmployee, string nameEmployee)
        {
            InitializeComponent();
            this.idEmployee = idEmployee;
            this.Text = "Form Employee" + nameEmployee;
           // this.emp = emp;
        }

        // private Employee emp;

        private int idEmployee;

        private void FormEditEmployee_Load(object sender, EventArgs e)
        {
            Employee employee = DataAccess.GetEmployeeById(idEmployee);

            txtIdEmployee.Text = Convert.ToString(employee.IdEmployee);
            txtLastNameEdit.Text = employee.LastName;
            txtFirstNameEdit.Text = employee.firstName;
           
            txtIDPersonEdit.Text = employee.IdPerson;
            txtCellPhoneEdit.Text = employee.CellPhone;
            txtAddressEdit.Text = employee.Address;
            txtCityEdit.Text = employee.City;


            List<Title> titleName = DataAccess.ReadAllTitle();
            comboBoxTitleName.DataSource = titleName;
            comboBoxTitleName.DisplayMember = "TitleName";
            comboBoxTitleName.ValueMember = "IdTitle";
            comboBoxTitleName.Text = employee.TitleName;
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            try
            {
               
                Title title = new Title();
                title.TitleName = comboBoxTitleName.Text;
                title.IdTitle = DataAccess.GetIdTitle(title);

                Employee employee = new Employee();
                employee.IdEmployee = Convert.ToInt32(txtIdEmployee.Text);
                employee.LastName = txtLastNameEdit.Text;
                employee.firstName = txtFirstNameEdit.Text;
                //employee.TitleName = comboBoxTitleName.Text;
                employee.IdPerson = txtIDPersonEdit.Text;
                employee.CellPhone = txtCellPhoneEdit.Text;
                employee.Address = txtAddressEdit.Text;
                employee.City = txtCityEdit.Text;
                //employee.TitleName = titleName;
                employee.IdTitle = title.IdTitle;


                DataAccess.EditEmployee(employee);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }

        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
