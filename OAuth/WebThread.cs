using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuth
{
    public class WebThread
    {
        private WebBrowser web { get; set; }

        public void StartBrowser()
        {
            web = new WebBrowser();
            web.Visible = true;
            web.DocumentCompleted += Web_DocumentCompleted;
            web.ScriptErrorsSuppressed = true;
            web.Navigate("http://www.google.com");

            Application.Run();

            web.Dispose();
        }

        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Debug.Print("Arrived: " + e.Url.ToString());

            if (e.Url.ToString() == "http://www.google.com.au/")
            {
                Application.ExitThread();
            }
        }
    }
}
