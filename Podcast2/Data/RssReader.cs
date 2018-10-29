using Podcast2.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Podcast2.Data
{
    class RssReader
    {
        // New RSS feed
        public static void RssFeed(string url, string cat, int freq)
        {
            // Reading the feed
            // http://fulkultur.libsyn.com/rss
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            // Creating a Podcast object and adding it to PodcastList
            string podTitle = feed.Title.Text;
            int nrOfEp = feed.Items.Count();
            Podcast podcast = new Podcast(nrOfEp, podTitle, cat, freq);
            PodcastList.AddPodcast(podcast);

            // Creating the Episodes objects and adding them to PodcastEpList
            foreach (SyndicationItem item in feed.Items)
            {
                string title = item.Title.Text;
                string description = item.Summary.Text;

                PodcastEp episode = new PodcastEp(title, description);
                PodcastEpList.AddEpisode(episode);
            }
        }
    }
}
