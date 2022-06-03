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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        connectionclass connectionclass = new connectionclass();

        private void btnlist_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            tboxsize.Text = "";
            tboxavailable.Text = "";
            tboxpurpose.Text = "";
            tboxsellprice.Text = "";
            tboxsex.Text = "";
            tboxbrand.Text = "";
            Products.Items.Clear();
            cnn.Open();
            SqlCommand com = new SqlCommand("Select * from [product]", cnn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Products.Items.Add(dr[7]);
            }
            cnn.Close();
        }

        private void Products_DoubleClick(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select* from[product] where name = @name";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.Parameters.AddWithValue("@name", Products.SelectedItem.ToString());
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                tboxsize.Text = dr["size"].ToString();
                tboxavailable.Text = dr["available"].ToString();
                tboxpurpose.Text = dr["purpose"].ToString();
                tboxsellprice.Text = dr["sell_price"].ToString()+"$";
                tboxsex.Text = dr["sex"].ToString();
                tboxbrand.Text = dr["brand"].ToString();
            }
            cnn.Close();
        }

        private void tboxsex_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnusersettings_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnloginpage_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }

}

