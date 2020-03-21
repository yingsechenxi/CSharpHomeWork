using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace orderwork
{
    class OrderService
    {
        int flag = 0;
        public void AddOrder(int id, double money, string name, int number,  List<Order> orders)
        {
            foreach (Order noworder in orders)
            {
                if (noworder.id==id)
                {
                    flag = 1;
                }
            }
            if(flag==1)
            {
                Console.WriteLine("该订单号已存在，请重新确认订单号");
                flag = 0;
            }
            else
            {
                orders.Add(new Order(id, money, name,number));
                Console.WriteLine("订单添加成功！");
            }

        }
        public void DeleteOrder(int id,List<Order>orders)
        {
            try
            {
                int a = 0;
                foreach (Order noworder in orders)
                {                    
                    if (noworder.id == id)
                    {
                        orders.Remove(noworder);
                        Console.WriteLine("删除成功！");
                        break;                        
                    }
                    a++;
                }
                if (a == orders.Count)
                {
                    Console.WriteLine("未找到该订单号，请重新确定订单号！");
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("删除失败！原因:" + e);
            }
        }
        public void ChangeOrder(int id, List<Order> orders, int newid, double money, string name, int number)
        {
            try
            {
                int i = 0;
                foreach (Order noworder in orders)
                {
                    if (noworder.id == id)
                    {
                        orders.Remove(noworder);                        
                        foreach (Order checkorder in orders)
                        {
                            if (checkorder.id == newid)
                            {
                                flag = 1;
                            }
                        }
                        if (flag == 1)
                        {
                            Console.WriteLine("该订单号已存在，请重新选择订单号");
                            orders.Insert(i, noworder);
                            flag = 0;
                        }
                        else
                        {
                            orders.Insert(i, new Order(newid, money, name, number));
                            Console.WriteLine("修改成功！"); 
                        }                                               
                        break;
                    }                   
                    i++;
                }
                if(i==orders.Count)
                {
                    Console.WriteLine("未找到该订单号，请重新确定订单号！");                    
                }
            }catch(Exception e)
            {
                Console.WriteLine("修改失败！原因：" + e);
            }
        }
        public void SearchOrder(int id,double money,string name,int number,List<Order> orders)
        {
            if (id != 0)
            {
                var target = from o in orders where o.id == id select o;
                List<Order> result = target.ToList();
                foreach (Order noworeder in result)
                {
                    Console.WriteLine(noworeder);
                }
            }
            else if(money!=0)
            {
                var target = from o in orders where o.money == money select o;
                List<Order> result = target.ToList();
                foreach (Order noworeder in result)
                {
                    Console.WriteLine(noworeder);
                }
            }
            else if(name!="")
            {
                var target = from o in orders where o.name == name orderby o.money descending select o;
                List<Order> result = target.ToList();
                foreach (Order noworeder in result)
                {
                    Console.WriteLine(noworeder);
                }
            }
            else if(number!=0)
            {
                var target = from o in orders where o.number == number orderby o.money descending select o;
                List<Order> result = target.ToList();
                foreach (Order noworeder in result)
                {
                    Console.WriteLine(noworeder);
                }
            }
        }
    }
}
