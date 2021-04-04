using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercise47_Who_sInSpace
{
    public class ApiParser
    {
        public static Dictionary<dynamic, dynamic> ParseAPI()
        {
            var namesWithCrafts = new Dictionary<dynamic, dynamic>();

            using (var webClient = new WebClient())
            {
                var json = webClient.DownloadString("http://api.open-notify.org/astros.json");

                JObject obj1 = JObject.Parse(json);
                dynamic obj2 = obj1;

                for (int i = 0; i < obj2.people.Count; i++)
                {
                    namesWithCrafts.Add(obj2.people[i].name, obj2.people[i].craft);
                }
            }

            return namesWithCrafts;
        }
    }
}
