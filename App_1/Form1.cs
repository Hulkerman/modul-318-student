using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace App_1
{
    public partial class Form_Fahrplan : Form
    {
        Transport transport = new Transport();
        public Form_Fahrplan()
        {
            InitializeComponent();
        }

        //----METHODS----
        private void Set_DefaultTxt()
        {
            if (txt_start.Focused)
            {
                txt_start.Text = "";
                txt_start.ForeColor = Color.Black;
            }
            else
            {
                if (txt_start.Text == "")
                {
                    txt_start.Text = "Von...";
                    txt_start.ForeColor = Color.Gray;
                }
            }

            if (txt_end.Focused)
            {
                txt_end.Text = "";
                txt_end.ForeColor = Color.Black;
            }
            else
            {
                if (txt_end.Text == "")
                {
                    txt_end.Text = "Nach...";
                    txt_end.ForeColor = Color.Gray;
                }
            }
        }

        private void Get_Stations(string text, ListBox listBox)
        {
            if (text.Length >= 3 && text != "Von..." && text != "Nach...")
            {
                listBox.Items.Clear();
                Stations stations = transport.GetStations(text);
                foreach (Station station in stations.StationList)
                {
                    listBox.Items.Add(station.Name);
                    listBox.Visible = true;
                    listBox.BringToFront();
                }
            }
        }

        private void Get_Grid()
        {
            DataTable dtt_connections = new DataTable();
            dtt_connections.Columns.Add("Datum");
            dtt_connections.Columns.Add("Abfahrt");
            dtt_connections.Columns.Add("Von");
            dtt_connections.Columns.Add("Nach");
            dtt_connections.Columns.Add("Linie");

            Connections connections = transport.GetConnections(txt_start.Text, txt_end.Text, dtp_date.Value.ToString("yyyy-MM-dd"), dtp_time.Text);

            foreach (Connection connection in connections.ConnectionList)
            {
                dtt_connections.Rows.Add(Get_Date(connection.From.Departure), Get_Time(connection.From.Departure), connection.From.Station.Name, connection.To.Station.Name);
            }

            dtg_connections.DataSource = dtt_connections;
        }

        private string Get_Date(string date1)
        {
            string date2 = date1.Remove(10);
            DateTime date3 = Convert.ToDateTime(date2);

            return date3.ToString("dd.MM.yyyy");
        }

        private string Get_Time(string time1)
        {
            string time2 = time1.Remove(0, 11);
            time2 = time2.Remove(5);

            return time2;
        }

        //----EVENTS----

        private void Form_Fahrplan_Load(object sender, EventArgs e)
        {
            Set_DefaultTxt();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                Get_Grid();
            }
            catch
            {
                MessageBox.Show("Mindestens eine Station wurde nicht gefunden!");
            }
        }

        private void txt_start_FocusEnter(object sender, EventArgs e)
        {
            if (!lbx_start.Visible)
            {
                Set_DefaultTxt();
            }
        }

        private void txt_start_FocusLeave(object sender, EventArgs e)
        {
            Set_DefaultTxt();
            if (!lbx_start.Focused)
            {
                lbx_start.Visible = false;
            }
        }

        private void txt_end_FocusEnter(object sender, EventArgs e)
        {
            if (!lbx_end.Visible)
            {
                Set_DefaultTxt();
            }
        }

        private void txt_end_FocusLeave(object sender, EventArgs e)
        {
            Set_DefaultTxt();
            if (!lbx_end.Focused)
            {
                lbx_end.Visible = false;
            }
        }

        private void txt_start_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(txt_start.Text, lbx_start);
        }

        private void txt_end_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(txt_end.Text, lbx_end);
        }

        private void lbx_start_FocusLeave(object sender, EventArgs e)
        {
            if (!txt_start.Focused)
            {
                lbx_start.Visible = false;
            }
        }
        private void lbx_end_FocusLeave(object sender, EventArgs e)
        {
            if (!txt_end.Focused)
            {
                lbx_end.Visible = false;
            }

        }
        private void lbx_start_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_start.Text = lbx_start.SelectedItem.ToString();
            lbx_start.Visible = false;
        }

        private void lbx_end_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_end.Text = lbx_end.SelectedItem.ToString();
            lbx_end.Visible = false;
        }
    }
}