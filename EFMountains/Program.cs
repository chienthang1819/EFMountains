using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using EFMountains.Domain;

namespace EFMountains
{
    class Program
    {
        static void Main(string[] args)
        {
            BuildSampleData();
            RetriveData();

            Console.ReadLine();
        }

        static void BuildSampleData()
        {
            using (var context = new StoreDbContext())
            {
                var order1 = new Order()
                    {
                        Id = Guid.Parse("59400C52-5C2C-4332-9715-022A4D0B2EE3"),
                        Name = "Order 1",
                        CreatedAt = DateTime.Now,
                        CreatedBy = "root@system"
                    };
                order1.Items.Add(new OrderItem()
                    {
                        Name = "Product 1",
                        Amount = 10,
                        Price = 2
                    });
                order1.Items.Add(new OrderItem()
                    {
                        Name = "Product 2",
                        Amount = 2,
                        Price = 5
                    });

                var order2 = new Order()
                {
                    Id = Guid.Parse("B77C1F3E-A2B6-44DF-A2F0-2FFC4A7DD348"),
                    Name = "Order 2",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "root@system"
                };
                order2.Items.Add(new OrderItem()
                {
                    Name = "Product 3",
                    Amount = 1,
                    Price = 20
                });
                order2.Items.Add(new OrderItem()
                {
                    Name = "Product 2",
                    Amount = 2,
                    Price = 5
                });

                var order3 = new Order()
                {
                    Id = Guid.Parse("B77C1F3E-A2B6-44DF-A2F0-2FFC4A7DD349"),
                    Name = "Order 2",
                    CreatedAt = DateTime.Now,
                    CreatedBy = "root@system"
                };
                order3.Items.Add(new OrderItem()
                    {
                        Name = "Product 3",
                        Price = 10,
                        Amount = 2
                    });

                context.Orders.AddOrUpdate(order1);
                context.Orders.AddOrUpdate(order2);
                context.Orders.AddOrUpdate(order3);

                context.SaveChanges();
            }
        }

        static void RetriveData()
        {
            using (var context = new StoreDbContext())
            {
                foreach (var order in context.Orders.Include(x => x.Items).ToList())
                {
                    Console.WriteLine(order.Name + " created at " + order.CreatedAt);
                    Console.WriteLine("Items: " + order.Items.Count);
                    foreach (var item in order.Items)
                    {
                        Console.WriteLine("\t" + item.Name + ", Amount = " + item.Amount);
                    }
                    Console.WriteLine("--------------");
                }
            }
        }
    }
}
