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
    public partial class app : Form
    {
        public app()
        {
            InitializeComponent();
        }

        public static int sdep;                //
        public static int suser_id;            //
        public static string uname;            //
        public static string name;             //
        public static string surname;          //giriş formunda atanan bilgiler

        private void app_Load(object sender, EventArgs e)
        {
            lbl_time.Text = DateTime.Now.ToLongDateString();//arihi ekrana yazdırır
            dep_btn();//departman fonksiyonu
            openChildForm(new frm_main());//formun içinde form çağırmak için oluşturulan fonksiyon
        }
        private void dep_btn()
        {
            if (sdep / 100 == 1)//100 ler basamağı 1 se bir yöneticidir
            {//departman olarak yönetici departmanında olanların görebildiği formlara bağlanan butonların görünürlüğünü ayarlar
                btn_materials.Visible = true;
                btn_sales.Visible = true;
                btn_client.Visible = true;
                btn_account.Visible = true;
                btn_staff.Visible = true;//işçi butonu işiçii formuna bağlanır ve sadece yöneticiler işçi formunu görür
            }
            else
            {//eğer yönetici değilse
                if ((sdep % 100) / 10 == 1)//onlar basamağına bakıyoruz onlar basamağı satış görevlisi olup olmadığını belirler eğer 1 se satış yetkisi vardır
                {
                    btn_sales.Visible = true;            //
                    btn_client.Visible = true;           //
                    btn_account.Visible = true;          //o yüzden satışla ilgili formlara erişmeyi sağlayan butonları görünür yapar
                }
                if (sdep % 10 == 1)//üretim için birler basamağına bakıyoruz
                {
                    btn_materials.Visible = true;        //
                    btn_account.Visible = true;          //üretimle ilgili formmlara erişmeyi sağlayan butonları gösterir
                }
            }//görünürlüğü açık olmayan butonlara basılamaz
        }

        private void user_Click(object sender, EventArgs e)
        {//profil formuna erişmeyi sağlayan buton
            openChildForm(new frm_profile());
        }

        private void exit_Click(object sender, EventArgs e)
        {//çıkış butonuna basıldığında 
            connect();//günlüğe olayı yazmak için bağlantıyı açıyoruz
            SqlCommand com = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);

            com.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            com.Parameters.AddWithValue("@text", "kullanıcı adı " + uname + " olan " + name + " " + surname + " çıkış yaptı");
            com.ExecuteNonQuery();//olayı ve tarihi günlüğe yazıp executeediyoruz
            connection.Close();

            frm_login frm_Login = new frm_login();//ve giriş ekranına yönlendiriyoruz
            frm_Login.Show();
            this.Hide();
        }

        private void logo_Click(object sender, EventArgs e)                 //
        {                                                                   //
            openChildForm(new frm_main());                                  //
        }                                                                   //
                                                                            //
        private void btn_main_Click(object sender, EventArgs e)             //
        {                                                                   //
            openChildForm(new frm_main());                                  //
        }                                                                   //
                                                                            //
        private void btn_materials_Click(object sender, EventArgs e)        //
        {                                                                   //
            openChildForm(new frm_material());                              //
        }                                                                   //
                                                                            //
        private void btn_sales_Click(object sender, EventArgs e)            //
        {                                                                   //
            openChildForm(new frm_sales());                                 //
        }                                                                   //
                                                                            //
        private void btn_client_Click(object sender, EventArgs e)           //
        {                                                                   //
            openChildForm(new frm_client());                                //
        }                                                                   //
                                                                            //
        private void btn_account_Click(object sender, EventArgs e)          //
        {                                                                   //
            openChildForm(new frm_account());                               //
        }                                                                   //
                                                                            //
        private void btn_staff_Click(object sender, EventArgs e)            //
        {                                                                   //
            openChildForm(new frm_staff());                                 //
        }                                                                   //kendi formlarına erişmeyi sağlar

        private Form activeForm = null;//bir form nesnesi oluşturuyoruz ve null olarak başlatıyoruz

        private void openChildForm(Form childForm)//form parametresi alan fonksiyonumuz
        {//form içinde form çağırmak için oluşturduğumuz fonksiyonumuz
            if (activeForm != null)
            {//oluşturduğumuz nesnenin değeri varsa yani null değilse
                activeForm.Close();//kapatıyoruz
            }
            activeForm = childForm;//parametre olarak aldığımız formun
            childForm.TopLevel = false;                              //
            childForm.FormBorderStyle = FormBorderStyle.None;        //
            childForm.Dock = DockStyle.Fill;                         //
            pnl_fill.Controls.Add(childForm);                        //formun nereye çağrılıcağını belirliyor
            pnl_fill.Tag = childForm;                                //
            childForm.BringToFront();                                //çağrılacak formu uygulamamıza göre ayarlıyoruz
            childForm.Show();                                        //formu göster komutuyla ayarlarımıa göre çağırıyoruz
        }

        SqlConnection connection = new SqlConnection(cs_data.path);      //sql ile bağlantı için gerekli olanlar
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
        }                                        //sql ile bağlantı için gerekli olanlar

        private void app_FormClosed(object sender, FormClosedEventArgs e)
        {
            //uygulama 'x' tuşuna basılarak kapatılmışsa uygulamayı sonlandırır
            DialogResult result1 = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uygulama Çıkış", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                connect();//çıkış olayını günlüğe kaydediyoruz
                SqlCommand com = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);

                com.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                com.Parameters.AddWithValue("@text", "kullanıcı adı " + uname + " olan " + name + " " + surname + " çıkış yaptı");
                com.ExecuteNonQuery();//execute ediyoruz
                connection.Close();

                Application.ExitThread();//uygulamayı sonlandırıyoruz
            }
            else
            {//kapatmaktan vaz geçerse uygulamayı tekrardan açıyoruz
                app appp = new app();
                appp.Show();
            }
        }
    }
}

