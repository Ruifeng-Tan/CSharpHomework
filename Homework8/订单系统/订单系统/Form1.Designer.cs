namespace 订单系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Orderpanel = new System.Windows.Forms.Panel();
            this.gvOrder = new System.Windows.Forms.DataGridView();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordercustormetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordertotalconsumptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.QuertAllbtn = new System.Windows.Forms.Button();
            this.tbQuertStr = new System.Windows.Forms.TextBox();
            this.Querybtn = new System.Windows.Forms.Button();
            this.cmbQuertyCondition = new System.Windows.Forms.ComboBox();
            this.ReviseOrderbtn = new System.Windows.Forms.Button();
            this.DeleteOrderbtn = new System.Windows.Forms.Button();
            this.AddOrderbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gvItems = new System.Windows.Forms.DataGridView();
            this.nameofitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numofitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceofitemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderitemlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Orderpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemlistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Orderpanel
            // 
            this.Orderpanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Orderpanel.Controls.Add(this.gvOrder);
            this.Orderpanel.Location = new System.Drawing.Point(9, 12);
            this.Orderpanel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.Orderpanel.Name = "Orderpanel";
            this.Orderpanel.Padding = new System.Windows.Forms.Padding(2);
            this.Orderpanel.Size = new System.Drawing.Size(761, 222);
            this.Orderpanel.TabIndex = 0;
            // 
            // gvOrder
            // 
            this.gvOrder.AutoGenerateColumns = false;
            this.gvOrder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderIDDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn,
            this.ordercustormetNameDataGridViewTextBoxColumn,
            this.ordertotalconsumptionDataGridViewTextBoxColumn});
            this.gvOrder.DataSource = this.OrderbindingSource;
            this.gvOrder.Location = new System.Drawing.Point(2, 2);
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.RowHeadersWidth = 51;
            this.gvOrder.RowTemplate.Height = 27;
            this.gvOrder.Size = new System.Drawing.Size(751, 223);
            this.gvOrder.TabIndex = 0;
            this.gvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "Order_ID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "订单号";
            this.orderIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            this.orderIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "Order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "订单日期";
            this.orderdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            this.orderdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.orderdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordercustormetNameDataGridViewTextBoxColumn
            // 
            this.ordercustormetNameDataGridViewTextBoxColumn.DataPropertyName = "Order_custormet_Name";
            this.ordercustormetNameDataGridViewTextBoxColumn.HeaderText = "用户名";
            this.ordercustormetNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordercustormetNameDataGridViewTextBoxColumn.Name = "ordercustormetNameDataGridViewTextBoxColumn";
            this.ordercustormetNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordercustormetNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordertotalconsumptionDataGridViewTextBoxColumn
            // 
            this.ordertotalconsumptionDataGridViewTextBoxColumn.DataPropertyName = "Order_total_consumption";
            this.ordertotalconsumptionDataGridViewTextBoxColumn.HeaderText = "总金额";
            this.ordertotalconsumptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordertotalconsumptionDataGridViewTextBoxColumn.Name = "ordertotalconsumptionDataGridViewTextBoxColumn";
            this.ordertotalconsumptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.ordertotalconsumptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // OrderbindingSource
            // 
            this.OrderbindingSource.DataSource = typeof(订单系统.Order);
            this.OrderbindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnImport);
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.QuertAllbtn);
            this.panel2.Controls.Add(this.tbQuertStr);
            this.panel2.Controls.Add(this.Querybtn);
            this.panel2.Controls.Add(this.cmbQuertyCondition);
            this.panel2.Controls.Add(this.ReviseOrderbtn);
            this.panel2.Controls.Add(this.DeleteOrderbtn);
            this.panel2.Controls.Add(this.AddOrderbtn);
            this.panel2.Location = new System.Drawing.Point(776, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 531);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(4, 135);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(150, 49);
            this.btnImport.TabIndex = 8;
            this.btnImport.Text = "导入订单";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(160, 135);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(150, 49);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "导出订单";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // QuertAllbtn
            // 
            this.QuertAllbtn.Location = new System.Drawing.Point(4, 319);
            this.QuertAllbtn.Name = "QuertAllbtn";
            this.QuertAllbtn.Size = new System.Drawing.Size(300, 72);
            this.QuertAllbtn.TabIndex = 6;
            this.QuertAllbtn.Text = "查询所有订单";
            this.QuertAllbtn.UseVisualStyleBackColor = true;
            this.QuertAllbtn.Click += new System.EventHandler(this.QuertAllbtn_Click);
            // 
            // tbQuertStr
            // 
            this.tbQuertStr.Location = new System.Drawing.Point(4, 278);
            this.tbQuertStr.Name = "tbQuertStr";
            this.tbQuertStr.Size = new System.Drawing.Size(300, 25);
            this.tbQuertStr.TabIndex = 5;
            // 
            // Querybtn
            // 
            this.Querybtn.Location = new System.Drawing.Point(132, 246);
            this.Querybtn.Name = "Querybtn";
            this.Querybtn.Size = new System.Drawing.Size(172, 23);
            this.Querybtn.TabIndex = 4;
            this.Querybtn.Text = "查询订单";
            this.Querybtn.UseVisualStyleBackColor = true;
            this.Querybtn.Click += new System.EventHandler(this.Querybtn_Click);
            // 
            // cmbQuertyCondition
            // 
            this.cmbQuertyCondition.FormattingEnabled = true;
            this.cmbQuertyCondition.Items.AddRange(new object[] {
            "按商品名查询",
            "按用户名查询",
            "按订单日期查询"});
            this.cmbQuertyCondition.Location = new System.Drawing.Point(0, 247);
            this.cmbQuertyCondition.Name = "cmbQuertyCondition";
            this.cmbQuertyCondition.Size = new System.Drawing.Size(121, 23);
            this.cmbQuertyCondition.TabIndex = 3;
            this.cmbQuertyCondition.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ReviseOrderbtn
            // 
            this.ReviseOrderbtn.Location = new System.Drawing.Point(160, 25);
            this.ReviseOrderbtn.Name = "ReviseOrderbtn";
            this.ReviseOrderbtn.Size = new System.Drawing.Size(150, 49);
            this.ReviseOrderbtn.TabIndex = 2;
            this.ReviseOrderbtn.Text = "修改订单";
            this.ReviseOrderbtn.UseVisualStyleBackColor = true;
            this.ReviseOrderbtn.Click += new System.EventHandler(this.ReviseOrderbtn_Click);
            // 
            // DeleteOrderbtn
            // 
            this.DeleteOrderbtn.Location = new System.Drawing.Point(4, 80);
            this.DeleteOrderbtn.Name = "DeleteOrderbtn";
            this.DeleteOrderbtn.Size = new System.Drawing.Size(150, 49);
            this.DeleteOrderbtn.TabIndex = 1;
            this.DeleteOrderbtn.Text = "删除订单";
            this.DeleteOrderbtn.UseVisualStyleBackColor = true;
            this.DeleteOrderbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOrderbtn
            // 
            this.AddOrderbtn.Location = new System.Drawing.Point(4, 25);
            this.AddOrderbtn.Name = "AddOrderbtn";
            this.AddOrderbtn.Size = new System.Drawing.Size(150, 49);
            this.AddOrderbtn.TabIndex = 0;
            this.AddOrderbtn.Text = "添加订单";
            this.AddOrderbtn.UseVisualStyleBackColor = true;
            this.AddOrderbtn.Click += new System.EventHandler(this.AddOrderbtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gvItems);
            this.panel1.Location = new System.Drawing.Point(13, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 288);
            this.panel1.TabIndex = 3;
            // 
            // gvItems
            // 
            this.gvItems.AutoGenerateColumns = false;
            this.gvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameofitemDataGridViewTextBoxColumn,
            this.numofitemDataGridViewTextBoxColumn,
            this.priceofitemDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn});
            this.gvItems.DataSource = this.orderitemlistBindingSource;
            this.gvItems.Location = new System.Drawing.Point(4, 4);
            this.gvItems.Name = "gvItems";
            this.gvItems.RowHeadersWidth = 51;
            this.gvItems.RowTemplate.Height = 27;
            this.gvItems.Size = new System.Drawing.Size(742, 281);
            this.gvItems.TabIndex = 0;
            this.gvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvItems_CellContentClick);
            // 
            // nameofitemDataGridViewTextBoxColumn
            // 
            this.nameofitemDataGridViewTextBoxColumn.DataPropertyName = "name_of_item";
            this.nameofitemDataGridViewTextBoxColumn.HeaderText = "商品名";
            this.nameofitemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameofitemDataGridViewTextBoxColumn.Name = "nameofitemDataGridViewTextBoxColumn";
            this.nameofitemDataGridViewTextBoxColumn.Width = 125;
            // 
            // numofitemDataGridViewTextBoxColumn
            // 
            this.numofitemDataGridViewTextBoxColumn.DataPropertyName = "num_of_item";
            this.numofitemDataGridViewTextBoxColumn.HeaderText = "商品数量";
            this.numofitemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numofitemDataGridViewTextBoxColumn.Name = "numofitemDataGridViewTextBoxColumn";
            this.numofitemDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceofitemDataGridViewTextBoxColumn
            // 
            this.priceofitemDataGridViewTextBoxColumn.DataPropertyName = "price_of_item";
            this.priceofitemDataGridViewTextBoxColumn.HeaderText = "商品单价";
            this.priceofitemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceofitemDataGridViewTextBoxColumn.Name = "priceofitemDataGridViewTextBoxColumn";
            this.priceofitemDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "总价";
            this.totalpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderitemlistBindingSource
            // 
            this.orderitemlistBindingSource.DataMember = "Orderitem_list";
            this.orderitemlistBindingSource.DataSource = this.OrderbindingSource;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Orderpanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Orderpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderbindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderitemlistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource OrderbindingSource;
        private System.Windows.Forms.Panel Orderpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gvOrder;
        private System.Windows.Forms.Button AddOrderbtn;
        private System.Windows.Forms.Button ReviseOrderbtn;
        private System.Windows.Forms.Button DeleteOrderbtn;
        private System.Windows.Forms.TextBox tbQuertStr;
        private System.Windows.Forms.Button Querybtn;
        private System.Windows.Forms.ComboBox cmbQuertyCondition;
        private System.Windows.Forms.Button QuertAllbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custormerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordercustormetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordertotalconsumptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gvItems;
        private System.Windows.Forms.BindingSource orderitemlistBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameofitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numofitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceofitemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

