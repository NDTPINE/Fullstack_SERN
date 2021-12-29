using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Supermarket_Management_System
{
    public partial class CategoryForm : Form
    {
        [Obsolete]
        public CategoryForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=desktop-5kgl5vg\sqlexpress;Initial Catalog=SMarketDB;Integrated Security=True");
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTbl values('" + txbNameCategory.Text + "','" + txbDescriptionCategory.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                Con.Close();
                populate();

                // MessageBox.Show(string.Format("{0}", txbDescriptionCategory.Text));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dtgvCategoryForm.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string queryCount = "Select Count(*) from ProductTbl, CategoryTbl where ProductCatId =" + txbIDCategory.Text;
                SqlCommand cmd1 = new SqlCommand(queryCount, Con);
                int count = (int)cmd1.ExecuteScalar();
                Con.Close();
                if (count != 0)
                {
                    MessageBox.Show("Cannot delete category");
                }
                else if (txbIDCategory.Text == "")
                {
                    MessageBox.Show("Select the Category to Detele");
                }
                else
                {
                    Con.Open();
                    string query = "delete from CategoryTbl where CatId = " + txbIDCategory.Text + "";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbIDCategory.Text == "" || txbNameCategory.Text == "" || txbDescriptionCategory.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "Update CategoryTbl set CatName ='" + txbNameCategory.Text + "',CatDesc ='" + txbDescriptionCategory.Text + "' where CatId =" + txbIDCategory.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Successfully Updated");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProductCategoryForm_Click(object sender, EventArgs e)
        {
            ProductForm pro = new ProductForm();
            pro.Show();
            this.Hide();
        }

        private void btnSellerCategoryForm_Click(object sender, EventArgs e)
        {
            SellerForm seller = new SellerForm();
            seller.Show();
            this.Hide();
        }

        private void btnSellingCategoryForm_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }

        private void dtgvCategoryForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbIDCategory.Text = dtgvCategoryForm.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbNameCategory.Text = dtgvCategoryForm.Rows[e.RowIndex].Cells[1].Value.ToString();
            txbDescriptionCategory.Text = dtgvCategoryForm.Rows[e.RowIndex].Cells[2].Value.ToString();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
