using OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoOAuthConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //WebBrowserTest t = new WebBrowserTest();
            WebFormCaller wf = new WebFormCaller();
            wf.Run();

            Console.Read();
        }
    }
}
