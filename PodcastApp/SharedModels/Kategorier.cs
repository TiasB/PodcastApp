using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModels
{
    public class Kategorier
    {
        public string KategoriNamn { get; set; }
        public Kategorier(string kategoriNamn)
        {
            this.KategoriNamn = kategoriNamn;
        }
    }
}
