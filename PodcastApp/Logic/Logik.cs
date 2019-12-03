﻿using System;
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
        public List<Kategori> allaKategorier { get; set; }
        public SerializedReaderWriter SerDeser { get; set; }
        public List<PodcastShow> Podcasts { get; set; }


        public Logik()
        {
            allaKategorier = new List<Kategori>();
            SerDeser = new SerializedReaderWriter();

        }

        public void nyKategori(string Kategorinamn)
        {
            Kategori enKategori = new Kategori(Kategorinamn);
            läggTillKategori(enKategori);
            
        }
        public void läggTillKategori(Kategori nykategori)
        {
            allaKategorier.Add(nykategori);
        }
        public void saveCategoryList()
        {
            SerDeser.SerializeCategory(allaKategorier);
        }
        public void nyPodcast(string titel, string kategori, string url, string desc)
        {
            PodcastShow newPodcast = new PodcastShow(url, kategori, titel, desc);
            addNyPodcastToList(newPodcast);
        }

        private void addNyPodcastToList(PodcastShow nyPodcast)
        {
            Podcasts.Add(nyPodcast);
        }

    }//logik

}

