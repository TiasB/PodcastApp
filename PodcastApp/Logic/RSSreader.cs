using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
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
        WebClient client = new WebClient();

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

        private JsonSerializer CreateSerializer()
        {
            return new JsonSerializer
            {
                TypeNameHandling = TypeNameHandling.All
            };
        }
        //public void Serialize<PodcashShow>(string filename, List<PodcastShow> Lists)

        //{
        //   PodcastShow Podcast = new PodcastShow();
        //    try
        //    {
        //        var serializer = CreateSerializer();
        //        using (var sw = new StreamWriter(filename))
        //        {
        //            using (var jw = new JsonTextWriter(sw))
        //            {
        //                serializer.Formatting = Newtonsoft.Json.Formatting.Indented;
        //                serializer.Serialize(jw, Podcast);
        //            }
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw new Exception(filename);
        //    }
        //}
            
        //public List<T> Deserialize<T>(string filename)
        //{
        //    try
        //    {
        //        var serializer = CreateSerializer();
        //        using (var sr = new StreamReader(filename))
        //        {
        //            using (var jr = new JsonTextReader(sr))
        //            {
        //                var list = serializer.Deserialize<List<T>>(jr);
        //                return list;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
        public string läsPod(string url)
        {
           

            Stream stream = client.OpenRead(url);
            StreamReader reader = new StreamReader(stream);
            string xml = reader.ReadToEnd();
            return xml;


        }
        public async Task sparaPodd(string url)
        {
            Stream stream = client.OpenRead(url);
            XmlReader reader = XmlReader.Create(stream);
            SyndicationFeed feed = SyndicationFeed.Load(reader);

            XmlWriterSettings setting = new XmlWriterSettings();
            setting.Async= true;

            XmlWriter writer = XmlWriter.Create(feed.Title.Text + ".xml", setting);

            using (writer)
            {
                await
                    writer.WriteRawAsync(läsPod(url));
                writer.Flush();
                writer.Close();
            }


        }
        public string Pod(string url)
        {


            Stream stream = client.OpenRead(url);
            StreamReader reader = new StreamReader(stream);
            string xml = reader.ReadToEnd();
            return xml;


        }
    }

}
