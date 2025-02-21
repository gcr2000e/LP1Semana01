using System;
using System.Globalization;

namespace Percentagem
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = 
            CultureInfo.InvariantCulture;
            
            Console.WriteLine("Insire 4 números reais entre 0 e 1:");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            string str3 = Console.ReadLine();
            string str4 = Console.ReadLine();
            
            float num1 = float.Parse(str1);
            float num2 = float.Parse(str2);
            float num3 = float.Parse(str3);
            float num4 = float.Parse(str4);

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine($"{num1:p2}");
            Console.WriteLine($"{num2:p2}");
            Console.WriteLine($"{num3:p2}");
            Console.WriteLine($"{num4:p2}");
            
        }
    }
}
