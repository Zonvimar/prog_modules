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
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
        }
        private void LoadComboBoxProductTypes()
        {
            ProductTypes_Class.getProductTypes();
            productTypeAddCbx.DataSource = ProductTypes_Class.dtProductTypes;
            productTypeAddCbx.DisplayMember = "product_type_name";
            productTypeAddCbx.ValueMember = "product_type_id";
            productTypeEditCbx.DataSource = ProductTypes_Class.dtProductTypes;
            productTypeEditCbx.DisplayMember = "product_type_name";
            productTypeEditCbx.ValueMember = "product_type_id";
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxProductTypes();
            addGroupBox.Visible = false;
            editGroupBox.Visible = false;
            Products_Class.getProducts();
            productsGridView.DataSource = Products_Class.dtProduct;
        }


        private void productsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addGroupBox.Visible = true;
            editGroupBox.Visible = false;
        }


        static public string EditProductId, EditProductTypeId, EditProductTypeName, EditProductName, EditProductArticle, EditProductMinCost;


        private void editBtn_Click(object sender, EventArgs e)
        {
            EditProductId = productsGridView.CurrentRow.Cells[0].Value.ToString();
            EditProductTypeId = productsGridView.CurrentRow.Cells[1].Value.ToString();
            EditProductName = productsGridView.CurrentRow.Cells[3].Value.ToString();
            EditProductArticle = productsGridView.CurrentRow.Cells[4].Value.ToString();
            EditProductMinCost = productsGridView.CurrentRow.Cells[5].Value.ToString();

            addGroupBox.Visible = false;
            editGroupBox.Visible = true;

            productTypeAddCbx.SelectedValue = EditProductTypeId;
            productNameEditTbx.Text = EditProductName;
            productArticleEditTbx.Text = EditProductArticle;
            productMinCostEditTbx.Text = EditProductMinCost;
        }

        private void productEditButton_Click(object sender, EventArgs e)
        {
            string productType = productTypeEditCbx.SelectedValue.ToString();
            int product_type_id = int.Parse(productType);


            if (!String.IsNullOrEmpty(productTypeEditCbx.Text) || !String.IsNullOrEmpty(productNameEditTbx.Text) || !String.IsNullOrEmpty(productArticleEditTbx.Text) || !String.IsNullOrEmpty(productMinCostEditTbx.Text))
            {
                if (Products_Class.EditProduct(int.Parse(EditProductId), product_type_id, productNameEditTbx.Text, productArticleEditTbx.Text, productMinCostEditTbx.Text))
                {
                    MessageBox.Show("You have successfully edit a product!", "Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editGroupBox.Visible = false;
                    Products_Class.getProducts();
                    productsGridView.DataSource = Products_Class.dtProduct;
                }
                else
                {
                    MessageBox.Show("The product has not been edit", "Some error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields", "Filling in the fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void productAddCancelBtn_Click(object sender, EventArgs e)
        {
            addGroupBox.Visible = false;
        }

        private void productAddBtn_Click(object sender, EventArgs e)
        {
            string productType = productTypeAddCbx.SelectedValue.ToString();
            int product_type_id = int.Parse(productType);


            if (!String.IsNullOrEmpty(productTypeAddCbx.Text) || !String.IsNullOrEmpty(productNameAddTbx.Text) || !String.IsNullOrEmpty(productArticleAddTbx.Text) || !String.IsNullOrEmpty(productMinCostAddTbx.Text))
            {
                if(Products_Class.AddProduct(product_type_id, productNameAddTbx.Text, productArticleAddTbx.Text, productMinCostAddTbx.Text))
                {
                    MessageBox.Show("You have successfully created a new product!", "Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    addGroupBox.Visible = false;
                    productNameAddTbx.Text = "";
                    productArticleAddTbx.Text = "";
                    productMinCostAddTbx.Text = "";
                    Products_Class.getProducts();
                    productsGridView.DataSource = Products_Class.dtProduct;
                } 
                else
                {
                    MessageBox.Show("The product has not been added", "Some error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill in all required fields", "Filling in the fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string select = productsGridView.CurrentRow.Cells[0].Value.ToString();
                DialogResult del = MessageBox.Show("Do you really want to delete this product?", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (del == DialogResult.Yes)
                {
                    try
                    {
                        Products_Class.DeleteProduct(select);
                        Products_Class.getProducts();
                        productsGridView.DataSource = Products_Class.dtProduct;
                        MessageBox.Show("You have successfully deleted a product!", "Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("The product has not been deleted", "Some error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch
            {
                MessageBox.Show("Error when deleting", "Some error...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
