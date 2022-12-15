
namespace wonka
{
    partial class app
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(app));
            this.pnl_top = new System.Windows.Forms.Panel();
            this.p1 = new System.Windows.Forms.Panel();
            this.pnl_time = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pnl_left = new System.Windows.Forms.Panel();
            this.btn_staff = new System.Windows.Forms.Button();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_client = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.btn_materials = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_fill = new System.Windows.Forms.Panel();
            this.pnl_top.SuspendLayout();
            this.pnl_time.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnl_left.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.pnl_top.Controls.Add(this.p1);
            this.pnl_top.Controls.Add(this.pnl_time);
            this.pnl_top.Controls.Add(this.user);
            this.pnl_top.Controls.Add(this.exit);
            this.pnl_top.Controls.Add(this.logo);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(10, 10);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(1364, 147);
            this.pnl_top.TabIndex = 0;
            // 
            // p1
            // 
            this.p1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.p1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p1.Location = new System.Drawing.Point(0, 142);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(1364, 5);
            this.p1.TabIndex = 33;
            // 
            // pnl_time
            // 
            this.pnl_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_time.Controls.Add(this.lbl_time);
            this.pnl_time.Location = new System.Drawing.Point(905, 32);
            this.pnl_time.Name = "pnl_time";
            this.pnl_time.Size = new System.Drawing.Size(421, 80);
            this.pnl_time.TabIndex = 8;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(190)))), ((int)(((byte)(255)))));
            this.lbl_time.Location = new System.Drawing.Point(25, 24);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(77, 36);
            this.lbl_time.TabIndex = 0;
            this.lbl_time.Text = "time";
            // 
            // user
            // 
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Image = ((System.Drawing.Image)(resources.GetObject("user.Image")));
            this.user.Location = new System.Drawing.Point(335, 32);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(70, 70);
            this.user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.user.TabIndex = 7;
            this.user.TabStop = false;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(460, 32);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(70, 70);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exit.TabIndex = 6;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // logo
            // 
            this.logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Image = global::wonka.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(252, 147);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 5;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.logo_Click);
            // 
            // pnl_left
            // 
            this.pnl_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.pnl_left.Controls.Add(this.btn_staff);
            this.pnl_left.Controls.Add(this.btn_account);
            this.pnl_left.Controls.Add(this.btn_client);
            this.pnl_left.Controls.Add(this.btn_sales);
            this.pnl_left.Controls.Add(this.btn_materials);
            this.pnl_left.Controls.Add(this.btn_main);
            this.pnl_left.Controls.Add(this.panel1);
            this.pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_left.Location = new System.Drawing.Point(10, 157);
            this.pnl_left.Name = "pnl_left";
            this.pnl_left.Size = new System.Drawing.Size(252, 574);
            this.pnl_left.TabIndex = 1;
            // 
            // btn_staff
            // 
            this.btn_staff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btn_staff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_staff.ForeColor = System.Drawing.Color.White;
            this.btn_staff.Location = new System.Drawing.Point(0, 295);
            this.btn_staff.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_staff.Name = "btn_staff";
            this.btn_staff.Size = new System.Drawing.Size(247, 59);
            this.btn_staff.TabIndex = 8;
            this.btn_staff.Text = "kullanıcılar";
            this.btn_staff.UseVisualStyleBackColor = false;
            this.btn_staff.Visible = false;
            this.btn_staff.Click += new System.EventHandler(this.btn_staff_Click);
            // 
            // btn_account
            // 
            this.btn_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btn_account.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.ForeColor = System.Drawing.Color.White;
            this.btn_account.Location = new System.Drawing.Point(0, 236);
            this.btn_account.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(247, 59);
            this.btn_account.TabIndex = 7;
            this.btn_account.Text = "hesap";
            this.btn_account.UseVisualStyleBackColor = false;
            this.btn_account.Click += new System.EventHandler(this.btn_account_Click);
            // 
            // btn_client
            // 
            this.btn_client.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btn_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.ForeColor = System.Drawing.Color.White;
            this.btn_client.Location = new System.Drawing.Point(0, 177);
            this.btn_client.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_client.Name = "btn_client";
            this.btn_client.Size = new System.Drawing.Size(247, 59);
            this.btn_client.TabIndex = 6;
            this.btn_client.Text = "müşteriler";
            this.btn_client.UseVisualStyleBackColor = false;
            this.btn_client.Visible = false;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btn_sales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sales.ForeColor = System.Drawing.Color.White;
            this.btn_sales.Location = new System.Drawing.Point(0, 118);
            this.btn_sales.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(247, 59);
            this.btn_sales.TabIndex = 5;
            this.btn_sales.Text = "satış";
            this.btn_sales.UseVisualStyleBackColor = false;
            this.btn_sales.Visible = false;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_materials
            // 
            this.btn_materials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btn_materials.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_materials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_materials.ForeColor = System.Drawing.Color.White;
            this.btn_materials.Location = new System.Drawing.Point(0, 59);
            this.btn_materials.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_materials.Name = "btn_materials";
            this.btn_materials.Size = new System.Drawing.Size(247, 59);
            this.btn_materials.TabIndex = 3;
            this.btn_materials.Text = "ürünler";
            this.btn_materials.UseVisualStyleBackColor = false;
            this.btn_materials.Visible = false;
            this.btn_materials.Click += new System.EventHandler(this.btn_materials_Click);
            // 
            // btn_main
            // 
            this.btn_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.btn_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main.ForeColor = System.Drawing.Color.White;
            this.btn_main.Location = new System.Drawing.Point(0, 0);
            this.btn_main.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(247, 59);
            this.btn_main.TabIndex = 1;
            this.btn_main.Text = "anasayfa";
            this.btn_main.UseVisualStyleBackColor = false;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(160)))), ((int)(((byte)(250)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(247, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 574);
            this.panel1.TabIndex = 34;
            // 
            // pnl_fill
            // 
            this.pnl_fill.AutoSize = true;
            this.pnl_fill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(37)))), ((int)(((byte)(60)))));
            this.pnl_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_fill.Location = new System.Drawing.Point(262, 157);
            this.pnl_fill.Name = "pnl_fill";
            this.pnl_fill.Size = new System.Drawing.Size(1112, 574);
            this.pnl_fill.TabIndex = 2;
            // 
            // app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1384, 741);
            this.Controls.Add(this.pnl_fill);
            this.Controls.Add(this.pnl_left);
            this.Controls.Add(this.pnl_top);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(1400, 780);
            this.Name = "app";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wonka Chocolate";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.app_FormClosed);
            this.Load += new System.EventHandler(this.app_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_time.ResumeLayout(false);
            this.pnl_time.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnl_left.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.Panel pnl_fill;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel pnl_time;
        private System.Windows.Forms.PictureBox user;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Panel p1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_staff;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btn_client;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Button btn_materials;
        private System.Windows.Forms.Button btn_main;
    }
}