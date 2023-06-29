namespace Laurantine
{
    partial class Add_parcel_type
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
            this.delete = new System.Windows.Forms.Button();
            this.Not_Active = new System.Windows.Forms.RadioButton();
            this.Active = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.des = new System.Windows.Forms.TextBox();
            this.names = new System.Windows.Forms.TextBox();
            this.Uid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Parcel_type = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Parcel_type)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 244);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.Not_Active);
            this.groupBox1.Controls.Add(this.Active);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.edit);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.des);
            this.groupBox1.Controls.Add(this.names);
            this.groupBox1.Controls.Add(this.Uid);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(139, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parcel Type List";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(509, 177);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(97, 31);
            this.delete.TabIndex = 11;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // Not_Active
            // 
            this.Not_Active.AutoSize = true;
            this.Not_Active.Location = new System.Drawing.Point(188, 178);
            this.Not_Active.Name = "Not_Active";
            this.Not_Active.Size = new System.Drawing.Size(120, 29);
            this.Not_Active.TabIndex = 10;
            this.Not_Active.TabStop = true;
            this.Not_Active.Text = "Not_Active";
            this.Not_Active.UseVisualStyleBackColor = true;
            // 
            // Active
            // 
            this.Active.AutoSize = true;
            this.Active.Location = new System.Drawing.Point(101, 178);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(81, 29);
            this.Active.TabIndex = 9;
            this.Active.TabStop = true;
            this.Active.Text = "Active";
            this.Active.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // edit
            // 
            this.edit.Location = new System.Drawing.Point(415, 178);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(88, 31);
            this.edit.TabIndex = 4;
            this.edit.Text = "Update";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(325, 178);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(84, 31);
            this.save.TabIndex = 3;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // des
            // 
            this.des.Location = new System.Drawing.Point(303, 70);
            this.des.Multiline = true;
            this.des.Name = "des";
            this.des.Size = new System.Drawing.Size(232, 59);
            this.des.TabIndex = 2;
            // 
            // names
            // 
            this.names.Location = new System.Drawing.Point(31, 133);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(234, 33);
            this.names.TabIndex = 1;
            // 
            // Uid
            // 
            this.Uid.Location = new System.Drawing.Point(31, 65);
            this.Uid.Name = "Uid";
            this.Uid.Size = new System.Drawing.Size(65, 33);
            this.Uid.TabIndex = 0;
            this.Uid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.Parcel_type);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 244);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 328);
            this.panel2.TabIndex = 1;
            // 
            // Parcel_type
            // 
            this.Parcel_type.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Parcel_type.BackgroundColor = System.Drawing.Color.White;
            this.Parcel_type.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Parcel_type.Location = new System.Drawing.Point(3, 1);
            this.Parcel_type.Name = "Parcel_type";
            this.Parcel_type.Size = new System.Drawing.Size(794, 319);
            this.Parcel_type.TabIndex = 0;
            this.Parcel_type.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Parcel_type_CellContentClick);
            // 
            // Add_parcel_type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Add_parcel_type";
            this.Text = "Add_parcel_type";
            this.Load += new System.EventHandler(this.Add_parcel_type_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Parcel_type)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Parcel_type;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox des;
        private System.Windows.Forms.TextBox names;
        private System.Windows.Forms.TextBox Uid;
        private System.Windows.Forms.RadioButton Not_Active;
        private System.Windows.Forms.RadioButton Active;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
    }
}