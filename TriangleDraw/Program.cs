using System;

namespace TriangleDraw
{

    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Lütfen Üçgen Genişliğini Giriniz :");
            int genislik = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Lütfen Üçgen Uzunluğunu Giriniz :");
            int uzunluk = int.Parse(Console.ReadLine());;
            
            for (int i = 0; i <=(genislik/2); i++)
            {
                System.Console.Write(" ");
            }
            System.Console.WriteLine("#");
            for(int j = 0; j < uzunluk ; j++)
            {
                for(int i = 0 ; i <(genislik / 2)-j ; i++ )
                {
                    System.Console.Write(" ");
                }
                
                System.Console.Write("#");

                for(int k = 0 ; k <= 2*j; k++ )
                {
                    System.Console.Write(" ");
                }
                
                 System.Console.WriteLine("#");
            }
            for(int i =1  ; i <= (genislik / 2)-uzunluk ; i++)
            {
                System.Console.Write(" ");
            } 
            for (int i = 0; i <=2*(uzunluk+1); i++)
            {
                System.Console.Write("#");
            }

        }
    }

}