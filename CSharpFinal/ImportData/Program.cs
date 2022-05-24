using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ImportData
{
    public class Program
    {
        static void Main()
        {
            using (var db=new PoemContext())
            {
                for (int i = 1; i <= 100; i++)
                {
                    string path = $"json\\" + (i / 100) + ((i % 100) / 10) + (i % 10) + ".json";
                    List<RawPoem> rawPoems = ReadPoem(path);
                    rawPoems.ForEach(rawPoem =>
                    {
                        Poem poem = new Poem(rawPoem.title, rawPoem.author, rawPoem.biography, rawPoem.volume);
                        rawPoem.paragraphs.ForEach(paragragh =>
                        {
                            poem.paragraphs.Add(new Paragraph(paragragh));
                        });
                        db.Poems.Add(poem);
                        db.SaveChanges();
                        Console.WriteLine(i);
                    });
                }
                db.SaveChanges();
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

    }
}
