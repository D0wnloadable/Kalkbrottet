using System;
using System.Collections.Generic;
using System.ServiceModel.Syndication;
using System.Windows.Forms;
using System.Xml;

namespace Podcast2.Business
{
    class Validator
    {
        // Checks if string is Null or empty
        public static bool StringNotEmpty(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Ett eller fler fält är tomma.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            else
            {
                return true;
            }
        }



        public static bool PodcastAlreadyExist(string url)
        {
            List<Podcast> podList = PodcastList.GetPodList();
            bool notFound = true;

            foreach (Podcast pod in podList)
            {
                if (url == pod.Url)
                {
                    notFound = false;

                    MessageBox.Show("Podcasten finns redan.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return notFound;
        }



        // Checks if Url is valid
        public static bool CheckUrl(string url)
        {
            try
            {
                SyndicationFeed feed = SyndicationFeed.Load(XmlReader.Create(url));
                return true;
            }
            catch
            {
                MessageBox.Show("Det gick inte att hitta podden.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }



        public static bool CatExist(string cat)
        {
            List<string> CatList = CategoryList.GetCatList();

            if (!CatList.Contains(cat))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Kategorin finns redan.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }



        public static bool ParseFrequency(object freq)
        {
            try
            {
                int intFreq = Int32.Parse(freq.ToString());

                return true;
            }
            catch
            {
                MessageBox.Show("Ingen uppdateringsfrekvens är vald.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }
    }
}