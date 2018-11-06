//using System;


namespace Podcast2.Interface
{
    interface IPodcast
    {
        string Url { get; set; }
        int Episodes { get; set; }
        string Title { get; set; }
        string Category { get; set; }
        int Frequency { get; set; }
    }
}
