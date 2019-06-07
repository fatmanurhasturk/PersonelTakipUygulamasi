using _04_PersonelTakipUygulamasi.Database;
using _04_PersonelTakipUygulamasi.Entities;
using _04_PersonelTakipUygulamasi.Entity;
using _04_PersonelTakipUygulamasi.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_PersonelTakipUygulamasi
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DatabaseIlkHali();
            Application.EnableVisualStyles();           Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPersonel());
        }

        static void DatabaseIlkHali()
        {
            Departman departman1 = new Departman()
            {
                DepartmanAdi = "Muhasebe",
            };
            Departman departman2 = new Departman()
            {
                DepartmanAdi = "Yazılım Geliştirme",
            };
            Departman departman3 = new Departman()
            {
                DepartmanAdi = "İnsan Kaynakları",
            };
            Departman departman4 = new Departman()
            {
                DepartmanAdi = "Pazarlama",
            };
            Departman departman5 = new Departman()
            {
                DepartmanAdi = "Arge",
            };
            Db_Context.Departmanlar.Add(departman1);
            Db_Context.Departmanlar.Add(departman2);
            Db_Context.Departmanlar.Add(departman3);
            Db_Context.Departmanlar.Add(departman4);
            Db_Context.Departmanlar.Add(departman5);


            Personel ziya = new Personel()
            {
                Ad = "Ziya",
                Soyad = "Balta",
                Adres = "Ayvansaray Üniversitesi Sınıf:204",
                Cinsiyet = CinsiyetEnum.Erkek,
                CocukSayisi = 0,
                Departman = departman1,
                DogumTarihi = new DateTime(1993, 2, 1),
                Email = "ziyabalta@outlook.com",
                IseBaslamaTarihi = new DateTime(2019, 1, 21),
                 MedeniHal=MedeniHalEnum.Bekar,
                   Telefon="02162161616"
            };
            ziya.Ehliyetler.Add(EhliyetEnum.A1);
            ziya.Ehliyetler.Add(EhliyetEnum.B);


            Personel huseyin = new Personel()
            {
                Ad = "Hüseyin",
                Soyad = "Çekmez",
                Adres = "Ayvansaray Üniversitesi Sınıf:204",
                Cinsiyet = CinsiyetEnum.Erkek,
                CocukSayisi = 0,
                Departman = departman3,
                DogumTarihi = new DateTime(1990, 9, 29),
                Email = "huseyincekmez@outlook.com",
                IseBaslamaTarihi = new DateTime(2019, 1, 21),
                MedeniHal = MedeniHalEnum.Bekar,
                Telefon = "02162161615"
            };
            huseyin.Ehliyetler.Add(EhliyetEnum.A1);
            huseyin.Ehliyetler.Add(EhliyetEnum.C);




            Personel oguzhan = new Personel()
            {
                Ad = "Oğuzhan",
                Soyad = "Demiral",
                Adres = "Ayvansaray Üniversitesi Sınıf:204",
                Cinsiyet = CinsiyetEnum.Erkek,
                CocukSayisi = 0,
                Departman = departman2,
                DogumTarihi = new DateTime(1994, 10, 5),
                Email = "oguzhandemiral@outlook.com",
                IseBaslamaTarihi = new DateTime(2019, 1, 21),
                MedeniHal = MedeniHalEnum.Bekar,
                Telefon = "02162161618"
            };
            oguzhan.Ehliyetler.Add(EhliyetEnum.A2);
            oguzhan.Ehliyetler.Add(EhliyetEnum.E);


            Db_Context.Personeller.Add(ziya);
            Db_Context.Personeller.Add(huseyin);
            Db_Context.Personeller.Add(oguzhan);
        }
    }
}
