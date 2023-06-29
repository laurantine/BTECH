using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laurantine
{
    public partial class UserForm : Form
    {
        userClass user = new userClass();
        DBconnection connect = new DBconnection();
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string fname = full_name.Text;
            string Uname = name.Text;
            string hashedPass = "";
            DateTime date = date_created.Value;

            if (checkFields())
            {
                try
                {
                    using (SHA256 sha256 = SHA256.Create())
                    {
                        byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password.Text));
                        hashedPass = Convert.ToBase64String(hash);
                    }

                    MySqlCommand command = new MySqlCommand("INSERT INTO `user_list`(`fullname`, `username`, `password`, `status`, `date_created`) VALUES (@fn,@un,@pd,@st,@d)", connect.getconnection);
                    command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
                    command.Parameters.Add("@un", MySqlDbType.VarChar).Value = Uname;
                    command.Parameters.Add("@pd", MySqlDbType.VarChar).Value = hashedPass;
                    command.Parameters.Add("@st", MySqlDbType.VarChar).Value = "Active";
                    command.Parameters.Add("@d", MySqlDbType.Date).Value = date;

                    connect.openconnect();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        connect.closeconnect();
                        showTable();
                        MessageBox.Show("New user added", "Add user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
                    else
                    {
                        connect.closeconnect();
                        MessageBox.Show("User insertion failed", "Add user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool checkFields()
        {
            //return !string.IsNullOrEmpty(full_name.Text) && !string.IsNullOrEmpty(name.Text) && !string.IsNullOrEmpty(password.Text);

            if ((full_name.Text=="") || (name.Text=="") || (password.Text==""))

            {
                return false;
            }
            else
                return true;
        }

        private void clearFields()
        {
            full_name.Clear();
            name.Clear();
            password.Clear();
            date_created.Value = DateTime.Now;
            uid.Clear();
        }
        public void showTable()
        {
            users.DataSource = user.getList(new MySqlCommand("SELECT * FROM `user_list`"));
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(uid.Text);
            string fname = full_name.Text;
            string Uname = name.Text;
            string hashedPass = "";
            DateTime date = date_created.Value;

            if (checkFields())
            {
                try
                {
                    MySqlCommand command;
                    if (string.IsNullOrEmpty(password.Text))
                    {
                        command = new MySqlCommand("UPDATE `user_list` SET `fullname`=@fn,`username`=@un,`date_created`=@d WHERE `user_id`=@id", connect.getconnection);
                    }
                    else
                    {
                        using (SHA256 sha256 = SHA256.Create())
                        {
                            byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password.Text));
                            hashedPass = Convert.ToBase64String(hash);
                        }

                        command = new MySqlCommand("UPDATE `user_list` SET `fullname`=@fn,`username`=@un,`password`=@pd,`date_created`=@d WHERE `user_id`=@id", connect.getconnection);
                        command.Parameters.Add("@pd", MySqlDbType.VarChar).Value = hashedPass;
                    }

                    command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
                    command.Parameters.Add("@un", MySqlDbType.VarChar).Value = Uname;
                    command.Parameters.Add("@d", MySqlDbType.Date).Value = date;
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id; // the id of the user to update

                    connect.openconnect();
                    if (command.ExecuteNonQuery() == 1)
                    {
                        connect.closeconnect();
                        showTable();
                        MessageBox.Show("User updated", "Update user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clearFields();
                    }
                    else
                    {
                        connect.closeconnect();
                        MessageBox.Show("User update failed", "Update user", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields", "Update User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(uid.Text);
            try
            {
                if (user.deleteuser(id))
                {
                    showTable();
                    MessageBox.Show("User deleted", "Delete user", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                }
                else
                {
                    MessageBox.Show("Invalid user ID", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            uid.Text = users.CurrentRow.Cells[0].Value.ToString();
            full_name.Text = users.CurrentRow.Cells[1].Value.ToString();
            name.Text = users.CurrentRow.Cells[2].Value.ToString();

            date_created.Value = (DateTime)users.CurrentRow.Cells[4].Value;
        }
    }
}
