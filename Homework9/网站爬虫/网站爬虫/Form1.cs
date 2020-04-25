using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 网站爬虫
{
    public partial class Form1 : Form
    {
        BindingSource resultBindingSource = new BindingSource();
        //使用BindingSource绑定数据，以便爬虫状态一更新就可以显示在dataGridView上
        Crawler mycrawler = new Crawler();
        Thread thread = null;

        public Form1()
        {
            InitializeComponent();
            dgvResult.DataSource = resultBindingSource;
            //绑定相关的事件响应
            Crawler.PageDownloaded += Download;
            Crawler.CrawlerStopped += StopCrawing;
        }

        //相应Action
        private void StopCrawing(Crawler obj)
        {
            Action action = () => lblStatus.Text = "爬虫已停止";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Download(Crawler crawler, string url, string info)
        {
            lock (this)//防止对编号numIndex的数据争用
            {
                var pageInfo = new { numIndex = resultBindingSource.Count + 1, URL = url, Status = info };
                Action action = () => { resultBindingSource.Add(pageInfo); };
                if (this.InvokeRequired)
                {
                    this.Invoke(action);
                }
                else
                {
                    action();
                }
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            mycrawler.StartURL = tbStartUrl.Text;
            
            Match match = Regex.Match(mycrawler.StartURL, Crawler.urlParseRegex);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            //设置过滤器
            mycrawler.HostFilter = "^" + host + "$";
            mycrawler.FileFilter = ".html?$";

            if (thread != null)
            {
                thread.Abort();
            }
            thread = new Thread(mycrawler.Start);
            thread.Start();
            lblStatus.Text = "爬虫已启动....";

        }

    }
}
