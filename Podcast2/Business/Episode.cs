// using System;

namespace Podcast2.Business
{
    public class Episode
    {
        public string PodTitle { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }



        // Empty constructor
        public Episode()
        {
        }



        // Constructor
        public Episode(string podTitle,string title, string description)
        {
            PodTitle = podTitle;
            Title = title;
            Description = description;
        }
    }
}
