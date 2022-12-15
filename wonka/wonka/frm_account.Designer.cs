
namespace wonka
{
    partial class frm_account
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
            this.lv_safe = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.safe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtp_search = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.p1 = new System.Windows.Forms.Panel();
            this.btn_ty = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_tm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_td = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ts = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_tb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_tt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_safe
            // 
            this.lv_safe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.lv_safe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.date,
            this.text,
            this.safe,
            this.status});
            this.lv_safe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_safe.ForeColor = System.Drawing.Color.Black;
            this.lv_safe.HideSelection = false;
            this.lv_safe.Location = new System.Drawing.Point(30, 80);
            this.lv_safe.Name = "lv_safe";
            this.lv_safe.Size = new System.Drawing.Size(1052, 344);
            this.lv_safe.TabIndex = 40;
            this.lv_safe.UseCompatibleStateImageBehavior = false;
            this.lv_safe.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            // 
            // date
            // 
            this.date.Text = "tarih";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 208;
            // 
            // text
            // 
            this.text.Text = "işlem";
            this.text.Width = 500;
            // 
            // safe
            // 
            this.safe.Text = "safe";
            this.safe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.safe.Width = 136;
            // 
            // status
            // 
            this.status.Text = "durum";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.Width = 144;
            // 
            // dtp_search
            // 
            this.dtp_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_search.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.dtp_search.Location = new System.Drawing.Point(755, 23);
            this.dtp_search.Name = "dtp_search";
            this.dtp_search.Size = new System.Drawing.Size(324, 33);
            this.dtp_search.TabIndex = 43;
            this.dtp_search.ValueChanged += new System.EventHandler(this.dtp_search_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "tarih ara";
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.p1.Location = new System.Drawing.Point(36, 62);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(1046, 5);
            this.p1.TabIndex = 41;
            // 
            // btn_ty
            // 
            this.btn_ty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_ty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.btn_ty.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ty.ForeColor = System.Drawing.Color.White;
            this.btn_ty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ty.Location = new System.Drawing.Point(32, 506);
            this.btn_ty.Name = "btn_ty";
            this.btn_ty.Size = new System.Drawing.Size(177, 50);
            this.btn_ty.TabIndex = 44;
            this.btn_ty.Text = "0";
            this.btn_ty.UseVisualStyleBackColor = false;
            this.btn_ty.Click += new System.EventHandler(this.btn_ty_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "yıllık kazanç";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "aylık kazanç";
            // 
            // btn_tm
            // 
            this.btn_tm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_tm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.btn_tm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tm.ForeColor = System.Drawing.Color.White;
            this.btn_tm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_tm.Location = new System.Drawing.Point(215, 506);
            this.btn_tm.Name = "btn_tm";
            this.btn_tm.Size = new System.Drawing.Size(177, 50);
            this.btn_tm.TabIndex = 46;
            this.btn_tm.Text = "0";
            this.btn_tm.UseVisualStyleBackColor = false;
            this.btn_tm.Click += new System.EventHandler(this.btn_tm_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 49;
            this.label4.Text = "günlük kazanç";
            // 
            // btn_td
            // 
            this.btn_td.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_td.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.btn_td.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_td.ForeColor = System.Drawing.Color.White;
            this.btn_td.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_td.Location = new System.Drawing.Point(398, 506);
            this.btn_td.Name = "btn_td";
            this.btn_td.Size = new System.Drawing.Size(177, 50);
            this.btn_td.TabIndex = 48;
            this.btn_td.Text = "0";
            this.btn_td.UseVisualStyleBackColor = false;
            this.btn_td.Click += new System.EventHandler(this.btn_td_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(745, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 51;
            this.label5.Text = "toplam gelen:";
            // 
            // btn_ts
            // 
            this.btn_ts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.btn_ts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ts.ForeColor = System.Drawing.Color.Green;
            this.btn_ts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_ts.Location = new System.Drawing.Point(905, 439);
            this.btn_ts.Name = "btn_ts";
            this.btn_ts.Size = new System.Drawing.Size(177, 28);
            this.btn_ts.TabIndex = 50;
            this.btn_ts.Text = "0";
            this.btn_ts.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(745, 476);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 25);
            this.label6.TabIndex = 53;
            this.label6.Text = "toplam giden:";
            // 
            // btn_tb
            // 
            this.btn_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.btn_tb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tb.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_tb.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_tb.Location = new System.Drawing.Point(905, 474);
            this.btn_tb.Name = "btn_tb";
            this.btn_tb.Size = new System.Drawing.Size(177, 28);
            this.btn_tb.TabIndex = 52;
            this.btn_tb.Text = "0";
            this.btn_tb.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.panel1.Location = new System.Drawing.Point(733, 508);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 5);
            this.panel1.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(745, 528);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "toplam hesap:";
            // 
            // btn_tt
            // 
            this.btn_tt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.btn_tt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tt.ForeColor = System.Drawing.Color.Black;
            this.btn_tt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_tt.Location = new System.Drawing.Point(905, 519);
            this.btn_tt.Name = "btn_tt";
            this.btn_tt.Size = new System.Drawing.Size(177, 43);
            this.btn_tt.TabIndex = 55;
            this.btn_tt.Text = "0";
            this.btn_tt.UseVisualStyleBackColor = false;
            // 
            // frm_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1112, 574);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_tt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_ts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_td);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_tm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ty);
            this.Controls.Add(this.dtp_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.lv_safe);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frm_account";
            this.Padding = new System.Windows.Forms.Padding(30, 80, 30, 150);
            this.Text = "frm_account";
            this.Load += new System.EventHandler(this.frm_account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_safe;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader text;
        private System.Windows.Forms.DateTimePicker dtp_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.ColumnHeader safe;
        private System.Windows.Forms.ColumnHeader status;
        private System.Windows.Forms.Button btn_ty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_tm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_td;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_tb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_tt;
    }
}