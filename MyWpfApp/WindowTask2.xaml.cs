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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CarModels_Selector.ItemsSource = RepairMethods.GetCarModels();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string model = (string)CarModels_Selector.SelectedItem;

            MessageBox.Show(RepairMethods.FindMostPopularRepairByCarModel(model), "Задание 2");
        }
    }
}
