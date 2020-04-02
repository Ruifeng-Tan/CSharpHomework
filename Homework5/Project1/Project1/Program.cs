using System;
using System.Collections.Generic;
using System.IO;

namespace Project1
{

    class Program
    {
        static void Main(string[] args)
        {
            //鉴于本次作业重要在于考查基本类、集合类、Linq的运用
            //所以不设计基于控制台的复杂用户交互，这里只是测试各个类及相应函数的实现效果
            //创建一个用户，在用户看来，所有的操作都是他控制完成的
            Customer user1 = new Customer("Pingxiang JiangXI", "TRF");
            //用户买一个item
            user1.Add_Item("洗发水", 1, 10);
            user1.Add_Item("剃须刀", 1, 50);
            user1.Add_Item("洗面奶", 2, 40);
            //查看当前订单信息
            string order_info=user1.order.ToString();
            Console.WriteLine(order_info);
            //再输出相应的货物信息
            string Item_info;
            Console.WriteLine("商品名"+"\t"+"单价"+"\t"+"购买数量"+"\t"+"总价"+"\n");
            foreach(OrderItem item in user1.order.Orderitem_list)
            {
                Item_info = item.ToString();
                Console.WriteLine(Item_info);
            }
            //用户确认这一笔下单完成
            user1.Finish_Order();
            //User1来下一笔新的订单
            user1.Add_Item("笔记本", 3, 5);
            user1.Add_Item("Mac", 1, 5500);
            user1.Add_Item("鼠标", 1, 150);
            user1.Add_Item("键盘", 1, 800);
            //查看当前订单与相应货物信息
            //查看当前订单信息
           order_info = user1.order.ToString();
            Console.WriteLine(order_info);
            //再输出相应的货物信息
            Console.WriteLine("商品名" + "\t" + "单价" + "\t" + "购买数量" + "\t" + "总价" + "\n");
            foreach (OrderItem item in user1.order.Orderitem_list)
            {
                Item_info = item.ToString();
                Console.WriteLine(Item_info);
            }
            //用户确认这一笔下单完成
            user1.Finish_Order();
            /*--------------------------------接下来让我们来测试一下Linq查询吧----------------------------------------*/
            //清空一下当前的显示以免影响测试观看效果
            //Console.Clear();
            IEnumerable<Order> querys;
            //按下单时间查询
            Console.WriteLine("\n按下单时间进行查询：\n");
            querys = user1.Check_By_Order_date(DateTime.Now);
            foreach(Order order in querys)
            {
                Console.WriteLine(order.ToString());
                foreach(OrderItem orderItem in order.Orderitem_list)
                {
                    Console.WriteLine(orderItem.ToString());
                }
            }

            //按用户ID进行查询
            Console.WriteLine("\n按用户ID进行查询：\n");
            querys = user1.Check_By_Custormer_ID(user1.Custormer_ID);
            foreach (Order order in querys)
            {
                Console.WriteLine(order.ToString());
                foreach (OrderItem orderItem in order.Orderitem_list)
                {
                    Console.WriteLine(orderItem.ToString());
                }
            }
            //按收货地址进行查询
            Console.WriteLine("\n按收货地址进行查询：\n");
            querys = user1.Check_By_Order_address(user1.Order_address);
            foreach (Order order in querys)
            {
                Console.WriteLine(order.ToString());
                foreach (OrderItem orderItem in order.Orderitem_list)
                {
                    Console.WriteLine(orderItem.ToString());
                }
            }
            //按用户名进行查询
            Console.WriteLine("\n按用户名进行查询：\n");
            querys = user1.Check_By_Order_custormet_Name(user1.Order_custormet_Name);
            foreach (Order order in querys)
            {
                Console.WriteLine(order.ToString());
                foreach (OrderItem orderItem in order.Orderitem_list)
                {
                    Console.WriteLine(orderItem.ToString());
                }
            }
            //按是否包含特定货物进行查询
            Console.WriteLine("\n按货物进行查询：\n");
            string name_of_item = "洗发水";
            querys = user1.Check_By_name_of_item(name_of_item);
            foreach (Order order in querys)
            {
                Console.WriteLine(order.ToString());
                foreach (OrderItem orderItem in order.Orderitem_list)
                {
                    Console.WriteLine(orderItem.ToString());
                }
            }
            //将现在的所有订单编程xml格式输出
            user1.orderService.Export("Order");
            Console.WriteLine(File.ReadAllText("Order.xml"));
            user1.orderService.Import("Order");
            foreach(Order order in user1.orderService.Order_list)
            {
                Console.WriteLine(order.ToString());
            }
        }
    }
}
