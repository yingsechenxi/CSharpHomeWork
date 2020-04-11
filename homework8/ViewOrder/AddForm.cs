using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewOrder
{
    public partial class AddForm : Form
    {
        private Form1 form1;
        public AddForm(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }
        int id, number,cid;
        double price;
        private void confirmButton_Click(object sender, EventArgs e)
        {
            if(idTextBox.Text == "" && numberTextBox.Text == "" && priceTextBox.Text == "" && nameTextBox.Text == "" && cnameTextBox.Text == "" && cidTextBox.Text == "")
            {
                MessageBox.Show("输入信息不全！请重新确认", "提示");
            }
            else if(int.TryParse(idTextBox.Text,out id) && double.TryParse(priceTextBox.Text,out price) && int.TryParse(numberTextBox.Text,out number) && int.TryParse(cidTextBox.Text,out cid))
            {

                form1.id = id;
                form1.price = price;
                form1.number = number;
                form1.name = nameTextBox.Text;
                form1.clientID = cid;
                form1.client = cnameTextBox.Text;
                form1.Finish = "true";
                if (MessageBox.Show("添加订单成功！请问是否还要在该订单号下增加细项？", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    idTextBox.ReadOnly = true;
                    cidTextBox.ReadOnly = true;
                    cnameTextBox.ReadOnly = true;
                    priceTextBox.Text = "";
                    numberTextBox.Text = "";
                    nameTextBox.Text = "";
                }
                else
                {
                    this.Close();
                }
                
            }
        }
    }
}
