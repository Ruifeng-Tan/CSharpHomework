namespace 网站爬虫
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
            this.tbStartUrl = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.lblStatus = new System.Windows.Forms.Label();
            this.numIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // tbStartUrl
            // 
            this.tbStartUrl.Location = new System.Drawing.Point(34, 24);
            this.tbStartUrl.Name = "tbStartUrl";
            this.tbStartUrl.Size = new System.Drawing.Size(510, 25);
            this.tbStartUrl.TabIndex = 0;
            this.tbStartUrl.Text = "http://www.cnblogs.com/dstang2000/";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(565, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "启动爬虫";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numIndex,
            this.URL,
            this.Status});
            this.dgvResult.Location = new System.Drawing.Point(12, 107);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowHeadersWidth = 51;
            this.dgvResult.RowTemplate.Height = 27;
            this.dgvResult.Size = new System.Drawing.Size(776, 338);
            this.dgvResult.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(45, 71);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(67, 15);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "爬虫状态";
            // 
            // numIndex
            // 
            this.numIndex.DataPropertyName = "numIndex";
            this.numIndex.HeaderText = "编号";
            this.numIndex.MinimumWidth = 6;
            this.numIndex.Name = "numIndex";
            this.numIndex.Width = 125;
            // 
            // URL
            // 
            this.URL.DataPropertyName = "URL";
            this.URL.HeaderText = "URL网址";
            this.URL.MinimumWidth = 6;
            this.URL.Name = "URL";
            this.URL.Width = 300;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tbStartUrl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStartUrl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn numIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

