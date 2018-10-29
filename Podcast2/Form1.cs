using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Podcast2.Business;
using Podcast2.Data;

namespace Podcast2
{
    public partial class Form1 : Form
    {
        private RssReader Reader = new RssReader();
        private SaveFile SaveLoad = new SaveFile();



        public Form1()
        {
            InitializeComponent();
        }



        // Button to add a new Podcast
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var Url = tbUrl.Text;
            var Category = cbCategory.Text;
            int Frequency = cbFrequency.SelectedIndex;

            RssReaderBusi.AddPodcast(Url, Category, Frequency);
            SaveFile.SavePodcast();
            SaveFile.SaveEpisodes();

            UpdateListView();
        }



        // Updates the list view of the Podcasts
        private void UpdateListView()
        {
            lvPods.Items.Clear();

            List<Podcast> podList = PodcastList.GetList();

            foreach(var pod in podList)
            {
                var list = new ListViewItem(new[]
                {
                    pod.Episodes.ToString(),
                    pod.Title,
                    pod.Category,
                    pod.Frequency.ToString()
                });

                lvPods.Items.Add(list);
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            new PodcastList();
            new PodcastEpList();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }
    }
}
