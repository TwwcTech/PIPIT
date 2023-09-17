namespace PIPIT.Backend.PublicIP.PIPResources
{
    internal class PIPParser
    {
        private PIPSetters? _setters;

        public PIPParser(PIPSetters setters)
        {
            _setters = setters;
        }

        public string Parse(string parseType)
        {
            try
            {
                switch (parseType.ToLower())
                {
                    case "ip":
                        return _setters?.ip!;
                    case "country":
                        return _setters?.country!;
                    case "iso":
                        return _setters?.country_iso!;
                    case "region":
                        return _setters?.region_name!;
                    case "regioncode":
                        return _setters?.region_code!;
                    case "zip":
                        return _setters?.zip_code!;
                    case "city":
                        return _setters?.city!;
                    case "lat":
                        return _setters?.latitude.ToString()!;
                    case "long":
                        return _setters?.longitude.ToString()!;
                    case "timezone":
                        return _setters?.time_zone!;
                    case "asnorg":
                        return _setters?.asn_org!;
                    case "hostname":
                        return _setters?.hostname!;
                    default:
                        throw new ArgumentException("not a category to parse");
                }
            }
            catch (Exception ex) { throw new Exception(ex.ToString()); }
        }
    }
}
