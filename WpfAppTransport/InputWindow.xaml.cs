using System;
using System.Windows;
using TransportLibrary;

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

        /// <summary>
        /// Formation of values of combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TransportSelector.ItemsSource = Service.GetShortTransportInfo(Service.TransportList);
        }

        /// <summary>
        /// Updating data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
