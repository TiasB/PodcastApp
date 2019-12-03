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
        public List<Kategori> allaKategorier { get; set; }


        public Logik()
        {
            allaKategorier = new List<Kategori>();

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
        public void bajs(string bajs)
        {
            Console.WriteLine(bajs);
        }
    }//logik

}

