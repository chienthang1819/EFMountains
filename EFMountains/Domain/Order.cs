using System;
using System.Collections.Generic;

namespace EFMountains.Domain
{
    public class Order
    {
        public Order()
        {
            Items = new List<OrderItem>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public IList<OrderItem> Items { get; set; }
    }
}