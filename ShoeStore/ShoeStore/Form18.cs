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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();


        private void btnback_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void Form18_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "select [shopping_cart].cart_id," +
                        "[shopping_cart].buying_date," +
                        "[user].first_name," +
                        "[user].last_name," +
                        "[user].user_id," +
                        "[product].name," +
                        "[product].sell_price," +
                        "[product].sold," +
                        "[product].product_id from [shopping_cart] inner join [user] on [shopping_cart].user_id=[user].user_id inner join [product] on [shopping_cart].product_id=[product].product_id";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridshoppings.DataSource = dt;
            dgridshoppings.Columns[0].HeaderText = "Cart Id";
            dgridshoppings.Columns[1].HeaderText = "Date";
            dgridshoppings.Columns[2].HeaderText = "Name";
            dgridshoppings.Columns[3].HeaderText = "Surname";
            dgridshoppings.Columns[4].HeaderText = "User Id";
            dgridshoppings.Columns[5].HeaderText = "Product Name";
            dgridshoppings.Columns[6].HeaderText = "Price";
            dgridshoppings.Columns[7].HeaderText = "Sold";
            dgridshoppings.Columns[8].HeaderText = "Product Id";
            cnn.Close();
        }

        private void dgridshoppings_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tboxname.Text = dgridshoppings.CurrentRow.Cells[2].Value.ToString();
            tboxlastname.Text = dgridshoppings.CurrentRow.Cells[3].Value.ToString();
            tboxtproductname.Text = dgridshoppings.CurrentRow.Cells[5].Value.ToString();
            tboxsellprice.Text = dgridshoppings.CurrentRow.Cells[6].Value.ToString()+"$";
            mtboxdate.Text = dgridshoppings.CurrentRow.Cells[1].Value.ToString();
            tboxsold.Text = dgridshoppings.CurrentRow.Cells[7].Value.ToString();
        }

        private void tboxsearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            SqlCommand com = new SqlCommand("select [shopping_cart].cart_id," +
                        "[shopping_cart].buying_date," +
                        "[user].first_name," +
                        "[user].last_name," +
                        "[user].user_id," +
                        "[product].name," +
                        "[product].sell_price," +
                        "[product].sold," +
                        "[product].product_id from [shopping_cart] inner join [user] on [shopping_cart].user_id=[user].user_id inner join [product] on [shopping_cart].product_id=[product].product_id where [product].name like '%" + tboxsearch.Text + "%'", cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridshoppings.DataSource = dt;
            cnn.Close();
        }

        private void tboxsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void Form18_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnqueries_Click(object sender, EventArgs e)
        {
            Form13 frm13 = new Form13();
            frm13.Show();
            this.Hide();
        }
    }
}
