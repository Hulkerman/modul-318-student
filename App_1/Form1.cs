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
            cmb_start.DisplayMember = "Name";
            cmb_end.DisplayMember = "Name";
        }

        //----METHODS----
        private void set_dflt_cmb()
        {
            if (cmb_start.Focused)
            {
                cmb_start.Text = "";
                cmb_start.ForeColor = Color.Black;
            }
            else
            {
                if (cmb_start.Text == "")
                {
                    cmb_start.Text = "Von...";
                    cmb_start.ForeColor = Color.Gray;
                }
            }

            if (cmb_end.Focused)
            {
                cmb_end.Text = "";
                cmb_end.ForeColor = Color.Black;
            }
            else
            {
                if (cmb_end.Text == "")
                {
                    cmb_end.Text = "Nach...";
                    cmb_end.ForeColor = Color.Gray;
                }
            }
        }

        private void set_ComboBox (ComboBox box)
        {
            string input_text = box.Text;
            if (input_text != null)
            {
                box.DataSource = transport.GetStations(box.Text).StationList;
                box.Text = input_text;
                box.SelectionStart = input_text.Length;
                if (box.DroppedDown == false)
                {
                    box.DroppedDown = true;
                }
            }
        }

        //----EVENTS----

        private void Form_Fahrplan_Load(object sender, EventArgs e)
        {
            set_dflt_cmb();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void cmb_start_focus_enter(object sender, EventArgs e)
        {
            set_dflt_cmb();
        }

        private void cmb_start_focus_leave(object sender, EventArgs e)
        {
            set_dflt_cmb();
        }

        private void cmb_end_focus_enter(object sender, EventArgs e)
        {
            set_dflt_cmb();
        }

        private void cmb_end_focus_leave(object sender, EventArgs e)
        {
            set_dflt_cmb();
        }

        private void cmb_start_TextChanged(object sender, EventArgs e)
        {
            if (cmb_start.Text != "" && cmb_start.Text != "Von...")
            {
                set_ComboBox(cmb_start);
            }
        }
    }
}
