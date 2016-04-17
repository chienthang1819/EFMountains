using System;
using System.Data.Entity;
using System.Linq;

namespace EFMountains
{
    class Program
    {
        static void Main(string[] args)
        {
            RetriveData();

            Console.WriteLine("Press enter key to exit");
            Console.ReadLine();
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
