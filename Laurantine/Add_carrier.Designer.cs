namespace Laurantine
{
    partial class Add_carrier
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
            this.edit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.Label();
            this.Active = new System.Windows.Forms.RadioButton();
            this.Not_Active = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_added = new System.Windows.Forms.DateTimePicker();
            this.cid = new System.Windows.Forms.TextBox();
            this.adr = new System.Windows.Forms.TextBox();
            this.con = new System.Windows.Forms.TextBox();
            this._name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.carrier_list = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carrier_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 269);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.edit);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.state);
            this.groupBox1.Controls.Add(this.Active);
            this.groupBox1.Controls.Add(this.Not_Active);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.date_added);
            this.groupBox1.Controls.Add(this.cid);
            this.groupBox1.Controls.Add(this.adr);
            this.groupBox1.Controls.Add(this.con);
            this.groupBox1.Controls.Add(this._name);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(52, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 244);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Carreir";
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete.Location = new System.Drawing.Point(581, 191);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 34);
            this.delete.TabIndex = 15;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit.Location = new System.Drawing.Point(480, 192);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(95, 33);
            this.edit.TabIndex = 14;
            this.edit.Text = "Update";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.Location = new System.Drawing.Point(364, 192);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 33);
            this.save.TabIndex = 13;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // state
            // 
            this.state.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(352, 137);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(66, 25);
            this.state.TabIndex = 12;
            this.state.Text = "Status:";
            // 
            // Active
            // 
            this.Active.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Active.AutoSize = true;
            this.Active.Location = new System.Drawing.Point(420, 137);
            this.Active.Name = "Active";
            this.Active.Size = new System.Drawing.Size(81, 29);
            this.Active.TabIndex = 11;
            this.Active.TabStop = true;
            this.Active.Text = "Active";
            this.Active.UseVisualStyleBackColor = true;
            // 
            // Not_Active
            // 
            this.Not_Active.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Not_Active.AutoSize = true;
            this.Not_Active.Location = new System.Drawing.Point(507, 137);
            this.Not_Active.Name = "Not_Active";
            this.Not_Active.Size = new System.Drawing.Size(117, 29);
            this.Not_Active.TabIndex = 10;
            this.Not_Active.TabStop = true;
            this.Not_Active.Text = "Not Active";
            this.Not_Active.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date Added";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contact";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // date_added
            // 
            this.date_added.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_added.Location = new System.Drawing.Point(29, 192);
            this.date_added.Name = "date_added";
            this.date_added.Size = new System.Drawing.Size(305, 33);
            this.date_added.TabIndex = 4;
            // 
            // cid
            // 
            this.cid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cid.Location = new System.Drawing.Point(627, 59);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(54, 33);
            this.cid.TabIndex = 3;
            // 
            // adr
            // 
            this.adr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adr.Location = new System.Drawing.Point(364, 59);
            this.adr.Multiline = true;
            this.adr.Name = "adr";
            this.adr.Size = new System.Drawing.Size(247, 52);
            this.adr.TabIndex = 2;
            // 
            // con
            // 
            this.con.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.con.Location = new System.Drawing.Point(29, 121);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(305, 33);
            this.con.TabIndex = 1;
            // 
            // _name
            // 
            this._name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._name.Location = new System.Drawing.Point(29, 60);
            this._name.Name = "_name";
            this._name.Size = new System.Drawing.Size(305, 33);
            this._name.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.carrier_list);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 269);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 302);
            this.panel2.TabIndex = 1;
            // 
            // carrier_list
            // 
            this.carrier_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carrier_list.BackgroundColor = System.Drawing.Color.White;
            this.carrier_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carrier_list.Location = new System.Drawing.Point(8, 0);
            this.carrier_list.Name = "carrier_list";
            this.carrier_list.Size = new System.Drawing.Size(785, 293);
            this.carrier_list.TabIndex = 0;
            this.carrier_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.carrier_list_CellContentClick);
            // 
            // Add_carrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 571);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Add_carrier";
            this.Text = "Add_carrier";
            this.Load += new System.EventHandler(this.Add_carrier_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carrier_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.TextBox adr;
        private System.Windows.Forms.TextBox con;
        private System.Windows.Forms.TextBox _name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView carrier_list;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_added;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.RadioButton Active;
        private System.Windows.Forms.RadioButton Not_Active;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button save;
    }
}