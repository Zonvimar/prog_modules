using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog_modules
{
    internal class DBconnection
    {
        static string connectionString = @"Server=DESKTOP-TDSIDOR\SQLEXPRESS;Database=prog_modules;Trusted_Connection=True; Integrated Security=True;Encrypt=False";
        static public SqlDataAdapter msDataAdapter;
        static SqlConnection connection;
        static public SqlCommand msCommand;


        public static bool ConnectionDB()
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                msCommand = new SqlCommand();
                msCommand.Connection = connection;
                msDataAdapter = new SqlDataAdapter(msCommand);
                return true;
            }
            catch
            {
                MessageBox.Show("Ошибка соединения с базой данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void ClodeDB()
        {
            connection.Close();
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
