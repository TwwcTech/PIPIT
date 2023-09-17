using Newtonsoft.Json;
using PIPIT.Backend.PublicIP.PIPResources;

namespace PIPIT.Backend.PublicIP
{
    internal class RequestPIP
    {
        public static async Task<PIPSetters> RequestJson()
        {
            PIPSetters jsonSetters;
            using (HttpClient client = new())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    string jsonContent = await client.GetStringAsync(@"https://ifconfig.co/json");

                    jsonSetters = JsonConvert.DeserializeObject<PIPSetters>(jsonContent)!;
                    return jsonSetters;
                }
                catch (HttpRequestException ex) { throw new HttpRequestException(ex.ToString()); }
            }
        }
    }
}
