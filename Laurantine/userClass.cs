using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laurantine
{
    internal class userClass
    {
        DBconnection connect = new DBconnection();

        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteuser(int id)
        {
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM `user_list` WHERE `user_id`=@id", connect.getconnection);
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
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public string exeCount(string query, MySqlParameter[] parameters)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
            command.Parameters.AddRange(parameters);

            connect.openconnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeconnect();
            return count;
        }

        //to get the total users
        public string totaluser()
        {
            string query = "SELECT COUNT(*) FROM `user_list`";
            MySqlParameter[] parameters = new MySqlParameter[0];
            return exeCount(query, parameters);
        }
    }
}
