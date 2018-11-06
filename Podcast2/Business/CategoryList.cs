using System.Collections.Generic;
using System.Linq;

using Podcast2.Data;

namespace Podcast2.Business
{
    class CategoryList
    {
        public static List<string> CatList { get; set; }



        // Constructor
        public CategoryList()
        {
            CatList = new List<string>();
        }



        // Adds a category to CatList
        public static void AddCat(string cat)
        {
            CatList.Add(cat);
        }



        // Returns the CatList
        public static List<string> GetCatList()
        {
            return CatList;
        }



        // Deletes a specific category
        public static void DeleteCat(string cat)
        {
            for (int i = 0; i < CatList.Count; i++)
            {
                if (CatList.ElementAt(i).Equals(cat))
                {
                    CatList.RemoveAt(i);

                    CreateFile.CreateCategoryFile();
                }
            }
        }
    }
}
