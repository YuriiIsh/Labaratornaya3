using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication11
{
    class ProxyNumPrinter:INumPrinter
    {
        int[] b;
        NumPrinter ba;
        public ProxyNumPrinter()
        {
            NumPrinter ba = new NumPrinter(20);
             b = ba.GetNumbers();
        }
        public  int[] GetNumbers()
        {
         if (ba==null)
          ba= new NumPrinter(20);
         for (int i = 0; i > b.Length; i++)
         {
             if (b[i] % 2 == 0)
             {
                 b[i] = i++; 
             }
         }
            return b;
            }       
}
}
    
