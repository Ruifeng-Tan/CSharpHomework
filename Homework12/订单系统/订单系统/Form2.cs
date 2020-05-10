using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
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
        public Order CurrentOrder { get; set; }
        
        public bool editmode;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(OrderService os,Order o,bool Editmode=false)
        {
            InitializeComponent();
            orderService = os;
            CurrentOrder = o;//获得传进来的Order
            CurrentOrder.Order_total_consumption = 0;
            orderbindingSource.DataSource = CurrentOrder;
            editmode = Editmode;
            if (Editmode == true)
            {
                 tbOrderID.Text = Convert.ToString(CurrentOrder.Order_ID);
                 tbOrderID.Enabled = false;
            }
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
            //订单每增加一个就应该存到currentorder的items列表中，方便到时候存进数据库
           if(CurrentOrder.Add_Item(itemAddForm.currentItem))
            {
                if (editmode == true)
                {
                    using(var db = new OrdersContext())
                    {
                        var neworderitem = itemAddForm.currentItem;
                        neworderitem.Order_ID = CurrentOrder.Order_ID;
                        db.Entry(neworderitem).State = EntityState.Added;
                        db.SaveChanges();
                    }
                }
                orderbindingSource.DataSource = CurrentOrder;//更新绑定信息，使界面立即显示信息
                orderbindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("添加商品明细失败");
            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CurrentOrder.Order_custormet_Name = cmbCustomerName.Text;
            using (var db = new OrdersContext())
            {

                if (editmode == false) {
                    //不是修改模式，说明是添加新订单
                    //先保存订单再保存下属orderItem
                    //这样外键引用才有效
                    CurrentOrder.Order_date = DateTime.Now;
                    CurrentOrder.Order_ID = Convert.ToInt32(tbOrderID.Text);
                    CurrentOrder.OrderServiceID = 1;
                    var order = CurrentOrder;
                    db.Entry(order).State = EntityState.Added;
                    for (int i = 0; i < CurrentOrder.Orderitem_list.Count; i++)
                    {
                        CurrentOrder.Orderitem_list[i].Order_ID = CurrentOrder.Order_ID;
                        OrderItem tmpOrderItem = CurrentOrder.Orderitem_list[i];
                        db.Entry(tmpOrderItem).State = EntityState.Added;
                    }
                db.SaveChanges(); 
                }
            }
            this.Close();

        }

        private void btnReviseItem_Click(object sender, EventArgs e)
        {
    

        }

        private void btnDelItem_Click(object sender, EventArgs e)
        {
            OrderItem orderItem = orderitemlistBindingSource.Current as OrderItem;
            //从当前订单中删除选择的item
            if (orderItem == null)
            {
                MessageBox.Show("请选择一个订单项进行删除");
                return;
            }
            if (CurrentOrder.Delete_Item(orderItem.name_of_item))
            {
                using(var db = new OrdersContext())
                {
                    var delItem = db.OrderItems.FirstOrDefault(oi => oi.Order_ID == CurrentOrder.Order_ID && oi.name_of_item == orderItem.name_of_item);
                    if(delItem != null)
                    {
                        db.OrderItems.Remove(delItem);
                        db.SaveChanges();
                    }
                }
            }
            orderbindingSource.DataSource = CurrentOrder;
            orderitemlistBindingSource.ResetBindings(false);
        }
    }
  }

