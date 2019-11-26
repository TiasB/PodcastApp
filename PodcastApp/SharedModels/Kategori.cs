using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Kategori
    {
        public string KategoriNamn { get; set; }
        public Kategori(string kategorinamn)
        {
            this.KategoriNamn = kategorinamn;
        }
        public Kategori()
        {

        }
        public static List<Kategori> AddkategoriToList(string Kategorinamnet)
        {
            List<Kategori> kategorilista = new List<Kategori>();

            foreach (kategorinamnet in kategorilista)
            {
                Kategori kategorin = new Kategori();

                count++;
                nypodd.Title += item.Title.Text; //funkar
                nypodd.Url += item.Links[0].Uri.OriginalString; //funkar
                nypodd.Description = item.Summary.Text;
                nypodd.Kategori = nypodd.getKategori(); //funkar men tar med <p> taggar
                podcastlista.Add(nypodd);

            }
        }
    }
}

