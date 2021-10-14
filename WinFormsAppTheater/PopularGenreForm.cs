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
            List<TheaterGenre> genres = Play.GetAllGenresInDateRange(plays, startDate, endDate);

            int maxIndex = Play.GetIndexOfTheMostPopularGenre(plays, genres);

            MostPopGenreLabel.Text += "\n" + Play.GetDisplayName(genres[maxIndex]);
        }
    }
}
