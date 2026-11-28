using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyThuVien
{
    internal class XuLyDuLieu
    {
        public static int LayMaTheoTen(
                                        string Table,
                                        string KeyName,
                                        string tenCotTen,
                                        string tenCanTim)
        {
            DBConnection Connect = new DBConnection();
            using (SqlConnection conn = Connect.GetConnection())
            {
                conn.Open();

                string sql = $"SELECT {KeyName} FROM {Table} WHERE {tenCotTen} = @Ten";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Ten", SqlDbType.NVarChar).Value = tenCanTim;

                    object ketQua = cmd.ExecuteScalar();

                    if (ketQua != null && ketQua != DBNull.Value)
                        return Convert.ToInt32(ketQua);

                    return -1;
                }
            }
        }
        public static string LayTenTheoMa(string Table, string KeyName, string Colum, int key)
        {
            DBConnection Connect = new DBConnection();
            using (SqlConnection conn = Connect.GetConnection())
            {
                conn.Open();

                string sql = $"SELECT {Colum} FROM {Table} WHERE {KeyName} = @Ma";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Ma", SqlDbType.Int).Value = key;

                    object ketQua = cmd.ExecuteScalar();

                    if (ketQua != null && ketQua != DBNull.Value)
                        return ketQua.ToString();

                    return "";
                }
            }
        }
        public static void CapNhatTrangThaiQuaHan()
        {
            DBConnection Connect = new DBConnection();
            using (SqlConnection conn = Connect.GetConnection())
            {
                conn.Open();

                string sql = @"UPDATE PhieuMuon
                       SET TrangThai = N'Quá hạn'
                       WHERE CAST(GETDATE() AS DATE) > CAST(HanTra AS DATE)
                       AND TrangThai = N'Đang mượn'";

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
