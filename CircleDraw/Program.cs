using System;

namespace CircleDraw
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Lütfen Yariçap giriniz :");
            int r = int.Parse(Console.ReadLine());
            

            for(int i = 0 ; i < r ; i++)
            {
                for(int k = 0 ; k < r-i ; k++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("*");

                for(int j = 0 ; j < 2*i ; j++)
                {
                    System.Console.Write(" ");
                }
                System.Console.WriteLine("*");
            }

               for(int i = r ; i > 0 ; i--)
            {
                for(int k = 0 ; k < r-i ; k++)
                {
                    System.Console.Write(" ");
                }
                System.Console.Write("*");

                for(int j = 0 ; j < 2*i ; j++)
                {
                    System.Console.Write(" ");
                }
                System.Console.WriteLine("*");
            }
        }
    }
}