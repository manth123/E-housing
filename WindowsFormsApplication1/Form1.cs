using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void labe1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_e_societyDataSet.sdetails' table. You can move, or remove it, as needed.
            this.sdetailsTableAdapter.Fill(this._e_societyDataSet.sdetails);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
