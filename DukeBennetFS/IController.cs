using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukeBennetFS
{
    interface IController
    {
      void Process(string command, IEnumerable<String> args);
    }
}
