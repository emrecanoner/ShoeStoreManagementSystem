using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace ShoeStore
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void Form13_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form18 frm18 = new Form18();
            frm18.Show();
            this.Hide();
        }

        private void btnquerie1_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select top 10 product.sold, product.name, purpose, product.product_id, shopping_cart.buying_date FROM [product] inner join [shopping_cart] on [shopping_cart].product_id = [product].product_id WHERE MONTH(shopping_cart.buying_date) = '06' or MONTH(shopping_cart.buying_date) = '07' or MONTH(shopping_cart.buying_date) = '08' Group by sold, name, product.product_id, shopping_cart.buying_date, purpose ORDER BY sold desc";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridqueries.DataSource = dt;
            dgridqueries.Columns[0].HeaderText = "Sold";
            dgridqueries.Columns[1].HeaderText = "Name";
            dgridqueries.Columns[2].HeaderText = "Purpose";
            dgridqueries.Columns[3].HeaderText = "Product Id";
            dgridqueries.Columns[4].HeaderText = "Date";
            cnn.Close();
        }

        private void btnquerie2_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select top 10 product.sold, product.name, purpose, product.product_id, shopping_cart.buying_date FROM product inner join shopping_cart on shopping_cart.product_id = product.product_id WHERE MONTH(shopping_cart.buying_date) = '12' or MONTH(shopping_cart.buying_date) = '01' or MONTH(shopping_cart.buying_date) = '02' Group by sold, name, product.product_id, shopping_cart.buying_date, purpose ORDER BY sold desc";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridqueries.DataSource = dt;
            dgridqueries.Columns[0].HeaderText = "Sold";
            dgridqueries.Columns[1].HeaderText = "Name";
            dgridqueries.Columns[2].HeaderText = "Purpose";
            dgridqueries.Columns[3].HeaderText = "Product Id";
            dgridqueries.Columns[4].HeaderText = "Date";
            cnn.Close();
        }

        private void btnquerie3_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select top 10 product.sold, product.name, purpose, product.product_id FROM product Group by sold, name, product.product_id, purpose ORDER BY sold ";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridqueries.DataSource = dt;
            dgridqueries.Columns[0].HeaderText = "Sold";
            dgridqueries.Columns[1].HeaderText = "Name";
            dgridqueries.Columns[2].HeaderText = "Purpose";
            dgridqueries.Columns[3].HeaderText = "Product Id";
            cnn.Close();
        }

        private void btnquerie4_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select top 10 product.sold, product.name, brand, product.product_id, shopping_cart.buying_date FROM product inner join shopping_cart on shopping_cart.product_id = product.product_id WHERE year(shopping_cart.buying_date) = '2018' Group by sold, brand, name, product.product_id, shopping_cart.buying_date ORDER BY sold desc";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridqueries.DataSource = dt;
            dgridqueries.Columns[0].HeaderText = "Sold";
            dgridqueries.Columns[1].HeaderText = "Name";
            dgridqueries.Columns[2].HeaderText = "Brand";
            dgridqueries.Columns[3].HeaderText = "Product Id";
            dgridqueries.Columns[3].HeaderText = "Date";
            cnn.Close();
        }

        private void btnquerie5_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select top 10 product.sold, product.name, brand, product.product_id, shopping_cart.buying_date FROM product inner join shopping_cart on shopping_cart.product_id = product.product_id WHERE year(shopping_cart.buying_date) = '2019' Group by sold, brand, name, product.product_id, shopping_cart.buying_date ORDER BY sold desc";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridqueries.DataSource = dt;
            dgridqueries.Columns[0].HeaderText = "Sold";
            dgridqueries.Columns[1].HeaderText = "Name";
            dgridqueries.Columns[2].HeaderText = "Brand";
            dgridqueries.Columns[3].HeaderText = "Product Id";
            dgridqueries.Columns[3].HeaderText = "Date";
            cnn.Close();
        }

        private void btnquerie6_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select top 10 product.sold, product.name, brand, product.product_id, shopping_cart.buying_date FROM product inner join shopping_cart on shopping_cart.product_id = product.product_id WHERE year(shopping_cart.buying_date) = '2020' Group by sold, brand, name, product.product_id, shopping_cart.buying_date ORDER BY sold desc";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridqueries.DataSource = dt;
            dgridqueries.Columns[0].HeaderText = "Sold";
            dgridqueries.Columns[1].HeaderText = "Name";
            dgridqueries.Columns[2].HeaderText = "Brand";
            dgridqueries.Columns[3].HeaderText = "Product Id";
            dgridqueries.Columns[3].HeaderText = "Date";
            cnn.Close();
        }

        private void btnquerie7_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select top 10 product.sold, product.name, purpose, product.product_id, shopping_cart.buying_date FROM product inner join shopping_cart on shopping_cart.product_id = product.product_id WHERE year(shopping_cart.buying_date) = '2018' Group by sold, purpose, name, product.product_id, shopping_cart.buying_date ORDER BY sold desc";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridqueries.DataSource = dt;
            dgridqueries.Columns[0].HeaderText = "Sold";
            dgridqueries.Columns[1].HeaderText = "Name";
            dgridqueries.Columns[2].HeaderText = "Purpose";
            dgridqueries.Columns[3].HeaderText = "Product Id";
            dgridqueries.Columns[3].HeaderText = "Date";
            cnn.Close();
        }

        private void btnquerie8_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select top 10 product.sold, product.name, purpose, product.product_id, shopping_cart.buying_date FROM product inner join shopping_cart on shopping_cart.product_id = product.product_id WHERE year(shopping_cart.buying_date) = '2019' Group by sold, purpose, name, product.product_id, shopping_cart.buying_date ORDER BY sold desc";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridqueries.DataSource = dt;
            dgridqueries.Columns[0].HeaderText = "Sold";
            dgridqueries.Columns[1].HeaderText = "Name";
            dgridqueries.Columns[2].HeaderText = "Purpose";
            dgridqueries.Columns[3].HeaderText = "Product Id";
            dgridqueries.Columns[3].HeaderText = "Date";
            cnn.Close();
        }

        private void btnquerie9_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select top 10 product.sold, product.name, purpose, product.product_id, shopping_cart.buying_date FROM product inner join shopping_cart on shopping_cart.product_id = product.product_id WHERE year(shopping_cart.buying_date) = '2020' Group by sold, purpose, name, product.product_id, shopping_cart.buying_date ORDER BY sold desc";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridqueries.DataSource = dt;
            dgridqueries.Columns[0].HeaderText = "Sold";
            dgridqueries.Columns[1].HeaderText = "Name";
            dgridqueries.Columns[2].HeaderText = "Purpose";
            dgridqueries.Columns[3].HeaderText = "Product Id";
            dgridqueries.Columns[3].HeaderText = "Date";
            cnn.Close();
        }
    }
}
