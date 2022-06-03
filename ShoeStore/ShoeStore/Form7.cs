using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();


        private void Form7_Load(object sender, EventArgs e)
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
            tboxccnum.Text = "";
            tboxcvc.Text = "";
            mtboxexdate.Text = "";
            tboxnameoncard.Text = "";

            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select* from[user] INNER JOIN [credit_card_info] ON [user].user_id=[credit_card_info].user_id where login_id = @loginid And login_password = @password";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.Parameters.AddWithValue("@loginid", tboxusername.Text);
            com.Parameters.AddWithValue("@password", tboxpassword1.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    tboxccnum.Text = dr["credit_card_number"].ToString();
                    tboxcvc.Text = dr["cvc"].ToString();
                    mtboxexdate.Text = dr["expiration_date"].ToString();
                    tboxnameoncard.Text = dr["name_on_card"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Important");
                tboxusername.Text = "";
                tboxpassword1.Text = "";
                tboxccnum.Text = "";
                tboxcvc.Text = "";
                mtboxexdate.Text = "";
                tboxnameoncard.Text = "";
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
                        tboxccnum.Text!=""&& tboxcvc.Text!=""&& mtboxexdate.Text!= "  .  ."
                    )
                {
                    SqlConnection cnn = new SqlConnection(connectionclass.address);
                    cnn.Open();
                    string sql = "update [credit_card_info]" +
                        "SET [credit_card_info].cvc='" + tboxcvc.Text + "'," +
                        "[credit_card_info].expiration_date=@date," +
                        "[credit_card_info].name_on_card='" + tboxnameoncard.Text + "'," +
                        "[credit_card_info].credit_card_number='" + tboxccnum.Text + "' FROM [credit_card_info] INNER JOIN [user] ON [credit_card_info].user_id = [user].user_id WHERE login_id = @loginid And login_password = @password";
                    SqlCommand com = new SqlCommand(sql, cnn);
                    com.Parameters.AddWithValue("@loginid", tboxusername.Text);
                    com.Parameters.AddWithValue("@password", tboxpassword1.Text);
                    com.Parameters.AddWithValue("@date", DateTime.Parse(mtboxexdate.Text));
                    SqlDataReader dr = com.ExecuteReader();
                    MessageBox.Show("Credit Card Information(s) updated", "Completed");
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

        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tboxcvc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tboxccnum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tboxnameoncard_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
