using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebScraperAT1.Logic
{
    public static class Helpers
    {
        /// <summary>
        /// retrieves the specified website's source code
        /// </summary>
        /// <param name="url">the website we wish to get source for</param>
        /// <returns>string containing source code</returns>
        public static string GetWebsiteSource(string url)
        {

            // create the request
            WebRequest request = HttpWebRequest.Create(url);

            // get the response from the server
            WebResponse response = request.GetResponse();

            Stream stream = response.GetResponseStream();

            StreamReader reader = new StreamReader(stream);

            string result = reader.ReadToEnd();

            return result;
        }

        /// <summary>
        /// finds all html links in a websites source
        /// </summary>
        /// <param name="source">source code of website</param>
        /// <returns>list of strings containing links</returns>
        internal static List<string> FindWebsiteLinks(string source)
        {
            string[] separator = { "\r\n" };

            // split at \r\n
            var lines = source.Split(separator,10000, StringSplitOptions.RemoveEmptyEntries);

            List<string> links = new List<string>();

            foreach (var line in lines)
            {
                if (line.Contains("<a href="))
                {
                    links.Add(line.Trim());
                }
            }

            return links;
        }
    }
}
