namespace 订单系统
{
    partial class OrderDelForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "删除订单";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(45, 61);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(52, 15);
            this.lblOrderID.TabIndex = 1;
            this.lblOrderID.Text = "订单号";
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(104, 58);
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(346, 25);
            this.tbOrderID.TabIndex = 2;
            // 
            // OrderDelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 218);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.button1);
            this.Name = "OrderDelForm";
            this.Text = "OrderDelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox tbOrderID;
    }
}