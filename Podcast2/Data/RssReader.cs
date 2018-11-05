﻿using Podcast2.Business;
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
            XmlReader reader = XmlReader.Create(url);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();

            // Creating a Podcast object and adding it to PodcastList
            string podTitle = feed.Title.Text;
            int nrOfEp = feed.Items.Count();

            Podcast podcast = new Podcast(url, nrOfEp, podTitle, cat, freq);
            PodcastList.AddPodcast(podcast);

            // Creating the Episodes objects and adding them to PodcastEpList
            foreach (SyndicationItem item in feed.Items)
            {
                string title = item.Title.Text;
                string description = item.Summary.Text;

                PodcastEp episode = new PodcastEp(podTitle, title, description);
                PodcastEpList.AddEpisode(episode);
            }

            TheTimer.SetTimer(url, podTitle, cat, freq);
        }



        public static async Task<int> GetNumberOfEpisodes(string url)
        {
            using (XmlReader reader = XmlReader.Create(url))
            {
                SyndicationFeed feed = SyndicationFeed.Load(reader);
                reader.Close();

                int nrOfEp = feed.Items.Count();

                return nrOfEp;
            }
        }
    }
}
