using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace SharedModels
{
    public class PodcastShow
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public string Description { get; set; }
        public string Category { get; set; }


        public PodcastShow(string title, string url, string desc, string cat)
        {
            this.Title = title;
            this.Url = url;
            this.Description = desc;
            this.Category = cat;




        }

        public PodcastShow()
        {

        }
        public string getCategory()
        {
            return Category;
        }

    }
}



  