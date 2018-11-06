using System.Collections.Generic;
using System.Linq;

using Podcast2.Data;

namespace Podcast2.Business
{
    class PodcastList
    {
        public static List<Podcast> PodList { get; set; }



        // Contructor
        public PodcastList()
        {
            PodList = new List<Podcast>();
        }



        // Adds a podcast to the PodList
        public static void AddPodcast(Podcast pod)
        {
            PodList.Add(pod);
        }



        // Returns the PodList
        public static List<Podcast> GetPodList()
        {
            PodList.Reverse();

            return PodList;
        }



        // Deleted a specific podcast
        public static void DeletePod(string title)
        {
            for (int i = 0; i < PodList.Count(); i++)
            {
                if (PodList.ElementAt(i).Title == title)
                {
                    PodList.RemoveAt(i);
                }
            }
        }
    }
}
