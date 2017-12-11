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
        private void set_dflt_txt()
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

        private void get_stations(string text, ListBox listBox)
        {
            if(text.Length >= 3 && text!= "Von..." && text != "Nach...")
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

        //----EVENTS----

        private void Form_Fahrplan_Load(object sender, EventArgs e)
        {
            set_dflt_txt();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void txt_start_FocusEnter(object sender, EventArgs e)
        {
            if (!lbx_start.Visible)
            {
                set_dflt_txt();
            }
        }

        private void txt_start_FocusLeave(object sender, EventArgs e)
        {
            set_dflt_txt();
            if (lbx_start.Focused)
            {
                //Do Nothing
            }
            else
            {
                lbx_start.Visible = false;
            }
        }

        private void txt_end_FocusEnter(object sender, EventArgs e)
        {
            if (!lbx_end.Visible)
            {
                set_dflt_txt();
            }
        }

        private void txt_end_FocusLeave(object sender, EventArgs e)
        {
            set_dflt_txt();
            if (lbx_end.Focused)
            {
                //Do Nothing
            }
            else
            {
                lbx_end.Visible = false;
            }
        }

        private void txt_start_TextChanged(object sender, EventArgs e)
        {
            get_stations(txt_start.Text, lbx_start);
        }

        private void txt_end_TextChanged(object sender, EventArgs e)
        {
            get_stations(txt_end.Text, lbx_end);
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
        }

        private void lbx_end_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txt_end.Text = lbx_end.SelectedItem.ToString();
        }
    }
}
