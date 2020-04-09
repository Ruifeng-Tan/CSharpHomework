namespace WindowsFormsApp1
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
            this.drawbutton = new System.Windows.Forms.Button();
            this.txtdepthofrecursion = new System.Windows.Forms.TextBox();
            this.txtleng = new System.Windows.Forms.TextBox();
            this.txt_th2 = new System.Windows.Forms.TextBox();
            this.txt_th1 = new System.Windows.Forms.TextBox();
            this.cmbPenColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBarforperl2 = new System.Windows.Forms.TrackBar();
            this.trackBarforperl1 = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarforperl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarforperl1)).BeginInit();
            this.SuspendLayout();
            // 
            // drawbutton
            // 
            this.drawbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawbutton.Location = new System.Drawing.Point(685, 29);
            this.drawbutton.Name = "drawbutton";
            this.drawbutton.Size = new System.Drawing.Size(75, 23);
            this.drawbutton.TabIndex = 0;
            this.drawbutton.Text = "draw";
            this.drawbutton.UseVisualStyleBackColor = true;
            this.drawbutton.Click += new System.EventHandler(this.drawbutton_Click);
            // 
            // txtdepthofrecursion
            // 
            this.txtdepthofrecursion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdepthofrecursion.Location = new System.Drawing.Point(718, 96);
            this.txtdepthofrecursion.Name = "txtdepthofrecursion";
            this.txtdepthofrecursion.Size = new System.Drawing.Size(100, 25);
            this.txtdepthofrecursion.TabIndex = 1;
            // 
            // txtleng
            // 
            this.txtleng.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtleng.Location = new System.Drawing.Point(526, 96);
            this.txtleng.Name = "txtleng";
            this.txtleng.Size = new System.Drawing.Size(100, 25);
            this.txtleng.TabIndex = 4;
            // 
            // txt_th2
            // 
            this.txt_th2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_th2.Location = new System.Drawing.Point(524, 156);
            this.txt_th2.Name = "txt_th2";
            this.txt_th2.Size = new System.Drawing.Size(100, 25);
            this.txt_th2.TabIndex = 5;
            // 
            // txt_th1
            // 
            this.txt_th1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_th1.Location = new System.Drawing.Point(524, 216);
            this.txt_th1.Name = "txt_th1";
            this.txt_th1.Size = new System.Drawing.Size(100, 25);
            this.txt_th1.TabIndex = 6;
            // 
            // cmbPenColor
            // 
            this.cmbPenColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPenColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPenColor.FormattingEnabled = true;
            this.cmbPenColor.Items.AddRange(new object[] {
            "蓝色",
            "红色",
            "黑色"});
            this.cmbPenColor.Location = new System.Drawing.Point(579, 276);
            this.cmbPenColor.Name = "cmbPenColor";
            this.cmbPenColor.Size = new System.Drawing.Size(121, 23);
            this.cmbPenColor.TabIndex = 7;
            this.cmbPenColor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(645, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "递归深度";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "左分支长度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "右分支长度";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(451, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "主干长度";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "左分支角度";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "右分支角度";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "画笔颜色";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // trackBarforperl2
            // 
            this.trackBarforperl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarforperl2.Location = new System.Drawing.Point(714, 156);
            this.trackBarforperl2.Name = "trackBarforperl2";
            this.trackBarforperl2.Size = new System.Drawing.Size(104, 56);
            this.trackBarforperl2.TabIndex = 15;
            this.trackBarforperl2.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBarforperl1
            // 
            this.trackBarforperl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarforperl1.Location = new System.Drawing.Point(714, 216);
            this.trackBarforperl1.Name = "trackBarforperl1";
            this.trackBarforperl1.Size = new System.Drawing.Size(104, 56);
            this.trackBarforperl1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 401);
            this.panel1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.trackBarforperl1);
            this.Controls.Add(this.trackBarforperl2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPenColor);
            this.Controls.Add(this.txt_th1);
            this.Controls.Add(this.txt_th2);
            this.Controls.Add(this.txtleng);
            this.Controls.Add(this.txtdepthofrecursion);
            this.Controls.Add(this.drawbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarforperl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarforperl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button drawbutton;
        private System.Windows.Forms.TextBox txtdepthofrecursion;
        private System.Windows.Forms.TextBox txtleng;
        private System.Windows.Forms.TextBox txt_th2;
        private System.Windows.Forms.TextBox txt_th1;
        private System.Windows.Forms.ComboBox cmbPenColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TrackBar trackBarforperl2;
        private System.Windows.Forms.TrackBar trackBarforperl1;
        private System.Windows.Forms.Panel panel1;
    }
}

