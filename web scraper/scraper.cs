using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;
using HtmlAgilityPack;

namespace web_scraper
{
    class scraper
    {
        //load the http of the page
        private HtmlDocument loadhttp(string s)
        {
           HtmlWeb web = new HtmlWeb();
                HtmlDocument doc = web.Load(s);

           
            return doc;
        }

            //Generate the list of all sites in that domain
     /*   private List<String>  generatesites(string domain)
        {
            return 
        } */
        //scrapes the site and loads into the model variables

        

        public void scrapesite(Queue <string> q1)
        {
             int i = 0;
             List<outputmodel> lstapps = new List<outputmodel>(); 

            Parallel.ForEach(q1, q =>
         {
            while (i < 1000)
           {
            string a = q1.Dequeue();
            HtmlDocument html = loadhttp(a); 
         //This code is to debug if there are any issues with Dequeuing etc.    
            /*string abc = html.DocumentNode.OuterHtml;
            System.Console.WriteLine(abc);
            System.IO.StreamWriter file = new System.IO.StreamWriter("e:\\test.txt");
            file.WriteLine(abc);*/
           foreach (HtmlNode nodes in html.DocumentNode.SelectNodes("//a"))
            {
               // System.Console.WriteLine(nodes.Attributes["href"].Value);
               if (nodes.Attributes["href"].Value.Contains("store/apps/details?id=") == true )
               {
                   q1.Enqueue("https://play.google.com/" + nodes.Attributes["href"].Value);
                  // System.Console.WriteLine("https://play.google.com/" + nodes.Attributes["href"].Value);
               }
            }
            
          // Catch exception, if so replace div with h1
           try
           {
               HtmlNode node = html.DocumentNode.SelectSingleNode("//div[@class=\"document-title\"]//div");
               System.Console.WriteLine("B" + node.InnerText);
           }
           catch
           {
               try
               {
                   HtmlNode node = html.DocumentNode.SelectSingleNode("//h1[@class=\"document-title\"]//div");
                   System.Console.WriteLine("A" +node.InnerText);
                }
               catch (Exception ex)
               {
                   System.Console.WriteLine(ex);
               }
           }
          //  
  /*          
            HtmlNode node1 = html.DocumentNode.SelectSingleNode("//a[@class=\"document-subtitle primary\"]//span");
            System.Console.WriteLine(node1.InnerText);
            HtmlNode node2 = html.DocumentNode.SelectSingleNode("//a[@class=\"document-subtitle category\"]//span");
            System.Console.WriteLine(node2.InnerText);

            HtmlNode node3 = html.DocumentNode.SelectSingleNode("//span[@class=\"reviews-num\"]");
            System.Console.WriteLine(node3.InnerText);
            HtmlNode node4 = html.DocumentNode.SelectSingleNode("//div[@class=\"score\"]");
            System.Console.WriteLine(node4.InnerText);
            HtmlNode node5 = html.DocumentNode.SelectSingleNode("//div[@itemprop=\"numDownloads\"]");
            System.Console.WriteLine(node5.InnerText);
*/
         /*   foreach (string s in q1)
            {
                Console.WriteLine(s);
            }*/

               i++;
           }
            //string ch = (string)q.Dequeue();
          //  Console.WriteLine("The removed value: {0}", ch);
           /*
            HtmlNode node3 = html.DocumentNode.SelectSingleNode("//div[@class=\"document-subtitle info-star-rating\"]//span");
            System.Console.WriteLine(node3.InnerText);
            */
            // http://stackoverflow.com/questions/28100914/get-values-of-htm-tags-with-htmlagilitypack  
    
         });
        }
    }
}   
