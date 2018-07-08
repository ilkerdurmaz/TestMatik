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
namespace TestMatikProje
{
    public partial class Dersler : Form
    {
        public Dersler()
        {
            InitializeComponent();
            baglan= sunucu.server();
        }
        Baglanti sunucu=new Baglanti();
        SqlConnection baglan = new SqlConnection();
        
        SqlCommand komut;   //Bir çok yerde kullanılacak sql
        SqlDataAdapter da;  //nesnelerinin global olarak tanımlanması
        DataSet ds;

        void griddoldur() //ekleme, silme, düzenleme gibi tablonun aslını değiştirien işlemlerden 
        {                 //sonra gridview'in otomatik olarak güncellenmesi için tabloyu tekrar okuyan metod
            da = new SqlDataAdapter("Select *From DERSLER", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "DERSLER");
            dataGridView1.DataSource = ds.Tables["DERSLER"];
            baglan.Close();
        }
        private void Dersler_Load(object sender, EventArgs e)//Form yüklendiği anda hoca tablosundaki hoca no ve hoca adi
        {                                                    //alanlarının, cbHoca,cbHoca2,cbHoca3 isimli comboBox'lara yüklenmesi

            griddoldur();
            baglan.Open();
            komut = new SqlCommand("select * from HOCA", baglan);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                cbHoca.Items.Add(veriOku["HocaNo"] + " - " + veriOku["HocaAdi"]);
                cbHoca2.Items.Add(veriOku["HocaNo"] + " - " + veriOku["HocaAdi"]);
                cbHoca3.Items.Add(veriOku["HocaNo"] + " - " + veriOku["HocaAdi"]);
            }
            veriOku.Close();
            baglan.Close();
        }

        private void bDuzenle_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedRows[0].Index; //gridview'deki seçilen satırın indexini okuma ve secilen degiskenine atma

            int Secmeli;
            if (rbEvet2.Checked) //secmeli olup olmamasına karar vermek için Evet/Hayır radiobutton'undan seçin yapma
                Secmeli = 1;
            else
                Secmeli = 0;

            int kredi, akts, dersSaati, sinif; //integer deger alacak olan ilgili alanların textBoxlar'dan okunup tür değişiminin yapılması
            bool k1 = Int32.TryParse(tKredi2.Text, out kredi);
            bool k2 = Int32.TryParse(tAkts2.Text, out akts);
            bool k3 = Int32.TryParse(tDersSaati2.Text, out dersSaati);
            bool k4 = Int32.TryParse(tSinif2.Text, out sinif);

