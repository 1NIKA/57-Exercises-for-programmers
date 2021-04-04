using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise52_CreatingYourOwnTimeService
{
    public class JsonReader
    {
        public static void ReadCurrentDataInJson(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd().Replace('[', ' ').Replace(']', ' ');
                dynamic time = JObject.Parse(json);

                DateTime date = DateTime.ParseExact(time.CurrentTime.ToString(), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
                Console.WriteLine("The current time is " + date.ToString("HH:mm:ss UTC MMMM dd yyyy", CultureInfo.InvariantCulture));
            }
        }
    }
}
