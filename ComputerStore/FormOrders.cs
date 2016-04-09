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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
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



            var orders = DataAccess.readAllOrders();
            bsOrders.DataSource = orders;
            gvOrders.DataSource = bsOrders;

            var colSelect2 = new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Select",
                Width = 50
            };
            gvOrders.Columns.Add(colSelect2);
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
    }
}
