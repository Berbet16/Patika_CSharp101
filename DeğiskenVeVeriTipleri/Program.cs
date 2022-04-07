
using System;

namespace hackerrank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            byte b = 5;         //1 byte
            sbyte c = 5;        //1 byte

            short s = 5;        //2 byte
            ushort u = 5;       //2 byte

            Int16 i16 = 2;      //2 byte
            int i = 2;          //2 byte
            Int32 i32 = 2;      //4 byte
            Int64 i64 = 2;      //8 byte

            uint ui= 2;         //4 byte
            long l = 4;         //8 byte
            ulong ul= 4;        //8 byte


            //  REEL SAYILAR //
            float f = 5;        //4 byte 
            double d = 5;       //8 byte
            decimal de = 5;     //16 byte

            char ch = '2';          //2 bytte
            string str = "Goktug";  //sınırsız

            bool b2 = true;
            bool c2 = false;

            DateTime dt2 = DateTime.Now;
            Console.WriteLine(dt2);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            // String İfadeler //
            string str1 = string.Empty;
            str1 = "Goktug YILDIZ";
            string ad = "Goktug";
            string soyad = "yildiz";
            string tamIsim = ad + " " + soyad;

            // integer tanımlama şekilleri //
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1 + integer2;
            

            // boolean //
            bool bool1 = 10<2; //false atar büyüktür olsaydı true atardı.

            // değişken dönüşümleri //
            string str20 = "20";
            int int20 = 22;

            string yenideger = str20 + int20.ToString();

            Console.WriteLine(yenideger); // 2022 olarak çıktı verir

            int int21=int20 +Convert.ToInt32(str20);
            Console.WriteLine(int21); // 42 olarak çıktı verir. stringi int'e çevirir

            int22 = int20 + int.Parse(int20); // 40 olarak çıktı verir. parse genelde stringten dönüşüm için kullanılır.

            // DateTime //
            string datetime=DateTime.Now.ToString("dd.mm.yy");
            Console.WriteLine(datetime); // 07.04.2022

            string datetime2 = DateTime.Now.ToString("dd/mm/yy");
            Console.WriteLine(datetime2); // 07/04/2022
            
            // saat //
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour); // 01:08

            DateTime myValue = DateTime.Now;
            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());       
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());
            //Console.WriteLine(myValue.Month);

            //DateTime myBDay = new DateTime(1998,6,23);
            //Console.WriteLine(myBDay.ToLongDateString());

            DateTime myBDay = DateTime.Parse("6/23/1998");
            TimeSpan myTimeSpan = DateTime.Now.Subtract(myBDay);
            Console.WriteLine(myTimeSpan.TotalDays);

            Console.ReadLine();

        }
    }
}
