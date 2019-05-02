using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class BingMapService
{
    public async Task<BingServer.RootObject> GetAddresses()
    {
          var client = new HttpClient();

          //var addresses = new BingServer();

          //var streamTasl = await client.GetStreamAsync("https://dev.virtualearth.net/REST/v1/Locations?countryRegion=US&addressLine=2810%20Fendall&key=AioE2WYI4PFEB6QJ05ws3SYzEfBmT4Dq4GcO-ACemmZnFi5pyKjXeE44i9Qz0QOS").ConfigureAwait(continueOnCapturedContext: false);

        //   var jsonResult = await client.GetStringAsync("https://dev.virtualearth.net/REST/v1/Locations?countryRegion=US&amp;addressLine=broad&key=AioE2WYI4PFEB6QJ05ws3SYzEfBmT4Dq4GcO-ACemmZnFi5pyKjXeE44i9Qz0QOS");
          var jsonResult = await client.GetStringAsync("https://dev.virtualearth.net/REST/v1/Locations?countryRegion=US&addressLine=2810%20Fendall&key=AioE2WYI4PFEB6QJ05ws3SYzEfBmT4Dq4GcO-ACemmZnFi5pyKjXeE44i9Qz0QOS");

          var serializer = new DataContractJsonSerializer(typeof(BingServer.RootObject));
     
          //var addresses = serializer.ReadObject(streamTasl) as BingServer.RootObject;

        //   var bingServer = new BingServer();

        //MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonResult));

        //   var newSerializer = new DataContractJsonSerializer(bingServer.GetType());
         //var bingServer = serializer.ReadObject(ms) as BingServer.RootObject;
         //ms.Close();
         
          var result = JsonConvert.DeserializeObject<BingServer.RootObject>(jsonResult);
        
        return result;
          //return addresses;
          //return bingServer;

          //var objects =  serializer.ReadObject(streamTasl) as BingServer.RootObject;

         //return bingServer;
    }
}