using System;

namespace AlanHesapla
{
    class Sekil
    {
        public static void Dikdortgen()
        {
            System.Console.WriteLine("Lütfen Uzun Kenari Giriniz:");
            int kenarUzun = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Lütfen Kisa Kenari Giriniz :");
            int kisaKenar = int.Parse(Console.ReadLine());

            int alan = kisaKenar * kenarUzun;
            int cevre = (kisaKenar * 2 )  + (kenarUzun * 2);

            System.Console.WriteLine("Alan : " + alan);
            System.Console.WriteLine("Çevre :" + cevre);
        }

        public static void Kare() 
        {
            
            System.Console.WriteLine("Lütfen Kenari Giriniz:");
            int kenarUzun = int.Parse(Console.ReadLine());
            int kisaKenar = kenarUzun;

            int alan = kisaKenar * kenarUzun;
            int cevre = (kisaKenar * 2 )  + (kenarUzun * 2);

            System.Console.WriteLine("Alan : " + alan);
            System.Console.WriteLine("Çevre :" + cevre);
        }

        public static void Ucgen()
        {
            
            System.Console.WriteLine("Lütfen birinci ikinci ve üçüncü kenarı giriniz :");
            int kenarBir = int.Parse(Console.ReadLine());
            int kenariki = int.Parse(Console.ReadLine());
            int kenarUc = int.Parse(Console.ReadLine());
            int cevre = kenarBir + kenariki + kenarUc;
            int s = cevre / 2;

            int alanKaresi = s * (s - kenarBir) * (s-kenariki)*(s-kenarUc);
            double alan = Math.Sqrt(alanKaresi);

            System.Console.WriteLine("Alan : " + alan);
            System.Console.WriteLine("Çevre :" + cevre);
        }

        public static void Daire()
        {
            double pi = 3.14;
            System.Console.WriteLine("Lütfen Yaricapi Giriniz");
            int yariCap = int.Parse(Console.ReadLine());

            double alan = pi * yariCap * yariCap;
            double cevre = 2 * pi * yariCap;

            System.Console.WriteLine(alan);
            System.Console.WriteLine(cevre);
        }

    }
}