using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;


namespace wonka
{
    public partial class frm_signup : Form
    {
        public frm_signup()
        {
            InitializeComponent();
            this.ActiveControl = txt_uname;
            txt_uname.Focus();//kayıt formu açıldığında imleç kullanıcı adı kutucuğunu seçer
        }

        string imagepath;//kullanıcının profil fotoğrafının yolunu tutan değişken
        public static int add;//kayıt formunun giriş ekranından açıldığını yada çalışanlar formundan açıldığını ayırt edebilmesi için oluşturulmuş değişken

        private void frm_signup_Load(object sender, EventArgs e)
        {
            addimage.FileName = "aa\\logo.png";//open file dialogumuzun dosyasını yani profil fotoğrafını default olarak şirketimizin logosu olarak ayarlıyoruz
            imagepath = addimage.FileName;
        }

        private void pb_pp_Click(object sender, EventArgs e)
        {//profil fotoğrafı eklemek için kayıt formundaki resme tıklar ve open file dialogu muzu başlatır
            addimage.Title = "resim seç";//başlığı ayarlar
            addimage.Filter = "png|*.png| jpeg|*.jpeg| jpg|*jpg ";//seçebileceği dosya formatları(resim seçeceğimiz için resim formatları) 
            if (addimage.ShowDialog() == DialogResult.OK)//eğer fotoğraf seçerse
            {
                pb_pp.Image = Image.FromFile(addimage.FileName);
                imagepath = addimage.FileName;//fotoğraf yolumuzu seçilen fotoğrafla değiştirir
            }//eğer seçmezse default olarak ayarlanan fotoğrafı kullanır
        }

