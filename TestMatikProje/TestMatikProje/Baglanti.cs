using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace TestMatikProje
{
    public class Baglanti
    {
        SqlConnection baglan;
        public  Baglanti()
        {
            baglan = new SqlConnection("Data Source =localhost; Initial Catalog = testmatik; Integrated Security = True");
        }

        public SqlConnection server()
        {
            return baglan;
        }
    }
}
