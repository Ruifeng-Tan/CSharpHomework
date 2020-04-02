using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Project1
{
    class Customer
    {
         
        public double Custormer_ID;//顾客唯一识别ID
        public string Order_address;//收货地址
        public string Order_custormet_Name;//顾客姓名
        public Order order;
        public OrderService orderService=new OrderService();//每个客户都有专属于自己订单的订单服务，因为订单服务中保存了不同客户的不同订单
        public double Generate_Custormer_ID()
        {
            double tmp = 0;
            Random ran = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                tmp += ran.Next(10) * Math.Pow(10, i);
                Thread.Sleep(15);
            }
            return tmp;
        }//随机产生customer_ID
        public Customer(string Order_address,string Order_custormet_Name)
        {
            this.Order_address = Order_address;
            this.Order_custormet_Name = Order_custormet_Name;
            this.Custormer_ID = Generate_Custormer_ID();
            Create_NewOrder();
        }
        public void Create_NewOrder()//创建订单
        {
            DateTime Order_date = DateTime.Now;
            order = new Order(Order_date, Custormer_ID, Order_address, Order_custormet_Name);
        }
        public void Add_Item(string name_of_item, int num_of_item, double price_of_item)//讲商品加入订单
        {
            OrderItem item = new OrderItem(name_of_item, num_of_item, price_of_item);//生成一个新Item
            order.Add_Item(item);//将商品加入订单
        }
        public void Delete_Item(string name_of_item)
        {
            order.Delete_Item(name_of_item);
            //使用Order类的函数删除商品
        }

        public void Finish_Order()//完成下单
        {
            while (!orderService.Save_Order(this.order))
            {
                this.order.Order_ID = this.order.Generate_Order_ID();
            }//将用户当前订单保存，如果订单ID重复则生成新的ID，直到不重复为止
            Create_NewOrder();//旧订单已经保存上交，现在创建一个全新的订单让用户再下单
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   Custormer_ID == customer.Custormer_ID &&
                   Order_address == customer.Order_address &&
                   Order_custormet_Name == customer.Order_custormet_Name &&
                   EqualityComparer<Order>.Default.Equals(order, customer.order) &&
                   EqualityComparer<OrderService>.Default.Equals(orderService, customer.orderService);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Custormer_ID, Order_address, Order_custormet_Name, order, orderService);
        }

        public override string ToString()
        {
            return "用户名:" + Order_custormet_Name +"\n"+ "用户ID:" + Custormer_ID + "\n" + "收获地址:" + Order_address+"\n";
        }
        //用户实现Linq查询
        public IEnumerable<Order> Check_By_Order_date(DateTime Order_date)
        {
            return orderService.Check_By_Order_date(Order_date);
        }
        public IEnumerable<Order> Check_By_Custormer_ID(double Custormer_ID)
        {
            return orderService.Check_By_Custormer_ID(Custormer_ID);
        }
        public IEnumerable<Order> Check_By_Order_address(String Order_address)
        {
            return orderService.Check_By_Order_address(Order_address);
        }
        public IEnumerable<Order> Check_By_Order_custormet_Name(String Order_custormet_Name)
        {
            return orderService.Check_By_Order_custormet_Name(Order_custormet_Name);
        }
        public IEnumerable<Order> Check_By_name_of_item(string name_of_item)
        {
            return orderService.Check_By_name_of_item(name_of_item);
        }
    }
}
