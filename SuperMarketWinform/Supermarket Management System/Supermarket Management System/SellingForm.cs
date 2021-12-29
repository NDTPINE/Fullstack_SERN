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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=desktop-5kgl5vg\sqlexpress;Initial Catalog=SMarketDB;Integrated Security=True");

        private void SellingForm_Load(object sender, EventArgs e)
        {
            lbDateSelling.Text = DateTime.Now.ToString("dd/MM/yyyy");
            fillCbCategory();
            fillDtgvProduct();
            populateBill();
            lbSellerName.Text = Form1.Sellername;
            //Creat Column DataGridView ProductSell
            dtgvProductSell.Columns.Add("ProductId", "ProductID");
            dtgvProductSell.Columns.Add("ProductName", "ProductName");
            dtgvProductSell.Columns.Add("Quantity", "Quantity");
            dtgvProductSell.Columns.Add("Price", "Price");
            dtgvProductSell.Columns.Add("Total", "Total");

            //Create Column DataGridView ProductSellList

        }
        //LOAD Category
        private void fillCbCategory()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select CatID, CatName from CategoryTbl", Con);
            SqlDataReader sqlData;
            sqlData = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CatId", typeof(int));
            dt.Columns.Add("CatName", typeof(string));
            dt.Load(sqlData);
            cbSelectCategorySelling.DisplayMember = "CatName";
            cbSelectCategorySelling.ValueMember = "CatId";
            cbSelectCategorySelling.DataSource = dt;
            Con.Close();
        }
        //Load Product
        private void fillDtgvProduct()
        {
            Con.Open();
            string query = "select * from ProductTbl ";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dtgvProduct.DataSource = ds.Tables[0];
            dtgvProduct.Columns[0].Visible = false;
            dtgvProduct.Columns[4].Visible = false;
            dtgvProduct.Columns[3].Visible = false;
            Con.Close();
        }
        //Button Exit Application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Filter Product by Category
        private void btnRefreshSelling_Click(object sender, EventArgs e)
        {
            fillDtgvProduct();
        }

        int Total = 0;
        int GridTotal = 0;
        private void btnAddProductSelling_Click(object sender, EventArgs e)
        {

            Total = Convert.ToInt32(txbQuantitySelling.Text) * Convert.ToInt32(txbPriceSelling.Text);
            if (txbQuantitySelling.Text == "" || txbPriceSelling.Text == "")
            {
                MessageBox.Show("Missing Data");
            }
            else
            {
                int selectedRowIndex = dtgvProduct.SelectedCells[0].RowIndex;
                bool checkExist = false;
                for (int i = 0; i < dtgvProductSell.Rows.Count; i++)
                {
                    
                    if (dtgvProductSell.Rows[i].Cells[0].Value.ToString() == dtgvProduct.Rows[selectedRowIndex].Cells[0].Value.ToString())
                    {
                        int temp1 = int.Parse(dtgvProductSell.Rows[i].Cells[2].Value.ToString());
                        int temp2 = int.Parse(dtgvProduct.Rows[selectedRowIndex].Cells[2].Value.ToString());
                        dtgvProductSell.Rows[i].Cells[2].Value = (temp1 + temp2).ToString();
                        checkExist = true;
                        break;
                    }
                }
                if (!checkExist) 
                    dtgvProductSell.Rows.Add(dtgvProduct.Rows[selectedRowIndex].Cells[0].Value, dtgvProduct.Rows[selectedRowIndex].Cells[1].Value, txbQuantitySelling.Text, txbPriceSelling.Text, Total);
                GridTotal += Total;
            }
            lbAmount.Text = GridTotal.ToString();

            
        }

        private void cbSelectCategorySelling_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con.Close();
            Con.Open();
            string query = "select DISTINCT * from ProductTbl as Pro, CategoryTbl as Cat where Pro.ProductCatId = " + cbSelectCategorySelling.SelectedValue + " and Cat.CatId = " + cbSelectCategorySelling.SelectedValue;
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dtgvProduct.DataSource = ds.Tables[0];
            dtgvProduct.Columns[0].Visible = false;
            dtgvProduct.Columns[1].Visible = true;
            dtgvProduct.Columns[2].Visible = true;
            dtgvProduct.Columns[3].Visible = false;
            dtgvProduct.Columns[4].Visible = false;
            dtgvProduct.Columns[5].Visible = false;
            dtgvProduct.Columns[6].Visible = false;
            dtgvProduct.Columns[7].Visible = false;
            Con.Close();
        }

        private void dtgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbNameSelling.Text = dtgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void populateBill()
        {
            Con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            dtgvBillSell.DataSource = ds.Tables[0];
            Con.Close();

        }
        int flag = 0;
        private void btnAddProducts_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "Insert into BillTbl values('" + lbSellerName.Text + "','"
                                                + lbDateSelling.Text + "'," + lbAmount.Text +  ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully");
                Con.Close();
                populateBill();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrintProducts_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbBillId.Text == "")
                {
                    MessageBox.Show("Select the BillID to Detele");
                }
                else
                {
                    Con.Open();
                    string query = "Delete from BillTbl where BillId = " + txbBillId.Text;
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Deleted Successfully");
                    Con.Close();
                    populateBill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgvBillSell_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txbBillId.Text = dtgvBillSell.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("MY SUPERMARKET", new Font("Century Gothic",20,FontStyle.Bold),Brushes.Red,new Point(230)); 

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }
    }
}
