using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoeStore
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            frm11.Show();
            this.Hide();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            Form15 frm15 = new Form15();
            frm15.Show();
            this.Hide();
        }

        private void btncreditcard_Click(object sender, EventArgs e)
        {
            Form16 frm16 = new Form16();
            frm16.Show();
            this.Hide();
        }

        private void btnaddress_Click(object sender, EventArgs e)
        {
            Form17 frm17 = new Form17();
            frm17.Show();
            this.Hide();
        }

        private void Form14_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void Form14_Load(object sender, EventArgs e)
        {

        }
    }
}
