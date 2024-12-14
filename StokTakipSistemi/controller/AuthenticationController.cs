using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using StokTakipSistemi.model;

namespace StokTakipSistemi.controller
{
    internal class AuthenticationController
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS01;Initial Catalog=master;Integrated Security=True;TrustServerCertificate=True";
        private string query = "SELECT * FROM dbo.Users";

        public Boolean login(UserModel userModel)
        {
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
