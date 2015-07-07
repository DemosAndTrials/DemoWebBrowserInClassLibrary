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
        // global CPG credentials
        private static String ClientId = "3MVG9WtWSKUDG.x4JfXszDgauSc9I64phmL17AKPzxp.RjOizYDLMZ6LRZtaEUX3I9P2rUr8HwpfI3jT5sc7c";
        private static String ClientSecret = "6205687164973136440";

        /* prod */
        private static string RedirectUri = "https://login.salesforce.com/services/oauth2/success";
        private static string ServiceRequestUri = "https://login.salesforce.com/services/oauth2/authorize?response_type=token&client_id=" + ClientId + "&redirect_uri=" + RedirectUri;
        private static string CallbackUrl = "https://login.salesforce.com/services/oauth2/success";
        internal static String TokenRefreshUrl = "https://login.salesforce.com/services/oauth2/token";

        WebForm web = new WebForm(new Uri(ServiceRequestUri), CallbackUrl);

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
