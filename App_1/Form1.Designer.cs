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
            this.grp_search = new System.Windows.Forms.GroupBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbx_start = new System.Windows.Forms.ListBox();
            this.lbx_end = new System.Windows.Forms.ListBox();
            this.grp_result = new System.Windows.Forms.GroupBox();
            this.dtg_connections = new System.Windows.Forms.DataGridView();
            this.grp_search.SuspendLayout();
            this.grp_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_connections)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_search
            // 
            this.grp_search.Controls.Add(this.txt_end);
            this.grp_search.Controls.Add(this.txt_start);
            this.grp_search.Controls.Add(this.dtp_time);
            this.grp_search.Controls.Add(this.dtp_date);
            this.grp_search.Controls.Add(this.btn_search);
            this.grp_search.Controls.Add(this.lbl_start);
            this.grp_search.Controls.Add(this.lbl_end);
            this.grp_search.Controls.Add(this.lbl_date);
            this.grp_search.Controls.Add(this.lbl_time);
            this.grp_search.Controls.Add(this.lbx_start);
            this.grp_search.Controls.Add(this.lbx_end);
            this.grp_search.Location = new System.Drawing.Point(12, 12);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(642, 164);
            this.grp_search.TabIndex = 0;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Suche";
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(236, 40);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(200, 20);
            this.txt_end.TabIndex = 2;
            this.txt_end.TextChanged += new System.EventHandler(this.txt_end_TextChanged);
            this.txt_end.Enter += new System.EventHandler(this.txt_end_FocusEnter);
            this.txt_end.Leave += new System.EventHandler(this.txt_end_FocusLeave);
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(6, 40);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(200, 20);
            this.txt_start.TabIndex = 1;
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
            this.dtp_time.TabIndex = 4;
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "dd.MM.yyyy";
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(6, 92);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(119, 20);
            this.dtp_date.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(502, 131);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(134, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Verbindung suchen";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
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
            this.lbl_end.Location = new System.Drawing.Point(236, 24);
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
            this.lbx_start.TabIndex = 8;
            this.lbx_start.Visible = false;
            this.lbx_start.Leave += new System.EventHandler(this.lbx_start_FocusLeave);
            this.lbx_start.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbx_start_MouseDoubleClick);
            // 
            // lbx_end
            // 
            this.lbx_end.FormattingEnabled = true;
            this.lbx_end.Location = new System.Drawing.Point(236, 59);
            this.lbx_end.Name = "lbx_end";
            this.lbx_end.Size = new System.Drawing.Size(200, 95);
            this.lbx_end.TabIndex = 8;
            this.lbx_end.Visible = false;
            this.lbx_end.Leave += new System.EventHandler(this.lbx_end_FocusLeave);
            this.lbx_end.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbx_end_MouseDoubleClick);
            // 
            // grp_result
            // 
            this.grp_result.Controls.Add(this.dtg_connections);
            this.grp_result.Location = new System.Drawing.Point(12, 182);
            this.grp_result.Name = "grp_result";
            this.grp_result.Size = new System.Drawing.Size(648, 204);
            this.grp_result.TabIndex = 0;
            this.grp_result.TabStop = false;
            this.grp_result.Text = "Resultat";
            // 
            // dtg_connections
            // 
            this.dtg_connections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_connections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_connections.Cursor = System.Windows.Forms.Cursors.No;
            this.dtg_connections.Location = new System.Drawing.Point(6, 19);
            this.dtg_connections.Name = "dtg_connections";
            this.dtg_connections.RowHeadersVisible = false;
            this.dtg_connections.Size = new System.Drawing.Size(636, 177);
            this.dtg_connections.TabIndex = 0;
            // 
            // Form_Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 398);
            this.Controls.Add(this.grp_result);
            this.Controls.Add(this.grp_search);
            this.Name = "Form_Fahrplan";
            this.Text = "Fahrplan";
            this.Load += new System.EventHandler(this.Form_Fahrplan_Load);
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            this.grp_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_connections)).EndInit();
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
    }
}

