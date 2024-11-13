namespace prog_modules
{
    partial class ProductsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.productAddCancelBtn = new System.Windows.Forms.Button();
            this.productAddBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.productMinCostAddTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productArticleAddTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productNameAddTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.productTypeAddCbx = new System.Windows.Forms.ComboBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.productEditCancelBtn = new System.Windows.Forms.Button();
            this.productEditButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.productMinCostEditTbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.productArticleEditTbx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productNameEditTbx = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.productTypeEditCbx = new System.Windows.Forms.ComboBox();
            this.product_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min_cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.editGroupBox.SuspendLayout();
            this.addGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.backButton.Location = new System.Drawing.Point(828, 522);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(73, 27);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToAddRows = false;
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.AllowUserToResizeColumns = false;
            this.productsGridView.AllowUserToResizeRows = false;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_id,
            this.product_type_id,
            this.name,
            this.product_type_name,
            this.article,
            this.min_cost});
            this.productsGridView.Location = new System.Drawing.Point(12, 12);
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productsGridView.Size = new System.Drawing.Size(889, 184);
            this.productsGridView.TabIndex = 1;
            this.productsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellContentClick);
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.productEditCancelBtn);
            this.editGroupBox.Controls.Add(this.productEditButton);
            this.editGroupBox.Controls.Add(this.label5);
            this.editGroupBox.Controls.Add(this.productMinCostEditTbx);
            this.editGroupBox.Controls.Add(this.label6);
            this.editGroupBox.Controls.Add(this.productArticleEditTbx);
            this.editGroupBox.Controls.Add(this.label7);
            this.editGroupBox.Controls.Add(this.productNameEditTbx);
            this.editGroupBox.Controls.Add(this.label8);
            this.editGroupBox.Controls.Add(this.productTypeEditCbx);
            this.editGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGroupBox.Location = new System.Drawing.Point(304, 202);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(274, 356);
            this.editGroupBox.TabIndex = 2;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "Edit product";
            this.editGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.productAddCancelBtn);
            this.addGroupBox.Controls.Add(this.productAddBtn);
            this.addGroupBox.Controls.Add(this.label4);
            this.addGroupBox.Controls.Add(this.productMinCostAddTbx);
            this.addGroupBox.Controls.Add(this.label3);
            this.addGroupBox.Controls.Add(this.productArticleAddTbx);
            this.addGroupBox.Controls.Add(this.label2);
            this.addGroupBox.Controls.Add(this.productNameAddTbx);
            this.addGroupBox.Controls.Add(this.label1);
            this.addGroupBox.Controls.Add(this.productTypeAddCbx);
            this.addGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBox.Location = new System.Drawing.Point(12, 202);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(274, 356);
            this.addGroupBox.TabIndex = 3;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add product";
            // 
            // productAddCancelBtn
            // 
            this.productAddCancelBtn.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productAddCancelBtn.Location = new System.Drawing.Point(19, 315);
            this.productAddCancelBtn.Name = "productAddCancelBtn";
            this.productAddCancelBtn.Size = new System.Drawing.Size(231, 32);
            this.productAddCancelBtn.TabIndex = 16;
            this.productAddCancelBtn.Text = "Cancel";
            this.productAddCancelBtn.UseVisualStyleBackColor = true;
            this.productAddCancelBtn.Click += new System.EventHandler(this.productAddCancelBtn_Click);
            // 
            // productAddBtn
            // 
            this.productAddBtn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productAddBtn.Location = new System.Drawing.Point(19, 265);
            this.productAddBtn.Name = "productAddBtn";
            this.productAddBtn.Size = new System.Drawing.Size(231, 44);
            this.productAddBtn.TabIndex = 15;
            this.productAddBtn.Text = "Add";
            this.productAddBtn.UseVisualStyleBackColor = true;
            this.productAddBtn.Click += new System.EventHandler(this.productAddBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label4.Location = new System.Drawing.Point(17, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "MInimal Cost";
            // 
            // productMinCostAddTbx
            // 
            this.productMinCostAddTbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productMinCostAddTbx.Location = new System.Drawing.Point(20, 224);
            this.productMinCostAddTbx.Name = "productMinCostAddTbx";
            this.productMinCostAddTbx.Size = new System.Drawing.Size(231, 33);
            this.productMinCostAddTbx.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label3.Location = new System.Drawing.Point(17, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Article";
            // 
            // productArticleAddTbx
            // 
            this.productArticleAddTbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productArticleAddTbx.Location = new System.Drawing.Point(19, 166);
            this.productArticleAddTbx.Name = "productArticleAddTbx";
            this.productArticleAddTbx.Size = new System.Drawing.Size(231, 33);
            this.productArticleAddTbx.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label2.Location = new System.Drawing.Point(17, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // productNameAddTbx
            // 
            this.productNameAddTbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameAddTbx.Location = new System.Drawing.Point(19, 108);
            this.productNameAddTbx.Name = "productNameAddTbx";
            this.productNameAddTbx.Size = new System.Drawing.Size(231, 33);
            this.productNameAddTbx.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product Type";
            // 
            // productTypeAddCbx
            // 
            this.productTypeAddCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTypeAddCbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeAddCbx.FormattingEnabled = true;
            this.productTypeAddCbx.Location = new System.Drawing.Point(20, 50);
            this.productTypeAddCbx.Name = "productTypeAddCbx";
            this.productTypeAddCbx.Size = new System.Drawing.Size(231, 33);
            this.productTypeAddCbx.TabIndex = 7;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(722, 208);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(179, 34);
            this.addBtn.TabIndex = 4;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(722, 252);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(179, 34);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(722, 295);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(179, 34);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete selected";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // productEditCancelBtn
            // 
            this.productEditCancelBtn.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productEditCancelBtn.Location = new System.Drawing.Point(22, 314);
            this.productEditCancelBtn.Name = "productEditCancelBtn";
            this.productEditCancelBtn.Size = new System.Drawing.Size(231, 32);
            this.productEditCancelBtn.TabIndex = 26;
            this.productEditCancelBtn.Text = "Cancel";
            this.productEditCancelBtn.UseVisualStyleBackColor = true;
            // 
            // productEditButton
            // 
            this.productEditButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productEditButton.Location = new System.Drawing.Point(22, 264);
            this.productEditButton.Name = "productEditButton";
            this.productEditButton.Size = new System.Drawing.Size(231, 44);
            this.productEditButton.TabIndex = 25;
            this.productEditButton.Text = "Edit";
            this.productEditButton.UseVisualStyleBackColor = true;
            this.productEditButton.Click += new System.EventHandler(this.productEditButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label5.Location = new System.Drawing.Point(20, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "MInimal Cost";
            // 
            // productMinCostEditTbx
            // 
            this.productMinCostEditTbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productMinCostEditTbx.Location = new System.Drawing.Point(23, 223);
            this.productMinCostEditTbx.Name = "productMinCostEditTbx";
            this.productMinCostEditTbx.Size = new System.Drawing.Size(231, 33);
            this.productMinCostEditTbx.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label6.Location = new System.Drawing.Point(20, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Article";
            // 
            // productArticleEditTbx
            // 
            this.productArticleEditTbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productArticleEditTbx.Location = new System.Drawing.Point(22, 165);
            this.productArticleEditTbx.Name = "productArticleEditTbx";
            this.productArticleEditTbx.Size = new System.Drawing.Size(231, 33);
            this.productArticleEditTbx.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label7.Location = new System.Drawing.Point(20, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 20;
            this.label7.Text = "Name";
            // 
            // productNameEditTbx
            // 
            this.productNameEditTbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productNameEditTbx.Location = new System.Drawing.Point(22, 107);
            this.productNameEditTbx.Name = "productNameEditTbx";
            this.productNameEditTbx.Size = new System.Drawing.Size(231, 33);
            this.productNameEditTbx.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label8.Location = new System.Drawing.Point(20, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Product Type";
            // 
            // productTypeEditCbx
            // 
            this.productTypeEditCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productTypeEditCbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeEditCbx.FormattingEnabled = true;
            this.productTypeEditCbx.Location = new System.Drawing.Point(23, 49);
            this.productTypeEditCbx.Name = "productTypeEditCbx";
            this.productTypeEditCbx.Size = new System.Drawing.Size(231, 33);
            this.productTypeEditCbx.TabIndex = 17;
            // 
            // product_id
            // 
            this.product_id.DataPropertyName = "product_id";
            this.product_id.HeaderText = "product_id";
            this.product_id.Name = "product_id";
            this.product_id.ReadOnly = true;
            this.product_id.Visible = false;
            // 
            // product_type_id
            // 
            this.product_type_id.DataPropertyName = "product_type_id";
            this.product_type_id.HeaderText = "product_type_id";
            this.product_type_id.Name = "product_type_id";
            this.product_type_id.ReadOnly = true;
            this.product_type_id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 325;
            // 
            // product_type_name
            // 
            this.product_type_name.DataPropertyName = "product_type_name";
            this.product_type_name.HeaderText = "Product Type";
            this.product_type_name.Name = "product_type_name";
            this.product_type_name.ReadOnly = true;
            this.product_type_name.Width = 290;
            // 
            // article
            // 
            this.article.DataPropertyName = "article";
            this.article.HeaderText = "Article";
            this.article.Name = "article";
            this.article.ReadOnly = true;
            // 
            // min_cost
            // 
            this.min_cost.DataPropertyName = "min_cost";
            this.min_cost.HeaderText = "Minimal Cost";
            this.min_cost.Name = "min_cost";
            this.min_cost.ReadOnly = true;
            this.min_cost.Width = 130;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 561);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editGroupBox);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.backButton);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(929, 600);
            this.MinimumSize = new System.Drawing.Size(929, 600);
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.editGroupBox.ResumeLayout(false);
            this.editGroupBox.PerformLayout();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox productTypeAddCbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productNameAddTbx;
        private System.Windows.Forms.Button productAddBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productMinCostAddTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productArticleAddTbx;
        private System.Windows.Forms.Button productAddCancelBtn;
        private System.Windows.Forms.Button productEditCancelBtn;
        private System.Windows.Forms.Button productEditButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox productMinCostEditTbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productArticleEditTbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox productNameEditTbx;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox productTypeEditCbx;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn min_cost;
    }
}