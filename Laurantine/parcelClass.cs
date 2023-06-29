using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laurantine
{
    internal class parcelClass
    {
        DBconnection connect = new DBconnection();

        public bool insertparcelType(string name, string description, string status)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `parcel_type_list`(`name`, `description`, `status`) VALUES (@n,@des,@st)", connect.getconnection);
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@des", MySqlDbType.VarChar).Value = description;

            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = status;




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
        public DataTable getparcelType(MySqlCommand command)
        {
            command.Connection=connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool deleteparcelType(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `parcel_type_list` WHERE `parcel_type_id`=@id", connect.getconnection);

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

        public bool updateparcelType(int id, string name, string description, string status)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `parcel_type_list` SET `name`=@n,`description`=@des,`status`=@st WHERE `parcel_type_id`=@id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@n", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@des", MySqlDbType.VarChar).Value = description;

            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = status;




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
            return exeCount("SELECT COUNT(*) FROM `parcel_type_list`");
        }
    }
}
