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
using System.Collections;

namespace TestMatikProje
{
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
            baglan = sunucu.server();
        }
        Baglanti sunucu = new Baglanti();
        SqlConnection baglan = new SqlConnection();
        DataTable tablo = new DataTable();
        SqlDataAdapter da;


        private void Raporlama_Load(object sender, EventArgs e)//form yüklendiğinde dataAdapter'in tablo adlı dataTable nesnesini doldurması ve 
        {                                                      //rapor isimli CrystalReport nesnesine kaynak olarak gösterilmesi. Ardından 
            da = new SqlDataAdapter("Select * from TEMP", baglan);//crystalReportViewer göstericisine rapor eklenerek raporlamayı sağlaması.
            da.Fill(tablo);
            CrystalReport2 rapor = new CrystalReport2();
            rapor.SetDataSource(tablo);
            crystalReportViewer1.ReportSource = rapor;
        }
    }
}
