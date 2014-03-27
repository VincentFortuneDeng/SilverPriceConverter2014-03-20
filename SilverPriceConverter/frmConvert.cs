using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevComponents.DotNetBar.Metro;
using System.Net.Cache;

namespace SilverPriceConverter
{
    public partial class frmConvert : MetroForm
    {
        private RMBExchangeRate rmbexchangeRate = new RMBExchangeRate();
        public frmConvert()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (cbxAuto.Checked)
            {
                try
                {
                    if (rmbexchangeRate.GetRMBExchangeRateFromDealerCenter())
                    //if (rmbexchangeRate.GetRMBExchangeRateFromDealerCenter("2014-03-13","2014-03-20"))
                    {
                        txtExchangeRate.Text = rmbexchangeRate.USD;
                        //lblDate.Text = rmbexchangeRate.Date;
                        DateTime dt = new DateTime();
                        dt = DateTime.Parse(rmbexchangeRate.Date);
                        lblDate.Text = dt.ToString("yyyy-MM-dd");

                        txtRMB.Text = PriceConverter.Convert(double.Parse(txtUSD.Text),
                            double.Parse(txtExchangeRate.Text)).ToString();

                        Log(txtUSD.Text + "  " + txtRMB.Text);
                    }
                }

                catch
                {
                    txtRMB.Text = "网络异常";
                }
            }

            else
            {
                //txtExchangeRate.Text = rmbexchangeRate.USD;
                lblDate.Text = "离线";

                txtRMB.Text = PriceConverter.Convert(double.Parse(txtUSD.Text),
                    double.Parse(txtExchangeRate.Text)).ToString();
            }
        }

        /*
        private RMBExchangeRate getExchangeRate()
        {
            //RMBExchangeRate rmbExchangeRate = new RMBExchangeRate();


            string erUrl = getExchangeRateUrl("http://www.pbc.gov.cn/publish/zhengcehuobisi/637/index.html");
            RMBExchangeRate rmbExchangeRate = getExchangeRateString(erUrl);
            if (rmbExchangeRate != null)
            {
                //DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(RMBExchangeRate));
                //RMBExchangeRate rmbExchangeRate = serializer.ReadObject(sexchangeRate);

                //rmbExchangeRate = JsonConvert.DeserializeObject<RMBExchangeRate>(sexchangeRate);
                return rmbExchangeRate;
            }

            else
            {
                return null;
            }
            //if 9:00之前 查询昨天时间戳(周一查上周五)和标志
            //if 昨天时间戳9:00之前
            //查询昨天汇率并返回
            //else 昨天时间戳9:00之后
            //停止查询直接读取
            //else 9:00之后

            //访问汇率网站，获得数据，捕获数据异常

            //if 今天汇率 停止查询 设置标志 //记录汇率

            //else 继续查询 设置查询标志


            //if 当天9:00之前
            //检查本地数据
            //获取数据
            //if 得到当天数据
            //停止计时器 存储汇率到本地 记录成功日志
            //else if 非当天数据
            //比较本地数据
            //if 数据相同
            //不存储 设置下次启动计时器时间
            //else 不同
            //存储 设置下次启动时间
            //else 异常
            //设置下次启动计时器时间 提示网络错误
            //继续查询标志 
            //计算下次计时器启动时间 9:00之后启动
            //else 当天9:00之后
            //获取数据
            //if 得到当天数据
            //停止计时器 存储汇率到本地 记录成功日志
            //else if 非当天数据
            //比较本地数据
            //if 数据相同
            //不存储 设置下次启动计时器时间
            //else 不同
            //存储 设置下次启动时间
            //else 异常
            //设置下次启动计时器时间 提示网络错误


            //RMBExchangeRate rmbExchangeRate = new RMBExchangeRate();


        }
        */

        /// <summary>
        /// 正则表达式取数组
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        //static int intTime = 0;
        /*
        private string[] StrToArray(string webContent)
        {
            intTime = System.Environment.TickCount;
            MatchCollection mc = Regex.Matches(webContent, "<font[//s]+color=/" + "/" + ">[0-9]{1,}.[0-9]{4,}</font>");
            string[] res = new string[mc.Count];
            for (int i = 0; i < mc.Count; i++)
            {
                res[i] = mc[i].Value.Substring(0, mc[i].Value.Length);
            }
            intTime = System.Environment.TickCount - intTime;
            return res;
        }*/
        /*
        private string getExchangeRateUrl(string noticeUrl)
        {
            string noticeListWebContent = GetWebContent(noticeUrl);

            //匹配规则
            string pattern = @"/publish/zhengcehuobisi/\d{3}/20\d{2}/\d{23}/\d{23}_.html";
            //使用RegexOptions.IgnoreCase枚举值表示不区分大小写  
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            //使用正则表达式匹配字符串，仅返回一次匹配结果  
            Match m = r.Match(noticeListWebContent);

            if (m.Success)
            {
                return "http://www.pbc.gov.cn" + m.Value;
            }

            else
            {
                return "";
            }
        }*/

