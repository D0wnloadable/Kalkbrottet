using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast2.Business
{
    public class PodcastEp
    {
        public string PodTitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }



        public PodcastEp()
        {
        }



        public PodcastEp(string podTit,string tit, string desc)
        {
            PodTitle = podTit;
            Title = tit;
            Description = desc;
        }
    }
}
