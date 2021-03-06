﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using IoTCentral;
using System.IO;

namespace IoTC
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "[ACCESS_TOKEN]");
            var continuousDataExportsClient = new ContinuousDataExportsClient(httpClient);
            continuousDataExportsClient.BaseUrl = "https://[APP_NAME].azureiotcentral.com/api/preview";

            var result = await continuousDataExportsClient.ListAsync();

            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
