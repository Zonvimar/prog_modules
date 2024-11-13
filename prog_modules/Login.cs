using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog_modules
{
    internal class Login
    {
        static public string role, full_name;
        
        static public void Authorization(string login, string password)
        {
            try
            {
                DBconnection.msCommand.CommandText = @"SELECT role_name from roles, users WHERE login = '" + login + "' and password = '" + password + "' and " +
                    "users.role_id=roles.role_id ";
                Object result = DBconnection.msCommand.ExecuteScalar();
                if(result != null)
                {
                    role = result.ToString();
                    
                }
                else
                {
                    role = null;
                    full_name = null;
                }
            }
            catch
            {
                role = null;
                MessageBox.Show("Ошибка при авторизации", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public string AuthorizationName(string login)
        {
            try
            {
                DBconnection.msCommand.CommandText = @"SELECT full_name from users WHERE login = '" + login + "'";
                Object result = DBconnection.msCommand.ExecuteScalar();
                full_name = result.ToString();
                return full_name;
            }
            catch
            {
                return null;
            }
        }
    }
}
