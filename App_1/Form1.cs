using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_1
{
    public partial class Form_Fahrplan : Form
    {
        public Form_Fahrplan()
        {
            InitializeComponent();

            cmb_start.Text = "Von...";
            cmb_start.ForeColor = Color.Gray;
            cmb_end.Text = "Nach...";
            cmb_end.ForeColor = Color.Gray;
        }
        //----METHODS----
        private void set_dflt_cmb()
        {
            if (!cmb_start.Focused)
            {
                if (cmb_start.Text == "")
                {
                    cmb_start.Text = "Von...";
                    cmb_start.ForeColor = Color.Gray;
                }
            }

            if (!cmb_end.Focused)
            {
                if (cmb_end.Text == "")
                {
                    cmb_end.Text = "Nach...";
                    cmb_end.ForeColor = Color.Gray;
                }
            }
        }


        //----EVENTS----
        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void cmb_start_focus_enter(object sender, EventArgs e)
        {
            cmb_start.Text = "";
            cmb_start.ForeColor = Color.Black;
        }

        private void cmb_start_focus_leave(object sender, EventArgs e)
        {
            set_dflt_cmb();
        }

        private void cmb_end_focus_enter(object sender, EventArgs e)
        {
            cmb_end.Text = "";
            cmb_end.ForeColor = Color.Black;
        }

        private void cmb_end_focus_leave(object sender, EventArgs e)
        {
            set_dflt_cmb();
        }
    }
}
