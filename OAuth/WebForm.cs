using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuth
{
    public partial class WebForm : Form
    {
        public Uri Link{ get; private set; }
        public string endLink { get; private set; }

        public WebForm(Uri link, string endLink) 
        {
            InitializeComponent();
            this.Link = link;
            this.endLink = endLink;
        }

        public void ShowTest()
        {
            var br = new WebBrowser();
            br.Url = Link;
            br.Dock = DockStyle.Fill;
            br.Navigating += br_Navigating;
            this.Controls.Add(br);

            this.ShowDialog();
        }

        void br_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.AbsoluteUri.StartsWith(endLink))
            {
                string urlEnd = e.Url.ToString().Split('#')[1];
                Dictionary<string, string> values = new Dictionary<string, string>();
                string[] nameValues = urlEnd.Split(new[] { "&" }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var nameValue in nameValues)
                {
                    // Separate this values by '=' so you get name/key and value as separated field in array
                    string[] temp = nameValue.Split(new[] { "=" }, StringSplitOptions.RemoveEmptyEntries);

                    if (temp.Length == 2)
                    {
                        values.Add(temp[0], WebUtility.UrlDecode(temp[1]));
                    }
                }
                Config conf = new Config();
                conf.AccessToken = values["access_token"];
                conf.InstanceUrl = values["instance_url"];
                conf.RefreshToken = values["refresh_token"];
            }
        }

       
    }
}
