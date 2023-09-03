using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Ornekler;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void islemler()
        //{
        //    Class1 c =  new Class1();
        //    c.Topla();
        //}

        void mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir core projesidir";
            ViewBag.m2 = "Merhaba proje çok iyi duruyor";
            ViewBag.m3 = "Selamlar";
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc = s1 + s2;
            return sonuc;
        }

        int Cevre()
        {
            int kisa = 10;
            int uzun = 20;
            int sonuc = 2 * (kisa + uzun);
            return sonuc;
        }

        string cumle()
        {
            string c = "Benim adım Şafak";
            return c;
        }

        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }
        void Kullanıcı(string kullaniciadi)
        {
            ViewBag.v = kullaniciadi;
        }

        int Toplama(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }


        public IActionResult Index()
        {
            mesajlar();
            MesajListesi("Parametre ismi");
            Kullanıcı("ŞAfak");
            ViewBag.tp = Toplama(1, 3);
            return View();
        }

        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            ViewBag.c = Cevre();
            Kullanıcı("Şafak Şahin");
            return View();
        }

        public IActionResult Musteriler()
        {
            ViewBag.d = cumle();
            Kullanıcı("şfk");
            return View();
        }

        public IActionResult Deneme()
        {
            Sehirler sehirler = new Sehirler();
            Bayrak bayrak = new Bayrak();

            sehirler.Ad = "Kiev";
            sehirler.Id = 1;
            sehirler.Nufus = 1000000;
            sehirler.Ulke = "Ukrayna";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Mavi";
            sehirler.Renk3 = "Mavi";

            ViewBag.v1 = sehirler.Id;
            ViewBag.v2 = sehirler.Ulke;
            ViewBag.v3 = sehirler.Ad;
            ViewBag.v4 = sehirler.Nufus;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;

            sehirler.Id = 2;
            sehirler.Ad = "Üsküp";
            sehirler.Ulke = "Makedonya";
            sehirler.Nufus = 500000;
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Satı";
            ViewBag.z1 = sehirler.Id;
            ViewBag.z2 = sehirler.Ulke;
            ViewBag.z3 = sehirler.Ad;
            ViewBag.z4 = sehirler.Nufus;
            ViewBag.z5 = sehirler.Renk1;
            ViewBag.z6 = sehirler.Renk2;
            ViewBag.z7 = sehirler.Renk3;

            return View();
        }
    }
}
