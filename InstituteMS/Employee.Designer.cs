﻿namespace InstituteMS
{
    partial class Employee
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.empLastIdlbl = new System.Windows.Forms.Label();
            this.empIdtxt = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.empModbtn = new System.Windows.Forms.Button();
            this.empSavebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empContacttxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.empAdd3txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.empAdd2txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.empAdd1txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.empNICtxt = new System.Windows.Forms.TextBox();
            this.empFNametxt = new System.Windows.Forms.TextBox();
            this.empLNametxt = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.payEmpIdtxt = new System.Windows.Forms.ComboBox();
            this.button7 = new System.Windows.Forms.Button();
            this.payEmpAmounttxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.payEmpYeartxt = new System.Windows.Forms.TextBox();
            this.payEmpMonthcmb = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.empAlldatagrid = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empAlldatagrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.tabControl1.Location = new System.Drawing.Point(12, 97);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 469);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.empLastIdlbl);
            this.tabPage1.Controls.Add(this.empIdtxt);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.empModbtn);
            this.tabPage1.Controls.Add(this.empSavebtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.empContacttxt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.empAdd3txt);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.empAdd2txt);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.empAdd1txt);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.empNICtxt);
            this.tabPage1.Controls.Add(this.empFNametxt);
            this.tabPage1.Controls.Add(this.empLNametxt);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Register";
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // empLastIdlbl
            // 
            this.empLastIdlbl.AutoSize = true;
            this.empLastIdlbl.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.empLastIdlbl.ForeColor = System.Drawing.Color.White;
            this.empLastIdlbl.Location = new System.Drawing.Point(336, 36);
            this.empLastIdlbl.Name = "empLastIdlbl";
            this.empLastIdlbl.Size = new System.Drawing.Size(31, 23);
            this.empLastIdlbl.TabIndex = 40;
            this.empLastIdlbl.Text = "ID";
            // 
            // empIdtxt
            // 
            this.empIdtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empIdtxt.Location = new System.Drawing.Point(230, 33);
            this.empIdtxt.Name = "empIdtxt";
            this.empIdtxt.Size = new System.Drawing.Size(100, 26);
            this.empIdtxt.TabIndex = 28;
            this.empIdtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empIdtxt_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(85)))), ((int)(((byte)(236)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(619, 355);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 40);
            this.button3.TabIndex = 38;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(85)))), ((int)(((byte)(236)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(410, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 33);
            this.button4.TabIndex = 39;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // empModbtn
            // 
            this.empModbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(85)))), ((int)(((byte)(236)))));
            this.empModbtn.FlatAppearance.BorderSize = 0;
            this.empModbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empModbtn.ForeColor = System.Drawing.Color.White;
            this.empModbtn.Location = new System.Drawing.Point(491, 355);
            this.empModbtn.Name = "empModbtn";
            this.empModbtn.Size = new System.Drawing.Size(111, 40);
            this.empModbtn.TabIndex = 37;
            this.empModbtn.Text = "Modify";
            this.empModbtn.UseVisualStyleBackColor = false;
            this.empModbtn.Click += new System.EventHandler(this.empModbtn_Click);
            // 
            // empSavebtn
            // 
            this.empSavebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(85)))), ((int)(((byte)(236)))));
            this.empSavebtn.FlatAppearance.BorderSize = 0;
            this.empSavebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empSavebtn.ForeColor = System.Drawing.Color.White;
            this.empSavebtn.Location = new System.Drawing.Point(364, 355);
            this.empSavebtn.Name = "empSavebtn";
            this.empSavebtn.Size = new System.Drawing.Size(111, 40);
            this.empSavebtn.TabIndex = 36;
            this.empSavebtn.Text = "Save";
            this.empSavebtn.UseVisualStyleBackColor = false;
            this.empSavebtn.Click += new System.EventHandler(this.empSavebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(81, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(81, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(81, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Address Line1";
            // 
            // empContacttxt
            // 
            this.empContacttxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empContacttxt.Location = new System.Drawing.Point(230, 294);
            this.empContacttxt.MaxLength = 10;
            this.empContacttxt.Name = "empContacttxt";
            this.empContacttxt.Size = new System.Drawing.Size(159, 26);
            this.empContacttxt.TabIndex = 35;
            this.empContacttxt.TextChanged += new System.EventHandler(this.empContacttxt_TextChanged);
            this.empContacttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.empContacttxt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(81, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 23);
            this.label5.TabIndex = 24;
            this.label5.Text = "Contact";
            // 
            // empAdd3txt
            // 
            this.empAdd3txt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empAdd3txt.Location = new System.Drawing.Point(230, 256);
            this.empAdd3txt.Name = "empAdd3txt";
            this.empAdd3txt.Size = new System.Drawing.Size(159, 26);
            this.empAdd3txt.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(81, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 23);
            this.label6.TabIndex = 25;
            this.label6.Text = "Address Line2";
            // 
            // empAdd2txt
            // 
            this.empAdd2txt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empAdd2txt.Location = new System.Drawing.Point(230, 219);
            this.empAdd2txt.Name = "empAdd2txt";
            this.empAdd2txt.Size = new System.Drawing.Size(159, 26);
            this.empAdd2txt.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(81, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "Address Line3";
            // 
            // empAdd1txt
            // 
            this.empAdd1txt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empAdd1txt.Location = new System.Drawing.Point(230, 182);
            this.empAdd1txt.Name = "empAdd1txt";
            this.empAdd1txt.Size = new System.Drawing.Size(159, 26);
            this.empAdd1txt.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(81, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "NIC";
            // 
            // empNICtxt
            // 
            this.empNICtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empNICtxt.Location = new System.Drawing.Point(230, 145);
            this.empNICtxt.MaxLength = 10;
            this.empNICtxt.Name = "empNICtxt";
            this.empNICtxt.Size = new System.Drawing.Size(159, 26);
            this.empNICtxt.TabIndex = 31;
            // 
            // empFNametxt
            // 
            this.empFNametxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empFNametxt.Location = new System.Drawing.Point(230, 71);
            this.empFNametxt.Name = "empFNametxt";
            this.empFNametxt.Size = new System.Drawing.Size(159, 26);
            this.empFNametxt.TabIndex = 29;
            // 
            // empLNametxt
            // 
            this.empLNametxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.empLNametxt.Location = new System.Drawing.Point(230, 108);
            this.empLNametxt.Name = "empLNametxt";
            this.empLNametxt.Size = new System.Drawing.Size(159, 26);
            this.empLNametxt.TabIndex = 30;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.payEmpIdtxt);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.payEmpAmounttxt);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.payEmpYeartxt);
            this.tabPage2.Controls.Add(this.payEmpMonthcmb);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Payments";
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // payEmpIdtxt
            // 
            this.payEmpIdtxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.payEmpIdtxt.FormattingEnabled = true;
            this.payEmpIdtxt.Location = new System.Drawing.Point(343, 118);
            this.payEmpIdtxt.Name = "payEmpIdtxt";
            this.payEmpIdtxt.Size = new System.Drawing.Size(80, 26);
            this.payEmpIdtxt.TabIndex = 26;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(85)))), ((int)(((byte)(236)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(458, 302);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(111, 40);
            this.button7.TabIndex = 19;
            this.button7.Text = "Save";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // payEmpAmounttxt
            // 
            this.payEmpAmounttxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.payEmpAmounttxt.Location = new System.Drawing.Point(343, 249);
            this.payEmpAmounttxt.MaxLength = 4;
            this.payEmpAmounttxt.Name = "payEmpAmounttxt";
            this.payEmpAmounttxt.Size = new System.Drawing.Size(153, 26);
            this.payEmpAmounttxt.TabIndex = 18;
            this.payEmpAmounttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.payEmpAmounttxt_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(201, 246);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 23);
            this.label10.TabIndex = 17;
            this.label10.Text = "Amount";
            // 
            // payEmpYeartxt
            // 
            this.payEmpYeartxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.payEmpYeartxt.Location = new System.Drawing.Point(343, 203);
            this.payEmpYeartxt.Name = "payEmpYeartxt";
            this.payEmpYeartxt.Size = new System.Drawing.Size(192, 26);
            this.payEmpYeartxt.TabIndex = 16;
            this.payEmpYeartxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.payEmpYeartxt_KeyPress);
            // 
            // payEmpMonthcmb
            // 
            this.payEmpMonthcmb.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.payEmpMonthcmb.FormattingEnabled = true;
            this.payEmpMonthcmb.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.payEmpMonthcmb.Location = new System.Drawing.Point(343, 161);
            this.payEmpMonthcmb.Name = "payEmpMonthcmb";
            this.payEmpMonthcmb.Size = new System.Drawing.Size(192, 26);
            this.payEmpMonthcmb.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(201, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 23);
            this.label11.TabIndex = 13;
            this.label11.Text = "Year";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(201, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "Month";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(201, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 23);
            this.label13.TabIndex = 11;
            this.label13.Text = "Employee ID";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.empAlldatagrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(781, 433);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Reports";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // empAlldatagrid
            // 
            this.empAlldatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empAlldatagrid.Location = new System.Drawing.Point(13, 39);
            this.empAlldatagrid.Name = "empAlldatagrid";
            this.empAlldatagrid.Size = new System.Drawing.Size(758, 320);
            this.empAlldatagrid.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Moire", 30F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 48);
            this.label9.TabIndex = 22;
            this.label9.Text = "Employee";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(85)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 70);
            this.panel1.TabIndex = 23;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(788, 11);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(48, 41);
            this.button10.TabIndex = 29;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(734, 11);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 41);
            this.button9.TabIndex = 28;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(680, 11);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(48, 41);
            this.button8.TabIndex = 27;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(622, 11);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(48, 41);
            this.button11.TabIndex = 26;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(845, 576);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Employee";
            this.Text = "empRegister";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.empAlldatagrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox empIdtxt;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button empModbtn;
        private System.Windows.Forms.Button empSavebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox empContacttxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox empAdd3txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empAdd2txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox empAdd1txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox empNICtxt;
        private System.Windows.Forms.TextBox empFNametxt;
        private System.Windows.Forms.TextBox empLNametxt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox payEmpAmounttxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox payEmpYeartxt;
        private System.Windows.Forms.ComboBox payEmpMonthcmb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.DataGridView empAlldatagrid;
        private System.Windows.Forms.Label empLastIdlbl;
        private System.Windows.Forms.ComboBox payEmpIdtxt;

    }
}