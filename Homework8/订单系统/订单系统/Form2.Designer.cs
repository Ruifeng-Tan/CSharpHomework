namespace 订单系统
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Order_IDlbl = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReviseItem = new System.Windows.Forms.Button();
            this.btnDelItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDelCustomerName = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.OrderDetailbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_IDlbl
            // 
            this.Order_IDlbl.AutoSize = true;
            this.Order_IDlbl.Location = new System.Drawing.Point(14, 61);
            this.Order_IDlbl.Name = "Order_IDlbl";
            this.Order_IDlbl.Size = new System.Drawing.Size(52, 15);
            this.Order_IDlbl.TabIndex = 0;
            this.Order_IDlbl.Text = "订单号";
            this.Order_IDlbl.Click += new System.EventHandler(this.Order_IDlbl_Click);
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(72, 58);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(303, 25);
            this.tbOrderID.TabIndex = 4;
            this.tbOrderID.TextChanged += new System.EventHandler(this.tbOrderID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "顾客";
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Items.AddRange(new object[] {
            "张三",
            "李四"});
            this.cmbCustomerName.Location = new System.Drawing.Point(72, 104);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(303, 23);
            this.cmbCustomerName.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOrderDetail);
            this.groupBox1.Location = new System.Drawing.Point(17, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1047, 297);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单明细";
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AutoGenerateColumns = false;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.DataSource = this.OrderDetailbindingSource;
            this.dgvOrderDetail.Location = new System.Drawing.Point(0, 31);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 27;
            this.dgvOrderDetail.Size = new System.Drawing.Size(1034, 266);
            this.dgvOrderDetail.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReviseItem);
            this.groupBox2.Controls.Add(this.btnDelItem);
            this.groupBox2.Controls.Add(this.btnAddItem);
            this.groupBox2.Location = new System.Drawing.Point(17, 463);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1034, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "明细操作";
            // 
            // btnReviseItem
            // 
            this.btnReviseItem.Location = new System.Drawing.Point(308, 24);
            this.btnReviseItem.Name = "btnReviseItem";
            this.btnReviseItem.Size = new System.Drawing.Size(145, 55);
            this.btnReviseItem.TabIndex = 2;
            this.btnReviseItem.Text = "修改明细";
            this.btnReviseItem.UseVisualStyleBackColor = true;
            // 
            // btnDelItem
            // 
            this.btnDelItem.Location = new System.Drawing.Point(157, 24);
            this.btnDelItem.Name = "btnDelItem";
            this.btnDelItem.Size = new System.Drawing.Size(145, 55);
            this.btnDelItem.TabIndex = 1;
            this.btnDelItem.Text = "删除明细";
            this.btnDelItem.UseVisualStyleBackColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(6, 24);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(145, 55);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "添加明细";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(381, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 71);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelCustomerName);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.tbCustomerName);
            this.groupBox3.Controls.Add(this.lblCustomerName);
            this.groupBox3.Location = new System.Drawing.Point(532, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(530, 108);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用户操作";
            // 
            // btnDelCustomerName
            // 
            this.btnDelCustomerName.Location = new System.Drawing.Point(294, 67);
            this.btnDelCustomerName.Name = "btnDelCustomerName";
            this.btnDelCustomerName.Size = new System.Drawing.Size(230, 25);
            this.btnDelCustomerName.TabIndex = 3;
            this.btnDelCustomerName.Text = "删除用户";
            this.btnDelCustomerName.UseVisualStyleBackColor = true;
            this.btnDelCustomerName.Click += new System.EventHandler(this.btnDelCustomerName_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(11, 67);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(230, 25);
            this.button5.TabIndex = 2;
            this.button5.Text = "创建用户";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(89, 25);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(435, 25);
            this.tbCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(8, 35);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(52, 15);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "用户名";
            // 
            // OrderDetailbindingSource
            // 
            this.OrderDetailbindingSource.DataSource = typeof(订单系统.OrderItem);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 580);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.Order_IDlbl);
            this.Name = "Form2";
            this.Text = "订单信息";
            this.Load += new System.EventHandler(this.AddOrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Order_IDlbl;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReviseItem;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDelCustomerName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.BindingSource OrderDetailbindingSource;
    }
}