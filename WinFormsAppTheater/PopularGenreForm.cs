using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TheaterLibrary;

namespace WinFormsAppTheater
{
    public partial class PopularGenreForm : Form
    {
        /// <summary>
        /// Create window
        /// </summary>
        public PopularGenreForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start fetching data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            DateTime startDate = StartDatePicker.Value;
            DateTime endDate = EndDatePicker.Value;

            List<Play> plays = Service.PlaysList;
            List<TheaterGenre> genres = new List<TheaterGenre>();

            for (int i = 0; i < plays.Count; i++)
            {
                if (startDate > plays[i].StartDate || endDate < plays[i].EndDate)
                {
                    plays.RemoveAt(i);
                    i--;
                }
                else
                {
                    if (!genres.Contains(plays[i].Genre))
                    {
                        genres.Add(plays[i].Genre);
                    }
                }
            }

            int max = 0,
                maxIndex = 0,
                index = 0;

            foreach (TheaterGenre genre in genres)
            {
                int countOfPays = 0;

                foreach (Play play in plays)
                {
                    if (play.Genre == genre)
                    {
                        countOfPays++;
                    }
                }

                if (max < countOfPays)
                {
                    max = countOfPays;
                    maxIndex = index;
                }

                index++;
            }

            MostPopGenreLabel.Text += "\n" + Play.GetDisplayName(genres[maxIndex]);
        }
    }
}
