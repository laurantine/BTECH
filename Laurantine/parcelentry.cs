using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laurantine
{
    internal class parcelentry
    {
        DBconnection connect = new DBconnection();

        public bool addparcel(string sname, string scontact, string saddress, string rname, string rcontact, string raddress, string status, DateTime date, string ptype, string carrier)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `parcel_list`(`Sname`, `Scontact`,`Saddress`, `Rname`, `Rcontact`, `Raddress`, `status`, `date`, `p_type`, `carrier`)" +
                " VALUES (@sn,@sc,@sadr,@rn,@rc,@radr,@rem,@st,@d,@pt,@cr)", connect.getconnection);
            command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = sname;
            command.Parameters.Add("@sc", MySqlDbType.VarChar).Value = scontact;
            command.Parameters.Add("@sadr", MySqlDbType.VarChar).Value =saddress;
            command.Parameters.Add("@rn", MySqlDbType.VarChar).Value =rname;
            command.Parameters.Add("@rc", MySqlDbType.VarChar).Value =rcontact;
            command.Parameters.Add("@radr", MySqlDbType.VarChar).Value =raddress;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@d", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = ptype;
            command.Parameters.Add("@cr", MySqlDbType.VarChar).Value = carrier;


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

        public bool updateparcelinfo(int id, string sname, string scontact, string saddress, string rname, string rcontact, string raddress, string status, DateTime date, string ptype, string carrier)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `parcel_list` SET `Sname`=@sn, `Scontact`=@sc, `Saddress`=@sadr, `Rname`=@rn, `Rcontact`=@rc, `Raddress`=@radr, `status`=@st, `date`=@d, `p_type`=@pt, `carrier`=@cr WHERE `code`=@id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = sname;
            command.Parameters.Add("@sc", MySqlDbType.VarChar).Value = scontact;
            command.Parameters.Add("@sadr", MySqlDbType.VarChar).Value =saddress;
            command.Parameters.Add("@rn", MySqlDbType.VarChar).Value =rname;
            command.Parameters.Add("@rc", MySqlDbType.VarChar).Value =rcontact;
            command.Parameters.Add("@radr", MySqlDbType.VarChar).Value =raddress;
            command.Parameters.Add("@st", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@d", MySqlDbType.Date).Value = date;
            command.Parameters.Add("@pt", MySqlDbType.VarChar).Value = ptype;
            command.Parameters.Add("@cr", MySqlDbType.VarChar).Value = carrier;


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
        public bool deleteparcel(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `parcel_list` WHERE `code`=@id", connect.getconnection);

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

        public DataTable getparcellist(MySqlCommand command)
        {
            command.Connection=connect.getconnection;
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
            return exeCount("SELECT COUNT(*) FROM `parcel_list`");
        }
    }
}
