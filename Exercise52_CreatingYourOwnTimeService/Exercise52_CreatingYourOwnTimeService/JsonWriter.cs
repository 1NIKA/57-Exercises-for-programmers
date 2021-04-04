using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise52_CreatingYourOwnTimeService
{
    public class JsonWriter
    {
        public static void WriteCurrentDataInJson(string path)
        {
            HashSet<NikalaiTbiliskiTime> currentTime = new HashSet<NikalaiTbiliskiTime>()
            {
                new NikalaiTbiliskiTime 
                { 
                    CurrentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") 
                }       
            };

            using (StreamWriter file = File.CreateText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, currentTime);
            }
        }
    }
}