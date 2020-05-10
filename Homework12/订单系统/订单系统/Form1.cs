using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            totalorderService.OrderServiceID = 1;
            //由于本订单系统只有一个OrderService，所以直接指定ID
            //每次重新打开软件时应该调出数据库中已经保存的Orders
            DBinit();
            QueryAll();
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
            if (form.ShowDialog() == DialogResult.OK)
            {
                totalorderService.DeleteOrder(form.delOrder.Order_ID);
                using(var db = new OrdersContext())
                {
                    var delOrder = db.Orders.Include("Orderitem_list").FirstOrDefault(o => o.Order_ID == form.delOrder.Order_ID);
                    if (delOrder != null)
                    {
                        db.Orders.Remove(delOrder);
                        db.SaveChanges();
                    }
                }
                QueryAll();
            }
        }

        private void ReviseOrderbtn_Click(object sender, EventArgs e)
        {
            order = OrderbindingSource.Current as Order;//将OrderbingdingSource中当前选中的对象解包成Order
            if(order == null)
            {
                MessageBox.Show("请选中一个订单");
            }
            else
            {
                Form2 form2 = new Form2(totalorderService, order, true);
                if(form2.ShowDialog() == DialogResult.OK)
                {
                    totalorderService.DeleteOrder(order.Order_ID);
                    if (totalorderService.Save_Order(form2.CurrentOrder))
                    {
                        QueryAll();
                    }
                }
            }
        }

        private void AddOrderbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(totalorderService,order);
            if (form2.ShowDialog() == DialogResult.OK)
            {
               if(totalorderService.Save_Order(form2.CurrentOrder))
                {
                    QueryAll();
                }
               else
                {
                    MessageBox.Show("不可创建重复订单");
                    using(var context = new OrdersContext())
                    {
                        var tmporder = context.Orders.Include("Orderitem_list").FirstOrDefault(o => o.Order_ID == form2.CurrentOrder.Order_ID);
                        if (tmporder != null)
                        {
                            context.Orders.Remove(tmporder);
                            context.SaveChanges();
                        }
                    }
                }
            }

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

        private void gvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void QuertAllbtn_Click(object sender, EventArgs e)
        {
            QueryAll();
        }

        private void Querybtn_Click(object sender, EventArgs e)
        {
            List<Order> tmpOrderList = new List<Order>();
            string condition = cmbQuertyCondition.Text;
            string str = tbQuertStr.Text;
            switch (condition)
            {
                case "按用户名查询":
                    tmpOrderList = totalorderService.Check_By_Order_custormet_Name(str);
                    break;
                case "按商品名查询":
                    tmpOrderList = totalorderService.Check_By_name_of_item(str);
                    break;
                case "按订单日期查询":
                    tmpOrderList = totalorderService.Check_By_Order_date(Convert.ToDateTime(str));
                    break;
                default:
                    MessageBox.Show("请选择一项查询条件");
                    break;
            }
            OrderbindingSource.DataSource = tmpOrderList;
            OrderbindingSource.ResetBindings(false);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = saveFileDialog1.FileName;
                totalorderService.Export(fileName);
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                String fileName = openFileDialog1.FileName;
                totalorderService.Import(fileName);
                QueryAll();
            }
        }

        private void DBinit()
        {
            using (var context = new OrdersContext())
            {
                var query = context.Orders.Include("Orderitem_list").Where(o => o.OrderServiceID == 1).OrderBy(o => o.Order_total_consumption);
                foreach (var order in query)
                {
                    totalorderService.Order_list.Add(order);
                }
            }
        }
    }
}
