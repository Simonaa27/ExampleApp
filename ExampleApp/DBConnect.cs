using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExampleApp
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string serverName;
        private string dbName;
        private string userID;
        private string password;
        //public int doktor_id;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            serverName = "localhost";
            dbName = "proba_apteka";
            userID = "root";
            password = "root";
            string connectionString;
            connectionString = String.Format("server={0};User Id={1};password={2};database={3}", serverName, userID, password, dbName);

            connection = new MySqlConnection(connectionString);
        }

        //open connection statement
        public bool openConnection() 
        {
            if (connection != null && connection.State == ConnectionState.Closed)
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Не може да се поврзе со серверот.");
                            break;

                        case 1045:
                            MessageBox.Show("Невалидно корисничко име/пасворд. Обидете се пак.");
                            break;
                    }
                    return false;
                }
            }
            return false;
        }

        //Close connection statement
        public bool closeConnection() //to close connection to database
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                try
                {
                    connection.Close();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            }
            return false;
        }

        //Insert statement
        public void Insert(string query)
        {
            if (connection.State == ConnectionState.Open)
            {
               
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeConnection();
            }   
        }

        //Search statement
        public int Search(string query)
        {
            int id = 0;

            if (connection.State == ConnectionState.Open)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["id_pacienti"]);
                    }
                    this.closeConnection();
                    return id;
                }
            }
            this.closeConnection();
            return 0;
        }

        //Select statement
        public object select(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt; 
        }

        //Update statement
        public void Update(string query)
        {
            if (connection.State == ConnectionState.Open)
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandText = query;
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                this.closeConnection();
            }
        }

        //Delete statement
        public void Delete(string query)
        {
            if (connection.State == ConnectionState.Open)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.closeConnection();
            }
        }

        //Login statement
        public int Login(string query)
        {
            int id = 0;

            if (connection.State == ConnectionState.Open)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["id_doktori"]);
                    }
                    this.closeConnection();
                    return id;
                }
            }
            return id;
        }            
    }
}
