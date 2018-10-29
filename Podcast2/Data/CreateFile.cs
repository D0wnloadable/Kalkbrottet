using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Podcast2.Business;

namespace Podcast2.Data
{
    public class CreateFile
    {
        public static void CreatePodcastList()
        {
            if (File.Exists("Podcasts.txt"))
            {
                XDocument xdoc = XDocument.Load("Podcast.txt");
                xdoc.Descendants("Podcast").Select(p => new
                {
                    podcastTitel = p.Element("podcastTitel").Value,
                    uppdateringsFrekvens = Convert.ToInt32(p.Element("uppdateringsFrekvens").Value),
                    kategori = p.Element("kategori").Value,
                    antalAvsnitt = Convert.ToInt32(p.Element("antalAvsnitt").Value)

                }).ToList().ForEach(p =>
                {
                    Podcast pod = new Podcast(
                        p.antalAvsnitt,
                        p.podcastTitel,
                        p.kategori,
                        p.uppdateringsFrekvens
                        );
                        

                    PodcastList.AddPodcast(pod);
                });
            }
        }

        public static void CreateEpisodeList()
        {
            if (File.Exists("avsnitt.txt"))
            {
                XDocument xdoc = XDocument.Load("PodcastEp.txt");
                xdoc.Descendants("Avsnitt").Select(p => new
                {
                    title = p.Element("avsnittTitel").Value,
                    desc = p.Element("beskrivning").Value,

                }).ToList().ForEach(p =>
                {
                    PodcastEp ep = new PodcastEp(
                        p.title,
                        p.desc);
                    PodcastEpList.AddEpisode(ep);
                });
            }
        }







        public void CreateXml(Podcast pod, List<PodcastEp> podList)
        {
            // LinQ
            //XDocument xmlDocument = new XDocument(
            //    new XDeclaration("1.0", "utf-8", "yes"),
            //    new XComment("Creating an XML tree using LINQ to XML"),
            //    new XElement("Root",
            //        new XElement("Episodes", podList.Count),
            //        new XElement("Podcast", pod.Title),
            //            from item in podList
            //            select new XElement("Episode", new XAttribute("Id", podList.IndexOf(item)),
            //                //new XElement("EP", "Avsnitt: " + podList.IndexOf(item)),
            //                new XElement("Name", "Titel: " + item.Title))
            //    ));
            //xmlDocument.Save(@"C:\Users\joaki\source\repos\Podcast2\Podcast2\RSS.xml");

            // Creating the XML document
            //XmlDocument doc = new XmlDocument();
            //doc.LoadXml(podList); // Could be a List

            // Save the document to a file and auto-indent the output
            //XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
            //StreamWriter writer = new StreamWriter(path);

            //serializer.Serialize(writer, path);
            //writer.Close();
        }
    }
}
