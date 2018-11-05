using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podcast2.Data;

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



        public static void DeletePod(string title)
        {
            for (int i = 0; i < PodList.Count(); i++)
            {
                if (PodList.ElementAt(i).Title == title)
                {
                    PodList.RemoveAt(i);
                }
            }

            CreateFile.CreatePodcastFile();
        }
    }
}
