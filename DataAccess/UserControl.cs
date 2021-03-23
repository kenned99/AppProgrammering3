using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    class UserControl
    {
        public bool tjekLogin(string username, string password)
        {

            string connStr = "server=localhost;user=root;database=telefonselskabet;port=3306;";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("Connecting to MySQL...");
                conn.Open();

                string sql = "SELECT * FROM users WHERE username='" + username + "' && password='" + password + "'";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Console.WriteLine(rdr[1] + " -- " + rdr[2] + " -- " + rdr[3] + " -- " + rdr[4]);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
            return true;
        }
    }
}
