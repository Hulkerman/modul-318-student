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
            this.cmb_end = new System.Windows.Forms.ComboBox();
            this.cmb_start = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_time = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_start = new System.Windows.Forms.Label();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.grp_result = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grp_search.SuspendLayout();
            this.grp_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_search
            // 
            this.grp_search.Controls.Add(this.cmb_end);
            this.grp_search.Controls.Add(this.cmb_start);
            this.grp_search.Controls.Add(this.dateTimePicker_time);
            this.grp_search.Controls.Add(this.dateTimePicker_date);
            this.grp_search.Controls.Add(this.btn_search);
            this.grp_search.Controls.Add(this.lbl_start);
            this.grp_search.Controls.Add(this.lbl_end);
            this.grp_search.Controls.Add(this.lbl_date);
            this.grp_search.Controls.Add(this.lbl_time);
            this.grp_search.Location = new System.Drawing.Point(12, 12);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(442, 164);
            this.grp_search.TabIndex = 0;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Suche";
            // 
            // cmb_end
            // 
            this.cmb_end.FormattingEnabled = true;
            this.cmb_end.Location = new System.Drawing.Point(236, 40);
            this.cmb_end.Name = "cmb_end";
            this.cmb_end.Size = new System.Drawing.Size(200, 21);
            this.cmb_end.TabIndex = 2;
            this.cmb_end.Enter += new System.EventHandler(this.cmb_end_focus_enter);
            this.cmb_end.Leave += new System.EventHandler(this.cmb_end_focus_leave);
            // 
            // cmb_start
            // 
            this.cmb_start.FormattingEnabled = true;
            this.cmb_start.Location = new System.Drawing.Point(6, 40);
            this.cmb_start.Name = "cmb_start";
            this.cmb_start.Size = new System.Drawing.Size(200, 21);
            this.cmb_start.TabIndex = 1;
            this.cmb_start.Enter += new System.EventHandler(this.cmb_start_focus_enter);
            this.cmb_start.Leave += new System.EventHandler(this.cmb_start_focus_leave);
            // 
            // dateTimePicker_time
            // 
            this.dateTimePicker_time.CustomFormat = "HH:mm";
            this.dateTimePicker_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_time.Location = new System.Drawing.Point(131, 92);
            this.dateTimePicker_time.Name = "dateTimePicker_time";
            this.dateTimePicker_time.ShowUpDown = true;
            this.dateTimePicker_time.Size = new System.Drawing.Size(75, 20);
            this.dateTimePicker_time.TabIndex = 4;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.CustomFormat = "dd.mm.yyyy";
            this.dateTimePicker_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_date.Location = new System.Drawing.Point(6, 92);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(119, 20);
            this.dateTimePicker_date.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(302, 135);
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
            // grp_result
            // 
            this.grp_result.Controls.Add(this.dataGridView1);
            this.grp_result.Location = new System.Drawing.Point(12, 182);
            this.grp_result.Name = "grp_result";
            this.grp_result.Size = new System.Drawing.Size(442, 239);
            this.grp_result.TabIndex = 0;
            this.grp_result.TabStop = false;
            this.grp_result.Text = "Resultat";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(430, 214);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form_Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 433);
            this.Controls.Add(this.grp_result);
            this.Controls.Add(this.grp_search);
            this.Name = "Form_Fahrplan";
            this.Text = "Fahrplan";
            this.Load += new System.EventHandler(this.Form_Fahrplan_Load);
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            this.grp_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.GroupBox grp_result;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_time;
        private System.Windows.Forms.ComboBox cmb_start;
        private System.Windows.Forms.ComboBox cmb_end;
    }
}

