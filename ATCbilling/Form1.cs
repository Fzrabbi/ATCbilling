using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Web;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ATCbilling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.cash_bill' table. You can move, or remove it, as needed.
            this.cash_billTableAdapter.Fill(this.DataSet1.cash_bill);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
           
            //SqlDataAdapter sda = new SqlDataAdapter("Select sl From [dbo].[cash_bill] WHERE sl=(SELECT MAX(sl) From [dbo].[cash_bill]) ", con);
            
            
        }

        private void Refreash_Click(object sender, EventArgs e)
        {   
            //check the sl no & increase
            if (comboBox1.Text == "Cash Bill")
            {
                int max;
                using (var con = new SqlConnection("Data Source=den1.mssql6.gear.host;Persist Security Info=True;User ID=atcaccounts;Password=Do72-8!iq51s"))
                {
                    var sql = "Select sl From [dbo].[cash_bill] WHERE sl=(SELECT MAX(sl) From [dbo].[cash_bill] where year='2018-19')";
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("sl", Int32.Parse(label6.Text));
                        con.Open();
                        max = (int)cmd.ExecuteScalar();
                        con.Close();
                    }
                }
                label6.Text = (max + 1).ToString();
            }
            if (comboBox1.Text == "Tender Bill")
            {
                int max;
                using (var con = new SqlConnection("Data Source=den1.mssql6.gear.host;Persist Security Info=True;User ID=atcaccounts;Password=Do72-8!iq51s"))
                {
                    var sql = "Select sl From [dbo].[tender_bill] WHERE sl=(SELECT MAX(sl) From [dbo].[tender_bill] where year='2018-19')";
                    using (var cmd = new SqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("sl", Int32.Parse(label6.Text));
                        con.Open();
                        max = (int)cmd.ExecuteScalar();
                        con.Close();
                    }
                }
                label6.Text = (max + 1).ToString();
            }

            ReportParameterCollection reportParameters = new ReportParameterCollection();
            ReportParameterCollection reportParameters1 = new ReportParameterCollection();
            //for Bill
            reportParameters.Add(new ReportParameter("no", label6.Text));
            reportParameters.Add(new ReportParameter("date", textBox2.Text));
            reportParameters.Add(new ReportParameter("To", textBox3.Text));
            reportParameters.Add(new ReportParameter("sub", textBox4.Text));
            reportParameters.Add(new ReportParameter("ref", textBox18.Text));
            reportParameters.Add(new ReportParameter("packageno", textBox19.Text));
            reportParameters.Add(new ReportParameter("dear_sir", textBox5.Text));
            reportParameters.Add(new ReportParameter("amountinword", textBox17.Text));
            reportParameters.Add(new ReportParameter("your_sincerely", textBox7.Text));
            //for Challan
            reportParameters1.Add(new ReportParameter("no", label6.Text));
            reportParameters1.Add(new ReportParameter("date", textBox2.Text));
            reportParameters1.Add(new ReportParameter("To", textBox20.Text));
            reportParameters1.Add(new ReportParameter("sub", textBox23.Text));
            reportParameters1.Add(new ReportParameter("ref", textBox18.Text));
            reportParameters1.Add(new ReportParameter("packageno", textBox19.Text));
            reportParameters1.Add(new ReportParameter("dear_sir", textBox22.Text));
            reportParameters1.Add(new ReportParameter("your_sincerely", textBox7.Text));

            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.reportViewer1.RefreshReport();
            this.reportViewer2.LocalReport.SetParameters(reportParameters1);
            this.reportViewer2.RefreshReport();

            

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sqlQuery = "";
            SqlConnection con = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=atcbill;Password=Zy8m9J?65!3Y");
            con.Open();
            sqlQuery = @"INSERT INTO [dbo].[cash_bill]
           ([sl]
           ,[name]
           ,[qty]
           ,[price]
           ,[total_price])VALUES
            ('" + textBox8.Text + "','" + textBox9.Text + "','" + textBox10.Text + "','" + textBox11.Text + "','" + textBox12.Text + "')";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            //reportViewer1.Clear();
            //this.DataSet1.Reset();
            this.cash_billTableAdapter.Fill(this.DataSet1.cash_bill);
            this.reportViewer1.RefreshReport();
            
        }

        private void button2_Click(object sender, EventArgs e)//delete from table
        {
            var sqlQuery = "";
            SqlConnection con = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=atcbill;Password=Zy8m9J?65!3Y");
            con.Open();
            sqlQuery = @"DELETE FROM [cash_bill] WHERE [sl] = '" + textBox13.Text + "'";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            this.cash_billTableAdapter.Fill(this.DataSet1.cash_bill);
            this.reportViewer1.RefreshReport();
        }

        private void button3_Click(object sender, EventArgs e) //save,done
        {
            
            
            //Confirmation of proceeding process
            DialogResult dialogResult = MessageBox.Show("By Clicking YES the Bill will be Stored into the Database, are you SURE you want to Proceed ?", "Finalize", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //check the sl no & increase
                if (comboBox1.Text == "Cash Bill")
                {
                    int max;
                    using (var con = new SqlConnection("Data Source=den1.mssql6.gear.host;Persist Security Info=True;User ID=atcaccounts;Password=Do72-8!iq51s"))
                    {
                        var sql = "Select sl From [dbo].[cash_bill] WHERE sl=(SELECT MAX(sl) From [dbo].[cash_bill] where year='2018-19')";
                        using (var cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("sl", Int32.Parse(label6.Text));
                            con.Open();
                            max = (int)cmd.ExecuteScalar();
                            con.Close();
                        }
                    }
                    label6.Text = (max + 1).ToString();
                }
                if (comboBox1.Text == "Tender Bill")
                {
                    int max;
                    using (var con = new SqlConnection("Data Source=den1.mssql6.gear.host;Persist Security Info=True;User ID=atcaccounts;Password=Do72-8!iq51s"))
                    {
                        var sql = "Select sl From [dbo].[tender_bill] WHERE sl=(SELECT MAX(sl) From [dbo].[tender_bill] where year='2018-19')";
                        using (var cmd = new SqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("sl", Int32.Parse(label6.Text));
                            con.Open();
                            max = (int)cmd.ExecuteScalar();
                            con.Close();
                        }
                    }
                    label6.Text = (max + 1).ToString();
                }
                //refreash reportviewer once more
                ReportParameterCollection reportParameters = new ReportParameterCollection();
                ReportParameterCollection reportParameters1 = new ReportParameterCollection();
                reportParameters.Add(new ReportParameter("no", label6.Text));
                reportParameters.Add(new ReportParameter("date", textBox2.Text));
                reportParameters.Add(new ReportParameter("To", textBox3.Text));
                reportParameters.Add(new ReportParameter("sub", textBox4.Text));
                reportParameters.Add(new ReportParameter("ref", textBox18.Text));
                reportParameters.Add(new ReportParameter("packageno", textBox19.Text));
                reportParameters.Add(new ReportParameter("dear_sir", textBox5.Text));
                reportParameters.Add(new ReportParameter("amountinword", textBox17.Text));
                reportParameters.Add(new ReportParameter("your_sincerely", textBox7.Text));

                reportParameters1.Add(new ReportParameter("no", label6.Text));
                reportParameters1.Add(new ReportParameter("date", textBox2.Text));
                reportParameters1.Add(new ReportParameter("To", textBox20.Text));
                reportParameters1.Add(new ReportParameter("sub", textBox23.Text));
                reportParameters1.Add(new ReportParameter("ref", textBox18.Text));
                reportParameters1.Add(new ReportParameter("packageno", textBox19.Text));
                reportParameters1.Add(new ReportParameter("dear_sir", textBox22.Text));
                reportParameters1.Add(new ReportParameter("your_sincerely", textBox7.Text));

                this.reportViewer1.LocalReport.SetParameters(reportParameters);
                this.reportViewer1.RefreshReport();
                this.reportViewer2.LocalReport.SetParameters(reportParameters1);
                this.reportViewer2.RefreshReport();
                //
                if (comboBox1.Text == "Cash Bill")//for storing cash bill
                {
                    if (Int32.Parse(label6.Text) > -1)
                    {
                        //increase the sl no if taken
                        //check the sl no & increase
                        if (comboBox1.Text == "Cash Bill")
                        {
                            int max;
                            using (var con = new SqlConnection("Data Source=den1.mssql6.gear.host;Persist Security Info=True;User ID=atcaccounts;Password=Do72-8!iq51s"))
                            {
                                var sql = "Select sl From [dbo].[cash_bill] WHERE sl=(SELECT MAX(sl) From [dbo].[cash_bill] where year='2018-19')";
                                using (var cmd = new SqlCommand(sql, con))
                                {
                                    cmd.Parameters.AddWithValue("sl", Int32.Parse(label6.Text));
                                    con.Open();
                                    max = (int)cmd.ExecuteScalar();
                                    con.Close();
                                }
                            }
                            label6.Text = (max + 1).ToString();
                        }
                        if (comboBox1.Text == "Tender Bill")
                        {
                            int max;
                            using (var con = new SqlConnection("Data Source=den1.mssql6.gear.host;Persist Security Info=True;User ID=atcaccounts;Password=Do72-8!iq51s"))
                            {
                                var sql = "Select sl From [dbo].[tender_bill] WHERE sl=(SELECT MAX(sl) From [dbo].[tender_bill] where year='2018-19')";
                                using (var cmd = new SqlCommand(sql, con))
                                {
                                    cmd.Parameters.AddWithValue("sl", Int32.Parse(label6.Text));
                                    con.Open();
                                    max = (int)cmd.ExecuteScalar();
                                    con.Close();
                                }
                            }
                            label6.Text = (max + 1).ToString();
                        }
                    }
                    //

                    //Storing PDF byte form

                    Warning[] warnings;
                    string[] streamids;
                    string mimeType;
                    string encoding;
                    string filenameExtension;

                    byte[] bytes = reportViewer1.LocalReport.Render(
                        "PDF", null, out mimeType, out encoding, out filenameExtension,
                        out streamids, out warnings);

                    byte[] bytes1 = reportViewer2.LocalReport.Render(
                        "PDF", null, out mimeType, out encoding, out filenameExtension,
                        out streamids, out warnings);

                    var sqlQuery = "";
                    //SqlConnection con2 = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=billhistory;Password=Eo04NJ?_TuJ6");
                    //con2.Open();
                    //sqlQuery = @"INSERT INTO [dbo].[Cash_Bill]
                    //([billno]
                    //,[year]
                    //,[pdf])VALUES
                    //('" + "ATC/C-" + label6.Text + "/2018-19" + "','" + "2018-19" + "','" + bytes + "')";
                    //SqlCommand cmd2 = new SqlCommand(sqlQuery, con2);
                    //cmd2.ExecuteNonQuery();
                    //con2.Close();


                    //fetching byte to pdf
                    using (FileStream fs = new FileStream("ATC-B-" + label6.Text + "-2018-19.pdf", FileMode.Create))
                    {
                        fs.Write(bytes, 0, bytes.Length);
                    }

                    using (FileStream fs = new FileStream("ATC-C-" + label6.Text + "-2018-19.pdf", FileMode.Create))
                    {
                        fs.Write(bytes1, 0, bytes1.Length);
                    }

                    //Storing to db

                    using (SqlConnection cn = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=billhistory;Password=Eo04NJ?_TuJ6"))
                    {

                        cn.Open();

                        FileStream fStream = File.OpenRead("ATC-B-" + label6.Text + "-2018-19.pdf");

                        byte[] contents = new byte[fStream.Length];

                        fStream.Read(contents, 0, (int)fStream.Length);

                        fStream.Close();

                        using (SqlCommand cmd = new SqlCommand("insert into Cash_Bill " + "(billno,year,pdf) values(@billno,@year,@data)", cn))
                        {
                            cmd.Parameters.Add("@billno", label6.Text);
                            cmd.Parameters.Add("@year", "2018-19");
                            cmd.Parameters.Add("@data", contents);
                            cmd.ExecuteNonQuery();

                            // Response.Write("Pdf File Save in Dab");

                        }

                    }
                    //refreash reportviewer once more
                    reportParameters = new ReportParameterCollection();
                    reportParameters1 = new ReportParameterCollection();
                    reportParameters.Add(new ReportParameter("no", label6.Text));
                    reportParameters.Add(new ReportParameter("date", textBox2.Text));
                    reportParameters.Add(new ReportParameter("To", textBox3.Text));
                    reportParameters.Add(new ReportParameter("sub", textBox4.Text));
                    reportParameters.Add(new ReportParameter("ref", textBox18.Text));
                    reportParameters.Add(new ReportParameter("packageno", textBox19.Text));
                    reportParameters.Add(new ReportParameter("dear_sir", textBox5.Text));
                    reportParameters.Add(new ReportParameter("amountinword", textBox17.Text));
                    reportParameters.Add(new ReportParameter("your_sincerely", textBox7.Text));

                    reportParameters1.Add(new ReportParameter("no", label6.Text));
                    reportParameters1.Add(new ReportParameter("date", textBox2.Text));
                    reportParameters1.Add(new ReportParameter("To", textBox20.Text));
                    reportParameters1.Add(new ReportParameter("sub", textBox23.Text));
                    reportParameters1.Add(new ReportParameter("ref", textBox18.Text));
                    reportParameters1.Add(new ReportParameter("packageno", textBox19.Text));
                    reportParameters1.Add(new ReportParameter("dear_sir", textBox22.Text));
                    reportParameters1.Add(new ReportParameter("your_sincerely", textBox7.Text));

                    this.reportViewer1.LocalReport.SetParameters(reportParameters);
                    this.reportViewer1.RefreshReport();
                    this.reportViewer2.LocalReport.SetParameters(reportParameters1);
                    this.reportViewer2.RefreshReport();
                    //

                    //inserting to database
                    string year = "2018-19";
                    string org = textBox3.Text.ToString();
                    int sl = Convert.ToInt32(label6.Text);
                    string billchalanrefno = "ATC/B-" + sl + "/2018-19";
                    decimal amount = decimal.Parse(textBox1.Text);
                    decimal rec = decimal.Parse(textBox6.Text);
                    decimal vat = decimal.Parse(textBox14.Text);
                    decimal tax = decimal.Parse(textBox15.Text);
                    decimal due = amount - (rec + vat + tax);
                    string remarks = textBox16.Text.ToString();
                    if (sl > -1)
                    {
                        SqlConnection con1 = new SqlConnection("Data Source=den1.mssql6.gear.host;Persist Security Info=True;User ID=atcaccounts;Password=Do72-8!iq51s");
                        con1.Open();
                        sqlQuery = "";
                        sqlQuery = @"INSERT INTO [dbo].[cash_bill]
                    ([sl]
                    ,[org]
                    ,[billing_date]
                    ,[bill_challan_ref]
                    ,[amount]
                    ,[received]
                    ,[vat]
                    ,[tax]
                    ,[due]
                    ,[remarks]
                    ,[year])VALUES
                     ('" + sl + "','" + org + "','" + DateTime.Now + "','" + billchalanrefno + "','" + amount + "','" + rec + "','" + vat + "','" + tax + "','" + due + "','" + remarks+'('+Class1.name+')'+ "','" + year + "')";
                        SqlCommand cmd1 = new SqlCommand(sqlQuery, con1);
                        cmd1.ExecuteNonQuery();
                        con1.Close();
                        //clear all data from Textboxes
                        label6.Text = "-1";
                        //after storing info to database
                        DialogResult dialogResult1 = MessageBox.Show("Sucessfully Stored all the information to Database, you are now authorize to PRINT the bill and do not forget to close the window after Printing.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult1 == DialogResult.OK)
                        {
                        }
                    }
                    else
                    {
                        DialogResult dialogResult2 = MessageBox.Show("Bill no. is not updated...!", "Serial is not Synconized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    //

                }
                if (comboBox1.Text == "Tender Bill")//for storing in tender bill
                {

                    if (Int32.Parse(label6.Text) > -1)
                    {
                        //increase the sl no if taken
                        int max;
                        using (var con = new SqlConnection("Data Source=den1.mssql6.gear.host;Persist Security Info=True;User ID=atcaccounts;Password=Do72-8!iq51s"))
                        {
                            var sql = "Select sl From [dbo].[tender_bill] WHERE sl=(SELECT MAX(sl) From [dbo].[tender_bill] where year = '2018-19')";
                            using (var cmd = new SqlCommand(sql, con))
                            {
                                cmd.Parameters.AddWithValue("sl", Int32.Parse(label6.Text));
                                con.Open();
                                max = (int)cmd.ExecuteScalar();
                                con.Close();
                            }
                        }
                        label6.Text = (max + 1).ToString();
                    }
                    //

                    //Storing PDF byte form

                    Warning[] warnings;
                    string[] streamids;
                    string mimeType;
                    string encoding;
                    string filenameExtension;

                    byte[] bytes = reportViewer1.LocalReport.Render(
                        "PDF", null, out mimeType, out encoding, out filenameExtension,
                        out streamids, out warnings);

                    byte[] bytes1 = reportViewer2.LocalReport.Render(
                        "PDF", null, out mimeType, out encoding, out filenameExtension,
                        out streamids, out warnings);

                    var sqlQuery = "";
                    //SqlConnection con2 = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=billhistory;Password=Eo04NJ?_TuJ6");
                    //con2.Open();
                    //sqlQuery = @"INSERT INTO [dbo].[Cash_Bill]
                    //([billno]
                    //,[year]
                    //,[pdf])VALUES
                    //('" + "ATC/C-" + label6.Text + "/2018-19" + "','" + "2018-19" + "','" + bytes + "')";
                    //SqlCommand cmd2 = new SqlCommand(sqlQuery, con2);
                    //cmd2.ExecuteNonQuery();
                    //con2.Close();


                    //fetching byte to pdf
                    using (FileStream fs = new FileStream("ATC-B-" + label6.Text + "-2018-19.pdf", FileMode.Create))
                    {
                        fs.Write(bytes, 0, bytes.Length);
                    }

                    using (FileStream fs = new FileStream("ATC-C-" + label6.Text + "-2018-19.pdf", FileMode.Create))
                    {
                        fs.Write(bytes1, 0, bytes1.Length);
                    }

                    //Storing to db

                    using (SqlConnection cn = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=billhistory;Password=Eo04NJ?_TuJ6"))
                    {

                        cn.Open();

                        FileStream fStream = File.OpenRead("ATC-B-" + label6.Text + "-2018-19.pdf");

                        byte[] contents = new byte[fStream.Length];

                        fStream.Read(contents, 0, (int)fStream.Length);

                        fStream.Close();

                        using (SqlCommand cmd = new SqlCommand("insert into Tender_bill " + "(billno,year,pdf) values(@billno,@year,@data)", cn))
                        {
                            cmd.Parameters.Add("@billno", label6.Text);
                            cmd.Parameters.Add("@year", "2018-19");
                            cmd.Parameters.Add("@data", contents);
                            cmd.ExecuteNonQuery();

                            // Response.Write("Pdf File Save in Dab");

                        }

                    }
                    //refreash reportviewer once more
                    reportParameters = new ReportParameterCollection();
                    reportParameters1 = new ReportParameterCollection();
                    reportParameters.Add(new ReportParameter("no", label6.Text));
                    reportParameters.Add(new ReportParameter("date", textBox2.Text));
                    reportParameters.Add(new ReportParameter("To", textBox3.Text));
                    reportParameters.Add(new ReportParameter("sub", textBox4.Text));
                    reportParameters.Add(new ReportParameter("ref", textBox18.Text));
                    reportParameters.Add(new ReportParameter("packageno", textBox19.Text));
                    reportParameters.Add(new ReportParameter("dear_sir", textBox5.Text));
                    reportParameters.Add(new ReportParameter("amountinword", textBox17.Text));
                    reportParameters.Add(new ReportParameter("your_sincerely", textBox7.Text));

                    reportParameters1.Add(new ReportParameter("no", label6.Text));
                    reportParameters1.Add(new ReportParameter("date", textBox2.Text));
                    reportParameters1.Add(new ReportParameter("To", textBox20.Text));
                    reportParameters1.Add(new ReportParameter("sub", textBox23.Text));
                    reportParameters1.Add(new ReportParameter("ref", textBox18.Text));
                    reportParameters1.Add(new ReportParameter("packageno", textBox19.Text));
                    reportParameters1.Add(new ReportParameter("dear_sir", textBox22.Text));
                    reportParameters1.Add(new ReportParameter("your_sincerely", textBox7.Text));

                    this.reportViewer1.LocalReport.SetParameters(reportParameters);
                    this.reportViewer1.RefreshReport();
                    this.reportViewer2.LocalReport.SetParameters(reportParameters1);
                    this.reportViewer2.RefreshReport();
                    //

                    //inserting to database
                    string year = "2018-19";
                    string org = textBox3.Text.ToString();
                    int sl = Convert.ToInt32(label6.Text);
                    string billchalanrefno = "ATC/B-"+sl+"/2018-19";
                    decimal amount = decimal.Parse(textBox1.Text);
                    decimal rec = decimal.Parse(textBox6.Text);
                    decimal vat = decimal.Parse(textBox14.Text);
                    decimal tax = decimal.Parse(textBox15.Text);
                    decimal due = amount - (rec + vat + tax);
                    string remarks = textBox16.Text.ToString();
                    if (sl > -1)
                    {
                        SqlConnection con1 = new SqlConnection("Data Source=den1.mssql6.gear.host;Persist Security Info=True;User ID=atcaccounts;Password=Do72-8!iq51s");
                        con1.Open();
                        sqlQuery = "";
                        sqlQuery = @"INSERT INTO [dbo].[tender_bill]
                    ([sl]
                    ,[company]
                    ,[bill_date]
                    ,[bill_challan_ref]
                    ,[benifeciary]
                    ,[total]
                    ,[received]
                    ,[vat]
                    ,[tax]
                    ,[due]
                    ,[remarks]
                    ,[year])VALUES
                     ('" + sl + "','" + org + "','" + DateTime.Now + "','" + billchalanrefno + "','" + textBox21.Text.ToString() + "','" + amount + "','" + rec + "','" + vat + "','" + tax + "','" + due + "','" + remarks +'('+Class1.name+')' + "','" + year + "')";
                        SqlCommand cmd1 = new SqlCommand(sqlQuery, con1);
                        cmd1.ExecuteNonQuery();
                        con1.Close();
                        //clear all data from Textboxes
                        label6.Text = "-1";
                        //after storing info to database
                        DialogResult dialogResult1 = MessageBox.Show("Sucessfully Stored all the information to Database, you are now authorize to PRINT the bill and do not forget to close the window after Printing.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dialogResult1 == DialogResult.OK)
                        {
                        }
                    }
                    else
                    {
                        DialogResult dialogResult2 = MessageBox.Show("Bill no. is not updated...!", "Serial is not Synconized", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
               
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
            
      }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        public CultureInfo Locale { get; set; }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Cash Bill"){
                label26.Visible=false;
                textBox18.Visible =false;
                textBox18.Text = "";
                label27.Visible = false;
                textBox19.Visible = false;
                textBox19.Text = "";
            }
            if(comboBox1.Text=="Tender Bill"){
                label26.Visible = true;
                textBox18.Visible = true;
                label27.Visible = true;
                textBox19.Visible = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sqlQuery = "";
            SqlConnection con = new SqlConnection("Data Source=den1.mssql4.gear.host;Persist Security Info=True;User ID=atcbill;Password=Zy8m9J?65!3Y");
            con.Open();
            sqlQuery = @"DELETE FROM [cash_bill] ";
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Application.Exit();
        }
        
    }
}
