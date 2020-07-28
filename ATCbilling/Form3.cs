using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATCbilling
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=den1.mssql6.gear.host;Persist Security Info=True;User ID=atcaccounts;Password=Do72-8!iq51s");
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
                                FROM [dbo].[Login] Where UserName='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Class1.name =textBox1.Text;
                this.Hide();
                Form1 newmain = new Form1();
                newmain.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username & Password..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Clear();
                textBox1.Focus();

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SqlConnection con = new SqlConnection("Data Source=den1.mssql6.gear.host;Persist Security Info=True;User ID=atcaccounts;Password=Do72-8!iq51s");
                SqlDataAdapter sda = new SqlDataAdapter(@"SELECT *
                                FROM [dbo].[Login] Where UserName='" + textBox1.Text + "' and Password='" + textBox2.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    Class1.name = textBox1.Text;
                    this.Hide();
                    Form1 newmain = new Form1();
                    newmain.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username & Password..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    textBox2.Clear();
                    textBox1.Focus();

                }
            }
        }
        public string name { get; set; }
    }
}
