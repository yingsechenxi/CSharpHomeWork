using System;
using System.Collections.Generic;
using System.Text;

namespace orderwork
{
    public class Order
    {
        public int id;
        public string name;
        public int number;
        public double money;
        public Order(int id, double money,string name,int number)
        {
            this.id = id;
            this.name = name;
            this.number = number;
            this.money = money;
        }
        public Order() { }
        public override bool Equals(object obj)
        {
            Order test = obj as Order;
            return test != null && test.id == id && test.name == name && test.number == number;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(id, name, number);
        }
        public override string ToString()
        {
            return "OrderID：" + id + " Money in all:" + money + " Item name:" + name + " Number in all:" + number ;
        }
    }
}
