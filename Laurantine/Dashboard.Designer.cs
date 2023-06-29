namespace Laurantine
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_side = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel_subAdmin = new System.Windows.Forms.Panel();
            this.logout = new System.Windows.Forms.Button();
            this.account = new System.Windows.Forms.Button();
            this.admin = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.panel_sublist = new System.Windows.Forms.Panel();
            this.parcel_type = new System.Windows.Forms.Button();
            this.add_carrier = new System.Windows.Forms.Button();
            this.assign_list = new System.Windows.Forms.Button();
            this.parcel_list = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_out = new System.Windows.Forms.Panel();
            this.panel_in = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cl = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pt = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.us = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_side.SuspendLayout();
            this.panel_subAdmin.SuspendLayout();
            this.panel_sublist.SuspendLayout();
            this.panel_out.SuspendLayout();
            this.panel_in.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 41);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_side
            // 
            this.panel_side.BackColor = System.Drawing.Color.Indigo;
            this.panel_side.Controls.Add(this.panel9);
            this.panel_side.Controls.Add(this.panel_subAdmin);
            this.panel_side.Controls.Add(this.admin);
            this.panel_side.Controls.Add(this.send);
            this.panel_side.Controls.Add(this.panel_sublist);
            this.panel_side.Controls.Add(this.assign_list);
            this.panel_side.Controls.Add(this.parcel_list);
            this.panel_side.Controls.Add(this.button1);
            this.panel_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_side.Location = new System.Drawing.Point(0, 41);
            this.panel_side.Name = "panel_side";
            this.panel_side.Size = new System.Drawing.Size(177, 649);
            this.panel_side.TabIndex = 1;
            this.panel_side.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(2, -5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(175, 10);
            this.panel9.TabIndex = 9;
            // 
            // panel_subAdmin
            // 
            this.panel_subAdmin.Controls.Add(this.logout);
            this.panel_subAdmin.Controls.Add(this.account);
            this.panel_subAdmin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_subAdmin.Location = new System.Drawing.Point(9, 463);
            this.panel_subAdmin.Name = "panel_subAdmin";
            this.panel_subAdmin.Size = new System.Drawing.Size(162, 84);
            this.panel_subAdmin.TabIndex = 8;
            // 
            // logout
            // 
            this.logout.FlatAppearance.BorderSize = 0;
            this.logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout.ForeColor = System.Drawing.Color.White;
            this.logout.Location = new System.Drawing.Point(3, 41);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(156, 38);
            this.logout.TabIndex = 1;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // account
            // 
            this.account.FlatAppearance.BorderSize = 0;
            this.account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.account.ForeColor = System.Drawing.Color.White;
            this.account.Location = new System.Drawing.Point(3, 1);
            this.account.Name = "account";
            this.account.Size = new System.Drawing.Size(156, 38);
            this.account.TabIndex = 0;
            this.account.Text = "Account";
            this.account.UseVisualStyleBackColor = true;
            this.account.Click += new System.EventHandler(this.account_Click);
            // 
            // admin
            // 
            this.admin.FlatAppearance.BorderSize = 0;
            this.admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.admin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.ForeColor = System.Drawing.Color.White;
            this.admin.Location = new System.Drawing.Point(9, 423);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(162, 38);
            this.admin.TabIndex = 7;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // send
            // 
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(9, 322);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(162, 38);
            this.send.TabIndex = 6;
            this.send.Text = "SMS";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // panel_sublist
            // 
            this.panel_sublist.Controls.Add(this.parcel_type);
            this.panel_sublist.Controls.Add(this.add_carrier);
            this.panel_sublist.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_sublist.Location = new System.Drawing.Point(9, 230);
            this.panel_sublist.Name = "panel_sublist";
            this.panel_sublist.Size = new System.Drawing.Size(162, 86);
            this.panel_sublist.TabIndex = 5;
            // 
            // parcel_type
            // 
            this.parcel_type.FlatAppearance.BorderSize = 0;
            this.parcel_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parcel_type.ForeColor = System.Drawing.Color.White;
            this.parcel_type.Location = new System.Drawing.Point(3, 3);
            this.parcel_type.Name = "parcel_type";
            this.parcel_type.Size = new System.Drawing.Size(156, 38);
            this.parcel_type.TabIndex = 3;
            this.parcel_type.Text = "Parcel Type";
            this.parcel_type.UseVisualStyleBackColor = true;
            this.parcel_type.Click += new System.EventHandler(this.parcel_type_Click);
            // 
            // add_carrier
            // 
            this.add_carrier.FlatAppearance.BorderSize = 0;
            this.add_carrier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_carrier.ForeColor = System.Drawing.Color.White;
            this.add_carrier.Location = new System.Drawing.Point(3, 43);
            this.add_carrier.Name = "add_carrier";
            this.add_carrier.Size = new System.Drawing.Size(156, 38);
            this.add_carrier.TabIndex = 4;
            this.add_carrier.Text = "Add Carrier";
            this.add_carrier.UseVisualStyleBackColor = true;
            this.add_carrier.Click += new System.EventHandler(this.add_carrier_Click);
            // 
            // assign_list
            // 
            this.assign_list.FlatAppearance.BorderSize = 0;
            this.assign_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assign_list.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assign_list.ForeColor = System.Drawing.Color.White;
            this.assign_list.Location = new System.Drawing.Point(9, 193);
            this.assign_list.Name = "assign_list";
            this.assign_list.Size = new System.Drawing.Size(162, 38);
            this.assign_list.TabIndex = 2;
            this.assign_list.Text = "Assign";
            this.assign_list.UseVisualStyleBackColor = true;
            this.assign_list.Click += new System.EventHandler(this.assign_list_Click);
            // 
            // parcel_list
            // 
            this.parcel_list.FlatAppearance.BorderSize = 0;
            this.parcel_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.parcel_list.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parcel_list.ForeColor = System.Drawing.Color.White;
            this.parcel_list.Location = new System.Drawing.Point(6, 103);
            this.parcel_list.Name = "parcel_list";
            this.parcel_list.Size = new System.Drawing.Size(162, 38);
            this.parcel_list.TabIndex = 1;
            this.parcel_list.Text = "Parcel List";
            this.parcel_list.UseVisualStyleBackColor = true;
            this.parcel_list.Click += new System.EventHandler(this.parcel_list_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dashboard";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel_out
            // 
            this.panel_out.Controls.Add(this.panel_in);
            this.panel_out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_out.Location = new System.Drawing.Point(177, 41);
            this.panel_out.Name = "panel_out";
            this.panel_out.Size = new System.Drawing.Size(970, 649);
            this.panel_out.TabIndex = 2;
            // 
            // panel_in
            // 
            this.panel_in.Controls.Add(this.chart1);
            this.panel_in.Controls.Add(this.tableLayoutPanel1);
            this.panel_in.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_in.Location = new System.Drawing.Point(0, 0);
            this.panel_in.Name = "panel_in";
            this.panel_in.Padding = new System.Windows.Forms.Padding(10);
            this.panel_in.Size = new System.Drawing.Size(970, 649);
            this.panel_in.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(10, 125);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Parcels per Month";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(950, 514);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(950, 115);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Navy;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.cl);
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(10, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 102);
            this.panel5.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label5.Location = new System.Drawing.Point(68, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // cl
            // 
            this.cl.AutoSize = true;
            this.cl.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.cl.ForeColor = System.Drawing.Color.White;
            this.cl.Location = new System.Drawing.Point(74, 16);
            this.cl.Name = "cl";
            this.cl.Size = new System.Drawing.Size(40, 44);
            this.cl.TabIndex = 0;
            this.cl.Text = "0";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.pt);
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(247, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(217, 105);
            this.panel6.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label6.Location = new System.Drawing.Point(71, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "label6";
            // 
            // pt
            // 
            this.pt.AutoSize = true;
            this.pt.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.pt.ForeColor = System.Drawing.Color.White;
            this.pt.Location = new System.Drawing.Point(84, 16);
            this.pt.Name = "pt";
            this.pt.Size = new System.Drawing.Size(40, 44);
            this.pt.TabIndex = 0;
            this.pt.Text = "0";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.c);
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(484, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(217, 105);
            this.panel7.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label7.Location = new System.Drawing.Point(79, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "label7";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.c.ForeColor = System.Drawing.Color.White;
            this.c.Location = new System.Drawing.Point(89, 26);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(40, 44);
            this.c.TabIndex = 0;
            this.c.Text = "0";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.OliveDrab;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.us);
            this.panel8.ForeColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(711, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0, 0, 10, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(229, 105);
            this.panel8.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label8.Location = new System.Drawing.Point(73, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "label8";
            // 
            // us
            // 
            this.us.AutoSize = true;
            this.us.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold);
            this.us.ForeColor = System.Drawing.Color.White;
            this.us.Location = new System.Drawing.Point(81, 26);
            this.us.Name = "us";
            this.us.Size = new System.Drawing.Size(40, 44);
            this.us.TabIndex = 0;
            this.us.Text = "0";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 690);
            this.Controls.Add(this.panel_out);
            this.Controls.Add(this.panel_side);
            this.Controls.Add(this.panel1);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_side.ResumeLayout(false);
            this.panel_subAdmin.ResumeLayout(false);
            this.panel_sublist.ResumeLayout(false);
            this.panel_out.ResumeLayout(false);
            this.panel_in.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_side;
        private System.Windows.Forms.Panel panel_out;
        private System.Windows.Forms.Panel panel_in;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel_sublist;
        private System.Windows.Forms.Button parcel_type;
        private System.Windows.Forms.Button add_carrier;
        private System.Windows.Forms.Button assign_list;
        private System.Windows.Forms.Button parcel_list;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Panel panel_subAdmin;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button account;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label cl;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label pt;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label us;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel9;
    }
}

