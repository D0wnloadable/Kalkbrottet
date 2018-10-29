using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast2.Business
{
    public class Podcast
    {
        public int Episodes { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int Frequency { get; set; }



        public Podcast()
        {
        }



        public Podcast(int ep, string tit, string cat, int freq)
        {
            Episodes = ep;
            Title = tit;
            Category = cat;
            Frequency = freq;
        }
    }
}
