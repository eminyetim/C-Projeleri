using System;

namespace FibonacciOrtHesaplama
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            int gelenDeger=0;
            double toplamSonuc = 0;
            System.Console.WriteLine("Lütfen Derinliği Giriniz:");
            gelenDeger = int.Parse(Console.ReadLine());

            for(int i = 1 ; i <= gelenDeger ; i++)
            {
                toplamSonuc += fibonacciHesapla(i);
            }
            
            double res = Convert.ToDouble(toplamSonuc/gelenDeger);

            System.Console.WriteLine(res);
        }

        public static int fibonacciHesapla(int gelenDerinlik)
        {
           
            if(gelenDerinlik == 1 || gelenDerinlik == 2)
                return 1;         

            return fibonacciHesapla(gelenDerinlik - 2) + fibonacciHesapla((gelenDerinlik-1));
        }
    }
}