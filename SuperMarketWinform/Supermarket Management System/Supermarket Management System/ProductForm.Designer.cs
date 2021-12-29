
namespace Supermarket_Management_System
{
    partial class ProductForm
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvProductForm = new System.Windows.Forms.DataGridView();
            this.txbPriceProducts = new System.Windows.Forms.TextBox();
            this.txbQuantityProducts = new System.Windows.Forms.TextBox();
            this.txbNameProducts = new System.Windows.Forms.TextBox();
            this.txbIDProducts = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnRefreshProducts = new System.Windows.Forms.Button();
            this.cbSelectCategoryRefresh = new System.Windows.Forms.ComboBox();
            this.btnDeleteProducts = new System.Windows.Forms.Button();
            this.btnEditProducts = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.cbSelectCategory = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSellerProductsForm = new System.Windows.Forms.Button();
            this.btnCategoryProductForm = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.dtgvProductForm);
            this.panel1.Controls.Add(this.txbPriceProducts);
            this.panel1.Controls.Add(this.txbQuantityProducts);
            this.panel1.Controls.Add(this.txbNameProducts);
            this.panel1.Controls.Add(this.txbIDProducts);
            this.panel1.Controls.Add(this.btnShowAll);
            this.panel1.Controls.Add(this.btnRefreshProducts);
            this.panel1.Controls.Add(this.cbSelectCategoryRefresh);
            this.panel1.Controls.Add(this.btnDeleteProducts);
            this.panel1.Controls.Add(this.btnEditProducts);
            this.panel1.Controls.Add(this.btnAddProducts);
            this.panel1.Controls.Add(this.cbSelectCategory);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(130, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 508);
            this.panel1.TabIndex = 0;
            // 
            // dtgvProductForm
            // 
            this.dtgvProductForm.AllowUserToAddRows = false;
            this.dtgvProductForm.AllowUserToDeleteRows = false;
            this.dtgvProductForm.AllowUserToResizeColumns = false;
            this.dtgvProductForm.AllowUserToResizeRows = false;
            this.dtgvProductForm.BackgroundColor = System.Drawing.Color.White;
            this.dtgvProductForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvProductForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductForm.GridColor = System.Drawing.Color.White;
            this.dtgvProductForm.Location = new System.Drawing.Point(347, 122);
            this.dtgvProductForm.Name = "dtgvProductForm";
            this.dtgvProductForm.Size = new System.Drawing.Size(512, 381);
            this.dtgvProductForm.TabIndex = 42;
            this.dtgvProductForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProductForm_CellContentClick);
            // 
            // txbPriceProducts
            // 
            this.txbPriceProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPriceProducts.Location = new System.Drawing.Point(119, 220);
            this.txbPriceProducts.Name = "txbPriceProducts";
            this.txbPriceProducts.Size = new System.Drawing.Size(222, 27);
            this.txbPriceProducts.TabIndex = 41;
            // 
            // txbQuantityProducts
            // 
            this.txbQuantityProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantityProducts.Location = new System.Drawing.Point(119, 175);
            this.txbQuantityProducts.Name = "txbQuantityProducts";
            this.txbQuantityProducts.Size = new System.Drawing.Size(222, 27);
            this.txbQuantityProducts.TabIndex = 40;
            // 
            // txbNameProducts
            // 
            this.txbNameProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameProducts.Location = new System.Drawing.Point(119, 132);
            this.txbNameProducts.Name = "txbNameProducts";
            this.txbNameProducts.Size = new System.Drawing.Size(222, 27);
            this.txbNameProducts.TabIndex = 39;
            // 
            // txbIDProducts
            // 
            this.txbIDProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDProducts.Location = new System.Drawing.Point(119, 85);
            this.txbIDProducts.Name = "txbIDProducts";
            this.txbIDProducts.ReadOnly = true;
            this.txbIDProducts.Size = new System.Drawing.Size(222, 27);
            this.txbIDProducts.TabIndex = 38;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.White;
            this.btnShowAll.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnShowAll.FlatAppearance.BorderSize = 0;
            this.btnShowAll.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnShowAll.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnShowAll.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnShowAll.Location = new System.Drawing.Point(669, 90);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(112, 28);
            this.btnShowAll.TabIndex = 35;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnRefreshProducts
            // 
            this.btnRefreshProducts.BackColor = System.Drawing.Color.White;
            this.btnRefreshProducts.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRefreshProducts.FlatAppearance.BorderSize = 0;
            this.btnRefreshProducts.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnRefreshProducts.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnRefreshProducts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProducts.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRefreshProducts.Location = new System.Drawing.Point(551, 90);
            this.btnRefreshProducts.Name = "btnRefreshProducts";
            this.btnRefreshProducts.Size = new System.Drawing.Size(112, 28);
            this.btnRefreshProducts.TabIndex = 32;
            this.btnRefreshProducts.Text = "Filter";
            this.btnRefreshProducts.UseVisualStyleBackColor = false;
            this.btnRefreshProducts.Click += new System.EventHandler(this.btnRefreshProducts_Click);
            // 
            // cbSelectCategoryRefresh
            // 
            this.cbSelectCategoryRefresh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectCategoryRefresh.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbSelectCategoryRefresh.FormattingEnabled = true;
            this.cbSelectCategoryRefresh.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.cbSelectCategoryRefresh.Location = new System.Drawing.Point(376, 89);
            this.cbSelectCategoryRefresh.Name = "cbSelectCategoryRefresh";
            this.cbSelectCategoryRefresh.Size = new System.Drawing.Size(169, 29);
            this.cbSelectCategoryRefresh.TabIndex = 31;
            this.cbSelectCategoryRefresh.Text = "Select Category";
            // 
            // btnDeleteProducts
            // 
            this.btnDeleteProducts.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteProducts.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDeleteProducts.FlatAppearance.BorderSize = 0;
            this.btnDeleteProducts.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteProducts.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteProducts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProducts.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteProducts.Location = new System.Drawing.Point(219, 326);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Size = new System.Drawing.Size(79, 28);
            this.btnDeleteProducts.TabIndex = 8;
            this.btnDeleteProducts.Text = "DELETE";
            this.btnDeleteProducts.UseVisualStyleBackColor = false;
            this.btnDeleteProducts.Click += new System.EventHandler(this.btnDeleteProducts_Click);
            // 
            // btnEditProducts
            // 
            this.btnEditProducts.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditProducts.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEditProducts.FlatAppearance.BorderSize = 0;
            this.btnEditProducts.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnEditProducts.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnEditProducts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProducts.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEditProducts.Location = new System.Drawing.Point(120, 326);
            this.btnEditProducts.Name = "btnEditProducts";
            this.btnEditProducts.Size = new System.Drawing.Size(79, 28);
            this.btnEditProducts.TabIndex = 7;
            this.btnEditProducts.Text = "EDIT";
            this.btnEditProducts.UseVisualStyleBackColor = false;
            this.btnEditProducts.Click += new System.EventHandler(this.btnEditProducts_Click);
            // 
            // btnAddProducts
            // 
            this.btnAddProducts.BackColor = System.Drawing.Color.White;
            this.btnAddProducts.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddProducts.FlatAppearance.BorderSize = 0;
            this.btnAddProducts.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAddProducts.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAddProducts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducts.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddProducts.Location = new System.Drawing.Point(21, 326);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(79, 28);
            this.btnAddProducts.TabIndex = 6;
            this.btnAddProducts.Text = "ADD";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // cbSelectCategory
            // 
            this.cbSelectCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbSelectCategory.FormattingEnabled = true;
            this.cbSelectCategory.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.cbSelectCategory.Location = new System.Drawing.Point(119, 264);
            this.cbSelectCategory.Name = "cbSelectCategory";
            this.cbSelectCategory.Size = new System.Drawing.Size(169, 29);
            this.cbSelectCategory.TabIndex = 5;
            this.cbSelectCategory.Text = "Select Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 25;
            this.label6.Text = "CATEGORY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "PRICE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "QUANTITY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE PRODUCTS ";
            // 
            // btnSellerProductsForm
            // 
            this.btnSellerProductsForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnSellerProductsForm.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSellerProductsForm.FlatAppearance.BorderSize = 0;
            this.btnSellerProductsForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnSellerProductsForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnSellerProductsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellerProductsForm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellerProductsForm.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSellerProductsForm.Location = new System.Drawing.Point(9, 109);
            this.btnSellerProductsForm.Margin = new System.Windows.Forms.Padding(0);
            this.btnSellerProductsForm.Name = "btnSellerProductsForm";
            this.btnSellerProductsForm.Size = new System.Drawing.Size(103, 39);
            this.btnSellerProductsForm.TabIndex = 0;
            this.btnSellerProductsForm.Text = "Sellers";
            this.btnSellerProductsForm.UseVisualStyleBackColor = false;
            this.btnSellerProductsForm.Click += new System.EventHandler(this.btnSellerProductsForm_Click);
            // 
            // btnCategoryProductForm
            // 
            this.btnCategoryProductForm.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnCategoryProductForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryProductForm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoryProductForm.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCategoryProductForm.Location = new System.Drawing.Point(2, 157);
            this.btnCategoryProductForm.Name = "btnCategoryProductForm";
            this.btnCategoryProductForm.Size = new System.Drawing.Size(127, 38);
            this.btnCategoryProductForm.TabIndex = 1;
            this.btnCategoryProductForm.Text = "Categories";
            this.btnCategoryProductForm.UseVisualStyleBackColor = true;
            this.btnCategoryProductForm.Click += new System.EventHandler(this.btnCategoryProductForm_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.DarkOrange;
            this.button3.Location = new System.Drawing.Point(972, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(12, 509);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 35);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCategoryProductForm);
            this.Controls.Add(this.btnSellerProductsForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSellerProductsForm;
        private System.Windows.Forms.Button btnCategoryProductForm;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSelectCategory;
        private System.Windows.Forms.Button btnDeleteProducts;
        private System.Windows.Forms.Button btnEditProducts;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.Button btnRefreshProducts;
        private System.Windows.Forms.ComboBox cbSelectCategoryRefresh;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txbPriceProducts;
        private System.Windows.Forms.TextBox txbQuantityProducts;
        private System.Windows.Forms.TextBox txbNameProducts;
        private System.Windows.Forms.TextBox txbIDProducts;
        private System.Windows.Forms.DataGridView dtgvProductForm;
        private System.Windows.Forms.Button btnLogout;
    }
}