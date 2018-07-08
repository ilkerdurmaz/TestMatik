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
    public partial class Sorular : Form
    {
        
        
        public Sorular()
        {
            InitializeComponent();
            baglan = sunucu.server();
        }
        Baglanti sunucu = new Baglanti();
        SqlConnection baglan = new SqlConnection();
        SqlCommand komut;
        SqlDataAdapter da;
        DataSet ds;

        void griddoldur()
        {
            
            da = new SqlDataAdapter("Select *From SORULAR", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "SORULAR");
            dataGridView1.DataSource = ds.Tables["SORULAR"];
            baglan.Close();
        }
        

        private void Sorular_Load(object sender, EventArgs e)
        {
            griddoldur();
            baglan.Open();
            komut = new SqlCommand("select * from DERSLER",baglan);
            SqlDataReader veriOku = komut.ExecuteReader();
            while(veriOku.Read())
            {
                cbDers.Items.Add(veriOku["DersNo"]+" - "+veriOku["DersAdi"]);
                cbDers2.Items.Add(veriOku["DersNo"] + " - " + veriOku["DersAdi"]);
                cbDers3.Items.Add(veriOku["DersNo"] + " - " + veriOku["DersAdi"]);
            }
            veriOku.Close();
            baglan.Close();
            
        }
        
        private void bEkle_Click(object sender, EventArgs e)
        {
            string Zorluk;
            if (rbKolay.Checked)
                Zorluk = "Kolay";
            else if (rbOrta.Checked)
                Zorluk = "Orta";
            else
                Zorluk = "Zor";

            if (cbDers.SelectedIndex > -1)
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
                if (tSoru.TextLength > 0)
                {
                    try
                    {

                        string kayit = "insert into SORULAR(Soru,A_Cevap,B,C,D,E,Zorluk,SorulmaSayisi,DersNo) values (@Soru,@A_Cevap,@B,@C,@D,@E,@Zorluk,@SorulmaSayisi,@DersNo)";

                        komut = new SqlCommand(kayit, baglan);
                        baglan.Open();

                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@Soru", tSoru.Text);
                        komut.Parameters.AddWithValue("@A_Cevap", tA.Text);
                        komut.Parameters.AddWithValue("@B", tB.Text);
                        komut.Parameters.AddWithValue("@C", tC.Text);
                        komut.Parameters.AddWithValue("@D", tD.Text);
                        komut.Parameters.AddWithValue("@E", tE.Text);
                        komut.Parameters.AddWithValue("@Zorluk", Zorluk);
                        komut.Parameters.AddWithValue("@SorulmaSayisi", 0);
                        komut.Parameters.AddWithValue("@DersNo", dersNo);
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
                    MessageBox.Show("SORU BOŞ BIRAKILAMAZ!");
            }
            else
            {
                MessageBox.Show("LÜTFEN DERS SEÇİMİ YAPINIZ!");
            }




            
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tSoru.Clear();
            tA.Clear();
            tB.Clear();
            tC.Clear();
            tD.Clear();
            tE.Clear();
            rbOrta.Checked = true;
            cbDers.SelectedIndex = -1;
        }

        private void bDuzenle_Click(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedRows[0].Index;

            string Zorluk;
            if (rbKolay2.Checked)
                Zorluk = "Kolay";
            else if (rbOrta2.Checked)
                Zorluk = "Orta";
            else
                Zorluk = "Zor";

            if (cbDers2.SelectedIndex > -1)
            {
                string dersNo = "";
                string z = cbDers2.Items[cbDers2.SelectedIndex].ToString();
                for (int i = 0; i < z.Length; i++)
                {
                    if (z[i] == ' ')
                        break;
                    else
                        dersNo += z[i];
                }
                if (tSoru2.TextLength > 0)
                {
                    try
                    {


                        string kayit = "update SORULAR set Soru=@Soru,A_Cevap=@A_Cevap,B=@B,C=@C,D=@D,E=@E,Zorluk=@Zorluk,DersNo=@DersNo where SoruNo=@SoruNo";

                        komut = new SqlCommand(kayit, baglan);
                        baglan.Open();

                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@SoruNo", dataGridView1.Rows[secilen].Cells[0].Value);
                        komut.Parameters.AddWithValue("@Soru", tSoru2.Text);
                        komut.Parameters.AddWithValue("@A_Cevap", tA2.Text);
                        komut.Parameters.AddWithValue("@B", tB2.Text);
                        komut.Parameters.AddWithValue("@C", tC2.Text);
                        komut.Parameters.AddWithValue("@D", tD2.Text);
                        komut.Parameters.AddWithValue("@E", tE2.Text);
                        komut.Parameters.AddWithValue("@Zorluk", Zorluk);
                        komut.Parameters.AddWithValue("@DersNo", dersNo);
                        komut.ExecuteNonQuery();
                        baglan.Close();
                        griddoldur();
                        
                    }
                    catch
                    {
                        MessageBox.Show("DÜZENLEME İŞLEMİ BAŞARISIZ");
                        baglan.Close();
                    }
                }
                else
                    MessageBox.Show("SORU BOŞ BIRAKILAMAZ!");
            }
            else
            {
                MessageBox.Show("LÜTFEN DERS SEÇİMİ YAPINIZ!");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen= dataGridView1.SelectedRows[0].Index;
          
            tSoru2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tA2.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            tB2.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tC2.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tD2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            tE2.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            string zorluk = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

            if (zorluk == "Kolay")
                rbKolay2.Checked = true;
            else if (zorluk == "Orta")
                rbOrta2.Checked = true;
            else
                rbZor2.Checked = true;


            string dersNo= dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            baglan.Open();
            komut = new SqlCommand("select * from DERSLER", baglan);
            SqlDataReader veriOku = komut.ExecuteReader();

            while (veriOku.Read())
            {
                if (veriOku["DersNo"].ToString() == dersNo)
                {
                    cbDers2.Text = dersNo+" - "+veriOku["DersAdi"];
                }
                    
            }
            veriOku.Close();
            baglan.Close();



        }

        private void bTemizle2_Click(object sender, EventArgs e)
        {
            tSoru2.Clear();
            tA2.Clear();
            tB2.Clear();
            tC2.Clear();
            tD2.Clear();
            tE2.Clear();
            rbOrta2.Checked = true;
            cbDers2.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void bSoruNoAra_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("Select *From SORULAR where SoruNo=@SoruNo", baglan);
            da.SelectCommand.Parameters.AddWithValue("@SoruNo", Convert.ToInt32(tSoruNoAra.Text));
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "SORULAR");
            dataGridView1.DataSource = ds.Tables["SORULAR"];
            baglan.Close();

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
                griddoldur();
        }

        private void tSoruNoAra2_TextChanged(object sender, EventArgs e)
        {
            int soruNo;
            bool k = Int32.TryParse(tSoruNoAra2.Text, out soruNo);

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
                griddoldur();
        }

        private void bListele_Click(object sender, EventArgs e)
        {
            if (cbDers3.SelectedIndex != -1 && cbZorluk.SelectedIndex != -1)
            {
                string Zorluk = cbZorluk.SelectedItem.ToString();
                string dersNo = "";
                string z = cbDers3.Items[cbDers3.SelectedIndex].ToString();
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
            else if (cbDers3.SelectedIndex != -1)
            {
                string dersNo = "";
                string z = cbDers3.Items[cbDers3.SelectedIndex].ToString();
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
                griddoldur();
                MessageBox.Show("Listeleme Kriteri Seçmediniz!");
            }
        }

        private void tSoruNoAra3_TextChanged(object sender, EventArgs e)
        {
            int soruNo;
            bool k = Int32.TryParse(tSoruNoAra3.Text, out soruNo);

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
                griddoldur();
        }

        private void bSoruAra_Click(object sender, EventArgs e)
        {

            string Soru = tSoru3.Text;
            if (tSoru3.TextLength > 0)
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
                griddoldur();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbDers3.SelectedIndex = -1;
            cbZorluk.SelectedIndex = -1;
            tSoruNoAra3.Clear();
            tSoru3.Clear();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            DialogResult cikti = MessageBox.Show("Seçtiğiniz Soruyu Silmek İstediğinizden Emin Misiniz?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo);
            if (cikti == DialogResult.Yes)
            {
                try
                {
                    int secilen = dataGridView1.SelectedRows[0].Index;
                    string kayit = "delete from SORULAR where SoruNo=@SoruNo";

                    komut = new SqlCommand(kayit, baglan);
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.Parameters.AddWithValue("@SoruNo", dataGridView1.Rows[secilen].Cells[0].Value);
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
    }
}
