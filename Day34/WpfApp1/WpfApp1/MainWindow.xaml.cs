using System;
using System.Data.SqlClient;
using System.Windows;
using Microsoft.Data.Sqlite;
using System.Data.OleDb;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PracticaC#\Day32\WpfApp1\WpfApp1\bin\Debug\DBTur_firm1.mdb;Persist Security Info=False;";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

               
                DataSet dataSet = new DataSet();

               
                string toursQuery = "SELECT * FROM Туры";
                string touristsQuery = "SELECT * FROM Туристы";

                
                DataTable toursTable = new DataTable("Туры");
                DataTable touristsTable = new DataTable("Туристы");

              
                OleDbDataAdapter toursAdapter = new OleDbDataAdapter(toursQuery, connection);
                toursAdapter.Fill(toursTable);

                OleDbDataAdapter touristsAdapter = new OleDbDataAdapter(touristsQuery, connection);
                touristsAdapter.Fill(touristsTable);
                
                dataSet.Tables.Add(toursTable);
                dataSet.Tables.Add(touristsTable);
                //s

                
                dataGridTours.ItemsSource = dataSet.Tables["Туры"].DefaultView;
                dataGridTourists.ItemsSource = dataSet.Tables["Туристы"].DefaultView;

               
                int tourCodeToDelete = 5;
                string deleteTourQuery = "DELETE FROM Туры WHERE КодТура = TourCode";
                OleDbCommand deleteTourCommand = new OleDbCommand(deleteTourQuery, connection);
                deleteTourCommand.Parameters.AddWithValue("@TourCode", tourCodeToDelete);
                int deletedRows = deleteTourCommand.ExecuteNonQuery();

                Console.WriteLine("Удалено {0} записей", deletedRows);


                int touristIdToUpdate = 1;
                string newName = "Антон";
                string updateTouristQuery = "UPDATE Туристы SET Имя = NewName WHERE TouristId = TouristId";
                OleDbCommand updateTouristCommand = new OleDbCommand(updateTouristQuery, connection);
                updateTouristCommand.Parameters.AddWithValue("NewName", newName);
                updateTouristCommand.Parameters.AddWithValue("TouristId", touristIdToUpdate);
                int updatedRows = updateTouristCommand.ExecuteNonQuery();

                Console.WriteLine("Изменено {0} записей", updatedRows);
            }
        }
    }

    }


