using System;

namespace karakteriTerstenYazdirma
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Lütfen ifadeyi giriniz :");
            string ifade = Convert.ToString(Console.ReadLine());
            string[] ifadeTemp = ifade.Split(' ');
            int size = ifadeTemp.Count();

            for (int i = 0; i < 3; i++)
            {
                for(int j = ifadeTemp[i].Length - 1 ; j >= 0 ; j--)
                {
                    System.Console.Write(ifadeTemp[i][j]);
                }
                System.Console.Write(" ");
            }
        }
    }
}