using System;
using System.Collections.Generic;
using System.Text;

namespace homework8
{
    class Client
    {
        public string name;
        public int id;
        public Client(string name,int id)
        {
            this.name = name;
            this.id = id;
        }
        public override string ToString()
        {
            return "ClientID：" + id + " Client name:" + name;
        }
    }
}
