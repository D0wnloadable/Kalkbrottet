using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podcast2.Data;

namespace Podcast2.Business
{
    class CategoryList
    {
        public static List<Category> CatList { get; set; }



        public CategoryList()
        {
            CatList = new List<Category>();
        }



        public static void AddCat(Category cat)
        {
            CatList.Add(cat);
        }



        public static List<Category> GetCatList()
        {
            return CatList;
        }



        public static void DeleteCat(string c)
        {
            CatList.RemoveAll(i => i.Name == c);

            SaveFile.SaveCategory();
        }
    }
}
