using _04_PersonelTakipUygulamasi.Entities;
using _04_PersonelTakipUygulamasi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PersonelTakipUygulamasi.Entity
{
    class Personel
    {
        public Personel()
        {
            Ehliyetler = new HashSet<EhliyetEnum>();
        }
        public string  Ad { get; set; }
        public string  Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public CinsiyetEnum Cinsiyet { get; set; }
        public string Telefon { get; set; }
        public string  Email { get; set; }
        public string  Adres { get; set; }
        public  Departman Departman { get; set; }
        public DateTime IseBaslamaTarihi { get; set; }
        public MedeniHalEnum MedeniHal { get; set; }
        public ICollection<EhliyetEnum> Ehliyetler { get; set; }
        public int CocukSayisi { get; set; }
        public string ResimYolu { get; set; }

        public bool IsDeleted { get; set; }

    }
}
