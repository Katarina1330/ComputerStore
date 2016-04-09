using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public class Orders
    {
        public int IdOrder { get; set; }
        public DateTime DateOrder { get; set; }
        public int CashRegister { get; set; }
        public decimal PriceOrder { get; set; }
        public int IdEmployee { get; set; }
        public string Details { get; set; }
        public int IdCustomer { get; set; }
        
    }
}
