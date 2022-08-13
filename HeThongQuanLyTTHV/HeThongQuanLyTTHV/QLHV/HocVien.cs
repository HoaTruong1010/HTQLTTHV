using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongQuanLyTTHV.QLHV
{
    class HocVien
    {
        private string id, name, dob, gender, email, phoneNumber, adress;

        public HocVien()
        {
            id = name = dob = gender = email = phoneNumber = adress = null;
        }

        public HocVien(String id, String name, String dob, String gender, String email, String phoneNumber, String adress)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.gender = gender;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.adress = adress;
        }

        public HocVien(HocVien h)
        {
            this.id = h.id;
            this.name = h.name;
            this.dob = h.dob;
            this.gender = h.gender;
            this.email = h.email;
            this.phoneNumber = h.phoneNumber;
            this.adress = h.adress;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Adress { get => adress; set => adress = value; }
    }
}
