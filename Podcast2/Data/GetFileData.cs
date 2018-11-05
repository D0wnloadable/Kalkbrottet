using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Podcast2.Business;

namespace Podcast2.Data
{
    public class GetFileData
    {
        public static void GetPodcastList()
        {
            if (File.Exists("data\\Podcast.txt"))
            {
                XDocument xdoc = XDocument.Load("data\\Podcast.txt");
                xdoc.Descendants("Podcast").Select(p => new
                {
                    Url = p.Element("Url").Value,
                    Episodes = Convert.ToInt32(p.Element("Episodes").Value),
                    Title = p.Element("Title").Value,
                    Category = p.Element("Category").Value,
                    Frequency = Convert.ToInt32(p.Element("Frequency").Value)

                }).ToList().ForEach(p =>
                {
                    Podcast pod = new Podcast(
                        p.Url,
                        p.Episodes,
                        p.Title,
                        p.Category,
                        p.Frequency
                        );
                        
                    PodcastList.AddPodcast(pod);
                    TheTimer.SetTimer(p.Url, p.Title, p.Category, p.Frequency);
                });
            }
        }

        public static void GetEpisodeList()
        {
            if (File.Exists("data\\Episodes.txt"))
            {
                XDocument xdoc = XDocument.Load("data\\Episodes.txt");
                xdoc.Descendants("PodcastEp").Select(p => new
                {
                    podTitle = p.Element("PodTitle").Value,
                    title = p.Element("Title").Value,
                    desc = p.Element("Description").Value,

                }).ToList().ForEach(p =>
                {
                    PodcastEp ep = new PodcastEp(
                        p.podTitle,
                        p.title,
                        p.desc);
                    PodcastEpList.AddEpisode(ep);
                });
            }
        }



        public static void GetCategoryList()
        {
            if (File.Exists("data\\Category.txt"))
            {
                var catFile = File.ReadAllLines("data\\Category.txt");

                foreach (string cat in catFile)
                {
                    CategoryList.AddCat(cat);
                }
            }
        }
    }
}
