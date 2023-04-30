using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UAS_Muhammad_Rahman.Kelas
{
    class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source= Rahman\\SQLEXPRESS; Initial Catalog=UAS_21312027;  Integrated Security=true";
            return conn;
        }
    }
}
