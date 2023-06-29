using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laurantine
{
    public partial class Login : Form
    {
        DBconnection connect = new DBconnection();
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            Dashboard home = new Dashboard();
            connect.openconnect();

            // Hash the entered password using the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(textBox_password.Text));
                string hashedPass = Convert.ToBase64String(hash);

                // Retrieve the hashed password from the database
                MySqlCommand command = new MySqlCommand("SELECT `password` FROM `user_list` WHERE `username`=@username", connect.getconnection);
                command.Parameters.Add("@username", MySqlDbType.VarChar).Value = textBox_username.Text;
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    // Compare the hashedpasswords
                    string storedHash = table.Rows[0]["password"].ToString();
                    if (hashedPass == storedHash)
                    {
                        home.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Username or Password");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password");
                }

                connect.closeconnect();
            }
        }

        private void show_password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_password.Checked)
            {
                textBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                textBox_password.UseSystemPasswordChar= true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Close();
        }
    }
}
