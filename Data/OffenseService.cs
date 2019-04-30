using System;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

public class OffenseService
{
    public async Task<List<Offense>> GetOffenses()
    {
        var client = new HttpClient();

        var offenses = new List<Offense>();

        var streamTask = client.GetStreamAsync("https://justiceservicesdev.richva.ci.richmond.va.us/services/empoweradultapi/api/offense/getall");

        var serializer = new DataContractJsonSerializer(typeof(List<Offense>));

        offenses = serializer.ReadObject(await streamTask) as List<Offense>;

        return offenses;
    }
}