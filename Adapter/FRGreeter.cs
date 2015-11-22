using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class FRGreeter:IGreeter 
    {
        public void  SayHello()
        {
            Console.WriteLine("Salutation");
        }

    }
}
