using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OAuth
{
    public class WebBrowserTest
    {
        public WebBrowserTest()
        {
            Debug.Print("Thread is starting.");
            var webThread = new WebThread();

            var t = new Thread(webThread.StartBrowser);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            while (t.IsAlive)
            {
                Thread.Sleep(5000);
            }

            Debug.Print("Thread has finished.");
        }
    }
}
