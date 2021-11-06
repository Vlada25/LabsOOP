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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            TransportSelector.ItemsSource = Service.GetShortTransportInfo(Service.TransportList);
        }

        private void TransportSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            transportIndex = TransportSelector.SelectedIndex;
            selectedTransportKind = Convert.ToString(TransportSelector.SelectedItem).Split(' ')[1];

            KindSelector.ItemsSource = Service.SelectKindOfSits(transportIndex, selectedTransportKind);
        }

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
