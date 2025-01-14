﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal Weight { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        public Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
