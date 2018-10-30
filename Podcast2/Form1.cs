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

            List<Podcast> podList = PodcastList.GetPodList();

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
            new CategoryList();

            CreateFile.CreatePodcastList();
            CreateFile.CreateEpisodeList();
            CreateFile.CreateCategoryList2();

            UpdateListView();
            UpdateCategoryList();
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
        }

        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            string cat = tbNewCat.Text;

            CreateCategoryList.AddCatList(cat);

            UpdateCategoryList();
        }

        public void UpdateCategoryList()
        {
            lvCategory.Items.Clear();

            List<Category> catList = CategoryList.GetCatList();

            foreach(var category in catList)
            {
                lvCategory.Items.Add(category.Name);
            }

            //lvCategory.Items.Add(cat);
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            //DeleteCategory();
        }

        public void DeleteCategory()
        {
            string item = lvCategory.SelectedItems[0].Text;
            // Gets the text from the selected item
            if (Validator.StringNotEmpty(item))
            {
                // Runs the DeleteCat method
                CategoryList.DeleteCat(item);

                // Updated the list
                UpdateCategoryList();
            }
        }

        private void lvPods_Click(object sender, EventArgs e)
        {
            int i = lvPods.SelectedItems[0].Index;
            string selectedItem = lvPods.Items[i].SubItems[1].Text;

            UpdateEpisodeListView(selectedItem);
        }

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
    }
}
