using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Text;
using System.Threading.Tasks;
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
                return false;
            }
            else
            {
                return true;
            }
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
                MessageBox.Show("Det gick inte att hitta podden!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}