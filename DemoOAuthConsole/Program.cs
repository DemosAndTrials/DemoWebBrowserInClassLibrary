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

            //runBrowserThread(new Uri("http://www.google.co.il/"));



            Console.Read();
        }

        private static void runBrowserThread(Uri url)
        {
            var th = new Thread(() =>
            {

                var br = new WebBrowser();
                br.DocumentCompleted += browser_DocumentCompleted;
                br.Navigate(url);
                Application.Run();
            });
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        static void browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            var br = sender as WebBrowser;
            if (br.Url == e.Url)
            {
                Console.WriteLine("Natigated to {0}", e.Url);
                Application.ExitThread();   // Stops the thread
            }
        }
    }
}
