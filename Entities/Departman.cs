using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_PersonelTakipUygulamasi.Entities
{
    class Departman
    {
        public string  DepartmanAdi { get; set; }

        public override string ToString()
        {
            return DepartmanAdi;
        }
    }
}
