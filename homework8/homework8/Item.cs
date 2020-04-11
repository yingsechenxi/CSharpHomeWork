using System;
using System.Collections.Generic;
using System.Text;

namespace homework8
{
    class Item
    {
        public string name;
        public int money;
        public override string ToString()
        {
            return " Money :" + money + " Item name:" + name;
        }
    }
}
