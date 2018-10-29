using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Podcast2.Business
{
    class Validate
    {
        public static bool CheckUrl(string url)
        {
            try
            {
                SyndicationFeed feed = SyndicationFeed.Load(XmlReader.Create(url));
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
