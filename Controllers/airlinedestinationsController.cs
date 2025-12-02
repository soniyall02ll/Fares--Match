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
    public class airlinedestinationsController : Controller
    {
        // GET: airlinedestinations
        public ActionResult Index()
        {
            return View();
        }



        [Route("~/airline-destinations/air-canada-flights-to-austria.aspx/")]
        public ActionResult aircanadaflightstoaustria()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/air-canada-flights-to-bahamas.aspx/")]
        public ActionResult aircanadaflightstobahamas()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/air-canada-flights-to-brazil.aspx/")]
        public ActionResult aircanadaflightstobrazil()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/air-canada-flights-to-freeport.aspx/")]
        public ActionResult aircanadaflightstofreeport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/air-canada-flights-to-george-town.aspx/")]
        public ActionResult aircanadaflightstogeorgetown()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/air-canada-flights-to-grantley-adams-international-airport.aspx/")]
        public ActionResult aircanadaflightstograntleyadamsinternationalairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/air-canada-flights-to-nassau.aspx/")]
        public ActionResult aircanadaflightstonassau()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/air-canada-flights-to-rio-de-janeiro-airport.aspx/")]
        public ActionResult aircanadaflightstoriodejaneiroairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/air-canada-flights-to-sao-paulo.aspx/")]
        public ActionResult aircanadaflightstosaopaulo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/allegiant-air-to-akron.aspx/")]
        public ActionResult allegiantairtoakron()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/allegiant-air-to-alaska.aspx/")]
        public ActionResult allegiantairtoalaska()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-albany.aspx/")]
        public ActionResult allegiantairtoalbany()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-albuquerque.aspx/")]
        public ActionResult allegiantairtoalbuquerque()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-allentown.aspx/")]
        public ActionResult allegiantairtoallentown()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-amarillo.aspx/")]
        public ActionResult allegiantairtoamarillo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-anchorage.aspx/")]
        public ActionResult allegiantairtoanchorage()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-austin.aspx/")]
        public ActionResult allegiantairtoaustin()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-baltimore.aspx/")]
        public ActionResult allegiantairtobaltimore()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-bangor.aspx/")]
        public ActionResult allegiantairtobangor()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-belleville-st-louis.aspx/")]
        public ActionResult allegiantairtobellevillestlouis()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/allegiant-air-to-bellingham.aspx/")]
        public ActionResult allegiantairtobellingham()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/allegiant-air-to-billings.aspx/")]
        public ActionResult allegiantairtobillings()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/allegiant-air-to-bismmarck.aspx/")]
        public ActionResult allegiantairtobismmarck()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/allegiant-air-to-boise.aspx/")]
        public ActionResult allegiantairtoboise()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-boston.aspx/")]
        public ActionResult allegiantairtoboston()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/allegiant-air-to-bozeman.aspx/")]
        public ActionResult allegiantairtobozeman()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-bristol.aspx/")]
        public ActionResult allegiantairtobristol()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-cedar-rapids.aspx/")]
        public ActionResult allegiantairtocedarrapids()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/allegiant-air-to-charlotte-concord.aspx/")]
        public ActionResult allegiantairtocharlotteconcord()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-chattanooga.aspx/")]
        public ActionResult allegiantairtochattanooga()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-chicago-rockford.aspx/")]
        public ActionResult allegiantairtochicagorockford()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/allegiant-air-to-clarksburg.aspx/")]
        public ActionResult allegiantairtoclarksburg()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-columbus.aspx/")]
        public ActionResult allegiantairtocolumbus()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-dayton.aspx/")]
        public ActionResult allegiantairtodayton()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-denver.aspx/")]
        public ActionResult allegiantairtodenver()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-elmira.aspx/")]
        public ActionResult allegiantairtoelmira()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-el-paso.aspx/")]
        public ActionResult allegiantairtoelpaso()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-eugene.aspx/")]
        public ActionResult allegiantairtoeugene()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/allegiant-air-to-evansville.aspx/")]
        public ActionResult allegiantairtoevansville()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }




        [Route("~/airline-destinations/allegiant-air-to-fargo.aspx/")]
        public ActionResult allegiantairtofargo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-fayetteville.aspx/")]
        public ActionResult allegiantairtofayetteville()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/allegiant-air-to-idaho.aspx/")]
        public ActionResult allegiantairtoidaho()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-indiana.aspx/")]
        public ActionResult allegiantairtoindiana()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-lowa.aspx/")]
        public ActionResult allegiantairtolowa()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-maine.aspx/")]
        public ActionResult allegiantairtomaine()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-maryland.aspx/")]
        public ActionResult allegiantairtomaryland()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-missouri.aspx/")]
        public ActionResult allegiantairtomissouri()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/allegiant-air-to-new-mexico.aspx/")]
        public ActionResult allegiantairtonewmexico()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-new-york.aspx/")]
        public ActionResult allegiantairtonewyork()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-ohio.aspx/")]
        public ActionResult allegiantairtoohio()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-oregon.aspx/")]
        public ActionResult allegiantairtooregon()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-pennsylvania.aspx/")]
        public ActionResult allegiantairtopennsylvania()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-south-carolina.aspx/")]
        public ActionResult allegiantairtosouthcarolina()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-south-cincinnati.aspx/")]
        public ActionResult allegiantairtosouthcincinnati()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-south-ohio.aspx/")]
        public ActionResult allegiantairtosouthohio()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-tennessee.aspx/")]
        public ActionResult allegiantairtotennessee()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-texas.aspx/")]
        public ActionResult allegiantairtotexas()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-washington.aspx/")]
        public ActionResult allegiantairtowashington()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/allegiant-air-to-wisconsin.aspx/")]
        public ActionResult allegiantairtowisconsin()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-flights-to-washington-dc.aspx/")]
        public ActionResult allegiantflightstowashingtondc()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/avianca-flights-tickets-to-neiva.aspx/")]
        public ActionResult aviancaflightsticketstoneiva()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/avianca-flight-to-montevideo.aspx/")]
        public ActionResult aviancaflighttomontevideo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/avianca-flight-to-munich.aspx/")]
        public ActionResult aviancaflighttomunich()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/cheap-flights-to-btm.aspx/")]
        public ActionResult cheapflightstobtm()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-chicago.aspx/")]
        public ActionResult etihadflightstochicago()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-columbus.aspx/")]
        public ActionResult etihadflightstocolumbus()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-dallas.aspx/")]
        public ActionResult etihadflightstodallas()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-huntsville.aspx/")]
        public ActionResult etihadflightstohuntsville()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-los-angeles.aspx/")]
        public ActionResult etihadflightstolosangeles()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-miami.aspx/")]
        public ActionResult etihadflightstomiami()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-san-francisco.aspx/")]
        public ActionResult etihadflightstosanfrancisco()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-sharjah.aspx/")]
        public ActionResult etihadflightstosharjah()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-the-anchorage.aspx/")]
        public ActionResult etihadflightstotheanchorage()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-the-east-midlands.aspx/")]
        public ActionResult etihadflightstotheeastmidlands()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-the-london.aspx/")]
        public ActionResult etihadflightstothelondon()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-the-manchester.aspx/")]
        public ActionResult etihadflightstothemanchester()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-the-united-kingdom.aspx/")]
        public ActionResult etihadflightstotheunitedkingdom()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-the-united-states.aspx/")]
        public ActionResult etihadflightstotheunitedstates()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/etihad-flights-to-united-arab-emirates.aspx/")]
        public ActionResult etihadflightstounitedarabemirates()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/etihad-flights-to-washington-dc.aspx/")]
        public ActionResult etihadflightstowashingtondc()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-albania.aspx/")]
        public ActionResult lotpolishflightstoalbania()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-armenia.aspx/")]
        public ActionResult lotpolishflightstoarmenia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-austria.aspx/")]
        public ActionResult lotpolishflightstoaustria()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-belarus.aspx/")]
        public ActionResult lotpolishflightstobelarus()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-brazil.aspx/")]
        public ActionResult lotpolishflightstobrazil()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-brussels.aspx/")]
        public ActionResult lotpolishflightstobrussels()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-brussels-airport.aspx/")]
        public ActionResult lotpolishflightstobrusselsairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/lot-polish-flights-to-bulgaria.aspx/")]
        public ActionResult lotpolishflightstobulgaria()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/lot-polish-flights-to-canada.aspx/")]
        public ActionResult lotpolishflightstocanada()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-china.aspx/")]
        public ActionResult lotpolishflightstochina()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-minsk.aspx/")]
        public ActionResult lotpolishflightstominsk()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-montreal.aspx/")]
        public ActionResult lotpolishflightstomontreal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-montreal-international-airport.aspx/")]
        public ActionResult lotpolishflightstomontrealinternationalairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-rio-de-janerio.aspx/")]
        public ActionResult lotpolishflightstoriodejanerio()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-toronto.aspx/")]
        public ActionResult lotpolishflightstotoronto()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-vienna.aspx/")]
        public ActionResult lotpolishflightstovienna()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/lot-polish-flights-to-yerevan.aspx/")]
        public ActionResult lotpolishflightstoyerevan()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/singapore-airlines-flights-to-bahrain.aspx/")]
        public ActionResult singaporeairlinesflightstobahrain()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-chicago.aspx/")]
        public ActionResult singaporeairlinesflightstochicago()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-fukuoka.aspx/")]
        public ActionResult singaporeairlinesflightstofukuoka()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/singapore-airlines-flights-to-hiroshima.aspx/")]
        public ActionResult singaporeairlinesflightstohiroshima()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-japan.aspx/")]
        public ActionResult singaporeairlinesflightstojapan()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-kota-kinabalu.aspx/")]
        public ActionResult singaporeairlinesflightstokotakinabalu()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-kuantan.aspx/")]
        public ActionResult singaporeairlinesflightstokuantan()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/singapore-airlines-flights-to-kuwait.aspx/")]
        public ActionResult singaporeairlinesflightstokuwait()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-kuwait-city.aspx/")]
        public ActionResult singaporeairlinesflightstokuwaitcity()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-las-vegas.aspx/")]
        public ActionResult singaporeairlinesflightstolasvegas()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-london.aspx/")]
        public ActionResult singaporeairlinesflightstolondon()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-los-angeles.aspx/")]
        public ActionResult singaporeairlinesflightstolosangeles()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-luqa.aspx/")]
        public ActionResult singaporeairlinesflightstoluqa()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-manchester.aspx/")]
        public ActionResult singaporeairlinesflightstomanchester()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-mandalay.aspx/")]
        public ActionResult singaporeairlinesflightstomandalay()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-mauritius.aspx/")]
        public ActionResult singaporeairlinesflightstomauritius()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-osaka.aspx/")]
        public ActionResult singaporeairlinesflightstoosaka()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/singapore-airlines-flights-to-sapporo.aspx/")]
        public ActionResult singaporeairlinesflightstosapporo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/singapore-airlines-flights-to-sendai.aspx/")]
        public ActionResult singaporeairlinesflightstosendai()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-airlines-flights-to-tokyo.aspx/")]
        public ActionResult singaporeairlinesflightstotokyo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/singapore-flights-to-adelaide.aspx/")]
        public ActionResult singaporeflightstoadelaide()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-athens.aspx/")]
        public ActionResult singaporeflightstoathens()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-auckland.aspx/")]
        public ActionResult singaporeflightstoauckland()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-australia.aspx/")]
        public ActionResult singaporeflightstoaustralia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-bandar-seri-begawan.aspx/")]
        public ActionResult singaporeflightstobandarseribegawan()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-bandung.aspx/")]
        public ActionResult singaporeflightstobandung()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-bangladesh.aspx/")]
        public ActionResult singaporeflightstobangladesh()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-beijing.aspx/")]
        public ActionResult singaporeflightstobeijing()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-belgium.aspx/")]
        public ActionResult singaporeflightstobelgium()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }




        [Route("~/airline-destinations/singapore-flights-to-brazil.aspx/")]
        public ActionResult singaporeflightstobrazil()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-brisbane.aspx/")]
        public ActionResult singaporeflightstobrisbane()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-brunei.aspx/")]
        public ActionResult singaporeflightstobrunei()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-cairns.aspx/")]
        public ActionResult singaporeflightstocairns()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-cairo.aspx/")]
        public ActionResult singaporeflightstocairo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/singapore-flights-to-cambodia.aspx/")]
        public ActionResult singaporeflightstocambodia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-canberra.aspx/")]
        public ActionResult singaporeflightstocanberra()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-chittagong.aspx/")]
        public ActionResult singaporeflightstochittagong()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-christchurch.aspx/")]
        public ActionResult singaporeflightstochristchurch()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-copenhagen.aspx/")]
        public ActionResult singaporeflightstocopenhagen()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-darwin.aspx/")]
        public ActionResult singaporeflightstodarwin()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-dhaka.aspx/")]
        public ActionResult singaporeflightstodhaka()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-egypt.aspx/")]
        public ActionResult singaporeflightstoegypt()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-france.aspx/")]
        public ActionResult singaporeflightstofrance()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-frankfurt.aspx/")]
        public ActionResult singaporeflightstofrankfurt()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-germany.aspx/")]
        public ActionResult singaporeflightstogermany()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-greece.aspx/")]
        public ActionResult singaporeflightstogreece()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-guangzhou.aspx/")]
        public ActionResult singaporeflightstoguangzhou()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-hangzhou.aspx/")]
        public ActionResult singaporeflightstohangzhou()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-hong-kong.aspx/")]
        public ActionResult singaporeflightstohongkong()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-iran.aspx/")]
        public ActionResult singaporeflightstoiran()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-malaysia.aspx/")]
        public ActionResult singaporeflightstomalaysia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-maldives.aspx/")]
        public ActionResult singaporeflightstomaldives()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-male.aspx/")]
        public ActionResult singaporeflightstomale()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-manila.aspx/")]
        public ActionResult singaporeflightstomanila()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-medan.aspx/")]
        public ActionResult singaporeflightstomedan()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-melbourne.aspx/")]
        public ActionResult singaporeflightstomelbourne()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/singapore-flights-to-nanjing.aspx/")]
        public ActionResult singaporeflightstonanjing()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-nepal.aspx/")]
        public ActionResult singaporeflightstonepal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-netherlands.aspx/")]
        public ActionResult singaporeflightstonetherlands()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-newark.aspx/")]
        public ActionResult singaporeflightstonewark()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-new-york-city.aspx/")]
        public ActionResult singaporeflightstonewyorkcity()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-new-zealand.aspx/")]
        public ActionResult singaporeflightstonewzealand()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-papua-new-guinea.aspx/")]
        public ActionResult singaporeflightstopapuanewguinea()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-penang.aspx/")]
        public ActionResult singaporeflightstopenang()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-perth.aspx/")]
        public ActionResult singaporeflightstoperth()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-philippines.aspx/")]
        public ActionResult singaporeflightstophilippines()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-port-moresby.aspx/")]
        public ActionResult singaporeflightstoportmoresby()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-rome.aspx/")]
        public ActionResult singaporeflightstorome()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/singapore-flights-to-san-francisco.aspx/")]
        public ActionResult singaporeflightstosanfrancisco()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-sao-paulo.aspx/")]
        public ActionResult singaporeflightstosaopaulo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/singapore-flights-to-shenzhen.aspx/")]
        public ActionResult singaporeflightstoshenzhen()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/singapore-flights-to-siem-reap.aspx/")]
        public ActionResult singaporeflightstosiemreap()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/singapore-flights-to-surabaya.aspx/")]
        public ActionResult singaporeflightstosurabaya()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/singapore-flights-to-sydney.aspx/")]
        public ActionResult singaporeflightstosydney()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/singapore-flights-to-tehran.aspx/")]
        public ActionResult singaporeflightstotehran()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/singapore-flights-to-toronto.aspx/")]
        public ActionResult singaporeflightstotoronto()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/singapore-flights-to-united-kingdom.aspx/")]
        public ActionResult singaporeflightstounitedkingdom()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/singapore-flights-to-united-states.aspx/")]
        public ActionResult singaporeflightstounitedstates()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-vienna.aspx/")]
        public ActionResult singaporeflightstovienna()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/singapore-flights-to-yangon.aspx/")]
        public ActionResult singaporeflightstoyangon()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-alabama.aspx/")]
        public ActionResult southwestflightstoalabama()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-arizona.aspx/")]
        public ActionResult southwestflightstoarizona()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-arkansas.aspx/")]
        public ActionResult southwestflightstoarkansas()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-aruba.aspx/")]
        public ActionResult southwestflightstoaruba()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-bahamas.aspx/")]
        public ActionResult southwestflightstobahamas()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-belize.aspx/")]
        public ActionResult southwestflightstobelize()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-belize-city.aspx/")]
        public ActionResult southwestflightstobelizecity()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-birmingham.aspx/")]
        public ActionResult southwestflightstobirmingham()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-california.aspx/")]
        public ActionResult southwestflightstocalifornia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-cayman-islands.aspx/")]
        public ActionResult southwestflightstocaymanislands()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-colorado.aspx/")]
        public ActionResult southwestflightstocolorado()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-colorado-springs.aspx/")]
        public ActionResult southwestflightstocoloradosprings()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-connecticut.aspx/")]
        public ActionResult southwestflightstoconnecticut()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-costa-rica.aspx/")]
        public ActionResult southwestflightstocostarica()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-destin.aspx/")]
        public ActionResult southwestflightstodestin()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-florida.aspx/")]
        public ActionResult southwestflightstoflorida()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-fort-lauderdale.aspx/")]
        public ActionResult southwestflightstofortlauderdale()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-fort-myers.aspx/")]
        public ActionResult southwestflightstofortmyers()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-fresno.aspx/")]
        public ActionResult southwestflightstofresno()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-georgia.aspx/")]
        public ActionResult southwestflightstogeorgia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-hartford.aspx/")]
        public ActionResult southwestflightstohartford()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-havana.aspx/")]
        public ActionResult southwestflightstohavana()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-hawaii.aspx/")]
        public ActionResult southwestflightstohawaii()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-hilo.aspx/")]
        public ActionResult southwestflightstohilo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-honolulu.aspx/")]
        public ActionResult southwestflightstohonolulu()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-idaho.aspx/")]
        public ActionResult southwestflightstoidaho()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-jacksonville.aspx/")]
        public ActionResult southwestflightstojacksonville()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-jamaica.aspx/")]
        public ActionResult southwestflightstojamaica()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-kahului.aspx/")]
        public ActionResult southwestflightstokahului()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-lihue.aspx/")]
        public ActionResult southwestflightstolihue()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-little-rock.aspx/")]
        public ActionResult southwestflightstolittlerock()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-long-beach.aspx/")]
        public ActionResult southwestflightstolongbeach()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-los-angeles.aspx/")]
        public ActionResult southwestflightstolosangeles()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-mexico.aspx/")]
        public ActionResult southwestflightstomexico()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-miami.aspx/")]
        public ActionResult southwestflightstomiami()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-montego.aspx/")]
        public ActionResult southwestflightstomontego()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-montegoy-bay.aspx/")]
        public ActionResult southwestflightstomontegoybay()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-nassau.aspx/")]
        public ActionResult southwestflightstonassau()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-ontario.aspx/")]
        public ActionResult southwestflightstoontario()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-orange-county.aspx/")]
        public ActionResult southwestflightstoorangecounty()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-orlando.aspx/")]
        public ActionResult southwestflightstoorlando()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-palm-beach.aspx/")]
        public ActionResult southwestflightstopalmbeach()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-palm-springs.aspx/")]
        public ActionResult southwestflightstopalmsprings()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-panama-city.aspx/")]
        public ActionResult southwestflightstopanamacity()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-pensacoa.aspx/")]
        public ActionResult southwestflightstopensacoa()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-phoenix.aspx/")]
        public ActionResult southwestflightstophoenix()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-punta-cana.aspx/")]
        public ActionResult southwestflightstopuntacana()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-sacramento.aspx/")]
        public ActionResult southwestflightstosacramento()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-san-diego.aspx/")]
        public ActionResult southwestflightstosandiego()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-san-francisco.aspx/")]
        public ActionResult southwestflightstosanfrancisco()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-sanjose.aspx/")]
        public ActionResult southwestflightstosanjose()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-san-jose-del-cabo.aspx/")]
        public ActionResult southwestflightstosanjosedelcabo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-sarasota.aspx/")]
        public ActionResult southwestflightstosarasota()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-savannah.aspx/")]
        public ActionResult southwestflightstosavannah()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-steamboat-springs.aspx/")]
        public ActionResult southwestflightstosteamboatsprings()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/southwest-flights-to-tampa.aspx/")]
        public ActionResult southwestflightstotampa()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/southwest-flights-to-turks-and-caicos-islands.aspx/")]
        public ActionResult southwestflightstoturksandcaicosislands()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/spirit-airlines-flights-armenia.aspx/")]
        public ActionResult spiritairlinesflightsarmenia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/spirit-airlines-flights-aruba.aspx/")]
        public ActionResult spiritairlinesflightsaruba()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/spirit-airlines-flights-bogota.aspx/")]
        public ActionResult spiritairlinesflightsbogota()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/spirit-airlines-flights-bucaramanga.aspx/")]
        public ActionResult spiritairlinesflightsbucaramanga()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/spirit-airlines-flights-colombia.aspx/")]
        public ActionResult spiritairlinesflightscolombia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/spirit-airlines-flights-dominican-republic.aspx/")]
        public ActionResult spiritairlinesflightsdominicanrepublic()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/spirit-airlines-flights-el-salvador.aspx/")]
        public ActionResult spiritairlinesflightselsalvador()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/spirit-airlines-flights-medellin.aspx/")]
        public ActionResult spiritairlinesflightsmedellin()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/spirit-airlines-flights-oranjestad.aspx/")]
        public ActionResult spiritairlinesflightsoranjestad()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/spirit-airlines-flights-punta-cana.aspx/")]
        public ActionResult spiritairlinesflightspuntacana()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/spirit-airlines-flights-san-jose-de-costa-rica.aspx/")]
        public ActionResult spiritairlinesflightssanjosedecostarica()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-alaska.aspx/")]
        public ActionResult unitedflightstoalaska()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-anchorage.aspx/")]
        public ActionResult unitedflightstoanchorage()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-arizona.aspx/")]
        public ActionResult unitedflightstoarizona()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-atlanta.aspx/")]
        public ActionResult unitedflightstoatlanta()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-baltimore.aspx/")]
        public ActionResult unitedflightstobaltimore()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-california.aspx/")]
        public ActionResult unitedflightstocalifornia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-cedar-rapids.aspx/")]
        public ActionResult unitedflightstocedarrapids()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-chicago.aspx/")]
        public ActionResult unitedflightstochicago()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-colorado.aspx/")]
        public ActionResult unitedflightstocolorado()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-connecticut.aspx/")]
        public ActionResult unitedflightstoconnecticut()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-denver.aspx/")]
        public ActionResult unitedflightstodenver()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-fairbanks.aspx/")]
        public ActionResult unitedflightstofairbanks()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-fort-myers.aspx/")]
        public ActionResult unitedflightstofortmyers()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-fresno.aspx/")]
        public ActionResult unitedflightstofresno()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-georgia.aspx/")]
        public ActionResult unitedflightstogeorgia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-guam.aspx/")]
        public ActionResult unitedflightstoguam()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-hartford.aspx/")]
        public ActionResult unitedflightstohartford()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-honululu.aspx/")]
        public ActionResult unitedflightstohonululu()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-illinois.aspx/")]
        public ActionResult unitedflightstoillinois()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-indiana.aspx/")]
        public ActionResult unitedflightstoindiana()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-jacksonville.aspx/")]
        public ActionResult unitedflightstojacksonville()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-kahului.aspx/")]
        public ActionResult unitedflightstokahului()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-kona.aspx/")]
        public ActionResult unitedflightstokona()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-los-angeles.aspx/")]
        public ActionResult unitedflightstolosangeles()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-louisville.aspx/")]
        public ActionResult unitedflightstolouisville()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-maryland.aspx/")]
        public ActionResult unitedflightstomaryland()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-massachusetts.aspx/")]
        public ActionResult unitedflightstomassachusetts()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-miami.aspx/")]
        public ActionResult unitedflightstomiami()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-montrose.aspx/")]
        public ActionResult unitedflightstomontrose()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-oakland.aspx/")]
        public ActionResult unitedflightstooakland()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-ontario.aspx/")]
        public ActionResult unitedflightstoontario()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-orange-county.aspx/")]
        public ActionResult unitedflightstoorangecountry()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-orlando.aspx/")]
        public ActionResult unitedflightstoorlando()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-palm-springs.aspx/")]
        public ActionResult unitedflightstopalmsprings()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-panama-city.aspx/")]
        public ActionResult unitedflightstopanamacity()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-pensacola.aspx/")]
        public ActionResult unitedflightstopensacola()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-phoenix.aspx/")]
        public ActionResult unitedflightstophoenix()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-portland.aspx/")]
        public ActionResult unitedflightstoportland()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-sacramento.aspx/")]
        public ActionResult unitedflightstosacramento()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-san-diego.aspx/")]
        public ActionResult unitedflightstosandiego()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-san-francisco.aspx/")]
        public ActionResult unitedflightstosanfrancisco()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-san-jose.aspx/")]
        public ActionResult unitedflightstosanjose()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-santa-barbara.aspx/")]
        public ActionResult unitedflightstosantabarbara()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-sarasota.aspx/")]
        public ActionResult unitedflightstosarasota()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-savannah.aspx/")]
        public ActionResult unitedflightstosavannah()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-tampa.aspx/")]
        public ActionResult unitedflightstotampa()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/united-flights-to-tucson.aspx/")]
        public ActionResult unitedflightstotucson()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-vail.aspx/")]
        public ActionResult unitedflightstovail()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-west-palm-beach.aspx/")]
        public ActionResult unitedflightstowestpalmbeach()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/united-flights-to-wichita.aspx/")]
        public ActionResult unitedflightstowichita()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/avelo-airlines-burbank.aspx/")]
        public ActionResult aveloairlinesburbank()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/avelo-airlines-delaware.aspx/")]
        public ActionResult aveloairlinesdelaware()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/avelo-airlines-new-haven.aspx/")]
        public ActionResult aveloairlinesnewhaven()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/avelo-airlines-santa-rosa.aspx/")]
        public ActionResult aveloairlinessantarosa()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/avelo-airlines-wilmington.aspx/")]
        public ActionResult aveloairlineswilmington()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/copa-airlines-jfk.aspx/")]
        public ActionResult copaairlinesjfk()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/copa-airlines-lax.aspx/")]
        public ActionResult copaairlineslax()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/copa-airlines-miami-airport.aspx/")]
        public ActionResult copaairlinesmiamiairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/frontier-airlines-charlotte-airport.aspx/")]
        public ActionResult frontierairlinescharlotteairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/frontier-airlines-mco-terminal.aspx/")]
        public ActionResult frontierairlinesmcoterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/frontier-airlines-msp-terminal.aspx/")]
        public ActionResult frontierairlinesmspterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/frontier-airlines-puerto-rico.aspx/")]
        public ActionResult frontierairlinespuertorico()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/frontier-airlines-terminal-dfw.aspx/")]
        public ActionResult frontierairlinesterminaldfw()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/hawaiian-airlines-lax-terminal.aspx/")]
        public ActionResult hawaiianairlineslaxterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/hawaiian-airlines-lax-to-maui.aspx/")]
        public ActionResult hawaiianairlineslaxtomaui()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/hawaiian-airlines-seattle-to-maui.aspx/")]
        public ActionResult hawaiianairlinesseattletomaui()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/lufthansa-boston-to-frankfurt.aspx/")]
        public ActionResult lufthansabostontofrankfurt()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/lufthansa-chicago-to-frankfurt.aspx/")]
        public ActionResult lufthansachicagotofrankfurt()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/lufthansa-denver-to-frankfurt.aspx/")]
        public ActionResult lufthansadenvertofrankfurt()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/lufthansa-lax-to-frankfurt.aspx/")]
        public ActionResult lufthansalaxtofrankfurt()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/lufthansa-seattle-to-frankfurt.aspx/")]
        public ActionResult lufthansaseattletofrankfurt()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/lufthansa-sfo-to-frankfurt.aspx/")]
        public ActionResult lufthansasfotofrankfurt()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/spirit-airlines-atlantic-city-airport.aspx/")]
        public ActionResult spiritairlinesatlanticcityairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/spirit-airlines-bush-airport-terminal.aspx/")]
        public ActionResult spiritairlinesbushairportterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/spirit-airlines-dfw-terminal.aspx/")]
        public ActionResult spiritairlinesdfwterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/spirit-airlines-ewr-terminal.aspx/")]
        public ActionResult spiritairlinesewrterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/spirit-airlines-lax-terminal.aspx/")]
        public ActionResult spiritairlineslaxterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/sun-country-airlines-dfw-terminal.aspx/")]
        public ActionResult suncountryairlinesdfwterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/sun-country-airlines-jfk-terminal.aspx/")]
        public ActionResult suncountryairlinesjfkterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/sun-country-airlines-lax-terminal.aspx/")]
        public ActionResult suncountryairlineslaxterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/sun-country-airlines-minneapolis-terminal.aspx/")]
        public ActionResult suncountryairlinesminneapolisterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/westjet-airlines-jfk-terminal.aspx/")]
        public ActionResult westjetairlinesjfkterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airline-destinations/westjet-airlines-lax-terminal.aspx/")]
        public ActionResult westjetairlineslaxterminal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/sun-country-airlines-msp-airport.aspx/")]
        public ActionResult suncountryairlinesmspairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/air-canada-flights-to-bermuda.aspx/")]
        public ActionResult aircanadaflightstobermuda()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airline-destinations/allegiant-air-to-bismarck.aspx/")]
        public ActionResult allegiantairtobismarck()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/lot-polish-flights-to-rio-de-janeiro.aspx/")]
        public ActionResult lotpolishflightstoriodejaneiro()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/southwest-flights-to-montego-bay.aspx/")]
        public ActionResult southwestflightstomontegobay()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }




        [Route("~/airline-destinations/southwest-flights-to-pensacola.aspx/")]
        public ActionResult southwestflightstopensacola()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/airline-destinations/united-flights-to-honolulu.aspx/")]
        public ActionResult unitedflightstohonolulu()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }
    }
}