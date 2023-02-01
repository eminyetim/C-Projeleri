using System;

namespace mutlakKareAlma
{
    class Program
    {
        public static void Main()
        {
            System.Console.WriteLine("Lütfen Değer Giriniz :");
            int adet = int.Parse(Console.ReadLine());

            int[] arr = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                System.Console.WriteLine("Lüfen" + (i+1) + ". değeri giriniz :");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int farkK = 0;
            double farkB = 0;
            for (int i = 0; i < adet; i++)
            {
                if(arr[i] < 67)
                {
                    farkK+= (67 - arr[i]);
                }
                else
                {
                    int temp = 0;
                    temp += -(67 - arr[i]);
                    farkB += Math.Pow(temp , 2); 
                }
            }

            System.Console.WriteLine(farkK + " " + farkB);
        }
    }
}