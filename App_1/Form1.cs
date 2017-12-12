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
        Coordinate coordinate = new Coordinate();
        public Form_Fahrplan()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------------------------
        //--METHODS-----
        //----------------------------------------------------------------------------------------------------

        private void Set_DefaultTxt(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                textBox.Text = "Station...";
                textBox.ForeColor = Color.Gray;
            }
            if (textBox.Focused)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void Get_Stations(string text, ListBox listBox)
        {
            if (text.Length >= 3 && text != "Station...")
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
                Station station = transport.GetStations(txt_start.Text).StationList.First();
                StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id);
                foreach (StationBoard station_ in departures.Entries)
                {
                    dtt_connections.Rows.Add(Get_Date(connection.From.Departure), Get_Time(connection.From.Departure), connection.From.Station.Name, connection.To.Station.Name, (station_.Category + " " + station_.Number));
                }

            }
            
            dtg_connections.DataSource = dtt_connections;
        }

        private void Get_2_Grid()
        {
            DataTable dtt_routes = new DataTable();
            dtt_routes.Columns.Add("Nach");
            dtt_routes.Columns.Add("Linie");

            Station station = transport.GetStations(txt_2_start.Text).StationList.First();
            StationBoardRoot departures = transport.GetStationBoard(station.Name, station.Id);

            foreach (StationBoard station_b in departures.Entries)
            {
                dtt_routes.Rows.Add(station_b.To, (station_b.Category + " " + station_b.Number));
            }

            dtg_2_routes.DataSource = dtt_routes;
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

        private void Set_DefaultBtn()
        {
            System.Drawing.Size draw_btn_active = new System.Drawing.Size();
            draw_btn_active.Width = 125;
            draw_btn_active.Height = 45;

            System.Drawing.Size draw_btn_inactive = new System.Drawing.Size();
            draw_btn_inactive.Width = 125;
            draw_btn_inactive.Height = 35;

            if (pnl_1.Visible)
            {
                btn_navigation_1.Size = draw_btn_active;
            }
            else
            {
                btn_navigation_1.Size = draw_btn_inactive;
            }

            if (pnl_2.Visible)
            {
                btn_navigation_2.Size = draw_btn_active;
            }
            else
            {
                btn_navigation_2.Size = draw_btn_inactive;
            }

            if (pnl_3.Visible)
            {
                btn_navigation_3.Size = draw_btn_active;
            }
            else
            {
                btn_navigation_3.Size = draw_btn_inactive;
            }
        }

        private void Create_GmapConnection(string x1, string y1, string x2, string y2)
        {
            string url = "https://www.google.ch/maps/dir/"+ x1 + ", " + y1 + "/" + x2 + "," + y2;
            web_gmaps.Navigate(url);
        }

        private void Create_GmapStation(string x, string y)
        {
            string url = "https://www.google.ch/maps/place/" + x + "," + y;
            web_gmaps.Navigate(url);
        }

        //----------------------------------------------------------------------------------------------------
        //--EVENTS--------
        //----Navigation--
        //----------------------------------------------------------------------------------------------------

        private void Form_Fahrplan_Load(object sender, EventArgs e)
        {
            pnl_1.Visible = true;
            pnl_2.Visible = false;
            pnl_3.Visible = false;
            Set_DefaultBtn();
            Set_DefaultTxt(txt_start);
            Set_DefaultTxt(txt_end);
            Set_DefaultTxt(txt_2_start);
            Set_DefaultTxt(txt_3_start);
        }

        private void btn_navigation_1_Click(object sender, EventArgs e)
        {
            pnl_1.Visible = true;
            pnl_2.Visible = false;
            pnl_3.Visible = false;
            Set_DefaultBtn();
        }

        private void btn_navigation_2_Click(object sender, EventArgs e)
        {
            pnl_1.Visible = false;
            pnl_2.Visible = true;
            pnl_3.Visible = false;
            Set_DefaultBtn();
        }

        private void btn_navigation_3_Click(object sender, EventArgs e)
        {
            pnl_1.Visible = false;
            pnl_2.Visible = false;
            pnl_3.Visible = true;
            Set_DefaultBtn();
        }

        //----------------------------------------------------------------------------------------------------
        //----Menu_1------
        //----------------------------------------------------------------------------------------------------

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_start.Text != string.Empty && txt_start.Text != "Station...")
            {
                Get_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie zwei Stationen ein.");
            }
        }

        private void btn_view_gmaps_Click(object sender, EventArgs e)
        {
            if (txt_start.Text != string.Empty && txt_start.Text != "Station...")
            {
                Stations stations_start = transport.GetStations(txt_start.Text);
                Stations stations_end = transport.GetStations(txt_end.Text);

                Station station_start = stations_start.StationList[0];
                Station station_end = stations_end.StationList[0];

                Create_GmapConnection(Convert.ToString(station_start.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station_start.Coordinate.YCoordinate).Replace(',', '.'), Convert.ToString(station_end.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station_end.Coordinate.YCoordinate).Replace(',', '.'));

                pnl_1.Visible = false;
                pnl_2.Visible = false;
                pnl_3.Visible = true;

                Set_DefaultBtn();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie zwei Stationen ein.");
            }

        }

        private void txt_start_FocusEnter(object sender, EventArgs e)
        {
            if (!lbx_start.Visible)
            {
                Set_DefaultTxt(txt_start);
            }
        }

        private void txt_start_FocusLeave(object sender, EventArgs e)
        {
            Set_DefaultTxt(txt_start);
            if (!lbx_start.Focused)
            {
                lbx_start.Visible = false;
            }
        }

        private void txt_end_FocusEnter(object sender, EventArgs e)
        {
            if (!lbx_end.Visible)
            {
                Set_DefaultTxt(txt_end);
            }
        }

        private void txt_end_FocusLeave(object sender, EventArgs e)
        {
            Set_DefaultTxt(txt_end);
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

        //----------------------------------------------------------------------------------------------------
        //----Menu_2------
        //----------------------------------------------------------------------------------------------------

        private void btn_2_search_Click(object sender, EventArgs e)
        {
            if (txt_2_start.Text != string.Empty && txt_2_start.Text != "Station...")
            {
                Get_2_Grid();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine Station ein.");
            }
        }

        private void txt_2_start_FocusEnter(object sender, EventArgs e)
        {
            if (!lbx_start.Visible)
            {
                Set_DefaultTxt(txt_2_start);
            }
        }

        private void txt_2_start_FocusLeave(object sender, EventArgs e)
        {
            Set_DefaultTxt(txt_2_start);
            if (!lbx_start.Focused)
            {
                lbx_start.Visible = false;
            }
        }

        private void txt_2_start_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(txt_2_start.Text, lbx_2_start);
        }

        private void lbx_2_start_FoucsLeave(object sender, EventArgs e)
        {
            Set_DefaultTxt(txt_2_start);
            if (!lbx_2_start.Focused)
            {
                lbx_2_start.Visible = false;
            }
        }

        private void lbx_2_start_DoubleClick(object sender, EventArgs e)
        {
            txt_2_start.Text = lbx_2_start.SelectedItem.ToString();
            lbx_2_start.Visible = false;
        }

        //----------------------------------------------------------------------------------------------------
        //----Menu_3------
        //----------------------------------------------------------------------------------------------------

        private void btn_3_search_Click(object sender, EventArgs e)
        {
            if(txt_3_start.Text != string.Empty && txt_3_start.Text != "Station...")
            {
                Stations stations = transport.GetStations(txt_3_start.Text);

                Station station = stations.StationList[0];
                Create_GmapStation(Convert.ToString(station.Coordinate.XCoordinate).Replace(',', '.'), Convert.ToString(station.Coordinate.YCoordinate).Replace(',', '.'));
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine Station ein.");
            }
        }

        private void txt_3_start_TextChanged(object sender, EventArgs e)
        {
            Get_Stations(txt_3_start.Text, lbx_3_1_start);
        }

        private void txt_3_start_FocusEnter(object sender, EventArgs e)
        {
            Set_DefaultTxt(txt_3_start);
        }

        private void txt_3_start_FocusLeave(object sender, EventArgs e)
        {
            Set_DefaultTxt(txt_3_start);
        }

        private void lbx_3_start_DoubleClick(object sender, EventArgs e)
        {
            txt_3_start.Text = lbx_3_1_start.SelectedItem.ToString();
            lbx_3_1_start.Visible = false;
        }

        private void lbx_3_start_FocusLeave(object sender, EventArgs e)
        {
            Set_DefaultTxt(txt_3_start);
            if (!lbx_3_1_start.Focused)
            {
                lbx_3_1_start.Visible = false;
            }
        }
    }
}
