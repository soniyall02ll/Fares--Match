using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Viman.Models;

namespace Viman.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        public JsonResult GetAirport()
        {
            string searchLocation = Request.QueryString["pickUpLocation"];

            List<Airport> airportList = Common.GetAllAirport(searchLocation);

            return Json(airportList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCountry()
        {
            string searchLocation = Request.QueryString["pickUpLocation"];

            List<Country> countryList = Common.GetAllCountry(searchLocation);

            return Json(countryList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetCity()
        {
            string searchLocation = Request.QueryString["pickUpLocation"];

            List<City> cityList = Common.GetAllCity(searchLocation);

            return Json(cityList, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetLocation()
        {
            string searchLocation = Request.QueryString["pickUpLocation"];

            List<CarLocation> locationList = Common.GetAllLocation(searchLocation);

            return Json(locationList, JsonRequestBehavior.AllowGet);
        }
    }
}