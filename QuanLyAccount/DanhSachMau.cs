using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien
{
    internal class DanhSachMau
    {
        // Nạp 20 cuốn sách mẫu vào danh sách.
        // Các mã (tác giả, NXB, thể loại) và số lượng chỉ là dữ liệu mẫu,
        // hãy đổi cho khớp với dữ liệu thật trong CSDL của bạn.
        public static void NapDanhSachMau(List<CSach> danhsachSach)
        {
            danhsachSach.AddRange(new List<CSach>
            {
                // Thể loại: TL01 = Văn học, TL02 = Kỹ năng sống,
                //           TL03 = Công nghệ thông tin, TL04 = Khoa học - Lịch sử
                TaoSach("S001", "Dế Mèn phiêu lưu ký",              "TG001", "NXB01", "TL01", 1941, 30),
                TaoSach("S002", "Số đỏ",                            "TG002", "NXB01", "TL01", 1936, 25),
                TaoSach("S003", "Tắt đèn",                          "TG003", "NXB01", "TL01", 1939, 20),
                TaoSach("S004", "Chí Phèo",                         "TG004", "NXB01", "TL01", 1941, 40),
                TaoSach("S005", "Truyện Kiều",                      "TG005", "NXB01", "TL01", 1820, 15),
                TaoSach("S006", "Nhà giả kim",                      "TG006", "NXB02", "TL01", 1988, 35),
                TaoSach("S007", "Đắc nhân tâm",                     "TG007", "NXB03", "TL02", 1936, 50),
                TaoSach("S008", "Cho tôi xin một vé đi tuổi thơ",   "TG008", "NXB02", "TL01", 2008, 28),
                TaoSach("S009", "Mắt biếc",                         "TG008", "NXB02", "TL01", 1990, 32),
                TaoSach("S010", "Tôi thấy hoa vàng trên cỏ xanh",   "TG008", "NXB02", "TL01", 2010, 45),
                TaoSach("S011", "Lập trình C# cơ bản",              "TG009", "NXB04", "TL03", 2020, 18),
                TaoSach("S012", "Cấu trúc dữ liệu và giải thuật",   "TG010", "NXB04", "TL03", 2018, 12),
                TaoSach("S013", "Cơ sở dữ liệu",                    "TG011", "NXB04", "TL03", 2021, 22),
                TaoSach("S014", "Lập trình hướng đối tượng",        "TG012", "NXB04", "TL03", 2019, 16),
                TaoSach("S015", "Mạng máy tính",                    "TG013", "NXB04", "TL03", 2017, 14),
                TaoSach("S016", "Hệ điều hành",                     "TG014", "NXB04", "TL03", 2016, 10),
                TaoSach("S017", "Phân tích thiết kế hệ thống",      "TG015", "NXB04", "TL03", 2022, 9),
                TaoSach("S018", "Trí tuệ nhân tạo",                 "TG016", "NXB04", "TL03", 2023, 20),
                TaoSach("S019", "Sapiens: Lược sử loài người",      "TG017", "NXB05", "TL04", 2011, 26),
                TaoSach("S020", "Harry Potter và Hòn đá Phù thủy",  "TG018", "NXB06", "TL01", 1997, 38)
            });
        }

        // Tạo một CSach bằng thuộc tính, không phụ thuộc vào thứ tự tham số của hàm khởi tạo.
        // Năm xuất bản được lưu thành DateTime (ngày 01/01 của năm đó).
        private static CSach TaoSach(string masach, string tensach, string matacgia,
                                     string manxb, string matheloai, int namxuatban, int soluong)
        {
            return new CSach
            {
                Masach = masach,
                Tensach = tensach,
                Matacgia = matacgia,
                MaNXB = manxb,
                Matheloai = matheloai,
                Namxuatban = new DateTime(namxuatban, 1, 1),
                Soluong = soluong
            };
        }
    }
}