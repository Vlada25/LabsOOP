using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TheaterLibrary;

namespace WinFormsAppTheater
{
    public partial class CoutnOfPlaysForm : Form
    {
        /// <summary>
        /// Create window
        /// </summary>
        public CoutnOfPlaysForm()
        {
            InitializeComponent();
            GenresDataTable.Columns.AddRange(CreateTable());
        }

        /// <summary>
        /// Start fetching data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterBtn_Click(object sender, EventArgs e)
        {
            GenresDataTable.Rows.Clear();

            DateTime startDate = StartDatePicker.Value;
            DateTime endDate = EndDatePicker.Value;

            List<Play> plays = Service.PlaysList;
            List<TheaterGenre> genres = Play.GetAllGenresInDateRange(plays, startDate, endDate);

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

                double persent = countOfPays * 100 / plays.Count;

                GenresDataTable.Rows.Add(AddRow(genre, countOfPays, persent));
            }
        }

        /// <summary>
        /// Creating the header of table
        /// </summary>
        /// <returns>Header of the table</returns>
        DataGridViewTextBoxColumn[] CreateTable()
        {
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "genre";
            column0.HeaderText = "Жанр";
            column0.Width = 170;

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "countOfPlays";
            column1.HeaderText = "Количество спектаклей жанра";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "persent";
            column2.HeaderText = "Процент";

            return new DataGridViewTextBoxColumn[] { column0, column1, column2};
        }

        /// <summary>
        /// Adding new row
        /// </summary>
        /// <param name="genre">Genre</param>
        /// <param name="countOfPlays">Count of plays of genre</param>
        /// <param name="percent">Percent of genre</param>
        /// <returns>New row</returns>
        public static DataGridViewRow AddRow(TheaterGenre genre, int countOfPlays, double percent)
        {
            DataGridViewCell genreCell = new DataGridViewTextBoxCell();
            DataGridViewCell countOfPlaysCell = new DataGridViewTextBoxCell();
            DataGridViewCell persentCell = new DataGridViewTextBoxCell();

            genreCell.Value = Play.GetDisplayName(genre);
            countOfPlaysCell.Value = countOfPlays;
            persentCell.Value = percent;

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(genreCell, countOfPlaysCell, persentCell);

            return row;
        }
    }
}
