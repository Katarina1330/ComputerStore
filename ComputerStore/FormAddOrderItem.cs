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
    public partial class FormAddOrderItem : Form
    {
        public FormAddOrderItem()
        {
            InitializeComponent();
        }

        public FormAddOrderItem(int idOrder)
        {
            InitializeComponent();
            this.idOrder = idOrder;
        }

        private int idOrder;

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.NameProduct = comboProductName.Text;
            product.IdProduct = DataAccess.GetIdProduct(product);


            OrderItem orderItem = new OrderItem();
            orderItem.Quantity = Convert.ToInt32(txtQuantity.Text);
            orderItem.OrderItemPrice = Convert.ToDecimal(comboOrderItemPrice.Text);
            orderItem.IdProduct = product.IdProduct;
            orderItem.IdOrder = idOrder;

            orderItem.IdOrderItem = DataAccess.InsertOrderItem(orderItem);

            Order order = DataAccess.GetOrderById(idOrder);
            decimal newPriceOrder;
            newPriceOrder = order.PriceOrder + orderItem.OrderItemPrice;
            order.PriceOrder = newPriceOrder;

            DataAccess.UpdateOrderPrice(order.IdOrder, newPriceOrder);
            //Order order2 = DataAccess.GetOrderById(order.IdOrder);
            //order2.PriceOrder = newPriceOrder;
            //order2.IdOrder = DataAccess.InsertOrder(order2);

            this.Close();

            
        }

        private void FormAddOrderItem_Load(object sender, EventArgs e)
        {
           List<Product> products = DataAccess.ReadAllProduct(false);
            comboProductName.DataSource = products;
            comboProductName.DisplayMember = "NameProduct";
            comboProductName.ValueMember = "IdProduct";
            comboProductName.Text = " ";

            comboOrderItemPrice.DataSource = products;
            comboOrderItemPrice.DisplayMember = "PriceProduct";
            comboOrderItemPrice.ValueMember = "IdProduct";
            comboOrderItemPrice.Text = " ";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
