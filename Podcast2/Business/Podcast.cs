using Podcast2.Interface;

namespace Podcast2.Business
{
    public class Podcast : IPodcast
    {
        public string Url { get; set; }
        public int Episodes { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public int Frequency { get; set; }



        // Empty constructor
        public Podcast()
        {
        }



        // Constructor
        public Podcast(string url, int episodes, string title, string category, int frequency)
        {
            Url = url;
            Episodes = episodes;
            Title = title;
            Category = category;
            Frequency = frequency;
        }
    }
}
