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
    public  class PodcastShow
    {
        public string Title { get; set; }
        public string Url { get; set; }

        public string Description { get; set; }

        public string Kategori { get; set; }

        public PodcastShow(string title, string url,  string desc, string kat)
       {
            this.Title = title;
            this.Url = url;
            this.Description = desc;
            this.Kategori = kat;

           

       }

        public PodcastShow()
        {
            
        }
        //public string Serialize()
        //{
        //    var lines = new List<PodcastShow>();
        //    foreach (var item in lines)
        //    {
        //        lines.Add(item.Serialize());
        //    }
        //    return string.Join("\n", lines.ToArray());
        //}
        //public static void Write<PodcastShow>(string filename, PodcastShow data)
        //{
        //    // TODO: Write data.Serialize() into filename using StreamWriter!
        //    using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
        //    {
        //        using (var sw = new StreamWriter(fs))
        //        {
        //            sw.Write(data.Serialize());
        //        }
        //    }

        //}
        //public string Serialize()
        //{
        //    var lines = new List<string>();
        //    foreach (var item in this)
        //    {
        //        lines.Add(item.Serialize());
        //    }
        //    return string.Join("\n", lines.ToArray());
        //}
        //public void Deserialize(string serializedString)
        //{
        //    var lines = serializedString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

        //    foreach (var line in lines)
        //    {
        //        try
        //        {
        //            Add(SerializeableFactory.FromString<T>(line));
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex as DeserializationException;
        //        }
        //    }
        //}
        //    public static List<PodcastShow> ReadPodcastsFromFile(string filepath)
        //    { 


        //        if (!File.Exists(filepath)) return new List<PodcastShow>();

        //        string json = File.ReadAllText(filepath);
        //        return JsonConvert.DeserializeObject<List<PodcastShow>>(json);
        //    }

        //        public static void WritePodcastsToFile(List<PodcastShow> podcasts, string filepath) {
        //        //System.UnauthorizedAccessException: 'Åtkomst till sökvägen C:\Users\9805phsa\Documents\GitHub\PodcastApp\PodcastApp\GUI\bin\Debug nekas.'
        //        File.WriteAllText(filepath, JsonConvert.SerializeObject(podcasts));
        //        using (StreamWriter file = File.CreateText(Path.Combine(Environment.CurrentDirectory)))
        //        {
        //            JsonSerializer serializer = new JsonSerializer();
        //            serializer.Serialize(file, podcasts);

        //        }
        //        }

        //    public void SaveFile(PodcastShow podcast)
        //    {

        //        string fileName = "PodcastApp";
        //        string filepath = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
        //        List<PodcastShow> podcasts = ReadPodcastsFromFile(filepath);
        //        podcasts.Add(podcast);
        //        WritePodcastsToFile(podcasts, filepath);

        //    }

    }
}
  