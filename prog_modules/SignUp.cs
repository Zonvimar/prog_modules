using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog_modules
{
    internal class SignUp
    {

        static public bool Registration(string login, string password, string full_name, string phone, string email)
        {
            try
            {
                DBconnection.msCommand.CommandText = @"INSERT INTO users (role_id, login, password, full_name, phone_number, email) VALUES(3, " + login + ", " + password + ", " + full_name + ", " + phone + ", " + email + ")";
                if (DBconnection.msCommand.ExecuteNonQuery() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка при регистрации", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
