using System;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        int x = 2;
        string m = "Olá mundo";
        string s = "Um tab\t e um copyright \u03A9";
        string path = "C:\\Users\\Gonçalo\\Desktop";
        string message = "a" + 2;
        string message2 = "abc" + 2;
        string message3;
        private void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(m);
            Console.WriteLine(s);
            Console.WriteLine(path);
            Console.WriteLine(message);
            Console.WriteLine(message2);

            message3 = $"valor de x é {x}";
            Console.WriteLine(message3);
        }
    }
}
