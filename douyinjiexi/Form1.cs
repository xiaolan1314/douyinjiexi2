using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json.Linq;
using System.Text.RegularExpressions;
using Microsoft.Toolkit.Uwp.Notifications;
using System.Net;
using Windows.ApplicationModel.Background;
using Windows.Foundation;
using Windows.UI.Notifications;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Collections;
using System.IO;

namespace douyinjiexi
{
    public partial class Form1 : Form
    {
        public static string Url;
        public static string desc ;
        public static string music ;
        public static string video_down ;
        public static string desc_mp4;
        public static string copy_info;
        public static string shuruUrl;
        public static int check=0;
        public static string xinxi ;
        public static string jiexiUrl;
        public static string IDS;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) 
        {
            shuruUrl = this.textBox_shuru1.Text;
            解析();
            if (check == 1)    
            {
                geshihua();
            }
            xinxi = "解析完成！";
            提示信息();
        }
        private void 解析()
        {
            
            string reg = @"([a-zA-z]+://[^\s]*)";
            Match zhengze = Regex.Match(shuruUrl, reg);
            string pipeiUrl = zhengze.ToString();
            if (!string.IsNullOrEmpty(pipeiUrl))
            {
                Url = pipeiUrl;
                解析API();
                check = 1;
            }
            else
            {
                check = 0;
                MessageBox.Show("请输入正确的抖音分享地址");
            }
        }
        private void 解析API()
        {
            string fanhui = Fanhuiurl(Url);
            string ids = @"([0-9]+)";
            Match zhengze2 = Regex.Match(fanhui, ids);
            IDS = zhengze2.ToString();
            //根据API提供请求到服务器上
            string fanhuiapi1 = HttpWebRequest_Get1("https://www.iesdouyin.com/web/api/v2/aweme/iteminfo/?item_ids=" + IDS);
            //json取出对应地址
            JObject jo = JObject.Parse(fanhuiapi1);
            string video = jo["item_list"][0]["video"]["play_addr"]["url_list"][0].ToString();
            //文件名
            desc = jo["item_list"][0]["desc"].ToString();
            desc_mp4 = desc + ".mp4";
            //音乐
            music= jo["item_list"][0]["music"]["play_url"]["uri"].ToString();
            //视频
            video = video.Replace("playwm", "play");
            video = video.Replace("720p", "4K");
            video_down = Fanhuiurl2(video);
            
        }
        private void geshihua()
        {
            this.textBox_shuchu_desc.Text = desc;
            this.textBox_shuchu_music.Text = music;
            this.textBox_shuchu_video.Text = video_down;
            this.button_start.Text = "解析完成！";
            this.button_down_IDM.Enabled=true;
            this.button_down_Thunder.Enabled = true;
            this.button_copy.Enabled = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            textBox_shuru1.Text = "9.97 Mwf:/ 该吃吃该喝喝 有事没事多想哥 https://v.douyin.com/juPXoWr/ 复制此链接，打开Dou音搜索，直接观看视频！";
        }

        private void button_down_IDM_Click(object sender, EventArgs e)
        {
            IDMdown(video_down, desc_mp4);
            xinxi = "被推送到IDM下载器!";
            提示信息();
        }
        public void IDMdown(string down_url,string down_name)
        {
            new IDManLib.CIDMLinkTransmitterClass().SendLinkToIDM(down_url, "", "", "", "", "", "", down_name, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_ver.Text = GetEdition().ToString();
        }
        public static Version GetEdition()
        {
            return System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        }
        private void button_down_Thunder_Click(object sender, EventArgs e)
        {
            button_down_Thunder.Text = "正在下载";
            string zhuomian = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            string save = @zhuomian+ "\\"+ desc_mp4;
            using (var web = new WebClient())
            {
                web.DownloadFile(video_down, save);
                
            }
            button_down_Thunder.Text = "下载完成";
            xinxi = "下载到" + zhuomian;
            提示信息();
        }
        public void 本地下载(string mulu,string name)
        {

        }
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }


