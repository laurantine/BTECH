using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laurantine
{
    public partial class Add_parcel_type : Form
    {
        DBconnection connect = new DBconnection();
        parcelClass pc = new parcelClass();
        public Add_parcel_type()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = names.Text;
            string description = des.Text;
            string status = Active.Checked ? "Active" : "Not_Active";

            if (verify())
            {
                try
                {

                    if (pc.insertparcelType(name, description, status))
                    {
                        showTable();
                        MessageBox.Show("New parcel type Added", "Add parcel type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //button_clear_Click.PerfomClick();
                        names.Clear();
                        des.Clear();
                        Active.Checked = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add parcel type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Empty Field", "Add parcel type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        bool verify()
        {
            if ((names.Text=="") || (des.Text==""))

            {
                return false;
            }
            else
                return true;
        }

        public void showTable()
        {
            Parcel_type.DataSource = pc.getparcelType(new MySqlCommand("SELECT * FROM `parcel_type_list`"));

        }

        private void delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Uid.Text);
            if (MessageBox.Show("Are you sure you want to remove this parcel type", "Remove parcel type", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (pc.deleteparcelType(id))
                {
                    showTable();
                    MessageBox.Show("parce type Removed", "Remove parcel type", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void Parcel_type_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Uid.Text = Parcel_type.CurrentRow.Cells[0].Value.ToString();
            names.Text = Parcel_type.CurrentRow.Cells[1].Value.ToString();
            des.Text = Parcel_type.CurrentRow.Cells[2].Value.ToString();
            //Active.Text = parcel_type.CurrentRow.Cells[3].Value.ToString();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Uid.Text);
            string name = names.Text;
            string description = des.Text;
            string status = Active.Checked ? "Active" : "Not_Active";



            if (pc.updateparcelType(id, name, description, status))
            {

                MessageBox.Show("parcel type Update Complete", "Update parcel type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Uid.Clear();
                names.Clear();
                des.Clear();
                Active.Checked = true;

            }
            else
            {
                MessageBox.Show("parcel type not updated", "Update parcel type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Add_parcel_type_Load(object sender, EventArgs e)
        {
            showTable();
        }
    }
}
