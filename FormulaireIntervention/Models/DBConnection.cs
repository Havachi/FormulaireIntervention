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
        private MySqlConnection connection;
        private MySqlCommand command;

        //Constructors
        public DBConnection()
        {
            Init();
        }
       
        //Privates Methodes
        private void Init()
        {
            MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();
            stringBuilder.Server = "localhost";           
            stringBuilder.Database = "formulaireintervention";
            stringBuilder.UserID = "DBconnector";
            stringBuilder.Password = "Pa$$w0rd";
            connection = new MySqlConnection(stringBuilder.ToString());
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
        
        //Publics Methodes
        public void InsertNewClientInDatabase(string firstName, string lastName, string address, string phoneNumber)
        {         
            string insertCommand = $@"INSERT INTO clients(ClientFirstName, ClientLastName, ClientAddress, ClientPhoneNumber) VALUES ('{firstName}','{lastName}','{address}','{phoneNumber}')";

            command = new MySqlCommand(insertCommand,connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
        }
        public void InsertNewClientInDatabase(int ID,string firstName, string lastName, string address, string phoneNumber)
        {
            string insertCommand = $@"INSERT INTO clients(ClientID,ClientFirstName, ClientLastName, ClientAddress, ClientPhoneNumber) VALUES ('{ID}','{firstName}','{lastName}','{address}','{phoneNumber}')";

            command = new MySqlCommand(insertCommand, connection);
            int result = command.ExecuteNonQuery();
            connection.Close();
        }
        public void InsertNewIntervention()
        {
            //todo code dis
        }

        public List<string> SelectOneClientInDB(int ID)
        {
            string selectCommand = $@"SELECT * FROM clients WHERE ClientID = '{ID}' ;";
            command = new MySqlCommand(selectCommand, connection);
            var reader = command.ExecuteReader();
            var resultList = new List<string>();
            if (reader.HasRows)
            {
                int counter = 0;
                while (reader.Read())
                {
                    resultList.Add(reader.GetString(counter));
                    counter++; 
                }
            }
            reader.Close();
            connection.Close();
            return resultList;
        }
        public int SelectClientIDInDB(string firstName, string lastName)
        {
            string selectCommand = $@"SELECT ClientID FROM clients WHERE ClientFirstName = '{firstName}' AND ClientLastName = '{lastName}'  ;";
            command = new MySqlCommand(selectCommand, connection);
            var reader = command.ExecuteReader();
            int resultID = 0;
            if (reader.HasRows)
            {
                int counter = 0;
                while (reader.Read())
                {
                    resultID = reader.GetInt16(0);
                    counter++;
                }
            }
            reader.Close();
            connection.Close();
            return resultID;
        }
        public void DeleteUserInDB(int ID)
        {
            string selectCommand = $@"DELETE FROM clients WHERE ClientID = '{ID}' ;";
            command = new MySqlCommand(selectCommand, connection);
            int result = command.ExecuteNonQuery();
            if (result != 1)
            {
                throw new UnknownClient("The client isn't existing in database");
            }   
            
        }
        public void DeleteUserInDB(string firstName, string lastName)
        {
            string selectCommand = $@"SELECT ClientID FROM clients WHERE ClientFirstName = '{firstName}'  AND ClientLastName = '{lastName}' ;";
            command = new MySqlCommand(selectCommand, connection);
            var reader = command.ExecuteReader();
            List<int> IDList = new List<int>();
            int counter = 0;
            if (reader.HasRows)
            {
                
                while (reader.Read())
                {
                    IDList.Add( reader.GetInt16(0));
                    counter++;
                }
            }

            reader.Close();
            
            if (counter == 0)
            {
                throw new UnknownClient("The client isn't existing in database");
            }
            else
            {
                foreach (var id in IDList)
                {
                    DeleteUserInDB(id);
                }             
            }
            connection.Close();
        }             
        public List<Intervenant> GetListOfIntervenant()
        {
            List<Intervenant> listIntervernant = new List<Intervenant>();
            Intervenant intervenant;
            string selectCommand = $@"SELECT IntervenantFirstName, IntervenantLastName FROM intervenant;";
            command = new MySqlCommand(selectCommand, connection);
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                int counter = 0;
                while (reader.Read())
                {
                    intervenant = new Intervenant();
                    intervenant.FirstName = reader.GetString(0);
                    intervenant.LastName = reader.GetString(1);
                    listIntervernant.Add(intervenant);
                    counter++;
                }

            }
            reader.Close();
            connection.Close();
            return listIntervernant;
        }
        public List<InterventionType> GetListOfInterventionType()
        {
            List<InterventionType> listInterventionTypes = new List<InterventionType>();
            InterventionType interventionType;
            string selectCommand = $@"SELECT InterventionTypeName FROM interventiontype;";
            command = new MySqlCommand(selectCommand, connection);
            var reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                int counter = 0;
                while (reader.Read())
                {
                    interventionType = new InterventionType();
                    interventionType.Type = reader.GetString(0);
                    listInterventionTypes.Add(interventionType);
                    counter++;
                }

            }
            reader.Close();
            connection.Close();
            return listInterventionTypes;
        }
    }
}