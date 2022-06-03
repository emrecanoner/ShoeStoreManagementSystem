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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;

        private void btnback_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14();
            frm14.Show();
            this.Hide();
        }

        private void Form17_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            da = new SqlDataAdapter("Select * from [delivery_address]", cnn);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "delivery_address");
            dgridusers.DataSource = ds.Tables[0];
            dgridusers.Columns[0].HeaderText = "Address Id";
            dgridusers.Columns[1].HeaderText = "Country";
            dgridusers.Columns[2].HeaderText = "Postal Code";
            dgridusers.Columns[3].HeaderText = "City";
            dgridusers.Columns[4].HeaderText = "District";
            dgridusers.Columns[5].HeaderText = "Street";
            dgridusers.Columns[6].HeaderText = "Block No";
            dgridusers.Columns[7].HeaderText = "Apartment No";
            dgridusers.Columns[8].HeaderText = "User Id";
            dgridusers.Columns["user_id"].ReadOnly = true;
            dgridusers.Columns["address_id"].ReadOnly = true;
            cnn.Close();
        }

        private void dgridusers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tboxcountry.Text = dgridusers.CurrentRow.Cells[1].Value.ToString();
            tboxcity.Text = dgridusers.CurrentRow.Cells[3].Value.ToString();
            tboxdistrict.Text = dgridusers.CurrentRow.Cells[4].Value.ToString();
            tboxapartmentno.Text = dgridusers.CurrentRow.Cells[7].Value.ToString();
            tboxpostalcode.Text = dgridusers.CurrentRow.Cells[2].Value.ToString();
            tboxstreet.Text = dgridusers.CurrentRow.Cells[5].Value.ToString();
            tboxblockno.Text = dgridusers.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            dgridusers.DataSource = ds.Tables[0];
            da.Update(ds, "delivery_address");
            MessageBox.Show("Address Information(s) updated", "Completed");
            cnn.Close();
            tboxcountry.Text = "";
            tboxcity.Text = "";
            tboxdistrict.Text = "";
            tboxapartmentno.Text = "";
            tboxpostalcode.Text = "";
            tboxstreet.Text = "";
            tboxblockno.Text = "";
        }

        private void tboxsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
  
        }

        private void Form17_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
