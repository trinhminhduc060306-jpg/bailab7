using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Lab07_ADONET_Connection
{
    public static class DbConnectionFactory
    {
        private const string ConnectionString =
@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLSinhVien;Integrated Security=True";

        public static SqlConnection Create()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
