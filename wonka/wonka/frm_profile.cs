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
    public partial class frm_profile : Form
    {
        public frm_profile()
        {
            InitializeComponent();
        }

        private string passs;
        private void frm_profile_Load(object sender, EventArgs e)
        {
            refresh();
        }
        private void refresh()
        {
            start();
            lbl_npass.Visible = false;
            lbl_npass2.Visible = false;
            txt_npass.Visible = false;
            txt_npass2.Visible = false;
            btn_cancel.Visible = false;
            btn_save.Visible = false;
            edit.Enabled = true;
            delete.Enabled = true;
            txt_pass.Text = "";
            for (int i = 0; i < passs.Length; i++)
            {
                txt_pass.Text += "*";
            }
            txt_uname.Enabled = false;
            txt_name.Enabled = false;
            txt_surname.Enabled = false;
            txt_pass.Enabled = false;
            txt_mail.Enabled = false;
            txt_adress.Enabled = false;
            pb_pp.Enabled = false;
        }
        byte[] data;
        private void start()
        {
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_employee", connection);
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                if(app.suser_id==Convert.ToInt32(read["id"]))
                {
                    data = new byte[0];
                    data = (byte[])(read["pp"]);
                    MemoryStream mem = new MemoryStream(data);
                    pb_pp.Image = Image.FromStream(mem);
                    txt_uname.Text = read["uname"].ToString();
                    txt_name.Text = read["name"].ToString();
                    txt_surname.Text = read["surname"].ToString();
                    lage.Text = read["age"].ToString();
                    txt_mail.Text = read["email"].ToString();
                    lgender.Text = read["gender"].ToString();
                    txt_adress.Text = read["adress"].ToString();
                    llogdate.Text = read["logdate"].ToString();
                    passs = read["pass"].ToString();
                    if (Convert.ToInt32(read["dep"]) / 100 == 1)
                    {
                        ldep.Text = "yönetim ";
                    }
                    else
                    {
                        if((Convert.ToInt32(read["dep"]) % 100) / 10 == 1)
                        {
                            ldep.Text = "satış ";
                        }
                        if (Convert.ToInt32(read["dep"]) % 10 == 1)
                        {
                            ldep.Text += "üretim ";
                        }
                    }
                    ldep.Text += "görevlisi";
                }
            }
            read.Close();
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

        private void kaydet_Click(object sender, EventArgs e)
        {
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_employee", connection);
            SqlDataReader read = com.ExecuteReader();
            bool b = true;
            while (read.Read())
            {
                if (txt_uname.Text == read["uname"].ToString() && app.suser_id != Convert.ToInt32(read["id"]))
                {
                    b = false;
                }
            }
            string funame;
            if (b)
            {
                funame = txt_uname.Text;
            }
            else
            {
                funame = "x";
            }
            read.Close();
            connection.Close();
            string fname = txt_name.Text;
            string fsurname = txt_surname.Text;
            string fnpass = txt_npass.Text;
            if (txt_npass.Text != txt_npass2.Text)
            {
                fnpass = "x";
            }
            string femail = txt_mail.Text;

            string fadress = txt_adress.Text;
            if (txt_adress.Text == "")
            {
                fadress = "dünya";
            }
            if (funame != "" && funame != "x" && fnpass != "" && fname != "" && fsurname != "" && femail != "")
            {
                try
                {
                    connect();

                    string kk = "update tbl_employee set uname='" + funame+"',name='" + fname + "',surname='" + fsurname + "',pass='" + fnpass + "',email='" + femail + "',adress='" + fadress + "' where id=" + app.suser_id + " ";

                    SqlCommand sqlcom = new SqlCommand(kk, connection);

                    sqlcom.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("değişiklikler kaydedilimiştir", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                }
                catch (Exception x)
                {
                    MessageBox.Show("değişiklikler kaydedilmedi\n" + x.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (txt_uname.Text == "")
                    e0.Visible = true;
                if (txt_name.Text == "")
                    e1.Visible = true;
                if (txt_surname.Text == "")
                    e2.Visible = true;
                if (txt_pass.Text == "")
                    e3.Visible = true;
                if (txt_npass.Text == "")
                    e4.Visible = true;
                if (txt_npass2.Text == "")
                    e5.Visible = true;
                if (txt_mail.Text == "")
                    e6.Visible = true;
                e8.Text = "*seçili alanlar boş bırakılamaz";
                if (funame == "x")
                {
                    e8.Text = "*bu kullanıcı adı zaten mevcut*";
                }
                if (fnpass == "x")
                {
                    e8.Text = "*şifreler eşleşmiyor";
                }
                e8.Visible = true;
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            lbl_npass.Visible = true;
            lbl_npass2.Visible = true;
            txt_npass.Visible = true;
            txt_npass2.Visible = true;

            txt_uname.Enabled = true;
            txt_name.Enabled = true;
            txt_surname.Enabled = true;
            txt_pass.Enabled = true;
            txt_mail.Enabled = true;
            txt_adress.Enabled = true;
            pb_pp.Enabled = true;
            edit.Enabled = false;
            delete.Enabled = false;
            btn_save.Visible = true;
            btn_cancel.Visible = true;
            txt_pass.Text = "";

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("kaydınızı silmek istediğinizden emin misiniz ?!!\nkaydınız silindikten sonra giriş yapamiyacaksınız.", "dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                connect();
                SqlCommand com2 = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);

                com2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                com2.Parameters.AddWithValue("@text", "kullanıcı adı " + txt_uname.Text + " olan " + txt_name.Text + " " + txt_surname.Text + " kaydı silinmiştir");
                com2.ExecuteNonQuery();

                SqlCommand com = new SqlCommand("delete from tbl_employee where id=" + app.suser_id + "", connection);
                SqlDataReader read = com.ExecuteReader();

                connection.Close();
                MessageBox.Show("kaydınız silinmiştir.", "gülegüle...", MessageBoxButtons.OK);

                Application.ExitThread();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("değişiklikler kaydedilmedi");
            refresh();
        }
    }
}