        private void 解析ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                e.Cancel = true;
                this.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("你确定要退出吗！", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                // 关闭所有的线程
                this.Dispose();
                this.Close();
            }
        }

        private void nIcon_Click(object sender, EventArgs e)
        {

        }

        private void nIcon_Click(object sender, MouseEventArgs e)
        {
            显示主程序();
        }

        private void 显示主程序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            显示主程序();
        }
        private void 显示主程序()
        {
            try
            {
                if (this.WindowState == FormWindowState.Minimized)//当程序是最小化的状态时显示程序页面
                {
                    this.WindowState = FormWindowState.Normal;
                }
                this.Activate();
                this.Visible = true;
                this.ShowInTaskbar = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         private void 获取剪切板内容()
        {
            IDataObject iData = Clipboard.GetDataObject();//从剪贴板中获取数据
            if (iData.GetDataPresent(DataFormats.Text))
            {
                // GetData检索数据并指定一个格式
                copy_info = (string)iData.GetData(DataFormats.Text);
                check = 1;


            }
            else
            {
                check = 0;
                MessageBox.Show("剪贴板中数据不可转换为文本", "错误");
            }
            
        }
        
        private void 解析后使用IDM下载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            获取剪切板内容();
            if (check == 1)                     //检验剪切板是否有内容
            {               
                shuruUrl = copy_info;
            解析();
            if (check == 1)                     //校验解析是否正常
            {
                    IDMdown(video_down, desc_mp4);
                    xinxi = "被推送到IDM下载器!";
                提示信息();
            }
            }
        }
        private void 粘贴到剪切板(string doc)
        {
            Clipboard.SetText(doc);
        }

        private void 解析后复制到剪贴板ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            获取剪切板内容();
            if (check == 1)
            {
                shuruUrl = copy_info;
                解析();
                if (check == 1)
                {
                    粘贴到剪切板(video_down);
                    xinxi = "被复制到剪切板!";
                    提示信息();
                }
            }
        }
        private void 提示信息()
        {

            // Requires Microsoft.Toolkit.Uwp.Notifications NuGet package version 7.0 or greater
            new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("解析成功!")
                .AddText(desc_mp4)
                //.AddText(down)
                .AddText("已成功"+xinxi)



                .AddButton(new ToastButton()
                .SetContent("播放")
                .AddArgument("action", "bofang")
                .SetBackgroundActivation())

                .AddButton(new ToastButton()
                .SetContent("下载")
                .AddArgument("action", "download")
                .SetBackgroundActivation())
                
                .Show(); // Not seeing the Show() method? Make sure you have version 7.0, and if you're using .NET 6 (or later), then your TFM must be net6.0-windows10.0.17763.0 or greater
            
        }
        //public event TypedEventHandler<ToastNotification, object> Activated;
        

        private void 解析后使用迅雷下载ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var zhuomian = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            var save = @zhuomian + "\\" + desc_mp4;
            using (var web = new WebClient())
            {
                web.DownloadFile(video_down, save);
            }
            xinxi = "下载到" + zhuomian;
            提示信息();
            //MessageBox.Show("！还未开发！");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox_shuru1_Leave(object sender, EventArgs e)
        {
            if (textBox_shuru1.Text == "")
            {
                textBox_shuru1.Text = "提示内容";
                textBox_shuru1.ForeColor = Color.LightGray;
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox_shuchu_video_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_shuchu_music_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_shuchu_desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                粘贴到剪切板(video_down);
                xinxi = "被复制到剪切板!";
                提示信息();
            }
        }

        private void label_ver_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://cdn.xlhhy.cn/publish/%E6%8A%96%E9%9F%B3%E6%97%A0%E6%B0%B4%E5%8D%B0%E8%A7%A3%E6%9E%90%E5%B7%A5%E5%85%B7.application");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://cdn.xlhhy.cn/publish/%E6%8A%96%E9%9F%B3%E6%97%A0%E6%B0%B4%E5%8D%B0%E8%A7%A3%E6%9E%90%E5%B7%A5%E5%85%B7.application");
        }
        //public virtual extern void AddTask([MarshalAs(UnmanagedType.BStr), In] string bstrUrl, [MarshalAs(UnmanagedType.BStr), In] string bstrFileName = "", [MarshalAs(UnmanagedType.BStr), In] string bstrPath = "", [MarshalAs(UnmanagedType.BStr), In] string bstrComments = "", [MarshalAs(UnmanagedType.BStr), In] string bstrReferUrl = "", [In] int nStartMode = -1, [In] int nOnlyFromOrigin = 0, [In] int nOriginThreadCount = -1);
        /*public static void 获取剪切板内容(string[] args)
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
            {
                Console.WriteLine((String)iData.GetData(DataFormats.Text));
            }
            if (iData.GetDataPresent(DataFormats.Bitmap))
            {
                Image img = (Bitmap)iData.GetData(DataFormats.Bitmap);
            }
        }
        */
        static string Fanhuiurl(string cahxunurl)
        {
            string url = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(cahxunurl);
            req.Method = "HEAD";
            req.AllowAutoRedirect = false;
            HttpWebResponse myResp = (HttpWebResponse)req.GetResponse();
            if (myResp.StatusCode == HttpStatusCode.Redirect)
            { url = myResp.GetResponseHeader("Location"); }
            return url;
        }
        static string Fanhuiurl2(string cahxunurl)
        {
            string url = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(cahxunurl);

            req.AllowAutoRedirect = false;

            req.Method = "GET";
            req.Accept = "text/html";
            req.ContentType = "application/x-www-form-urlencoded";
            req.Host = "aweme.snssdk.com";
            req.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.861.0 Safari/535.2";
            HttpWebResponse myResp = (HttpWebResponse)req.GetResponse();
            if (myResp.StatusCode == HttpStatusCode.Redirect)
            { url = myResp.GetResponseHeader("Location"); }
            return url;
        }


        public static string HttpWebRequest_Get1(string url)
        {
            //取网页返回html全部内容
            Encoding encoding = Encoding.UTF8;


            //构造一个Web请求的对象
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.Accept = "text/html";
            request.ContentType = "application/x-www-form-urlencoded";
            request.Host = "www.iesdouyin.com";
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.861.0 Safari/535.2";

            //获取web请求的响应的内容
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            粘贴到剪切板(desc);
        }
    }

}
