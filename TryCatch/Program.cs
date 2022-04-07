
using System;

   
namespace ExceptionHandling // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try  //Hata alması muhtemelen kontrol edilmesi gereken kod bloğu girelecek.
            {
                System.Console.WriteLine("Bir sayı giriniz!");
                int sayi = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            }
            catch (Exception ex) //Hata aldığında ne yapmasını istediğimiz kod girilecek.
            {
                System.Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            finally  //Koşuldan bağımsız çalışmasını istediğimiz kod bloğunu yazıyoruz.
            {
                System.Console.WriteLine("İşlem tamamlandı.");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }

using System;

   
namespace ExceptionHandling // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try  //Hata alması muhtemelen kontrol edilmesi gereken kod bloğu girelecek.
            {
                System.Console.WriteLine("Bir sayı giriniz!");
                int sayi = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            }
            catch (Exception ex) //Hata aldığında ne yapmasını istediğimiz kod girilecek.
            {
                System.Console.WriteLine("Hata:" + ex.Message.ToString());
            }
            finally  //Koşuldan bağımsız çalışmasını istediğimiz kod bloğunu yazıyoruz.
            {
                System.Console.WriteLine("İşlem tamamlandı.");
            }

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük yada çok büyük bir değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem başarıyla tamamlandı.");
            }
        }
    }
}