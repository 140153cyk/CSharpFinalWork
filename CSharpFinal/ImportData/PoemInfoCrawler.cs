using HtmlAgilityPack;
using Models;
using Newtonsoft.Json;
using ScrapySharp.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ImportData
{
    public class PoemInfoCrawler
    {
        public string[] poets { get; set; }
        public string baseUrl { get; set; }

        public HttpClient apiClient { get; set; }

        public PoemInfoCrawler()
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
            apiClient = new HttpClient(handler);
            apiClient.DefaultRequestHeaders.Accept.Clear();
            apiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            var task = apiClient.GetStringAsync("https://localhost:5001/api/poem/poets");
            poets = JsonConvert.DeserializeObject<string[]>(task.Result);
            foreach (string poet in poets)
            {
                Console.WriteLine(poet);
            }

            Console.ReadLine();
        }

        public string crawl(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                return html;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public void addPoet(string name)
        {
            string url = "https://baike.baidu.com/item/" + name;
            string html = crawl(url);
            HtmlDocument document = new HtmlDocument();
            document.LoadHtml(html);
            HtmlNode node = document.DocumentNode;
            HtmlNode para = node.CssSelect("div.para").FirstOrDefault();
            string rawIntro = para.InnerText;
            rawIntro = Regex.Replace(rawIntro,@"\[([1234567890-])+\]&nbsp;","");
            rawIntro = rawIntro.Replace("\n", "");

            HtmlNode img = node.CssSelect("img.picture").FirstOrDefault();
            string src;
            if (img != null)
            {
                src = img.GetAttributeValue("src", "https://bkimg.cdn.bcebos.com/pic/8c1001e93901213feb055d8250e736d12f2e95bd?x-bce-process=image/resize,m_lfit,w_220,limit_1/format,f_auto");
                Console.WriteLine(src);
            }
            else
            {
                src = "https://bkimg.cdn.bcebos.com/pic/8c1001e93901213feb055d8250e736d12f2e95bd?x-bce-process=image/resize,m_lfit,w_220,limit_1/format,f_auto";
            }

            Poet poet = new Poet(name, rawIntro, src);
            HttpContent content = new StringContent(JsonConvert.SerializeObject(poet));
            apiClient.PostAsync("https://localhost:5001/api/poet", content);
            
        }
       
    }
}
