﻿using TimeSpan;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var D1 = new Duration(1, 10, 15);
            Console.WriteLine($"D1 = {D1}");

            var D2 = new Duration(3600);
            Console.WriteLine($"D2 = {D2}");

            var D3 = new Duration(7800);
            Console.WriteLine($"D3 = {D3}");

            var D4 = new Duration(666);
            Console.WriteLine($"");
            Console.WriteLine($"D4 = {D4}");
        }
    }
}
