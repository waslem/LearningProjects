using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebScraperAT1.Logic;

namespace WebScraperAT1
{
    class Program
    {
        static void Main(string[] args)
        {
            string website = "http://www.baycorp.com.au";

            var source = Helpers.GetWebsiteSource(website);

            var robots = Helpers.GetWebsiteRobotsTxt(website);

            List<Link> links = Helpers.GetWebsiteLinks(source);

            Console.WriteLine(robots);

            DisplayLinks(links);
            Console.WriteLine();
        }

        public static void DisplayLinks(List<Link> links)
        {
            foreach (var link in links)
            {
                Console.WriteLine("Link address:    " + link.LinkAddress);
                Console.WriteLine("Link text:       " + link.LinkText);
            }
        }
    }
}
