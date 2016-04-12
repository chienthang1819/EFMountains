using System;
using System.ComponentModel.DataAnnotations;

namespace EFMountains.Domain
{
    public class OrderItem
    {
        public OrderItem()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        [Range(0, float.MaxValue)]
        public float Price { get; set; }

        [Required]
        [Range(0, 10)]
        public int Amount { get; set; }
    }
}