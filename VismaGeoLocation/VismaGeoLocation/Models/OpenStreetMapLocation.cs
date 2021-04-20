using System;
using System.Collections.Generic;
using System.Text;

namespace VismaGeoLocation.Models
{
    public class OpenAddress
    {
        public string house_number { get; set; }
        public string road { get; set; }
        public string village { get; set; }
        public string municipality { get; set; }
        public string state { get; set; }
        public string postcode { get; set; }
        public string country { get; set; }
        public string country_code { get; set; }
    }

    public class OpenLocationRoot
    {
        public int place_id { get; set; }
        public string licence { get; set; }
        public string osm_type { get; set; }
        public long osm_id { get; set; }
        public string lat { get; set; }
        public string lon { get; set; }
        public string display_name { get; set; }
        public OpenAddress address { get; set; }
        public List<string> boundingbox { get; set; }
    }
}
