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

        //public static bool checkIfPodcastShowExists(string url, Bll bLL)
        //{
        //    bool result= false;
        //    Logik logik = new logik();
        //    logik = ;
        //    foreach (var pod in logik.allaPodcasts)
        //    {
        //        if (pod.Url.Equals(url))
        //        {
        //            result = true;
        //        }
        //    }
        //    return result;
        //}

        public static bool thereIsNoCategoryToModify(int index)//Om kategorin har intex 0 så finns den inte. 
        {
            bool result = false;

            if (index == 0)
            {
                result = true;
                return result;
            }
            return result;
        }

        public static bool ThereIsNoCategoryToRemove(int index)
        {
            bool resultat = false;
            if (index == 0)
            {
                resultat = true;
                return resultat;

            }
            return resultat;
        }
    }
}
