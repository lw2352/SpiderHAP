﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;

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

            string path = @"F:\LW_files\GitHub\SpiderHAP\SpiderHAP\10P.html";

            HtmlWeb hw = new HtmlWeb();
            hw.OverrideEncoding = Encoding.GetEncoding("gbk");  //注意：此处需要设置页面编码格式
            HtmlAgilityPack.HtmlDocument doc = hw.Load(path);//是你需要解析的url
            
        }
    }
}
