using System.Data.SqlClient;

namespace QuanLyUser
{
    public class DBConnection
    {
        private string connectionString =
            @"Server=localhost\SQLEXPRESS02;
              Database=QuanLyThuVien;
              Trusted_Connection=True;
              TrustServerCertificate=True";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}