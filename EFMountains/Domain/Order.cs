using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFMountains.Domain
{
    public class Order
    {
        public Order()
        {
            Items = new List<OrderItem>();
            DeliverTo = new Contact();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [MaxLength(250)]
        public string CreatedBy { get; set; }

        public DateTime CreatedAt { get; set; }

        public Contact DeliverTo { get; set; }

        public IList<OrderItem> Items { get; set; }
    }
}