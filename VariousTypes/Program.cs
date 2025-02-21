using System;
using System.Globalization;
using System.Text;

namespace VariousTypes
{
    public class Program
    {

        private static void Main(string[] args)
        {
          int num = 9;
          float x = 4.9f;
          double y = 4.9;
          double p = 4.9e-10;
          decimal z = 4.9m;
          uint j = 9U;
          long k = 4L;
          ulong n = 4UL;
          bool a = false;
          bool b = true;
          char copyrightSymbol = '\u00A9';

           Console.OutputEncoding = Encoding.UTF8;
           Console.WriteLine(num);
           Console.WriteLine(x);
           Console.WriteLine(y);
           Console.WriteLine(p);
           Console.WriteLine(p);
           Console.WriteLine(z);
           Console.WriteLine(j);
           Console.WriteLine(k);
           Console.WriteLine(n);
           Console.WriteLine(copyrightSymbol);
           Console.WriteLine(a);
           Console.WriteLine(b);
        }
    }
}
