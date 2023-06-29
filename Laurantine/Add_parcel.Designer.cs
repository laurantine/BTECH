namespace Laurantine
{
    partial class Add_parcel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delivered = new System.Windows.Forms.RadioButton();
            this.pending = new System.Windows.Forms.RadioButton();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.carriers = new System.Windows.Forms.ComboBox();
            this.type = new System.Windows.Forms.ComboBox();
            this.ra = new System.Windows.Forms.TextBox();
            this.rc = new System.Windows.Forms.TextBox();
            this.rn = new System.Windows.Forms.TextBox();
            this.sa = new System.Windows.Forms.TextBox();
            this.sc = new System.Windows.Forms.TextBox();
            this.sn = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.parcel = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.edit);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.delivered);
            this.groupBox1.Controls.Add(this.pending);
            this.groupBox1.Controls.Add(this.dt);
            this.groupBox1.Controls.Add(this.carriers);
            this.groupBox1.Controls.Add(this.type);
            this.groupBox1.Controls.Add(this.ra);
            this.groupBox1.Controls.Add(this.rc);
            this.groupBox1.Controls.Add(this.rn);
            this.groupBox1.Controls.Add(this.sa);
            this.groupBox1.Controls.Add(this.sc);
            this.groupBox1.Controls.Add(this.sn);
            this.groupBox1.Controls.Add(this.code);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(948, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(841, 226);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 27);
            this.delete.TabIndex = 25;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(759, 225);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(75, 28);
            this.edit.TabIndex = 24;
            this.edit.Text = "Update";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(666, 226);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 28);
            this.save.TabIndex = 23;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(662, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 21);
            this.label11.TabIndex = 22;
            this.label11.Text = "Receiver Address";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(662, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 21);
            this.label10.TabIndex = 21;
            this.label10.Text = "Receiver Contact";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 21);
            this.label9.TabIndex = 20;
            this.label9.Text = "Receiver Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(368, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 19;
            this.label8.Text = "Status:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sender Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sender Contact";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sender Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Carrier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Parcel Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tracking Code";
            // 
            // delivered
            // 
            this.delivered.AutoSize = true;
            this.delivered.Location = new System.Drawing.Point(526, 229);
            this.delivered.Name = "delivered";
            this.delivered.Size = new System.Drawing.Size(94, 25);
            this.delivered.TabIndex = 11;
            this.delivered.TabStop = true;
            this.delivered.Text = "Delivered";
            this.delivered.UseVisualStyleBackColor = true;
            // 
            // pending
            // 
            this.pending.AutoSize = true;
            this.pending.Location = new System.Drawing.Point(436, 229);
            this.pending.Name = "pending";
            this.pending.Size = new System.Drawing.Size(84, 25);
            this.pending.TabIndex = 10;
            this.pending.TabStop = true;
            this.pending.Text = "Pending";
            this.pending.UseVisualStyleBackColor = true;
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(64, 244);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(254, 29);
            this.dt.TabIndex = 9;
            // 
            // carriers
            // 
            this.carriers.FormattingEnabled = true;
            this.carriers.Location = new System.Drawing.Point(64, 184);
            this.carriers.Name = "carriers";
            this.carriers.Size = new System.Drawing.Size(254, 29);
            this.carriers.TabIndex = 8;
            // 
            // type
            // 
            this.type.FormattingEnabled = true;
            this.type.Location = new System.Drawing.Point(64, 121);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(254, 29);
            this.type.TabIndex = 7;
            // 
            // ra
            // 
            this.ra.Location = new System.Drawing.Point(662, 184);
            this.ra.Name = "ra";
            this.ra.Size = new System.Drawing.Size(246, 29);
            this.ra.TabIndex = 6;
            // 
            // rc
            // 
            this.rc.Location = new System.Drawing.Point(662, 121);
            this.rc.Name = "rc";
            this.rc.Size = new System.Drawing.Size(246, 29);
            this.rc.TabIndex = 5;
            // 
            // rn
            // 
            this.rn.Location = new System.Drawing.Point(662, 56);
            this.rn.Name = "rn";
            this.rn.Size = new System.Drawing.Size(246, 29);
            this.rn.TabIndex = 4;
            // 
            // sa
            // 
            this.sa.Location = new System.Drawing.Point(364, 184);
            this.sa.Name = "sa";
            this.sa.Size = new System.Drawing.Size(246, 29);
            this.sa.TabIndex = 3;
            // 
            // sc
            // 
            this.sc.Location = new System.Drawing.Point(364, 121);
            this.sc.Name = "sc";
            this.sc.Size = new System.Drawing.Size(246, 29);
            this.sc.TabIndex = 2;
            // 
            // sn
            // 
            this.sn.Location = new System.Drawing.Point(364, 56);
            this.sn.Name = "sn";
            this.sn.Size = new System.Drawing.Size(246, 29);
            this.sn.TabIndex = 1;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(64, 56);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(254, 29);
            this.code.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 290);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 48);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.parcel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 338);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 411);
            this.panel2.TabIndex = 2;
            // 
            // parcel
            // 
            this.parcel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.parcel.BackgroundColor = System.Drawing.Color.White;
            this.parcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.parcel.Location = new System.Drawing.Point(3, 6);
            this.parcel.Name = "parcel";
            this.parcel.Size = new System.Drawing.Size(940, 393);
            this.parcel.TabIndex = 0;
            this.parcel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parcel_CellContentClick);
            // 
            // Add_parcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 749);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_parcel";
            this.Text = "Add_parcel";
            this.Load += new System.EventHandler(this.Add_parcel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.parcel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton delivered;
        private System.Windows.Forms.RadioButton pending;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.ComboBox carriers;
        private System.Windows.Forms.ComboBox type;
        private System.Windows.Forms.TextBox ra;
        private System.Windows.Forms.TextBox rc;
        private System.Windows.Forms.TextBox rn;
        private System.Windows.Forms.TextBox sa;
        private System.Windows.Forms.TextBox sc;
        private System.Windows.Forms.TextBox sn;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView parcel;
        private System.Windows.Forms.Button delete;
    }
}