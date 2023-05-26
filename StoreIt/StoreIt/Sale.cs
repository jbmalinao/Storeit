using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreIt
{
    public class Sale
    {
        public DateTime DateTime { get; set; }
        public List<SaleItem> Items { get; set; }
        public decimal TotalAmount { get; set; }

    public Sale()

    {

        DateTime = DateTime.Now;
        Items = new List<SaleItem>();
        TotalAmount = 0;
    }
}
}