        private void btn_register_Click(object sender, EventArgs e)
        {//kayıt tuşuna basarsa
            connect();//bağlantıyı açar
            e0.Visible = false;   //
            e1.Visible = false;   //
            e2.Visible = false;   //
            e3.Visible = false;   //
            e4.Visible = false;   //
            e5.Visible = false;   //
            e6.Visible = false;   //
            e7.Visible = false;   //formdaki doldurulması mecburi yerleri işaret eden işaretleri görünmez yapar

            SqlCommand com = new SqlCommand("select * from tbl_employee", connection);//işçi tablosunu okuma komutu
            SqlDataReader read = com.ExecuteReader();//okuma fonksiyonunu komutumuzla eşleştirir
            bool b = true;//kullanıcı adının daha önce kullanılıp kullanılmadığına bakmak için oluşturulmuş değişken
            //eğer kullanıcı adı daha önce seçilmişse ve aynı yapılmışsa ve bir ihtimal şşifreler de aynıysa ilk kaydolan kişinin hesabına girilir 
            while (read.Read())//işçi tablosundaki satırlar bitene kadar döng durmaz
            {
                if (txt_uname.Text == read["uname"].ToString())//eğer eşleşen bir kullanıcı adı varsa 
                {
                    b = false;//doğruluk değerimizi değiştirir
                    break;//aynı isimde bir kullanıcı adı bulduğumuz için tablonun geri kalan satırlarına bakmaya gerek kalmaz
                }
            }
            string funame = txt_uname.Text;//kullanıcı adını tutan değişken
            read.Close();//okumayı ve
            connection.Close();//bağlantıyı kkapattık
            string fname = txt_name.Text;//adını
            string fsurname = txt_surname.Text;//soyadını
            string fpass = txt_pass.Text;//ve şifresini değşikenlere atar
            if (txt_pass.Text != txt_pass2.Text)//eğer şifreler eşleşmezse şifremizi 'x' yapar buda eşleşmediğini gösterir
            {//yeni bir doğruluk değişkeni oluşturmamamızın sebebi ram tasarrufu böylece daha hızlı çalışır
                fpass = "x";
            }
            int fage = 0;//yaşımızı 0 olarak ayarlar
            if(txt_age.Text != "")
            {//eğer yaş kutucuğu boş değilse bunu sayıya dönüştürür ve yaş değişkenimize atar
                fage = Convert.ToInt32(txt_age.Text);
            }
            string femail = txt_mail.Text;//mail adresimizi atar
            string fgender = "belirsiz";//cinsiyet seçilmemişse belirsiz yapar cinsiyet seçme zorunluluğu yok
            if (rb_female.Checked == true)
            {//eğer kadın seçiliyse kadın
                fgender = "kadın";
            }
            else if (rb_male.Checked == true)
            {//erkek seçiliyse erkek olarak ayarlar
                fgender = "erkek";
            }

            string fadress = txt_adress.Text;//adresi değişkene atar
            if (txt_adress.Text == "")//adres girme zorunluluğu yok bu yüzden adres girilmemişse kessin olan ve bilinen konumu ayarlar 
            {
                fadress = "dünya";//yani dünya 
            }
            int fdep = 0;//departman değerimizi 0 dan başlatıyoruz
            if (cb_sales.Checked == true)
            {
                fdep += 10;//eğer satış departmanı seçiliyse onlar basamağını 1 yapar yani 10 ekliyoruz
            }
            if (cb_prod.Checked == true)
            {
                fdep += 1;//eğer üretim departmanı seçiliyse birler basamağını 1 yapar yani 1 ekliyoruz
            }//birden fazla departman seçilebildiği için ve bunları ayırt etmek için böyle bir yöntem kullandık
            string flogdate = (DateTime.Now).ToString();//kayıt tarihini şimdiki zaman olarak oluşturuyoruzoluşturuyoruz

            if (imagepath != null && funame != "" && b && fpass != "" && fname != "" && fsurname != "" && femail != "" && fdep != 0 && fpass != "x")
            {//formdaki zorunlu kısımlar doldurulmuşmu diye kontrol ediyoruz şifre x değilse yani eşleşiyorsa ve kullanıcı adından başka aynı isimde başka kullanıcı yoksa
             //kullanıcı adı, ad, soyad, şifre ve mail kutucukları boş değilse ve departman seçilmişse
                try
                {//tabloya kayıt işlemleri başlar
                    string text;//günlük için oluşturulmuş işlem değişkeni
                    connect();//bağlantıyı açıyoruz
                    FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);//resmimizi dosyayadönüştürüyoruz
                    BinaryReader binaryReader = new BinaryReader(fileStream);//bu dosyayı 2 lik sistemde okuyoruuz
                    byte[] image = binaryReader.ReadBytes((int)fileStream.Length);//sonra bu2 lik sistemdeki verileri byte dizimize aktarıyoruz
                    //böylece verilerimizi 2 lik sistemde sql e kaydediyoruz
                    binaryReader.Close();//dönüştürme fonksiyonlarını kapatıyoruz
                    fileStream.Close();

                    string kk = "INSERT INTO tbl_employee(uname,name,surname,pass,age,email,gender,adress,dep,pp,logdate) VALUES (@uname,@name,@surname,@pass,@age,@email,@gender,@adress,@dep,@pp,@logdate)";//komutumuzun metni çok uzun olduğu için karışıklığı engelliyoruz
                    //işçi tablosuna insert yani eklemme yapıyoruz
                    SqlCommand com2 = new SqlCommand(kk, connection);//komutu oluşturuyoruz
                    com2.Parameters.Add("@pp", SqlDbType.Image, image.Length).Value = image;//2lik sistemdeki resmimizi tabloya ekliyoruz                              //
                    com2.Parameters.AddWithValue("@uname", funame);                              //
                    com2.Parameters.AddWithValue("@name", fname);                                //
                    com2.Parameters.AddWithValue("@surname", fsurname);                          //
                    com2.Parameters.AddWithValue("@pass", fpass);                                //
                    com2.Parameters.AddWithValue("@age", fage);                                  //
                    com2.Parameters.AddWithValue("@email", femail);                              //
                    com2.Parameters.AddWithValue("@gender", fgender);                            //
                    com2.Parameters.AddWithValue("@adress", fadress);                            //
                    com2.Parameters.AddWithValue("@dep", fdep);                                  //
                    com2.Parameters.AddWithValue("@logdate", flogdate);                          //diğer bilgileride tabloya ekliyoruz
                    text ="kullanıcı adı "+funame+" olan "+fname+" "+fsurname+" kaydoldu";        //gnlük için metnimizi oluşturuyoruz
                    com2.ExecuteNonQuery();//ekleme işlemini yani komutumuzu execute ediyoruz

                    SqlCommand com3 = new SqlCommand("INSERT INTO tbl_daily(date,text) VALUES (@date,@text)", connection);
                    //günlüğümüze tarih ve metni ekliyoruz
                    com3.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                    com3.Parameters.AddWithValue("@text", text);

                    com3.ExecuteNonQuery();//execute ediyoruz
                    connection.Close();//bağlantıyı kapatıyoruz

                    if (add == 1)
                    {//eğer kayıt formu giriş sayfasından açıldıysa bize farklı bir mesaj verip giriş sayfasına yönlendiriyor
                        MessageBox.Show("kaydınız başarıyla gerçekleştirilmiştir", "hoş geldiniz", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frm_login frm_Login = new frm_login();
                        frm_Login.Show();
                        this.Hide();
                    }
                    else if(add == 2)
                    {//eğer eleman kısmından açılmışsa farklı bir mesaj verip formu kapatıyor
                        MessageBox.Show("kaydı başarıyla gerçekleştirilmiştir", "hoş geldini", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                }
                catch (Exception x)
                {//kayıt anında bir hata verirse bize uyarı veriyor
                    MessageBox.Show("kaydınız başarısız\n" + x.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (txt_uname.Text == "")          //
                    e0.Visible = true;             //
                if (txt_name.Text == "")           //
                    e1.Visible = true;             //
                if (txt_surname.Text == "")        //
                    e2.Visible = true;             //
                if (txt_pass.Text == "")           //
                    e3.Visible = true;             //
                if (txt_pass2.Text == "")          //
                    e4.Visible = true;             //
                if (txt_mail.Text == "")           //
                    e5.Visible = true;             //
                if (fdep == 0)                     //
                    e6.Visible = true;             //eğer mecburi yerlerden boş brakılan varsa boşbırakılan yere karşılık gelen beliirteçler görünür olur
                e7.Text = "seçili alanlar boş bırakılamaz*";//ve ne olduğunu uyarı metninde açıklar
                if (b==false)
                {//kullanıcı adı zeten mevcutsa uyarı metnini değiştirir
                    e7.Text = "bu kullanıcı adı zaten mevcut*";
                }
                if (fpass == "x")
                {//şifereler eşleşmiyorsa uyarı metnini buna göre ayarlar
                    e7.Text = "şifreler eşleşmiyor";
                }
                e7.Visible = true;//uyarı metnini görünür yapar
            }            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (add == 1)//eğer kayıt işlemi iptal edilirse ve giriş sayfasından yönlendirilmişse
            {//tekrar giriş sayfasına yönlendirilir
                frm_login frm_Login = new frm_login();
                frm_Login.Show();
                this.Hide();
            }
            else if (add == 2) 
            {//eğer işçi formundan yönlendirilmişse formu kapatır
                this.Hide();
            }
        }

        SqlConnection connection = new SqlConnection(cs_data.path);//bağlantı oluşturduk

        private void connect()
        {//bağlantı fonksiyonu
            try
            {
                connection.Open();
            }
            catch (Exception x)
            {
                if (MessageBox.Show("veri bağlantısı hatası\n" + x.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void txt_uname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//kullanıcı adı seçiliyken enter tuşuna basılırsa isim kutucuğuna geçer
                txt_name.Focus();
            }
        }

        private void txt_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//bu kutucuk seçiliyken entere basılırsa bir sonraki kutucuğa geçer
                txt_surname.Focus();
            }
        }

        private void txt_surname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//bu kutucuk seçiliyken entere basılırsa bir sonraki kutucuğa geçer
                txt_pass.Focus();
            }
        }

        private void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//bu kutucuk seçiliyken entere basılırsa bir sonraki kutucuğa geçer
                txt_pass2.Focus();
            }
        }

