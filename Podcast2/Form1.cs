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



        // Runs when the form is first loading
        private void Form1_Load(object sender, EventArgs e)
        {
            new PodcastList();
            new PodcastEpList();
            new CategoryList();

            GetFileData.GetPodcastList();
            GetFileData.GetEpisodeList();
            GetFileData.GetCategoryList();

            UpdatePodListView();
            UpdateCategoryListView();
        }



        // Button to add a new Podcast
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string url = tbUrl.Text;
            string category = cbCategory.Text;
            var stringFrequency = cbFrequency.SelectedItem;

            if (Validator.StringNotEmpty(category) && Validator.ParseFrequency(stringFrequency))
            {
                int frequency = Int32.Parse(stringFrequency.ToString());

                RssReaderBusi.AddPodcast(url, category, frequency);
                CreateFile.CreatePodcastFile();
                CreateFile.CreateEpisodeFile();

                UpdatePodListView();
            }
        }



        // Button to delete a podcast
        private void btnDeletePod_Click(object sender, EventArgs e)
        {
            string title = lvPods.SelectedItems[0].SubItems[1].Text;

            if (Validator.StringNotEmpty(title))
            {
                PodcastList.DeletePod(title);
                PodcastEpList.DeleteEpisodes(title);

                UpdatePodListView();
                lvEpisodes.Items.Clear();
            }
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
            string title = lvPods.SelectedItems[0].SubItems[1].Text;

            UpdateEpisodeListView(title);
        }



        // Updates the list view of the Episodes
        public void UpdateEpisodeListView(string title)
        {
            lvEpisodes.Items.Clear();

            List<PodcastEp> epList = PodcastEpList.GetEpList();

            foreach (var ep in epList)
            {
                if (ep.PodTitle == title)
                {
                    var list = new ListViewItem(new[]
                    {
                        ep.Title
                    });

                    lvEpisodes.Items.Add(list);
                }
            }
        }



        // When clicking an Episode on the "lvEpisodes" element, the Description text box should update
        private void lvEpisodes_Click(object sender, EventArgs e)
        {
            string epTitle = lvEpisodes.SelectedItems[0].Text;

            UpdateEpisodeDescription(epTitle);
        }



        // Updates the text box of the Description
        public void UpdateEpisodeDescription(string title)
        {
            string description = "";

            List<PodcastEp> list = PodcastEpList.GetEpList();

            foreach (PodcastEp ep in list)
            {
                if (ep.Title == title)
                {
                    description = ep.Description;
                    break;
                }
            }

            tbEpDescription.Clear();
            tbEpDescription.AppendText(description);
        }



        // Button to save a Category
        private void btnSaveCat_Click(object sender, EventArgs e)
        {
            string cat = tbNewCat.Text;

            if (Validator.StringNotEmpty(cat))
            {
                if (Validator.CatExist(cat))
                {
                    CreateCategoryList.AddCatList(cat);
                    UpdateCategoryListView();
                }
            }
            
        }



        // Button to delete a Category
        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
            // var item = lvCategory.SelectedItems[0].Text; if(Validator.checkSomething(item))
            try
            {
                var item = lvCategory.SelectedItems[0].Text;

                if (Validator.StringNotEmpty(item))
                {
                    CategoryList.DeleteCat(item);

                    // Updated the list
                    UpdateCategoryListView();
                }
            }
            catch
            {
                MessageBox.Show("Ingen kategori är vald.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        // Updates the list view of the Categories
        public void UpdateCategoryListView()
        {
            lvCategory.Items.Clear();
            cbCategory.Items.Clear();

            List<string> catList = CategoryList.GetCatList();

            foreach (string cat in catList)
            {
                lvCategory.Items.Add(cat);
                cbCategory.Items.Add(cat);
            }
            
            //lvCategory.Items.Add(cat);
        }
    }
}
