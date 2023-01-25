using FinalProject.FP;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FinalProject
{
   
    public class mydb : DbContext
    {
        public mydb()
            : base("name=MYDB1")
        {
        }
       
        public MySqlConnection connection = new MySqlConnection(
               "server=localhost;port=3306;username=root;password=;database=bioskop");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
        public int setData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, getConnection());

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            openConnection();

            int commandState = command.ExecuteNonQuery();

            closeConnection();
            return commandState;
        }
        public DataTable getData(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, getConnection());

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        public DataTable Get(int id,string query)
        {
            DataTable table = new DataTable();
            table = getData(query, null);
     
            return table;
        }







    }

    
}