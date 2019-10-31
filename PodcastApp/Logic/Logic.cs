using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Data;
using SharedModels;

namespace Logic
{
    public class Logic
    {
        //public static List<PodcastShow> GetPodcastFeed()
        //{
        //    List<PodcastShow> Podcastlista = new List<PodcastShow>();
        //    string rssFeedurl = "http://borssnack.libsyn.com/rss";
        //    using (XmlReader reader = XmlReader.Create(rssFeedurl))
        //    {
        //        SyndicationFeed feed = SyndicationFeed.Load(reader);
        //        foreach (SyndicationItem item in feed.Items)
        //        {
        //            PodcastShow nyPodd = new PodcastShow();
        //            nyPodd.Title += item.Title.Text; //funkar
        //            nyPodd.Url += item.Links[0].Uri.OriginalString; //funkar
        //            nyPodd.Description = item.Summary.Text; //funkar men tar med <p> taggar
        //            Podcastlista.Add(nyPodd);
        //        }
        //        return Podcastlista;
        //    }
        //}
    }
}
