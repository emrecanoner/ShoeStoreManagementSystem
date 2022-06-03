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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnconnect;
        }
        connectionclass connectionclass = new connectionclass();


        private void Form1_Load(object sender, EventArgs e)
        {
            tboxpassword.PasswordChar = '*';
        }

        private void btnconnect_Click(object sender, EventArgs e)
        {
            SqlConnection cnn = new SqlConnection(connectionclass.address);
            cnn.Open();
            string sql = "Select * from[user] where login_id = @username And login_password = @password";
            SqlCommand com = new SqlCommand(sql, cnn);
            com.Parameters.AddWithValue("@username", tboxusername.Text);
            com.Parameters.AddWithValue("@password", tboxpassword.Text);
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {               
                    if (dr["role"].ToString() == "0")
                    {
                        Form3 frm3 = new Form3();
                        frm3.Show();
                        this.Hide();
                    }
                    else
                    {
                        Form4 frm4 = new Form4();
                        frm4.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sorry, incorrect login");
            }

            tboxpassword.Clear();
            tboxusername.Clear();
            cnn.Close();
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
