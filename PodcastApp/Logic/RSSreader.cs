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
using 
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
        
        private JsonSerializer CreateSerializer()
        {
            return new JsonSerializer
            {
                TypeNameHandling = TypeNameHandling.All
            };
        }
        public void Serialize<PodcashShow>(string filename, List<PodcastShow> Lists)

        {
           PodcastShow Podcast = new PodcastShow();
            try
            {
                var serializer = CreateSerializer();
                using (var sw = new StreamWriter(filename))
                {
                    using (var jw = new JsonTextWriter(sw))
                    {
                        serializer.Formatting = Newtonsoft.Json.Formatting.Indented;
                        serializer.Serialize(jw, Podcast);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception(filename);
            }
        }
            
        public List<T> Deserialize<T>(string filename)
        {
            try
            {
                var serializer = CreateSerializer();
                using (var sr = new StreamReader(filename))
                {
                    using (var jr = new JsonTextReader(sr))
                    {
                        var list = serializer.Deserialize<List<T>>(jr);
                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void Write<T>(string filename, T data) where T : ISerializeable
        {
            // TODO: Write data.Serialize() into filename using StreamWriter!
            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.Write(data.Serialize());
                }
            }
        }
        public static T Read<T>(string filename) where T : ISerializeable, new()
        {
            var filecontent = "";

            using (var fs = new FileStream(filename, FileMode.Open))
            {
                using (var sr = new StreamReader(fs))
                {
                    filecontent = sr.ReadToEnd();
                }
            }

            if (!string.IsNullOrEmpty(filecontent))
            {
                try
                {
                    return SerializeableFactory.FromString<T>(filecontent);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
           
        }

    }
    public class vetej
    {
        static string dbFile = "data.txt";
        List<PodcastShow> podcastlista = new List<PodcastShow>();

        public static void bajs(string[] args)
        {
            PodcastShow podcast;
            if (File.Exists(dbFile))
            {
                try
                {
                    podcast = RSSreader.Read <> (dbFile);

                    Console.WriteLine("Read " + books.Count + " books from file");

                    foreach (var book in books)
                    {
                        Console.WriteLine(book.Author);
                        Console.WriteLine(book.Title);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                books = new BookList {
                    new Book { Author = "Douglas Adams", Title = "The Hitch Hiker's Guide to the Galaxy"},
                    new Book { Author = "Douglas Adams", Title = "Dirk Gently's Holistic Detective Agency"}
                };

                // TODO: Handle exceptions!
                try
                {
                    SerializedReaderWriter.Write<BookList>(dbFile, books);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Serialization failed!");
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }









}
}
