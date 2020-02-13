using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace FormulaireIntervention.Models
{
    public class DBConnection
    {
        string connectionString;
        private MySqlConnection connection;

        private void Init()
        {
            connectionString = $@"Host=localhost; Database=formulaireintervention; Username=dbconnector; Password=Pa$$w0rd";
            connection = new MySqlConnection(connectionString);
            connection.Open();
        }
        private void Open(MySqlConnection connection)
        {
            connection.Open();
        }
        private void Close(MySqlConnection connection)
        {
            connection.Dispose();
        }
        
        public void InsertNewClientInDatabase(string firstName, string lastName, string address, string phoneNumber)
        {
            Init();
           
            string insertCommand = $@"INSERT INTO clients(ClientFirstName, ClientLastName, ClientAddress, ClientPhoneNumber)
                                        values (@firstName, @lastName,@address,@phoneNumber)";

            MySqlCommand command = new MySqlCommand(insertCommand,connection);

            command.Parameters.AddWithValue("@firstName", firstName);
            command.Parameters.AddWithValue("@lastName", lastName);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            int result = command.ExecuteNonQuery();
            connection.Close();
        }
    }
}