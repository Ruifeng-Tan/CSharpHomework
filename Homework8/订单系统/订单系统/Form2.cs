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
    public partial class Form2 : Form
    {
        public OrderService orderService { get; set; }
        public Order currentOrder { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(OrderService os)
        {
            InitializeComponent();
            orderService = os;
        }
        public Form2(OrderService os,Order o)
        {
            InitializeComponent();
            orderService = os;
            currentOrder = o;
            currentOrder.Order_total_consumption = 0;
        }
        private void AddOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Order_IDlbl_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {   if (!cmbCustomerName.Items.Contains(tbCustomerName.Text))
            {
                cmbCustomerName.Items.Add(tbCustomerName.Text);//向comobox中添加创建的用户姓名
            }
        else
            {
                MessageBox.Show("需要添加的用户名已经存在");
            }
        }

        private void btnDelCustomerName_Click(object sender, EventArgs e)
        {
            if (cmbCustomerName.Items.Contains(tbCustomerName.Text))
            {
                int index = cmbCustomerName.Items.IndexOf(tbCustomerName.Text);
                cmbCustomerName.Items.RemoveAt(index);
                for(int i=0;i<orderService.Order_list.Count;i++)
                {
                    if (orderService.Order_list[i].Order_custormet_Name == tbCustomerName.Text)
                    {
                        orderService.Order_list.RemoveAt(i);//删除所有该用户下的订单
                    }
                }
            }
            else
            {
                MessageBox.Show("需要删除的用户名不存在");
            }
        }

        private void tbOrderID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = new OrderItem();
            ItemAddForm itemAddForm = new ItemAddForm(orderItem);
            itemAddForm.ShowDialog();
            currentOrder.Add_Item(itemAddForm.currentItem);
           
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            currentOrder.Order_custormet_Name = cmbCustomerName.Text;
            currentOrder.Order_ID = Convert.ToDouble(tbOrderID.Text);
            currentOrder.Order_date = DateTime.Now;
            this.Close();

        }
    }
}
