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
               
                  
                case "access":
                    controller = new AccessController();
                    break;
                case "transfer":
                    controller = new Transfercontroller();
                    break;
                case "balance":
                    controller = new BalanceController();
                    break;
                case "create":
                    controller = new CustomerController();
                    break; 
                case "help":
                case "h":
                case "withdraw":
                    controller = new WithdrawController();
                    break;
                case "deposit":
                    controller = new FunctionsController();
                    break;  
                  default:  
                      controller = new welcomeController();
                    break;
            }
            controller.Process(command, args);
        }
    }

   
}
