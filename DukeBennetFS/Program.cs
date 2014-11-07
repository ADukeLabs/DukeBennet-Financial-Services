using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukeBennetFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Router router = new Router();
           
            router.Route(args);
        }
    }
}
