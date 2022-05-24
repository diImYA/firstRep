using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Data.SqlClient;

namespace LogAReg
{
    //Encrypt=False
    class Connect
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-AK89O21;Initial Catalog=check1;Integrated Security=True;TrustServerCertificate=True;");

        public void OpenConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
        }
        public void ClosedConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
