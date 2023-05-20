using System;

﻿using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace store
{
    public class Sale
    {
       public DateTime DateTime { get; set; }

       public List<SaleItem> Items { get; set; }

       public decimal TotalAmount { get; set; }

       public decimal Profit { get; set; }

      public Sale()

    {

        DateTime = DateTime.Now;

        Items = new List<SaleItem>();

        TotalAmount = 0;

        Profit = 0;

    }
    }
}
