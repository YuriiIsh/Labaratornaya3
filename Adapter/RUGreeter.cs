using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class RUGreeter:IGreeter
    {
        public void SayHello()
        {
            Console.WriteLine("Приветствие");
        }

    }
}
