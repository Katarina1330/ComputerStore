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
    public partial class FormAddOrder : Form
    {
        public FormAddOrder()
        {
            InitializeComponent();

            txtQuantity.Hide();
            // cmbProduct.Hide();
            cmbProduct.Visible = false;
        }

        Order order = new Order();
        int counterBtnSaveProduct = 0;
        int counterBtnCancel = 0;
        int IdOrder;
        decimal priceOrder;


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                btnSaveProduct.Enabled = false;
                int customerId;
                Customer customer = new Customer();
                //txtNameCustomer.Text;  primer: Pera Peric 12345
                char[] separatori = { ' ', ',' };
                string[] delovi = txtNameCustomer.Text.Split(separatori, StringSplitOptions.RemoveEmptyEntries);
                if (delovi.Length == 3)
                {
                    customer.FirstNameCustomer = delovi[0];
                    customer.LastNameCustomer = delovi[1];
                    customer.ID = delovi[2];
                    customerId = DataAccess.InsertCustomer(customer);
                    if (customerId == -1)
                    {
                        MessageBox.Show("Unos customera nije uspeo.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Morate uneti ime, prez i id za customera.");
                    return; // ne izvrsavamo ostatak ovog metoda jer nemamo id customera
                }

                order.DateOrder = dateTimePickerDateOrder.Value;
                order.CashRegister = Convert.ToInt32((string)cmbCashRegister.SelectedItem);
                order.IdEmployee = (int)cmbNameEmployee.SelectedValue;
                order.Details = txtDetails.Text;
                //... prepoznavanje customera na osnovu imena i prez
                order.IdCustomer = customerId;
                order.PriceOrder = priceOrder;
                IdOrder = DataAccess.InsertOrder(order);
                btnSave.Enabled = false;
                btnSaveProduct.Enabled = true;
                // txtQuantity.Show();
                txtQuantity.Visible = true;
                cmbProduct.Show();
                txtPriceOrder.Text = "0.00";
                counterBtnCancel = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private void FormAddOrder_Load(object sender, EventArgs e)
        {
            List<Employee> employees = DataAccess.ReadActiveEmployees();

            cmbNameEmployee.DataSource = employees;
            cmbNameEmployee.DisplayMember = "EmployeeName";
            cmbNameEmployee.ValueMember = "IdEmployee";
            cmbNameEmployee.SelectedItem = null;
            cmbNameEmployee.Text = "Izaberi sa liste";

            List<Product> products = DataAccess.ReadAllProduct(false);

            cmbProduct.DataSource = products;
            cmbProduct.DisplayMember = "NameProduct";
            cmbProduct.ValueMember = "IdProduct";
            cmbProduct.SelectedItem = null;
            cmbProduct.Text = "Izaberi sa liste";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            counterBtnCancel++;
            if (counterBtnCancel == 1)
            {
                cmbCashRegister.Text = string.Empty;
                cmbNameEmployee.Text = string.Empty;
                txtDetails.Text = string.Empty;
                txtNameCustomer.Text = string.Empty;
                txtPriceOrder.Text = string.Empty;
                txtQuantity.Text = string.Empty;
                cmbProduct.Text = string.Empty;
                btnSave.Enabled = true;
                btnSaveProduct.Enabled = false;
            }
            else
            {
                this.Close();
            }

        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                counterBtnSaveProduct++;

                OrderItem orderItem = new OrderItem();
                orderItem.IdProduct = (int)cmbProduct.SelectedValue;
                orderItem.Quantity = Convert.ToInt32(txtQuantity.Text);
                Product product = (Product)cmbProduct.SelectedItem;
                orderItem.OrderItemPrice = product.PriceProduct * orderItem.Quantity;

                orderItem.IdOrder = IdOrder;
                DataAccess.InsertOrderItem(orderItem);

                priceOrder = Convert.ToDecimal(txtPriceOrder.Text);
                priceOrder += orderItem.OrderItemPrice;
                txtPriceOrder.Text = priceOrder.ToString("0.##");

                DataAccess.UpdateOrderPrice(IdOrder, priceOrder);

                txtQuantity.Text = string.Empty;
                cmbProduct.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private void cmbNameEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
