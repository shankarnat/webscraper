using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class defines the various parameters to be stored from each of the webpages. 

namespace web_scraper
{
    public class outputmodel
    {
        public string appName { get; set; }
        public string appCompany { get; set; }
        public string appCategory { get; set; }
        public string reviewsNum { get; set; }
        public string reviewsScore { get; set; }
        public string numDownloads { get; set; }

        public outputmodel(string appName, string appCompany, string appCategory, string reviewsNum, string reviewsScore, string numDownloads)
        {
            this.appName = appName;
            this.appCompany = appCompany;
            this.appCategory = appCategory;
            this.reviewsNum = reviewsNum;
            this.reviewsScore = reviewsScore;
            this.numDownloads = numDownloads;
        }
    }
}
