using System;
using System.Data.Entity;
using System.Linq;
using EFMountains.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFMountains.Tests
{
    [TestClass]
    public class RowVersionTests
    {
        [TestMethod]
        public void UpdateAnEntityTest()
        {
            var order = new Order()
            {
                Id = Guid.NewGuid(),
                Name = "Order created at " + DateTime.Now,
                CreatedBy = "root",
                CreatedAt = DateTime.Now
            };

            var context = new StoreDbContext();
            context.Orders.Add(order);

            context.SaveChanges();

            var orderSaved = context.Orders.First(x => x.Id == order.Id);
            orderSaved.Name = "Order updated at " + DateTime.Now;
            context.Entry(orderSaved).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
