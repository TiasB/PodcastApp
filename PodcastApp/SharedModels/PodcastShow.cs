using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

//namespace SharedModels
//{
//    public class PodcastShow 
//    {
//        public string Title { get; set; }
//        public string Url { get; set; }

//        public string Description { get; set; }


//        public PodcastShow(string title, string url, string desc)
//        {
//            this.Title = title;
//            this.Url = url;
//            this.Description = desc;
          



//        }

//        public PodcastShow()
//        {

//        }

    
//    }
//    public class Poddlist : SerializeableList<PodcastShow> {
    
    
    
//    }
//    public class SerializeableList<T> : List<T>, ISerializeable where T : ISerializeable, new()
//    {
//        public string Serialize()
//        {
//            var lines = new List<string>();
//            foreach (var item in this)
//            {
//                lines.Add(item.Serialize());
//            }
//            return string.Join("\n", lines.ToArray());
//        }

//        public void Deserialize(string serializedString)
//        {
//            var lines = serializedString.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

//            foreach (var line in lines)
//            {
//                try
//                {
//                    Add(SerializeableFactory.FromString<T>(line));
//                }
//                catch (Exception ex)
//                {
//                    throw ex as DeserializationException;
//                }
//            }
//        }
//    }
//}
//}


  