using System;

namespace AlanHesapla
{
    class Program
    {
        public static void Main(String[] args)
        {
            System.Console.WriteLine("(1) Kare");
            System.Console.WriteLine("(2) Dikdörtgen");
            System.Console.WriteLine("(3) Üçgen");  
            System.Console.WriteLine("(4) Daire");  
            System.Console.WriteLine("Lütfen Şekil Seçiniz");
            System.Console.WriteLine("(0) Çikiş");

            int girilenIslem = int.Parse(Console.ReadLine());

            switch (girilenIslem)
            {
                
                case 1 : Sekil.Kare(); break;
                case 2 : Sekil.Dikdortgen();break;
                case 3 : Sekil.Ucgen(); break;
                case 4 : Sekil.Daire();break;
                case 0 : Environment.Exit(0); break;

                default: System.Console.WriteLine("Lütfen 1 ile 4 arasi değer giriniz."); break;
            }
            
        }
    }
}