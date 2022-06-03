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
    public partial class Form15 : Form
    {
        public Form15()
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

        private void Form15_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            da = new SqlDataAdapter("Select * from [user]", cnn);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "user");
            dgridusers.DataSource = ds.Tables[0];
            dgridusers.Columns[0].HeaderText = "Name";
            dgridusers.Columns[1].HeaderText = "Surname";
            dgridusers.Columns[2].HeaderText = "Telephone Number";
            dgridusers.Columns[3].HeaderText = "Mail";
            dgridusers.Columns[4].HeaderText = "Username";
            dgridusers.Columns[6].HeaderText = "Password";
            dgridusers.Columns[5].HeaderText = "Role";
            dgridusers.Columns[7].HeaderText = "User Id";
            dgridusers.Columns["user_id"].ReadOnly = true;
            cnn.Close();
        }

        private void dgridusers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tboxname.Text = dgridusers.CurrentRow.Cells[0].Value.ToString();
            tboxlastname.Text = dgridusers.CurrentRow.Cells[1].Value.ToString();
            tboxtnumber.Text = dgridusers.CurrentRow.Cells[2].Value.ToString();
            tboxmail.Text = dgridusers.CurrentRow.Cells[3].Value.ToString();
            tboxloginid.Text = dgridusers.CurrentRow.Cells[4].Value.ToString();
            tboxpassword2.Text = dgridusers.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            dgridusers.DataSource = ds.Tables[0];
            da.Update(ds, "user");
            MessageBox.Show("User(s) updated", "Completed");
            cnn.Close();
            tboxname.Text = "";
            tboxlastname.Text = "";
            tboxtnumber.Text = "";
            tboxmail.Text = "";
            tboxloginid.Text = "";
            tboxpassword2.Text = "";
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if
               (dgridusers.SelectedRows.Count > 0)
            {
                DialogResult dialog = new DialogResult();
                dialog = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection cnn = new SqlConnection(connectionclass.address);
                    cnn.Open();
                    string sql = "DELETE FROM [credit_card_info] WHERE user_id=@id " +
                                 "DELETE FROM [delivery_address] WHERE user_id=@id " +
                                 "DELETE FROM [user] WHERE user_id=@id ";
                    SqlCommand com = new SqlCommand(sql, cnn);
                    com.Parameters.AddWithValue("@id", dgridusers.CurrentRow.Cells[7].Value);
                    com.ExecuteNonQuery();
                    cnn.Close();
                    cnn.Open();
                    da = new SqlDataAdapter("Select * from [user]", cnn);
                    cmdb = new SqlCommandBuilder(da);
                    ds = new DataSet();
                    da.Fill(ds, "user");
                    dgridusers.DataSource = ds.Tables[0];
                    dgridusers.Columns[0].HeaderText = "Name";
                    dgridusers.Columns[1].HeaderText = "Surname";
                    dgridusers.Columns[2].HeaderText = "Telephone Number";
                    dgridusers.Columns[3].HeaderText = "Mail";
                    dgridusers.Columns[4].HeaderText = "Username";
                    dgridusers.Columns[5].HeaderText = "Password";
                    dgridusers.Columns[6].HeaderText = "Role";
                    dgridusers.Columns[7].HeaderText = "User Id";
                    cnn.Close();
                    MessageBox.Show("User deleted", "Completed");
                }
            }
            else
            {
                MessageBox.Show("Please, choose the row that you want delete", "Warning");
            }           
        }

        private void tboxsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form15_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