            if (cbHoca2.SelectedIndex > -1) //hoca adlarının tutan combobox'ın seçilip seçilmediğinin kontrolü
            {
                string hocaNo = "";
                string z = cbHoca2.Items[cbHoca2.SelectedIndex].ToString();
                for (int i = 0; i < z.Length; i++) //hoca seçme combobox'ında hoca no'ları ve isimleri yanyanadır.
                {                                   //seçilen hocanın hoca no'sunu ayıklamak için seçilen index'deki
                    if (z[i] == ' ')                //bilgiden sadece hoca no olan kısmı ayıkladım
                        break;
                    else
                        hocaNo += z[i];
                }

                if (k1 && k2 && k3 && k4) //tür dönüşümlerinin düzgün yapılıp-yapılmadığının kontrolü
            {
                if (tDersAdi2.TextLength > 0) //ders adının girileceği textBox'ın kontrolü
                {
                    try
                    {
                        //sqlserver'a çalıştırılmak üzere gönderilecek olan komut satırı string bir değişkene yazılır

                        string kayit = "update DERSLER set DersAdi=@DersAdi,Kredi=@Kredi,Akts=@Akts,DersSaati=@DersSaati,Sinif=@Sinif,Secmeli=@Secmeli,HocaNo=@HocaNo where DersNo=@DersNo";
                        //kayit ve baglan parametreleri ile komut nesnesi oluşturulur
                        komut = new SqlCommand(kayit, baglan); 
                        baglan.Open();
                        //bağlantı açılarak parametre ile ekleme yöntemi ile komut satırındaki referanslar gerekli yerlere işaret edilir.
                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@DersNo", dataGridView1.Rows[secilen].Cells[0].Value);
                        komut.Parameters.AddWithValue("@DersAdi", tDersAdi2.Text);
                        komut.Parameters.AddWithValue("@Kredi", kredi);
                        komut.Parameters.AddWithValue("@Akts", akts);
                        komut.Parameters.AddWithValue("@DersSaati", dersSaati);
                        komut.Parameters.AddWithValue("@Sinif", sinif);
                        komut.Parameters.AddWithValue("@Secmeli", Secmeli);
                        komut.Parameters.AddWithValue("@HocaNo", hocaNo);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        griddoldur(); //bağlantı kapatıldıktan sonra gridview güncellenir
                    }   
                    catch
                    {
                        MessageBox.Show("DÜZENLEME İŞLEMİ BAŞARISIZ");
                        baglan.Close();
                    }
                }
                else
                    MessageBox.Show("DERS ADI BOŞ BIRAKILAMAZ!");
            }
            else
            {
                MessageBox.Show("LÜTFEN ALANLARI DÜZGÜN GİRİNİZ!");
            }
            }
            else
            {
                MessageBox.Show("LÜTFEN HOCA SEÇİNİZ!");
            }
        }

        private void bEkle_Click(object sender, EventArgs e)// düzenleme ile aynı komutları içeriyor
        {

            int Secmeli;
            if (rbEvet.Checked)
                Secmeli = 1;
            else
                Secmeli = 0;

            int kredi, akts, dersSaati, sinif;
            bool k1 = Int32.TryParse(tKredi.Text, out kredi);
            bool k2 = Int32.TryParse(tAkts.Text, out akts);
            bool k3 = Int32.TryParse(tDersSaati.Text, out dersSaati);
            bool k4 = Int32.TryParse(tSinif.Text, out sinif);


            if (cbHoca.SelectedIndex > -1)
            {
                string hocaNo = "";
                string z = cbHoca.Items[cbHoca.SelectedIndex].ToString();
                for (int i = 0; i < z.Length; i++)
                {
                    if (z[i] == ' ')
                        break;
                    else
                        hocaNo += z[i];
                }
                if (k1&&k2&&k3&&k4)
            {
                if (tDersAdi.TextLength > 0)
                {
                    try
                    {
                        string kayit = "insert into DERSLER(DersAdi,Kredi,Akts,DersSaati,Sinif,Secmeli,HocaNo) values (@DersAdi,@Kredi,@Akts,@DersSaati,@Sinif,@Secmeli,@HocaNo)";

                        komut = new SqlCommand(kayit, baglan);
                        baglan.Open();

                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@DersAdi", tDersAdi.Text);
                        komut.Parameters.AddWithValue("@Kredi", kredi);
                        komut.Parameters.AddWithValue("@Akts", akts);
                        komut.Parameters.AddWithValue("@DersSaati", dersSaati);
                        komut.Parameters.AddWithValue("@Sinif", sinif);
                        komut.Parameters.AddWithValue("@Secmeli", Secmeli);
                        komut.Parameters.AddWithValue("@HocaNo", hocaNo);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        griddoldur();
                    }
                    catch
                    {
                        MessageBox.Show("EKLEME İŞLEMİ BAŞARISIZ");
                        baglan.Close();
                    }
                }
                else
                    MessageBox.Show("DERS ADI BOŞ BIRAKILAMAZ!");
            }
            else
            {
                MessageBox.Show("LÜTFEN ALANLARI DÜZGÜN GİRİNİZ!");
            }
            }
            else
            {
                MessageBox.Show("LÜTFEN HOCA SEÇİNİZ!");
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)//alanların temizlenmesi
        {
            rbHayir.Checked = true;
            tDersAdi.Clear();
            tKredi.Clear();
            tAkts.Clear();
            tSinif.Clear();
            tDersSaati.Clear();
            tDersNoAra.Clear();
        }

        private void tDersNoAra_TextChanged(object sender, EventArgs e) //textBox'a yazılan değere göre gridview'de bu dersNo'yu içeren bilgilerin görüntülenmesi
        {
            int dersNo;
            bool k = Int32.TryParse(tDersNoAra.Text, out dersNo); 

            if (k && dersNo > 0)
            {
                
                da = new SqlDataAdapter("Select *From DERSLER where DersNo=@DersNo", baglan);
                da.SelectCommand.Parameters.AddWithValue("@DersNo", dersNo);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "DERSLER");
                dataGridView1.DataSource = ds.Tables["DERSLER"];
                baglan.Close();
            }
            else
            {
                griddoldur();
            }
        }

        private void tDersNoAra2_TextChanged(object sender, EventArgs e)//textBox'a yazılan değere göre gridview'de bu dersNo'yu içeren bilgilerin görüntülenmesi
        {
            int dersNo;
            bool k = Int32.TryParse(tDersNoAra2.Text, out dersNo);

            if (k && dersNo > 0)
            {

                da = new SqlDataAdapter("Select *From DERSLER where DersNo=@DersNo", baglan);
                da.SelectCommand.Parameters.AddWithValue("@DersNo", dersNo);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "DERSLER");
                dataGridView1.DataSource = ds.Tables["DERSLER"];
                baglan.Close();
            }
            else
            {
                griddoldur();
            }
        }

        private void bTemizle2_Click(object sender, EventArgs e)//alanların temizlenmesi
        {
            rbHayir2.Checked = true;
            tDersAdi2.Clear();
            tKredi2.Clear();
            tAkts2.Clear();
            tSinif2.Clear();
            tDersSaati2.Clear();
            tDersNoAra2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)//textBox'a yazılan değere göre gridview'de bu dersAdi'ni içeren bilgilerin görüntülenmesi
        {
            string dersAdi = tDersAdi3.Text;
            if (tDersAdi3.TextLength > 0)
            {
                da = new SqlDataAdapter("Select *From DERSLER where DersAdi=@DersAdi", baglan);
                da.SelectCommand.Parameters.AddWithValue("@DersAdi", dersAdi);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "DERSLER");
                dataGridView1.DataSource = ds.Tables["DERSLER"];
                baglan.Close();
            }
            else
            {
                MessageBox.Show("LÜTFEN ARANACAK DERSİN ADINI GİRİNİZ");
                griddoldur();
            }
        }

        private void button2_Click(object sender, EventArgs e)//gridview'de seçili olan satırdaki tüm bilgilerin, ilgili tablodan silinmesi
        {
            DialogResult cikti = MessageBox.Show("Seçtiğiniz Dersi Silmek İstediğinizden Emin Misiniz?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo);
            if (cikti == DialogResult.Yes)
            {
                try
                {
                    int secilen = dataGridView1.SelectedRows[0].Index;
                    string kayit = "delete from DERSLER where DersNo=@DersNo";

                    komut = new SqlCommand(kayit, baglan);
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.Parameters.AddWithValue("@DersNo", dataGridView1.Rows[secilen].Cells[0].Value);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    griddoldur();

                }
                catch
                {
                    MessageBox.Show("SİLME İŞLEMİ BAŞARISIZ");
                    baglan.Close();
                }
            }
        }

        private void bListele_Click(object sender, EventArgs e)//seçili olan radioButton'a göre hoca,kredi,ders,sinif ve seçmeli durumuna göre bilgilerin listelenmesi
        {
            if(rbHoca.Checked)
            {
                if (cbHoca3.SelectedIndex > -1)
                {
                    string hocaNo = "";
                    string z = cbHoca3.Items[cbHoca3.SelectedIndex].ToString();
                    for (int i = 0; i < z.Length; i++)
                    {
                        if (z[i] == ' ')
                            break;
                        else
                            hocaNo += z[i];
                    }
                    da = new SqlDataAdapter("Select *From DERSLER where HocaNo=@HocaNo", baglan);
                    da.SelectCommand.Parameters.AddWithValue("@HocaNo", hocaNo);
                    ds = new DataSet();
                    baglan.Open();
                    da.Fill(ds, "DERSLER");
                    dataGridView1.DataSource = ds.Tables["DERSLER"];
                    baglan.Close();
                }
                else
                    MessageBox.Show("ARANACAK HOCA SEÇİNİZ!");
            }
            else if(rbKredi.Checked)
            {
                int kredi;
                bool k1 = Int32.TryParse(tKrediAra.Text, out kredi);
                if (tKrediAra.TextLength > 0)
                {
                    da = new SqlDataAdapter("Select *From DERSLER where Kredi=@Kredi", baglan);
                    da.SelectCommand.Parameters.AddWithValue("@Kredi", kredi);
                    ds = new DataSet();
                    baglan.Open();
                    da.Fill(ds, "DERSLER");
                    dataGridView1.DataSource = ds.Tables["DERSLER"];
                    baglan.Close();
                }
                else
                {
                    MessageBox.Show("ARANACAK ALANI BOŞ BIRAKILAMAZ!");
                    griddoldur();
                }
            }
            else if(rbDersSaati.Checked)
            {
                int dersSaati;
                bool k1 = Int32.TryParse(tDersSaatiAra.Text, out dersSaati);
                if (tDersSaatiAra.TextLength > 0)
                {
                    da = new SqlDataAdapter("Select *From DERSLER where DersSaati=@DersSaati", baglan);
                    da.SelectCommand.Parameters.AddWithValue("@DersSaati", dersSaati);
                    ds = new DataSet();
                    baglan.Open();
                    da.Fill(ds, "DERSLER");
                    dataGridView1.DataSource = ds.Tables["DERSLER"];
                    baglan.Close();
                }
                else
                {
                    MessageBox.Show("ARANACAK ALANI BOŞ BIRAKILAMAZ!");
                    griddoldur();
                }
            }
            else if(rbSinif.Checked)
            {
                int sinif;
                bool k1 = Int32.TryParse(tSinifAra.Text, out sinif);
                if (tSinifAra.TextLength > 0)
                {
                    da = new SqlDataAdapter("Select *From DERSLER where Sinif=@Sinif", baglan);
                    da.SelectCommand.Parameters.AddWithValue("@Sinif", sinif);
                    ds = new DataSet();
                    baglan.Open();
                    da.Fill(ds, "DERSLER");
                    dataGridView1.DataSource = ds.Tables["DERSLER"];
                    baglan.Close();
                }
                else
                {
                    MessageBox.Show("ARANACAK ALANI BOŞ BIRAKILAMAZ!");
                    griddoldur();
                }
            }
            else
            {
                int secmeli;
                if (rbEvet3.Checked)
                    secmeli = 1;
                else
                    secmeli = 0;
                    da = new SqlDataAdapter("Select *From DERSLER where Secmeli=@Secmeli", baglan);
                    da.SelectCommand.Parameters.AddWithValue("@Secmeli", secmeli);
                    ds = new DataSet();
                    baglan.Open();
                    da.Fill(ds, "DERSLER");
                    dataGridView1.DataSource = ds.Tables["DERSLER"];
                    baglan.Close();
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//gridview'in seçili olan satırındaki bilgilerin, düzenleme bölümündeki ilgili alanlara yazılması
        {
            int secilen = dataGridView1.SelectedRows[0].Index;

            tDersAdi2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tKredi2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tAkts2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tDersSaati2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tSinif2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

            int secmeli  =Convert.ToInt32(dataGridView1.Rows[secilen].Cells[6].Value);
            if (secmeli == 1)
                rbEvet2.Checked = true;
            else
                rbHayir2.Checked = true;

            string hocaNo = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            baglan.Open();
            komut = new SqlCommand("select * from HOCA", baglan);
            SqlDataReader veriOku = komut.ExecuteReader();

            while (veriOku.Read())
            {
                if (veriOku["HocaNo"].ToString() == hocaNo)
                {
                    cbHoca2.Text = hocaNo + " - " + veriOku["HocaAdi"];
                }

            }
            veriOku.Close();
            baglan.Close();

        }
    }
    }

