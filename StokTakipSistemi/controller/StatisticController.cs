using Microsoft.Data.SqlClient;
using StokTakipSistemi.model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.controller
{
    internal class StatisticController
    {
        private string connectionString = new SQLIslemleri().GetBaglanti();

        public StatisticSalesModel getMonthSalesData(int offset, String catergory)
        {
            string query = "";

            if (offset != 0)
            {
                query = "SELECT ID, UrunGKategori, Miktar, UrunFiyatSatis, CreatedAt " +
                       "FROM [dbo].[IstatistikSatis] " +
                       "WHERE UrunGKategori='" + catergory + "' AND CAST([CreatedAt] AS DATE) BETWEEN CAST(GETDATE()" + ((offset - 1) * 30).ToString() + " AS DATE) AND CAST(GETDATE() " + (offset * 30).ToString() + " AS DATE)";
            }
            else
            {
                query = "SELECT ID, UrunGKategori, Miktar, UrunFiyatSatis, CreatedAt " +
                       "FROM [dbo].[IstatistikSatis] " +
                       "WHERE UrunGKategori='" + catergory + "' AND CAST([CreatedAt] AS DATE) BETWEEN CAST(GETDATE() - 30 AS DATE) AND CAST(GETDATE() AS DATE)";
            }

            int sumOfSalesQuantity = 0;
            double sumOfSalesPrices = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string kategori = reader.GetString(1);
                                int miktar = reader.GetInt32(2);
                                double fiyat = reader.GetDouble(3);
                                DateTime createdAt = reader.GetDateTime(4);

                                //Print the retrieved data
                                //Debug.WriteLine($"ID: {id}, Kategori: {kategori}, Miktar: {miktar}, Fiyat: {fiyat}, CreatedAt: {createdAt}");

                                sumOfSalesPrices += fiyat;
                                sumOfSalesQuantity += miktar;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                return new StatisticSalesModel(sumOfSalesQuantity, sumOfSalesPrices);
            }
        }

        public StatisticSalesModel getDaySalesData(int offset, String catergory)
        {
            string query = "";
         
            if (offset != 0)
            {
                query = "SELECT ID, UrunGKategori, Miktar, UrunFiyatSatis, CreatedAt " +
                       "FROM [dbo].[IstatistikSatis] " +
                       "WHERE UrunGKategori='" + catergory + "' AND CAST([CreatedAt] AS DATE) = CAST(GETDATE() " + offset.ToString() + " AS DATE)";
            }else
            {
                query = "SELECT ID, UrunGKategori, Miktar, UrunFiyatSatis, CreatedAt " +
                       "FROM [dbo].[IstatistikSatis] " +
                       "WHERE UrunGKategori='"+ catergory + "' AND CAST([CreatedAt] AS DATE) = CAST(GETDATE() AS DATE)";
            }

            int sumOfSalesQuantity = 0;
            double sumOfSalesPrices = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();

                    // Create a SqlCommand with the query
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Execute the query and read the results
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if there are rows returned
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string kategori = reader.GetString(1);
                                int miktar = reader.GetInt32(2);
                                double fiyat = reader.GetDouble(3);
                                DateTime createdAt = reader.GetDateTime(4);

                                // Print the retrieved data
                                //Debug.WriteLine($"ID: {id}, Kategori: {kategori}, Miktar: {miktar}, Fiyat: {fiyat}, CreatedAt: {createdAt}");

                                sumOfSalesPrices += fiyat;
                                sumOfSalesQuantity += miktar;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                return new StatisticSalesModel(sumOfSalesQuantity, sumOfSalesPrices);
            }
            
        }
        
        public List<string> getDistinctCategories()
        {
            List<string> categories = new List<string>();
            string query = "SELECT DISTINCT UrunGKategori FROM [dbo].[Urun]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        categories.Add(reader["UrunGKategori"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            return categories;
        }
    }
}
