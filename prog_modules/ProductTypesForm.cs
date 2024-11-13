using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog_modules
{
    public partial class ProductTypesForm : Form
    {
        public ProductTypesForm()
        {
            InitializeComponent();
        }

        private void ProductTypesForm_Load(object sender, EventArgs e)
        {
            ProductTypes_Class.getProductTypes();
            productTypesGridView.DataSource = ProductTypes_Class.dtProductTypes;
            addGroupBox.Visible = false;
            //editGrouBox.Visible = false;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }

        private void deleteBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string select = productTypesGridView.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Do you really want to delete this product?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    string sql = @"SELECT product_type_id FROM products WHERE product_type_id = '" + select + "'";
                    DBconnection.msCommand.CommandText = sql;
                    Object result = DBconnection.msCommand.ExecuteScalar();

                    if (result != null)
                    {
                        MessageBox.Show("You already have an entry with this type in the product table");
                    }
                    else
                    {
                        ProductTypes_Class.DeleteProductType(select);
                        ProductTypes_Class.getProductTypes();
                        productTypesGridView.DataSource = ProductTypes_Class.dtProductTypes;
                        MessageBox.Show("You have successfully deleted a product!", "Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error when deleting", "Some error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void productTypeAddCancelBtn_Click(object sender, EventArgs e)
        {
            addGroupBox.Visible = false;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addGroupBox.Visible = true;
            editGroupBox.Visible = false;
        }

        static public string EditProductTypeId, EditProductTypeName, EditProductTypeRatio;


        private void editBtn_Click(object sender, EventArgs e)
        {
            EditProductTypeId = productTypesGridView.CurrentRow.Cells[0].Value.ToString();
            EditProductTypeName = productTypesGridView.CurrentRow.Cells[1].Value.ToString();
            EditProductTypeRatio = productTypesGridView.CurrentRow.Cells[2].Value.ToString();

            productTypeNameEditTbx.Text = EditProductTypeName;
            productTypeRatioEditTbx.Text = EditProductTypeRatio;
            editGroupBox.Visible = true;
            addGroupBox.Visible = true;
        }

        private void productTypeEditBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(productTypeNameEditTbx.Text) || !String.IsNullOrEmpty(productTypeRatioEditTbx.Text))
            {
                string sql = @"SELECT product_type_name FROM product_types WHERE product_type_name = '" + productTypeNameEditTbx.Text + "' and NOT product_type_id = '" + EditProductTypeId + "'";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("You already have an entry with this type name");
                }
                else
                {
                    if (ProductTypes_Class.EditProductType(int.Parse(EditProductTypeId), productTypeNameEditTbx.Text, productTypeRatioEditTbx.Text))
                    {
                        MessageBox.Show("You have successfully edit a product type!", "Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        editGroupBox.Visible = false;
                        addGroupBox.Visible = false;
                        ProductTypes_Class.getProductTypes();
                        productTypesGridView.DataSource = ProductTypes_Class.dtProductTypes;
                    }
                    else
                    {
                        MessageBox.Show("The product type has not been edit", "Some error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields", "Filling in the fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void productTypeAddBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(productTypeNameAddTbx.Text) || !String.IsNullOrEmpty(productTypeRatioAddTbx.Text))
            {
                string sql = @"SELECT product_type_name FROM product_types WHERE product_type_name = '" + productTypeNameAddTbx.Text + "'";
                DBconnection.msCommand.CommandText = sql;
                Object result = DBconnection.msCommand.ExecuteScalar();

                if (result != null)
                {
                    MessageBox.Show("You already have an entry with this type name");
                }
                else
                {
                    if (ProductTypes_Class.AddProductType(productTypeNameAddTbx.Text, productTypeRatioAddTbx.Text))
                    {
                        MessageBox.Show("You have successfully created a new product type!", "Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        addGroupBox.Visible = false;
                        productTypeNameAddTbx.Text = "";
                        productTypeRatioAddTbx.Text = "";
                        ProductTypes_Class.getProductTypes();
                        productTypesGridView.DataSource = ProductTypes_Class.dtProductTypes;
                    }
                    else
                    {
                        MessageBox.Show("The product type has not been added", "Some error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Please fill in all required fields", "Filling in the fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void productTypeEditCancelBtn_Click(object sender, EventArgs e)
        {
            editGroupBox.Visible = false;
        }
    }
}
