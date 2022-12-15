
namespace wonka
{
    partial class frm_main
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
            this.p1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_search = new System.Windows.Forms.DateTimePicker();
            this.lv_daily = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.text = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // p1
            // 
            this.p1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.p1.Location = new System.Drawing.Point(33, 73);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(1046, 5);
            this.p1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(651, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "tarih ara";
            // 
            // dtp_search
            // 
            this.dtp_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_search.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.dtp_search.Location = new System.Drawing.Point(755, 12);
            this.dtp_search.Name = "dtp_search";
            this.dtp_search.Size = new System.Drawing.Size(324, 33);
            this.dtp_search.TabIndex = 38;
            this.dtp_search.ValueChanged += new System.EventHandler(this.dtp_search_ValueChanged);
            // 
            // lv_daily
            // 
            this.lv_daily.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.lv_daily.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.date,
            this.text});
            this.lv_daily.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_daily.HideSelection = false;
            this.lv_daily.Location = new System.Drawing.Point(30, 100);
            this.lv_daily.Name = "lv_daily";
            this.lv_daily.Size = new System.Drawing.Size(1052, 444);
            this.lv_daily.TabIndex = 39;
            this.lv_daily.UseCompatibleStateImageBehavior = false;
            this.lv_daily.View = System.Windows.Forms.View.Details;
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
            this.text.Width = 772;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1112, 574);
            this.Controls.Add(this.lv_daily);
            this.Controls.Add(this.dtp_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frm_main";
            this.Padding = new System.Windows.Forms.Padding(30, 100, 30, 30);
            this.Text = "frm_main";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_search;
        private System.Windows.Forms.ListView lv_daily;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader text;
    }
}