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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Sellername = "";
        SqlConnection Con = new SqlConnection(@"Data Source=desktop-5kgl5vg\sqlexpress;Initial Catalog=SMarketDB;Integrated Security=True");

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txbPassword.Text = "";
            txbUsername.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "" || txbPassword.Text == "")
            {
                MessageBox.Show("Enter the Username and Password");
            }
            else
            {
                if (cbRole.SelectedIndex > -1)
                {

                    if (cbRole.SelectedItem.ToString() == "Admin")
                    {
                        if (txbUsername.Text == "Admin" && txbPassword.Text == "Admin")
                        {
                            ProductForm pro = new ProductForm();
                            pro.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If you are the Admin, Enter the correct password");
                        }
                    }
                    else
                    {
                        Con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from SellerTbl where SellerName='" + txbUsername.Text + "' and SellerPass='"+ txbPassword.Text+"'",Con);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows[0][0].ToString() == "1")
                        {
                            Sellername = txbUsername.Text;
                            SellingForm sell = new SellingForm();
                            sell.Show();
                            this.Hide();
                            Con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Wrong UserName or Password");
                        }
                        Con.Close();
                        
                    }
                }
                else MessageBox.Show("Select A Role");
            }
        }


    }
}
