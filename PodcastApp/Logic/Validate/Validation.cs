using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Validate
{
    class Validation
    {
        public static bool isEmpty(string text)
        {
            bool result = false;

            if (text.Equals("") || text.Equals(null))
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }

        public static bool isIndexNull(string selectedItem)
        {
            bool result = false;

            if (selectedItem == null)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            return result;
        }


    }
}
