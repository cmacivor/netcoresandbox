using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

public class BingMapService
{
    public async Task<List<BingServer.Address>> GetAddresses()
    {
          var client = new HttpClient();

          var addresses = new List<BingServer.Address>();

          var streamTasl = client.GetStreamAsync("https://dev.virtualearth.net/REST/v1/Locations?countryRegion=US&amp;addressLine=broad&key=AioE2WYI4PFEB6QJ05ws3SYzEfBmT4Dq4GcO-ACemmZnFi5pyKjXeE44i9Qz0QOS");

          var serializer = new DataContractJsonSerializer(typeof(List<BingServer.Address>));

          addresses = serializer.ReadObject(await streamTasl) as List<BingServer.Address>;

          return addresses;
    }
}