
namespace wonka
{
    partial class frm_sales
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
            this.tc_sell = new System.Windows.Forms.TabControl();
            this.tp_s = new System.Windows.Forms.TabPage();
            this.flp_s = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_s_ok = new System.Windows.Forms.Button();
            this.btn_s_c = new System.Windows.Forms.Button();
            this.btn_s_sc = new System.Windows.Forms.Button();
            this.btn_s_sp = new System.Windows.Forms.Button();
            this.txt_s_ta = new System.Windows.Forms.TextBox();
            this.txt_s_t = new System.Windows.Forms.TextBox();
            this.btn_s_t = new System.Windows.Forms.Button();
            this.txt_s_p = new System.Windows.Forms.TextBox();
            this.txt_s_a = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tp_sh = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_search = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_tt = new System.Windows.Forms.Button();
            this.cb_c = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lv_c = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.client = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.text1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.safe1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tc_sell.SuspendLayout();
            this.tp_s.SuspendLayout();
            this.tp_sh.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_sell
            // 
            this.tc_sell.Controls.Add(this.tp_s);
            this.tc_sell.Controls.Add(this.tp_sh);
            this.tc_sell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_sell.ItemSize = new System.Drawing.Size(200, 30);
            this.tc_sell.Location = new System.Drawing.Point(0, 0);
            this.tc_sell.Margin = new System.Windows.Forms.Padding(0);
            this.tc_sell.Name = "tc_sell";
            this.tc_sell.Padding = new System.Drawing.Point(0, 0);
            this.tc_sell.SelectedIndex = 0;
            this.tc_sell.Size = new System.Drawing.Size(1112, 574);
            this.tc_sell.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tc_sell.TabIndex = 0;
            // 
            // tp_s
            // 
            this.tp_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.tp_s.Controls.Add(this.label1);
            this.tp_s.Controls.Add(this.label2);
            this.tp_s.Controls.Add(this.flp_s);
            this.tp_s.Controls.Add(this.btn_s_ok);
            this.tp_s.Controls.Add(this.btn_s_c);
            this.tp_s.Controls.Add(this.btn_s_sc);
            this.tp_s.Controls.Add(this.btn_s_sp);
            this.tp_s.Controls.Add(this.txt_s_ta);
            this.tp_s.Controls.Add(this.txt_s_t);
            this.tp_s.Controls.Add(this.btn_s_t);
            this.tp_s.Controls.Add(this.txt_s_p);
            this.tp_s.Controls.Add(this.txt_s_a);
            this.tp_s.Controls.Add(this.label4);
            this.tp_s.Controls.Add(this.label11);
            this.tp_s.Location = new System.Drawing.Point(4, 34);
            this.tp_s.Margin = new System.Windows.Forms.Padding(0);
            this.tp_s.Name = "tp_s";
            this.tp_s.Padding = new System.Windows.Forms.Padding(20);
            this.tp_s.Size = new System.Drawing.Size(1104, 536);
            this.tp_s.TabIndex = 0;
            this.tp_s.Text = "ürün sat";
            // 
            // flp_s
            // 
            this.flp_s.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_s.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.flp_s.Location = new System.Drawing.Point(489, 23);
            this.flp_s.Name = "flp_s";
            this.flp_s.Size = new System.Drawing.Size(592, 490);
            this.flp_s.TabIndex = 54;
            // 
            // btn_s_ok
            // 
            this.btn_s_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_s_ok.Enabled = false;
            this.btn_s_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_s_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btn_s_ok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_s_ok.Location = new System.Drawing.Point(231, 469);
            this.btn_s_ok.Name = "btn_s_ok";
            this.btn_s_ok.Size = new System.Drawing.Size(202, 44);
            this.btn_s_ok.TabIndex = 53;
            this.btn_s_ok.Text = "sat";
            this.btn_s_ok.UseVisualStyleBackColor = true;
            this.btn_s_ok.Click += new System.EventHandler(this.btn_s_ok_Click);
            // 
            // btn_s_c
            // 
            this.btn_s_c.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_s_c.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_s_c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btn_s_c.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_s_c.Location = new System.Drawing.Point(23, 469);
            this.btn_s_c.Name = "btn_s_c";
            this.btn_s_c.Size = new System.Drawing.Size(202, 44);
            this.btn_s_c.TabIndex = 52;
            this.btn_s_c.Text = "iptal";
            this.btn_s_c.UseVisualStyleBackColor = true;
            this.btn_s_c.Click += new System.EventHandler(this.btn_s_c_Click);
            // 
            // btn_s_sc
            // 
            this.btn_s_sc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btn_s_sc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_s_sc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.btn_s_sc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_s_sc.Location = new System.Drawing.Point(175, 188);
            this.btn_s_sc.Name = "btn_s_sc";
            this.btn_s_sc.Size = new System.Drawing.Size(229, 32);
            this.btn_s_sc.TabIndex = 51;
            this.btn_s_sc.Text = "müşteri seç";
            this.btn_s_sc.UseVisualStyleBackColor = false;
            this.btn_s_sc.Click += new System.EventHandler(this.btn_s_sc_Click);
            // 
            // btn_s_sp
            // 
            this.btn_s_sp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btn_s_sp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_s_sp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.btn_s_sp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_s_sp.Location = new System.Drawing.Point(175, 143);
            this.btn_s_sp.Name = "btn_s_sp";
            this.btn_s_sp.Size = new System.Drawing.Size(229, 32);
            this.btn_s_sp.TabIndex = 50;
            this.btn_s_sp.Text = "ürün seç";
            this.btn_s_sp.UseVisualStyleBackColor = false;
            this.btn_s_sp.Click += new System.EventHandler(this.btn_s_sp_Click);
            // 
            // txt_s_ta
            // 
            this.txt_s_ta.Enabled = false;
            this.txt_s_ta.Location = new System.Drawing.Point(292, 241);
            this.txt_s_ta.Name = "txt_s_ta";
            this.txt_s_ta.ReadOnly = true;
            this.txt_s_ta.Size = new System.Drawing.Size(112, 33);
            this.txt_s_ta.TabIndex = 49;
            // 
            // txt_s_t
            // 
            this.txt_s_t.Enabled = false;
            this.txt_s_t.Location = new System.Drawing.Point(175, 333);
            this.txt_s_t.Name = "txt_s_t";
            this.txt_s_t.ReadOnly = true;
            this.txt_s_t.Size = new System.Drawing.Size(229, 33);
            this.txt_s_t.TabIndex = 48;
            // 
            // btn_s_t
            // 
            this.btn_s_t.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_s_t.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btn_s_t.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_s_t.Location = new System.Drawing.Point(56, 334);
            this.btn_s_t.Name = "btn_s_t";
            this.btn_s_t.Size = new System.Drawing.Size(113, 32);
            this.btn_s_t.TabIndex = 47;
            this.btn_s_t.Text = "hesapla";
            this.btn_s_t.UseVisualStyleBackColor = true;
            this.btn_s_t.Click += new System.EventHandler(this.btn_s_t_Click);
            // 
            // txt_s_p
            // 
            this.txt_s_p.Enabled = false;
            this.txt_s_p.Location = new System.Drawing.Point(175, 287);
            this.txt_s_p.Name = "txt_s_p";
            this.txt_s_p.ReadOnly = true;
            this.txt_s_p.Size = new System.Drawing.Size(229, 33);
            this.txt_s_p.TabIndex = 46;
            // 
            // txt_s_a
            // 
            this.txt_s_a.Location = new System.Drawing.Point(175, 241);
            this.txt_s_a.Name = "txt_s_a";
            this.txt_s_a.Size = new System.Drawing.Size(112, 33);
            this.txt_s_a.TabIndex = 45;
            this.txt_s_a.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_s_a_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(87, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 43;
            this.label4.Text = "miktar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(108, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 25);
            this.label11.TabIndex = 41;
            this.label11.Text = "fiyat:";
            // 
            // tp_sh
            // 
            this.tp_sh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.tp_sh.Controls.Add(this.lv_c);
            this.tp_sh.Controls.Add(this.label6);
            this.tp_sh.Controls.Add(this.cb_c);
            this.tp_sh.Controls.Add(this.label7);
            this.tp_sh.Controls.Add(this.btn_tt);
            this.tp_sh.Controls.Add(this.dtp_search);
            this.tp_sh.Controls.Add(this.label3);
            this.tp_sh.Location = new System.Drawing.Point(4, 34);
            this.tp_sh.Name = "tp_sh";
            this.tp_sh.Padding = new System.Windows.Forms.Padding(20, 50, 20, 100);
            this.tp_sh.Size = new System.Drawing.Size(1104, 536);
            this.tp_sh.TabIndex = 1;
            this.tp_sh.Text = "satışlar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(105, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "ürün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(78, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "müşteri:";
            // 
            // dtp_search
            // 
            this.dtp_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp_search.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.dtp_search.Location = new System.Drawing.Point(760, 11);
            this.dtp_search.Name = "dtp_search";
            this.dtp_search.Size = new System.Drawing.Size(324, 33);
            this.dtp_search.TabIndex = 46;
            this.dtp_search.ValueChanged += new System.EventHandler(this.dtp_search_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.label3.Location = new System.Drawing.Point(656, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "tarih ara";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.label7.Location = new System.Drawing.Point(656, 474);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 25);
            this.label7.TabIndex = 58;
            this.label7.Text = "toplam hesap:";
            // 
            // btn_tt
            // 
            this.btn_tt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_tt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btn_tt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_tt.ForeColor = System.Drawing.Color.White;
            this.btn_tt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_tt.Location = new System.Drawing.Point(821, 457);
            this.btn_tt.Name = "btn_tt";
            this.btn_tt.Size = new System.Drawing.Size(260, 59);
            this.btn_tt.TabIndex = 57;
            this.btn_tt.Text = "0";
            this.btn_tt.UseVisualStyleBackColor = false;
            // 
            // cb_c
            // 
            this.cb_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.cb_c.FormattingEnabled = true;
            this.cb_c.Location = new System.Drawing.Point(289, 11);
            this.cb_c.Name = "cb_c";
            this.cb_c.Size = new System.Drawing.Size(238, 33);
            this.cb_c.TabIndex = 60;
            this.cb_c.SelectedValueChanged += new System.EventHandler(this.cb_c_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.label6.Location = new System.Drawing.Point(158, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 25);
            this.label6.TabIndex = 61;
            this.label6.Text = "müşteri ara";
            // 
            // lv_c
            // 
            this.lv_c.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.lv_c.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.date,
            this.client,
            this.text1,
            this.safe1});
            this.lv_c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_c.ForeColor = System.Drawing.Color.Black;
            this.lv_c.HideSelection = false;
            this.lv_c.Location = new System.Drawing.Point(20, 50);
            this.lv_c.Name = "lv_c";
            this.lv_c.Size = new System.Drawing.Size(1064, 386);
            this.lv_c.TabIndex = 62;
            this.lv_c.UseCompatibleStateImageBehavior = false;
            this.lv_c.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 17;
            // 
            // date
            // 
            this.date.Text = "tarih";
            this.date.Width = 208;
            // 
            // client
            // 
            this.client.Text = "müşteri adı";
            this.client.Width = 159;
            // 
            // text1
            // 
            this.text1.Text = "işlem";
            this.text1.Width = 493;
            // 
            // safe1
            // 
            this.safe1.Text = "tutar";
            this.safe1.Width = 179;
            // 
            // frm_sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1112, 574);
            this.Controls.Add(this.tc_sell);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frm_sales";
            this.Text = "frm_sales";
            this.Load += new System.EventHandler(this.frm_sales_Load);
            this.tc_sell.ResumeLayout(false);
            this.tp_s.ResumeLayout(false);
            this.tp_s.PerformLayout();
            this.tp_sh.ResumeLayout(false);
            this.tp_sh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_sell;
        private System.Windows.Forms.TabPage tp_s;
        private System.Windows.Forms.TabPage tp_sh;
        private System.Windows.Forms.TextBox txt_s_ta;
        private System.Windows.Forms.TextBox txt_s_t;
        private System.Windows.Forms.Button btn_s_t;
        private System.Windows.Forms.TextBox txt_s_p;
        private System.Windows.Forms.TextBox txt_s_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_s_sc;
        private System.Windows.Forms.Button btn_s_sp;
        private System.Windows.Forms.FlowLayoutPanel flp_s;
        private System.Windows.Forms.Button btn_s_ok;
        private System.Windows.Forms.Button btn_s_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_tt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_c;
        private System.Windows.Forms.ListView lv_c;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader client;
        private System.Windows.Forms.ColumnHeader text1;
        private System.Windows.Forms.ColumnHeader safe1;
    }
}