        /*
        private RMBExchangeRate getExchangeRateString(string currentExchangeRateUrl)
        {
            string noticeWebContent = GetWebContent(currentExchangeRateUrl);
            RMBExchangeRate rmbExchangeRate = new RMBExchangeRate();
            //要匹配的字符串  
            //string text = "1A 2B 3C 4D 5E 6F 7G 8H 9I 10J 11Q 12J 13K 14L 15M 16N ffee80 #800080";
            //正则表达式  
            string pattern = @"<span>\d{4}.*</span>";
            Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = r.Match(noticeWebContent);
            if (m.Success)
            {
                noticeWebContent = m.Value;
                pattern = @"\d{4}[\u4E00-\u9FA5]{1}(\d{1}|\d{2})[\u4E00-\u9FA5]{1}(\d{1}|\d{2})[\u4E00-\u9FA5]{1}";
                r = new Regex(pattern, RegexOptions.IgnoreCase);
                m = r.Match(noticeWebContent);
                rmbExchangeRate.Date = m.Value;

                pattern = @"[0-9]\.\d{4}";
                r = new Regex(pattern, RegexOptions.IgnoreCase);
                MatchCollection ms = r.Matches(noticeWebContent);

                rmbExchangeRate.USD = ms[0].Value;
                rmbExchangeRate.EUR = ms[1].Value;
                rmbExchangeRate.JPY = ms[2].Value;
                rmbExchangeRate.HKD = ms[3].Value;
                rmbExchangeRate.GBP = ms[4].Value;
                rmbExchangeRate.AUD = ms[5].Value;
                rmbExchangeRate.CAN = ms[6].Value;
                rmbExchangeRate.MYR = ms[7].Value;
                rmbExchangeRate.RUB = ms[8].Value;

                return rmbExchangeRate;
            }

            else
            {
                return null;
            }
        }
        */

        //根据Url地址得到网页的html源码 
        /*
        private string GetWebContent(string url)
        {
            string strResult = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                //声明一个HttpWebRequest请求 
                request.Timeout = 30000;
                //设置连接超时时间 
                //request.Headers.Set("Pragma", "no-cache");
                //设置非缓存请求
                HttpRequestCachePolicy noCachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
                request.CachePolicy = noCachePolicy;

                //WebResponse response = request.GetResponse();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                Encoding encoding = Encoding.GetEncoding("utf-8");
                StreamReader streamReader = new StreamReader(streamReceive, encoding);
                strResult = streamReader.ReadToEnd();
            }
            catch
            {

            }
            return strResult;
        }*/
        /*
        public string GetHttpData(string url)
        {
            string exception = null;
            string rslt = null;
            WebResponse webRps = null;
            WebRequest webRqst = WebRequest.Create(url);
            webRqst.Timeout = 50000;
            try
            {
                webRps = webRqst.GetResponse();
            }
            catch (WebException e)
            {
                exception = e.Message.ToString();
            }
            catch (Exception e)
            {
                exception = e.ToString();
            }
            finally
            {
                if (webRps != null)
                {
                    StreamReader streamRd = new StreamReader(webRps.GetResponseStream(), Encoding.GetEncoding("GB2312"));
                    rslt = streamRd.ReadToEnd();
                    streamRd.Close();
                    webRps.Close();
                }
            }
            return rslt;
        }*/

        /*
        protected void getHuiLvPrice()
        {
            string temp = string.Empty;
            string temp1 = string.Empty;
            string temp2 = string.Empty;
            string temp3 = string.Empty;
            string temp4 = string.Empty;
            string temp5 = string.Empty;
            string htmlStr = string.Empty;

            string rS = string.Empty;
            string regText = "[0-9]{1,}.[0-9]{4,}";

            string httpData = GetHttpData("http://www.pbc.gov.cn/huobizhengce/huobizhengcegongju/huilvzhengce/renminbihuilvjiaoyishoupanjia.asp");
            if (!string.IsNullOrEmpty(httpData))
            {
                string[] arry = StrToArray(httpData);
                for (int i = 0; i < 5; i++)
                {
                    htmlStr = arry.GetValue(i).ToString();
                    if (!string.IsNullOrEmpty(htmlStr))
                    {
                        htmlStr = Regex.Replace(htmlStr, "//s{3,}", "");
                        htmlStr = htmlStr.Replace("/r", "");
                        htmlStr = htmlStr.Replace("/n", "");
                        Regex Re = new Regex(regText);
                        string huilv = string.Empty;

                        Match Ma = Re.Match(htmlStr);
                        if (Ma.Success)
                        {
                            huilv = Ma.Groups[0].Value;
                        }
                        if (!string.IsNullOrEmpty(huilv))
                        {
                            float chinam = float.Parse("100") * float.Parse(huilv);
                            float chinam1 = float.Parse(huilv) / float.Parse("100");
                            if (i == 0)
                            {
                                temp1 = "美元100=" + "RMB" + chinam.ToString() + "<br/>";
                            }
                            else if (i == 1)
                            {
                                temp2 = "欧元100=" + "RMB" + chinam.ToString() + "<br/>";
                            }
                            else if (i == 2)
                            {
                                temp3 = "日元100=" + "RMB" + chinam.ToString() + "<br/>";
                            }
                            else if (i == 3)
                            {
                                temp4 = "港币100=" + "RMB" + chinam.ToString() + "<br/>";
                            }
                            else if (i == 4)
                            {
                                temp5 = "英镑100=" + "RMB" + chinam.ToString();
                            }
                        }
                    }
                }
            }

        }*/

        private void 显示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }

            else
            {
                this.Hide();
            }
        }

        private delegate void InvokeLog(string logtxt);

        private void Log(string logtxt)
        {
            InvokeLog invokeLog = new InvokeLog(Log);

            if (this.txtHistory.InvokeRequired)
            {
                invokeLog.Invoke(logtxt);
            }

            else
            {
                txtHistory.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ")
                    + logtxt + System.Environment.NewLine);
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void frmConvert_Resize(object sender, EventArgs e)
        {
            //窗体最小化时  
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }

            //窗体恢复正常时  
            if (this.WindowState == FormWindowState.Normal)
            {
                //this.Show();
            }
        }

        private void frmConvert_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void notIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.Visible)
                {
                    this.Hide();
                }

                else
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    //this.ResumeLayout();
                }
            }
        }
    }
}
