using System;
using System.Windows;
using TransportLibrary;

namespace WpfAppTransport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Exception noData = new Exception("No data");

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adding data to table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Read_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Service.ReadData();
                TransportGrid.ItemsSource = Service.GetTransportInfo(Service.TransportList);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error!");
            }
            
        }

        /// <summary>
        /// Adding missing info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Input_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Service.TransportList.Count == 0)
                {
                    throw noData;
                }

                InputWindow inputWindow = new InputWindow();
                inputWindow.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error!");
            }
        }

        /// <summary>
        /// Updating table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {
            TransportGrid.ItemsSource = Service.GetTransportInfo(Service.TransportList);
        }

        /// <summary>
        /// Output price for selected transport and kind of sit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Output_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Service.TransportList.Count == 0)
                {
                    throw noData;
                }

                PriceWindow priceWindow = new PriceWindow();
                priceWindow.Show();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error!");
            }
        }
    }
}
