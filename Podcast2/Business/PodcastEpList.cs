using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podcast2.Business
{
    class PodcastEpList
    {
        public static List<PodcastEp> EpisodeList { get; set; }



        public PodcastEpList()
        {
            EpisodeList = new List<PodcastEp>();
        }



        public static void AddEpisode(PodcastEp ep)
        {
            EpisodeList.Add(ep);
        }



        public static List<PodcastEp> GetEpList()
        {
            return EpisodeList;
        }



        public static List<string> GetEpTitle()
        {
            List<string> list = new List<string>();

            foreach (PodcastEp title in EpisodeList)
            {
                list.Add(title.Title);
            }

            return list;
        }
    }
}
