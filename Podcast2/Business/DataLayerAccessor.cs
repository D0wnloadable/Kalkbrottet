using Podcast2.Data;

namespace Podcast2.Business
{
    class DataLayerAccessor
    {
        // Runs methods that reads file data and loads it into form
        public static void LoadFileData()
        {
            GetFileData.GetPodcastList();
            GetFileData.GetEpisodeList();
            GetFileData.GetCategoryList();
        }



        // Runs methods that create files and save data to them
        public static void CreateFiles()
        {
            CreateFile.CreatePodcastFile();
            CreateFile.CreateEpisodeFile();
        }



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
