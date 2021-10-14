using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TheaterLibrary;

namespace WinFormsAppTheater
{
    public partial class PlaysByDateForm : Form
    {
        /// <summary>
        /// Create window
        /// </summary>
        public PlaysByDateForm()
        {
            InitializeComponent();
            SelectedDataTable.Columns.AddRange(MainForm.CreateTable());
        }

        /// <summary>
        /// Start fetching data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDateBtn_Click(object sender, EventArgs e)
        {
            SelectedDataTable.Rows.Clear();
            DateTime selectedDate = dateTimePicker1.Value;
            List<Play> plays = Service.PlaysList;
            int index = 0;

            foreach (Play play in plays)
            {
                if (selectedDate >= play.StartDate && selectedDate <= play.EndDate)
                {
                    SelectedDataTable.Rows.Add(MainForm.AddRow(play, index));
                }
                index++;
            }
        }
    }
}
