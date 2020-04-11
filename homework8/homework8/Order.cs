using System;
using System.Collections.Generic;
using System.Text;

namespace homework8
{
    public class Order
    {
        public int id { get; set; }
        public int number { get; set; }
        public double money { get; set; }
        public Order(int id, double money,int number)
        {
            this.id = id;
            this.number = number;
            this.money = money;
        }
        public Order() { }
        public override bool Equals(object obj)
        {
            Order test = obj as Order;
            return test != null && test.id == id  && test.number == number;
        }

        public override string ToString()
        {
            return "OrderID：" + id + " Money in all:" + money + " Number in all:" + number ;
        }

        public override int GetHashCode()
        {
            var hashCode = -1230746091;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + number.GetHashCode();
            hashCode = hashCode * -1521134295 + money.GetHashCode();
            return hashCode;
        }
    }
}
