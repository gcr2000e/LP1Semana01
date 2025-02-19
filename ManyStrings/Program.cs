using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        string m = "Olá mundo";
        string s = "Um tab\t e um copyright \u03A9";
        string path = "C:\\Users\\Gonçalo\\Desktop";
        private void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine(m);
            Console.WriteLine(s);
            Console.WriteLine(path);
        }
    }
}
