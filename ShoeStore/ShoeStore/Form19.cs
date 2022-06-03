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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;

        private void Form19_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            tboxrole.Text = "0";
            cnn.Open();
            da = new SqlDataAdapter("Select first_name, last_name, login_id, login_password, user_id, role from [user] where role=0", cnn);
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "user");
            dgridadmins.DataSource = ds.Tables[0];
            dgridadmins.Columns[0].HeaderText = "Name";
            dgridadmins.Columns[1].HeaderText = "Surname";
            dgridadmins.Columns[2].HeaderText = "Username";
            dgridadmins.Columns[3].HeaderText = "Password";
            dgridadmins.Columns[5].HeaderText = "Role";
            dgridadmins.Columns[4].HeaderText = "User Id";
            dgridadmins.Columns["user_id"].ReadOnly = true;
            cnn.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Show();
            this.Hide();
        }

        private void Form19_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if
                (
                    tboxname.Text != "" &&
                    tboxlastname.Text != "" &&
                    tboxloginid.Text != "" &&
                    tboxpassword2.Text != ""
                )
            {
                SqlConnection cnn = new SqlConnection(connectionclass.address);
                cnn.Open();
                string sql = "insert into [user] (first_name,last_name,login_id,login_password,role) values (@name,@lastname,@username,@password,@role)";
                SqlCommand com = new SqlCommand(sql, cnn);
                com.Parameters.AddWithValue("@name", tboxname.Text);
                com.Parameters.AddWithValue("@lastname", tboxlastname.Text);
                com.Parameters.AddWithValue("@username", tboxloginid.Text);
                com.Parameters.AddWithValue("@password", tboxpassword2.Text);
                com.Parameters.AddWithValue("@role", tboxrole.Text);
                com.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Admin added", "Completed");
                cnn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT [user].first_name, " +
                            "[user].last_name," +
                            "[user].login_id," +
                            "[user].login_password," +
                            "[user].user_id," +
                            "[user].role FROM [user] where [user].role='0'", cnn);
                DataSet dt = new DataSet();
                da.Fill(dt);
                dgridadmins.DataSource = dt.Tables[0];
                cnn.Close();
                tboxname.Text = "";
                tboxlastname.Text = "";
                tboxloginid.Text = "";
                tboxpassword2.Text = "";
            }
            else
            {
                MessageBox.Show("Please, fill the blank(s)", "Warning");
            }
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            if
               (dgridadmins.SelectedRows.Count > 0)
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
                    com.Parameters.AddWithValue("@id", dgridadmins.CurrentRow.Cells[4].Value);
                    com.ExecuteNonQuery();
                    cnn.Close();
                    cnn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT [user].first_name, " +
                                "[user].last_name," +
                                "[user].login_id," +
                                "[user].login_password," +
                                "[user].user_id," +
                                "[user].role FROM [user] where [user].role='0'", cnn);
                    cmdb = new SqlCommandBuilder(da);
                    ds = new DataSet();
                    da.Fill(ds, "user");
                    dgridadmins.DataSource = ds.Tables[0];
                    dgridadmins.Columns[0].HeaderText = "Name";
                    dgridadmins.Columns[1].HeaderText = "Surname";
                    dgridadmins.Columns[2].HeaderText = "Username";
                    dgridadmins.Columns[3].HeaderText = "Password";
                    dgridadmins.Columns[4].HeaderText = "User Id";
                    dgridadmins.Columns[5].HeaderText = "Role";
                    cnn.Close();
                    MessageBox.Show("Admin deleted", "Completed");
                }
            }
            else
            {
                MessageBox.Show("Please, choose the row that you want delete", "Warning");
            }
        }

        private void tboxname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tboxlastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
