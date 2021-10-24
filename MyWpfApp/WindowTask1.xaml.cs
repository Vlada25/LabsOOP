using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TireFittingLibrary;

namespace MyWpfApp
{
    /// <summary>
    /// Логика взаимодействия для WindowTask1.xaml
    /// </summary>
    public partial class WindowTask1 : Window
    {
        public WindowTask1()
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
