using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace Project1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        OrderService testOrderService = new OrderService();
        OrderItem item = new OrderItem("电脑", 1, 10);
        Order testorder = new Order(1234567890, DateTime.Now, 12345657890, "江西萍乡", "TRF");
        Order testorder2 = new Order(2123456789, DateTime.Now, 2123456789, "江西萍乡", "TRF");
        [TestInitialize()]
        public void init()
        {
            testorder.Add_Item(item);
            testOrderService.Save_Order(testorder);
            testOrderService.Save_Order(testorder2);
        }
        [TestMethod()]
        public void DeleteOrderTest()
        {

            testOrderService.DeleteOrder(testorder.Order_ID);
            Assert.AreEqual(1, testOrderService.Order_list.Count);
        }

        [TestMethod()]
        public void ReviseOrderTest()
        {
            Order neworder = new Order(3223456789, DateTime.Now, 3223456789, "江西萍乡", "TRF");
            testOrderService.ReviseOrder(testorder2.Order_ID, neworder);
            CollectionAssert.Contains(testOrderService.Order_list, neworder);
        }

        [TestMethod()]
        public void Save_OrderTest()
        {
            Order order = new Order(4234567890, DateTime.Now, 4234567890, "JiangXi", "TRF");
            OrderItem item = new OrderItem("洗发水", 1, 10);
            order.Add_Item(item);
            testOrderService.Save_Order(order);
            CollectionAssert.Contains(testOrderService.Order_list, order);
        }

        [TestMethod()]
        public void SortOrderListTest()
        {
            testOrderService.SortOrderList();
            Assert.AreEqual(1234567890, testOrderService.Order_list[0].Order_ID);
        }

        [TestMethod()]
        public void Check_By_Order_custormet_NameTest()
        {
            Assert.AreEqual(0, testOrderService.Check_By_Order_custormet_Name("PXL").Count);
            Assert.AreEqual(2, testOrderService.Check_By_Order_custormet_Name("TRF").Count);
        }

        [TestMethod()]
        public void Check_By_Order_addressTest()
        {
            Assert.AreEqual(0, testOrderService.Check_By_Order_address("HuBei").Count);
            Assert.AreEqual(0, testOrderService.Check_By_Order_address("JiangXi").Count);
        }

        [TestMethod()]
        public void Check_By_Custormer_IDTest()
        {
            Assert.AreEqual(0, testOrderService.Check_By_Custormer_ID(4234567890).Count);

        }

        [TestMethod()]
        public void Check_By_Order_dateTest()
        {
            Assert.AreEqual(0, testOrderService.Check_By_Order_date(DateTime.Now).Count);
        }

        [TestMethod()]
        public void Check_By_name_of_itemTest()
        {
            Assert.AreEqual(0, testOrderService.Check_By_name_of_item("洗发水").Count);
            Assert.AreEqual(0, testOrderService.Check_By_name_of_item("洗衣机").Count);
            Assert.AreEqual(1, testOrderService.Check_By_name_of_item("电脑").Count);
        }

        [TestMethod()]
        public void ExportTest()
        {
            String file = "temp.xml";
            testOrderService.Export(file);
            Assert.IsTrue(File.Exists(file));
            List<String> expectLines = File.ReadLines("temp.xml").ToList();
            List<String> outputLines = File.ReadLines(file).ToList();
            Assert.AreEqual(expectLines.Count, outputLines.Count);
            for (int i = 0; i < expectLines.Count; i++)
            {
                Assert.AreEqual(expectLines[i].Trim(), outputLines[i].Trim());
            }
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService orderService = new OrderService();
            orderService.Import("temp.xml");
        }


    }
}