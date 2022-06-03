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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;

        private void btnback_Click(object sender, EventArgs e)
        {
            Form9 frm9= new Form9();
            frm9.Show();
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            da = new SqlDataAdapter("Select * from [product]", cnn);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "product");
            dgridproducts.DataSource = ds.Tables[0];
            dgridproducts.Columns[0].HeaderText = "Size";
            dgridproducts.Columns[2].HeaderText = "Product Id";
            dgridproducts.Columns[7].HeaderText = "Name";
            dgridproducts.Columns[6].HeaderText = "Brand";
            dgridproducts.Columns[3].HeaderText = "Purpose";
            dgridproducts.Columns[1].HeaderText = "Buy Price";
            dgridproducts.Columns[4].HeaderText = "Sell Price";
            dgridproducts.Columns[5].HeaderText = "Sex";
            dgridproducts.Columns[8].HeaderText = "Available";
            cnn.Close();
            tboxsold.Text = "0";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (tboxsize.Text != "" && tboxbuyprice.Text != "" && tboxsellprice.Text != "" && cboxpurpose.Text != "" && cboxsex.Text != "" && cboxbrand.Text != "" && tboxname.Text != "" && tboxavailable.Text != "")
            {
                SqlConnection cnn = new SqlConnection(connectionclass.address);
                cnn.Open();
                string sql = "insert into [product] (size,buy_price,sell_price,purpose,sex,brand,name,available,sold) values (@size,@buyprice,@sellprice,@purpose,@sex,@brand,@name,@available,@sold)";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.Parameters.AddWithValue("@size", tboxsize.Text);
                com.Parameters.AddWithValue("@buyprice", tboxbuyprice.Text);
                com.Parameters.AddWithValue("@sellprice", tboxsellprice.Text);
                com.Parameters.AddWithValue("@purpose", cboxpurpose.Text);
                com.Parameters.AddWithValue("@sex", cboxsex.Text);
                com.Parameters.AddWithValue("@brand", cboxbrand.Text);
                com.Parameters.AddWithValue("@name", tboxname.Text);
                com.Parameters.AddWithValue("@available", tboxavailable.Text);
                com.Parameters.AddWithValue("@sold", tboxsold.Text);
                com.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Product added", "Completed");
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT [product].size, " +
                            "[product].buy_price," +
                            "[product].product_id," +
                            "[product].purpose," +
                            "[product].sell_price," +
                            "[product].sex," +
                            "[product].brand," +
                            "[product].name," +
                            "[product].available, [product].sold FROM [product]", cnn);
                DataSet dt = new DataSet();
                da.Fill(dt);
                dgridproducts.DataSource = dt.Tables[0];
                cnn.Close();
                tboxsize.Text = "";
                tboxbuyprice.Text = "";
                tboxsellprice.Text = "";
                cboxsex.Text = "";
                cboxpurpose.Text = "";
                cboxbrand.Text = "";
                tboxname.Text = "";
                tboxavailable.Text = "";
            }
            else
            {
                MessageBox.Show("Please, fill the blank(s)", "Warning");
            }

        }

        private void tboxsize_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tboxbuyprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tboxsellprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tboxavailable_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if
                (dgridproducts.SelectedRows.Count > 0)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection cnn = new SqlConnection(connectionclass.address);
                    cnn.Open();
                    string sql = "DELETE FROM [product] WHERE product_id=@id";
                    SqlCommand com = new SqlCommand(sql, cnn);
                    com.Parameters.AddWithValue("@id", dgridproducts.CurrentRow.Cells[2].Value);
                    com.ExecuteNonQuery();
                    cnn.Close();
                    cnn.Open();
                    da = new SqlDataAdapter("Select * from [product]", cnn);
                    cmdb = new SqlCommandBuilder(da);
                    ds = new DataSet();
                    da.Fill(ds, "product");
                    dgridproducts.DataSource = ds.Tables[0];
                    dgridproducts.Columns[0].HeaderText = "Size";
                    dgridproducts.Columns[2].HeaderText = "Product Id";
                    dgridproducts.Columns[7].HeaderText = "Name";
                    dgridproducts.Columns[6].HeaderText = "Brand";
                    dgridproducts.Columns[3].HeaderText = "Purpose";
                    dgridproducts.Columns[1].HeaderText = "Buy Price";
                    dgridproducts.Columns[4].HeaderText = "Sell Price";
                    dgridproducts.Columns[5].HeaderText = "Sex";
                    dgridproducts.Columns[8].HeaderText = "Available";
                    dgridproducts.Columns[9].HeaderText = "Sold";
                    cnn.Close();
                    MessageBox.Show("Product deleted", "Completed");
                }
            }
            else
            {
                MessageBox.Show("Please, choose the row that you want delete",  "Warning");
            }
        }

        private void tboxsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form12_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tboxsold_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
