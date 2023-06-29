using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laurantine
{
    internal class carrierClass
    {
        DBconnection connect = new DBconnection();

        public bool Addcarrier(string name, string contact, string address, string status, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `carrier_list`(`name`, `contact`, `address`, `status`, `date_added`) VALUES (@n,@con,@addr,@st,@d)", connect.getconnection);
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
            command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@d", MySqlDbType.Date).Value = date;



            connect.openconnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeconnect();
                return true;
            }
            else
            {
                connect.closeconnect();
                return false;
            }
        }

        public bool updatecarrierinfo(int id, string name, string contact, string address, string status, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `carrier_list` SET `name`=@n,`contact`=@con,`address`=@addr,`status`=@st,`date_added`=@d WHERE `carrier_id`=@id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@con", MySqlDbType.VarChar).Value = contact;
            command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@d", MySqlDbType.Timestamp).Value = date;


            connect.openconnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeconnect();
                return true;
            }
            else
            {
                connect.closeconnect();
                return false;
            }
        }

        public bool deletecarrier(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `carrier_list` WHERE `carrier_id`=@id", connect.getconnection);

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            connect.openconnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeconnect();
                return true;
            }
            else
            {
                connect.closeconnect();
                return false;
            }

        }

        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
            connect.openconnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeconnect();
            return count;
        }
        //to get the total student
        public string totalparcel()
        {
            return exeCount("SELECT COUNT(*) FROM `carrier_list`");
        }
    }
}
