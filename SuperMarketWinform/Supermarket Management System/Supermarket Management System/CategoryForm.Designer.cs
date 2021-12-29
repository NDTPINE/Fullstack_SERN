
namespace Supermarket_Management_System
{
    partial class CategoryForm
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
            this.dtgvCategoryForm = new System.Windows.Forms.DataGridView();
            this.txbDescriptionCategory = new System.Windows.Forms.TextBox();
            this.txbNameCategory = new System.Windows.Forms.TextBox();
            this.txbIDCategory = new System.Windows.Forms.TextBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProductCategoryForm = new System.Windows.Forms.Button();
            this.btnSellerCategoryForm = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategoryForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.dtgvCategoryForm);
            this.panel1.Controls.Add(this.txbDescriptionCategory);
            this.panel1.Controls.Add(this.txbNameCategory);
            this.panel1.Controls.Add(this.txbIDCategory);
            this.panel1.Controls.Add(this.btnDeleteCategory);
            this.panel1.Controls.Add(this.btnEditCategory);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(130, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 508);
            this.panel1.TabIndex = 1;
            // 
            // dtgvCategoryForm
            // 
            this.dtgvCategoryForm.AllowUserToAddRows = false;
            this.dtgvCategoryForm.AllowUserToDeleteRows = false;
            this.dtgvCategoryForm.AllowUserToOrderColumns = true;
            this.dtgvCategoryForm.AllowUserToResizeColumns = false;
            this.dtgvCategoryForm.AllowUserToResizeRows = false;
            this.dtgvCategoryForm.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCategoryForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategoryForm.GridColor = System.Drawing.Color.White;
            this.dtgvCategoryForm.Location = new System.Drawing.Point(342, 85);
            this.dtgvCategoryForm.Name = "dtgvCategoryForm";
            this.dtgvCategoryForm.Size = new System.Drawing.Size(517, 420);
            this.dtgvCategoryForm.TabIndex = 40;
            this.dtgvCategoryForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategoryForm_CellContentClick);
            // 
            // txbDescriptionCategory
            // 
            this.txbDescriptionCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDescriptionCategory.Location = new System.Drawing.Point(114, 176);
            this.txbDescriptionCategory.Name = "txbDescriptionCategory";
            this.txbDescriptionCategory.Size = new System.Drawing.Size(222, 27);
            this.txbDescriptionCategory.TabIndex = 39;
            // 
            // txbNameCategory
            // 
            this.txbNameCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameCategory.Location = new System.Drawing.Point(114, 130);
            this.txbNameCategory.Name = "txbNameCategory";
            this.txbNameCategory.Size = new System.Drawing.Size(222, 27);
            this.txbNameCategory.TabIndex = 38;
            // 
            // txbIDCategory
            // 
            this.txbIDCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIDCategory.Location = new System.Drawing.Point(114, 85);
            this.txbIDCategory.Name = "txbIDCategory";
            this.txbIDCategory.ReadOnly = true;
            this.txbIDCategory.Size = new System.Drawing.Size(222, 27);
            this.txbIDCategory.TabIndex = 37;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCategory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCategory.FlatAppearance.BorderSize = 0;
            this.btnDeleteCategory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCategory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteCategory.Location = new System.Drawing.Point(213, 254);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(79, 28);
            this.btnDeleteCategory.TabIndex = 6;
            this.btnDeleteCategory.Text = "DELETE";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditCategory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnEditCategory.FlatAppearance.BorderSize = 0;
            this.btnEditCategory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnEditCategory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnEditCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnEditCategory.Location = new System.Drawing.Point(114, 254);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(79, 28);
            this.btnEditCategory.TabIndex = 5;
            this.btnEditCategory.Text = "EDIT";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.White;
            this.btnAddCategory.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddCategory.FlatAppearance.BorderSize = 0;
            this.btnAddCategory.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAddCategory.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAddCategory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddCategory.Location = new System.Drawing.Point(15, 254);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(79, 28);
            this.btnAddCategory.TabIndex = 4;
            this.btnAddCategory.Text = "ADD";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "DESCRIPTION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 138);
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
            this.label2.Location = new System.Drawing.Point(11, 93);
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
            this.label1.Size = new System.Drawing.Size(242, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE CATEGORIES";
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
            this.button3.TabIndex = 33;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnProductCategoryForm
            // 
            this.btnProductCategoryForm.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnProductCategoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductCategoryForm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductCategoryForm.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnProductCategoryForm.Location = new System.Drawing.Point(2, 157);
            this.btnProductCategoryForm.Name = "btnProductCategoryForm";
            this.btnProductCategoryForm.Size = new System.Drawing.Size(127, 38);
            this.btnProductCategoryForm.TabIndex = 35;
            this.btnProductCategoryForm.Text = "Products";
            this.btnProductCategoryForm.UseVisualStyleBackColor = true;
            this.btnProductCategoryForm.Click += new System.EventHandler(this.btnProductCategoryForm_Click);
            // 
            // btnSellerCategoryForm
            // 
            this.btnSellerCategoryForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnSellerCategoryForm.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSellerCategoryForm.FlatAppearance.BorderSize = 0;
            this.btnSellerCategoryForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnSellerCategoryForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnSellerCategoryForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSellerCategoryForm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSellerCategoryForm.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSellerCategoryForm.Location = new System.Drawing.Point(9, 109);
            this.btnSellerCategoryForm.Margin = new System.Windows.Forms.Padding(0);
            this.btnSellerCategoryForm.Name = "btnSellerCategoryForm";
            this.btnSellerCategoryForm.Size = new System.Drawing.Size(103, 39);
            this.btnSellerCategoryForm.TabIndex = 34;
            this.btnSellerCategoryForm.Text = "Sellers";
            this.btnSellerCategoryForm.UseVisualStyleBackColor = false;
            this.btnSellerCategoryForm.Click += new System.EventHandler(this.btnSellerCategoryForm_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(12, 506);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 35);
            this.btnLogout.TabIndex = 36;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 553);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProductCategoryForm);
            this.Controls.Add(this.btnSellerCategoryForm);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategoryForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnProductCategoryForm;
        private System.Windows.Forms.Button btnSellerCategoryForm;
        private System.Windows.Forms.DataGridView dtgvCategoryForm;
        private System.Windows.Forms.TextBox txbDescriptionCategory;
        private System.Windows.Forms.TextBox txbNameCategory;
        private System.Windows.Forms.TextBox txbIDCategory;
        private System.Windows.Forms.Button btnLogout;
    }
}