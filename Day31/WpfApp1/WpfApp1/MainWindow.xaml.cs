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


            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\PracticaC#\Day31\WpfApp1\WpfApp1\bin\Debug\DBTur_firm1.mdb;Persist Security Info=False;";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Туры";
                OleDbCommand selectCommand = new OleDbCommand(selectQuery, connection);

                OleDbDataAdapter adapter = new OleDbDataAdapter(selectQuery, connectionString);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGrid.ItemsSource = dataTable.DefaultView;

                OleDbDataReader reader = selectCommand.ExecuteReader();
                while (reader.Read())
                {
               
                    string tourName = reader["Название"].ToString();
                    
                }
                reader.Close();

                int tourCodeToDelete = 5;
                string deleteTourQuery = "DELETE FROM Туры WHERE КодТура = TourCode";
                OleDbCommand deleteTourCommand = new OleDbCommand(deleteTourQuery, connection);
                deleteTourCommand.Parameters.AddWithValue("TourCode", tourCodeToDelete);
                int deletedRows = deleteTourCommand.ExecuteNonQuery();

                Console.WriteLine("Удалено {0} записей", deletedRows);

             
                int touristIdToUpdate = 1; 
                string newName = "Антон";
                string updateTouristQuery = "UPDATE Туристы SET Имя = Антон WHERE TouristId = TouristId";
                OleDbCommand updateTouristCommand = new OleDbCommand(updateTouristQuery, connection);
                updateTouristCommand.Parameters.AddWithValue("Имя", newName);
                updateTouristCommand.Parameters.AddWithValue("TouristId", touristIdToUpdate);
                int updatedRows = updateTouristCommand.ExecuteNonQuery();

                Console.WriteLine("Изменено {0} записей", updatedRows);

            }
        }
    
        }


    }


