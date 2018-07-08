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
using System.Collections; //arraylist kullanabilmek için


namespace TestMatikProje
{
    public partial class SinavHazirla : Form
    {
        public SinavHazirla()
        {
            InitializeComponent();
            baglan = sunucu.server();
        }

        Baglanti sunucu = new Baglanti();
        SqlConnection baglan = new SqlConnection();
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds;
        ArrayList karistirma = new ArrayList();
        int sayac = 0;
        
        
        void SoruDoldur()
        {

            da = new SqlDataAdapter("Select *From SORULAR", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "SORULAR");
            dataGridView1.DataSource = ds.Tables["SORULAR"];
            baglan.Close();
        }//Soru gridview'inin güncellenmesi
        void SinavDoldur()
        {

            da = new SqlDataAdapter("Select *From O_SINAV", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "O_SINAV");
            dataGridView2.DataSource = ds.Tables["O_SINAV"];
            baglan.Close();
        }//Sinav gridview'inin güncellenmesi

        void SoruEkle()
        {                                                      
            try                                               
            {
                
                //sınav gridview'ine ve O_SINAV geçici tablosuna şıkları katışrırarak yazar. Şıkları karıştırma
                //işlemi, önce şıkların bir arrayListe atılması, random sayı oluşturan bir nesne oluşturulması ve
                //bu random sayının işaret ettiği arrayList indexindeki şıkkı başka bir array liste eklemesi şeklinde
                //olmaktadır.  
                int secilen = dataGridView1.SelectedRows[0].Index;
                string dogruCevap = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                int dersNo = (int)dataGridView1.Rows[secilen].Cells[9].Value; ;
                int soruNo = (int)dataGridView1.Rows[secilen].Cells[0].Value;
                string soru = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

                ArrayList cevaplar = new ArrayList();

                if (dataGridView1.Rows[secilen].Cells[2].Value.ToString() != "")
                    cevaplar.Add(dataGridView1.Rows[secilen].Cells[2].Value.ToString());

                if (dataGridView1.Rows[secilen].Cells[3].Value.ToString() != "")
                    cevaplar.Add(dataGridView1.Rows[secilen].Cells[3].Value.ToString());

                if (dataGridView1.Rows[secilen].Cells[4].Value.ToString() != "")
                    cevaplar.Add(dataGridView1.Rows[secilen].Cells[4].Value.ToString());

                if (dataGridView1.Rows[secilen].Cells[5].Value.ToString() != "")
                    cevaplar.Add(dataGridView1.Rows[secilen].Cells[5].Value.ToString());

                if (dataGridView1.Rows[secilen].Cells[6].Value.ToString() != "")
                    cevaplar.Add(dataGridView1.Rows[secilen].Cells[6].Value.ToString());




                Random rnd = new Random();
                ArrayList Rcevaplar = new ArrayList();
                for (int i = 0; i < cevaplar.Count; i++)
                {
                    string cevap = cevaplar[rnd.Next(0, cevaplar.Count)].ToString();
                    if (!Rcevaplar.Contains(cevap))
                        Rcevaplar.Add(cevap);
                    else
                    {
                        if (Rcevaplar.Count == 5)
                            break;
                        else
                            i--;
                    }
                }




                if (Rcevaplar.Count != 0)
                {
                    string kayit = "insert into O_SINAV(Soru,SoruNo,DersNo) values (@Soru,@SoruNo,@DersNo)";

                    komut = new SqlCommand(kayit, baglan);
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.Parameters.AddWithValue("@SoruNo", soruNo);
                    komut.Parameters.AddWithValue("@Soru", soru);
                    komut.Parameters.AddWithValue("@DersNo", dersNo);
                    komut.ExecuteNonQuery();
                    baglan.Close();


                    if (Rcevaplar.Count > 0)
                    {
                        baglan.Open();
                        komut = new SqlCommand("update O_SINAV set A=@A where Soru=@Soru");
                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@Soru", soru);
                        komut.Parameters.AddWithValue("@A", Rcevaplar[0]);
                        komut.ExecuteNonQuery();
                        baglan.Close();

                    }
                    if (Rcevaplar.Count > 1)
                    {
                        baglan.Open();
                        komut = new SqlCommand("update O_SINAV set B=@B where Soru=@Soru");
                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@Soru", soru);
                        komut.Parameters.AddWithValue("@B", Rcevaplar[1]);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                    }
                    if (Rcevaplar.Count > 2)
                    {
                        baglan.Open();
                        komut = new SqlCommand("update O_SINAV set C=@C where Soru=@Soru");
                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@Soru", soru);
                        komut.Parameters.AddWithValue("@C", Rcevaplar[2]);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                    }
                    if (Rcevaplar.Count > 3)
                    {
                        baglan.Open();
                        komut = new SqlCommand("update O_SINAV set D=@D where Soru=@Soru");
                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@Soru", soru);
                        komut.Parameters.AddWithValue("@D", Rcevaplar[3]);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                    }
                    if (Rcevaplar.Count > 4)
                    {
                        baglan.Open();
                        komut = new SqlCommand("update O_SINAV set E=@E where Soru=@Soru");
                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@Soru", soru);
                        komut.Parameters.AddWithValue("@E", Rcevaplar[4]);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                    }

                    SinavDoldur();
                    dataGridView2.Sort(dataGridView2.Columns["O_SoruNo"], ListSortDirection.Ascending); //gridview'i sıralama

                    if (dogruCevap == dataGridView2.Rows[sayac].Cells[3].Value.ToString())
                    {
                        baglan.Open();
                        komut = new SqlCommand("update O_SINAV set DogruCevap='A' where Soru=@Soru");
                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@Soru", soru);
                        komut.Parameters.AddWithValue("@DogruCevap", dogruCevap);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                    }
                    else if (dogruCevap == dataGridView2.Rows[sayac].Cells[4].Value.ToString())
                    {
                        baglan.Open();
                        komut = new SqlCommand("update O_SINAV set DogruCevap='B' where Soru=@Soru");
                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@Soru", soru);
                        komut.Parameters.AddWithValue("@DogruCevap", dogruCevap);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                    }
                    else if (dogruCevap == dataGridView2.Rows[sayac].Cells[5].Value.ToString())
                    {
                        baglan.Open();
                        komut = new SqlCommand("update O_SINAV set DogruCevap='C' where Soru=@Soru");
                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@Soru", soru);
                        komut.Parameters.AddWithValue("@DogruCevap", dogruCevap);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                    }
                    else if (dogruCevap == dataGridView2.Rows[sayac].Cells[6].Value.ToString())
                    {
                        baglan.Open();
                        komut = new SqlCommand("update O_SINAV set DogruCevap='D' where Soru=@Soru");
                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@Soru", soru);
                        komut.Parameters.AddWithValue("@DogruCevap", dogruCevap);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                    }
                    else if (dogruCevap == dataGridView2.Rows[sayac].Cells[7].Value.ToString())
                    {
                        baglan.Open();
                        komut = new SqlCommand("update O_SINAV set DogruCevap='E' where Soru=@Soru");
                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@Soru", soru);
                        komut.Parameters.AddWithValue("@DogruCevap", dogruCevap);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                    }


                    sayac++;
                    karistirma.Add(sayac);
                    laSoruSayisi.Text = sayac.ToString();

                }
                else
                {
                    MessageBox.Show("EKLENECEK SORUNUN TÜM ŞIKLARI BOŞ OLMAMALI!");
                }

                SinavDoldur();
            }
            catch
            {
                MessageBox.Show("EKLEME İŞLEMİ BAŞARISIZ");
                baglan.Close();
            }
        }

