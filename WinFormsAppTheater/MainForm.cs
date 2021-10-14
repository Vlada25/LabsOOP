using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TheaterLibrary;

namespace WinFormsAppTheater
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Creating start window
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            DataTablePlays.Columns.AddRange(CreateTable());
        }

        /// <summary>
        /// Fill table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            Service.Read();
            DataTablePlays.Rows.Clear();

            List<Play> plays = Service.PlaysList;
            int index = 0;

            foreach (Play play in plays)
            {
                DataTablePlays.Rows.Add(AddRow(play, index));
                index++;
            }
            
        }

        /// <summary>
        /// Creating the header of table
        /// </summary>
        /// <returns>Header of the table</returns>
        public static DataGridViewTextBoxColumn[] CreateTable()
        {
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "id";
            column0.HeaderText = "ID";
            column0.Width = 50;

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "name";
            column1.HeaderText = "Название спектакля";
            column1.Width = 300;

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "genre";
            column2.HeaderText = "Жанр";
            column2.Width = 170;

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "startDate";
            column3.HeaderText = "Дата премьеры";

            DataGridViewTextBoxColumn column4 = new DataGridViewTextBoxColumn();
            column4.Name = "endDate";
            column4.HeaderText = "Дата окончания";

            DataGridViewTextBoxColumn column5 = new DataGridViewTextBoxColumn();
            column5.Name = "countOfVisits";
            column5.HeaderText = "Количество посещений";
            column5.Width = 150;

            return new DataGridViewTextBoxColumn[] { column0, column1, column2, column3, column4, column5 };
        }

        /// <summary>
        /// Adding row with data
        /// </summary>
        /// <param name="play">Data</param>
        /// <param name="index">Index of line</param>
        /// <returns>New row</returns>
        public static DataGridViewRow AddRow(Play play, int index)
        {
            DataGridViewCell id = new DataGridViewTextBoxCell();
            DataGridViewCell name = new DataGridViewTextBoxCell();
            DataGridViewCell genre = new DataGridViewTextBoxCell();
            DataGridViewCell startDate = new DataGridViewTextBoxCell();
            DataGridViewCell endDate = new DataGridViewTextBoxCell();
            DataGridViewCell countOfVisits = new DataGridViewTextBoxCell();

            id.Value = index;
            name.Value = play.Name;
            genre.Value = Play.GetDisplayName(play.Genre);
            startDate.Value = play.StartDate.ToString("d");
            endDate.Value = play.EndDate.ToString("d");
            countOfVisits.Value = play.CountOfVisits;

            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(id, name, genre, startDate, endDate, countOfVisits);

            return row;
        }

        /// <summary>
        /// Button for opening new window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewVisits_Click(object sender, EventArgs e)
        {
            PlaysByDateForm playsByDateForm = new PlaysByDateForm();
            playsByDateForm.Show();
        }

        /// <summary>
        /// Button for opening new window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountVisits_Click(object sender, EventArgs e)
        {
            CoutnOfPlaysForm coutnOfPlaysForm = new CoutnOfPlaysForm();
            coutnOfPlaysForm.Show();
        }

        /// <summary>
        /// Button for opening new window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindMostPopularGenre_Click(object sender, EventArgs e)
        {
            PopularGenreForm popularGenreForm = new PopularGenreForm();
            popularGenreForm.Show();
        }
    }
}
