namespace PIPIT.Backend.PublicIP.PIPResources
{
    internal class PIPSetters
    {
        string? ip { get; set; }
        long ip_decimal { get; set; }
        string? country { get; set; }
        string? country_iso { get; set; }
        bool country_eu { get; set; }
        string? region_name { get; set; }
        string? region_code { get; set; }
        int metro_code { get; set; }
        string? zip_code { get; set; }
        string? city { get; set; }
        double? latitude { get; set; }
        double? longitude { get; set; }
        string? time_zone { get; set; }
        string? asn { get; set; }
        string? asn_org { get; set; }
        string? hostname { get; set; }
        UserAgent? user_agent { get; set; }
    }

    internal class UserAgent
    {
        string? product { get; set; }
        string? version { get; set; }
        string? comment { get; set; }
        string? raw_value { get; set; }
    }
}
