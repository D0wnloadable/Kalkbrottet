using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;
using Podcast2.Business;
using System.Windows.Forms;

namespace Podcast2.Data
{
    class TheTimer
    {
        private static Timer timer;

        public static int CalcInterval(int freq)
        {
            int frequency = 1000;
            frequency = frequency * freq;

            return frequency;
        }

        public static void SetTimer(string url, string title, string category, int frequency)
        {
            int freq = CalcInterval(frequency);

            timer = new Timer();
            timer.Elapsed += (sender, e) => TimerElapsed(sender, e, url, title, category, frequency);
            timer.Interval = freq;
            timer.Enabled = true;
        }

        private static async void TimerElapsed(object sender, System.Timers.ElapsedEventArgs e, string url, string title, string category, int frequency)
        {
            List<Podcast> list = PodcastList.GetPodList();
            bool PodExists = false;
            int NumberOfEpisodes = 0;
            int OldNumberOfEpisodes = await RssReader.GetNumberOfEpisodes(url);

            foreach (Podcast pod in list)
            {
                if (pod.Title == title)
                {
                    NumberOfEpisodes = pod.Episodes;
                    PodExists = true;
                }
            }

            if (!PodExists)
            {
                timer.Enabled = false;
            }

            if (NumberOfEpisodes >= OldNumberOfEpisodes)
            {
                PodcastList.DeletePod(title);
                PodcastEpList.DeleteEpisodes(title);
                RssReaderBusi.AddPodcast(url, category, frequency);
                CreateFile.CreatePodcastFile();
                CreateFile.CreateEpisodeFile();

                timer.Enabled = false;

                MessageBox.Show("Nytt avsnitt har hittats!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Inga nya avsnitt hittades!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PodExists = false;
        }
    }
}
