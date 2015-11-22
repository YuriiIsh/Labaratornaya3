using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace ConsoleApplication11
{
    internal class NumPrinter:INumPrinter 
    {
        private int n;
        Random rnd = new Random();
        public NumPrinter(int n)
        {
            this.n = n;
        }

        public int[] GetNumbers()  // возвращает массив чисел из сегмента [0, n]
        
        {
            Thread.Sleep(10000);
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = rnd.Next(10, 20);
            }
            int []a = numbers;
            return a;
            
        }
    }
}
