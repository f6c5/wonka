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
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
            //kullanıcı adı kutucuğunu seçili olarak başlar
            this.ActiveControl = txt_name;
            txt_name.Focus();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            //kayıt olma butonuna basıldığında kayıt formuna yönlendirir.
            frm_signup.add = 1;//eğer kayıt formu giriş formundan açılmışsa add değeri 1 olur.
            frm_signup frm_Signup = new frm_signup();
            frm_Signup.Show();
            this.Hide();//giriş formunu kapatır
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            //giriş butonuna tıklandığında eğer kullanıcı adı kısmı ve ya şifre kısmı boşsa bize uyarı verir
            if (txt_name.Text == "" || txt_pass.Text == "")
            {
                lbl_alert.Visible = true;
                lbl_alert.Text = "*kullanıcı adı ve şifre giriniz";
            }
            else
            {//boş değilse kontrole başlar
                connect();//bağlantıyı açma fonksiyonu
                SqlCommand com = new SqlCommand("select * from tbl_employee", connection);//sql de oluşturduğumuz işçi tablosunu listeler
                SqlDataReader read = com.ExecuteReader();//sql deki işçi tablosunu okur

                while (read.Read())//döngü tablodaki tüm elemanları okuyana kadar bitmez
                {
                    if (read["uname"].ToString() == txt_name.Text && read["pass"].ToString() == txt_pass.Text)
                        //kullanıcı adı tablodaki bir kullanıcı adıyla ve aynı kullanıcının şifresiyle uyuşana kadar arar
                    {
                        app.sdep = Convert.ToInt32(read["dep"]);//çalıştığı departmanı ana uygulamadaki dep degişkenine atar
                        app.suser_id = Convert.ToInt32(read["id"]);//kullanıcı id sini aynı şekilde değişkene atar
                        app.uname = read["uname"].ToString();//kullanıcı adını
                        app.name = read["name"].ToString();//adını
                        app.surname = read["surname"].ToString();//ve soyadını atar

                        string text = "kullanıcı adı " + read["uname"] + " olan " + read["name"] + " " + read["surname"] + " giriş yaptı";
                        read.Close();//okulmayı kapatır

                        SqlCommand com3 = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);
                        //bu komut sql de daily adında oluşturduğumuz günlük yani log tablosuna hangi işlemin yapıldığını kaydeder
                        com3.Parameters.AddWithValue("@date", DateTime.Now.ToString());//bu günkü zamanı ekler
                        com3.Parameters.AddWithValue("@text", text);//text adlı dizinde neler yapıldığını yazdık bu diziyi günlüğe kaydeder

                        com3.ExecuteNonQuery();//tabloya ekleme işlemini execute eder
                        read.Close();//tabloyu okumayı durdurur okumayı durdurur
                        connection.Close();//tablolarla işimiz bittiği için bağlantıyı kapatıyoruz

                        app fapp = new app();
                        fapp.Show();//app adındaki ana uygulama formunu açar
                        this.Hide();//giriş formunu saklar

                        lbl_alert.Visible = false;//uyarı labelini gizler
                        txt_name.Text = "";//giriş formundaki kullanıcı adı ve şifer kısmını boş olarak değiştirir
                        txt_pass.Text = "";
                        return;//fonksiyonu bitirir 
                    }
                }
                lbl_alert.Visible = true;//eğer fonksiyon bitmezse eşleşen bir kullanıcı adı ve şifresi bulamamış demektir
                lbl_alert.Text = "*kulanıcı adı yada şifre hatalı";//bu yüzden bize uyarı verir
                read.Close();//okumayı durdurur eğer tekrar giriş butanuna basarsam okumayı kapatmadığımız için hata verir
                connection.Close();//aynı şekil bağlantı açıksa eğer tekrar açamayız bu yüzden hata verir
                return;//fonksiyonu bitirir
            }

        }

        SqlConnection connection = new SqlConnection(cs_data.path);//bağlantımı global bir değişken olarak oluşturduk bağlantı yolunu ise oluşturduğumuz sınıftan çekiyoruz

        private void connect()
        {//boğlantı kurmayı sağlayan fonksiyon karışıklığı azaltmak için oluşturduk
            try
            {
                connection.Open();
            }
            catch (Exception x)
            {
                if (MessageBox.Show("veri bağlantısı hatası\n" + x.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();//eğer bağlantıyı sağlayamazsa formu kapatır
                }
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//kullanıcı adı seçiliyken enter tuşuna basarsa şifre kısmını seçer
            {
                txt_pass.Focus();
            }
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_signin.PerformClick();//şifre kısmı seçiliyken enter tuşuna basarsa giriş tuşuna basar
            }
        }
    }
}

