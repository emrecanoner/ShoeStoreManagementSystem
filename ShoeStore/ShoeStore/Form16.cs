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
    public partial class Form16 : Form
    {
        public Form16()
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

        private void Form16_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            da = new SqlDataAdapter("Select * from [credit_card_info]", cnn);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "credit_card_info");
            dgridusers.DataSource = ds.Tables[0];
            dgridusers.Columns[0].HeaderText = "Card Id";
            dgridusers.Columns[1].HeaderText = "Name On Card";
            dgridusers.Columns[2].HeaderText = "Credit Card Number";
            dgridusers.Columns[3].HeaderText = "CVC";
            dgridusers.Columns[4].HeaderText = "Expiration Date";
            dgridusers.Columns[5].HeaderText = "User Id";
            dgridusers.Columns["user_id"].ReadOnly = true;
            dgridusers.Columns["card_id"].ReadOnly = true;
            cnn.Close();
        }

        private void dgridusers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tboxccnum.Text = dgridusers.CurrentRow.Cells[2].Value.ToString();
            tboxcvc.Text = dgridusers.CurrentRow.Cells[3].Value.ToString();
            mtboxexpirationdate.Text = dgridusers.CurrentRow.Cells[4].Value.ToString();
            tboxnameoncard.Text = dgridusers.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            dgridusers.DataSource = ds.Tables[0];
            da.Update(ds, "credit_card_info");
            MessageBox.Show("Credit Card Information(s) updated", "Completed");
            cnn.Close();
            tboxccnum.Text = "";
            tboxcvc.Text = "";
            mtboxexpirationdate.Text = "";
            tboxnameoncard.Text = ""; 
        }

        private void tboxsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form16_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
