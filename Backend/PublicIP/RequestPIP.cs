using Newtonsoft.Json;
using PIPIT.Backend.PublicIP.PIPResources;

namespace PIPIT.Backend.PublicIP
{
    internal static class RequestPIP
    {
        public static async Task<PIPSetters> RequestJson()
        {
            using HttpClient client = new();
            try
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
                string jsonContent = await client.GetStringAsync(@"https://ifconfig.co/json");

                return JsonConvert.DeserializeObject<PIPSetters>(jsonContent)!;
            }
            catch (HttpRequestException ex) { throw new HttpRequestException(ex.ToString()); }
        }
    }
}
