using System;
using System.Collections.Generic;
using System.Text;

namespace homework8
{
    public class OrderItem
    {
        public int id;       
        public double money;
        public string name;
        public int number;
        public string client;
        public int clientID;
        public OrderItem(int id, double money, string name, int number,string client,int clientID)
        {
            this.id = id;
            this.name = name;
            this.money = money;
            this.number = number;
            this.client = client;
            this.clientID = clientID;
        }
        public override bool Equals(object obj)
        {
            var item = obj as OrderItem;
            return item != null &&
                   id == item.id &&
                   money == item.money &&
                   name == item.name &&
                   number == item.number &&
                   client == item.client &&
                   clientID == item.clientID;
        }

        public override int GetHashCode()
        {
            var hashCode = -1101375658;
            hashCode = hashCode * -1521134295 + id.GetHashCode();
            hashCode = hashCode * -1521134295 + money.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + number.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(client);
            hashCode = hashCode * -1521134295 + clientID.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return "OrderID：" + id + " Money in all:" + money + " Item name:" + name + " Number in all:" + number + " Ordered by :" + client + "Client's ID is:" + clientID;
        }
    }
}
