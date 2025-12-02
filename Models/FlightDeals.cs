using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;

namespace Viman.Models
{
    public class FlightDeals
    {

        public static FlightsResult GetFlightResult(string Dcode,string Gcode,string DepDate,string RetDate,string AirCode="")
        {
            FlightsSearch FlySearch = new FlightsSearch();

            FlySearch.SearchId = Common.GetId();
            FlySearch.FlightWay = FlightWay.RoundTrip;
            FlySearch.From = Common.GetAirport(Dcode); ;
            FlySearch.To = Common.GetAirport(Gcode);
            FlySearch.DepDate = Convert.ToDateTime(DepDate); ;

            FlySearch.RetDate = Convert.ToDateTime(RetDate);
            FlySearch.Adult = 1;
            FlySearch.Child = 0;
            FlySearch.Infant = 0;
            FlySearch.FlightClass = FlightClass.Economy;
            FlySearch.Airline = Common.GetAirline(AirCode);
            FlySearch.IsDirect = false;
            FlySearch.IsFlexi = true;
            FlySearch.Currency = "GBP";
            FlySearch.SiteCode = "VIMAN";
            FlySearch.SourceMedia = "VIMAN";
            FlySearch.IsDeepLink = false;
            FlySearch.ApiKey = Common.ApiKey;

            return Common.SearchFlight(FlySearch);


        }
    }
}