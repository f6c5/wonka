using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wonka
{
    public partial class frm_staff : Form
    {
        public frm_staff()
        {
            InitializeComponent();
        }

        private void frm_staff_Load(object sender, EventArgs e)
        {
            start();
        }

        byte[] data;

        private void start()
        {
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_employee", connection);
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                if (app.suser_id != Convert.ToInt32(read["id"]))
                {
                    data = new byte[0];
                    data = (byte[])(read["pp"]);
                    MemoryStream mem = new MemoryStream(data);
                    Button btn = new Button();
                    btn.Size = new Size(150, 200);
                    btn.Name = read["id"].ToString();
                    btn.Text = read["uname"].ToString();
                    btn.ForeColor = Color.White;
                    btn.Padding = new Padding(10);
                    btn.TextAlign = ContentAlignment.BottomCenter;
                    btn.BackgroundImage = Image.FromStream(mem);
                    btn.BackgroundImageLayout = ImageLayout.Zoom;
                    btn.BackColor = Color.FromArgb(160, 180, 230);
                    pnl_staff.Controls.Add(btn);
                    btn.Click += new EventHandler(btn_Click);
                }
            }
            read.Close();
            connection.Close();
        }
        int ss;
        int sd;
        private void btn_Click(object sender, EventArgs e)
        {
            ss = Convert.ToInt32(((Button)sender).Name);
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_employee ", connection);
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                if (Convert.ToInt32(((Button)sender).Name) == Convert.ToInt32(read["id"]))
                {
                    data = new byte[0];
                    data = (byte[])(read["pp"]);
                    MemoryStream mem = new MemoryStream(data);
                    pb_pp.Image = Image.FromStream(mem);
                    txt_uname.Text = read["uname"].ToString();
                    txt_name.Text = read["name"].ToString();
                    txt_surname.Text = read["surname"].ToString();
                    txt_pass.Text = read["pass"].ToString();
                    lage.Text = read["age"].ToString();
                    txt_mail.Text = read["email"].ToString();
                    lgender.Text = read["gender"].ToString();
                    txt_adress.Text = read["adress"].ToString();
                    sd = Convert.ToInt32(read["dep"]);
                    if (sd / 100 == 1)
                    {
                        ldep.Text = "yönetim ";
                    }
                    else
                    {
                        if ((Convert.ToInt32(read["dep"]) % 100) / 10 == 1)
                        {
                            ldep.Text = "satış ";
                        }
                        if (Convert.ToInt32(read["dep"]) % 10 == 1)
                        {
                            ldep.Text += "üretim ";
                        }
                    }
                    ldep.Text += "görevlisi";
                    if (Convert.ToInt32(read["dep"]) / 100 == 1)
                    {
                        set_dep.Text = "yetkisini al";
                    }
                    else
                    {
                        set_dep.Text = "yönetici yap";
                    }
                    break;
                }
            }
            read.Close();
            connection.Close();
        }

        private void del_staff_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("kaydını silmek istediğinizden emin misiniz ?!!", "dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                connect();
                SqlCommand com2 = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);

                com2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                com2.Parameters.AddWithValue("@text", "kullanıcı adı " + txt_uname.Text + " olan " + txt_name.Text + " " + txt_surname.Text + " kaydı silinmiştir");
                com2.ExecuteNonQuery();

                SqlCommand com = new SqlCommand("delete from tbl_employee where id=" + ss + "", connection);
                SqlDataReader read = com.ExecuteReader();

                connection.Close();

                MessageBox.Show("kaydı silinmiştir.", "gülegüle...", MessageBoxButtons.OK);
            }
        }

        private void add_satff_Click(object sender, EventArgs e)
        {
            frm_signup.add = 2;
            frm_signup reg = new frm_signup();
            reg.Show();
        }

        private void set_dep_Click(object sender, EventArgs e)
        {
            connect();
            if (sd != 100)
            {
                SqlCommand sqlcom = new SqlCommand("update tbl_employee set dep='" + 100 + "'  where id=" + ss + " ", connection);
                MessageBox.Show("yönetici olarak ayarladınız.");
                sqlcom.ExecuteNonQuery();
            }
            else
            {
                SqlCommand sqlcom = new SqlCommand("update tbl_employee set dep='" + 11 + "'  where id=" + ss + " ", connection);
                MessageBox.Show("yönetici yetkisini aldınız.");
                sqlcom.ExecuteNonQuery();
            }
            connection.Close();
        }

        SqlConnection connection = new SqlConnection(cs_data.path);
        private void connect()
        {
            try
            {
                connection.Open();
            }
            catch (Exception x)
            {
                if (MessageBox.Show("veri bağlantısı hatası\n" + x, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
