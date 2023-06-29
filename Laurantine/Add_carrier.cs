using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laurantine
{
    public partial class Add_carrier : Form
    {
        carrierClass cc = new carrierClass();
        DBconnection connect = new DBconnection();
        public Add_carrier()
        {
            InitializeComponent();
        }
        private void Add_carrier_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string name = _name.Text;
            string contact = con.Text;
            string address = adr.Text;
            string status = Active.Checked ? "Active" : "Not_Active";
            DateTime date = date_added.Value;


            if (verify())
            {
                try
                {

                    if (cc.Addcarrier(name, contact, address, status, date))
                    {
                        showTable();
                        MessageBox.Show("New carrier Added", "Add carrier", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _name.Clear();
                        con.Clear();
                        adr.Clear();
                        Active.Checked = true;
                        date_added.Value =DateTime.Now;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add carrier", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cid.Text);
            string name = _name.Text;
            string contact = con.Text;
            string address = adr.Text;
            string status = Active.Checked ? "Active" : "Not_Active";
            DateTime date = date_added.Value;

            if (cc.updatecarrierinfo(id, name, contact, address, status, date))
            {
                showTable();

                MessageBox.Show("carrier Update Complete", "Update carrier infos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cid.Clear();
                _name.Clear();
                con.Clear();
                adr.Clear();
                Active.Checked = true;
                date_added.Value =DateTime.Now;
            }
            else
            {
                MessageBox.Show("carrier not updated", "Update carrier infos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cid.Text);
            if (MessageBox.Show("Are you sure you want to delete this user", "Delete carrier", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cc.deletecarrier(id))
                {
                    showTable();
                    MessageBox.Show("carrier deleted", "deleted carrier", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
        bool verify()
        {
            if ((_name.Text=="") || (con.Text=="") || (adr.Text==""))

            {
                return false;
            }
            else
                return true;
        }
        public void showTable()
        {
            carrier_list.DataSource = cc.getList(new MySqlCommand("SELECT * FROM `carrier_list`"));

        }

        private void carrier_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cid.Text = carrier_list.CurrentRow.Cells[0].Value.ToString();
            _name.Text = carrier_list.CurrentRow.Cells[1].Value.ToString();
            con.Text = carrier_list.CurrentRow.Cells[2].Value.ToString();
            adr.Text = carrier_list.CurrentRow.Cells[3].Value.ToString();
            date_added.Value = (DateTime)carrier_list.CurrentRow.Cells[5].Value;
        }
    }
}
