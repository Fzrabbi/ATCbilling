namespace ATCbilling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.cash_billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new ATCbilling.DataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Refreash = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.cash_billTableAdapter = new ATCbilling.DataSet1TableAdapters.cash_billTableAdapter();
            this.cashbillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label30 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.cash_billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashbillBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cash_billBindingSource
            // 
            this.cash_billBindingSource.DataMember = "cash_bill";
            this.cash_billBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.AutoScroll = true;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.cash_billBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ATCbilling.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(466, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(387, 562);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expected Bill No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(12, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(92, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "To for bill";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.Location = new System.Drawing.Point(12, 107);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 66);
            this.textBox3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(13, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sub for bill";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox4.Location = new System.Drawing.Point(13, 192);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(13, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dear sir bill";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox5.Location = new System.Drawing.Point(13, 327);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(217, 50);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "We hereby furnish our bill below with request to kindly arrange the payment soon." +
    "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(13, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Finishing";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox7.Location = new System.Drawing.Point(13, 438);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(442, 80);
            this.textBox7.TabIndex = 13;
            this.textBox7.Text = "Assuring you of our best services at all time and thanking you.\r\nYour sincerely,";
            // 
            // Refreash
            // 
            this.Refreash.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Refreash.Location = new System.Drawing.Point(139, 3);
            this.Refreash.Name = "Refreash";
            this.Refreash.Size = new System.Drawing.Size(66, 32);
            this.Refreash.TabIndex = 15;
            this.Refreash.Text = "Refreash";
            this.Refreash.UseVisualStyleBackColor = false;
            this.Refreash.Click += new System.EventHandler(this.Refreash_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(201, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 16;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(67, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Insertion in Table";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox8.Location = new System.Drawing.Point(115, 552);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(35, 20);
            this.textBox8.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(10, 555);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "SL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(10, 596);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Name Of Equipment";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox9.Location = new System.Drawing.Point(114, 577);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(219, 53);
            this.textBox9.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(10, 635);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Qty.";
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox10.Location = new System.Drawing.Point(114, 632);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(48, 20);
            this.textBox10.TabIndex = 22;
            this.textBox10.TextChanged += new System.EventHandler(this.textBox10_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(10, 658);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Unit Price";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox11.Location = new System.Drawing.Point(114, 655);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(81, 20);
            this.textBox11.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(11, 681);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Total Price";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox12.Location = new System.Drawing.Point(115, 678);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(80, 20);
            this.textBox12.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(322, 527);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(133, 16);
            this.label14.TabIndex = 28;
            this.label14.Text = "Delete from Table";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(321, 555);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "SL";
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox13.Location = new System.Drawing.Point(347, 552);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(35, 20);
            this.textBox13.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.Location = new System.Drawing.Point(404, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gold;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(552, 612);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 63);
            this.button3.TabIndex = 32;
            this.button3.Text = "Done/Save";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(11, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "0";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(777, 589);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(193, 16);
            this.label16.TabIndex = 34;
            this.label16.Text = "Content To Save Data only";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(841, 608);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(92, 20);
            this.textBox1.TabIndex = 35;
            this.textBox1.Text = "0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(777, 611);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Total Price";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(777, 637);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Recieved";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox6.Location = new System.Drawing.Point(841, 634);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(92, 20);
            this.textBox6.TabIndex = 37;
            this.textBox6.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label19.Location = new System.Drawing.Point(777, 663);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(22, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "vat";
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox14.Location = new System.Drawing.Point(841, 660);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(92, 20);
            this.textBox14.TabIndex = 39;
            this.textBox14.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(777, 685);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 13);
            this.label20.TabIndex = 42;
            this.label20.Text = "Tax";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox15.Location = new System.Drawing.Point(841, 685);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(92, 20);
            this.textBox15.TabIndex = 41;
            this.textBox15.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label21.Location = new System.Drawing.Point(940, 611);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 13);
            this.label21.TabIndex = 44;
            this.label21.Text = "Remarks";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox16.Location = new System.Drawing.Point(995, 606);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(163, 46);
            this.textBox16.TabIndex = 43;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label22.Location = new System.Drawing.Point(13, 382);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 13);
            this.label22.TabIndex = 46;
            this.label22.Text = "Amount in word";
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox17.Location = new System.Drawing.Point(13, 398);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(443, 20);
            this.textBox17.TabIndex = 45;
            this.textBox17.Text = "In words:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Lime;
            this.label23.Location = new System.Drawing.Point(280, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 16);
            this.label23.TabIndex = 47;
            this.label23.Text = "INSTRUCTIONS";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Lime;
            this.label24.Location = new System.Drawing.Point(204, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(259, 65);
            this.label24.TabIndex = 48;
            this.label24.Text = resources.GetString("label24.Text");
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.DarkRed;
            this.label25.Location = new System.Drawing.Point(534, 685);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(201, 13);
            this.label25.TabIndex = 49;
            this.label25.Text = "(Do not press Unless its ready for PRINT)";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.MidnightBlue;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(1132, 658);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 47);
            this.button4.TabIndex = 50;
            this.button4.Text = "All Bills";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash Bill",
            "Tender Bill"});
            this.comboBox1.Location = new System.Drawing.Point(12, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 51;
            this.comboBox1.Text = "Select Bill Type";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label26.Location = new System.Drawing.Point(14, 215);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(24, 13);
            this.label26.TabIndex = 53;
            this.label26.Text = "Ref";
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox18.Location = new System.Drawing.Point(14, 231);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(395, 20);
            this.textBox18.TabIndex = 52;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label27.Location = new System.Drawing.Point(13, 255);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(119, 13);
            this.label27.TabIndex = 55;
            this.label27.Text = "Package no. and Detail";
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox19.Location = new System.Drawing.Point(13, 271);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(395, 37);
            this.textBox19.TabIndex = 54;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer2.AutoScroll = true;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.cash_billBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ATCbilling.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(855, 21);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(383, 562);
            this.reportViewer2.TabIndex = 56;
            this.reportViewer2.Load += new System.EventHandler(this.reportViewer2_Load);
            // 
            // label28
            // 
            this.label28.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label28.Location = new System.Drawing.Point(644, 5);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(20, 13);
            this.label28.TabIndex = 57;
            this.label28.Text = "Bill";
            // 
            // label29
            // 
            this.label29.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label29.Location = new System.Drawing.Point(1036, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 13);
            this.label29.TabIndex = 58;
            this.label29.Text = "Challan";
            // 
            // cash_billTableAdapter
            // 
            this.cash_billTableAdapter.ClearBeforeFill = true;
            // 
            // cashbillBindingSource
            // 
            this.cashbillBindingSource.DataMember = "cash_bill";
            this.cashbillBindingSource.DataSource = this.DataSet1;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label30.Location = new System.Drawing.Point(244, 90);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 13);
            this.label30.TabIndex = 60;
            this.label30.Text = "To for challan";
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox20.Location = new System.Drawing.Point(236, 107);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(219, 66);
            this.textBox20.TabIndex = 59;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label31.Location = new System.Drawing.Point(937, 660);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(59, 13);
            this.label31.TabIndex = 62;
            this.label31.Text = "Beneficiary";
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox21.Location = new System.Drawing.Point(995, 655);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(131, 39);
            this.textBox21.TabIndex = 61;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label32.Location = new System.Drawing.Point(242, 311);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(80, 13);
            this.label32.TabIndex = 63;
            this.label32.Text = "Dear sir challan";
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox22.Location = new System.Drawing.Point(243, 327);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(212, 50);
            this.textBox22.TabIndex = 64;
            this.textBox22.Text = "As per your verbal request, kindly receive the following goods.";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label33.Location = new System.Drawing.Point(237, 176);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(78, 13);
            this.label33.TabIndex = 66;
            this.label33.Text = "Sub for challan";
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox23.Location = new System.Drawing.Point(237, 192);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(217, 20);
            this.textBox23.TabIndex = 65;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1243, 710);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.textBox23);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Refreash);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ATC Billing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cash_billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashbillBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button Refreash;
        private System.Windows.Forms.BindingSource cash_billBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.cash_billTableAdapter cash_billTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox textBox19;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.BindingSource cashbillBindingSource;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox23;
    }
}