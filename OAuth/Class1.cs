using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth
{
    public class Class1
    {
        //public async Task<bool> AuthenticateToSalesforce()
        //{
        //    //Authentication Uri
        //    string uri = "https://login.salesforce.com/services/oauth2/token";
        //    //Standard redirect uri for desktop/non-web based apps
        //    //var redirectUri = "";
        //    //("grant_type", "password")
        //    var grant_type = "password";
        //    //("client_id", CONSUMER_KEY)
        //    var client_id = "3MVG9WtWSKUDG.x4JfXszDgauSc9I64phmL17AKPzxp.RjOizYDLMZ6LRZtaEUX3I9P2rUr8HwpfI3jT5sc7c";
        //    //"client_secret", CONSUMER_SECRET)
        //    var client_secret = "6205687164973136440";
        //    //("username", SALESFORCE_USERNAME)
        //    var username = "lee.khen@cpg.demo";
        //    //("password", SALESFORCE_PASSWORD_AND_SECRETKEY)
        //    var password = "shokibentuvin3DGYvUG6LhtmkhWJ4cJJAIN11";

        //    StringBuilder body = new StringBuilder();
        //    body.Append("grant_type=" + grant_type + "&");
        //    body.Append("client_id=" + client_id + "&");
        //    body.Append("client_secret=" + client_secret + "&");
        //    body.Append("username=" + username + "&");
        //    body.Append("password=" + password);
        //    var content = new StringContent(body.ToString());

        //    string json = await http.HttpPost(uri, body.ToString());
        //    if (string.IsNullOrEmpty(json))
        //        return false;
        //    //need to check if result is ok
        //    Token = JsonConvert.DeserializeObject<TokenResult>(json);
        //    return true;
        //}

        //public class TokenResult
        //{
        //    public string Id { get; set; }
        //    public string Issued_at { get; set; }
        //    public string Instance_url { get; set; }
        //    public string Signature { get; set; }
        //    public string Access_token { get; set; }

        //}


        //public async Task<string> HttpPost(string uri, string body)
        //{
        //    var client = new HttpClient();// move out
        //    var content = new StringContent(body);
        //    content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
        //    try
        //    {
        //        HttpResponseMessage response = await client.PostAsync(uri, content);

        //        if (response.StatusCode == HttpStatusCode.OK)
        //            return await response.Content.ReadAsStringAsync();
        //        return string.Empty;
        //    }
        //    catch (WebException wex)
        //    {
        //        string err = wex.Message;
        //        return string.Empty;
        //    }

        //}
    }
}
