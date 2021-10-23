﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using TireFittingLibrary;
using TireFittingLibrary.RepairTypes;
using System.Windows.Controls;

namespace MyWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection connection = null;
        List<Repair> repairList = new List<Repair>();

        public MainWindow()
        {
            InitializeComponent();
        }

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
                    repairList.Add(repair);
                }

                RepairGrid.ItemsSource = RepairMethods.GetRepairInfo(repairList);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
