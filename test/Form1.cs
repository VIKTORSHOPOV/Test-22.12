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

namespace test
{
    public partial class Form1 : Form
    {
        static int br = 0;
        Order[] orders = new Order[100];
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 100; i++)
            {
                orders[i] = new Order();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Orders.txt"))
            {
                using (StreamReader sr = new StreamReader(@"Orders.txt"))
                {
                    richTextBox1.Text = sr.ReadToEnd();
                }
            }
            else
            {
                richTextBox1.Text = "File Missing";
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"Orders.txt"))
            {
                File.Delete(@"Orders.txt");
            }
            using (StreamWriter sw = new StreamWriter(@"Orders.txt"))
            {
                string result = string.Empty;
                for (int i = 0; i < orders.Length; i++)
                {
                    sw.WriteLine(orders[i].ShowInfo());
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order
            {
                OrderNumber = txtNumber.Text,
                RecieverName = txtName.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                PriceProduct = double.Parse(txtPriceOrder.Text),
                PayMethod = int.Parse(txtPay.Text),
                PriceShipping = double.Parse(txtPriceShipping.Text)

            };
            orders[br] = newOrder;
            br++;
        }
    }
}
