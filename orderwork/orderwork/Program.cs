using System;
using System.Collections.Generic;
using System.Text;

namespace orderwork
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            bool working = true;
            int id = 0,number = 0;
            double money = 0;
            List<Order> orders = new List<Order>();
            while(working)
            {
                Console.WriteLine("请选择您希望使用的功能 1、添加订单 2、查询订单 3、删除订单 4、更改订单 5、显示现有订单 6、退出系统");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("请输入订单号，商品名，数量与金额！(请用空格分开各个信息)");
                        string[] info = Console.ReadLine().Split(" ");
                        if(info.Length<4)
                        {
                            Console.WriteLine("输入信息不全！请重新操作！");
                        }
                        else if(info.Length>4)
                        {
                            Console.WriteLine("输入信息过多！请重新操作！");
                        }
                        else
                        {
                            if (int.TryParse(info[0], out id) && double.TryParse(info[1], out money) && int.TryParse(info[3],out number))
                            {
                                service.AddOrder(id, money, info[2], number, orders);
                            }
                            else
                            {
                                Console.WriteLine("存在非法输入！请重新确认订单信息！");
                            }                            
                        }
                        break;
                    case "2":
                        Console.WriteLine("请选择您想查询的订单条件：1、订单号 2、金额 3、商品数量 4、商品名");
                        string condition = Console.ReadLine();
                        try
                        {
                            switch (condition)
                            {
                                case "1":
                                    Console.WriteLine("请输入订单号！");
                                    string searchid = Console.ReadLine();
                                    if (int.TryParse(searchid, out id))
                                    {
                                        service.SearchOrder(id, 0, "", 0, orders);
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("请输入金额！");
                                    string searchmoney = Console.ReadLine();
                                    if (double.TryParse(searchmoney, out money))
                                    {
                                        service.SearchOrder(0, money, "", 0, orders);
                                    }
                                    break;
                                case "3":
                                    Console.WriteLine("请输入商品数量！");
                                    string searchamount = Console.ReadLine();
                                    if (int.TryParse(searchamount, out number))
                                    {
                                        service.SearchOrder(0, 0, "", number, orders);
                                    }
                                    break;
                                case "4":
                                    Console.WriteLine("请输入商品名！");
                                    string searchname = Console.ReadLine();
                                    service.SearchOrder(0, 0, searchname, 0, orders);
                                    break;
                                default:
                                    Console.WriteLine("选择条件非法！请重新操作");
                                    break;
                            }
                        }catch (Exception e)
                        {
                            Console.WriteLine("发生错误！"+ e);
                        }
                        break;
                    case "3":
                        Console.WriteLine("请输入您想删除的订单号！可通过显示现有订单的功能查看现有订单号！");
                        string delid = Console.ReadLine();
                        if(int.TryParse(delid,out id))
                        {            
                            service.DeleteOrder(id,orders);
                        }
                        break;
                    case "4":
                        Console.WriteLine("请输入您想修改的订单号！可通过显示现有订单的功能查看现有订单号！");
                        string changeid = Console.ReadLine();
                        int changeid1;
                        if(int.TryParse(changeid,out changeid1))
                        {
                            Console.WriteLine("请输入您希望修改成的订单号，商品名，数量与金额！(请用空格分开各个信息)");
                            string[] newinfo = Console.ReadLine().Split(" ");
                            if (newinfo.Length < 4)
                            {
                                Console.WriteLine("输入信息不全！请重新操作！");
                            }
                            else if (newinfo.Length > 4)
                            {
                                Console.WriteLine("输入信息过多！请重新操作！");
                            }
                            else
                            {
                                if (int.TryParse(newinfo[0], out id) && double.TryParse(newinfo[1], out money) && int.TryParse(newinfo[3], out number))
                                {
                                    service.ChangeOrder(changeid1, orders,id, money, newinfo[2], number);
                                }
                                else
                                {
                                    Console.WriteLine("存在非法输入！请重新确认订单信息！");
                                }
                            }
                            
                        }
                        break;
                    case "5":
                        foreach (Order noworeder in orders)
                        {
                            Console.WriteLine(noworeder);
                        }
                        break;
                    case "6":
                        Console.WriteLine("确认退出吗？（输入1表示确认退出，0表示取消）");
                        string flag = Console.ReadLine();
                        if (flag == "1")
                        {
                            working = false;
                            break;
                        }
                        else if(flag == "0")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("输入非法！若要退出请重新执行退出操作！");
                            break;
                        }
                    default:
                        Console.WriteLine("输入非法！请重新确认您希望使用的功能！");
                        break;
                }
            }
        }
    }
}
