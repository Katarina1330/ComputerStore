using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerStore
{
    public class Product
    {
        public bool InStore { get; set; }

        public int IdProduct { get; set; }
        public string NameProduct { get; set; }
        public decimal PriceProduct { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }

        public string MadeIn { get; set; }
        public string BuyFromCompany { get; set; }
        public string CellPhoneCompany { get; set; }

    }
}
