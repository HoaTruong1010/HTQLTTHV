using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HeThongQuanLyTTHV.QLHV
{
    class PhuongThuc
    {
        public static void GhiFileStudentList(string path, List<HocVien> ts)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter s = new StreamWriter(path))
                {
                    foreach (HocVien h in ts)
                    {
                        s.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                        h.Id, h.Name, h.Dob, h.Gender, h.Email, h.PhoneNumber, h.Adress);
                    }
                }
            }
            else
            {
                File.Delete(path);
                using (StreamWriter s = new StreamWriter(path))
                {
                    foreach (HocVien h in ts)
                    {
                        s.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                        h.Id, h.Name, h.Dob, h.Gender, h.Email, h.PhoneNumber, h.Adress);
                    }
                }
            }                        
        }

        public static void GhiFileStu_Sub(string path, List<HocVien> ts)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter s = new StreamWriter(path))
                {
                    foreach (HocVien h in ts)
                    {
                        s.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                        h.Id, h.Name, h.Dob, h.Gender, h.Email, h.PhoneNumber, h.Adress);
                    }
                }
            }
            else
            {
                File.Delete(path);
                using (StreamWriter s = new StreamWriter(path))
                {
                    foreach (HocVien h in ts)
                    {
                        s.WriteLine("{0}#{1}#{2}#{3}#{4}#{5}#{6}",
                        h.Id, h.Name, h.Dob, h.Gender, h.Email, h.PhoneNumber, h.Adress);
                    }
                }
            }
        }

        private int SearchStudent(String id, List<HocVien> hocViens)
        {
            if (hocViens.Count > 0)
            {
                for (int i = 0; i < hocViens.Count; i++)
                {
                    if (hocViens[i].Id == id)
                        return i;
                }
                return -1;
            }
            else
                return -1;
        }

        public static void DienThongTin()
        {

        }
    }
}
