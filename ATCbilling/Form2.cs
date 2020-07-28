using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATCbilling
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=billhistory;Password=Eo04NJ?_TuJ6");
            SqlDataAdapter sda = new SqlDataAdapter("Select billno,year From [dbo].[Cash_Bill]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["billno"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["year"].ToString();
            }
            dataGridView1.Visible = true;
            dataGridView2.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string sl, year;
            sl = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            year = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            using (SqlConnection cn = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=billhistory;Password=Eo04NJ?_TuJ6"))
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand("select pdf from Cash_Bill where billno='" + sl + "' and year ='" + year + "' ", cn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.Default))
                    {

                        if (dr.Read())
                        {
                            byte[] fileData = (byte[])dr.GetValue(0);
                            using (FileStream fs = new FileStream("ATC-C-" + sl + "-2018-19(CashBill).pdf", FileMode.Create))
                            {
                                fs.Write(fileData, 0, fileData.Length);
                            }

                        }
                        dr.Close();
                    }
                }
            }
            //bytes = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            //using (FileStream fs = new FileStream("ATC-C-"+label6.Text+ "-2018-19.pdf", FileMode.Create))
            //{
            //fs.Write(bytes, 0, bytes.Length);
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=billhistory;Password=Eo04NJ?_TuJ6");
            SqlDataAdapter sda = new SqlDataAdapter("Select billno,year From [dbo].[Tender_bill]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.Rows.Clear();

            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = item["billno"].ToString();
                dataGridView2.Rows[n].Cells[1].Value = item["year"].ToString();
            }
            dataGridView1.Visible = false;
            dataGridView2.Visible = true;
        }

        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string sl, year;
            sl = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            year = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            using (SqlConnection cn = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=billhistory;Password=Eo04NJ?_TuJ6"))
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand("select pdf from Tender_bill where billno='" + sl + "' and year ='" + year + "' ", cn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.Default))
                    {

                        if (dr.Read())
                        {
                            byte[] fileData = (byte[])dr.GetValue(0);
                            using (FileStream fs = new FileStream("ATC-B-" + sl + "-2018-19(TenderBill).pdf", FileMode.Create))
                            {
                                fs.Write(fileData, 0, fileData.Length);
                            }

                        }
                        dr.Close();
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sqlQuery = "";
            SqlConnection con = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=billhistory;Password=Eo04NJ?_TuJ6");
            con.Open();
            sqlQuery = @"DELETE FROM Cash_Bill ";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();

            con.Open();
            sqlQuery = @"DELETE FROM Tender_bill ";
            cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
