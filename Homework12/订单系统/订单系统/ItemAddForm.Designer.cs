namespace 订单系统
{
    partial class ItemAddForm
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
            this.lbItemName = new System.Windows.Forms.Label();
            this.lbItemNum = new System.Windows.Forms.Label();
            this.lbItemPrice = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.tbItemName = new System.Windows.Forms.TextBox();
            this.tbItemNum = new System.Windows.Forms.TextBox();
            this.tbItemPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbItemName
            // 
            this.lbItemName.AutoSize = true;
            this.lbItemName.Location = new System.Drawing.Point(52, 55);
            this.lbItemName.Name = "lbItemName";
            this.lbItemName.Size = new System.Drawing.Size(52, 15);
            this.lbItemName.TabIndex = 0;
            this.lbItemName.Text = "商品名";
            // 
            // lbItemNum
            // 
            this.lbItemNum.AutoSize = true;
            this.lbItemNum.Location = new System.Drawing.Point(55, 90);
            this.lbItemNum.Name = "lbItemNum";
            this.lbItemNum.Size = new System.Drawing.Size(67, 15);
            this.lbItemNum.TabIndex = 1;
            this.lbItemNum.Text = "商品数量";
            // 
            // lbItemPrice
            // 
            this.lbItemPrice.AutoSize = true;
            this.lbItemPrice.Location = new System.Drawing.Point(58, 125);
            this.lbItemPrice.Name = "lbItemPrice";
            this.lbItemPrice.Size = new System.Drawing.Size(37, 15);
            this.lbItemPrice.TabIndex = 2;
            this.lbItemPrice.Text = "单价";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(178, 174);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(134, 32);
            this.btnAddItem.TabIndex = 3;
            this.btnAddItem.Text = "添加明细";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // tbItemName
            // 
            this.tbItemName.Location = new System.Drawing.Point(141, 55);
            this.tbItemName.Name = "tbItemName";
            this.tbItemName.Size = new System.Drawing.Size(251, 25);
            this.tbItemName.TabIndex = 4;
            // 
            // tbItemNum
            // 
            this.tbItemNum.Location = new System.Drawing.Point(141, 90);
            this.tbItemNum.Name = "tbItemNum";
            this.tbItemNum.Size = new System.Drawing.Size(251, 25);
            this.tbItemNum.TabIndex = 5;
            // 
            // tbItemPrice
            // 
            this.tbItemPrice.Location = new System.Drawing.Point(141, 125);
            this.tbItemPrice.Name = "tbItemPrice";
            this.tbItemPrice.Size = new System.Drawing.Size(251, 25);
            this.tbItemPrice.TabIndex = 6;
            // 
            // ItemAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 218);
            this.Controls.Add(this.tbItemPrice);
            this.Controls.Add(this.tbItemNum);
            this.Controls.Add(this.tbItemName);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lbItemPrice);
            this.Controls.Add(this.lbItemNum);
            this.Controls.Add(this.lbItemName);
            this.Name = "ItemAddForm";
            this.Text = "添加明细";
            this.Load += new System.EventHandler(this.ItemAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbItemName;
        private System.Windows.Forms.Label lbItemNum;
        private System.Windows.Forms.Label lbItemPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.TextBox tbItemNum;
        private System.Windows.Forms.TextBox tbItemPrice;
    }
}