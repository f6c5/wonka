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
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }
        private void frm_main_Load(object sender, EventArgs e)
        {
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_daily", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ListViewItem item = new ListViewItem();
                item.Text = read["id"].ToString();
                item.SubItems.Add(read["date"].ToString());
                item.SubItems.Add(read["text"].ToString());
                lv_daily.Items.Add(item);
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

        private void dtp_search_ValueChanged(object sender, EventArgs e)
        {
            lv_daily.Items.Clear();
            connect();
            SqlCommand com = new SqlCommand("select * from tbl_daily", connection);
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                if (Convert.ToDateTime(read["date"]).DayOfYear == Convert.ToDateTime(dtp_search.Value).DayOfYear)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = read["id"].ToString();
                    item.SubItems.Add(read["date"].ToString());
                    item.SubItems.Add(read["text"].ToString());
                    lv_daily.Items.Add(item);
                }
            }
            connection.Close();
        }
    }
}
