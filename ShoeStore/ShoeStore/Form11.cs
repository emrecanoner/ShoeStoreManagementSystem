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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();

        private void Form11_Load(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "select [user].first_name,"+
                        "[user].last_name,"+
                        "[user].telephone_number,"+
                        "[user].mail_address,"+
                        "[user].login_id,"+
                        "[user].login_password,"+
                        "[user].role,"+
                        "[user].user_id,"+
                        "[delivery_address].address_id,"+
                        "[delivery_address].apartment_no,"+
                        "[delivery_address].block_no,"+
                        "[delivery_address].city,"+
                        "[delivery_address].country,"+
                        "[delivery_address].district,"+
                        "[delivery_address].postal_code,"+
                        "[delivery_address].street,"+
                        "[credit_card_info].card_id,"+
                        "[credit_card_info].credit_card_number,"+
                        "[credit_card_info].cvc,"+
                        "[credit_card_info].expiration_date,"+
                        "[credit_card_info].name_on_card from [user] left join [delivery_address] on [user].user_id=[delivery_address].user_id left join [credit_card_info] on [user].user_id=[credit_card_info].user_id";
            SqlCommand com = new SqlCommand(sql, cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridusers.DataSource = dt;
            dgridusers.Columns[0].HeaderText = "Name";
            dgridusers.Columns[1].HeaderText = "Surname";
            dgridusers.Columns[2].HeaderText = "Telephone Number";
            dgridusers.Columns[3].HeaderText = "Mail";
            dgridusers.Columns[4].HeaderText = "Username";
            dgridusers.Columns[5].HeaderText = "Password";
            dgridusers.Columns[6].HeaderText = "Role";
            dgridusers.Columns[7].HeaderText = "User Id";
            dgridusers.Columns[8].HeaderText = "Address Id";
            dgridusers.Columns[9].HeaderText = "Apartment No";
            dgridusers.Columns[10].HeaderText = "Block No";
            dgridusers.Columns[11].HeaderText = "City";
            dgridusers.Columns[12].HeaderText = "Country";
            dgridusers.Columns[13].HeaderText = "District";
            dgridusers.Columns[14].HeaderText = "Postal Code";
            dgridusers.Columns[15].HeaderText = "Street";
            dgridusers.Columns[16].HeaderText = "Card Id";
            dgridusers.Columns[17].HeaderText = "Credit Card Number";
            dgridusers.Columns[18].HeaderText = "CVC";
            dgridusers.Columns[19].HeaderText = "Expiration Date";
            dgridusers.Columns[20].HeaderText = "Name on Card";
            cnn.Close();
        }

        private void lblusers_Click(object sender, EventArgs e)
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

        }

        private void btnusersettings_Click(object sender, EventArgs e)
        {
            Form14 frm14 = new Form14();
            frm14.Show();
            this.Hide();
        }

        private void btnaddremove_Click(object sender, EventArgs e)
        {

        }

        private void dgridusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tboxsearch_TextChanged(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            SqlCommand com = new SqlCommand("select[user].first_name, "+
                        "[user].last_name," +
                        "[user].telephone_number," +
                        "[user].mail_address," +
                        "[user].login_id," +
                        "[user].login_password," +
                        "[user].role," +
                        "[user].user_id," +
                        "[delivery_address].address_id," +
                        "[delivery_address].apartment_no," +
                        "[delivery_address].block_no," +
                        "[delivery_address].city," +
                        "[delivery_address].country," +
                        "[delivery_address].district," +
                        "[delivery_address].postal_code," +
                        "[delivery_address].street," +
                        "[credit_card_info].card_id," +
                        "[credit_card_info].credit_card_number," +
                        "[credit_card_info].cvc," +
                        "[credit_card_info].expiration_date," +
                        "[credit_card_info].name_on_card from [user] inner join [delivery_address] on [user].user_id=[delivery_address].user_id inner join [credit_card_info] on [user].user_id=[credit_card_info].user_id where [user].first_name like '%" + tboxsearch.Text + "%'", cnn);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgridusers.DataSource = dt;         
            cnn.Close();
        }

        private void tboxsearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnaddadmin_Click(object sender, EventArgs e)
        {
            Form19 frm19 = new Form19();
            frm19.Show();
            this.Hide();
        }
    }
}
