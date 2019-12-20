using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Interfaces;

namespace SharedModels
{
    public class Category 
    {
        public string CategoryName { get; set; }
        public Category(string categoryname)
        {
            this.CategoryName = categoryname;
        }
        public Category()
        {

        }
        public static List<Category> AddCategoryToList(string categoryname)
        {  Category category = new Category();
            List<Category> categorylist = new List<Category>();

            foreach (Category x in categorylist)
            {
                

                categorylist.Add(category);

            }
            return categorylist;
        }
    }
}

