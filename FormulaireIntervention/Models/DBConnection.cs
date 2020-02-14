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
        public void SelectInDB(string table)
        {
            Init();
            string selectCommand = $@"SELECT * IN {table};";
        }
        public void SelectInDB(string table, string column)
        {
            Init();
            string selectCommand = $@"SELECT {column} IN {table};";
        }
        public void SelectInDB(string table, int ID)
        {
            Init();
            string selectCommand = "";
            MySqlCommand command;
            MySqlDataReader dataReader;
            if (table == "clients")
            {
                selectCommand = $@"SELECT * IN {table} WHERE ClientID = '1' ;";
            }
            else if (table == "intervenant")
            {
                selectCommand = $@"SELECT * IN {table} WHERE IntervenantID = '1' ;";
            }

            command = new MySqlCommand(selectCommand, connection);
            
        }
    }
}