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
    public class Logik
    {
        public List<Category> allaKategorier { get; set; }
        public SerializedReaderWriter SerDeser { get; set; }
        public List<PodcastShow> Podcasts { get; set; }


        public Logik()
        {
            allaKategorier = new List<Category>();
            SerDeser = new SerializedReaderWriter();
            Podcasts = new List<PodcastShow>();

        }

        public void nyKategori(string Kategorinamn)
        {
            Category enKategori = new Category(Kategorinamn);
            läggTillKategori(enKategori);
            
        }
        public void läggTillKategori(Category nykategori)
        {
            allaKategorier.Add(nykategori);
        }
        public void saveCategoryList()
        {
            SerDeser.SerializeCategory(allaKategorier);
        }
        public void nyPodcast(string category, string url)
        {
            PodcastShow newPodcast = new PodcastShow(url, category);
            addNyPodcastToList(newPodcast);
        }

        private void addNyPodcastToList(PodcastShow newPodcast)
        {
            Podcasts.Add(newPodcast);
        }
        private List<PodcastShow> getPodcastListByName(string name)
        {
            return Podcasts
                               .Where(pod => pod.Title.Equals(name))
                               .ToList();
        }
        public List<string> getPodcastEpisodesToString(string name)
        {
            List<string> allEpisodesToString = new List<string>();
            var sortedPodcastListByName = getPodcastListByName(name);

            foreach (var podcast in sortedPodcastListByName)
            {
          
                foreach (PodcastShow pod in Podcasts)
                {
                    string EpisodeTitle = pod.Title.ToString();
                    allEpisodesToString.Add(EpisodeTitle);
                }
            }
            return allEpisodesToString;
        }
        public string getUrlfromPodcast(string name)
        {
            var sortedList = getPodcastListByName(name);
            var url = "";

            foreach (var pod in sortedList)
            {
                url = pod.Url;


            }

            return url;
        }
        public List<List<string>> ConvertPodcastListToString(string val)
        {
            var podcastlista = new List<PodcastShow>();

            switch (val)
            {
                case "HelaListan":
                    podcastlista = Podcasts;
                    break;
            }
            var allPodcastsInString = new List<List<string>>();
            var podcastProperty = new List<string>();

            foreach (PodcastShow podcast in podcastlista)
            {
                var kategori = podcast.Category;

                var name = podcast.Title;

                podcastProperty.Add(name);

                podcastProperty.Add(kategori);

                allPodcastsInString.Add(podcastProperty);

            }
            return allPodcastsInString;
        }

    }//logik

}

