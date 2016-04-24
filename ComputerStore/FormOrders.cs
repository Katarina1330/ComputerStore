﻿using System;
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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            counter++;
        }

        public FormOrders(int idEmployee, string nameEmployee)
        {
            InitializeComponent();
            counter++;
            this.idEmployee = idEmployee;
            this.Text =  "Form Orders" + nameEmployee;

            // Text += " for ... employee"
        }

        private int idEmployee = -1;

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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        BindingSource bsOrderItems = new BindingSource();
        BindingSource bsOrders = new BindingSource();

        private void FormOrders_Load(object sender, EventArgs e)
        {
            var orderItems = DataAccess.ReadAllOrderItems();

            bsOrderItems.DataSource = orderItems;
            gvOrderItems.DataSource = bsOrderItems;

            var colSelect = new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Select",
                Width = 50
            };
            gvOrderItems.Columns.Add(colSelect);
            gvOrderItems.Columns["IdOrder"].Visible = false;
            gvOrderItems.Columns["IdProduct"].Visible = false;
            gvOrderItems.Columns["IdOrderItem"].Visible = false;

            List<Order> orders;
            if (idEmployee == -1)
            {
                orders = DataAccess.readAllOrders(); // sve porudzbine
            }
            else
            {
                orders = DataAccess.readOrdersForEmployee(idEmployee); // por. za odabranog zap.
            }

            bsOrders.DataSource = orders;
            gvOrders.DataSource = bsOrders;
            bsOrders.CurrentChanged += BsOrders_CurrentChanged;
            BsOrders_CurrentChanged(this, EventArgs.Empty);

            var colSelect2 = new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Select",
                Width = 50
            };
            gvOrders.Columns.Add(colSelect2);
            gvOrders.Columns["IdEmployee"].Visible = false;
            gvOrders.Columns["IdCustomer"].Visible = false;
        }

        private void BsOrders_CurrentChanged(object sender, EventArgs e)
        {
            //* mogucnosti za ispitivanje (novog, nepoznatog) dogadjaja
            // MessageBox.Show("BsOrders_CurrentChanged");
            // Text += "/";

            // uzmem id porudzbine (orderId) za current (trenutnu) por.
            // var order = (Order)gvOrders.CurrentRow.DataBoundItem;
            var order = (Order)bsOrders.Current;
           // MessageBox.Show(order.IdOrder.ToString());


            List<OrderItem> orderItems = DataAccess.ReadOrderItemsForOneOrder(order.IdOrder);
            bsOrderItems.DataSource = orderItems;
            gvOrderItems.DataSource = bsOrderItems;
        }

        private void btnFirstOrderItems_Click(object sender, EventArgs e)
        {
            bsOrderItems.MoveFirst();
        }

        private void btnPreviousOrderItems_Click(object sender, EventArgs e)
        {
            bsOrderItems.MovePrevious();
        }

        private void btnNextOrderItems_Click(object sender, EventArgs e)
        {
            bsOrderItems.MoveNext();
        }

        private void btnLastOrderItems_Click(object sender, EventArgs e)
        {
            bsOrderItems.MoveLast();
        }

        private void btnDeleteOrderItems_Click(object sender, EventArgs e)
        {

        }

        private void gvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFirstOrders_Click(object sender, EventArgs e)
        {
            bsOrders.MoveFirst();
        }

        private void btnPreviousOrders_Click(object sender, EventArgs e)
        {
            bsOrders.MovePrevious();
        }

        private void btnNextOrders_Click(object sender, EventArgs e)
        {
            bsOrders.MoveNext();
        }

        private void btnLastOrders_Click(object sender, EventArgs e)
        {
            bsOrders.MoveLast();
        }

        private void btnShowProductsOrders_Click(object sender, EventArgs e)
        {
            if (FormProductPage.CanCreateNewForm)
            {
                var frm = new FormProductPage();
                frm.RoditeljskaForma = this;
                frm.ShowDialog();
            }

            else
            {
                var response = MessageBox.Show("Form Product is already opened. Do you want to close this form?"
                    , "Form Product Page", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (response == DialogResult.Yes)
                {
                    this.Close();
                    if (!(RoditeljskaForma is FormProductPage))
                        RoditeljskaForma.Close();
                }
            }
        }

        private void btnShowEmployeesOrders_Click(object sender, EventArgs e)
        {
            if (FormEmployees.CanCreateNewForm)
            {
                var frm = new FormEmployees();
                frm.RoditeljskaForma = this;
                frm.ShowDialog();
            }
            else
            {
                // MessageBox.Show("Form Employees is already opened.", "Kreiranje forme");
                //MessageBox.Show("Form Employees is already opened.", "Kreiranje forme"
                //    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                var response = MessageBox.Show("Form Employees is already opened. Do you want to close this form?"
                    , "Employees Form", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (response == DialogResult.Yes)
                {
                    this.Close();
                    if (!(RoditeljskaForma is FormEmployees))
                        RoditeljskaForma.Close();
                }
            }
        }

        public Form RoditeljskaForma { get; set; }

        private void FormOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            counter--;
        }

        private void gvOrders_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
