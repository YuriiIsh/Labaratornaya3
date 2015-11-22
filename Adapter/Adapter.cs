using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication11
{
    class Adapter : IGreeter 
    {
        Printer pr = new Printer();
        public void SayHello()
    {
        pr.Print("Salutation");
     }
    
    }
}
