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
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=desktop-5kgl5vg\sqlexpress;Initial Catalog=SMarketDB;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCategorySellerForm_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductForm pro = new ProductForm();
            pro.Show();
            this.Hide();
        }
        private void populate()
        {
            Con.Open();
            string query = "select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dtgvSellerForm.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        

        private void btnAddSeller_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into SellerTbl values('" + txbNameSeller.Text + "',"
                                                + txbAgeSeller.Text + "," + txbPhoneSeller.Text + ","
                                                + txbPasswordSeller.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller Added Successfully");
                Con.Close();
                populate();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditSeller_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbIDSeller.Text == "" || txbNameSeller.Text == "" || txbAgeSeller.Text == "" || txbPhoneSeller.Text == "" || txbPasswordSeller.Text == "")
                {
                    MessageBox.Show("Missing Information");
                }
                else
                {
                    Con.Open();
                    string query = "Update SellerTbl set SellerName ='" + txbNameSeller.Text + "',SellerAge ='" + txbAgeSeller.Text + "',SellerPhone ='" + txbPhoneSeller.Text + "',SellerPass ='" + txbPasswordSeller.Text + "' where SellerId =" + txbIDSeller.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Successfully Updated");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteSeller_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbIDSeller.Text == "")
                {
                    MessageBox.Show("Select the Seller to Detele");
                }
                else
                {
                    Con.Open();
                    string query = "Delete from SellerTbl where SellerId = " + txbIDSeller.Text;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller Deleted Successfully");
                    Con.Close();
                    populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvSellerForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbIDSeller.Text = dtgvSellerForm.Rows[e.RowIndex].Cells[0].Value.ToString();
            txbNameSeller.Text = dtgvSellerForm.SelectedRows[e.RowIndex].Cells[1].Value.ToString();
            txbAgeSeller.Text = dtgvSellerForm.SelectedRows[e.RowIndex].Cells[2].Value.ToString();
            txbPhoneSeller.Text = dtgvSellerForm.SelectedRows[e.RowIndex].Cells[3].Value.ToString();
            txbPasswordSeller.Text = dtgvSellerForm.SelectedRows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
