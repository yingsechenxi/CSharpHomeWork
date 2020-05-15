using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp {

  /**
   * The service class to manage orders
   * */
  public class OrderService {

    public OrderService() {
    }

    public static List<Order> GetAllOrders() {
      using (var db = new OrderContext()) {
        return AllOrders(db).ToList();
      }
    }

    public static Order GetOrder(string id) {
      using (var db = new OrderContext()) {
        return AllOrders(db).FirstOrDefault(o => o.Id == id);
      }
    }
        private List<Order> orders;

        //增加订单
        public void AddOrder(Order order)
        {
            orders.Add(order);
            using (var context = new OrderContext())
            {
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }

        //删除订单
        public void RemoveOrder(string ID)
        {
            var order1 = SearchByID(ID);
            orders.Remove(order1);
            using (var context = new OrderContext())
            {
                context.Orders.Remove(order1);
                context.SaveChanges();
            }
        }

        public void UpdateOrder(Order newOrder)
        {
            Order oldOrder = orders.Where(o => o.Id == newOrder.Id).FirstOrDefault();
            orders.Remove(oldOrder);

            orders.Add(newOrder);

            using (var context = new OrderContext())
            {
                var order = context.Orders.Include(o => o.OrderItems).

                    FirstOrDefault(o => o.Id == newOrder.Id);

                if (order != null)
                {
                    context.Orders.Remove(order);
                    context.Orders.Add(newOrder);
                    context.SaveChanges();
                }

            }
        }

        public Order SearchByID(string ID)
        {
            using (var context = new OrderContext())
            {
                var orders = context.Orders.SingleOrDefault(o => o.Id == ID);
                return orders;
            }
        }
        
        //通过客户名搜索
        static public HashSet<Order> SearchByClient(string Client)
        {
            using (var context = new OrderContext())
            {
                var query = context.Orders.Include("OrderItem").Where(o => o.CustomerName == Client);

                return new HashSet<Order>(query);
            }

        }

        //通过商品名搜索
        public List<Order> SearchByProduct(string Product)
        {
            var query = orders.Where(order => order.OrderItems.Exists(item => item.GoodsName == Product));
            return query.ToList();
        }

        /*public static Order AddOrder(Order order) {
          try {
            using (var db = new OrderContext()) {
              db.Orders.Add(order);
              db.SaveChanges();
            }
            return order;
          }
          catch (Exception e) {
            //TODO 需要更加错误类型返回不同错误信息
            throw new ApplicationException($"添加错误: {e.Message}");
          }
        }

        public static void RemoveOrder(string id) {
          try {
            using (var db = new OrderContext()) {
              var order = db.Orders.Include("Items").Where(o => o.Id == id).FirstOrDefault();
              db.Orders.Remove(order);
              db.SaveChanges();
            }
          }
          catch (Exception e) {
            //TODO 需要更加错误类型返回不同错误信息
            throw new ApplicationException($"删除订单错误!");
          }
        }

        public static void UpdateOrder(Order newOrder) {
          RemoveItems(newOrder.Id);
          using (var db = new OrderContext()) {
            db.Entry(newOrder).State = EntityState.Modified;
            db.OrderItems.AddRange(newOrder.Items);
            db.SaveChanges();
          }
        }

        private static void RemoveItems(string orderId) {
          using (var db = new OrderContext()) {
            var oldItems = db.OrderItems.Where(item => item.OrderId == orderId);
            db.OrderItems.RemoveRange(oldItems);
            db.SaveChanges();
          }
        }*/

        public static List<Order> QueryOrdersByGoodsName(string goodsName) {
      using (var db = new OrderContext()) {
        var query = AllOrders(db)
          .Where(o => o.Items.Count(i => i.GoodsItem.Name == goodsName) > 0);
        return query.ToList();
      }
    }

    public static List<Order> QueryOrdersByCustomerName(string customerName) {
      using (var db = new OrderContext()) {
        var query = AllOrders(db)
          .Where(o => o.Customer.Name == customerName);
        return query.ToList();
      }
    }

    public static object QueryByTotalAmount(float amout) {
      using (var db = new OrderContext()) {
        return AllOrders(db)
          .Where(o => o.Items.Sum(item => item.GoodsItem.Price * item.Quantity) > amout)
          .ToList();
      }
    }

    private static IQueryable<Order> AllOrders(OrderContext db) {
      return db.Orders.Include(o => o.Items.Select(i => i.GoodsItem))
                .Include("Customer");
    }

    /*public static void Export(String fileName) {
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
        xs.Serialize(fs, GetAllOrders());
      }
    }

    public static void Import(string path) {
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(path, FileMode.Open)) {
        List<Order> temp = (List<Order>)xs.Deserialize(fs);
        temp.ForEach(order => {
          try {
            AddOrder(order);
          }catch {
            //ignore errors
          }
        });
      }*/
    }




 }

