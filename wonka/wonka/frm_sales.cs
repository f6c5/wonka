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
    public partial class frm_sales : Form
    {
        public frm_sales()
        {
            InitializeComponent();
        }

        private void frm_sales_Load(object sender, EventArgs e)
        {
            start();
        }

        private void start()
        {
            lv_c.Items.Clear();
            double tot = 0;
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_cs", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(read["date"].ToString());
                item.SubItems.Add(read["client"].ToString());
                item.SubItems.Add(read["text"].ToString());
                item.SubItems.Add(read["safe"].ToString());
                lv_c.Items.Add(item);
                tot += Convert.ToDouble(read["safe"]);
            }
            read.Close();

            SqlCommand com2 =new SqlCommand("select * from tbl_client",connection);
            SqlDataReader read2 = com2.ExecuteReader();
            cb_c.Items.Clear();
            while (read2.Read())
            {
                cb_c.Items.Add(read2["name"].ToString());
            }
            read2.Close();
            connection.Close();
            btn_tt.Text = tot.ToString();
        }

        private void btn_s_sp_Click(object sender, EventArgs e)
        {
            flp_s.Controls.Clear();

            connect();
            SqlCommand com = new SqlCommand("select * from tbl_material", connection);
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                byte[] data = new byte[0];
                data = (byte[])(read["pp"]);
                MemoryStream mem = new MemoryStream(data);
                Button btn = new Button();
                btn.Size = new Size(130, 160);
                btn.Name = read["id"].ToString();
                btn.Text = read["name"].ToString() + "\n  " + read["amout"].ToString();
                btn.ForeColor = Color.White;
                btn.Padding = new Padding(10);
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.BackgroundImage = Image.FromStream(mem);
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.BackColor = Color.FromArgb(160, 180, 230);
                flp_s.Controls.Add(btn);
                btn.Click += new EventHandler(btnm_Click);
            }
            read.Close();
            connection.Close();
        }

        int sm = 0;

        private void btnm_Click(object sender, EventArgs e)
        {
            sm = Convert.ToInt32(((Button)sender).Name);

            connect();
            SqlCommand com = new SqlCommand("select * from tbl_material", connection);
            SqlDataReader read = com.ExecuteReader();


            while (read.Read())
            {
                if (sm == Convert.ToInt32(read["id"]))
                {
                    btn_s_sp.Text = read["name"].ToString();
                    txt_s_ta.Text = read["amout"].ToString();
                    txt_s_p.Text = read["price"].ToString();
                    break;
                }
            }
            read.Close();
            connection.Close();
            flp_s.Controls.Clear();
        }

        private void btn_s_sc_Click(object sender, EventArgs e)
        {
            flp_s.Controls.Clear();

            connect();
            SqlCommand com = new SqlCommand("select * from tbl_client", connection);
            SqlDataReader read = com.ExecuteReader();

            while (read.Read())
            {
                byte[] data = new byte[0];
                data = (byte[])(read["pp"]);
                MemoryStream mem = new MemoryStream(data);
                Button btn = new Button();
                btn.Size = new Size(130, 160);
                btn.Name = read["id"].ToString();
                btn.Text = read["name"].ToString();
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.ForeColor = Color.White;
                btn.Padding = new Padding(10);
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.BackgroundImage = Image.FromStream(mem);
                btn.BackgroundImageLayout = ImageLayout.Zoom;
                btn.BackColor = Color.FromArgb(160, 180, 230);
                flp_s.Controls.Add(btn);
                btn.Click += new EventHandler(btnc_Click);
            }
            read.Close();
            connection.Close();
        }

        int sc = 0;

        private void btnc_Click(object sender, EventArgs e)
        {
            sc = Convert.ToInt32(((Button)sender).Name);

            connect();
            SqlCommand com = new SqlCommand("select * from tbl_client", connection);
            SqlDataReader read = com.ExecuteReader();


            while (read.Read())
            {
                if (sc == Convert.ToInt32(read["id"]))
                {
                    btn_s_sc.Text = read["name"].ToString();
                    break;
                }
            }
            read.Close();
            connection.Close();
            flp_s.Controls.Clear();
        }

        private void btn_s_t_Click(object sender, EventArgs e)
        {
            if (btn_s_sp.Text != "ürün seç" && btn_s_sc.Text != "müşteri seç" && txt_s_a.Text != "" && Convert.ToDouble(txt_s_a.Text) <= Convert.ToDouble(txt_s_ta.Text))
            {
                btn_s_ok.Enabled = true;
                txt_s_t.Text = (Convert.ToDouble(txt_s_a.Text) * Convert.ToDouble(txt_s_p.Text)).ToString();
            }
            else if (btn_s_sp.Text == "ürün seç" && btn_s_sc.Text == "müşteri seç")
            {
                MessageBox.Show("ürün ve müşteri seçtiğinizden emin olun!!!");
            }
            else if (txt_s_t.Text != "" && txt_s_a.Text != "" && Convert.ToDouble(txt_s_a.Text) > 0 && Convert.ToDouble(txt_s_a.Text) > Convert.ToDouble(txt_s_ta.Text))
            {
                txt_s_a.ForeColor = Color.Red;
                btn_s_ok.Enabled = false;
            }

        }

        private void btn_s_ok_Click(object sender, EventArgs e)
        {
            if (btn_s_sp.Text == "ürün seç" && btn_s_sc.Text == "müşteri seç")
            {
                MessageBox.Show("ürün ve müşteri seçtiğinizden emin olun!!!");
            }
            else if (txt_s_t.Text == "" && txt_s_a.Text == "" && Convert.ToDouble(txt_s_t.Text) > 0 && Convert.ToDouble(txt_s_a.Text) > Convert.ToDouble(txt_s_ta.Text))
            {
                MessageBox.Show("lütfen fiyatları ve miktarı kontrol edin!!!");
            }
            else if(btn_s_sp.Text != "ürün seç" && btn_s_sc.Text != "müşteri seç" && txt_s_a.Text != "" && Convert.ToDouble(txt_s_t.Text) > 0 && Convert.ToDouble(txt_s_a.Text) <= Convert.ToDouble(txt_s_ta.Text))
            {
                connect();
                SqlCommand com = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);

                com.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                com.Parameters.AddWithValue("@text", btn_s_sp.Text + " isimli malzemeden " + txt_s_t.Text + " ₺ değerinde malzeme "+ btn_s_sc.Text +" adlı müşteriye satılmıştır.");
                com.ExecuteNonQuery();

                SqlCommand com2 = new SqlCommand("INSERT INTO tbl_safe(date,text,safe,status) VALUES (@date,@text,@safe,@status)", connection);
                com2.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                com2.Parameters.AddWithValue("@text", btn_s_sp.Text + " isimli malzemeden " + txt_s_t.Text + " ₺ değerinde malzeme " + btn_s_sc.Text + " adlı müşteriye satılmıştır.");
                com2.Parameters.AddWithValue("@safe", Convert.ToDouble(txt_s_t.Text));
                com2.Parameters.AddWithValue("@status", true);
                com2.ExecuteNonQuery();

                SqlCommand com3 = new SqlCommand("update tbl_material set amout='" + (Convert.ToDouble(txt_s_ta.Text) - Convert.ToDouble(txt_s_a.Text)).ToString() + "' where id=" + sm + "", connection);
                com3.ExecuteNonQuery();

                SqlCommand com4 = new SqlCommand("INSERT INTO tbl_cs(date,client,text,safe) VALUES (@date,@client,@text,@safe)", connection);
                com4.Parameters.AddWithValue("@date", DateTime.Now);
                com4.Parameters.AddWithValue("@client", btn_s_sc.Text);
                com4.Parameters.AddWithValue("@text", btn_s_sp.Text + " isimli malzemeden " + txt_s_t.Text + " ₺ değerinde malzeme satın aldı.");
                com4.Parameters.AddWithValue("@safe", Convert.ToDouble(txt_s_t.Text));
                com4.ExecuteNonQuery();

                connection.Close();

                btn_s_sp.Text = "ürün seç";
                btn_s_sc.Text = "müşteri seç";
                txt_s_a.Text = "";
                txt_s_t.Text = "";
                txt_s_ta.Text = "";
                txt_s_p.Text = "";
                start();
            }
        }

        private void btn_s_c_Click(object sender, EventArgs e)
        {
            btn_s_sp.Text = "ürün seç";
            btn_s_sc.Text = "müşteri seç";
            txt_s_a.Text = "";
            txt_s_t.Text = "";
            txt_s_ta.Text = "";
            txt_s_p.Text = "";
            flp_s.Controls.Clear();
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

        private void dtp_search_ValueChanged(object sender, EventArgs e)
        {
            lv_c.Items.Clear();
            double tot = 0;
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_cs", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if (Convert.ToDateTime(read["date"]).DayOfYear == Convert.ToDateTime(dtp_search.Value).DayOfYear)
                {
                    ListViewItem item = new ListViewItem();
                    item.SubItems.Add(read["date"].ToString());
                    item.SubItems.Add(read["client"].ToString());
                    item.SubItems.Add(read["text"].ToString());
                    item.SubItems.Add(read["safe"].ToString());
                    lv_c.Items.Add(item);
                    tot +=Convert.ToDouble(read["safe"]);
                }
            }
            read.Close();
            connection.Close();
            btn_tt.Text = tot.ToString();
        }

        private void cb_c_SelectedValueChanged(object sender, EventArgs e)
        {
            lv_c.Items.Clear();
            double tot = 0;
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_cs where client='"+cb_c.SelectedItem.ToString()+"'", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add(read["date"].ToString());
                item.SubItems.Add(read["client"].ToString());
                item.SubItems.Add(read["text"].ToString());
                item.SubItems.Add(read["safe"].ToString());
                lv_c.Items.Add(item);
                tot += Convert.ToDouble(read["safe"]);
            }
            read.Close();
            connection.Close();
            btn_tt.Text = tot.ToString();
        }
    }
}
