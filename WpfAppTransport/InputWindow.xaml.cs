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
using TransportLibrary;
using TransportLibrary.LandTransportKinds;

namespace WpfAppTransport
{
    /// <summary>
    /// Логика взаимодействия для InputWindow.xaml
    /// </summary>
    public partial class InputWindow : Window
    {
        public InputWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TransportSelector.ItemsSource = Service.GetShortTransportInfo(Service.TransportList);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int numOfItem = TransportSelector.SelectedIndex;
                string kind = Convert.ToString(TransportSelector.SelectedItem).Split(' ')[1];
                string[] textBoxValues = countOfSitsEnter.Text.Split(' ');

                Service.SetCountOfPlaces(numOfItem, kind, textBoxValues);

                MessageBox.Show("Данные добавлены. Обновите таблицу");

                Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error!");
            }
        }
    }
}
