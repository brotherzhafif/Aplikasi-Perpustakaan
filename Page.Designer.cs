namespace Aplikasi_Perpustakaan
{
    partial class Page
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
            this.panel_admin = new System.Windows.Forms.Panel();
            this.btn_user = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_nama = new System.Windows.Forms.Label();
            this.panel_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_admin
            // 
            this.panel_admin.BackColor = System.Drawing.Color.White;
            this.panel_admin.Controls.Add(this.lbl_nama);
            this.panel_admin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel_admin.Location = new System.Drawing.Point(370, 168);
            this.panel_admin.Name = "panel_admin";
            this.panel_admin.Size = new System.Drawing.Size(60, 3);
            this.panel_admin.TabIndex = 7;
            this.panel_admin.Visible = false;
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_user.BackgroundImage = global::Aplikasi_Perpustakaan.Properties.Resources.User;
            this.btn_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Monotype Corsiva", 1F, System.Drawing.FontStyle.Italic);
            this.btn_user.ForeColor = System.Drawing.Color.White;
            this.btn_user.Location = new System.Drawing.Point(370, 178);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(60, 60);
            this.btn_user.TabIndex = 8;
            this.btn_user.Text = "3";
            this.btn_user.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel4.Location = new System.Drawing.Point(370, 279);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(60, 3);
            this.panel4.TabIndex = 6;
            // 
            // lbl_nama
            // 
            this.lbl_nama.AutoSize = true;
            this.lbl_nama.Font = new System.Drawing.Font("Monotype Corsiva", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nama.ForeColor = System.Drawing.Color.White;
            this.lbl_nama.Location = new System.Drawing.Point(-23, -12);
            this.lbl_nama.Name = "lbl_nama";
            this.lbl_nama.Size = new System.Drawing.Size(106, 27);
            this.lbl_nama.TabIndex = 2;
            this.lbl_nama.Text = "Nama User";
            // 
            // Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_admin);
            this.Controls.Add(this.btn_user);
            this.Controls.Add(this.panel4);
            this.Name = "Page";
            this.Text = "Switch";
            this.Load += new System.EventHandler(this.Page_Load);
            this.panel_admin.ResumeLayout(false);
            this.panel_admin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_admin;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_nama;
    }
}