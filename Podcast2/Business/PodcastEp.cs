using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast2.Business
{
    public class PodcastEp
    {
        public string Title { get; set; }
        public string Description { get; set; }



        public PodcastEp()
        {
        }



        public PodcastEp(string tit, string desc)
        {
            Title = tit;
            Description = desc;
        }
    }
}
