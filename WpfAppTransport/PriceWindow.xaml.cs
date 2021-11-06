using System;
using System.Windows;
using System.Windows.Controls;
using TransportLibrary;

namespace WpfAppTransport
{
    /// <summary>
    /// Логика взаимодействия для PriceWindow.xaml
    /// </summary>
    public partial class PriceWindow : Window
    {
        private string selectedTransportKind;
        private int transportIndex;
        public PriceWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Formation of values of first combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TransportSelector.ItemsSource = Service.GetShortTransportInfo(Service.TransportList);
        }

        /// <summary>
        /// Formation of values of second combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransportSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            transportIndex = TransportSelector.SelectedIndex;
            selectedTransportKind = Convert.ToString(TransportSelector.SelectedItem).Split(' ')[1];

            KindSelector.ItemsSource = Service.SelectKindOfSits(transportIndex, selectedTransportKind);
        }

        /// <summary>
        /// Viewing price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string selectedSitKind = (string)KindSelector.SelectedItem;

                if (selectedSitKind == null)
                {
                    throw new Exception("Kind of sit doesn't select");
                }

                MessageBox.Show($"Цена: {Convert.ToString(Service.GetCorrespondingPrice(selectedSitKind, transportIndex, selectedTransportKind))} p.");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error!");
            }
        }
    }
}
