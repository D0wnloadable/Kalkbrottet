using System.Collections.Generic;

using Podcast2.Data;

namespace Podcast2.Business
{
    class EpisodeList
    {
        public static List<Episode> EpList { get; set; }



        // Constructor
        public EpisodeList()
        {
            EpList = new List<Episode>();
        }



        // Add an episode to EpList
        public static void AddEpisode(Episode ep)
        {
            EpList.Add(ep);
        }



        // Returns the EpList
        public static List<Episode> GetEpList()
        {
            return EpList;
        }



        // Returns a list of episode titles
        public static List<string> GetEpTitle()
        {
            List<string> list = new List<string>();

            foreach (Episode title in EpList)
            {
                list.Add(title.Title);
            }

            return list;
        }



        // Deletes episodes based on the podcast title
        public static void DeleteEpisodes(string title)
        {
            EpList.RemoveAll(e => e.PodTitle.Equals(title));
        }
    }
}
