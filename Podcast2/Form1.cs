using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Podcast2.Business;

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
            new EpisodeList();
            new CategoryList();

            DataLayerAccessor.LoadFileData();

            UpdatePodListView();
            UpdateCategoryListView();
        }



        // Button to add a new Podcast
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string url = tbUrl.Text;
            string category = cbCategory.Text;
            var stringFrequency = cbFrequency.SelectedItem;

            if (Validator.StringNotEmpty(category) &&
                Validator.ParseFrequency(stringFrequency) &&
                Validator.PodcastAlreadyExist(url))
            {
                int frequency = Int32.Parse(stringFrequency.ToString());

                DataLayerAccessor.AddPodcast(url, category, frequency);
                DataLayerAccessor.CreateFiles();

                UpdatePodListView();
            }
        }



        // Button to delete a podcast
        private void btnDeletePod_Click(object sender, EventArgs e)
        {
            try
            {
                string title = lvPods.SelectedItems[0].SubItems[1].Text;

                if (Validator.StringNotEmpty(title))
                {
                    PodcastList.DeletePod(title);
                    EpisodeList.DeleteEpisodes(title);
                    DataLayerAccessor.CreateFiles();

                    UpdatePodListView();
                    lvEpisodes.Items.Clear();
                    tbEpDescription.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Ingen podcast är vald.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        // When clicking a Podcast on the "lvPods" element, the episode list view and form elements should update
        private void lvPods_Click(object sender, EventArgs e)
        {
            string title = lvPods.SelectedItems[0].SubItems[1].Text;

            UpdateEpisodeListView(title);
            SetFormElements(title);
        }



        // Updates the list view of the Episodes
        public void UpdateEpisodeListView(string title)
        {
            lvEpisodes.Items.Clear();

            List<Episode> epList = EpisodeList.GetEpList();

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



        // Updates the data in the form elements
        public void SetFormElements(string title)
        {
            List<Podcast> podList = PodcastList.GetPodList();

            for (int i = 0; i < podList.Count(); i++)
            {
                if (podList.ElementAt(i).Title == title)
                {
                    tbUrl.Text = podList.ElementAt(i).Url;
                    cbFrequency.SelectedIndex = cbFrequency.Items.IndexOf(podList.ElementAt(i).Frequency.ToString());
                    cbCategory.SelectedIndex = cbCategory.Items.IndexOf(podList.ElementAt(i).Category);
                }
            }
        }



        // Updates the data of a specific podcast
        private void btnUpdatePod_Click(object sender, EventArgs e)
        {
            try
            {
                string title = lvPods.SelectedItems[0].SubItems[1].Text;

                string url = tbUrl.Text;
                string category = cbCategory.Text;
                var stringFrequency = cbFrequency.SelectedItem;

                if (Validator.StringNotEmpty(title) &&
                    Validator.StringNotEmpty(category) &&
                    Validator.ParseFrequency(stringFrequency))
                {
                    int frequency = Int32.Parse(stringFrequency.ToString());

                    PodcastList.DeletePod(title);
                    EpisodeList.DeleteEpisodes(title);

                    DataLayerAccessor.AddPodcast(url, category, frequency);
                    DataLayerAccessor.CreateFiles();
                    
                    UpdatePodListView();
                    lvEpisodes.Items.Clear();
                    tbEpDescription.Clear();
                    MessageBox.Show("Podcasten uppdaterades!", "Wohoo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ingen podcast är vald.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            List<Episode> list = EpisodeList.GetEpList();

            foreach (Episode ep in list)
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
                var list = new ListViewItem(new[]
                {
                    cat
                });

                lvCategory.Items.Add(list);
                cbCategory.Items.Add(cat);
            }
        }
    }
}
