using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 订单系统
{
    class OrdersContext : DbContext 
    {
        public OrdersContext() : base("OrdersDB")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrdersContext>());
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderService> OrderServices { get; set; }
    }
}
