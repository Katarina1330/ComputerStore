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
    public partial class FormEditOrder : Form
    {
        public FormEditOrder()
        {
            InitializeComponent();
        }

        public FormEditOrder(int idOrder)
        {
            InitializeComponent();
            this.idOrder = idOrder;
        }

        private int idOrder;
        private int idCustomer;

        private void FormEditOrder_Load(object sender, EventArgs e)
        {
            Order order = DataAccess.GetOrderById(idOrder);
            txtIdOrder.Text = Convert.ToString( order.IdOrder);
            txtIdOrder.ReadOnly = true;
            txtDateOrder.Text = Convert.ToString(order.DateOrder);
            txtDateOrder.ReadOnly = true;
            txtCashRegister.Text = Convert.ToString(order.CashRegister);
            txtCashRegister.ReadOnly = true;
            txtPriceOrder.Text = Convert.ToString(order.PriceOrder);
            txtDetails.Text = order.Details;
            txtNameCustomer.Text = order.CustomerName;
            idCustomer = order.IdCustomer;

            List<Employee> employees = DataAccess.ReadActiveEmployees();
            comboNameEmployee.DataSource = employees;
            comboNameEmployee.DisplayMember = "EmployeeName";
            comboNameEmployee.ValueMember = "IdEmployee";
            comboNameEmployee.Text = order.EmployeeName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Customer customer = new Customer();
                //customer.NameCustomer = txtNameCustomer.Text;
                //customer.IdCustomer = DataAccess.GetIdCustomer(customer);
                char[] separator = { ' ', ',' };
                string[] delovi = txtNameCustomer.Text.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                if(delovi.Length == 2)
                {
                    customer.LastNameCustomer = delovi[0];
                    customer.FirstNameCustomer = delovi[1];
                    customer.IdCustomer = idCustomer;
                    DataAccess.UpdateCustomer(customer);
                }
                else
                {
                    MessageBox.Show("Morate uneti ime, prez za customera.");
                }

                Employee employee = new Employee();
                employee.EmployeeName = comboNameEmployee.Text;
                employee.IdEmployee = DataAccess.GetIdEmployee(employee);

                Order order = new Order();
                order.IdOrder = Convert.ToInt32(txtIdOrder.Text);
                order.DateOrder = Convert.ToDateTime(txtDateOrder.Text);
                order.CashRegister = Convert.ToInt32(txtCashRegister.Text);
                order.PriceOrder = Convert.ToDecimal(txtPriceOrder.Text);
                order.Details = txtDetails.Text;
                order.CustomerName = txtNameCustomer.Text;
                order.IdEmployee = employee.IdEmployee;
                order.IdCustomer = customer.IdCustomer;

                DataAccess.EditOrder(order);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
