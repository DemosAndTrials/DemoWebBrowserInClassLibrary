using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OAuth
{
    public class TokenResult
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string InstanceUrl { get; set; }

        public override string ToString()
        {
            return string.Format("AccessToken: {0}\nRefreshToken: {1}\nInstanceUrl: {2}", AccessToken, RefreshToken, InstanceUrl);
        }
    }
}
