using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise43_WebsiteGenerator
{
    public class IndexCsHtml
    {
        public static void CreateIndexHtmlFile(string path, string name, string author)
        {
            string html = path + @"\index.html";

            List<string> htmlCode = new List<string>()
            {
                "<!DOCTYPE html>",
                "<html>",
                "<head>",
                    $"<title>{name}</title>",
                "</head>",
                "<body>",
                    $"<h1>{author}</h1>",
                "</body>",
                "</html>"
            };

            File.WriteAllLines(html, htmlCode);
        }
    }
}