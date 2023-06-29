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
    public partial class Add_parcel : Form
    {
        DBconnection connect = new DBconnection();
        parcelentry pe = new parcelentry();
        public Add_parcel()
        {
            InitializeComponent();
        }
        private void fillParcelType()
        {
            connect.openconnect();
            MySqlCommand command = new MySqlCommand("select name from parcel_type_list", connect.getconnection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            type.ValueMember = "name";
            MySqlDataAdapter rdr = new MySqlDataAdapter(command);
            rdr.Fill(dt);
            type.DataSource = (dt);

            connect.closeconnect();
        }

        private void fillCarrier()
        {
            connect.openconnect();
            MySqlCommand command = new MySqlCommand("SELECT `name` FROM `carrier_list`", connect.getconnection);
            command.ExecuteNonQuery();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            carriers.ValueMember = "name";
            MySqlDataAdapter rdr = new MySqlDataAdapter(command);
            rdr.Fill(dt);
            carriers.DataSource = (dt);

            connect.closeconnect();
        }
        private void Add_parcel_Load(object sender, EventArgs e)
        {
            showTable();
            fillParcelType();
            fillCarrier();
            // Create the BindingSource object
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = parcel.DataSource;

            // Set the DataSource property of the DataGridView to the BindingSource
            parcel.DataSource = bindingSource;
        }

        private void save_Click(object sender, EventArgs e)
        {
            string sname = sn.Text;
            string scontact = sc.Text;
            string saddress = sa.Text;
            string rname = rn.Text;
            string rcontact = rc.Text;
            string raddress = ra.Text;
            string status = pending.Checked ? "Pending" : "Delivered";
            DateTime date = dt.Value;
            string ptype = type.Text;
            string carrier = carriers.Text;

            if (verify())
            {
                try
                {

                    if (pe.addparcel(sname, scontact, saddress, rname, rcontact, raddress, status, date, ptype, carrier))
                    {
                        showTable();
                        MessageBox.Show("New parcel Added", "Add parcel ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        sn.Clear();
                        sc.Clear();
                        sa.Clear();
                        rn.Clear();
                        rc.Clear();
                        ra.Clear();
                        pending.Checked = true;



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add parcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Empty Field", "Add parcel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verify()
        {
            if ((sn.Text=="") || (sc.Text=="") || (sa.Text=="") || (rn.Text=="") || (rc.Text=="") || (ra.Text==""))

            {
                return false;
            }
            else
                return true;
        }

        public void showTable()
        {
            parcel.DataSource = pe.getparcellist(new MySqlCommand("SELECT * FROM `parcel_list`"));

        }

        private void edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(code.Text);
            string sname = sn.Text;
            string scontact = sc.Text;
            string saddress = sa.Text;
            string rname = rn.Text;
            string rcontact = rc.Text;
            string raddress = ra.Text;
            string status = pending.Checked ? "Pending" : "Delivered";
            DateTime date = dt.Value;
            string ptype = type.Text;
            string carrier = carriers.Text;



            if (pe.updateparcelinfo(id, sname, scontact, saddress, rname, rcontact, raddress, status, date, ptype, carrier))
            {

                MessageBox.Show("parcel type Update Complete", "Update parcel type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                code.Clear();
                sn.Clear();
                sc.Clear();
                sa.Clear();
                rn.Clear();
                rc.Clear();
                ra.Clear();
                pending.Checked = true;

            }
            else
            {
                MessageBox.Show("parcel type not updated", "Update parcel type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(code.Text);
            if (MessageBox.Show("Are you sure you want to delete this parcel", "delete parcel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pe.deleteparcel(id))
                {
                    showTable();
                    MessageBox.Show("parcel deleted", "delete parcel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void parcel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (parcel.Rows.Count > 0 && parcel.CurrentRow != null)
            {
                code.Text = parcel.CurrentRow.Cells[0].Value.ToString();
                sn.Text = parcel.CurrentRow.Cells[1].Value.ToString();
                sc.Text = parcel.CurrentRow.Cells[2].Value.ToString();
                sa.Text = parcel.CurrentRow.Cells[3].Value.ToString();
                rn.Text = parcel.CurrentRow.Cells[4].Value.ToString();
                rc.Text = parcel.CurrentRow.Cells[5].Value.ToString();
                ra.Text = parcel.CurrentRow.Cells[6].Value.ToString();
                pending.Text = parcel.CurrentRow.Cells[7].Value.ToString();
                dt.Value = (DateTime)parcel.CurrentRow.Cells[8].Value;
                type.Text = parcel.CurrentRow.Cells[9].Value.ToString();
                carriers.Text = parcel.CurrentRow.Cells[10].Value.ToString();
            }
        }
    }
}
