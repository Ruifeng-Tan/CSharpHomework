using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 订单系统
{
    public partial class OrderDelForm : Form
    {
        public Order delOrder = new Order();
        public OrderDelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delOrder.Order_ID = Convert.ToDouble(tbOrderID.Text);
            this.Close();
        }
    }
}
