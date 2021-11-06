using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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

        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {
            TransportGrid.ItemsSource = Service.GetTransportInfo(Service.TransportList);
        }

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
