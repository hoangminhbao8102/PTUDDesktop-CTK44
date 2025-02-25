﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Entities
{
    public class Bill
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int TableId { get; set; }

        public int Amount { get; set; }

        public float Discount { get; set; }

        public float Tax { get; set; }

        public BillStatus Status { get; set; }

        public DateTime? CheckoutDate { get; set; }

        public string? Account { get; set; }

        public Table? Table { get; set; }

        public ICollection<BillDetail>? BillDetails { get; set; }
    }

    public enum BillStatus
    {
        Pending = 0,
        Billed = 1,
        Cancelled = 2
    }
}
