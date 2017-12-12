namespace App_1
{
    partial class Form_Fahrplan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Fahrplan));
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbx_start = new System.Windows.Forms.ListBox();
            this.lbx_end = new System.Windows.Forms.ListBox();
            this.grp_result = new System.Windows.Forms.GroupBox();
            this.dtg_connections = new System.Windows.Forms.DataGridView();
            this.btn_navigation_1 = new System.Windows.Forms.Button();
            this.btn_navigation_2 = new System.Windows.Forms.Button();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.pnl_2 = new System.Windows.Forms.Panel();
            this.grp_2_result = new System.Windows.Forms.GroupBox();
            this.dtg_2_routes = new System.Windows.Forms.DataGridView();
            this.grp_2_search = new System.Windows.Forms.GroupBox();
            this.lbx_2_start = new System.Windows.Forms.ListBox();
            this.btn_2_search = new System.Windows.Forms.Button();
            this.txt_2_start = new System.Windows.Forms.TextBox();
            this.lbl_2_start = new System.Windows.Forms.Label();
            this.btn_navigation_3 = new System.Windows.Forms.Button();
            this.pnl_3 = new System.Windows.Forms.Panel();
            this.web_gmaps = new System.Windows.Forms.WebBrowser();
            this.grp_3_search = new System.Windows.Forms.GroupBox();
            this.lbx_3_1_start = new System.Windows.Forms.ListBox();
            this.btn_3_search = new System.Windows.Forms.Button();
            this.txt_3_start = new System.Windows.Forms.TextBox();
            this.lbl_3_start = new System.Windows.Forms.Label();
            this.btn_switch = new System.Windows.Forms.Button();
            this.grp_search.SuspendLayout();
            this.grp_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_connections)).BeginInit();
            this.pnl_1.SuspendLayout();
            this.pnl_2.SuspendLayout();
            this.grp_2_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_2_routes)).BeginInit();
            this.grp_2_search.SuspendLayout();
            this.pnl_3.SuspendLayout();
            this.grp_3_search.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_search
            // 
            this.grp_search.Controls.Add(this.btn_switch);
            this.grp_search.Controls.Add(this.txt_end);
            this.grp_search.Controls.Add(this.txt_start);
            this.grp_search.Controls.Add(this.dtp_time);
            this.grp_search.Controls.Add(this.dtp_date);
            this.grp_search.Controls.Add(this.button1);
            this.grp_search.Controls.Add(this.btn_search);
            this.grp_search.Controls.Add(this.lbl_start);
            this.grp_search.Controls.Add(this.lbl_end);
            this.grp_search.Controls.Add(this.lbl_date);
            this.grp_search.Controls.Add(this.lbl_time);
            this.grp_search.Controls.Add(this.lbx_start);
            this.grp_search.Controls.Add(this.lbx_end);
            this.grp_search.Location = new System.Drawing.Point(0, 0);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(923, 164);
            this.grp_search.TabIndex = 0;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Suche";
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(254, 40);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(200, 20);
            this.txt_end.TabIndex = 5;
            this.txt_end.TextChanged += new System.EventHandler(this.txt_end_TextChanged);
            this.txt_end.Enter += new System.EventHandler(this.txt_end_FocusEnter);
            this.txt_end.Leave += new System.EventHandler(this.txt_end_FocusLeave);
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(6, 40);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(200, 20);
            this.txt_start.TabIndex = 4;
            this.txt_start.TextChanged += new System.EventHandler(this.txt_start_TextChanged);
            this.txt_start.Enter += new System.EventHandler(this.txt_start_FocusEnter);
            this.txt_start.Leave += new System.EventHandler(this.txt_start_FocusLeave);
            // 
            // dtp_time
            // 
            this.dtp_time.CustomFormat = "HH:mm";
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_time.Location = new System.Drawing.Point(131, 92);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.ShowUpDown = true;
            this.dtp_time.Size = new System.Drawing.Size(75, 20);
            this.dtp_time.TabIndex = 8;
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "dd.MM.yyyy";
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(6, 92);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(119, 20);
            this.dtp_date.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Verbindung suchen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(766, 135);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(151, 23);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Auf Google Maps ansehen";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_view_gmaps_Click);
            // 
            // lbl_start
            // 
            this.lbl_start.AutoSize = true;
            this.lbl_start.Location = new System.Drawing.Point(6, 24);
            this.lbl_start.Name = "lbl_start";
            this.lbl_start.Size = new System.Drawing.Size(29, 13);
            this.lbl_start.TabIndex = 0;
            this.lbl_start.Text = "Start";
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(254, 24);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(24, 13);
            this.lbl_end.TabIndex = 0;
            this.lbl_end.Text = "Ziel";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(6, 76);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(38, 13);
            this.lbl_date.TabIndex = 0;
            this.lbl_date.Text = "Datum";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(131, 76);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(25, 13);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "Zeit";
            // 
            // lbx_start
            // 
            this.lbx_start.FormattingEnabled = true;
            this.lbx_start.Location = new System.Drawing.Point(6, 59);
            this.lbx_start.Name = "lbx_start";
            this.lbx_start.Size = new System.Drawing.Size(200, 95);
            this.lbx_start.TabIndex = 0;
            this.lbx_start.Visible = false;
            this.lbx_start.Leave += new System.EventHandler(this.lbx_start_FocusLeave);
            this.lbx_start.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbx_start_MouseDoubleClick);
            // 
            // lbx_end
            // 
            this.lbx_end.FormattingEnabled = true;
            this.lbx_end.Location = new System.Drawing.Point(254, 59);
            this.lbx_end.Name = "lbx_end";
            this.lbx_end.Size = new System.Drawing.Size(200, 95);
            this.lbx_end.TabIndex = 0;
            this.lbx_end.Visible = false;
            this.lbx_end.Leave += new System.EventHandler(this.lbx_end_FocusLeave);
            this.lbx_end.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbx_end_MouseDoubleClick);
            // 
            // grp_result
            // 
            this.grp_result.Controls.Add(this.dtg_connections);
            this.grp_result.Location = new System.Drawing.Point(0, 170);
            this.grp_result.Name = "grp_result";
            this.grp_result.Size = new System.Drawing.Size(923, 462);
            this.grp_result.TabIndex = 0;
            this.grp_result.TabStop = false;
            this.grp_result.Text = "Resultat";
            // 
            // dtg_connections
            // 
            this.dtg_connections.AllowUserToAddRows = false;
            this.dtg_connections.AllowUserToDeleteRows = false;
            this.dtg_connections.AllowUserToResizeRows = false;
            this.dtg_connections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_connections.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_connections.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_connections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_connections.Cursor = System.Windows.Forms.Cursors.No;
            this.dtg_connections.Location = new System.Drawing.Point(6, 24);
            this.dtg_connections.Name = "dtg_connections";
            this.dtg_connections.ReadOnly = true;
            this.dtg_connections.RowHeadersVisible = false;
            this.dtg_connections.Size = new System.Drawing.Size(911, 432);
            this.dtg_connections.TabIndex = 0;
            // 
            // btn_navigation_1
            // 
            this.btn_navigation_1.Location = new System.Drawing.Point(12, 12);
            this.btn_navigation_1.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.btn_navigation_1.Name = "btn_navigation_1";
            this.btn_navigation_1.Size = new System.Drawing.Size(125, 35);
            this.btn_navigation_1.TabIndex = 1;
            this.btn_navigation_1.Text = "Verbindung suchen";
            this.btn_navigation_1.UseVisualStyleBackColor = true;
            this.btn_navigation_1.Click += new System.EventHandler(this.btn_navigation_1_Click);
            // 
            // btn_navigation_2
            // 
            this.btn_navigation_2.Location = new System.Drawing.Point(137, 12);
            this.btn_navigation_2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_navigation_2.Name = "btn_navigation_2";
            this.btn_navigation_2.Size = new System.Drawing.Size(125, 35);
            this.btn_navigation_2.TabIndex = 2;
            this.btn_navigation_2.Text = "Fahrplan";
            this.btn_navigation_2.UseVisualStyleBackColor = true;
            this.btn_navigation_2.Click += new System.EventHandler(this.btn_navigation_2_Click);
            // 
            // pnl_1
            // 
            this.pnl_1.Controls.Add(this.grp_search);
            this.pnl_1.Controls.Add(this.grp_result);
            this.pnl_1.Location = new System.Drawing.Point(12, 63);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(923, 632);
            this.pnl_1.TabIndex = 2;
            // 
            // pnl_2
            // 
            this.pnl_2.Controls.Add(this.grp_2_result);
            this.pnl_2.Controls.Add(this.grp_2_search);
            this.pnl_2.Location = new System.Drawing.Point(12, 63);
            this.pnl_2.Name = "pnl_2";
            this.pnl_2.Size = new System.Drawing.Size(923, 632);
            this.pnl_2.TabIndex = 3;
            // 
            // grp_2_result
            // 
            this.grp_2_result.Controls.Add(this.dtg_2_routes);
            this.grp_2_result.Location = new System.Drawing.Point(0, 170);
            this.grp_2_result.Name = "grp_2_result";
            this.grp_2_result.Size = new System.Drawing.Size(923, 462);
            this.grp_2_result.TabIndex = 4;
            this.grp_2_result.TabStop = false;
            this.grp_2_result.Text = "Resultat";
            // 
            // dtg_2_routes
            // 
            this.dtg_2_routes.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dtg_2_routes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_2_routes.Cursor = System.Windows.Forms.Cursors.No;
            this.dtg_2_routes.Location = new System.Drawing.Point(6, 24);
            this.dtg_2_routes.Name = "dtg_2_routes";
            this.dtg_2_routes.RowHeadersVisible = false;
            this.dtg_2_routes.Size = new System.Drawing.Size(911, 432);
            this.dtg_2_routes.TabIndex = 0;
            // 
            // grp_2_search
            // 
            this.grp_2_search.Controls.Add(this.lbx_2_start);
            this.grp_2_search.Controls.Add(this.btn_2_search);
            this.grp_2_search.Controls.Add(this.txt_2_start);
            this.grp_2_search.Controls.Add(this.lbl_2_start);
            this.grp_2_search.Location = new System.Drawing.Point(0, 0);
            this.grp_2_search.Name = "grp_2_search";
            this.grp_2_search.Size = new System.Drawing.Size(923, 164);
            this.grp_2_search.TabIndex = 3;
            this.grp_2_search.TabStop = false;
            this.grp_2_search.Text = "Suche";
            // 
            // lbx_2_start
            // 
            this.lbx_2_start.FormattingEnabled = true;
            this.lbx_2_start.Location = new System.Drawing.Point(6, 59);
            this.lbx_2_start.Name = "lbx_2_start";
            this.lbx_2_start.Size = new System.Drawing.Size(200, 95);
            this.lbx_2_start.TabIndex = 0;
            this.lbx_2_start.Visible = false;
            this.lbx_2_start.DoubleClick += new System.EventHandler(this.lbx_2_start_DoubleClick);
            this.lbx_2_start.Leave += new System.EventHandler(this.lbx_2_start_FoucsLeave);
            // 
            // btn_2_search
            // 
            this.btn_2_search.Location = new System.Drawing.Point(783, 135);
            this.btn_2_search.Name = "btn_2_search";
            this.btn_2_search.Size = new System.Drawing.Size(134, 23);
            this.btn_2_search.TabIndex = 12;
            this.btn_2_search.Text = "Routen suchen";
            this.btn_2_search.UseVisualStyleBackColor = true;
            this.btn_2_search.Click += new System.EventHandler(this.btn_2_search_Click);
            // 
            // txt_2_start
            // 
            this.txt_2_start.Location = new System.Drawing.Point(6, 40);
            this.txt_2_start.Name = "txt_2_start";
            this.txt_2_start.Size = new System.Drawing.Size(200, 20);
            this.txt_2_start.TabIndex = 11;
            this.txt_2_start.TextChanged += new System.EventHandler(this.txt_2_start_TextChanged);
            this.txt_2_start.Enter += new System.EventHandler(this.txt_2_start_FocusEnter);
            this.txt_2_start.Leave += new System.EventHandler(this.txt_2_start_FocusLeave);
            // 
            // lbl_2_start
            // 
            this.lbl_2_start.AutoSize = true;
            this.lbl_2_start.Location = new System.Drawing.Point(6, 24);
            this.lbl_2_start.Name = "lbl_2_start";
            this.lbl_2_start.Size = new System.Drawing.Size(29, 13);
            this.lbl_2_start.TabIndex = 2;
            this.lbl_2_start.Text = "Start";
            // 
            // btn_navigation_3
            // 
            this.btn_navigation_3.Location = new System.Drawing.Point(262, 12);
            this.btn_navigation_3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_navigation_3.Name = "btn_navigation_3";
            this.btn_navigation_3.Size = new System.Drawing.Size(125, 35);
            this.btn_navigation_3.TabIndex = 3;
            this.btn_navigation_3.Text = "Karte";
            this.btn_navigation_3.UseVisualStyleBackColor = true;
            this.btn_navigation_3.Click += new System.EventHandler(this.btn_navigation_3_Click);
            // 
            // pnl_3
            // 
            this.pnl_3.Controls.Add(this.web_gmaps);
            this.pnl_3.Controls.Add(this.grp_3_search);
            this.pnl_3.Location = new System.Drawing.Point(12, 63);
            this.pnl_3.Name = "pnl_3";
            this.pnl_3.Size = new System.Drawing.Size(923, 632);
            this.pnl_3.TabIndex = 4;
            // 
            // web_gmaps
            // 
            this.web_gmaps.Location = new System.Drawing.Point(0, 170);
            this.web_gmaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_gmaps.Name = "web_gmaps";
            this.web_gmaps.ScriptErrorsSuppressed = true;
            this.web_gmaps.Size = new System.Drawing.Size(923, 462);
            this.web_gmaps.TabIndex = 5;
            // 
            // grp_3_search
            // 
            this.grp_3_search.Controls.Add(this.lbx_3_1_start);
            this.grp_3_search.Controls.Add(this.btn_3_search);
            this.grp_3_search.Controls.Add(this.txt_3_start);
            this.grp_3_search.Controls.Add(this.lbl_3_start);
            this.grp_3_search.Location = new System.Drawing.Point(0, 0);
            this.grp_3_search.Name = "grp_3_search";
            this.grp_3_search.Size = new System.Drawing.Size(923, 164);
            this.grp_3_search.TabIndex = 4;
            this.grp_3_search.TabStop = false;
            this.grp_3_search.Text = "Suche";
            // 
            // lbx_3_1_start
            // 
            this.lbx_3_1_start.FormattingEnabled = true;
            this.lbx_3_1_start.Location = new System.Drawing.Point(6, 59);
            this.lbx_3_1_start.Name = "lbx_3_1_start";
            this.lbx_3_1_start.Size = new System.Drawing.Size(200, 95);
            this.lbx_3_1_start.TabIndex = 9;
            this.lbx_3_1_start.Visible = false;
            this.lbx_3_1_start.DoubleClick += new System.EventHandler(this.lbx_3_start_DoubleClick);
            this.lbx_3_1_start.Leave += new System.EventHandler(this.lbx_3_start_FocusLeave);
            // 
            // btn_3_search
            // 
            this.btn_3_search.Location = new System.Drawing.Point(783, 135);
            this.btn_3_search.Name = "btn_3_search";
            this.btn_3_search.Size = new System.Drawing.Size(134, 23);
            this.btn_3_search.TabIndex = 14;
            this.btn_3_search.Text = "Station anzeigen";
            this.btn_3_search.UseVisualStyleBackColor = true;
            this.btn_3_search.Click += new System.EventHandler(this.btn_3_search_Click);
            // 
            // txt_3_start
            // 
            this.txt_3_start.Location = new System.Drawing.Point(6, 40);
            this.txt_3_start.Name = "txt_3_start";
            this.txt_3_start.Size = new System.Drawing.Size(200, 20);
            this.txt_3_start.TabIndex = 13;
            this.txt_3_start.TextChanged += new System.EventHandler(this.txt_3_start_TextChanged);
            this.txt_3_start.Enter += new System.EventHandler(this.txt_3_start_FocusEnter);
            this.txt_3_start.Leave += new System.EventHandler(this.txt_3_start_FocusLeave);
            // 
            // lbl_3_start
            // 
            this.lbl_3_start.AutoSize = true;
            this.lbl_3_start.Location = new System.Drawing.Point(6, 24);
            this.lbl_3_start.Name = "lbl_3_start";
            this.lbl_3_start.Size = new System.Drawing.Size(40, 13);
            this.lbl_3_start.TabIndex = 2;
            this.lbl_3_start.Text = "Station";
            // 
            // btn_switch
            // 
            this.btn_switch.BackgroundImage = global::App_1.Properties.Resources.minicons_73_5121;
            this.btn_switch.Location = new System.Drawing.Point(212, 40);
            this.btn_switch.Name = "btn_switch";
            this.btn_switch.Size = new System.Drawing.Size(36, 32);
            this.btn_switch.TabIndex = 6;
            this.btn_switch.UseVisualStyleBackColor = true;
            this.btn_switch.Click += new System.EventHandler(this.btn_switch_Click);
            // 
            // Form_Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 707);
            this.Controls.Add(this.btn_navigation_3);
            this.Controls.Add(this.btn_navigation_2);
            this.Controls.Add(this.btn_navigation_1);
            this.Controls.Add(this.pnl_3);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.pnl_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Fahrplan";
            this.Text = "Fahrplan";
            this.Load += new System.EventHandler(this.Form_Fahrplan_Load);
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            this.grp_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_connections)).EndInit();
            this.pnl_1.ResumeLayout(false);
            this.pnl_2.ResumeLayout(false);
            this.grp_2_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_2_routes)).EndInit();
            this.grp_2_search.ResumeLayout(false);
            this.grp_2_search.PerformLayout();
            this.pnl_3.ResumeLayout(false);
            this.grp_3_search.ResumeLayout(false);
            this.grp_3_search.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.GroupBox grp_result;
        private System.Windows.Forms.DataGridView dtg_connections;
        private System.Windows.Forms.DateTimePicker dtp_time;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.ListBox lbx_end;
        private System.Windows.Forms.ListBox lbx_start;
        private System.Windows.Forms.Button btn_navigation_1;
        private System.Windows.Forms.Button btn_navigation_2;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.Panel pnl_2;
        private System.Windows.Forms.GroupBox grp_2_result;
        private System.Windows.Forms.GroupBox grp_2_search;
        private System.Windows.Forms.TextBox txt_2_start;
        private System.Windows.Forms.Label lbl_2_start;
        private System.Windows.Forms.Button btn_2_search;
        private System.Windows.Forms.ListBox lbx_2_start;
        private System.Windows.Forms.DataGridView dtg_2_routes;
        private System.Windows.Forms.Button btn_navigation_3;
        private System.Windows.Forms.Panel pnl_3;
        private System.Windows.Forms.GroupBox grp_3_search;
        private System.Windows.Forms.ListBox lbx_3_1_start;
        private System.Windows.Forms.Button btn_3_search;
        private System.Windows.Forms.TextBox txt_3_start;
        private System.Windows.Forms.Label lbl_3_start;
        private System.Windows.Forms.WebBrowser web_gmaps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_switch;
    }
}

