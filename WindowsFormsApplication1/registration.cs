using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class registration : Form
    {
        public registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-CH98B3S\\SQLEXPRESS;Initial Catalog=e-society;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter();

            String Query = "insert into sdetails (sname,no_houses,address,city,pincode) values(@sname,@no_houses,@address,@city,@pincode)";
            using (SqlCommand cmd = new SqlCommand(Query, con))
            {
                cmd.Parameters.AddWithValue("@sname", textBox1.Text);
                cmd.Parameters.AddWithValue("@no_houses", textBox2.Text);
                cmd.Parameters.AddWithValue("@address", textBox3.Text);
                cmd.Parameters.AddWithValue("@city", textBox4.Text);
                cmd.Parameters.AddWithValue("@pincode", textBox5.Text);

                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result < 0)
                {
                    MessageBox.Show("error");
                }
                else
                    MessageBox.Show("Data Saved");

                con.Close();
            }

        }

        private void registration_Load(object sender, EventArgs e)
        {

        }
    }
}
