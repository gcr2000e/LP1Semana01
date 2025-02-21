using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        
        private static void Main(string[] args)
        {
          int x = 2;
          int ii = 19;
          double xx = 1.23456;
          string m = "Olá mundo";
          string s = "Um tab\t e um copyright \u03A9";
          string path = "C:\\Users\\Gonçalo\\Desktop";
          string message = "a" + 2;
          string message2 = "abc" + 2;
          string message3;
          string s1;
          string s2;
          
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(m);
            Console.WriteLine(s);
            Console.WriteLine(path);
            Console.WriteLine(message);
            Console.WriteLine(message2);

            message3 = $"valor de x é {x}";
            Console.WriteLine(message3);

            s1 = $"xx={xx:f2} e {xx:p1}";
            Console.WriteLine(xx);

            s2 = $"ii={ii:x}";
            Console.WriteLine(s2);


        }
    }
}
