using Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Media : IHasAName
    {
        public string Name { get; set; }
        protected virtual int getCountOfList()
        {
            int count = 0;
            return count;
        }
    }
}
