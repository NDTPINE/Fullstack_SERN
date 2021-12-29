
namespace Supermarket_Management_System
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgvBillSell = new System.Windows.Forms.DataGridView();
            this.dtgvProduct = new System.Windows.Forms.DataGridView();
            this.dtgvProductSell = new System.Windows.Forms.DataGridView();
            this.txbPriceSelling = new System.Windows.Forms.TextBox();
            this.txbQuantitySelling = new System.Windows.Forms.TextBox();
            this.txbNameSelling = new System.Windows.Forms.TextBox();
            this.txbBillId = new System.Windows.Forms.TextBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddProductSelling = new System.Windows.Forms.Button();
            this.lbSellerName = new System.Windows.Forms.Label();
            this.lbDateSelling = new System.Windows.Forms.Label();
            this.btnRefreshSelling = new System.Windows.Forms.Button();
            this.btnDeleteProducts = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnAddProducts = new System.Windows.Forms.Button();
            this.cbSelectCategorySelling = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductSell)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtgvBillSell);
            this.panel1.Controls.Add(this.dtgvProduct);
            this.panel1.Controls.Add(this.dtgvProductSell);
            this.panel1.Controls.Add(this.txbPriceSelling);
            this.panel1.Controls.Add(this.txbQuantitySelling);
            this.panel1.Controls.Add(this.txbNameSelling);
            this.panel1.Controls.Add(this.txbBillId);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.lbAmount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAddProductSelling);
            this.panel1.Controls.Add(this.lbSellerName);
            this.panel1.Controls.Add(this.lbDateSelling);
            this.panel1.Controls.Add(this.btnRefreshSelling);
            this.panel1.Controls.Add(this.btnDeleteProducts);
            this.panel1.Controls.Add(this.btnPrintBill);
            this.panel1.Controls.Add(this.btnAddProducts);
            this.panel1.Controls.Add(this.cbSelectCategorySelling);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(131, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 508);
            this.panel1.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(340, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 19);
            this.label7.TabIndex = 51;
            this.label7.Text = "Amount";
            // 
            // dtgvBillSell
            // 
            this.dtgvBillSell.AllowUserToAddRows = false;
            this.dtgvBillSell.AllowUserToDeleteRows = false;
            this.dtgvBillSell.AllowUserToResizeColumns = false;
            this.dtgvBillSell.AllowUserToResizeRows = false;
            this.dtgvBillSell.BackgroundColor = System.Drawing.Color.White;
            this.dtgvBillSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBillSell.GridColor = System.Drawing.Color.White;
            this.dtgvBillSell.Location = new System.Drawing.Point(299, 273);
            this.dtgvBillSell.Name = "dtgvBillSell";
            this.dtgvBillSell.Size = new System.Drawing.Size(555, 190);
            this.dtgvBillSell.TabIndex = 50;
            this.dtgvBillSell.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBillSell_CellContentClick);
            // 
            // dtgvProduct
            // 
            this.dtgvProduct.AllowUserToAddRows = false;
            this.dtgvProduct.AllowUserToDeleteRows = false;
            this.dtgvProduct.AllowUserToResizeColumns = false;
            this.dtgvProduct.AllowUserToResizeRows = false;
            this.dtgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dtgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProduct.GridColor = System.Drawing.Color.White;
            this.dtgvProduct.Location = new System.Drawing.Point(12, 282);
            this.dtgvProduct.Name = "dtgvProduct";
            this.dtgvProduct.Size = new System.Drawing.Size(276, 215);
            this.dtgvProduct.TabIndex = 49;
            this.dtgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvProduct_CellContentClick);
            // 
            // dtgvProductSell
            // 
            this.dtgvProductSell.AllowUserToAddRows = false;
            this.dtgvProductSell.AllowUserToDeleteRows = false;
            this.dtgvProductSell.AllowUserToResizeColumns = false;
            this.dtgvProductSell.AllowUserToResizeRows = false;
            this.dtgvProductSell.BackgroundColor = System.Drawing.Color.White;
            this.dtgvProductSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProductSell.GridColor = System.Drawing.Color.White;
            this.dtgvProductSell.Location = new System.Drawing.Point(299, 42);
            this.dtgvProductSell.Name = "dtgvProductSell";
            this.dtgvProductSell.Size = new System.Drawing.Size(555, 172);
            this.dtgvProductSell.TabIndex = 48;
            // 
            // txbPriceSelling
            // 
            this.txbPriceSelling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPriceSelling.Location = new System.Drawing.Point(112, 178);
            this.txbPriceSelling.Name = "txbPriceSelling";
            this.txbPriceSelling.Size = new System.Drawing.Size(176, 27);
            this.txbPriceSelling.TabIndex = 47;
            // 
            // txbQuantitySelling
            // 
            this.txbQuantitySelling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbQuantitySelling.Location = new System.Drawing.Point(112, 133);
            this.txbQuantitySelling.Name = "txbQuantitySelling";
            this.txbQuantitySelling.Size = new System.Drawing.Size(176, 27);
            this.txbQuantitySelling.TabIndex = 46;
            // 
            // txbNameSelling
            // 
            this.txbNameSelling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameSelling.Location = new System.Drawing.Point(112, 88);
            this.txbNameSelling.Name = "txbNameSelling";
            this.txbNameSelling.Size = new System.Drawing.Size(176, 27);
            this.txbNameSelling.TabIndex = 45;
            // 
            // txbBillId
            // 
            this.txbBillId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBillId.Location = new System.Drawing.Point(112, 47);
            this.txbBillId.Name = "txbBillId";
            this.txbBillId.ReadOnly = true;
            this.txbBillId.Size = new System.Drawing.Size(176, 27);
            this.txbBillId.TabIndex = 41;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.White;
            this.lbTotal.Location = new System.Drawing.Point(547, 222);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(44, 19);
            this.lbTotal.TabIndex = 44;
            this.lbTotal.Text = "VNĐ";
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmount.ForeColor = System.Drawing.Color.White;
            this.lbAmount.Location = new System.Drawing.Point(444, 222);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(0, 19);
            this.lbAmount.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(518, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "SELLS LIST";
            // 
            // btnAddProductSelling
            // 
            this.btnAddProductSelling.BackColor = System.Drawing.Color.White;
            this.btnAddProductSelling.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnAddProductSelling.FlatAppearance.BorderSize = 0;
            this.btnAddProductSelling.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnAddProductSelling.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnAddProductSelling.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProductSelling.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAddProductSelling.Location = new System.Drawing.Point(87, 213);
            this.btnAddProductSelling.Name = "btnAddProductSelling";
            this.btnAddProductSelling.Size = new System.Drawing.Size(130, 28);
            this.btnAddProductSelling.TabIndex = 40;
            this.btnAddProductSelling.Text = "Add Products";
            this.btnAddProductSelling.UseVisualStyleBackColor = false;
            this.btnAddProductSelling.Click += new System.EventHandler(this.btnAddProductSelling_Click);
            // 
            // lbSellerName
            // 
            this.lbSellerName.AutoSize = true;
            this.lbSellerName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSellerName.ForeColor = System.Drawing.Color.White;
            this.lbSellerName.Location = new System.Drawing.Point(8, 10);
            this.lbSellerName.Name = "lbSellerName";
            this.lbSellerName.Size = new System.Drawing.Size(50, 19);
            this.lbSellerName.TabIndex = 37;
            this.lbSellerName.Text = "Seller";
            // 
            // lbDateSelling
            // 
            this.lbDateSelling.AutoSize = true;
            this.lbDateSelling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateSelling.Location = new System.Drawing.Point(735, 15);
            this.lbDateSelling.Name = "lbDateSelling";
            this.lbDateSelling.Size = new System.Drawing.Size(45, 19);
            this.lbDateSelling.TabIndex = 36;
            this.lbDateSelling.Text = "Date";
            // 
            // btnRefreshSelling
            // 
            this.btnRefreshSelling.BackColor = System.Drawing.Color.White;
            this.btnRefreshSelling.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnRefreshSelling.FlatAppearance.BorderSize = 0;
            this.btnRefreshSelling.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnRefreshSelling.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnRefreshSelling.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSelling.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnRefreshSelling.Location = new System.Drawing.Point(176, 247);
            this.btnRefreshSelling.Name = "btnRefreshSelling";
            this.btnRefreshSelling.Size = new System.Drawing.Size(112, 28);
            this.btnRefreshSelling.TabIndex = 32;
            this.btnRefreshSelling.Text = "Refresh";
            this.btnRefreshSelling.UseVisualStyleBackColor = false;
            this.btnRefreshSelling.Click += new System.EventHandler(this.btnRefreshSelling_Click);
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
            this.btnDeleteProducts.Location = new System.Drawing.Point(650, 469);
            this.btnDeleteProducts.Name = "btnDeleteProducts";
            this.btnDeleteProducts.Size = new System.Drawing.Size(79, 28);
            this.btnDeleteProducts.TabIndex = 8;
            this.btnDeleteProducts.Text = "DELETE";
            this.btnDeleteProducts.UseVisualStyleBackColor = false;
            this.btnDeleteProducts.Click += new System.EventHandler(this.btnDeleteProducts_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrintBill.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnPrintBill.FlatAppearance.BorderSize = 0;
            this.btnPrintBill.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnPrintBill.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnPrintBill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnPrintBill.Location = new System.Drawing.Point(551, 469);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(79, 28);
            this.btnPrintBill.TabIndex = 7;
            this.btnPrintBill.Text = "PRINT";
            this.btnPrintBill.UseVisualStyleBackColor = false;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintProducts_Click);
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
            this.btnAddProducts.Location = new System.Drawing.Point(452, 469);
            this.btnAddProducts.Name = "btnAddProducts";
            this.btnAddProducts.Size = new System.Drawing.Size(79, 28);
            this.btnAddProducts.TabIndex = 6;
            this.btnAddProducts.Text = "ADD";
            this.btnAddProducts.UseVisualStyleBackColor = false;
            this.btnAddProducts.Click += new System.EventHandler(this.btnAddProducts_Click);
            // 
            // cbSelectCategorySelling
            // 
            this.cbSelectCategorySelling.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectCategorySelling.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbSelectCategorySelling.FormattingEnabled = true;
            this.cbSelectCategorySelling.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.cbSelectCategorySelling.Location = new System.Drawing.Point(12, 247);
            this.cbSelectCategorySelling.Name = "cbSelectCategorySelling";
            this.cbSelectCategorySelling.Size = new System.Drawing.Size(151, 29);
            this.cbSelectCategorySelling.TabIndex = 5;
            this.cbSelectCategorySelling.Text = "Select Category";
            this.cbSelectCategorySelling.SelectedIndexChanged += new System.EventHandler(this.cbSelectCategorySelling_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 186);
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
            this.label4.Location = new System.Drawing.Point(22, 141);
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
            this.label3.Location = new System.Drawing.Point(22, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "PRONAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "BILLID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELLING";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnExit.Location = new System.Drawing.Point(967, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(9, 510);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(103, 35);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBillSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProductSell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDateSelling;
        private System.Windows.Forms.Button btnRefreshSelling;
        private System.Windows.Forms.Button btnDeleteProducts;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Button btnAddProducts;
        private System.Windows.Forms.ComboBox cbSelectCategorySelling;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSellerName;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddProductSelling;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.TextBox txbPriceSelling;
        private System.Windows.Forms.TextBox txbQuantitySelling;
        private System.Windows.Forms.TextBox txbNameSelling;
        private System.Windows.Forms.TextBox txbBillId;
        private System.Windows.Forms.DataGridView dtgvBillSell;
        private System.Windows.Forms.DataGridView dtgvProduct;
        private System.Windows.Forms.DataGridView dtgvProductSell;
        private System.Windows.Forms.Label label7;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnLogout;
    }
}