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

            string source = Helpers.GetWebsiteSource("http://www.baycorp.com.au");

            List<string> links = Helpers.FindWebsiteLinks(source);

            foreach (var link in links)
            {
                Console.WriteLine(link);
            }

            Console.WriteLine();
        }
    }
}
