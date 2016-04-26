using System;

public static void Run(TimerInfo myTimer, out string myBlob,  TraceWriter log)
{
    log.Verbose($"C# Timer trigger function executed at: {DateTime.Now}");
    var client = new HttpClient();
    var res = client.GetStringAsync("https://dr.dk").Result;
    
    myBlob = res;
}