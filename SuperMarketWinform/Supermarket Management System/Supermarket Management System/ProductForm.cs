using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_Management_System
{
    public partial class ProductForm : Form
    {
        [Obsolete]
        public ProductForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=desktop-5kgl5vg\sqlexpress;Initial Catalog=SMarketDB;Integrated Security=True");
        public bool CheckAdmin ;
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fillcombox()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatID, CatName from CategoryTbl", Con);
            SqlDataReader sqlData;
            sqlData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatId", typeof(int));
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(sqlData);
            cbSelectCategory.DisplayMember = "CatName";
            cbSelectCategory.ValueMember = "CatId";
            cbSelectCategory.DataSource = dt;

            DataTable dtRefresh = new DataTable();
            sqlData = cmd.ExecuteReader();
            dtRefresh.Columns.Add("CatId", typeof(int));
            dtRefresh.Columns.Add("CatName", typeof(string));
            dtRefresh.Load(sqlData);
            cbSelectCategoryRefresh.DisplayMember = "CatName";
            cbSelectCategoryRefresh.ValueMember = "CatId";
            cbSelectCategoryRefresh.DataSource = dtRefresh;
            Con.Close();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from ProductTbl as Pro, CategoryTbl as Cat where Cat.CatId = Pro.ProductCatId";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dtgvProductForm.DataSource = ds.Tables[0];
            dtgvProductForm.Columns[0].Visible = false;
            dtgvProductForm.Columns[4].Visible = false;
            dtgvProductForm.Columns[5].Visible = false;
            Con.Close();

        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            fillcombox();
            populate();
            
            if (CheckAdmin == false)
            {
                btnSellerProductsForm.Visible = false;
            }
        }

        [Obsolete]
        private void btnCategoryProductForm_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into ProductTbl values('" + txbNameProducts.Text + "',"
                                                + txbQuantityProducts.Text + "," + txbPriceProducts.Text + ","
                                                + cbSelectCategory.SelectedValue.ToString() + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                Con.Close();
                populate();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbIDProducts.Text == "")
                {
                    MessageBox.Show("Select the Product to Detele");
                }
                else
                {
                    Con.Open();
                    string query = "Delete from ProductTbl where ProductId = " + txbIDProducts.Text;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
        private void btnEditProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbIDProducts.Text == "" || txbNameProducts.Text == "" || txbQuantityProducts.Text == "" || txbPriceProducts.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "Update ProductTbl set ProductName ='" + txbNameProducts.Text + "',ProductQty ='" + txbQuantityProducts.Text + "',ProductPrice ='" + txbPriceProducts.Text + "',ProductCatId ='" + cbSelectCategory.SelectedValue + "' where ProductId =" + txbIDProducts.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Successfully Updated");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            Con.Open();
            string query = "select DISTINCT * from ProductTbl as Pro, CategoryTbl as Cat where Pro.ProductCatId = " + cbSelectCategoryRefresh.SelectedValue + " and Cat.CatId = " + cbSelectCategoryRefresh.SelectedValue;
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dtgvProductForm.DataSource = ds.Tables[0];
            dtgvProductForm.Columns[0].Visible = false;
            dtgvProductForm.Columns[4].Visible = false;
            dtgvProductForm.Columns[5].Visible = false;
            Con.Close();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            populate();
        }

        public void btnSellerProductsForm_Click(object sender, EventArgs e)
        {

            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void btnSellingProductForm_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void dtgvProductForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow row = dtgvProductForm.Rows[e.RowIndex];
            txbIDProducts.Text = row.Cells[0].Value.ToString();
            txbNameProducts.Text = row.Cells[1].Value.ToString();
            txbQuantityProducts.Text = row.Cells[2].Value.ToString();
            txbPriceProducts.Text = row.Cells[3].Value.ToString();


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
