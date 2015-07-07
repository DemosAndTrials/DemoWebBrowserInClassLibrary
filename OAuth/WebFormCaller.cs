using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OAuth
{
    public class WebFormCaller
    {
        WebForm web = new WebForm(new Uri("http://www.google.co.il/"));

        public void Run()
        {
            var t = new Thread(web.ShowTest);
            t.SetApartmentState(ApartmentState.STA);
            t.Start();

            while (t.IsAlive)
            {
                Thread.Sleep(5000);
            }
        }

    }
}
