﻿using System;
using System.Runtime.InteropServices;

namespace AskForInput
{
    public class Program
    {
        
        private static void Main(string[] args)
        {
            float soma;
            Console.WriteLine("Insira um número inteiro:");
            string str = Console.ReadLine();
            int i = int.Parse(str);
            
            Console.WriteLine("Insire um número real");
            string str2 = Console.ReadLine();
            float j = float.Parse(str2);

            soma = i + j;
            Console.WriteLine($"A soma é {soma:f2}");
        }
    }
}
