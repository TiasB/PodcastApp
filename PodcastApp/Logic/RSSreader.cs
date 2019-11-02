using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using Data;
using Newtonsoft.Json;
using SharedModels;
namespace Logic
{
   public class RSSreader
    {
        public static List<PodcastShow> GetPodcastFeed(string url)
    {
        var count = 0;
        List<PodcastShow> podcastlista = new List<PodcastShow>();
        //string rssfeedurl = "http://borssnack.libsyn.com/rss";
        using (XmlReader reader = XmlReader.Create(url))
        {
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            foreach (SyndicationItem item in feed.Items)
            {

                PodcastShow nypodd = new PodcastShow();
                count++;
                nypodd.Title += item.Title.Text; //funkar
                nypodd.Url += item.Links[0].Uri.OriginalString; //funkar
                nypodd.Description = item.Summary.Text; //funkar men tar med <p> taggar
                podcastlista.Add(nypodd);
                   string x = podcastlista.ToString();
                }

                return podcastlista;
        }

    }
    }
}