        private void SinavHazirla_Load(object sender, EventArgs e)
        {                                                         
            string kayit = "delete from O_SINAV"; //Sadece form açık olduğu sürece kullanılabilen O_SINAV tablosunun
            komut = new SqlCommand(kayit, baglan);//form açılışında bilgilerinin temizlenmesi
            baglan.Open();
            komut.Connection = baglan;
            komut.ExecuteNonQuery();
            baglan.Close();

            kayit = "DBCC CHECKIDENT ('O_SINAV', RESEED,0)"; //identity sıfırlama
            komut = new SqlCommand(kayit, baglan);
            baglan.Open();
            komut.Connection = baglan;
            komut.ExecuteNonQuery();
            baglan.Close();

          

            SoruDoldur();
            SinavDoldur();

            baglan.Open();
            komut = new SqlCommand("select * from DERSLER", baglan);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                cbDers.Items.Add(veriOku["DersNo"] + " - " + veriOku["DersAdi"]); //Ders combobox'ına bilgilerin yüklenmesi
            }
            veriOku.Close();
            baglan.Close();

        }

        private void bSil_Click(object sender, EventArgs e)
        {
            DialogResult cikti = MessageBox.Show("Seçtiğiniz Soruyu Silmek İstediğinizden Emin Misiniz?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo);
            if (cikti == DialogResult.Yes)
            {
                try
                {
                    int secilen = dataGridView2.SelectedRows[0].Index;
                    string kayit = "delete from O_SINAV where O_SoruNo=@O_SoruNo";

                    komut = new SqlCommand(kayit, baglan);
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.Parameters.AddWithValue("@O_SoruNo", dataGridView2.Rows[secilen].Cells[0].Value);
                    komut.ExecuteNonQuery();
                    baglan.Close();
                    SinavDoldur();

                    sayac--;
                    laSoruSayisi.Text = sayac.ToString();
                }
                catch
                {
                    MessageBox.Show("SİLME İŞLEMİ BAŞARISIZ");
                    baglan.Close();
                }
            }
        }

        private void bListele_Click(object sender, EventArgs e)
        {
            if (cbDers.SelectedIndex != -1 && cbZorluk.SelectedIndex != -1)
            {
                string Zorluk = cbZorluk.SelectedItem.ToString();
                string dersNo = "";
                string z = cbDers.Items[cbDers.SelectedIndex].ToString();
                for (int i = 0; i < z.Length; i++)
                {
                    if (z[i] == ' ')
                        break;
                    else
                        dersNo += z[i];
                }


                da = new SqlDataAdapter("Select *From SORULAR where DersNo=@DersNo and Zorluk=@Zorluk", baglan);
                da.SelectCommand.Parameters.AddWithValue("@DersNo", Convert.ToInt32(dersNo));
                da.SelectCommand.Parameters.AddWithValue("@Zorluk", Zorluk);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "SORULAR");
                dataGridView1.DataSource = ds.Tables["SORULAR"];
                baglan.Close();
            }
            else if (cbDers.SelectedIndex != -1)
            {
                string dersNo = "";
                string z = cbDers.Items[cbDers.SelectedIndex].ToString();
                for (int i = 0; i < z.Length; i++)
                {
                    if (z[i] == ' ')
                        break;
                    else
                        dersNo += z[i];
                }

                da = new SqlDataAdapter("Select *From SORULAR where DersNo=@DersNo", baglan);
                da.SelectCommand.Parameters.AddWithValue("@DersNo", Convert.ToInt32(dersNo));
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "SORULAR");
                dataGridView1.DataSource = ds.Tables["SORULAR"];
                baglan.Close();
            }
            else if (cbZorluk.SelectedIndex != -1)
            {

                string Zorluk = cbZorluk.SelectedItem.ToString();
                da = new SqlDataAdapter("Select *From SORULAR where Zorluk=@Zorluk", baglan);
                da.SelectCommand.Parameters.AddWithValue("@Zorluk", Zorluk);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "SORULAR");
                dataGridView1.DataSource = ds.Tables["SORULAR"];
                baglan.Close();
            }
            else
            {
                SoruDoldur();
                MessageBox.Show("Listeleme Kriteri Seçmediniz!");
            }
        }

        private void bAra_Click(object sender, EventArgs e)
        {
            string Soru = tSoruAra.Text;
            if (tSoruAra.TextLength > 0)
            {
                da = new SqlDataAdapter("Select *From SORULAR where Soru=@Soru", baglan);
                da.SelectCommand.Parameters.AddWithValue("@Soru", Soru);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "SORULAR");
                dataGridView1.DataSource = ds.Tables["SORULAR"];
                baglan.Close();
            }
            else
            {
                MessageBox.Show("LÜTFEN ARANACAK SORUYU GİRİNİZ");
                SoruDoldur();
            }
        }

        private void tSoruNoAra_TextChanged(object sender, EventArgs e)
        {
            int soruNo;
            bool k = Int32.TryParse(tSoruNoAra.Text, out soruNo);

            if (k && soruNo > 0)
            {
                da = new SqlDataAdapter("Select *From SORULAR where SoruNo=@SoruNo", baglan);
                da.SelectCommand.Parameters.AddWithValue("@SoruNo", soruNo);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "SORULAR");
                dataGridView1.DataSource = ds.Tables["SORULAR"];
                baglan.Close();
            }
            else
                SoruDoldur();
        }

        private void SinavOlustur_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                e.Cancel = true;

            }

        }//form kapatıldığında O_SINAV tablosu silineceği için kapatma tuşuna basıldığında tekrar sorması

        private void bKaydet_Click(object sender, EventArgs e)//Sınav gridview'indeki soruların SinavAdi ile, soruların sırası karıştırılarak ARSIV tablosuna eklenmesi
        {                                                     //Soruların yerlerinin karıştırılması işlemi, soru sıralarının bir arrayList'e atılması ve random sayı üreterek
                                                              //arrayList'in o sayı index'indeki soru sırasınına göre ARSIV tablosuna eklenmesi şeklindedir.

           try
            {
                if (rbTek.Checked)
                {
                    string sinavAdi = tSinavAdi.Text;
                    if (tSinavAdi.TextLength > 0)
                    {
                        ArrayList z = new ArrayList();
                        Random rnd = new Random();
                        for (int i = 0; i <= sayac; i++)
                        {
                            int sira = (int)karistirma[rnd.Next(0, sayac)];
                            if (!z.Contains(sira))
                            {
                                z.Add(sira);
                                string kayit = "insert into ARSIV(SoruNo,SinavAdi,Soru,A,B,C,D,E,DogruCevap) values (@SoruNo,@SinavAdi,@Soru,@A,@B,@C,@D,@E,@DogruCevap)";

                                komut = new SqlCommand(kayit, baglan);
                                baglan.Open();

                                komut.Connection = baglan;
                                komut.Parameters.AddWithValue("@SoruNo", dataGridView2.Rows[sira - 1].Cells[1].Value);
                                komut.Parameters.AddWithValue("@SinavAdi", tSinavAdi.Text);
                                komut.Parameters.AddWithValue("@Soru", dataGridView2.Rows[sira - 1].Cells[2].Value);
                                komut.Parameters.AddWithValue("@A", "A)" + dataGridView2.Rows[sira - 1].Cells[3].Value);
                                komut.Parameters.AddWithValue("@B", "B)" + dataGridView2.Rows[sira - 1].Cells[4].Value);
                                komut.Parameters.AddWithValue("@C", "C)" + dataGridView2.Rows[sira - 1].Cells[5].Value);
                                komut.Parameters.AddWithValue("@D", "D)" + dataGridView2.Rows[sira - 1].Cells[6].Value);
                                komut.Parameters.AddWithValue("@E", "E)" + dataGridView2.Rows[sira - 1].Cells[7].Value);
                                komut.Parameters.AddWithValue("@DogruCevap", dataGridView2.Rows[sira - 1].Cells[8].Value);
                                komut.ExecuteNonQuery();
                                baglan.Close();

                            }
                            else
                            {
                                if (z.Count == sayac)
                                    break;
                                else
                                    i--;
                            }
                        }

                        string kayit2 = "insert into SINAVLAR(SinavAdi,OlusturmaTarihi) values (@SinavAdi,@OlusturmaTarihi)\ndelete from O_SINAV";

                        komut = new SqlCommand(kayit2, baglan);
                        baglan.Open();

                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@SinavAdi", tSinavAdi.Text);
                        komut.Parameters.AddWithValue("@OlusturmaTarihi", DateTime.Today);
                        komut.ExecuteNonQuery();
                        baglan.Close();

                        MessageBox.Show("KAYDETME İŞLEMİ BAŞARILI");
                        SinavDoldur();
                        sayac = 0;
                        karistirma.Clear();
                    }
                    else
                        MessageBox.Show("SINAV ADI BOŞ BIRAKILAMAZ!");
                }
                else if (rbNum.Checked)
                {
                    int grup;
                    bool k = Int32.TryParse(tGrup.Text, out grup);

                    if (k)
                    {
                        string sinavAdi = tSinavAdi.Text;
                        if (tSinavAdi.TextLength > 0)
                        {
                            for (int o = 0; o < grup; o++)
                            {
                                ArrayList z = new ArrayList();
                                Random rnd = new Random();
                                for (int i = 0; i <= sayac; i++)
                                {
                                    int sira = (int)karistirma[rnd.Next(0, sayac)];
                                    if (!z.Contains(sira))
                                    {
                                        z.Add(sira);
                                        string kayit = "insert into ARSIV(SoruNo,SinavAdi,Soru,A,B,C,D,E,DogruCevap) values (@SoruNo,@SinavAdi,@Soru,@A,@B,@C,@D,@E,@DogruCevap)";

                                        komut = new SqlCommand(kayit, baglan);
                                        baglan.Open();

                                        komut.Connection = baglan;
                                        komut.Parameters.AddWithValue("@SoruNo", dataGridView2.Rows[sira - 1].Cells[1].Value);
                                        komut.Parameters.AddWithValue("@SinavAdi", tSinavAdi.Text + " GRUP-" + (o + 1));
                                        komut.Parameters.AddWithValue("@Soru", dataGridView2.Rows[sira - 1].Cells[2].Value);
                                        komut.Parameters.AddWithValue("@A", "A)" + dataGridView2.Rows[sira - 1].Cells[3].Value);
                                        komut.Parameters.AddWithValue("@B", "B)" + dataGridView2.Rows[sira - 1].Cells[4].Value);
                                        komut.Parameters.AddWithValue("@C", "C)" + dataGridView2.Rows[sira - 1].Cells[5].Value);
                                        komut.Parameters.AddWithValue("@D", "D)" + dataGridView2.Rows[sira - 1].Cells[6].Value);
                                        komut.Parameters.AddWithValue("@E", "E)" + dataGridView2.Rows[sira - 1].Cells[7].Value);
                                        komut.Parameters.AddWithValue("@DogruCevap", dataGridView2.Rows[sira - 1].Cells[8].Value);
                                        komut.ExecuteNonQuery();
                                        baglan.Close();

                                    }
                                    else
                                    {
                                        if (z.Count == sayac)
                                            break;
                                        else
                                            i--;
                                    }
                                }

                                string kayit2 = "insert into SINAVLAR(SinavAdi,OlusturmaTarihi) values (@SinavAdi,@OlusturmaTarihi)";

                                komut = new SqlCommand(kayit2, baglan);
                                baglan.Open();

                                komut.Connection = baglan;
                                komut.Parameters.AddWithValue("@SinavAdi", tSinavAdi.Text + " GRUP-" + (o + 1));
                                komut.Parameters.AddWithValue("@OlusturmaTarihi", DateTime.Today);
                                komut.ExecuteNonQuery();
                                baglan.Close();
                                System.Threading.Thread.Sleep(10); // Soruların yerinin düzgün karışması için 10 milisaniye bekleme komutu                    
                            }
                            MessageBox.Show("KAYDETME İŞLEMİ BAŞARILI");
                            karistirma.Clear();
                            sayac = 0;
                          

                        }
                        else
                            MessageBox.Show("SINAV ADI BOŞ BIRAKILAMAZ!");
                    }
                    else
                        MessageBox.Show("LUTFEN GRUP SAYISI GİRİNİZ!");
                }
                else if (rbAlfa.Checked)
                {
                    int grup;
                    bool k = Int32.TryParse(tGrup.Text, out grup);

                    if (k)
                    {
                        string sinavAdi = tSinavAdi.Text;
                        if (tSinavAdi.TextLength > 0)
                        {
                            for (int o = 0; o < grup; o++)
                            {
                                char karakter = Convert.ToChar(o + 65);
                                ArrayList z = new ArrayList();
                                Random rnd = new Random();
                                for (int i = 0; i <= sayac; i++)
                                {
                                    int sira = (int)karistirma[rnd.Next(0, sayac)];
                                    if (!z.Contains(sira))
                                    {
                                        z.Add(sira);
                                        string kayit = "insert into ARSIV(SoruNo,SinavAdi,Soru,A,B,C,D,E,DogruCevap) values (@SoruNo,@SinavAdi,@Soru,@A,@B,@C,@D,@E,@DogruCevap)";

                                        komut = new SqlCommand(kayit, baglan);
                                        baglan.Open();

                                        komut.Connection = baglan;
                                        komut.Parameters.AddWithValue("@SoruNo", dataGridView2.Rows[sira - 1].Cells[1].Value);
                                        komut.Parameters.AddWithValue("@SinavAdi", tSinavAdi.Text + " GRUP-" + karakter);
                                        komut.Parameters.AddWithValue("@Soru", dataGridView2.Rows[sira - 1].Cells[2].Value);
                                        komut.Parameters.AddWithValue("@A", "A)" + dataGridView2.Rows[sira - 1].Cells[3].Value);
                                        komut.Parameters.AddWithValue("@B", "B)" + dataGridView2.Rows[sira - 1].Cells[4].Value);
                                        komut.Parameters.AddWithValue("@C", "C)" + dataGridView2.Rows[sira - 1].Cells[5].Value);
                                        komut.Parameters.AddWithValue("@D", "D)" + dataGridView2.Rows[sira - 1].Cells[6].Value);
                                        komut.Parameters.AddWithValue("@E", "E)" + dataGridView2.Rows[sira - 1].Cells[7].Value);
                                        komut.Parameters.AddWithValue("@DogruCevap", dataGridView2.Rows[sira - 1].Cells[8].Value);
                                        komut.ExecuteNonQuery();
                                        baglan.Close();

                                    }
                                    else
                                    {
                                        if (z.Count == sayac)
                                            break;
                                        else
                                            i--;
                                    }
                                }

                                string kayit2 = "insert into SINAVLAR(SinavAdi,OlusturmaTarihi) values (@SinavAdi,@OlusturmaTarihi)";

                                komut = new SqlCommand(kayit2, baglan);
                                baglan.Open();

                                komut.Connection = baglan;
                                komut.Parameters.AddWithValue("@SinavAdi", tSinavAdi.Text + " GRUP-" + karakter);
                                komut.Parameters.AddWithValue("@OlusturmaTarihi", DateTime.Today);
                                komut.ExecuteNonQuery();
                                baglan.Close();
                                System.Threading.Thread.Sleep(10); // Soruların yerinin düzgün karışması için 10 milisaniye bekleme komutu
                            }
                            MessageBox.Show("KAYDETME İŞLEMİ BAŞARILI");
                            karistirma.Clear();
                            sayac = 0;
                          
                        }
                        else
                            MessageBox.Show("SINAV ADI BOŞ BIRAKILAMAZ!");
                    }
                    else
                        MessageBox.Show("LUTFEN GRUP SAYISI GİRİNİZ!");
                }
            }
            catch
            { MessageBox.Show("KAYDETME İŞLEMİ BAŞARISIZ"); }
        }

        private void bEkle_Click(object sender, EventArgs e)
        {
            SoruEkle();
        }
        
        private void bMiktarlaSoruEkle_Click(object sender, EventArgs e)//Inputbox'dan alınan soru miktarı kadar soru ekleme
        {
            
            int miktar;
            string mktr = Microsoft.VisualBasic.Interaction.InputBox("Eklenecek Soru Miktarını Giriniz", "SORU MİKTARI", "", 500, 250);
            bool k = Int32.TryParse(mktr, out miktar);
            
            
            if ((miktar + sayac) <= dataGridView1.Rows.Count)
                {
                if (k)
                {
                    for (int i = 0; i < miktar; i++)
                    {
                        
                        dataGridView1.Rows[sayac].Selected = true;
                        SoruEkle();
                        System.Threading.Thread.Sleep(5); // Şıkların yerinin düzgün karışması için 10 milisaniye bekleme komutu
                    }
                }
            }
            else
            {
                MessageBox.Show("GİRİLEN MİKTAR KADAR (EKLENMEMİŞ)SORU BULUNMAMAKTADIR!");
            }
            dataGridView1.Rows[0].Selected = true;


        }

        private void rbNum_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNum.Checked)
                tGrup.Enabled = true;
        }//radioBox'ların durumuna göre grup girme textbox'ını aktifleştirme/deaktifleştirme

        private void rbAlfa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlfa.Checked)
                tGrup.Enabled = true;
        }//radioBox'ların durumuna göre grup girme textbox'ını aktifleştirme/deaktifleştirme

        private void rbTek_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTek.Checked)
                tGrup.Enabled = false;
        }//radioBox'ların durumuna göre grup girme textbox'ını aktifleştirme/deaktifleştirme
    }
}
