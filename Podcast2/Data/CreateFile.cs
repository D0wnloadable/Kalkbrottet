using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

using Podcast2.Business;

namespace Podcast2.Data
{
    class CreateFile
    {
        private static string currentDirectory = Directory.GetCurrentDirectory();



        // Creates the podcast file and puts data into it
        public static void CreatePodcastFile()
        {
            // Deleted the file if found to not leave old data in it and cause errors
            if (File.Exists(currentDirectory + "\\data\\Podcast.txt"))
            {
                File.Delete(currentDirectory + "\\data\\Podcast.txt");
            }

            //Creating the file
            Stream stream = File.OpenWrite(currentDirectory + "\\data\\Podcast.txt");

            // Writing to the file
            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
            serializer.Serialize(stream, PodcastList.GetPodList());
            stream.Close();
        }
        


        // Creates the episode file and puts data into it.
        public static void CreateEpisodeFile()
        {
            // Deleted the file if found to not leave old data in it and cause errors
            if (File.Exists(currentDirectory + "\\data\\Episodes.txt"))
            {
                File.Delete(currentDirectory + "\\data\\Episodes.txt");
            }

            //Creating the file
            Stream stream = File.OpenWrite(currentDirectory + "\\data\\Episodes.txt");

            // Writing to the file
            XmlSerializer serializer = new XmlSerializer(typeof(List<Episode>));
            serializer.Serialize(stream, EpisodeList.GetEpList());
            stream.Close();
        }



        // Creates the category file and puts data into it
        public static void CreateCategoryFile()
        {
            //Creating the file
            if (!File.Exists(currentDirectory + "\\data\\Category.txt"))
            {
                Stream stream = File.OpenWrite(currentDirectory + "\\data\\Category.txt");
                stream.Close();
            }

            // Writing to the file
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
