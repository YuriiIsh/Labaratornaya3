using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            Adapter adapter = new Adapter();
            adapter.SayHello();
            ProxyNumPrinter proxy = new ProxyNumPrinter();
            NumPrinter se = new NumPrinter(20);
            Stopwatch sy = new Stopwatch();
            sy.Start();
            proxy.GetNumbers();
            sy.Stop();
            Console.WriteLine("Время выполнения GetNumbers у прокси {0}",sy.Elapsed);
            sy.Restart();
            se.GetNumbers();
            sy.Stop();
            Console.WriteLine("Время выполнения GetNumbers у NumPrinter {0}", sy.Elapsed);
            Console.ReadLine();
        }
    }
}
