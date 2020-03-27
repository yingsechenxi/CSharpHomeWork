using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using orderwork;
using System.IO;
using System.Xml.Serialization;

namespace OrderTest
{
    [TestClass()]
    public class OrderTests
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
        OrderService orderservice = new OrderService();
        List<Order> orders = new List<Order>();
        [TestMethod()]
        public void AddOrderTest()
        {
            orderservice.AddOrder(1, 2, "3", 4, orders);
            Order order = new Order(1, 2, "3", 4);
            Assert.AreEqual(orders[1], order);
        }
        [TestMethod()]
        public void DeleteOrderTest()
        {
            orderservice.AddOrder(1, 2, "3", 4, orders);
            orderservice.DeleteOrder(1, orders);
            orderservice.orders[0].Equals(null);
        }
        [TestMethod()]
        public void ChangeOrderTest()
        {
            orderservice.AddOrder(1, 2, "3", 4, orders);
            orderservice.ChangeOrder(1, orders, 2, 3, "4", 5);
            orders[0].Equals(new Order(2, 3, "4", 5));
        }
        [TestMethod()]
        public void SearchOrderTest()
        {
            orderservice.AddOrder(1, 2, "3", 4, orders);
            orderservice.SearchOrder(1,0,"",0,orders);

        }
        [TestMethod()]
        public void ExportTest()
        {
            orderservice.AddOrder(1, 2, "3", 4, orderservice.orders);
            orderservice.Export();
            using (FileStream fs = new FileStream("order.xml", FileMode.Open))
            {
                List<Order> orders1 = (List<Order>)xmlSerializer.Deserialize(fs);
                orderservice.orders[0].Equals(orders1);                
            }           
        }
        [TestMethod()]
        public void ImportTest()
        {
            orderservice.AddOrder(1, 2, "3", 4, orderservice.orders);
            orderservice.Export();
            orderservice.Import();
            using (FileStream fs = new FileStream("order.xml", FileMode.Open))
            {
                List<Order> orders1 = (List<Order>)xmlSerializer.Deserialize(fs);
                orderservice.orders[0].Equals(orders1);
            }          
        }
    }
}