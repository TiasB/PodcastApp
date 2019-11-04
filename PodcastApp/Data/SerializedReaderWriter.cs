using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static Data.Exceptions.SerializerExceptions;

namespace Data
{
    class SerializedReaderWriter
    {
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
}
