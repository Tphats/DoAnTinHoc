using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyAccount
{
    internal class cDocGia
    {
            [Serializable]
            public class CDocGia
        {
            private string m_madg, m_hoten, m_diachi, m_sodt, m_email;
            private DateTime m_ngaysinh;       
            private bool m_phai;               
            public string MaDG
            {
                get { return m_madg; }
                set { m_madg = value; }
            }
            public string HoTen
            {
                get { return m_hoten; }
                set { m_hoten = value; }
            }
            public DateTime NgaySinh
            {
                get { return m_ngaysinh; }
                set { m_ngaysinh = value; }
            }
            public bool Phai
            {
                get { return m_phai; }
                set { m_phai = value; }
            }
            public string DiaChi
            {
                get { return m_diachi; }
                set { m_diachi = value; }
            }
            public string SoDT
            {
                get { return m_sodt; }
                set { m_sodt = value; }
            }
            public string Email
            {
                get { return m_email; }
                set { m_email = value; }
            }
            public string GioiTinh
            {
                get { return m_phai ? "Nam" : "Nữ"; }
            }
            public CDocGia()
            {
                m_madg = "";
                m_hoten = "";
                m_ngaysinh = DateTime.Today;   
                m_phai = true;
                m_diachi = "";
                m_sodt = "";
                m_email = "";
            }
            public CDocGia(string ma, string ten, DateTime ngaysinh, bool phai,
                           string diachi, string sodt, string email)
            {
                m_madg = ma;
                m_hoten = ten;
                m_ngaysinh = ngaysinh;
                m_phai = phai;
                m_diachi = diachi;
                m_sodt = sodt;
                m_email = email;
            }
        }
        public class CXuLyDocGia
        {
            private Dictionary<string, CDocGia> dsDocGia;
            private string tenFile = "docgia.dat";
            public CXuLyDocGia()
            {
                dsDocGia = new Dictionary<string, CDocGia>();
            }
            public List<CDocGia> layDSDocGia()
            {
                return dsDocGia.Values.ToList();
            }
            public CDocGia tim(string ma)
            {
                if (dsDocGia.ContainsKey(ma))      
                    return dsDocGia[ma];          
                return null;
            }
            public bool them(CDocGia d)
            {
                if (tim(d.MaDG) != null)          
                    return false;
                dsDocGia.Add(d.MaDG, d);          
                return true;
            }
            public bool xoa(string ma)
            {
                if (tim(ma) == null)
                    return false;
                dsDocGia.Remove(ma);              
                return true;
            }
            public bool sua(CDocGia d)
            {
                if (tim(d.MaDG) == null)           
                    return false;
                dsDocGia[d.MaDG] = d;             
                return true;
            }
            public List<CDocGia> timKiem(string tuKhoa)
            {
                List<CDocGia> kq = new List<CDocGia>();      
                string tk = tuKhoa.Trim().ToLower();         
                foreach (CDocGia d in dsDocGia.Values)      
                {
                    if (d.MaDG.ToLower().Contains(tk) || d.HoTen.ToLower().Contains(tk))
                        kq.Add(d);
                }
                return kq;
            }
            public void ghiFile()
            {
                FileStream fs = new FileStream(tenFile, FileMode.Create);
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, dsDocGia);    
                }
                finally
                {
                    fs.Close();                    
                }
            }
            public void docFile()
            {
                if (!File.Exists(tenFile))         
                    return;

                FileStream fs = new FileStream(tenFile, FileMode.Open);
                try
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    dsDocGia = (Dictionary<string, CDocGia>)bf.Deserialize(fs);
                }
                catch (Exception)
                {
                    dsDocGia = new Dictionary<string, CDocGia>();
                }
                finally
                {
                    fs.Close();
                }
            }

            
        }
    }

}

