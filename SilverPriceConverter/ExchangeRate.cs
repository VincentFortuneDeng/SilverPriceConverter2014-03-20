using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace SilverPriceConverter
{
    public class RMBExchangeRate
    {
        //[JsonConverter(typeof(IsoDateTimeConverter))]  
        public string Date { get; set; }
        public string USD { get; set; }
        public string EUR { get; set; }
        public string JPY { get; set; }
        public string HKD { get; set; }
        public string GBP { get; set; }
        public string AUD { get; set; }
        public string CAN { get; set; }
        public string MYR { get; set; }
        public string RUB { get; set; }

        private string noticeListUrl = "http://www.pbc.gov.cn/publish/zhengcehuobisi/637/index.html";
        private string dealerCenterUrl = "http://www.safe.gov.cn/AppStructured/view/project_RMBQuery.action";

        private bool enableProxy = false;
        public bool EnableProxy
        {
            get { return enableProxy; }
            set { enableProxy = value; }
        }


        public RMBExchangeRate()
        {

        }
        public RMBExchangeRate(string url)
        {
            this.noticeListUrl = url;
        }
        private string getExchangeRateUrl(string noticeUrl)
        {
            try
            {
                string noticeListWebContent = getWebContent(noticeUrl);

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
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        private byte[] GetEncodeDate(string fromDate, string toDate)
        {
            string param = "projectBean.startDate=" + fromDate +
                "&projectBean.endDate=" + toDate + "&queryYN=true";
            //string encodeParam = HttpUtility.UrlEncode(param, Encoding.UTF8);
            byte[] bytesEncode = Encoding.UTF8.GetBytes(param);

            return bytesEncode;
        }

        public bool GetRMBExchangeRateFromDealerCenter(string fromDate, string toDate)
        {
            try
            {
                //RMBExchangeRate rmbExchangeRate = new RMBExchangeRate();
                //获取最新汇率公告地址
                //string currentExchangeRateUrl = getExchangeRateUrl(noticeListUrl);
                //获取最新汇率公告内容
                string noticeWebContent = getWebContent(dealerCenterUrl, "POST", GetEncodeDate(fromDate, toDate));

                //要匹配的字符串  
                //string text = "1A 2B 3C 4D 5E 6F 7G 8H 9I 10J 11Q 12J 13K 14L 15M 16N ffee80 #800080";
                //正则表达式  

                //获取汇率部分文本
                string pattern = @"<tr.*(?=first)(.|\n)*?</tr>";
                Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
                Match m = r.Match(noticeWebContent);
                if (m.Success)
                {
                    noticeWebContent = m.Value;
                    //获取日期文本
                    //pattern = @"\d{4}[\u4E00-\u9FA5]{1}(\d{1}|\d{2})[\u4E00-\u9FA5]{1}(\d{1}|\d{2})[\u4E00-\u9FA5]{1}";
                    pattern = @"([0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]{1}|[0-9]{1}[1-9][0-9]{2}|[1-9][0-9]{3})-(((0[13578]|1[02])-(0[1-9]|[12][0-9]|3[01]))|((0[469]|11)-(0[1-9]|[12][0-9]|30))|(02-(0[1-9]|[1][0-9]|2[0-8])))";
                    r = new Regex(pattern, RegexOptions.IgnoreCase);
                    m = r.Match(noticeWebContent);
                    this.Date = m.Value;

                    //获取汇率组
                    //pattern = @"[0-9]\.\d{4}";
                    pattern = @"(\d+\.\d+)&nbsp";
                    r = new Regex(pattern, RegexOptions.IgnoreCase);
                    MatchCollection ms = r.Matches(noticeWebContent);


                    this.USD = (double.Parse(ms[0].Groups[1].Value) * 0.01).ToString();//美元

                    this.EUR = (double.Parse(ms[1].Groups[1].Value) * 0.01).ToString();//欧元

                    this.JPY = (double.Parse(ms[2].Groups[1].Value) * 0.01).ToString();//日元

                    this.HKD = (double.Parse(ms[3].Groups[1].Value) * 0.01).ToString();//港币

                    this.GBP = (double.Parse(ms[4].Groups[1].Value) * 0.01).ToString();//英镑

                    this.MYR = (double.Parse(ms[5].Groups[1].Value) * 0.01).ToString();//林吉特

                    this.RUB = (double.Parse(ms[6].Groups[1].Value) * 0.01).ToString();//卢布

                    this.AUD = (double.Parse(ms[7].Groups[1].Value) * 0.01).ToString();//澳元

                    this.CAN = (double.Parse(ms[8].Groups[1].Value) * 0.01).ToString();//加元

                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        public bool GetRMBExchangeRateFromDealerCenter(string date)
        {
            try
            {
                //RMBExchangeRate rmbExchangeRate = new RMBExchangeRate();
                //获取最新汇率公告地址
                //string currentExchangeRateUrl = getExchangeRateUrl(noticeListUrl);
                //获取最新汇率公告内容
                string noticeWebContent = getWebContent(dealerCenterUrl, "POST", GetEncodeDate(date, date));

                //要匹配的字符串  
                //string text = "1A 2B 3C 4D 5E 6F 7G 8H 9I 10J 11Q 12J 13K 14L 15M 16N ffee80 #800080";
                //正则表达式  

                //获取汇率部分文本
                string pattern = @"<tr.*(?=first)(.|\n)*?</tr>";
                Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
                Match m = r.Match(noticeWebContent);
                if (m.Success)
                {
                    noticeWebContent = m.Value;
                    //获取日期文本
                    //pattern = @"\d{4}[\u4E00-\u9FA5]{1}(\d{1}|\d{2})[\u4E00-\u9FA5]{1}(\d{1}|\d{2})[\u4E00-\u9FA5]{1}";
                    pattern = @"([0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]{1}|[0-9]{1}[1-9][0-9]{2}|[1-9][0-9]{3})-(((0[13578]|1[02])-(0[1-9]|[12][0-9]|3[01]))|((0[469]|11)-(0[1-9]|[12][0-9]|30))|(02-(0[1-9]|[1][0-9]|2[0-8])))";
                    r = new Regex(pattern, RegexOptions.IgnoreCase);
                    m = r.Match(noticeWebContent);
                    this.Date = m.Value;

                    //获取汇率组
                    //pattern = @"[0-9]\.\d{4}";
                    pattern = @"(\d+\.\d+)&nbsp";
                    r = new Regex(pattern, RegexOptions.IgnoreCase);
                    MatchCollection ms = r.Matches(noticeWebContent);


                    this.USD = (double.Parse(ms[0].Groups[1].Value) * 0.01).ToString();//美元

                    this.EUR = (double.Parse(ms[1].Groups[1].Value) * 0.01).ToString();//欧元

                    this.JPY = (double.Parse(ms[2].Groups[1].Value) * 0.01).ToString();//日元

                    this.HKD = (double.Parse(ms[3].Groups[1].Value) * 0.01).ToString();//港币

                    this.GBP = (double.Parse(ms[4].Groups[1].Value) * 0.01).ToString();//英镑

                    this.MYR = (double.Parse(ms[5].Groups[1].Value) * 0.01).ToString();//林吉特

                    this.RUB = (double.Parse(ms[6].Groups[1].Value) * 0.01).ToString();//卢布

                    this.AUD = (double.Parse(ms[7].Groups[1].Value) * 0.01).ToString();//澳元

                    this.CAN = (double.Parse(ms[8].Groups[1].Value) * 0.01).ToString();//加元

                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        public bool GetRMBExchangeRateFromDealerCenter()
        {
            try
            {
                //RMBExchangeRate rmbExchangeRate = new RMBExchangeRate();
                //获取最新汇率公告地址
                //string currentExchangeRateUrl = getExchangeRateUrl(noticeListUrl);
                //获取最新汇率公告内容
                string noticeWebContent = getWebContent(dealerCenterUrl, "POST");

                //要匹配的字符串  
                //string text = "1A 2B 3C 4D 5E 6F 7G 8H 9I 10J 11Q 12J 13K 14L 15M 16N ffee80 #800080";
                //正则表达式  

                //获取汇率部分文本
                string pattern = @"<tr.*(?=first)(.|\n)*?</tr>";
                Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
                Match m = r.Match(noticeWebContent);
                if (m.Success)
                {
                    noticeWebContent = m.Value;
                    //获取日期文本
                    //pattern = @"\d{4}[\u4E00-\u9FA5]{1}(\d{1}|\d{2})[\u4E00-\u9FA5]{1}(\d{1}|\d{2})[\u4E00-\u9FA5]{1}";
                    pattern = @"([0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]{1}|[0-9]{1}[1-9][0-9]{2}|[1-9][0-9]{3})-(((0[13578]|1[02])-(0[1-9]|[12][0-9]|3[01]))|((0[469]|11)-(0[1-9]|[12][0-9]|30))|(02-(0[1-9]|[1][0-9]|2[0-8])))";
                    r = new Regex(pattern, RegexOptions.IgnoreCase);
                    m = r.Match(noticeWebContent);
                    this.Date = m.Value;

                    //获取汇率组
                    //pattern = @"[0-9]\.\d{4}";
                    pattern = @"(\d+\.\d+)&nbsp";
                    r = new Regex(pattern, RegexOptions.IgnoreCase);
                    MatchCollection ms = r.Matches(noticeWebContent);


                    this.USD = (double.Parse(ms[0].Groups[1].Value) * 0.01).ToString();//美元

                    this.EUR = (double.Parse(ms[1].Groups[1].Value) * 0.01).ToString();//欧元

                    this.JPY = (double.Parse(ms[2].Groups[1].Value) * 0.01).ToString();//日元

                    this.HKD = (double.Parse(ms[3].Groups[1].Value) * 0.01).ToString();//港币

                    this.GBP = (double.Parse(ms[4].Groups[1].Value) * 0.01).ToString();//英镑

                    this.MYR = (double.Parse(ms[5].Groups[1].Value) * 0.01).ToString();//林吉特

                    this.RUB = (double.Parse(ms[6].Groups[1].Value) * 0.01).ToString();//卢布

                    this.AUD = (double.Parse(ms[7].Groups[1].Value) * 0.01).ToString();//澳元

                    this.CAN = (double.Parse(ms[8].Groups[1].Value) * 0.01).ToString();//加元

                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        public bool GetRMBExchangeRate()
        {
            try
            {
                //RMBExchangeRate rmbExchangeRate = new RMBExchangeRate();
                //获取最新汇率公告地址
                string currentExchangeRateUrl = getExchangeRateUrl(noticeListUrl);
                //获取最新汇率公告内容
                string noticeWebContent = getWebContent(currentExchangeRateUrl);

                //要匹配的字符串  
                //string text = "1A 2B 3C 4D 5E 6F 7G 8H 9I 10J 11Q 12J 13K 14L 15M 16N ffee80 #800080";
                //正则表达式  

                //获取汇率部分文本
                string pattern = @"<span>\d{4}.*</span>";
                Regex r = new Regex(pattern, RegexOptions.IgnoreCase);
                Match m = r.Match(noticeWebContent);
                if (m.Success)
                {
                    noticeWebContent = m.Value;
                    //获取日期文本
                    pattern = @"\d{4}[\u4E00-\u9FA5]{1}(\d{1}|\d{2})[\u4E00-\u9FA5]{1}(\d{1}|\d{2})[\u4E00-\u9FA5]{1}";
                    r = new Regex(pattern, RegexOptions.IgnoreCase);
                    m = r.Match(noticeWebContent);
                    this.Date = m.Value;

                    //获取汇率组
                    pattern = @"[0-9]\.\d{4}";
                    r = new Regex(pattern, RegexOptions.IgnoreCase);
                    MatchCollection ms = r.Matches(noticeWebContent);

                    this.USD = ms[0].Value;//美元
                    this.EUR = ms[1].Value;//欧元
                    this.JPY = ms[2].Value;//日元
                    this.HKD = ms[3].Value;//港币
                    this.GBP = ms[4].Value;//英镑
                    this.AUD = ms[5].Value;//澳元
                    this.CAN = ms[6].Value;//加元
                    this.MYR = ms[7].Value;//林吉特
                    this.RUB = ms[8].Value;//卢布

                    return true;
                }

                else
                {
                    return false;
                }
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        private WebProxy getWebProxy()
        {
            WebProxy proxy = null;//= new WebProxy(); //定義一個網關對象
            if (enableProxy)
            {
                proxy = new WebProxy("127.0.0.1", 8087);
                //proxy.Address = new Uri("127.0.0.1",8087); //網關服務器:端口
                //proxy.
                //proxy.Credentials = new NetworkCredential("f3210316", "6978233"); //用戶名,密碼 
                //hwr.UseDefaultCredentials = true; //啟用網關認証 
                //hwr.Proxy = proxy; //設置網關  
            }

            return proxy;
        }

        private string getWebContent(string url, string method, byte[] bytesParam)
        {
            string strResult = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                //自动代理
                request.Proxy = getWebProxy();
                //声明一个HttpWebRequest请求 
                request.Timeout = 30000;
                //设置连接超时时间 
                //request.Headers.Set("Pragma", "no-cache");
                //设置非缓存请求
                HttpRequestCachePolicy noCachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
                request.CachePolicy = noCachePolicy;
                request.Method = method;

                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                //request.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
                request.Headers["Accept-Encoding"] = "gzip,deflate,sdch";

                //req.AutomaticDecompression = DecompressionMethods.GZip;
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                //request.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
                request.Headers["Accept-Language"] = "zh-CN,zh;q=0.8";
                //request.Headers.Add("Cache-Control", "max-age=0");
                //request.Connection = "keep-alive";
                request.KeepAlive = true;

                //request.ContentLength = 76;
                request.ContentType = "application/x-www-form-urlencoded";
                //request.Headers.Add("Host", "www.safe.gov.cn");

                request.Headers["Origin"] = "http://www.safe.gov.cn";
                request.Referer = url;// "http://www.safe.gov.cn/AppStructured/view/project_RMBQuery.action";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.154 Safari/537.36";

                //byte[] postData = Encoding.UTF8.GetBytes(param);
                request.ContentLength = bytesParam.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(bytesParam, 0, bytesParam.Length);

                    //requestStream.Close();

                    //WebResponse response = request.GetResponse();
                    using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                    {
                        //Stream streamReceive = response.GetResponseStream();
                        //Encoding encoding = Encoding.UTF8;
                        StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                        strResult = streamReader.ReadToEnd();
                    }
                }
                return strResult;
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        //根据Url地址得到网页的html源码 
        private string getWebContent(string url, string method)
        {
            string strResult = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                //自动代理
                request.Proxy = getWebProxy();
                //声明一个HttpWebRequest请求 
                request.Timeout = 30000;
                //设置连接超时时间 
                //request.Headers.Set("Pragma", "no-cache");
                //设置非缓存请求
                HttpRequestCachePolicy noCachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
                request.CachePolicy = noCachePolicy;
                request.Method = method;

                request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                //request.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
                request.Headers["Accept-Encoding"] = "gzip,deflate,sdch";
                
                //req.AutomaticDecompression = DecompressionMethods.GZip;
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

                //request.Headers.Add("Accept-Language", "zh-CN,zh;q=0.8");
                request.Headers["Accept-Language"] = "zh-CN,zh;q=0.8";
                //request.Headers.Add("Cache-Control", "max-age=0");
                //request.Connection = "keep-alive";
                request.KeepAlive = true;

                //request.ContentLength = 76;
                request.ContentType = "application/x-www-form-urlencoded";
                //request.Headers.Add("Host", "www.safe.gov.cn");

                request.Headers["Origin"] = "http://www.safe.gov.cn";
                request.Referer = url;// "http://www.safe.gov.cn/AppStructured/view/project_RMBQuery.action";
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/33.0.1750.154 Safari/537.36";

                //WebResponse response = request.GetResponse();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //Stream streamReceive = response.GetResponseStream();
                //Encoding encoding = Encoding.UTF8;
                StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);//临时修改
                strResult = streamReader.ReadToEnd();
                return strResult;
            }

            catch (Exception e)
            {
                throw e;
            }
        }

        //根据Url地址得到网页的html源码 
        private string getWebContent(string url)
        {
            string strResult = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

                //自动代理
                request.Proxy = getWebProxy();
                //声明一个HttpWebRequest请求 
                request.Timeout = 30000;
                //设置连接超时时间 
                //request.Headers.Set("Pragma", "no-cache");

                request.Headers["Accept-Encoding"] = "gzip,deflate,sdch";

                //req.AutomaticDecompression = DecompressionMethods.GZip;
                request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
                //设置非缓存请求
                HttpRequestCachePolicy noCachePolicy = new HttpRequestCachePolicy(HttpRequestCacheLevel.NoCacheNoStore);
                request.CachePolicy = noCachePolicy;

                //WebResponse response = request.GetResponse();
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                //Encoding encoding = Encoding.UTF8;
                StreamReader streamReader = new StreamReader(streamReceive, Encoding.UTF8);
                strResult = streamReader.ReadToEnd();
                return strResult;
            }

            catch (Exception e)
            {
                throw e;
            }
        }
    }

}
