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



        public static void AddEpisode(PodcastEp episode)
        {
            EpisodeList.Add(episode);
        }



        public static List<PodcastEp> GetList()
        {
            EpisodeList.Reverse();

            return EpisodeList;
        }
    }
}
