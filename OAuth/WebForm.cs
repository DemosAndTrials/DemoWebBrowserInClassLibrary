using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace OAuth
{
    public partial class WebForm : Form
    {
        private Uri Link{ get;  set; }
        private string endLink { get; set; }
        private TokenResult Token { get; set; }

        public WebForm(Uri link, string endLink) 
        {
            InitializeComponent();
            this.Link = link;
            this.endLink = endLink;
        }

        public TokenResult Start()
        {
            // init browser
            var br = new WebBrowser();
            br.Url = Link;
            br.Dock = DockStyle.Fill;
            br.Navigating += br_Navigating;
            this.Controls.Add(br);
            // show window
            this.ShowDialog();
            // return token
            return Token;
        }

        void br_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (e.Url.AbsoluteUri.StartsWith(endLink))
            {
                // parse result
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

                Token = new TokenResult();
                Token.AccessToken = values["access_token"];
                Token.InstanceUrl = values["instance_url"];
                Token.RefreshToken = values["refresh_token"];

                // close window
                this.Close();
            }
        }

       
    }
}
