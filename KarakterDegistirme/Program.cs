using System;

namespace KarakterDegistirme
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Lütfen String ifadeyi giriniz :");
            string ifade = Convert.ToString(Console.ReadLine());

            string[] arrIfade = ifade.Split(' ');

            for (int i = 0; i < arrIfade.Count(); i++)
            {
                string tempArr =Convert.ToString(arrIfade[i]);
                string ilk = Convert.ToString(tempArr[0]);
                string son = Convert.ToString(tempArr[(tempArr.Length - 1)]);

                
                char[] arr = tempArr.ToCharArray();                
                arr[0] = Convert.ToChar(son);
                arr[tempArr.Length-1] = Convert.ToChar(ilk);
                System.Console.WriteLine(arr);
               
            }
            
        }
    }
}