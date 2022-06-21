using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Microsoft.VisualBasic;
using ChineseT2S;
using Models;

namespace ImportData
{
    public class Program
    {
        static void Main()
        {
            string baseUrl = "https://localhost:5001/api/poem";
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (message, cert, chain, err) => true;
            HttpClient client = new HttpClient(handler);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            for (int i = 1; i <= 900; i++)
            {
                string path = $"json\\" + (i / 100) + ((i % 100) / 10) + (i % 10) + ".json";
                List<RawPoem> rawPoems = ReadPoem(path);
                rawPoems.ForEach(rawPoem =>
                {
                    Poem poem = new Poem(
                        ConvertString(rawPoem.title), 
                        ConvertString(rawPoem.author), 
                        ConvertString(rawPoem.biography), 
                        ConvertString(rawPoem.volume) 
                       );                  

                    for(int j = 0; j < rawPoem.paragraphs.Count; j++)
                    {
                        poem.paragraphs.Add(new Paragraph(ConvertString(rawPoem.paragraphs[j]),j));
                    }
                    
                  
                HttpContent content = new StringContent(JsonConvert.SerializeObject(poem), Encoding.UTF8, "application/json");
                var task = client.PostAsync(baseUrl, content);
                    Console.WriteLine(i);
                });
            }

            
        }

        public static List<RawPoem> ReadPoem(string path)
        {
            ;
            string json = "";
            using (StreamReader sr = new StreamReader(path))
            {
                json = sr.ReadToEnd();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            List<RawPoem> result = serializer.Deserialize<List<RawPoem>>(json);
            return result;

        }

        //繁体字换简体字
        public static string ConvertString(string s)
        {
            return T2SUtility.ToSimplified(s);
        }


    }
}
