using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Project1
{   [Serializable]
    public class Order:IComparable
    {
        Random random = new Random();
        public double Order_ID { get; set; }//订单号
        public DateTime Order_date { get; set; }//下单日期
        public double Custormer_ID { get; set; }//顾客唯一识别ID
        public string Order_address { get; set; }//收货地址
        public string Order_custormet_Name { get; set; }//顾客姓名
        public double Order_total_consumption { get; set; }
        public List<OrderItem> Orderitem_list = new List<OrderItem>();

        public int CompareTo(object obj2)
        {
            Order order2 = obj2 as Order;
            if (order2 == null)
                throw new System.ArgumentException();
            return this.Order_ID.CompareTo(order2.Order_ID);
        }

        public double Generate_Order_ID()//随机生成十位数作为订单ID
        {
            double tmp=0;
            Random ran = new Random();
            for (int i = 0; i < 10; i++)
            {
                tmp += ran.Next(10)* Math.Pow(10,i);
                System.Threading.Thread.Sleep(15);
            }
            return tmp;
        }
        public Order() { }
        public Order(DateTime order_date, double custormer_ID, string order_address, string order_custormet_Name)
        {
            Order_date = order_date;
            Order_ID = Generate_Order_ID();//订单编号随机生成
            Custormer_ID = custormer_ID;
            Order_address = order_address;
            Order_custormet_Name = order_custormet_Name;
            Order_total_consumption = 0;//初始花销为0
        }

        public Order( double order_ID, DateTime order_date, double custormer_ID, string order_address, string order_custormet_Name)
        {
            Order_ID = order_ID;
            Order_date = order_date;
            Custormer_ID = custormer_ID;
            Order_address = order_address;
            Order_custormet_Name = order_custormet_Name;
            Order_total_consumption = 0;
          
        }

        public override bool Equals(object obj)
        {

            return obj is Order order &&
                  Order_ID == order.Order_ID ;//判断类型和订单号是否相同
        }



        public override string ToString()//输出Order信息
        {
            return "下单日期:" + Order_date + "\n" +
                "订单号:" + Order_ID + "\n" +
                "顾客ID:" + Custormer_ID + "\n" +
                "顾客姓名:" + Order_custormet_Name+"\n"+
            "收获地址:" + Order_address + "\n"+
            "订单总花费:"+Order_total_consumption+"元"+"\n";
        }
        public void Add_Item(OrderItem item)
        {
            try
            {
                if (!Orderitem_list.Contains(item)) 
                { 
                    Orderitem_list.Add(item);
                    Order_total_consumption += item.total_price;
                }
               
            }
            catch(Exception e)
            {
                throw new Exception("添加商品失败", e);
            }
        }
        public void Delete_Item(string name_of_item)
        {
            try
            {
                for (int i = 0; i < Orderitem_list.Count; i++)
                {
                    if (Orderitem_list[i].name_of_item == name_of_item)
                    {
                        Orderitem_list.Remove(Orderitem_list[i]);
                    }
                }
            }
            catch(Exception e)
            {
                throw new Exception("删除商品失败", e);
            }
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(random, Order_ID, Order_date, Custormer_ID, Order_address, Order_custormet_Name, Order_total_consumption, Orderitem_list);
        }
    }
    /*    -------------------                                ----------------------------------------------------------------------------------*/
   public class OrderItem
    {
        public string name_of_item;
        public int num_of_item;
        public double price_of_item;
        public double total_price;

        public OrderItem(string name_of_item, int num_of_item, double price_of_item)
        {
            this.name_of_item = name_of_item;
            this.num_of_item = num_of_item;
            this.price_of_item = price_of_item;
            this.total_price = price_of_item*num_of_item;
        }
        public OrderItem() { }

        public override bool Equals(object obj)
        {
            return obj is OrderItem item &&
                   name_of_item == item.name_of_item &&
                   num_of_item == item.num_of_item &&
                   price_of_item == item.price_of_item &&
                   total_price == item.total_price&&
                   obj!=null;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name_of_item, num_of_item, price_of_item, total_price);
        }

        public override string ToString()
        {
            return name_of_item + "\t" + price_of_item + "\t" + num_of_item + "\t" + total_price+"元"+"\n";
        }
    }
/*                     ------------------------------------------------------------------------------------------------------------------------*/


}
