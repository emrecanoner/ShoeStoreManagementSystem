using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();

        private void Form8_Load(object sender, EventArgs e)
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
            tboxcountry.Text = "";
            tboxpostalcode.Text = "";
            tboxcity.Text = "";
            tboxdistrict.Text = "";
            tboxstreet.Text = "";
            tboxblockno.Text = "";
            tboxapartmentno.Text = "";

            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select* from[user] INNER JOIN [delivery_address] ON [user].user_id=[delivery_address].user_id where login_id = @loginid And login_password = @password";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.Parameters.AddWithValue("@loginid", tboxusername.Text);
            com.Parameters.AddWithValue("@password", tboxpassword1.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    tboxcountry.Text = dr["country"].ToString();
                    tboxpostalcode.Text = dr["postal_code"].ToString();
                    tboxcity.Text = dr["city"].ToString();
                    tboxdistrict.Text = dr["district"].ToString();
                    tboxstreet.Text = dr["street"].ToString();
                    tboxblockno.Text = dr["block_no"].ToString();
                    tboxapartmentno.Text = dr["apartment_no"].ToString();
                }
            }
            else
            {
                MessageBox.Show("Wrong Username or Password", "Important");
                tboxusername.Text = "";
                tboxpassword1.Text = "";
                tboxcountry.Text = "";
                tboxpostalcode.Text = "";
                tboxcity.Text = "";
                tboxdistrict.Text = "";
                tboxstreet.Text = "";
                tboxblockno.Text = "";
                tboxapartmentno.Text = "";

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
                        tboxcountry.Text!=""&&
                        tboxcity.Text != "" &&
                        tboxapartmentno.Text != "" &&
                        tboxblockno.Text != "" &&
                        tboxdistrict.Text != "" &&
                        tboxstreet.Text != "" &&
                        tboxpostalcode.Text != "" 
                    )
                {
                    SqlConnection cnn = new SqlConnection(connectionclass.address);
                    cnn.Open();
                    string sql = "update [delivery_address]" +
                    "SET country='" + tboxcountry.Text + "'," +
                    "[delivery_address].postal_code='" + tboxpostalcode.Text + "'," +
                    "[delivery_address].city='" + tboxcity.Text + "'," +
                    "[delivery_address].district='" + tboxdistrict.Text + "'," +
                    "[delivery_address].street='" + tboxstreet.Text + "'," +
                    "[delivery_address].block_no='" + tboxblockno.Text + "'," +
                    "[delivery_address].apartment_no='" + tboxapartmentno.Text + "' FROM [delivery_address]" +
                    "INNER JOIN [user] ON [delivery_address].user_id = [user].user_id where login_id = @loginid And login_password = @password";
                    SqlCommand com = new SqlCommand(sql, cnn);
                    com.Parameters.AddWithValue("@loginid", tboxusername.Text);
                    com.Parameters.AddWithValue("@password", tboxpassword1.Text);
                    SqlDataReader dr = com.ExecuteReader();
                    MessageBox.Show("Address Information(s) updated", "Completed");
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

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void tboxapartmentno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tboxpostalcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tboxblockno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tboxcountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tboxcity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void tboxdistrict_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }
    }
}
