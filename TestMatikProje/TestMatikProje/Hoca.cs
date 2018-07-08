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
    public partial class Hoca : Form
    {
        public Hoca()
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
            
            da = new SqlDataAdapter("Select *From HOCA", baglan);
            ds = new DataSet();
            baglan.Open();
            da.Fill(ds, "HOCA");
            dataGridView1.DataSource = ds.Tables["HOCA"];
            baglan.Close();
        }



        private void Hoca_Load(object sender, EventArgs e)
        {
            griddoldur();

            baglan.Open();
            komut = new SqlCommand("select * from FAKULTELER", baglan);
            SqlDataReader veriOku = komut.ExecuteReader();
            while (veriOku.Read())
            {
                cbFakulte.Items.Add(veriOku["FakulteNo"] + " - " + veriOku["FakulteAdi"]);
                cbFakulte2.Items.Add(veriOku["FakulteNo"] + " - " + veriOku["FakulteAdi"]);
            }
            veriOku.Close();
            baglan.Close();
        }


        private void bEkle_Click(object sender, EventArgs e)
        {
            if(cbFakulte.SelectedIndex>-1)
            {
                string fakulteNo = "";
                string z = cbFakulte.Items[cbFakulte.SelectedIndex].ToString();
                for (int i = 0; i < z.Length; i++)
                {
                    if (z[i] == ' ')
                        break;
                    else
                        fakulteNo += z[i];
                }
                if (tHocaAdi.TextLength > 0)
                {
                    try
                    {
                        string kayit = "insert into HOCA(HocaAdi,FakulteNo) values (@HocaAdi,@FakulteNo)";

                        komut = new SqlCommand(kayit, baglan);
                        baglan.Open();

                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@HocaAdi", tHocaAdi.Text);
                        komut.Parameters.AddWithValue("@FakulteNo", fakulteNo);
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
                    MessageBox.Show("HOCA ADI BOŞ BIRAKILAMAZ!");
            }
            else
            {
                MessageBox.Show("LÜTFEN FAKÜLTE SEÇİNİZ!");
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tHocaAdi.Clear();
            cbFakulte.SelectedIndex = -1;
            tHocaNoAra.Clear();
            cbFakulte.Text = "";
            tFakulteNoAra.Clear();
        }

        private void bTemizle2_Click(object sender, EventArgs e)
        {
            tHocaAdi2.Clear();
            cbFakulte2.SelectedIndex = -1;
            cbFakulte2.Text = "";
            tHocaNoAra.Clear();
            tFakulteNoAra.Clear();
        }

        private void bDuzenle_Click_1(object sender, EventArgs e)
        {
            int secilen = dataGridView1.SelectedRows[0].Index;

            if (cbFakulte2.SelectedIndex > -1)
            {
                string fakulteNo = "";
                string z = cbFakulte2.Items[cbFakulte2.SelectedIndex].ToString();
                for (int i = 0; i < z.Length; i++)
                {
                    if (z[i] == ' ')
                        break;
                    else
                        fakulteNo += z[i];
                }
                if (tHocaAdi2.TextLength > 0)
                {
                    try
                    {

                        string kayit = "update HOCA set HocaAdi=@HocaAdi,FakulteNo=@FakulteNo where HocaNo=@HocaNo";

                        komut = new SqlCommand(kayit, baglan);
                        baglan.Open();

                        komut.Connection = baglan;
                        komut.Parameters.AddWithValue("@HocaNo", dataGridView1.Rows[secilen].Cells[0].Value);
                        komut.Parameters.AddWithValue("@HocaAdi", tHocaAdi2.Text);
                        komut.Parameters.AddWithValue("@FakulteNo", fakulteNo);
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
                    MessageBox.Show("HOCA ADI BOŞ BIRAKILAMAZ!");
            }
            else
            {
                MessageBox.Show("LÜTFEN FAKULTE SEÇİMİ YAPINIZ!");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedRows[0].Index;

            tHocaAdi2.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            string fakulteNo = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            baglan.Open();
            komut = new SqlCommand("select * from FAKULTELER", baglan);
            SqlDataReader veriOku = komut.ExecuteReader();

            while (veriOku.Read())
            {
                if (veriOku["FakulteNo"].ToString() == fakulteNo)
                {
                    cbFakulte2.Text = fakulteNo + " - " + veriOku["FakulteAdi"];
                }

            }
            veriOku.Close();
            baglan.Close();
        }

        private void tHocaNoAra_TextChanged(object sender, EventArgs e)
        {
            int HocaNo;
            bool k = Int32.TryParse(tHocaNoAra.Text, out HocaNo);

            if (k && HocaNo > 0)
            {
                da = new SqlDataAdapter("Select *From HOCA where HocaNo=@HocaNo", baglan);
                da.SelectCommand.Parameters.AddWithValue("@HocaNo", HocaNo);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "HOCA");
                dataGridView1.DataSource = ds.Tables["HOCA"];
                baglan.Close();
            }
            else
                griddoldur();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int fakulteNo;
            bool k = Int32.TryParse(tFakulteNoAra.Text, out fakulteNo);

            if (k && fakulteNo > 0)
            {
                da = new SqlDataAdapter("Select *From HOCA where FakulteNo=@FakulteNo", baglan);
                da.SelectCommand.Parameters.AddWithValue("@FakulteNo", fakulteNo);
                ds = new DataSet();
                baglan.Open();
                da.Fill(ds, "HOCA");
                dataGridView1.DataSource = ds.Tables["HOCA"];
                baglan.Close();
            }
            else
                griddoldur();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            DialogResult cikti = MessageBox.Show("Seçtiğiniz Hocayı Silmek İstediğinizden Emin Misiniz?", "SİLME İŞLEMİ", MessageBoxButtons.YesNo);
            if (cikti == DialogResult.Yes)
            {
                try
                {
                    int secilen = dataGridView1.SelectedRows[0].Index;
                    string kayit = "delete from HOCA where HocaNo=@HocaNo";

                    komut = new SqlCommand(kayit, baglan);
                    baglan.Open();
                    komut.Connection = baglan;
                    komut.Parameters.AddWithValue("@HocaNo", dataGridView1.Rows[secilen].Cells[0].Value);
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
