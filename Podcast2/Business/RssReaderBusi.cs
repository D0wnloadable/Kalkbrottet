using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Podcast2.Data;

namespace Podcast2.Business
{
    class RssReaderBusi
    {
        public static void AddPodcast(string url, string cat, int freq)
        {
            if (Validator.CheckUrl(url))
            {
                RssReader.RssFeed(url, cat, freq);
            }
            else
            {
            }
        }
    }
}
