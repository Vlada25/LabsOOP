using System.Windows;
using TireFittingLibrary;

namespace MyWpfApp
{
    /// <summary>
    /// Логика взаимодействия для WindowTask1.xaml
    /// </summary>
    public partial class WindowTask2 : Window
    {
        public WindowTask2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adding car models to select them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarModels_Selector.ItemsSource = RepairMethods.GetCarModels();
        }

        /// <summary>
        /// Finding the most popular repair by car model
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string model = (string)CarModels_Selector.SelectedItem;

            MessageBox.Show(RepairMethods.FindMostPopularRepairByCarModel(model), "Задание 2");
        }
    }
}
