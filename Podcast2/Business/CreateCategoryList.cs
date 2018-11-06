using Podcast2.Data;

namespace Podcast2.Business
{
    class CreateCategoryList
    {
        public static void AddCatList(string cat)
        {
            string category = cat;

            CategoryList.AddCat(category);

            CreateFile.CreateCategoryFile();
        }
    }
}
