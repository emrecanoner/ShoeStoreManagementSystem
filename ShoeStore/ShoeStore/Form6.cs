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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();

        private void Form6_Load(object sender, EventArgs e)
        {
            tboxpassword1.PasswordChar = '*';
            this.AcceptButton = btnfill;
        }

        private void btnfill_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btnfill_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            tboxname.Text = "";
            tboxmail.Text = "";
            tboxloginid.Text = "";
            tboxlastname.Text = "";
            tboxtnumber.Text = "";
            tboxpassword2.Text = "";

            cnn.Open();
            string sql = "Select* from[user] where login_id = @loginid And login_password = @password";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.Parameters.AddWithValue("@loginid", tboxusername.Text);
            com.Parameters.AddWithValue("@password", tboxpassword1.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    tboxname.Text = dr["first_name"].ToString();
                    tboxmail.Text = dr["mail_address"].ToString();
                    tboxloginid.Text = dr["login_id"].ToString();
                    tboxlastname.Text = dr["last_name"].ToString();
                    tboxtnumber.Text = dr["telephone_number"].ToString();
                    tboxpassword2.Text = dr["login_password"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Important");
                tboxusername.Text = "";
                tboxpassword1.Text = "";
                tboxname.Text = "";
                tboxmail.Text = "";
                tboxloginid.Text = "";
                tboxlastname.Text = "";
                tboxtnumber.Text = "";
                tboxpassword2.Text = "";

            }
            cnn.Close();
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {

            if (tboxusername.Text == "" || tboxpassword1.Text == "")
            {
                MessageBox.Show("Please, input Username or Password");
            }
            else
            {
                if
                    (
                        tboxname.Text!=""&&
                        tboxlastname.Text != "" &&
                        tboxloginid.Text != "" &&
                        tboxpassword2.Text != ""
                    )
                {
                    SqlConnection cnn = new SqlConnection(connectionclass.address);
                    cnn.Open();
                    string sql = "update [user]" +
                        "SET [user].first_name='" + tboxname.Text + "'," +
                        "[user].last_name='" + tboxlastname.Text + "' ," +
                        "[user].telephone_number='" + tboxtnumber.Text + "'," +
                        "[user].mail_address='" + tboxmail.Text + "'," +
                        "[user].login_id='" + tboxloginid.Text + "'," +
                        "[user].login_password='" + tboxpassword2.Text + "' FROM [user]" +
                        "where [user].login_id = @loginid And [user].login_password = @password";
                    SqlCommand com = new SqlCommand(sql, cnn);
                    com.Parameters.AddWithValue("@loginid", tboxusername.Text);
                    com.Parameters.AddWithValue("@password", tboxpassword1.Text);
                    SqlDataReader dr = com.ExecuteReader();
                    MessageBox.Show("User Information(s) updated", "Completed");
                    cnn.Close();
                }
                else
                {
                    MessageBox.Show("Please, fill the blank(s)", "Warning");
                }
            }
        }

        private void btnalert_Click(object sender, EventArgs e)
        {
            string impomes = "Please input your Username and Password then click Fill button.";
            MessageBox.Show(impomes, "Important");
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tboxtnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
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
