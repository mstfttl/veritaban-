using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GroupProject.database
{
    internal class dbconfig
    {
        public void StartConn()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=;Username=root;Password="))
            {
                try
                {
                    if (connection.State == System.Data.ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void EndConn()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=;Username=root;Password="))
            {
                try
                {
                    if (connection.State == System.Data.ConnectionState.Open)
                    {
                        connection.Close();
                    }

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public MySqlConnection GetConn()
        {
            using (MySqlConnection connection = new MySqlConnection("Server=localhost;Database=;Username=root;Password="))
            {
                try
                {
                    return connection;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
    }
}