        private void txt_pass2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//bu kutucuk seçiliyken entere basılırsa bir sonraki kutucuğa geçer
                txt_age.Focus();
            }
        }

        private void txt_age_KeyPress(object sender, KeyPressEventArgs e)
        {//yaş kısmına sadece rakam girilebilir 
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_age_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//bu kutucuk seçiliyken entere basılırsa bir sonraki kutucuğa geçer
                txt_mail.Focus();
            }
        }

        private void txt_mail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//bu kutucuk seçiliyken entere basılırsa bir sonraki kutucuğa geçer
                rb_female.Focus();
            }
        }

        private void rb_female_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//bu kutucuk seçiliyken entere basılırsa bir sonraki kutucuğa geçer
                rb_male.Focus();
            }
        }

        private void rb_male_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//bu kutucuk seçiliyken entere basılırsa bir sonraki kutucuğa geçer
                txt_adress.Focus();
            }
        }

        private void txt_adress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//bu kutucuk seçiliyken entere basılırsa bir sonraki kutucuğa geçer
                cb_sales.Focus();
            }
        }

        private void cb_sales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//bu kutucuk seçiliyken entere basılırsa bir sonraki kutucuğa geçer
                cb_prod.Focus();
            }
        }

        private void cb_prod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {//eğer form doluyken entere basılırsa kayıt butonuna tıklar
                btn_register.PerformClick();
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {//girilebilecek karakter sayısını sınırlar
            txt_pass.MaxLength = 20;
        }

        private void txt_pass2_TextChanged(object sender, EventArgs e)
        {//girilebilecek karakter sayısını sınırlar
            txt_pass2.MaxLength = 20;
        }

        private void txt_uname_TextChanged(object sender, EventArgs e)
        {//girilebilecek karakter sayısını sınırlar
            txt_uname.MaxLength = 20;
        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {//girilebilecek karakter sayısını sınırlar
            txt_name.MaxLength = 20;
        }

        private void txt_surname_TextChanged(object sender, EventArgs e)
        {//girilebilecek karakter sayısını sınırlar
            txt_surname.MaxLength = 20;
        }

        private void txt_mail_TextChanged(object sender, EventArgs e)
        {//girilebilecek karakter sayısını sınırlar
            txt_mail.MaxLength = 30;
        }

        private void txt_adress_TextChanged(object sender, EventArgs e)
        {//girilebilecek karakter sayısını sınırlar
            txt_adress.MaxLength = 100;
        }

        private void frm_signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (add == 1)
            {
                Application.ExitThread();
            }
            else
            {
                this.Hide();
            }
        }
    }
}
