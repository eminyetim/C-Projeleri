using System;


namespace integerOdev
{
    class Program
    {
        public static void Main(string[] args)
        {
            int adet = 0;
            do
            {
                System.Console.WriteLine("Kaç tana sayi giriceksiniz lütfen çift olsun");
                adet = int.Parse(Console.ReadLine());
            }while(adet % 2 != 0);

            int[] arr = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                System.Console.WriteLine("Lütfen " + (i+1) + ". değeri giriniz :");
                arr[i] = int.Parse(Console.ReadLine());
            }
            System.Console.WriteLine();
            foreach (var item in arr)
            {
                System.Console.Write(item + " ");
            }
            System.Console.WriteLine();
            for(int j = 0 ; j < adet ; j+=2)
            {
                if(arr[j] == arr[j+1])
                {
                    int temp = arr[j] * arr[j+1];
                    System.Console.Write(Math.Pow(temp,2) + " ");
                }
                else
                    System.Console.Write(arr[j] + arr[j+1] +  " ");

            }

        }
    }
}