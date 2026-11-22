using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class DatabaseConnection
    {
        private string connectionString =
            @"Server=.\SQLEXPRESS;
              Database=QuanLyThuVien;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
