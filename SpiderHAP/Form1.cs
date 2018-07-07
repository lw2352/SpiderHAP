using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpiderHAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //窗体初始化，在这里做测试
        private void Form1_Load(object sender, EventArgs e)
        {
            string url = "http://t66y.com/htm_data/7/1807/3201612.html";

            HtmlAgilityPack.HtmlWeb hw = new HtmlAgilityPack.HtmlWeb();

            HtmlAgilityPack.HtmlDocument doccc = hw.Load(url);//是你需要解析的url

        }
    }
}
