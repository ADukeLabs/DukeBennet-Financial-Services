using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DukeBennetFS
{
    class welcomeController : IController
    {
        public void Process(string command, IEnumerable<String> args)
        {
            welcomeView view = new welcomeView();
            view.Render();
            
        }
    }
}
