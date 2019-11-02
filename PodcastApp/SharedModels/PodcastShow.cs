using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
        public static List<PodcastShow> ReadPodcastsFromFile(string filepath)
        { 


            if (!File.Exists(filepath)) return new List<PodcastShow>();

            string json = File.ReadAllText(filepath);
            return JsonConvert.DeserializeObject<List<PodcastShow>>(json);
        }

            public static void WritePodcastsToFile(List<PodcastShow> podcasts, string filepath) { 
                // This will overwrite the file if it exists, or create a new one if it doesn't
                File.WriteAllText(filepath, JsonConvert.SerializeObject(podcasts));
            using (StreamWriter file = File.CreateText(Path.Combine(Environment.CurrentDirectory)))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, podcasts);
                //bajs
            }
            }
        
        public void SaveFile(PodcastShow podcast)
        {
         
            string fileName = "PodcastApp";
            string filepath = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            List<PodcastShow> podcasts = ReadPodcastsFromFile(filepath);
            podcasts.Add(podcast);
            WritePodcastsToFile(podcasts, filepath);

        }

    }
}
  