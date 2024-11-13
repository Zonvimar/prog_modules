using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace prog_modules
{
    internal class Products_Class : DBconnection
    {
        static public DataTable dtProduct = new DataTable();

        static public void getProducts()
        {
            try
            {
                msCommand.CommandText = @"SELECT products.product_id, products.product_type_id, product_types.product_type_name, products.name, products.article, products.min_cost FROM products, product_types WHERE products.product_type_id=product_types.product_type_id";
                dtProduct.Clear();
                msDataAdapter.SelectCommand = msCommand;
                msDataAdapter.Fill(dtProduct);
            }
            catch
            {
                MessageBox.Show("Error receiving data", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool AddProduct(int product_type_id, string name, string article, string min_cost)
        {
            try
            {
                msCommand.CommandText = @"INSERT INTO products (product_type_id, name, article, min_cost) VALUES('" + product_type_id + "', '" + name + "', '" + article + "', '" + min_cost + "') ";
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

        static public bool EditProduct(int product_id, int product_type_id, string name, string article, string min_cost)
        {
            try
            {
                msCommand.CommandText = @"UPDATE products SET product_type_id = '" + product_type_id + "', name = '" + name + "', article = '" + article + "', min_cost = '" + min_cost + "' WHERE product_id = '" + product_id + "' ";
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
    


        static public void DeleteProduct(string del)
        {
            try
            {
                msCommand.CommandText = @"DELETE FROM products WHERE product_id = '" + del + "';";
                msCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Errrrooooorrr", "Errrrooooorrr!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
