
namespace wonka
{
    partial class frm_client
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
            this.pnl_mat = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_info = new System.Windows.Forms.Panel();
            this.tc_material = new System.Windows.Forms.TabControl();
            this.tp_e = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_i_a = new System.Windows.Forms.TextBox();
            this.btn_i_c = new System.Windows.Forms.Button();
            this.btn_i_ok = new System.Windows.Forms.Button();
            this.txt_i_e = new System.Windows.Forms.TextBox();
            this.txt_i_t = new System.Windows.Forms.TextBox();
            this.txt_i_n = new System.Windows.Forms.TextBox();
            this.pb_i = new System.Windows.Forms.PictureBox();
            this.lbl_mat_amout = new System.Windows.Forms.Label();
            this.lbl_mat_name = new System.Windows.Forms.Label();
            this.lbl_mat_price = new System.Windows.Forms.Label();
            this.tp_a = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_a_a = new System.Windows.Forms.TextBox();
            this.txt_a_e = new System.Windows.Forms.TextBox();
            this.txt_a_t = new System.Windows.Forms.TextBox();
            this.txt_a_n = new System.Windows.Forms.TextBox();
            this.pb_a = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_a_c = new System.Windows.Forms.Button();
            this.btn_a_ok = new System.Windows.Forms.Button();
            this.addimage = new System.Windows.Forms.OpenFileDialog();
            this.pnl_info.SuspendLayout();
            this.tc_material.SuspendLayout();
            this.tp_e.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_i)).BeginInit();
            this.tp_a.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_a)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_mat
            // 
            this.pnl_mat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_mat.AutoScroll = true;
            this.pnl_mat.Location = new System.Drawing.Point(10, 10);
            this.pnl_mat.Name = "pnl_mat";
            this.pnl_mat.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_mat.Size = new System.Drawing.Size(550, 554);
            this.pnl_mat.TabIndex = 18;
            // 
            // pnl_info
            // 
            this.pnl_info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.pnl_info.Controls.Add(this.tc_material);
            this.pnl_info.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.pnl_info.ForeColor = System.Drawing.Color.White;
            this.pnl_info.Location = new System.Drawing.Point(566, 12);
            this.pnl_info.Name = "pnl_info";
            this.pnl_info.Padding = new System.Windows.Forms.Padding(7);
            this.pnl_info.Size = new System.Drawing.Size(534, 554);
            this.pnl_info.TabIndex = 19;
            // 
            // tc_material
            // 
            this.tc_material.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tc_material.Controls.Add(this.tp_e);
            this.tc_material.Controls.Add(this.tp_a);
            this.tc_material.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_material.Location = new System.Drawing.Point(7, 7);
            this.tc_material.Multiline = true;
            this.tc_material.Name = "tc_material";
            this.tc_material.Padding = new System.Drawing.Point(36, 5);
            this.tc_material.SelectedIndex = 0;
            this.tc_material.Size = new System.Drawing.Size(520, 540);
            this.tc_material.TabIndex = 15;
            // 
            // tp_e
            // 
            this.tp_e.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.tp_e.Controls.Add(this.label8);
            this.tp_e.Controls.Add(this.txt_i_a);
            this.tp_e.Controls.Add(this.btn_i_c);
            this.tp_e.Controls.Add(this.btn_i_ok);
            this.tp_e.Controls.Add(this.txt_i_e);
            this.tp_e.Controls.Add(this.txt_i_t);
            this.tp_e.Controls.Add(this.txt_i_n);
            this.tp_e.Controls.Add(this.pb_i);
            this.tp_e.Controls.Add(this.lbl_mat_amout);
            this.tp_e.Controls.Add(this.lbl_mat_name);
            this.tp_e.Controls.Add(this.lbl_mat_price);
            this.tp_e.Location = new System.Drawing.Point(4, 4);
            this.tp_e.Name = "tp_e";
            this.tp_e.Padding = new System.Windows.Forms.Padding(10);
            this.tp_e.Size = new System.Drawing.Size(478, 532);
            this.tp_e.TabIndex = 2;
            this.tp_e.Text = "bilgi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(97, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "adress:";
            // 
            // txt_i_a
            // 
            this.txt_i_a.Enabled = false;
            this.txt_i_a.Location = new System.Drawing.Point(188, 351);
            this.txt_i_a.Multiline = true;
            this.txt_i_a.Name = "txt_i_a";
            this.txt_i_a.Size = new System.Drawing.Size(220, 106);
            this.txt_i_a.TabIndex = 26;
            // 
            // btn_i_c
            // 
            this.btn_i_c.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_i_c.Enabled = false;
            this.btn_i_c.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_i_c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btn_i_c.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_i_c.Location = new System.Drawing.Point(13, 479);
            this.btn_i_c.Name = "btn_i_c";
            this.btn_i_c.Size = new System.Drawing.Size(214, 40);
            this.btn_i_c.TabIndex = 25;
            this.btn_i_c.Text = "sil";
            this.btn_i_c.UseVisualStyleBackColor = true;
            this.btn_i_c.Click += new System.EventHandler(this.btn_i_c_Click);
            // 
            // btn_i_ok
            // 
            this.btn_i_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_i_ok.Enabled = false;
            this.btn_i_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_i_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btn_i_ok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_i_ok.Location = new System.Drawing.Point(251, 479);
            this.btn_i_ok.Name = "btn_i_ok";
            this.btn_i_ok.Size = new System.Drawing.Size(214, 40);
            this.btn_i_ok.TabIndex = 24;
            this.btn_i_ok.Text = "düzenle";
            this.btn_i_ok.UseVisualStyleBackColor = true;
            this.btn_i_ok.Click += new System.EventHandler(this.btn_i_ok_Click);
            // 
            // txt_i_e
            // 
            this.txt_i_e.Enabled = false;
            this.txt_i_e.Location = new System.Drawing.Point(188, 309);
            this.txt_i_e.Name = "txt_i_e";
            this.txt_i_e.Size = new System.Drawing.Size(220, 31);
            this.txt_i_e.TabIndex = 23;
            // 
            // txt_i_t
            // 
            this.txt_i_t.Enabled = false;
            this.txt_i_t.Location = new System.Drawing.Point(188, 267);
            this.txt_i_t.Name = "txt_i_t";
            this.txt_i_t.Size = new System.Drawing.Size(220, 31);
            this.txt_i_t.TabIndex = 22;
            this.txt_i_t.TextChanged += new System.EventHandler(this.txt_i_t_TextChanged);
            this.txt_i_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_i_t_KeyPress);
            // 
            // txt_i_n
            // 
            this.txt_i_n.Enabled = false;
            this.txt_i_n.Location = new System.Drawing.Point(188, 225);
            this.txt_i_n.Name = "txt_i_n";
            this.txt_i_n.Size = new System.Drawing.Size(220, 31);
            this.txt_i_n.TabIndex = 21;
            // 
            // pb_i
            // 
            this.pb_i.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.pb_i.Enabled = false;
            this.pb_i.Image = global::wonka.Properties.Resources.logo;
            this.pb_i.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pb_i.Location = new System.Drawing.Point(242, 13);
            this.pb_i.Name = "pb_i";
            this.pb_i.Size = new System.Drawing.Size(166, 194);
            this.pb_i.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_i.TabIndex = 20;
            this.pb_i.TabStop = false;
            // 
            // lbl_mat_amout
            // 
            this.lbl_mat_amout.AutoSize = true;
            this.lbl_mat_amout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.lbl_mat_amout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_mat_amout.Location = new System.Drawing.Point(94, 270);
            this.lbl_mat_amout.Name = "lbl_mat_amout";
            this.lbl_mat_amout.Size = new System.Drawing.Size(78, 23);
            this.lbl_mat_amout.TabIndex = 19;
            this.lbl_mat_amout.Text = "telefon:";
            // 
            // lbl_mat_name
            // 
            this.lbl_mat_name.AutoSize = true;
            this.lbl_mat_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.lbl_mat_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_mat_name.Location = new System.Drawing.Point(69, 228);
            this.lbl_mat_name.Name = "lbl_mat_name";
            this.lbl_mat_name.Size = new System.Drawing.Size(103, 23);
            this.lbl_mat_name.TabIndex = 18;
            this.lbl_mat_name.Text = "ad soyad:";
            // 
            // lbl_mat_price
            // 
            this.lbl_mat_price.AutoSize = true;
            this.lbl_mat_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.lbl_mat_price.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_mat_price.Location = new System.Drawing.Point(85, 312);
            this.lbl_mat_price.Name = "lbl_mat_price";
            this.lbl_mat_price.Size = new System.Drawing.Size(87, 23);
            this.lbl_mat_price.TabIndex = 17;
            this.lbl_mat_price.Text = "e-posta:";
            // 
            // tp_a
            // 
            this.tp_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(230)))));
            this.tp_a.Controls.Add(this.label1);
            this.tp_a.Controls.Add(this.txt_a_a);
            this.tp_a.Controls.Add(this.txt_a_e);
            this.tp_a.Controls.Add(this.txt_a_t);
            this.tp_a.Controls.Add(this.txt_a_n);
            this.tp_a.Controls.Add(this.pb_a);
            this.tp_a.Controls.Add(this.label2);
            this.tp_a.Controls.Add(this.label3);
            this.tp_a.Controls.Add(this.label4);
            this.tp_a.Controls.Add(this.btn_a_c);
            this.tp_a.Controls.Add(this.btn_a_ok);
            this.tp_a.Location = new System.Drawing.Point(4, 4);
            this.tp_a.Name = "tp_a";
            this.tp_a.Padding = new System.Windows.Forms.Padding(10);
            this.tp_a.Size = new System.Drawing.Size(478, 532);
            this.tp_a.TabIndex = 0;
            this.tp_a.Text = "ekle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(97, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 36;
            this.label1.Text = "adress:";
            // 
            // txt_a_a
            // 
            this.txt_a_a.Location = new System.Drawing.Point(188, 351);
            this.txt_a_a.Multiline = true;
            this.txt_a_a.Name = "txt_a_a";
            this.txt_a_a.Size = new System.Drawing.Size(220, 106);
            this.txt_a_a.TabIndex = 35;
            // 
            // txt_a_e
            // 
            this.txt_a_e.Location = new System.Drawing.Point(188, 309);
            this.txt_a_e.Name = "txt_a_e";
            this.txt_a_e.Size = new System.Drawing.Size(220, 31);
            this.txt_a_e.TabIndex = 34;
            // 
            // txt_a_t
            // 
            this.txt_a_t.Location = new System.Drawing.Point(188, 267);
            this.txt_a_t.Name = "txt_a_t";
            this.txt_a_t.Size = new System.Drawing.Size(220, 31);
            this.txt_a_t.TabIndex = 33;
            this.txt_a_t.TextChanged += new System.EventHandler(this.txt_a_t_TextChanged);
            this.txt_a_t.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_a_t_KeyPress);
            // 
            // txt_a_n
            // 
            this.txt_a_n.Location = new System.Drawing.Point(188, 225);
            this.txt_a_n.Name = "txt_a_n";
            this.txt_a_n.Size = new System.Drawing.Size(220, 31);
            this.txt_a_n.TabIndex = 32;
            // 
            // pb_a
            // 
            this.pb_a.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.pb_a.Image = global::wonka.Properties.Resources.logo;
            this.pb_a.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pb_a.Location = new System.Drawing.Point(242, 13);
            this.pb_a.Name = "pb_a";
            this.pb_a.Size = new System.Drawing.Size(166, 194);
            this.pb_a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_a.TabIndex = 31;
            this.pb_a.TabStop = false;
            this.pb_a.Click += new System.EventHandler(this.pb_a_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(94, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(69, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "ad soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(85, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "e-posta:";
            // 
            // btn_a_c
            // 
            this.btn_a_c.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_a_c.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_a_c.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btn_a_c.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_a_c.Location = new System.Drawing.Point(13, 479);
            this.btn_a_c.Name = "btn_a_c";
            this.btn_a_c.Size = new System.Drawing.Size(214, 40);
            this.btn_a_c.TabIndex = 22;
            this.btn_a_c.Text = "iptal";
            this.btn_a_c.UseVisualStyleBackColor = true;
            this.btn_a_c.Click += new System.EventHandler(this.btn_a_c_Click);
            // 
            // btn_a_ok
            // 
            this.btn_a_ok.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_a_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_a_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.btn_a_ok.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_a_ok.Location = new System.Drawing.Point(251, 479);
            this.btn_a_ok.Name = "btn_a_ok";
            this.btn_a_ok.Size = new System.Drawing.Size(214, 40);
            this.btn_a_ok.TabIndex = 21;
            this.btn_a_ok.Text = "ekle";
            this.btn_a_ok.UseVisualStyleBackColor = true;
            this.btn_a_ok.Click += new System.EventHandler(this.btn_a_ok_Click);
            // 
            // addimage
            // 
            this.addimage.FileName = "openFileDialog1";
            // 
            // frm_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1112, 574);
            this.Controls.Add(this.pnl_mat);
            this.Controls.Add(this.pnl_info);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frm_client";
            this.Text = "frm_client";
            this.Load += new System.EventHandler(this.frm_client_Load);
            this.pnl_info.ResumeLayout(false);
            this.tc_material.ResumeLayout(false);
            this.tp_e.ResumeLayout(false);
            this.tp_e.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_i)).EndInit();
            this.tp_a.ResumeLayout(false);
            this.tp_a.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_a)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnl_mat;
        private System.Windows.Forms.Panel pnl_info;
        private System.Windows.Forms.TabControl tc_material;
        private System.Windows.Forms.TabPage tp_e;
        private System.Windows.Forms.Button btn_i_c;
        private System.Windows.Forms.Button btn_i_ok;
        private System.Windows.Forms.TextBox txt_i_e;
        private System.Windows.Forms.TextBox txt_i_t;
        private System.Windows.Forms.TextBox txt_i_n;
        private System.Windows.Forms.PictureBox pb_i;
        private System.Windows.Forms.Label lbl_mat_amout;
        private System.Windows.Forms.Label lbl_mat_name;
        private System.Windows.Forms.Label lbl_mat_price;
        private System.Windows.Forms.TabPage tp_a;
        private System.Windows.Forms.Button btn_a_c;
        private System.Windows.Forms.Button btn_a_ok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_i_a;
        private System.Windows.Forms.OpenFileDialog addimage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_a_a;
        private System.Windows.Forms.TextBox txt_a_e;
        private System.Windows.Forms.TextBox txt_a_t;
        private System.Windows.Forms.TextBox txt_a_n;
        private System.Windows.Forms.PictureBox pb_a;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}