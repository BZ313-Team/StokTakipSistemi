using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using StokTakipSistemi.model;
using StokTakipSistemi;

namespace StokTakipSistemi.controller
{
    using StokTakipSistemi;
    internal class AuthenticationController
    {
        SQLIslemleri  sqlIslemleri = new SQLIslemleri();
       
        
        /*private string connectionString = "Data Source=DESKTOP-IRAO93A\\SQLEXPRESS;Database=fatih;Integrated Security=True;TrustServerCertificate=True;";
        private string query = "SELECT * FROM Users";*/

        public Boolean login(UserModel userModel)
        {
            
            string connectionString = sqlIslemleri.GetBaglanti();
            string query = sqlIslemleri.GetSorguAuthentication();

            List<UserModel> users = new List<UserModel>();
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
                                // Debug.WriteLine($"Password: {reader["Password"]}, Username: {reader["Username"]}");
                                users.Add(new UserModel(reader["Username"].ToString(), reader["Password"].ToString()));
                            }
                        }
                    }

                    bool isUserExist = false;

                    foreach(var model in users)
                    {
                        if(model.getPassword() == userModel.getPassword() && model.getUserName() == userModel.getUserName())
                        {
                            isUserExist = true;
                            break;
                        }
                    }

                    return isUserExist;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("AuthenticationController -> login() error: " + ex.Message);
                    return false;
                }
            }
        }

    }
}
