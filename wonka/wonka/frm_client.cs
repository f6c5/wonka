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
    public partial class frm_client : Form
    {
        public frm_client()
        {
            InitializeComponent();
        }

        string imagepath;
        byte[] data;
        int sc = 0;

        private void frm_client_Load(object sender, EventArgs e)
        {
            addimage.FileName = "aa\\truffle.png";
            imagepath = addimage.FileName;
            start();
        }
        
        private void start()
        {
            pnl_mat.Controls.Clear();

            connect();
            SqlCommand com = new SqlCommand("select * from tbl_client", connection);
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                data = new byte[0];
                data = (byte[])(read["pp"]);
                MemoryStream mem = new MemoryStream(data);
                Button btn = new Button();
                btn.Size = new Size(130, 160);
                btn.Name = read["id"].ToString();
                btn.Text = read["name"].ToString();
                btn.ForeColor = Color.White;
                btn.Padding = new Padding(10);
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.BackgroundImage = Image.FromStream(mem);
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.BackColor = Color.FromArgb(160, 180, 230);
                pnl_mat.Controls.Add(btn);
                btn.Click += new EventHandler(btn_Click);
            }
            read.Close();

            SqlDataReader read3 = com.ExecuteReader();

            while (read3.Read())
            {
                if (sc == Convert.ToInt32(read3["id"]))
                {
                    byte[] data = new byte[0];
                    data = (byte[])(read3["pp"]);
                    MemoryStream mem = new MemoryStream(data);

                    pb_i.Image = Image.FromStream(mem);
                    txt_i_n.Text = read3["name"].ToString();
                    txt_i_t.Text = read3["tel"].ToString();
                    txt_i_e.Text = read3["email"].ToString();
                    txt_i_a.Text = read3["adress"].ToString();
                    break;
                }
            }
            read3.Close();
            connection.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            sc = Convert.ToInt32(((Button)sender).Name);
            btn_i_c.Enabled = true;
            btn_i_ok.Enabled = true;

            connect();
            SqlCommand com = new SqlCommand("select * from tbl_client ", connection);
            SqlDataReader read = com.ExecuteReader();


            while (read.Read())
            {
                if (sc == Convert.ToInt32(read["id"]))
                {
                    byte[] data = new byte[0];
                    data = (byte[])(read["pp"]);
                    MemoryStream mem = new MemoryStream(data);

                    pb_i.Image = Image.FromStream(mem);
                    txt_i_n.Text = read["name"].ToString();
                    txt_i_t.Text = read["tel"].ToString();
                    txt_i_e.Text = read["email"].ToString();
                    txt_i_a.Text = read["adress"].ToString();
                    break;
                }
            }
            read.Close();
            connection.Close();
        }

        public bool name_control(string name)
        {
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_client", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if (read["name"].ToString() == name && sc != Convert.ToInt32(read["id"]))
                {
                    read.Close();
                    connection.Close();
                    return false;
                }
            }
            read.Close();
            connection.Close();
            return true;
        }

        private void btn_i_ok_Click(object sender, EventArgs e)
        {
            if (btn_i_ok.Text == "kaydet")
            {
                if (txt_i_n.Text == "" || txt_i_t.Text == "" || txt_i_e.Text == "" || txt_i_a.Text == "")
                {
                    MessageBox.Show("lütfen tüm bilgileri girdiğinizden emin olun!!!", "dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (name_control(txt_i_n.Text))
                {
                    connect();
                    SqlCommand com = new SqlCommand("update tbl_client set name='" + txt_i_n.Text + "',tel='" + txt_i_t.Text + "',email='" + txt_i_e.Text + "',adress='" + txt_i_a.Text + "' where id=" + sc + "", connection);

                    SqlCommand com2 = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);

                    com2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                    com2.Parameters.AddWithValue("@text", txt_i_n.Text + " adlı müşterinin bilgileri güncellenmiştir.");

                    com2.ExecuteNonQuery();
                    com.ExecuteNonQuery();
                    connection.Close();

                    txt_i_n.Enabled = false;
                    txt_i_t.Enabled = false;
                    txt_i_a.Enabled = false;
                    txt_i_e.Enabled = false;
                    btn_i_ok.Text = "düzenle";
                    btn_i_c.Text = "sil";
                    start();
                }
                else
                {
                    MessageBox.Show("bu isme sahip bir müşteri var!!!", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txt_i_n.Enabled = true;
                txt_i_t.Enabled = true;
                txt_i_e.Enabled = true;
                txt_i_a.Enabled = true;
                btn_i_ok.Text = "kaydet";
                btn_i_c.Text = "iptal";
            }
        }

        private void btn_i_c_Click(object sender, EventArgs e)
        {
            if (btn_i_c.Text == "iptal")
            {
                btn_i_ok.Text = "düzenle";
                btn_i_c.Text = "sil";
                start();
                return;
            }
            else
            {
                if (MessageBox.Show(txt_i_n.Text + " isimli müşteriyi silmek istediğinizden emin misiniz", "dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    connect();
                    SqlCommand com2 = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);

                    com2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                    com2.Parameters.AddWithValue("@text", txt_i_n.Text + " isimli müşteri silinmiştir.");
                    com2.ExecuteNonQuery();

                    SqlCommand com = new SqlCommand("delete from tbl_client where id=" + sc + "", connection);
                    SqlDataReader read = com.ExecuteReader();

                    connection.Close();
                }
            }
        }

        private void pb_a_Click(object sender, EventArgs e)
        {
            addimage.Title = "resim seç";
            addimage.Filter = "png|*.png| jpeg|*.jpeg| jpg|*jpg ";
            if (addimage.ShowDialog() == DialogResult.OK)
            {
                pb_a.Image = Image.FromFile(addimage.FileName);
                imagepath = addimage.FileName;
            }
        }

        private void btn_a_ok_Click(object sender, EventArgs e)
        {
            if (name_control(txt_a_n.Text) == false)
            {
                MessageBox.Show("bu isme sahip bir müşteri var!!!", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txt_a_n.Text != "" && txt_a_t.Text != "" && txt_a_e.Text != "" && txt_a_a.Text != "")
            {
                connect();
                FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] image = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();

                SqlCommand com = new SqlCommand("INSERT INTO tbl_client(name,tel,email,adress,pp) VALUES (@name,@tel,@email,@adress,@pp)", connection);

                com.Parameters.Add("@pp", SqlDbType.Image, image.Length).Value = image;
                com.Parameters.AddWithValue("@name", txt_a_n.Text);
                com.Parameters.AddWithValue("@tel", txt_a_t.Text);
                com.Parameters.AddWithValue("@email", txt_a_e.Text);
                com.Parameters.AddWithValue("@adress", txt_a_a.Text);

                com.ExecuteNonQuery();

                SqlCommand com2 = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);
                com2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                com2.Parameters.AddWithValue("@text", txt_a_n.Text + " adında bir müşteri oluşturuldu.");

                com2.ExecuteNonQuery();
                connection.Close();
                start();
            }
            else
            {
                MessageBox.Show("lütfen tüm bilgileri eksiksiz girin..", "eksik bilgi!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_a_c_Click(object sender, EventArgs e)
        {
            txt_a_n.Text = "";
            txt_a_t.Text = "";
            txt_a_e.Text = "";
            txt_a_a.Text = "";
        }

        private void txt_i_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_a_t_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_a_t_TextChanged(object sender, EventArgs e)
        {
            txt_a_t.MaxLength = 11;
        }

        private void txt_i_t_TextChanged(object sender, EventArgs e)
        {
            txt_i_t.MaxLength = 11;
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
