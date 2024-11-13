namespace prog_modules
{
    partial class ProductTypesForm
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
            this.productTypesGridView = new System.Windows.Forms.DataGridView();
            this.product_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.product_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratio_tp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.addGroupBox = new System.Windows.Forms.GroupBox();
            this.editGroupBox = new System.Windows.Forms.GroupBox();
            this.productTypeEditCancelBtn = new System.Windows.Forms.Button();
            this.productTypeEditBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.productTypeRatioEditTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.productTypeNameEditTbx = new System.Windows.Forms.TextBox();
            this.productTypeAddCancelBtn = new System.Windows.Forms.Button();
            this.productTypeAddBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.productTypeRatioAddTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.productTypeNameAddTbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productTypesGridView)).BeginInit();
            this.addGroupBox.SuspendLayout();
            this.editGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // productTypesGridView
            // 
            this.productTypesGridView.AllowUserToAddRows = false;
            this.productTypesGridView.AllowUserToDeleteRows = false;
            this.productTypesGridView.AllowUserToResizeColumns = false;
            this.productTypesGridView.AllowUserToResizeRows = false;
            this.productTypesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productTypesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.product_type_id,
            this.product_type_name,
            this.ratio_tp});
            this.productTypesGridView.Location = new System.Drawing.Point(12, 12);
            this.productTypesGridView.Name = "productTypesGridView";
            this.productTypesGridView.ReadOnly = true;
            this.productTypesGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productTypesGridView.Size = new System.Drawing.Size(550, 184);
            this.productTypesGridView.TabIndex = 2;
            // 
            // product_type_id
            // 
            this.product_type_id.DataPropertyName = "product_type_id";
            this.product_type_id.HeaderText = "product_type_id";
            this.product_type_id.Name = "product_type_id";
            this.product_type_id.ReadOnly = true;
            this.product_type_id.Visible = false;
            // 
            // product_type_name
            // 
            this.product_type_name.DataPropertyName = "product_type_name";
            this.product_type_name.HeaderText = "Name";
            this.product_type_name.Name = "product_type_name";
            this.product_type_name.ReadOnly = true;
            this.product_type_name.Width = 350;
            // 
            // ratio_tp
            // 
            this.ratio_tp.DataPropertyName = "ratio_tp";
            this.ratio_tp.HeaderText = "Ratio TP";
            this.ratio_tp.Name = "ratio_tp";
            this.ratio_tp.ReadOnly = true;
            this.ratio_tp.Width = 155;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(418, 282);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(144, 34);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete selected";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click_1);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(418, 242);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(144, 34);
            this.editBtn.TabIndex = 9;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(418, 202);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(144, 34);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.backButton.Location = new System.Drawing.Point(489, 420);
            this.backButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(73, 27);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addGroupBox
            // 
            this.addGroupBox.Controls.Add(this.editGroupBox);
            this.addGroupBox.Controls.Add(this.productTypeAddCancelBtn);
            this.addGroupBox.Controls.Add(this.productTypeAddBtn);
            this.addGroupBox.Controls.Add(this.label3);
            this.addGroupBox.Controls.Add(this.productTypeRatioAddTbx);
            this.addGroupBox.Controls.Add(this.label2);
            this.addGroupBox.Controls.Add(this.productTypeNameAddTbx);
            this.addGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGroupBox.Location = new System.Drawing.Point(72, 205);
            this.addGroupBox.Name = "addGroupBox";
            this.addGroupBox.Size = new System.Drawing.Size(274, 244);
            this.addGroupBox.TabIndex = 11;
            this.addGroupBox.TabStop = false;
            this.addGroupBox.Text = "Add product type";
            // 
            // editGroupBox
            // 
            this.editGroupBox.Controls.Add(this.productTypeEditCancelBtn);
            this.editGroupBox.Controls.Add(this.productTypeEditBtn);
            this.editGroupBox.Controls.Add(this.label1);
            this.editGroupBox.Controls.Add(this.productTypeRatioEditTbx);
            this.editGroupBox.Controls.Add(this.label4);
            this.editGroupBox.Controls.Add(this.productTypeNameEditTbx);
            this.editGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editGroupBox.Location = new System.Drawing.Point(0, 0);
            this.editGroupBox.Name = "editGroupBox";
            this.editGroupBox.Size = new System.Drawing.Size(274, 244);
            this.editGroupBox.TabIndex = 17;
            this.editGroupBox.TabStop = false;
            this.editGroupBox.Text = "Edit product type";
            // 
            // productTypeEditCancelBtn
            // 
            this.productTypeEditCancelBtn.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeEditCancelBtn.Location = new System.Drawing.Point(20, 198);
            this.productTypeEditCancelBtn.Name = "productTypeEditCancelBtn";
            this.productTypeEditCancelBtn.Size = new System.Drawing.Size(231, 32);
            this.productTypeEditCancelBtn.TabIndex = 16;
            this.productTypeEditCancelBtn.Text = "Cancel";
            this.productTypeEditCancelBtn.UseVisualStyleBackColor = true;
            this.productTypeEditCancelBtn.Click += new System.EventHandler(this.productTypeEditCancelBtn_Click);
            // 
            // productTypeEditBtn
            // 
            this.productTypeEditBtn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeEditBtn.Location = new System.Drawing.Point(20, 148);
            this.productTypeEditBtn.Name = "productTypeEditBtn";
            this.productTypeEditBtn.Size = new System.Drawing.Size(231, 44);
            this.productTypeEditBtn.TabIndex = 15;
            this.productTypeEditBtn.Text = "Edit";
            this.productTypeEditBtn.UseVisualStyleBackColor = true;
            this.productTypeEditBtn.Click += new System.EventHandler(this.productTypeEditBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label1.Location = new System.Drawing.Point(18, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ratio TP";
            // 
            // productTypeRatioEditTbx
            // 
            this.productTypeRatioEditTbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeRatioEditTbx.Location = new System.Drawing.Point(20, 109);
            this.productTypeRatioEditTbx.Name = "productTypeRatioEditTbx";
            this.productTypeRatioEditTbx.Size = new System.Drawing.Size(231, 33);
            this.productTypeRatioEditTbx.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label4.Location = new System.Drawing.Point(18, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // productTypeNameEditTbx
            // 
            this.productTypeNameEditTbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeNameEditTbx.Location = new System.Drawing.Point(20, 51);
            this.productTypeNameEditTbx.Name = "productTypeNameEditTbx";
            this.productTypeNameEditTbx.Size = new System.Drawing.Size(231, 33);
            this.productTypeNameEditTbx.TabIndex = 9;
            // 
            // productTypeAddCancelBtn
            // 
            this.productTypeAddCancelBtn.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeAddCancelBtn.Location = new System.Drawing.Point(20, 198);
            this.productTypeAddCancelBtn.Name = "productTypeAddCancelBtn";
            this.productTypeAddCancelBtn.Size = new System.Drawing.Size(231, 32);
            this.productTypeAddCancelBtn.TabIndex = 16;
            this.productTypeAddCancelBtn.Text = "Cancel";
            this.productTypeAddCancelBtn.UseVisualStyleBackColor = true;
            this.productTypeAddCancelBtn.Click += new System.EventHandler(this.productTypeAddCancelBtn_Click);
            // 
            // productTypeAddBtn
            // 
            this.productTypeAddBtn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeAddBtn.Location = new System.Drawing.Point(20, 148);
            this.productTypeAddBtn.Name = "productTypeAddBtn";
            this.productTypeAddBtn.Size = new System.Drawing.Size(231, 44);
            this.productTypeAddBtn.TabIndex = 15;
            this.productTypeAddBtn.Text = "Add";
            this.productTypeAddBtn.UseVisualStyleBackColor = true;
            this.productTypeAddBtn.Click += new System.EventHandler(this.productTypeAddBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label3.Location = new System.Drawing.Point(18, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ratio TP";
            // 
            // productTypeRatioAddTbx
            // 
            this.productTypeRatioAddTbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeRatioAddTbx.Location = new System.Drawing.Point(20, 109);
            this.productTypeRatioAddTbx.Name = "productTypeRatioAddTbx";
            this.productTypeRatioAddTbx.Size = new System.Drawing.Size(231, 33);
            this.productTypeRatioAddTbx.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 10.25F);
            this.label2.Location = new System.Drawing.Point(18, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // productTypeNameAddTbx
            // 
            this.productTypeNameAddTbx.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productTypeNameAddTbx.Location = new System.Drawing.Point(20, 51);
            this.productTypeNameAddTbx.Name = "productTypeNameAddTbx";
            this.productTypeNameAddTbx.Size = new System.Drawing.Size(231, 33);
            this.productTypeNameAddTbx.TabIndex = 9;
            // 
            // ProductTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 461);
            this.Controls.Add(this.addGroupBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.productTypesGridView);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "ProductTypesForm";
            this.Text = "Product Types";
            this.Load += new System.EventHandler(this.ProductTypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productTypesGridView)).EndInit();
            this.addGroupBox.ResumeLayout(false);
            this.addGroupBox.PerformLayout();
            this.editGroupBox.ResumeLayout(false);
            this.editGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView productTypesGridView;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn product_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratio_tp;
        private System.Windows.Forms.GroupBox addGroupBox;
        private System.Windows.Forms.Button productTypeAddCancelBtn;
        private System.Windows.Forms.Button productTypeAddBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productTypeRatioAddTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productTypeNameAddTbx;
        private System.Windows.Forms.GroupBox editGroupBox;
        private System.Windows.Forms.Button productTypeEditCancelBtn;
        private System.Windows.Forms.Button productTypeEditBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productTypeRatioEditTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox productTypeNameEditTbx;
    }
}