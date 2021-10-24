using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows;
using TireFittingLibrary;


namespace MyWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection connection = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Database connecting when the window loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // INSERT INTO Repair (Id, Date, CarModel, CarNumber, RepairType, Price) VALUES ('1', '2021-10-23', N'Mersedes', N'2003', N'Замена колёс', '15')

            try
            {
                connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBSource"].ConnectionString);
                connection.Open();

                string strCommand = "SELECT * FROM [Repair]";
                SqlCommand command = new SqlCommand(strCommand, connection);
                SqlDataReader sqlReader = command.ExecuteReader();

                while (sqlReader.Read())
                {
                    Repair repair = RepairFactory.CreateRepair((int)sqlReader["Id"], (DateTime)sqlReader["Date"], (string)sqlReader["CarModel"], (string)sqlReader["CarNumber"], (string)sqlReader["RepairType"], (double)sqlReader["Price"]);
                    RepairMethods.RepairList.Add(repair);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }

            RepairGrid.ItemsSource = RepairMethods.GetRepairInfo(RepairMethods.RepairList);
        }

        /// <summary>
        /// Start to complete task 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(RepairMethods.ViewWorksByCarModel(), "Задание 1");
        }

        /// <summary>
        /// Start to complete task 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            WindowTask2 windowTask2 = new WindowTask2();
            windowTask2.Show();
        }

        /// <summary>
        /// Start to complete task 3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            WindowTask3 windowTask3 = new WindowTask3();
            windowTask3.Show();
        }
    }
}
