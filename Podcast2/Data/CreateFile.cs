using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Podcast2.Business;

namespace Podcast2.Data
{
    class CreateFile
    {
        private static string currentDirectory = Directory.GetCurrentDirectory();



        public static void CreatePodcastFile()
        {
            if (File.Exists(currentDirectory + "\\data\\Podcast.txt"))
            {
                File.Delete(currentDirectory + "\\data\\Podcast.txt");
            }

            Stream stream = File.OpenWrite(currentDirectory + "\\data\\Podcast.txt");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
            serializer.Serialize(stream, PodcastList.GetPodList());
            stream.Close();
        }
        


        public static void CreateEpisodeFile()
        {
            if (File.Exists(currentDirectory + "\\data\\Episodes.txt"))
            {
                File.Delete(currentDirectory + "\\data\\Episodes.txt");
            }

            Stream stream = File.OpenWrite(currentDirectory + "\\data\\Episodes.txt");
            XmlSerializer serializer = new XmlSerializer(typeof(List<PodcastEp>));
            serializer.Serialize(stream, PodcastEpList.GetEpList());
            stream.Close();
        }



        public static void CreateCategoryFile()
        {
            //Creating the file "Category.txt"
            Stream stream = File.OpenWrite(currentDirectory + "\\data\\Category.txt");
            stream.Close();

            // Writing to the text file
            StreamWriter sw = new StreamWriter(currentDirectory + "\\data\\Category.txt");

            List<string> catList = CategoryList.GetCatList();

            foreach(string cat in catList)
            {
                sw.WriteLine(cat);
            }
            sw.Close();
        }
    }
}
