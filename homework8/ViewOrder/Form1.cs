using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using homework8;

namespace ViewOrder
{
    public partial class Form1 : Form
    {
        OrderService service = new OrderService();
        public int id = 0, number = 0;
        public double price = 0,oldprice = 0;
        public string name = "";
        public string client;
        public int clientID;
        public delegate void finishChange(string value);
        public event finishChange OnfinishChange;
        private string finish;
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));

        public string Finish
        {
            get { return finish; }
            set
            {
                finish = value;
                OnfinishChange(value);
                
            }
        }
        void Form1_changeEvent(string value)
        {             
            if(finish == "true")
            {
                service.AddOrder(id, oldprice + price* number, number,name,client,clientID);
                finish = "false";
                oldprice = price;
            }
            orderBindingSource.ResetBindings(false);
        }       
        public Form1()
        {
            InitializeComponent();
            service.AddOrder(2, 2, 4, "B","B",44);
            service.AddOrder(3, 3, 5, "A", "B", 44);
            orderBindingSource.DataSource = service.orders;
            orderBindingSource1.DataSource = service.orderItems;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = service.orders;
            AddForm addForm = new AddForm(this);
            addForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = service.orders;
            if (conditiontextBox.Text == "")
            {
                MessageBox.Show("请输入订单号！");
            }
            else
            {
                conditioncomboBox.Text = "订单号";
                if(int.TryParse(conditiontextBox.Text,out id))
                {
                    service.DeleteOrder(id, service.orders);
                }
                orderBindingSource.ResetBindings(false);
                MessageBox.Show("删除成功！");
            }
            
        }


        private void exportButton_Click(object sender, EventArgs e)
        {
            orderBindingSource.DataSource = service.orders;
            service.Export();
            MessageBox.Show("导出成功！");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (conditioncomboBox.Text)
                {
                    case "订单号":
                        if (int.TryParse(conditiontextBox.Text, out id))
                        {
                            Search(id, 0, "", 0, service.orders);
                        }
                        break;
                    case "金额":
                        if (double.TryParse(conditiontextBox.Text, out price))
                        {
                            Search(0, price, "", 0, service.orders);
                        }
                        break;
                    case "商品数量":
                        if (int.TryParse(conditiontextBox.Text, out number))
                        {
                            Search(0, 0, "", number, service.orders);
                        }
                        break;
                    case "商品名":
                        Search(0, 0, conditiontextBox.Text, 0, service.orders);
                        break;
                    default:
                        Console.WriteLine("选择条件非法！请重新操作");
                        break;
                }
                MessageBox.Show("查询结束！");
            }
            catch (Exception ie)
            {
                Console.WriteLine("发生错误！" + ie);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OnfinishChange += Form1_changeEvent;
        }

        private void Search(int id, double money, string name, int number, List<Order> orders)
        {
            if (id != 0)
            {
                var target = from o in orders where o.id == id select o;
                List<Order> result = target.ToList();
                orderBindingSource.DataSource = result;
            }
            else if (money != 0)
            {
                var target = from o in orders where o.money == money select o;
                List<Order> result = target.ToList();
                orderBindingSource.DataSource = result;
            }
            else if (number != 0)
            {
                var target = from o in orders where o.number == number orderby o.money descending select o;
                List<Order> result = target.ToList();
                orderBindingSource.DataSource = result;
            }
        }
        private void importButton_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("order.xml", FileMode.Open))
            {
                List<Order> orders1 = (List<Order>)xmlSerializer.Deserialize(fs);
                orderBindingSource.DataSource = orders1;
                service.orders = orders1;
            }            
            MessageBox.Show("导入成功！");
        }
    }
}
