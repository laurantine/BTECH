namespace Laurantine
{
    partial class sendSMS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.filter = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msgg = new System.Windows.Forms.TextBox();
            this.phh = new System.Windows.Forms.TextBox();
            this.parcel = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcel)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 261);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Controls.Add(this.filter);
            this.groupBox1.Controls.Add(this.send);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.msgg);
            this.groupBox1.Controls.Add(this.phh);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(134, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 216);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send SMS";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(34, 146);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(243, 33);
            this.date.TabIndex = 7;
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(440, 146);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(89, 33);
            this.filter.TabIndex = 6;
            this.filter.Text = "Pending";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(307, 148);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(97, 33);
            this.send.TabIndex = 5;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phone Number";
            // 
            // msgg
            // 
            this.msgg.Location = new System.Drawing.Point(307, 66);
            this.msgg.Multiline = true;
            this.msgg.Name = "msgg";
            this.msgg.Size = new System.Drawing.Size(222, 58);
            this.msgg.TabIndex = 1;
            // 
            // phh
            // 
            this.phh.Location = new System.Drawing.Point(34, 66);
            this.phh.Multiline = true;
            this.phh.Name = "phh";
            this.phh.Size = new System.Drawing.Size(243, 42);
            this.phh.TabIndex = 0;
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
            this.parcel.Size = new System.Drawing.Size(792, 298);
            this.parcel.TabIndex = 0;
            this.parcel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.parcel_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.parcel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 261);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 316);
            this.panel2.TabIndex = 3;
            // 
            // sendSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "sendSMS";
            this.Text = "sendSMS";
            this.Load += new System.EventHandler(this.sendSMS_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.parcel)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox msgg;
        private System.Windows.Forms.TextBox phh;
        private System.Windows.Forms.DataGridView parcel;
        private System.Windows.Forms.Panel panel2;
    }
}