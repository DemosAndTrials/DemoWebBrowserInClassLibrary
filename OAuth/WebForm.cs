using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OAuth
{
    public partial class WebForm : Form
    {
        public Uri Link{ get; private set; }


        public WebForm(Uri link)
        {
            InitializeComponent();
            this.Link = link;
        }

        public void ShowTest()
        {
            var br = new WebBrowser();
            br.Url = Link;
            br.Dock = DockStyle.Fill;
            this.Controls.Add(br);

            this.ShowDialog();
        }
    }
}
