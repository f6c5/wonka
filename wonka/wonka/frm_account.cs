using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wonka
{
    public partial class frm_account : Form
    {
        public frm_account()
        {
            InitializeComponent();
        }

        double ts = 0;
        double tb = 0;
        double ty = 0;
        double tm = 0;
        double td = 0;
        double py = 0;

        private void frm_account_Load(object sender, EventArgs e)
        {
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_safe", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = read["id"].ToString();
                item.SubItems.Add(read["date"].ToString());
                item.SubItems.Add(read["text"].ToString());
                item.SubItems.Add(read["safe"].ToString());

                if (Convert.ToBoolean(read["status"]))
                {
                    item.SubItems.Add("satış");
                    ts += Convert.ToDouble(read["safe"]);

                    if(DateTime.Now.Year == Convert.ToDateTime(read["date"]).Year)
                    {
                        ty += Convert.ToDouble(read["safe"]);
                    }
                    if (DateTime.Now.Month == Convert.ToDateTime(read["date"]).Month && DateTime.Now.Year == Convert.ToDateTime(read["date"]).Year)
                    {
                        tm += Convert.ToDouble(read["safe"]);
                    }
                    if (DateTime.Now.DayOfYear == Convert.ToDateTime(read["date"]).DayOfYear && DateTime.Now.Year == Convert.ToDateTime(read["date"]).Year)
                    {
                        td += Convert.ToDouble(read["safe"]);
                    }
                    if (DateTime.Now.Year - 1 == Convert.ToDateTime(read["date"]).Year)
                    {
                        py += Convert.ToDouble(read["safe"]);
                    }
                }
                else
                {
                    item.SubItems.Add("alış");
                    tb += Convert.ToDouble(read["safe"]);

                    if (DateTime.Now.Year == Convert.ToDateTime(read["date"]).Year)
                    {
                        ty -= Convert.ToDouble(read["safe"]);
                    }
                    if (DateTime.Now.Month == Convert.ToDateTime(read["date"]).Month && DateTime.Now.Year == Convert.ToDateTime(read["date"]).Year)
                    {
                        tm -= Convert.ToDouble(read["safe"]);
                    }
                    if (DateTime.Now.DayOfYear == Convert.ToDateTime(read["date"]).DayOfYear && DateTime.Now.Year == Convert.ToDateTime(read["date"]).Year)
                    {
                        td -= Convert.ToDouble(read["safe"]);
                    }
                    if (DateTime.Now.Year - 1 == Convert.ToDateTime(read["date"]).Year)
                    {
                        py -= Convert.ToDouble(read["safe"]);
                    }
                }
                lv_safe.Items.Add(item);
            }
            read.Close();
            connection.Close();

            if (td > ty / 365)
            {
                btn_td.ForeColor = Color.Green;
            }
            else
            {
                btn_td.ForeColor = Color.DarkRed;
            }

            if (tm > ty / 12)
            {
                btn_tm.ForeColor = Color.Green;
            }
            else
            {
                btn_tm.ForeColor = Color.DarkRed;
            }

            if (ty > py)
            {
                btn_ty.ForeColor = Color.Green;
            }
            else
            {
                btn_ty.ForeColor = Color.DarkRed;
            }

            btn_tt.Text = (ts - tb).ToString();
            btn_tb.Text = tb.ToString();
            btn_ts.Text = ts.ToString();
            btn_ty.Text = ty.ToString();
            btn_tm.Text = tm.ToString();
            btn_td.Text = td.ToString();
        }

        private void dtp_search_ValueChanged(object sender, EventArgs e)
        {
            lv_safe.Items.Clear();
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_safe", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if (Convert.ToDateTime(read["date"]).DayOfYear == Convert.ToDateTime(dtp_search.Value).DayOfYear)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = read["id"].ToString();
                    item.SubItems.Add(read["date"].ToString());
                    item.SubItems.Add(read["text"].ToString());
                    item.SubItems.Add(read["safe"].ToString());
                    if (Convert.ToBoolean(read["status"]))
                    {
                        item.SubItems.Add("satış");
                    }
                    else
                    {
                        item.SubItems.Add("alış");
                    }
                    lv_safe.Items.Add(item);
                }
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

        private void btn_td_Click(object sender, EventArgs e)
        {
            lv_safe.Items.Clear();
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_safe", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if(DateTime.Now.DayOfYear == Convert.ToDateTime(read["date"]).DayOfYear && DateTime.Now.Year == Convert.ToDateTime(read["date"]).Year)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = read["id"].ToString();
                    item.SubItems.Add(read["date"].ToString());
                    item.SubItems.Add(read["text"].ToString());
                    item.SubItems.Add(read["safe"].ToString());

                    if (Convert.ToBoolean(read["status"]))
                    {
                        item.SubItems.Add("satış");
                    }
                    else
                    {
                        item.SubItems.Add("alış");
                    }
                    lv_safe.Items.Add(item);
                }
            }
            read.Close();
            connection.Close();
        }

        private void btn_tm_Click(object sender, EventArgs e)
        {
            lv_safe.Items.Clear();
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_safe", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Now.Month == Convert.ToDateTime(read["date"]).Month && DateTime.Now.Year == Convert.ToDateTime(read["date"]).Year)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = read["id"].ToString();
                    item.SubItems.Add(read["date"].ToString());
                    item.SubItems.Add(read["text"].ToString());
                    item.SubItems.Add(read["safe"].ToString());

                    if (Convert.ToBoolean(read["status"]))
                    {
                        item.SubItems.Add("satış");
                    }
                    else
                    {
                        item.SubItems.Add("alış");
                    }
                    lv_safe.Items.Add(item);
                }
            }
            read.Close();
            connection.Close();
        }

        private void btn_ty_Click(object sender, EventArgs e)
        {
            lv_safe.Items.Clear();
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_safe", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if (DateTime.Now.Year == Convert.ToDateTime(read["date"]).Year)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = read["id"].ToString();
                    item.SubItems.Add(read["date"].ToString());
                    item.SubItems.Add(read["text"].ToString());
                    item.SubItems.Add(read["safe"].ToString());

                    if (Convert.ToBoolean(read["status"]))
                    {
                        item.SubItems.Add("satış");
                    }
                    else
                    {
                        item.SubItems.Add("alış");
                    }
                    lv_safe.Items.Add(item);
                }
            }
            read.Close();
            connection.Close();
        }
    }
}
