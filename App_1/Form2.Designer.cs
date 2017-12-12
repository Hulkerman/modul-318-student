namespace App_1
{
    partial class Form_confirm_exit
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
            this.lbl_confirm_exit = new System.Windows.Forms.Label();
            this.btn_confitm_exit = new System.Windows.Forms.Button();
            this.btn_cancel_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_confirm_exit
            // 
            this.lbl_confirm_exit.AutoSize = true;
            this.lbl_confirm_exit.Location = new System.Drawing.Point(12, 27);
            this.lbl_confirm_exit.Name = "lbl_confirm_exit";
            this.lbl_confirm_exit.Size = new System.Drawing.Size(159, 13);
            this.lbl_confirm_exit.TabIndex = 0;
            this.lbl_confirm_exit.Text = "Möchten Sie wirklich verlassen?";
            // 
            // btn_confitm_exit
            // 
            this.btn_confitm_exit.Location = new System.Drawing.Point(15, 65);
            this.btn_confitm_exit.Name = "btn_confitm_exit";
            this.btn_confitm_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_confitm_exit.TabIndex = 1;
            this.btn_confitm_exit.Text = "Ja";
            this.btn_confitm_exit.UseVisualStyleBackColor = true;
            this.btn_confitm_exit.Click += new System.EventHandler(this.btn_confitm_exit_Click);
            // 
            // btn_cancel_exit
            // 
            this.btn_cancel_exit.Location = new System.Drawing.Point(96, 65);
            this.btn_cancel_exit.Name = "btn_cancel_exit";
            this.btn_cancel_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel_exit.TabIndex = 2;
            this.btn_cancel_exit.Text = "Nein";
            this.btn_cancel_exit.UseVisualStyleBackColor = true;
            this.btn_cancel_exit.Click += new System.EventHandler(this.btn_cancel_exit_Click);
            // 
            // Form_confirm_exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 100);
            this.Controls.Add(this.btn_cancel_exit);
            this.Controls.Add(this.btn_confitm_exit);
            this.Controls.Add(this.lbl_confirm_exit);
            this.Name = "Form_confirm_exit";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_confirm_exit;
        private System.Windows.Forms.Button btn_confitm_exit;
        private System.Windows.Forms.Button btn_cancel_exit;
    }
}