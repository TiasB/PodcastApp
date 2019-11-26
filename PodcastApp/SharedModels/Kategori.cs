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
        {  Kategori kategorin = new Kategori();
            List<Kategori> kategorilista = new List<Kategori>();

            foreach (Kategori x in kategorilista)
            {
                

                kategorilista.Add(kategorin);

            }
            return kategorilista;
        }
    }
}

