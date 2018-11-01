﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podcast2.Data;

namespace Podcast2.Business
{
    class CategoryList
    {
        public static List<Category> CatListt { get; set; }
        public static List<string> CatList { get; set; }



        public CategoryList()
        {
            CatListt = new List<Category>();
            CatList = new List<string>();
        }



        public static void AddCat(string cat)
        {
            CatList.Add(cat);
        }



        public static List<string> GetCatList()
        {
            return CatList;
        }



        public static void DeleteCat(string cat)
        {
            for (int i = 0; i < CatList.Count; i++)
            {
                if (CatList.ElementAt(i).Equals(cat))
                {
                    CatList.RemoveAt(i);

                    SaveFile.SaveCategory();
                }
            }
            //CatList.RemoveAll(i => i.Name == c);

            //SaveFile.SaveCategory();
        }
    }
}
