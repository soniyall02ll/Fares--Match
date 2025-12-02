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
    public class travelagencyController : Controller
    {
        // GET: travelagency
        public ActionResult Index()
        {
            return View();
        }


        [Route("~/travel-agency/agoda.aspx/")]
        public ActionResult agoda()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/airfarewatchdog.aspx/")]
        public ActionResult airfarewatchdog()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/booking.com.aspx/")]
        public ActionResult bookingcom()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/bookingbuddy.aspx/")]
        public ActionResult bookingbuddy()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/travel-agency/cheapair.aspx/")]
        public ActionResult cheapair()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/travel-agency/cheapoair.aspx/")]
        public ActionResult cheapoair()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/esky.aspx/")]
        public ActionResult esky()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/flightfinder.aspx/")]
        public ActionResult flightfinder()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/travel-agency/flighthub.aspx/")]
        public ActionResult flighthub()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/travel-agency/googleflights.aspx/")]
        public ActionResult googleflights()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/hopper.aspx/")]
        public ActionResult hopper()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/hotwire.aspx/")]
        public ActionResult hotwire()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/justfly.aspx/")]
        public ActionResult justfly()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/kayak.aspx/")]
        public ActionResult kayak()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/kiwi.com.aspx/")]
        public ActionResult kiwicom()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/travel-agency/momondo.aspx/")]
        public ActionResult momondo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/orbitz.aspx/")]
        public ActionResult orbitz()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/scottscheapflights.aspx/")]
        public ActionResult scottscheapflights()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/travel-agency/seatguru.aspx/")]
        public ActionResult seatguru()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/travel-agency/skiplagged.aspx/")]
        public ActionResult skiplagged()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/skyscanner.aspx/")]
        public ActionResult skyscanner()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/travelbuddy.aspx/")]
        public ActionResult travelbuddy()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/travelocity.aspx/")]
        public ActionResult travelocity()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/travelzoo.aspx/")]
        public ActionResult travelzoo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/trip.com.aspx/")]
        public ActionResult tripcom()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/travel-agency/tripadvisor.aspx/")]
        public ActionResult tripadvisor()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/trivago.aspx/")]
        public ActionResult trivago()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/travel-agency/wego.aspx/")]
        public ActionResult wego()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/travel-agency/wheelsup.aspx/")]
        public ActionResult wheelsup()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
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