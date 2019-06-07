using _04_PersonelTakipUygulamasi.Entities;
using _04_PersonelTakipUygulamasi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PersonelTakipUygulamasi.Database
{
    class Db_Context
    {
        public static ICollection<Personel> Personeller = new HashSet<Personel>();

        public static ICollection<Departman> Departmanlar = new HashSet<Departman>();
    }
}
