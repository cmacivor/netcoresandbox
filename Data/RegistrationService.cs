
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

public class RegistrationService
{
    public async Task<Response> RegisterUser(Registration registration)
    {
        var client = new HttpClient();

        var stringData = JsonConvert.SerializeObject(registration);

        var contentData = new StringContent(stringData, System.Text.Encoding.UTF8, "application/json");

        var response = await client.PostAsync("https://justiceservicesdev.richva.ci.richmond.va.us/services/empoweradultapi/api/account/register", contentData);

        var result = response.Content.ReadAsStringAsync().Result;

        var deserialized = JsonConvert.DeserializeObject<Response>(result);

        return deserialized;
    }
}
