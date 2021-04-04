using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise51_PushingNotesToFirebase
{
    public class JsonWriter
    {   
        public static void WriteTextToJson(string path, string note)
        {
            using (StreamWriter file = File.AppendText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, GetNotes(note));


            }
        }

        private static Dictionary<string, List<Notes>> ReadTextToJson(string path)
        {
            StreamReader r = new StreamReader(path);

            string jsonString = r.ReadToEnd();
            r.Close();

            dynamic jsonDyn = JObject.Parse(jsonString);

            List<Notes> list1 = new List<Notes>();

            foreach (var item in jsonDyn.ListofNodes)
            {
                list1.Add(new Notes()
                {
                    Note = item.Note,
                    Date = DateTime.Now
                });
            }

            Dictionary<string, List<Notes>> information = new Dictionary<string, List<Notes>>
            {
                { "ListofNodes", list1 }
            };
            
            return information;
        }

        private static List<Notes> GetNotes(string note)
        {
            List<Notes> notes = new List<Notes>
            {
                new Notes()
                {
                    Note = note,
                    Date = DateTime.Now
                }
            };

            return notes;
        }
    }  
}