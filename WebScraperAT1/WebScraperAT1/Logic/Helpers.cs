using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
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
        internal static List<Link> GetWebsiteLinks(string source)
        {
            string[] separator = { "\r\n" };

            // split at \r\n
            var lines = source.Split(separator,10000, StringSplitOptions.RemoveEmptyEntries);

            List<Link> links = new List<Link>();

            Regex ahref = new Regex("(?i)<a([^>]+)>(.+?)</a>");

            foreach (var line in lines)
	        {
                var link = new Link();

                var matches = Regex.Matches(line, "<a[^>]*? href=\"(?<url>[^\"]+)\"[^>]*?>(?<text>.*?)</a>", RegexOptions.Singleline);
                
                foreach (Match match in matches)
	            {
		            link.LinkAddress = match.Groups["url"].Value;
                    link.LinkText = match.Groups["text"].Value;
                    links.Add(link);
	            }

	        }

            return links;
        }

        /// <summary>
        /// gets websites robot.txt file, assumes it is in www.website.com/robots.txt
        /// </summary>
        /// <param name="website">website for request</param>
        /// <returns>string containing robots.txt file</returns>
        internal static object GetWebsiteRobotsTxt(string website)
        {
            try
            {
                WebRequest request = HttpWebRequest.Create(website + "/robots.txt");

                var response = request.GetResponse();

                var stream = response.GetResponseStream();

                StreamReader reader = new StreamReader(stream);

                string robots = reader.ReadToEnd();

                return robots;
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is no robots.txt file for this website. Error: " + ex.Message);
                return null;
            }

        }
    }
}
