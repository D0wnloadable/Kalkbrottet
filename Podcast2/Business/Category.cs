﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast2.Business
{
    public class Category
    {
        public string Name { get; set; }



        public Category()
        {
        }



        public Category(string cat)
        {
            Name = cat;
        }
    }
}
