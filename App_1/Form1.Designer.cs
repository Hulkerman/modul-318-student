namespace App_1
{
    partial class Form1
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_start = new System.Windows.Forms.Label();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.lbl_end = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.txt_start = new System.Windows.Forms.TextBox();
            this.txt_time = new System.Windows.Forms.TextBox();
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
            this.grp_search.Controls.Add(this.dateTimePicker);
            this.grp_search.Controls.Add(this.btn_search);
            this.grp_search.Controls.Add(this.lbl_start);
            this.grp_search.Controls.Add(this.txt_end);
            this.grp_search.Controls.Add(this.lbl_end);
            this.grp_search.Controls.Add(this.lbl_date);
            this.grp_search.Controls.Add(this.txt_start);
            this.grp_search.Controls.Add(this.txt_time);
            this.grp_search.Controls.Add(this.lbl_time);
            this.grp_search.Location = new System.Drawing.Point(12, 12);
            this.grp_search.Name = "grp_search";
            this.grp_search.Size = new System.Drawing.Size(442, 164);
            this.grp_search.TabIndex = 17;
            this.grp_search.TabStop = false;
            this.grp_search.Text = "Suche";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(6, 92);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker.TabIndex = 16;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(302, 135);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(134, 23);
            this.btn_search.TabIndex = 15;
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
            this.lbl_start.TabIndex = 4;
            this.lbl_start.Text = "Start";
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(236, 40);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(200, 20);
            this.txt_end.TabIndex = 14;
            // 
            // lbl_end
            // 
            this.lbl_end.AutoSize = true;
            this.lbl_end.Location = new System.Drawing.Point(236, 24);
            this.lbl_end.Name = "lbl_end";
            this.lbl_end.Size = new System.Drawing.Size(24, 13);
            this.lbl_end.TabIndex = 13;
            this.lbl_end.Text = "Ziel";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(6, 76);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(38, 13);
            this.lbl_date.TabIndex = 8;
            this.lbl_date.Text = "Datum";
            // 
            // txt_start
            // 
            this.txt_start.Location = new System.Drawing.Point(6, 40);
            this.txt_start.Name = "txt_start";
            this.txt_start.Size = new System.Drawing.Size(200, 20);
            this.txt_start.TabIndex = 12;
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(236, 92);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(65, 20);
            this.txt_time.TabIndex = 9;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(236, 76);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(25, 13);
            this.lbl_time.TabIndex = 10;
            this.lbl_time.Text = "Zeit";
            // 
            // grp_result
            // 
            this.grp_result.Controls.Add(this.dataGridView1);
            this.grp_result.Location = new System.Drawing.Point(12, 182);
            this.grp_result.Name = "grp_result";
            this.grp_result.Size = new System.Drawing.Size(442, 239);
            this.grp_result.TabIndex = 18;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 433);
            this.Controls.Add(this.grp_result);
            this.Controls.Add(this.grp_search);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grp_search.ResumeLayout(false);
            this.grp_search.PerformLayout();
            this.grp_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_search;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_start;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.Label lbl_end;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.TextBox txt_start;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.GroupBox grp_result;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

