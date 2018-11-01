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
using System.Xml.Linq;
using Podcast2.Business;
using Podcast2.Data;

namespace Podcast2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            new PodcastList();
            new PodcastEpList();
            new CategoryList();

            CreateFile.CreatePodcastList();
            CreateFile.CreateEpisodeList();
            //CreateFile.CreateCategoryList2();

            UpdatePodListView();
            UpdateCategoryListView();
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

            UpdatePodListView();
        }



        // Updates the list view of the Podcasts
        private void UpdatePodListView()
        {
            lvPods.Items.Clear();

            List<Podcast> podList = PodcastList.GetPodList();

            foreach (var pod in podList)
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



        // When clicking a Podcast on the "lvPods" element, the episode list view should update
        private void lvPods_Click(object sender, EventArgs e)
        {
            int i = lvPods.SelectedItems[0].Index;
            string selectedItem = lvPods.Items[i].SubItems[1].Text;

            UpdateEpisodeListView(selectedItem);
        }



        // Updates the list view of the Episodes
        public void UpdateEpisodeListView(string title)
        {
            lvEpisodes.Clear();

            List<PodcastEp> list = PodcastEpList.GetEpList();

            foreach (var ep in list)
            {
                if (ep.PodTitle == title)
                {
                    lvEpisodes.Items.Add(ep.Title);
                }
            }

            //List<string> list = PodcastEpList.GetEpTitle();

            //lvEpisodes.Items.Clear();

            //foreach(string t in list)
            //{
            //    lvEpisodes.Items.Add(t);
            //}
        }



        // Button to save a Category
        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            string cat = tbNewCat.Text;

            if (Validator.StringNotEmpty(cat))
            {
                CreateCategoryList.AddCatList(cat);
                UpdateCategoryListView();
            }
            
        }



        // Button to delete a Category
        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            // var item = lvCategory.SelectedItems[0].Text; if(Validator.checkSomething(item))
            string item = lvCategory.SelectedItems[0].Text;

            if (Validator.StringNotEmpty(item))
            {
                CategoryList.DeleteCat(item);

                // Updated the list
                UpdateCategoryListView();
            }
        }



        // Updates the list view of the Categories
        public void UpdateCategoryListView()
        {
            lvCategory.Items.Clear();

            List<string> catList = CategoryList.GetCatList();

            foreach (string cat in catList)
            {
                lvCategory.Items.Add(cat);
            }
            
            //lvCategory.Items.Add(cat);
        }
    }
}
