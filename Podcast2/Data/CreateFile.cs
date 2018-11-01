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
        public static void CreateCategoryList()
        {
            if (File.Exists("Category.txt"))
            {
                var doc = XDocument.Load("Category.txt");

                List<Category> cat =
                    doc.Root
                    .Elements("Category")
                    .Select(c => new Category
                    {
                        Name = (string)c.Element("Cat")
                    }).ToList();
            }
        }



        public static void CreateCategoryList2()
        {
            if (File.Exists("Category.txt"))
            {
                XDocument doc = XDocument.Load("Category.txt");
                doc.Descendants("Category").Select(p => new
                {
                    Name = p.Element("Name").Value

                }).ToList().ForEach(p =>
                {
                    Category cat = new Category(
                        p.Name
                        );

                    //CategoryList.AddCat(cat);
                });
            }
        }



        public static void CreatePodcastList()
        {
            if (File.Exists("Podcast.txt"))
            {
                XDocument xdoc = XDocument.Load("Podcast.txt");
                xdoc.Descendants("Podcast").Select(p => new
                {
                    Episodes = Convert.ToInt32(p.Element("Episodes").Value),
                    Title = p.Element("Title").Value,
                    Category = p.Element("Category").Value,
                    Frequency = Convert.ToInt32(p.Element("Frequency").Value)

                }).ToList().ForEach(p =>
                {
                    Podcast pod = new Podcast(
                        p.Episodes,
                        p.Title,
                        p.Category,
                        p.Frequency
                        );
                        
                    PodcastList.AddPodcast(pod);
                });
            }
        }

        public static void CreateEpisodeList()
        {
            if (File.Exists("Episodes.txt"))
            {
                XDocument xdoc = XDocument.Load("Episodes.txt");
                xdoc.Descendants("PodcastEp").Select(p => new
                {
                    podTitle = p.Element("PodTitle").Value,
                    title = p.Element("Title").Value,
                    desc = p.Element("Description").Value,

                }).ToList().ForEach(p =>
                {
                    PodcastEp ep = new PodcastEp(
                        p.podTitle,
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
