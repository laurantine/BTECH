namespace Laurantine
{
    partial class UserForm
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
            this.user_panel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.date_created = new System.Windows.Forms.DateTimePicker();
            this.full_name = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.uid = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.users = new System.Windows.Forms.DataGridView();
            this.user_panel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.users)).BeginInit();
            this.SuspendLayout();
            // 
            // user_panel
            // 
            this.user_panel.Controls.Add(this.groupBox1);
            this.user_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_panel.Location = new System.Drawing.Point(0, 0);
            this.user_panel.Name = "user_panel";
            this.user_panel.Size = new System.Drawing.Size(800, 288);
            this.user_panel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.delete);
            this.groupBox1.Controls.Add(this.edit);
            this.groupBox1.Controls.Add(this.save);
            this.groupBox1.Controls.Add(this.date_created);
            this.groupBox1.Controls.Add(this.full_name);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.uid);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.groupBox1.Location = new System.Drawing.Point(68, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Form";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Full Names";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "User Id ";
            // 
            // delete
            // 
            this.delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.delete.Location = new System.Drawing.Point(531, 186);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(88, 34);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // edit
            // 
            this.edit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.edit.Location = new System.Drawing.Point(439, 186);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(86, 33);
            this.edit.TabIndex = 6;
            this.edit.Text = "Update";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // save
            // 
            this.save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save.Location = new System.Drawing.Point(333, 187);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(90, 33);
            this.save.TabIndex = 5;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // date_created
            // 
            this.date_created.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_created.Location = new System.Drawing.Point(333, 124);
            this.date_created.Name = "date_created";
            this.date_created.Size = new System.Drawing.Size(286, 33);
            this.date_created.TabIndex = 4;
            // 
            // full_name
            // 
            this.full_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.full_name.Location = new System.Drawing.Point(333, 55);
            this.full_name.Name = "full_name";
            this.full_name.Size = new System.Drawing.Size(286, 33);
            this.full_name.TabIndex = 3;
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.Location = new System.Drawing.Point(40, 192);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(236, 33);
            this.name.TabIndex = 2;
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Location = new System.Drawing.Point(40, 124);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(236, 33);
            this.password.TabIndex = 1;
            // 
            // uid
            // 
            this.uid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uid.Location = new System.Drawing.Point(40, 57);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(236, 33);
            this.uid.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Indigo;
            this.panel2.Controls.Add(this.users);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 280);
            this.panel2.TabIndex = 1;
            // 
            // users
            // 
            this.users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.users.BackgroundColor = System.Drawing.Color.White;
            this.users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.users.Location = new System.Drawing.Point(7, 3);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(785, 265);
            this.users.TabIndex = 0;
            this.users.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.user_panel);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.user_panel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.users)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel user_panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DateTimePicker date_created;
        private System.Windows.Forms.TextBox full_name;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView users;
    }
}