using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public class OrderItem
    {
        public int IdOrderItem { set; get; }
        public int IdOrder { set; get; }
        public int IdProduct { set; get; }
        public int Quantity { set; get; }
        public decimal OrderItemPrice { set; get; }
    }
}
