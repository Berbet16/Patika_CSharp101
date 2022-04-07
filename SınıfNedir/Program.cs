using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Berna";
            calisan1.Soyad = "Soylu";
            calisan1.No = 107;
            calisan1.Departman = "Yazılım";

            calisan1.CalisanBilgileri();
            Console.WriteLine("*************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Betül";
            calisan2.Soyad = "Soylu";
            calisan2.No = 8531;
            calisan2.Departman = "Eğitim";

            calisan2.CalisanBilgileri();

        }
        class Calisan
        {
            //Property : Özellikler
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;
            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışan Adı : {0}", Ad);
                Console.WriteLine("Çalışan Soyad : {0}", Soyad);
                Console.WriteLine("Çalışan No : {0}", No);
                Console.WriteLine("Çalışan Departman : {0}", Departman);
            }

        }
    }
}

























