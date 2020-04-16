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
    public partial class ItemAddForm : Form
    {
        public OrderItem currentItem;
        public ItemAddForm()
        {
            InitializeComponent();
        }
        public ItemAddForm(OrderItem oi)
        {
            InitializeComponent();
            currentItem = oi;
        }
        private void ItemAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            currentItem.name_of_item = tbItemName.Text;
            currentItem.num_of_item =Convert.ToInt32(tbItemNum.Text);
            currentItem.price_of_item =Convert.ToDouble(tbItemPrice.Text);
            currentItem.total_price = currentItem.num_of_item * currentItem.price_of_item;//计算此商品的总价
            this.Close();
        }
    }
}
