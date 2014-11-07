using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace DukeBennetFS
{
    internal class welcomeView
    {
        public void Render()
        {
            Console.WriteLine(Ascii.ascii);
            Console.WriteLine("Type Transfer to Transfer Money ");
            Console.WriteLine("Type Create to Create a new bank account");
            Console.WriteLine("Type Deposit to Deposit Money");
            Console.WriteLine("Type Withdraw to Withdraw Money");
            string command = Console.ReadLine();
            Router router = new Router();
            router.Route(command.Split(' '));
          //  router.Route();
        }

    }
}
