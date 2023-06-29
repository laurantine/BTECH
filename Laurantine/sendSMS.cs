using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laurantine
{
    public partial class sendSMS : Form
    {
        DBconnection connect = new DBconnection();
        parcelentry pe = new parcelentry();
        public sendSMS()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void send_Click(object sender, EventArgs e)
        {
            if (phh.Text == "")
            {
                MessageBox.Show("Please enter phone numbers");
                return;
            }
            else if (msgg.Text == "")
            {
                MessageBox.Show("Please enter message");
                return;
            }
            connect.openconnect();
            // Parse the date string into a DateTime object and format it as a string
            string dateString = date.Text;
            DateTime dateValue = DateTime.Parse(dateString);
            string formattedDate = dateValue.ToString("yyyy-MM-dd HH:mm:ss");

            // Insert the SMS into the database for each recipient
            List<string> recipientNumbers = phh.Text.Split(',').ToList();
            foreach (string recipientNumber in recipientNumbers)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO sms (number, message, date) VALUES (@number, @message, @date)", connect.getconnection);
                command.Parameters.AddWithValue("@number", recipientNumber.Trim());
                command.Parameters.AddWithValue("@message", msgg.Text);
                command.Parameters.AddWithValue("@date", formattedDate);
                command.ExecuteNonQuery();
            }

            // Send the SMS to all recipients using the Twilio API
            try
            {
                WebClient cm = new WebClient();
                string usernames, passwords, telephones, messages = "";
                usernames = "AVITECH";
                passwords = "avitech@2021";
                messages = msgg.Text;
                telephones = string.Join(",", recipientNumbers);
                string baseurl = "http://api.foseintsms.com/api_v3.php?username=" + usernames + "&password=" + passwords + "&message=" + messages + "&telephone=" + telephones + "";
                MessageBox.Show("Message sent and saved");
                phh.Text = "";
                msgg.Text = "";
                date.Text = "";
                cm.OpenRead(baseurl);
            }
            catch (WebException ex)
            {
                // Display error message
                MessageBox.Show("Failed to send SMS: " + ex.Message);
            }

            connect.closeconnect();
        }

        private void parcel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (parcel.SelectedRows.Count > 0)
            {
                DataGridViewRow row = parcel.SelectedRows[0];
                string col1Value = row.Cells["Scontact"].Value.ToString();
                string col2Value = row.Cells["Rcontact"].Value.ToString();
                phh.Text += col1Value + "," + col2Value + ",";
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
            connect.openconnect();
            string query = "SELECT * FROM parcel_list where Status ='Pending'";
            MySqlDataAdapter sda = new MySqlDataAdapter(query, connect.getconnection);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);
            parcel.DataSource = dataTable;
            connect.closeconnect();
        }
        public void showTable()
        {
            parcel.DataSource = pe.getparcellist(new MySqlCommand("SELECT `Sname`, `Scontact`, `Saddress`, `Rname`, `Rcontact`, `Raddress`, `status`, `date` FROM `parcel_list`"));

        }
        private void sendSMS_Load(object sender, EventArgs e)
        {
            showTable();
        }
    }
}
