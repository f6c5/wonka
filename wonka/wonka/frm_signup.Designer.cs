
namespace wonka
{
    partial class frm_signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_signup));
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.lbl_age = new System.Windows.Forms.Label();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_pas = new System.Windows.Forms.Label();
            this.txt_uname = new System.Windows.Forms.TextBox();
            this.lbl_uname = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.line = new System.Windows.Forms.Panel();
            this.lbl_pp = new System.Windows.Forms.Label();
            this.pnl_gender = new System.Windows.Forms.Panel();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.lbl_dep = new System.Windows.Forms.Label();
            this.cb_sales = new System.Windows.Forms.CheckBox();
            this.cb_prod = new System.Windows.Forms.CheckBox();
            this.addimage = new System.Windows.Forms.OpenFileDialog();
            this.e0 = new System.Windows.Forms.Label();
            this.e3 = new System.Windows.Forms.Label();
            this.e5 = new System.Windows.Forms.Label();
            this.e6 = new System.Windows.Forms.Label();
            this.e7 = new System.Windows.Forms.Label();
            this.pb_pp = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.e1 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.e2 = new System.Windows.Forms.Label();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.e4 = new System.Windows.Forms.Label();
            this.txt_pass2 = new System.Windows.Forms.TextBox();
            this.lbl_pass2 = new System.Windows.Forms.Label();
            this.pnl_gender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(292, 584);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(264, 33);
            this.txt_mail.TabIndex = 3;
            this.txt_mail.TextChanged += new System.EventHandler(this.txt_mail_TextChanged);
            this.txt_mail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mail_KeyDown);
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.ForeColor = System.Drawing.Color.White;
            this.lbl_mail.Location = new System.Drawing.Point(141, 587);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(96, 25);
            this.lbl_mail.TabIndex = 26;
            this.lbl_mail.Text = "e-posta:";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(292, 523);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(264, 33);
            this.txt_age.TabIndex = 2;
            this.txt_age.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_age_KeyDown);
            this.txt_age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_age_KeyPress);
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.ForeColor = System.Drawing.Color.White;
            this.lbl_age.Location = new System.Drawing.Point(184, 526);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(53, 25);
            this.lbl_age.TabIndex = 24;
            this.lbl_age.Text = "yaş:";
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.ForeColor = System.Drawing.Color.White;
            this.rb_male.Location = new System.Drawing.Point(193, 8);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(87, 29);
            this.rb_male.TabIndex = 5;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "erkek";
            this.rb_male.UseVisualStyleBackColor = true;
            this.rb_male.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_male_KeyDown);
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.ForeColor = System.Drawing.Color.White;
            this.rb_female.Location = new System.Drawing.Point(16, 8);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(88, 29);
            this.rb_female.TabIndex = 4;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "kadın";
            this.rb_female.UseVisualStyleBackColor = true;
            this.rb_female.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rb_female_KeyDown);
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.ForeColor = System.Drawing.Color.White;
            this.lbl_gender.Location = new System.Drawing.Point(143, 652);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(94, 25);
            this.lbl_gender.TabIndex = 21;
            this.lbl_gender.Text = "cinsiyet:";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(292, 401);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(264, 33);
            this.txt_pass.TabIndex = 1;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            this.txt_pass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_KeyDown);
            // 
            // lbl_pas
            // 
            this.lbl_pas.AutoSize = true;
            this.lbl_pas.ForeColor = System.Drawing.Color.White;
            this.lbl_pas.Location = new System.Drawing.Point(179, 404);
            this.lbl_pas.Name = "lbl_pas";
            this.lbl_pas.Size = new System.Drawing.Size(58, 25);
            this.lbl_pas.TabIndex = 19;
            this.lbl_pas.Text = "şifre:";
            // 
            // txt_uname
            // 
            this.txt_uname.Location = new System.Drawing.Point(292, 218);
            this.txt_uname.Name = "txt_uname";
            this.txt_uname.Size = new System.Drawing.Size(264, 33);
            this.txt_uname.TabIndex = 0;
            this.txt_uname.TextChanged += new System.EventHandler(this.txt_uname_TextChanged);
            this.txt_uname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_uname_KeyDown);
            // 
            // lbl_uname
            // 
            this.lbl_uname.AutoSize = true;
            this.lbl_uname.ForeColor = System.Drawing.Color.White;
            this.lbl_uname.Location = new System.Drawing.Point(95, 221);
            this.lbl_uname.Name = "lbl_uname";
            this.lbl_uname.Size = new System.Drawing.Size(142, 25);
            this.lbl_uname.TabIndex = 17;
            this.lbl_uname.Text = "kullanıcı adı:";
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(636, 753);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(223, 41);
            this.btn_register.TabIndex = 11;
            this.btn_register.Text = "kaydol";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(299, 753);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(223, 41);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "iptal";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(90)))), ((int)(((byte)(180)))));
            this.line.Location = new System.Drawing.Point(84, 158);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(1000, 5);
            this.line.TabIndex = 33;
            // 
            // lbl_pp
            // 
            this.lbl_pp.AutoSize = true;
            this.lbl_pp.ForeColor = System.Drawing.Color.White;
            this.lbl_pp.Location = new System.Drawing.Point(679, 213);
            this.lbl_pp.Name = "lbl_pp";
            this.lbl_pp.Size = new System.Drawing.Size(158, 25);
            this.lbl_pp.TabIndex = 35;
            this.lbl_pp.Text = "profil fotoğrafı:";
            // 
            // pnl_gender
            // 
            this.pnl_gender.Controls.Add(this.rb_male);
            this.pnl_gender.Controls.Add(this.rb_female);
            this.pnl_gender.Location = new System.Drawing.Point(276, 642);
            this.pnl_gender.Name = "pnl_gender";
            this.pnl_gender.Size = new System.Drawing.Size(298, 49);
            this.pnl_gender.TabIndex = 4;
            // 
            // lbl_adress
            // 
            this.lbl_adress.AutoSize = true;
            this.lbl_adress.ForeColor = System.Drawing.Color.White;
            this.lbl_adress.Location = new System.Drawing.Point(679, 410);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(75, 25);
            this.lbl_adress.TabIndex = 37;
            this.lbl_adress.Text = "adres:";
            // 
            // txt_adress
            // 
            this.txt_adress.Location = new System.Drawing.Point(787, 407);
            this.txt_adress.Multiline = true;
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.Size = new System.Drawing.Size(297, 140);
            this.txt_adress.TabIndex = 6;
            this.txt_adress.TextChanged += new System.EventHandler(this.txt_adress_TextChanged);
            this.txt_adress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_adress_KeyDown);
            // 
            // lbl_dep
            // 
            this.lbl_dep.AutoSize = true;
            this.lbl_dep.ForeColor = System.Drawing.Color.White;
            this.lbl_dep.Location = new System.Drawing.Point(679, 587);
            this.lbl_dep.Name = "lbl_dep";
            this.lbl_dep.Size = new System.Drawing.Size(215, 25);
            this.lbl_dep.TabIndex = 39;
            this.lbl_dep.Text = "çalıştığı departman:";
            // 
            // cb_sales
            // 
            this.cb_sales.AutoSize = true;
            this.cb_sales.Location = new System.Drawing.Point(978, 588);
            this.cb_sales.Name = "cb_sales";
            this.cb_sales.Size = new System.Drawing.Size(74, 29);
            this.cb_sales.TabIndex = 8;
            this.cb_sales.Text = "satış";
            this.cb_sales.UseVisualStyleBackColor = true;
            this.cb_sales.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_sales_KeyDown);
            // 
            // cb_prod
            // 
            this.cb_prod.AutoSize = true;
            this.cb_prod.Location = new System.Drawing.Point(978, 623);
            this.cb_prod.Name = "cb_prod";
            this.cb_prod.Size = new System.Drawing.Size(95, 29);
            this.cb_prod.TabIndex = 9;
            this.cb_prod.Text = "üretim";
            this.cb_prod.UseVisualStyleBackColor = true;
            this.cb_prod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_prod_KeyDown);
            // 
            // addimage
            // 
            this.addimage.FileName = "openFileDialog1";
            // 
            // e0
            // 
            this.e0.AutoSize = true;
            this.e0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.e0.Location = new System.Drawing.Point(562, 218);
            this.e0.Name = "e0";
            this.e0.Size = new System.Drawing.Size(21, 25);
            this.e0.TabIndex = 45;
            this.e0.Text = "*";
            this.e0.Visible = false;
            // 
            // e3
            // 
            this.e3.AutoSize = true;
            this.e3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.e3.Location = new System.Drawing.Point(562, 401);
            this.e3.Name = "e3";
            this.e3.Size = new System.Drawing.Size(21, 25);
            this.e3.TabIndex = 46;
            this.e3.Text = "*";
            this.e3.Visible = false;
            // 
            // e5
            // 
            this.e5.AutoSize = true;
            this.e5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.e5.Location = new System.Drawing.Point(562, 584);
            this.e5.Name = "e5";
            this.e5.Size = new System.Drawing.Size(21, 25);
            this.e5.TabIndex = 47;
            this.e5.Text = "*";
            this.e5.Visible = false;
            // 
            // e6
            // 
            this.e6.AutoSize = true;
            this.e6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.e6.Location = new System.Drawing.Point(900, 587);
            this.e6.Name = "e6";
            this.e6.Size = new System.Drawing.Size(21, 25);
            this.e6.TabIndex = 48;
            this.e6.Text = "*";
            this.e6.Visible = false;
            // 
            // e7
            // 
            this.e7.AutoSize = true;
            this.e7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.e7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.e7.Location = new System.Drawing.Point(633, 733);
            this.e7.Name = "e7";
            this.e7.Size = new System.Drawing.Size(204, 17);
            this.e7.TabIndex = 50;
            this.e7.Text = "seçili alanlar boş bırakılamaz *";
            this.e7.Visible = false;
            // 
            // pb_pp
            // 
            this.pb_pp.BackColor = System.Drawing.Color.Transparent;
            this.pb_pp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_pp.Image = global::wonka.Properties.Resources.profile_2_;
            this.pb_pp.Location = new System.Drawing.Point(936, 213);
            this.pb_pp.Name = "pb_pp";
            this.pb_pp.Size = new System.Drawing.Size(144, 160);
            this.pb_pp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_pp.TabIndex = 34;
            this.pb_pp.TabStop = false;
            this.pb_pp.Click += new System.EventHandler(this.pb_pp_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Image = global::wonka.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(1164, 163);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 30;
            this.logo.TabStop = false;
            // 
            // e1
            // 
            this.e1.AutoSize = true;
            this.e1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.e1.Location = new System.Drawing.Point(562, 279);
            this.e1.Name = "e1";
            this.e1.Size = new System.Drawing.Size(21, 25);
            this.e1.TabIndex = 53;
            this.e1.Text = "*";
            this.e1.Visible = false;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(292, 279);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(264, 33);
            this.txt_name.TabIndex = 51;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            this.txt_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyDown);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(186, 282);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(51, 25);
            this.lbl_name.TabIndex = 52;
            this.lbl_name.Text = "adı:";
            // 
            // e2
            // 
            this.e2.AutoSize = true;
            this.e2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.e2.Location = new System.Drawing.Point(562, 340);
            this.e2.Name = "e2";
            this.e2.Size = new System.Drawing.Size(21, 25);
            this.e2.TabIndex = 56;
            this.e2.Text = "*";
            this.e2.Visible = false;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(292, 340);
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(264, 33);
            this.txt_surname.TabIndex = 54;
            this.txt_surname.TextChanged += new System.EventHandler(this.txt_surname_TextChanged);
            this.txt_surname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_surname_KeyDown);
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.ForeColor = System.Drawing.Color.White;
            this.lbl_surname.Location = new System.Drawing.Point(152, 343);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(85, 25);
            this.lbl_surname.TabIndex = 55;
            this.lbl_surname.Text = "soyadı:";
            // 
            // e4
            // 
            this.e4.AutoSize = true;
            this.e4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(180)))), ((int)(((byte)(254)))));
            this.e4.Location = new System.Drawing.Point(562, 462);
            this.e4.Name = "e4";
            this.e4.Size = new System.Drawing.Size(21, 25);
            this.e4.TabIndex = 59;
            this.e4.Text = "*";
            this.e4.Visible = false;
            // 
            // txt_pass2
            // 
            this.txt_pass2.Location = new System.Drawing.Point(292, 462);
            this.txt_pass2.Name = "txt_pass2";
            this.txt_pass2.PasswordChar = '*';
            this.txt_pass2.Size = new System.Drawing.Size(264, 33);
            this.txt_pass2.TabIndex = 57;
            this.txt_pass2.TextChanged += new System.EventHandler(this.txt_pass2_TextChanged);
            this.txt_pass2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass2_KeyDown);
            // 
            // lbl_pass2
            // 
            this.lbl_pass2.AutoSize = true;
            this.lbl_pass2.ForeColor = System.Drawing.Color.White;
            this.lbl_pass2.Location = new System.Drawing.Point(59, 465);
            this.lbl_pass2.Name = "lbl_pass2";
            this.lbl_pass2.Size = new System.Drawing.Size(178, 25);
            this.lbl_pass2.TabIndex = 58;
            this.lbl_pass2.Text = "şifre doğrulama:";
            // 
            // frm_signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1164, 821);
            this.Controls.Add(this.e4);
            this.Controls.Add(this.txt_pass2);
            this.Controls.Add(this.lbl_pass2);
            this.Controls.Add(this.e2);
            this.Controls.Add(this.txt_surname);
            this.Controls.Add(this.lbl_surname);
            this.Controls.Add(this.e1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.e7);
            this.Controls.Add(this.e6);
            this.Controls.Add(this.e5);
            this.Controls.Add(this.e3);
            this.Controls.Add(this.e0);
            this.Controls.Add(this.cb_sales);
            this.Controls.Add(this.cb_prod);
            this.Controls.Add(this.lbl_dep);
            this.Controls.Add(this.txt_adress);
            this.Controls.Add(this.lbl_adress);
            this.Controls.Add(this.pnl_gender);
            this.Controls.Add(this.lbl_pp);
            this.Controls.Add(this.pb_pp);
            this.Controls.Add(this.line);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_mail);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.lbl_age);
            this.Controls.Add(this.lbl_gender);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbl_pas);
            this.Controls.Add(this.txt_uname);
            this.Controls.Add(this.lbl_uname);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "frm_signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "wonka";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_signup_FormClosed);
            this.Load += new System.EventHandler(this.frm_signup_Load);
            this.pnl_gender.ResumeLayout(false);
            this.pnl_gender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.RadioButton rb_male;
        private System.Windows.Forms.RadioButton rb_female;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_pas;
        private System.Windows.Forms.TextBox txt_uname;
        private System.Windows.Forms.Label lbl_uname;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.PictureBox pb_pp;
        private System.Windows.Forms.Label lbl_pp;
        private System.Windows.Forms.Panel pnl_gender;
        private System.Windows.Forms.Label lbl_adress;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Label lbl_dep;
        private System.Windows.Forms.CheckBox cb_sales;
        private System.Windows.Forms.CheckBox cb_prod;
        private System.Windows.Forms.OpenFileDialog addimage;
        private System.Windows.Forms.Label e0;
        private System.Windows.Forms.Label e3;
        private System.Windows.Forms.Label e5;
        private System.Windows.Forms.Label e6;
        private System.Windows.Forms.Label e7;
        private System.Windows.Forms.Label e1;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label e2;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label e4;
        private System.Windows.Forms.TextBox txt_pass2;
        private System.Windows.Forms.Label lbl_pass2;
    }
}