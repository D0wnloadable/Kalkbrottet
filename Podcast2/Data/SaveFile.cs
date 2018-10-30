﻿using System;
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
    class SaveFile
    {
        public static void SavePodcast()
        {
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\Podcast.txt");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
            serializer.Serialize(stream, PodcastList.GetPodList());
            stream.Close();
        }
        
        public static void SaveEpisodes()
        {
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\Episodes.txt");
            XmlSerializer serializer = new XmlSerializer(typeof(List<PodcastEp>));
            serializer.Serialize(stream, PodcastEpList.GetEpList());
            stream.Close();
        }

        public static void SaveCategory()
        {
            Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\Category.txt");
            XmlSerializer serializer = new XmlSerializer(typeof(List<Category>));
            serializer.Serialize(stream, CategoryList.GetCatList());
            stream.Close();
        }
    }
}