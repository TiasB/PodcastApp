using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public  class PodcastShow
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public string Description { get; set; }

        public PodcastShow(string title, string url,  string desc)
       {
            this.Title = title;
            this.Url = url;
            this.Description = desc;
       }

        public PodcastShow()
        {
            
        }
    }
}
