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
    public class businessclassController : Controller
    {
        // GET: businessclass
        public ActionResult Index()
        {
            return View();
        }



        [Route("~/business-class/air-canada.aspx/")]
        public ActionResult aircanada()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/air-france.aspx/")]
        public ActionResult airfrance()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/british-airways.aspx/")]
        public ActionResult britishairways()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/delta.aspx/")]
        public ActionResult delta()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/emirates.aspx/")]
        public ActionResult emirates()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/etihad.aspx/")]
        public ActionResult etihad()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/eva-air.aspx/")]
        public ActionResult evaair()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/hawaiian-airlines.aspx/")]
        public ActionResult hawaiianairlines()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/japan-airlines.aspx/")]
        public ActionResult japanairlines()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/jetblue.aspx/")]
        public ActionResult jetblue()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/klm.aspx/")]
        public ActionResult klm()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/lufthansa.aspx/")]
        public ActionResult lufthansa()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/qatar-airways.aspx/")]
        public ActionResult qatarairways()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/singapore-airlines.aspx/")]
        public ActionResult singaporeairlines()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/business-class/united.aspx/")]
        public ActionResult united()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
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