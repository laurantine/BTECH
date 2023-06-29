using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laurantine
{
    public partial class Dashboard : Form
    {
        DBconnection connect = new DBconnection();
        parcelentry parcel = new parcelentry();
        carrierClass carrier = new carrierClass();
        parcelClass type = new parcelClass();
        userClass user = new userClass();
        public Dashboard()
        {
            InitializeComponent();
            CustomizeDesign();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            ParcelCount();
            ParcelcarrierCount();
            ParceltypeCount();
            userCount();

            connect.openconnect();

            string query = "SELECT DATE_FORMAT(date, '%m-%Y') AS month, SUM(1) AS code FROM parcel_list GROUP BY month";
            MySqlCommand cmd = new MySqlCommand(query, connect.getconnection);
            MySqlDataAdapter ad = new MySqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            ad.Fill(tb);


            //binding data to chart
            chart1.DataSource = tb;
            chart1.Series["Parcels per Month"].XValueMember = "month";
            chart1.Series["Parcels per Month"].YValueMembers ="code";
            chart1.DataBind();


            connect.closeconnect();
        }
        private void CustomizeDesign()
        {
            panel_sublist.Visible = false;
            panel_subAdmin.Visible = false;

        }
        private void hideSubmenu()
        {
            if (panel_sublist.Visible == true)
                panel_sublist.Visible = false;
            if (panel_subAdmin.Visible == true)
                panel_subAdmin.Visible = false;

        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm !=null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_out.Controls.Add(activeForm);
            panel_out.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_out.Controls.Add(panel_in);
        }

        private void parcel_list_Click(object sender, EventArgs e)
        {
            openChildForm(new Add_parcel());
        }

        private void assign_list_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_sublist);
        }

        private void parcel_type_Click(object sender, EventArgs e)
        {
            openChildForm(new Add_parcel_type());
            hideSubmenu();
        }

        private void add_carrier_Click(object sender, EventArgs e)
        {
            openChildForm(new Add_carrier());
            hideSubmenu();
        }

        private void send_Click(object sender, EventArgs e)
        {
            openChildForm(new sendSMS());
        }

        private void admin_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_subAdmin);
        }

        private void account_Click(object sender, EventArgs e)
        {
            openChildForm(new UserForm());
            hideSubmenu();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            this.Close();
            //Login lg = new Login();
            //lg.Show();
        }

        private void ParcelCount()
        {
            //Display the values
            cl.Text =  parcel.totalparcel();

        }
        private void ParceltypeCount()
        {
            //Display the values
            pt.Text =  type.totalparcel();

        }
        private void ParcelcarrierCount()
        {
            //Display the values
            c.Text =  carrier.totalparcel();

        }
        private void userCount()
        {
            //Display the values
            us.Text =  user.totaluser();

        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
