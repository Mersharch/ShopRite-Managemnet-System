using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace ShopRite
{
    internal class db
    {
        public static string conString = "server=localhost; database=shopritedatabase; uid=root; pwd=\"\";";
        public static MySqlConnection connection = new MySqlConnection(conString);

        public static void open()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error connecting to Database");
                Console.WriteLine(ex.Message);
            }
            

        }

        public static void close()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error terminating Database connection");
                Console.WriteLine(ex.Message);
            }


        }
    }
}
