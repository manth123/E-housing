using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection("Data Source=DESKTOP-CH98B3S\\SQLEXPRESS;Initial Catalog=e-society;Integrated Security=True");
            sqlcon.Open();
            String query = "Select * from login where username = ' " + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "'";
            SqlDataAdapter ada = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            ada.Fill(dtbl);
            if (dtbl.Rows.Count == 0)
            {
                mainform m1 = new mainform();
                this.Hide();
                m1.Show();

            }
            else
            {
                MessageBox.Show("plesase enter the correct details");
            }

            
            
/*          mainform f1 = new mainform();
            f1.Show();
            this.Hide();
*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
