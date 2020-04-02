namespace Homework1_2
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
            this.OperatorList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncaculate = new System.Windows.Forms.Button();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.error_reason = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OperatorList
            // 
            this.OperatorList.FormattingEnabled = true;
            this.OperatorList.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.OperatorList.Location = new System.Drawing.Point(153, 146);
            this.OperatorList.Name = "OperatorList";
            this.OperatorList.Size = new System.Drawing.Size(112, 23);
            this.OperatorList.TabIndex = 0;
            this.OperatorList.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncaculate
            // 
            this.btncaculate.Location = new System.Drawing.Point(153, 207);
            this.btncaculate.Name = "btncaculate";
            this.btncaculate.Size = new System.Drawing.Size(112, 47);
            this.btncaculate.TabIndex = 2;
            this.btncaculate.Text = "calculate";
            this.btncaculate.UseVisualStyleBackColor = true;
            this.btncaculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(47, 147);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(100, 25);
            this.textNum1.TabIndex = 3;
            this.textNum1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(271, 146);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(100, 25);
            this.textNum2.TabIndex = 4;
            this.textNum2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textResult
            // 
            this.textResult.Location = new System.Drawing.Point(398, 146);
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(208, 25);
            this.textResult.TabIndex = 5;
            this.textResult.TextChanged += new System.EventHandler(this.textResult_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "error_reason:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // error_reason
            // 
            this.error_reason.AutoSize = true;
            this.error_reason.Location = new System.Drawing.Point(298, 305);
            this.error_reason.Name = "error_reason";
            this.error_reason.Size = new System.Drawing.Size(55, 15);
            this.error_reason.TabIndex = 9;
            this.error_reason.Text = "reason";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 436);
            this.Controls.Add(this.error_reason);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.btncaculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperatorList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OperatorList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncaculate;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label error_reason;
    }
}

