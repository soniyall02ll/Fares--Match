using System;
using System.Collections.Generic;

namespace Viman.Models
{
    public class Root
    {
        public string uid { get; set; }
        public string searchID { get; set; }
        public string provider { get; set; }
        public string currency { get; set; }
        public string valCarrier { get; set; }
        public string fareFamily { get; set; }
        public bool promotionalFare { get; set; }
        public double grandTotal { get; set; }
        public object travelTime { get; set; }
        public List<Sector> sectors { get; set; }
        public List<PriceBreakup> priceBreakup { get; set; }
    }

    public class Sector
    {
        public string airlineCode { get; set; }
        public string airlineName { get; set; }
        public string group { get; set; }
        public string key { get; set; }
        public string fltNum { get; set; }
        public string equipType { get; set; }
        public string distance { get; set; }
        public string eTicket { get; set; }
        public string changeOfPlane { get; set; }
        public string baggageInfo { get; set; }
        public string handBaggage { get; set; }
        public string travelTime { get; set; }
        public string cabinClass { get; set; }
        public string availabilitySource { get; set; }
        public string fareBasisCode { get; set; }
        public Carrier marketingCarrier { get; set; }
        public Carrier operatingCarrier { get; set; }
        public SectorLocation departure { get; set; }
        public SectorLocation arrival { get; set; }
    }

    public class Carrier
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public class SectorLocation
    {
        public string code { get; set; }
        public string name { get; set; }
        public string cityCode { get; set; }
        public string cityName { get; set; }
        public string countryCode { get; set; }
        public string countryName { get; set; }
        public string terminal { get; set; }
        public string date { get; set; }
        public string time { get; set; }
    }

    public class PriceBreakup
    {
        public string passengerType { get; set; }  // "ADT", "CHD", "INF"
        public int noOfPassenger { get; set; }
        public double baseFare { get; set; }
        public double tax { get; set; }
        public double markUp { get; set; }
    }
}
