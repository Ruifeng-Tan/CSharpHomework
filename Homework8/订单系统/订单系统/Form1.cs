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
    public partial class Form1 : Form
    {
        public Order order = new Order();
        public OrderService totalorderService = new OrderService();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderDelForm form = new OrderDelForm();
            form.Show();
            totalorderService.DeleteOrder(form.delOrder.Order_ID);
            QueryAll();
        }

        private void ReviseOrderbtn_Click(object sender, EventArgs e)
        {

        }

        private void AddOrderbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(totalorderService,order);
            form2.ShowDialog();
          
            totalorderService.Save_Order(form2.currentOrder);
            QueryAll();
            
        }
        private void QueryAll()
        {
            OrderbindingSource.DataSource = totalorderService.Order_list;
            OrderbindingSource.ResetBindings(false);

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gvItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
