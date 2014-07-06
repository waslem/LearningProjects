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
            string website = "http://www.westnet.com.au";

            var source = Helpers.GetWebsiteSource(website);

            var robots = Helpers.GetWebsiteRobotsTxt(website);

            var links = Helpers.GetWebsiteLinks(source);


            Console.WriteLine(robots);
            Console.WriteLine();
        }
    }
}
