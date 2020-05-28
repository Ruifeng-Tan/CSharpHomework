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
            //自定创建数据库
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderService> OrderServices { get; set; }
        //自动创建相应的表，只需要在泛型中指定相对应的类，表名可自定义
    }
}
