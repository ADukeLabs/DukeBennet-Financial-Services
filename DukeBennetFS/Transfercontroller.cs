using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DukeBennetFS
{
    class Transfercontroller : IController
    {
       public void Process(string command, IEnumerable<String> args)
        {
            Console.WriteLine(command);
        // in here will be the calls to the database yada yada yada
        }
    }
}
