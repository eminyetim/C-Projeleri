using System; 
using System.Text.RegularExpressions;

namespace stringHomework
{
    class Program
    {
        public static void Main()
        {
            string girilenIfade = Convert.ToString(Console.ReadLine());

            string[] kelimeler = girilenIfade.Split(',');
          
            foreach (var item in kelimeler)
            {
                foreach(var item2 in item)
                {
                    int s;
                    if(int.TryParse(Convert.ToString(item2),out s))
                    {
                         continue;
                    }
                    System.Console.Write(item2);
                    
                }
               
               
            }
        }
    }
}