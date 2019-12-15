using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using SharedModels;
using System.Xml;
using Newtonsoft.Json;
using System.ServiceModel.Syndication;
//using static Data.Exceptions.SerializerExceptions;

namespace Data
{
   public class SerializedReaderWriter
    {



        WebClient client = new WebClient();

        public static List<PodcastShow> GetPodcastFeed(string url)
        {
            var count = 0;
            List<PodcastShow> podcastlista = new List<PodcastShow>();
            using (XmlReader reader = XmlReader.Create(url))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                foreach (SyndicationItem item in feed.Items)
                {

                    PodcastShow nypodd = new PodcastShow();

                    count++;
                    nypodd.Title += item.Title.Text; //funkar
                    nypodd.Url += item.Links[0].Uri.OriginalString; //funkar
                    nypodd.Description = item.Summary.Text;
                    nypodd.Category = nypodd.getCategory(); //funkar men tar med <p> taggar
                    podcastlista.Add(nypodd);


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
        public void Serialize(List<PodcastShow> Lists) { 

            try
            {
                var serializer = CreateSerializer();
                using (var sw = new StreamWriter("savedpodcasts.Json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        serializer.Formatting = Newtonsoft.Json.Formatting.Indented;
                        serializer.Serialize(jw, Lists);
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        public void SerializeCategory(List<Category> CategoryList)
        {

            try
            {
                var serializer = CreateSerializer();
                using (var sw = new StreamWriter("savedcategorys.Json"))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        serializer.Formatting = Newtonsoft.Json.Formatting.Indented;
                        serializer.Serialize(jw, CategoryList);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        public void Deserialize<PodcastShow>(string filename)
        {
            try
            {
                var serializer = CreateSerializer();
                using (var sr = new StreamReader(filename))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        var list = serializer.Deserialize<List<PodcastShow>>(jr);
                       
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
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
            setting.Async = true;
            //Deserialize<PodcastShow<GetPodcastFeed>>(url);


            XmlWriter writer = XmlWriter.Create(feed.Title.Text , setting);

            using (writer)
            {
                await
                    writer.WriteRawAsync(läsPod(url));
                writer.Flush();
                writer.Close();
            }


        }
        public string getPodcastTitleFromUrl(string url)
        {
            string title = "";
            try
            {
                var reader = XmlReader.Create(url);
                reader.ReadToFollowing("title");
                title = reader.ReadElementContentAsString();
                return title;
            }
            catch (Exception ex)
            {
                return title;
            } // måste skrivas om
        }

        public List<PodcastShow> getSparadPodcastListaFromJson()
        {
            List<PodcastShow> podcastLista = new List<PodcastShow>();
            try
            {

                var serializer = new JsonSerializer
                {
                    TypeNameHandling = TypeNameHandling.All
                };

                using (var sr = new StreamReader("sparadepodcasts.Json"))
                {
                    using (var jtr = new JsonTextReader(sr))
                    {
                        podcastLista = serializer.Deserialize<List<PodcastShow>>(jtr);
                        return podcastLista;
                    }

                }
            
             }
            catch (Exception ex)
            {
                return podcastLista;
            }
}
            
            //public string getkategori()
            //    {
            //        foreach (string Podcast in Directory.GetFiles(Directory.GetCurrentDirectory()))
            //            if (Podcast.Contains(".xml") && !Podcast.Contains("Newtonsoft"))
            //            {
            //                string kategorinamn = Path.GetFileName(Podcast);

                //                return kategorinamn;



                //        }



                //    }


                public string Pod(string url)
        {


            Stream stream = client.OpenRead(url);
            StreamReader reader = new StreamReader(stream);
            string xml = reader.ReadToEnd();
            return xml;



        }
    }
    //    public static void Write<PodcastShow>(string filename, PodcastShow data)
    //    {
    //        // TODO: Write data.Serialize() into filename using StreamWriter!
    //        using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
    //        {
    //            using (var sw = new StreamWriter(fs))
    //            {
    //                sw.Write(data.Serialize());
    //            }
    //        }

    //    }
    //    public string Serialize()
    //    {
    //        var lines = new List<string>();
    //        foreach (var item in this)
    //        {
    //            lines.Add(item.Serialize());
    //        }
    //        return string.Join("\n", lines.ToArray());
    //    }
    //    public void Deserialize(string serializedString)
    //    {
    //        var lines = serializedString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

    //        foreach (var line in lines)
    //        {
    //            try
    //            {
    //                Add(SerializeableFactory.FromString<T>(line));
    //            }
    //            catch (Exception ex)
    //            {
    //                throw ex as DeserializationException;
    //            }
    //        }
    //    }
}

