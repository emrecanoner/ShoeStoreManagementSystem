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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;

        private void btnback_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            frm9.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
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
            dgridproducts.Columns[9].HeaderText = "Sold";
            dgridproducts.Columns["product_id"].ReadOnly = true;
            cnn.Close();
        }

        private void dgridproducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tboxsize.Text = dgridproducts.CurrentRow.Cells[0].Value.ToString();
            tboxbuyprice.Text = dgridproducts.CurrentRow.Cells[1].Value.ToString() + "$";
            tboxpurpose.Text = dgridproducts.CurrentRow.Cells[3].Value.ToString();
            tboxsellprice.Text = dgridproducts.CurrentRow.Cells[4].Value.ToString() + "$";
            tboxsex.Text = dgridproducts.CurrentRow.Cells[5].Value.ToString();
            tboxbrand.Text = dgridproducts.CurrentRow.Cells[6].Value.ToString();
            tboxname.Text = dgridproducts.CurrentRow.Cells[7].Value.ToString();
            tboxavailable.Text = dgridproducts.CurrentRow.Cells[8].Value.ToString();
            tboxsold.Text = dgridproducts.CurrentRow.Cells[9].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            dgridproducts.DataSource = ds.Tables[0];
            da.Update(ds, "product");
            MessageBox.Show("Product(s) updated", "Completed!");
            cnn.Close();
            tboxsize.Text = "";
            tboxbuyprice.Text = "";
            tboxpurpose.Text = "";
            tboxsellprice.Text = "";
            tboxsex.Text = "";
            tboxbrand.Text = "";
            tboxname.Text = "";
            tboxavailable.Text = "";
            tboxsold.Text = "";
        }

        private void tboxsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
