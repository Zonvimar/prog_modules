using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog_modules
{
    internal class ProductTypes_Class : DBconnection
    {
        static public DataTable dtProductTypes = new DataTable();

        static public void getProductTypes()
        {
            try
            {
                DBconnection.msCommand.CommandText = @"SELECT * FROM product_types";
                dtProductTypes.Clear();
                DBconnection.msDataAdapter.SelectCommand = DBconnection.msCommand;
                DBconnection.msDataAdapter.Fill(dtProductTypes);
            }
            catch
            {
                MessageBox.Show("Error receiving data", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddProductType(string product_type_name, string ratio_tp)
        {
            try
            {
                msCommand.CommandText = @"INSERT INTO product_types (product_type_name, ratio_tp) VALUES('" + product_type_name + "', '" + ratio_tp + "') ";
                if (msCommand.ExecuteNonQuery() > 0)
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
                MessageBox.Show("Errrrooooorrr", "Errrrooooorrr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        static public bool EditProductType(int product_type_id, string product_type_name, string ratio_tp)
        {
            try
            {
                msCommand.CommandText = @"UPDATE product_types SET product_type_name = '" + product_type_name + "', ratio_tp = '" + ratio_tp + "' WHERE product_type_id = '" + product_type_id + "' ";
                if (msCommand.ExecuteNonQuery() > 0)
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
                MessageBox.Show("Errrrooooorrr", "Errrrooooorrr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }



        static public void DeleteProductType(string del)
        {
            try
            {
                msCommand.CommandText = @"DELETE FROM product_types WHERE product_type_id = '" + del + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Errrrooooorrr", "Errrrooooorrr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
