using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast2.Business
{
    class PodcastList
    {
        public static List<Podcast> PodList { get; set; }



        public PodcastList()
        {
            PodList = new List<Podcast>();
        }



        public static void AddPodcast(Podcast pod)
        {
            PodList.Add(pod);
        }



        public static List<Podcast> GetPodList()
        {
            PodList.Reverse();

            return PodList;
        }
    }
}
