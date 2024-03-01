﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Weight { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; } = new List<OrderDetail>();
    }
}
