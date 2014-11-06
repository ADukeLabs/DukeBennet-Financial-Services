using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DukeBennetFS
{
    internal class Router
    {
        public void Route(string[] args)
        {
            String command = args.Length != 0 ? args[0].ToLowerInvariant() : String.Empty;

            IController controller;
            switch (command)
            {
                case "Access":
                    controller = new AccessController();
                    break;
                case "Transfer":
                    controller = new Transfercontroller();
                    break;
                case "Balance":
                    controller = new BalanceController();
                    break;
                case "help":
                case "h":
                case "-h":
                //    controller = new HelpControler();
                    break;
                default:
                    controller = new welcomeController();
                    break;
            }

        }
    }
}
