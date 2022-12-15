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
    public partial class frm_material : Form
    {
        public frm_material()
        {
            InitializeComponent();
        }

        string imagepath;

        private void frm_material_Load(object sender, EventArgs e)
        {
            start();
            addimage.FileName = "aa\\apple.png";
            imagepath = addimage.FileName;
        }

        byte[] data;

        public double safe;

        private void start()
        {
            pnl_mat.Controls.Clear();

            connect();
            SqlCommand com = new SqlCommand("select * from tbl_material", connection);
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

            safe = 0;
            SqlCommand com2 = new SqlCommand("select * from tbl_safe ", connection);

            SqlDataReader read2 = com2.ExecuteReader();
            while (read2.Read())
            {
                if (Convert.ToBoolean(read2["status"]))
                {
                    safe += Convert.ToDouble(read2["safe"]);
                }
                else
                {
                    safe -= Convert.ToDouble(read2["safe"]);
                }
            }
            read2.Close();

            txt_safe.Text = safe.ToString();

            SqlDataReader read3 = com.ExecuteReader();

            while (read3.Read())
            {
                if (sm ==Convert.ToInt32(read3["id"]))
                {
                    byte[] data = new byte[0];
                    data = (byte[])(read3["pp"]);
                    MemoryStream mem = new MemoryStream(data);

                    pb_i.Image = Image.FromStream(mem);
                    txt_i_name.Text = read3["name"].ToString();
                    txt_i_amout.Text = read3["amout"].ToString();
                    txt_i_price.Text = read3["price"].ToString();

                    pb_o.Image = Image.FromStream(mem);
                    txt_o_name.Text = read3["name"].ToString();
                    txt_o_price.Text = read3["price"].ToString();

                    pb_s.Image = Image.FromStream(mem);
                    txt_s_n.Text = read3["name"].ToString();
                    txt_s_ta.Text = read3["amout"].ToString();
                    txt_s_p.Text = read3["price"].ToString();
                    break;
                }
            }
            read3.Close();
            connection.Close();
        }

        int sm = 0;

        private void btn_Click(object sender, EventArgs e)
        {
            sm = Convert.ToInt32(((Button)sender).Name);
            btn_i_c.Enabled = true;
            btn_i_ok.Enabled = true;
            btn_a_c.Enabled = true;
            btn_a_ok.Enabled = true;
            btn_o_c.Enabled = true;
            btn_o_ok.Enabled = true;
            btn_s_c.Enabled = true;
            btn_s_ok.Enabled = true;

            connect();
            SqlCommand com = new SqlCommand("select * from tbl_material ", connection);
            SqlDataReader read = com.ExecuteReader();


            while (read.Read())
            {
                if (sm == Convert.ToInt32(read["id"]))
                {
                    byte[] data = new byte[0];
                    data = (byte[])(read["pp"]);
                    MemoryStream mem = new MemoryStream(data);

                    pb_i.Image = Image.FromStream(mem);
                    txt_i_name.Text = read["name"].ToString();
                    txt_i_amout.Text = read["amout"].ToString();
                    txt_i_price.Text = read["price"].ToString();

                    pb_o.Image = Image.FromStream(mem);
                    txt_o_name.Text = read["name"].ToString();
                    txt_o_price.Text = read["price"].ToString();

                    pb_s.Image = Image.FromStream(mem);
                    txt_s_n.Text = read["name"].ToString();
                    txt_s_ta.Text = read["amout"].ToString();
                    txt_s_p.Text = read["price"].ToString();

                    break;
                }
            }
            read.Close();
            connection.Close();
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

        public bool name_control(string name)
        {
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_material ", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if (read["name"].ToString() == name && sm != Convert.ToInt32(read["id"]))
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

        private void txt_a_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 44)
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

        private void txt_i_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 44)
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

        private void txt_o_amout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 44)
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

        private void txt_s_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 47 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 44)
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

        private void btn_i_ok_Click(object sender, EventArgs e)
        {
            if (btn_i_ok.Text == "kaydet")
            {
                if(txt_i_name.Text =="" || txt_i_price.Text == "")
                {
                    MessageBox.Show("isim yada fiyat boş bırakılamaz!!!", "dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (name_control(txt_i_name.Text))
                {
                    connect();
                    SqlCommand com = new SqlCommand("update tbl_material set name='" + txt_i_name.Text + "',price='" + txt_i_price.Text + "' where id=" + sm + "", connection);

                    SqlCommand com2 = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);

                    com2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                    com2.Parameters.AddWithValue("@text", txt_i_name.Text + " adlı ürün güncellenmiştir.");

                    com2.ExecuteNonQuery();
                    com.ExecuteNonQuery();
                    connection.Close();

                    txt_i_name.Enabled = false;
                    txt_i_price.Enabled = false;
                    btn_i_ok.Text = "düzenle";
                    btn_i_c.Text = "sil";
                    start();
                }
                else
                {
                    MessageBox.Show("bu isme sahip bir ürün var!!!", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                txt_i_name.Enabled = true;
                txt_i_price.Enabled = true;
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
                if (MessageBox.Show(txt_i_name.Text+" isimli ürünü silmek istediğinizden emin misiniz\nbu ürün silinmeden önce stoktaki ürünler iade edilecektir", "dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    connect();
                    SqlCommand com2 = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);

                    com2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                    com2.Parameters.AddWithValue("@text",txt_i_name.Text+" isimli üründen "+txt_i_amout.Text+" adet iade edilmiş ve bu malzemenin kaydı silinmiştir.");
                    com2.ExecuteNonQuery();

                    SqlCommand com3 = new SqlCommand("INSERT INTO tbl_safe(date,text,safe,status) VALUES (@date,@text,@safe,@status)", connection);
                    com3.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                    com3.Parameters.AddWithValue("@text", txt_i_name.Text + " isimli üründen " + txt_i_amout.Text + " iade edilmiş ve bu malzemenin kaydı silinmiştir.");
                    com3.Parameters.AddWithValue("@safe", txt_o_t.Text);
                    com3.Parameters.AddWithValue("@status", true);
                    com3.ExecuteNonQuery();

                    SqlCommand com = new SqlCommand("delete from tbl_material where id=" + sm + "", connection);
                    SqlDataReader read = com.ExecuteReader();

                    connection.Close();
                }
            }
        }

        private void btn_a_ok_Click(object sender, EventArgs e)
        {
            if (name_control(txt_a_name.Text) == false)
            {
                MessageBox.Show("bu isme sahip bir ürün var!!!", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (txt_a_name.Text != "" && txt_a_price.Text != "" && name_control(txt_a_name.Text) && Convert.ToDouble(txt_a_price.Text) > 0)
            {
                string text;
                connect();
                FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] image = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();

                SqlCommand com = new SqlCommand("INSERT INTO tbl_material(name,price,amout,pp) VALUES (@name,@price,@amout,@pp)", connection);

                com.Parameters.Add("@pp", SqlDbType.Image, image.Length).Value = image;
                com.Parameters.AddWithValue("@name", txt_a_name.Text);
                com.Parameters.AddWithValue("@price", txt_a_price.Text);
                com.Parameters.AddWithValue("@amout", "0");
                text = "adı " + txt_a_name.Text + " olan " + txt_a_price.Text + " ₺ değerinde ürün kaydı oluşturuldu";
                com.ExecuteNonQuery();

                SqlCommand com2 = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);
                com2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                com2.Parameters.AddWithValue("@text", text);

                com2.ExecuteNonQuery();
                connection.Close();
                start();
            }
        }

        private void btn_a_c_Click(object sender, EventArgs e)
        {
            txt_a_name.Text = "";
            txt_a_price.Text = "";
        }

        private void btn_o_t_Click(object sender, EventArgs e)
        {
            if (txt_o_amout.Text != "")
            {
                txt_o_t.Text = (Convert.ToDouble(txt_o_price.Text) * Convert.ToDouble(txt_o_amout.Text)).ToString();
                if (Convert.ToDouble(txt_o_t.Text) <= safe && Convert.ToDouble(txt_o_amout.Text) > 0)
                {
                    btn_o_ok.Enabled = true;
                    txt_o_amout.ForeColor = Color.Black;
                }
                else
                {
                    txt_o_amout.ForeColor = Color.Red;
                    btn_o_ok.Enabled = false;
                }
            }
        }

        private void btn_o_ok_Click(object sender, EventArgs e)
        {
            if (txt_o_amout.Text != "" && Convert.ToDouble(txt_o_amout.Text) > 0 && Convert.ToDouble(txt_o_amout.Text) <= Convert.ToDouble(txt_safe.Text))
            {
                connect();
                SqlCommand com = new SqlCommand("update tbl_material set amout='" + (Convert.ToDouble(txt_o_amout.Text) + Convert.ToDouble(txt_i_amout.Text)).ToString() + "' where id=" + sm + "", connection);
                com.ExecuteNonQuery();

                SqlCommand com2 = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);
                com2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                com2.Parameters.AddWithValue("@text", txt_i_name.Text + " adlı üründen " + txt_o_amout.Text + " adet " + txt_o_t.Text + "₺ karşılığında alındı");
                com2.ExecuteNonQuery();

                SqlCommand com3 = new SqlCommand("INSERT INTO tbl_safe(date,text,safe,status) VALUES (@date,@text,@safe,@status)", connection);
                com3.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                com3.Parameters.AddWithValue("@text", txt_i_name.Text + " adlı üründen " + txt_o_amout.Text + " adet " + txt_o_t.Text + "₺ karşılığında alındı");
                com3.Parameters.AddWithValue("@safe", Convert.ToDouble(txt_o_t.Text));
                com3.Parameters.AddWithValue("@status", false);
                com3.ExecuteNonQuery();

                connection.Close();
                start();
            }
        }

        private void btn_o_c_Click(object sender, EventArgs e)
        {
            txt_o_amout.Text = "";
            txt_o_t.Text = "";
        }

        private void btn_s_t_Click(object sender, EventArgs e)
        {
            if (txt_s_a.Text != "")
            {
                txt_s_t.Text = (Convert.ToDouble(txt_s_p.Text) * Convert.ToDouble(txt_s_a.Text)).ToString();
                if (Convert.ToDouble(txt_s_ta.Text) >= Convert.ToDouble(txt_s_a.Text) && Convert.ToDouble(txt_s_a.Text) > 0)
                {
                    btn_s_ok.Enabled = true;
                    txt_s_a.ForeColor = Color.Black;
                }
                else
                {
                    txt_s_a.ForeColor = Color.Red;
                    btn_s_ok.Enabled = false;
                }
            }
            
        }

        private void btn_s_ok_Click(object sender, EventArgs e)
        {
            if (txt_s_a.Text != "" && Convert.ToDouble(txt_s_a.Text) > 0 && Convert.ToDouble(txt_s_a.Text) <= Convert.ToDouble(txt_s_ta.Text))
            {
                connect();
                SqlCommand com = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);

                com.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                com.Parameters.AddWithValue("@text", txt_s_n.Text + " isimli üründen " + txt_s_t.Text + " ₺ değerinde ürün iade edilmiştir.");
                com.ExecuteNonQuery();

                SqlCommand com2 = new SqlCommand("INSERT INTO tbl_safe(date,text,safe,status) VALUES (@date,@text,@safe,@status)", connection);
                com2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                com2.Parameters.AddWithValue("@text", txt_s_n.Text + " isimli üründen " + txt_s_t.Text + " ₺ değerinde ürün iade edilmiştir.");
                com2.Parameters.AddWithValue("@safe", Convert.ToDouble(txt_s_t.Text));
                com2.Parameters.AddWithValue("@status", true);
                com2.ExecuteNonQuery();


                SqlCommand com3 = new SqlCommand("update tbl_material set amout='" + (Convert.ToDouble(txt_s_ta.Text) - Convert.ToDouble(txt_s_a.Text)).ToString() + "' where id=" + sm + "", connection);
                com3.ExecuteNonQuery();
                connection.Close();

                start();
            }
            else
            {
                txt_s_a.ForeColor = Color.Red;
            }
        }

        private void btn_s_c_Click(object sender, EventArgs e)
        {
            txt_s_a.Text = "";
            txt_s_t.Text = "";
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
