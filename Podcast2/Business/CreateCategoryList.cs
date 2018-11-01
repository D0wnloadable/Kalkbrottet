using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podcast2.Data;

namespace Podcast2.Business
{
    class CreateCategoryList
    {
        public static void AddCatList(string cat)
        {
            string category = cat;

            CategoryList.AddCat(category);

            SaveFile.SaveCategory();
        }
    }
}
