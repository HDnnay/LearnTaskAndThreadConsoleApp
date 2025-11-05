// See https://aka.ms/new-console-template for more information

using System.Text.Json;
using LocationSDK;
using System.Text.Json.Serialization;

try
{
    var httpclient = new HttpClient(){Timeout = TimeSpan.FromSeconds(60) };
    var appClient = new LoginClient(httpclient);
    var Paramets = new LoginRequest().Parameters = new Dictionary<string, string>()
    {
        { "phone","13800138000" },
        { "code","1234" }
    };
    var reuslt = await appClient.LoginAsync("Phone", new LoginRequest() { Parameters = Paramets });

    Console.WriteLine($"{reuslt.Success}:{reuslt.Message}");
    
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


