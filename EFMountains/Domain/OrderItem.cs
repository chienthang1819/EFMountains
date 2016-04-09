using System;

namespace EFMountains.Domain
{
    public class OrderItem
    {
        public OrderItem()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public float Price { get; set; }

        public int Amount { get; set; }
    }
}