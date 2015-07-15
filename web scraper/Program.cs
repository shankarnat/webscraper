using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace web_scraper
{
    class Program
    {
        static void Main(string[] args)
        {
            scraper scraperobj = new scraper();

            Queue<string> q = new Queue<string>();
            q.Enqueue("https://play.google.com/store/apps/details?id=com.flipkart.android");

            q.Enqueue("https://play.google.com/store/apps/details?id=com.snapdeal.main");
            q.Enqueue("https://play.google.com/store/apps/details?id=com.myntra.android");
            q.Enqueue("https://play.google.com/store/apps/details?id=com.ebay.mobile");
            q.Enqueue("https://play.google.com/store/apps/details?id=com.microsoft.office.onenote");

                                               q.Enqueue("https://play.google.com/store/apps/details?id=com.rovio.angrybirds");
                             q.Enqueue("https://play.google.com/store/apps/details?id=com.july.ndtv&hl=en");
                                               q.Enqueue("https://play.google.com/store/apps/details?id=com.application.zomato&hl=en");
                                  
            scraperobj.scrapesite(q);
            System.Console.ReadLine();
            
            //read the list of sites
            
        }
    }
}
