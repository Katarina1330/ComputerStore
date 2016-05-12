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
    public partial class FormEditOrderItem : Form
    {
        public FormEditOrderItem()
        {
            InitializeComponent();
        }

        public FormEditOrderItem(int idOrderItem)
        {
            InitializeComponent();

            this.idOrderItem = idOrderItem;
        }

        private int idOrderItem;

        private void FormEditOrderItem_Load(object sender, EventArgs e)
        {
            OrderItem orderItem = DataAccess.GetOrderItemById(idOrderItem);

            txtQuantity.Text = Convert.ToString(orderItem.Quantity);
            txtOrderItemPrice.Text = Convert.ToString(orderItem.OrderItemPrice);

            List<Product> products = DataAccess.ReadAllProduct(false);
            comboProductName.DataSource = products;
            comboProductName.DisplayMember = "NameProduct";
            comboProductName.ValueMember = "IdProduct";
            comboProductName.Text = orderItem.NameProduct;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.NameProduct = comboProductName.Text;
            product.IdProduct = DataAccess.GetIdProduct(product);

            OrderItem orderItem = new OrderItem();
            orderItem.Quantity = Convert.ToInt32(txtQuantity.Text);
            orderItem.OrderItemPrice = Convert.ToDecimal(txtOrderItemPrice.Text);
            orderItem.IdOrderItem = idOrderItem;
            orderItem.IdProduct = product.IdProduct;

            DataAccess.EditOrderItem(orderItem);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
