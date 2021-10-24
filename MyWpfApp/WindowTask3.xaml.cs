using System;
using System.Windows;
using TireFittingLibrary;

namespace MyWpfApp
{
    /// <summary>
    /// Логика взаимодействия для WindowTask3.xaml
    /// </summary>
    public partial class WindowTask3 : Window
    {
        public WindowTask3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Finding sum of prices by repair works in selected interval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime? startDate = calendar1.SelectedDate;
                DateTime? endDate = calendar2.SelectedDate;

                RepairGrid.ItemsSource = RepairMethods.GetRepairInfo(RepairMethods.GetRepairInInterval(startDate.Value.Date, endDate.Value.Date));

                MessageBox.Show(RepairMethods.CountTotalCost(RepairMethods.GetRepairInInterval(startDate.Value.Date, endDate.Value.Date)), "Задание 3");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }

}
