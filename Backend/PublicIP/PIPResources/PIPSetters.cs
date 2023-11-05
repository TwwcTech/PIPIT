namespace PIPIT.Backend.PublicIP.PIPResources
{
    internal class PIPSetters
    {
        public string? ip { get; set; }
        public long ip_decimal { get; set; }
        public string? country { get; set; }
        public string? country_iso { get; set; }
        public bool country_eu { get; set; }
        public string? region_name { get; set; }
        public string? region_code { get; set; }
        public int metro_code { get; set; }
        public string? zip_code { get; set; }
        public string? city { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public string? time_zone { get; set; }
        public string? asn { get; set; }
        public string? asn_org { get; set; }
        public string? hostname { get; set; }
        public UserAgent? user_agent { get; set; }
    }

    internal class UserAgent
    {
        public string? product { get; set; }
        public string? version { get; set; }
        public string? comment { get; set; }
        public string? raw_value { get; set; }
    }
}