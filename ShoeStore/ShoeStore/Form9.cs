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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();

        private void Form9_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "SELECT [product].size," +
                        "[product].buy_price," +
                        "[product].product_id," +
                        "[product].purpose," +
                        "[product].sell_price," +
                        "[product].sex," +
                        "[product].brand," +
                        "[product].name," +
                        "[product].available,[product].sold FROM [product]";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridproducts.DataSource = dt;
            dgridproducts.Columns[0].HeaderText = "Size";
            dgridproducts.Columns[1].HeaderText = "Buy Price";
            dgridproducts.Columns[2].HeaderText = "Product Id";
            dgridproducts.Columns[3].HeaderText = "Purpose";
            dgridproducts.Columns[4].HeaderText = "Sell Price";
            dgridproducts.Columns[5].HeaderText = "Sex";
            dgridproducts.Columns[6].HeaderText = "Brand";
            dgridproducts.Columns[7].HeaderText = "Name";
            dgridproducts.Columns[8].HeaderText = "Available";
            dgridproducts.Columns[9].HeaderText = "Sold";
            cnn.Close();

        }

        private void dgridproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            frm10.Show();
            this.Hide();
        }

        private void btnaddremove_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            frm12.Show();
            this.Hide();
        }

        private void tboxsearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            SqlCommand com = new SqlCommand("select* from [product] where [product].name like '%" + tboxsearch.Text + "%'", cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgridproducts.DataSource = ds.Tables[0];
            cnn.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void tboxsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
