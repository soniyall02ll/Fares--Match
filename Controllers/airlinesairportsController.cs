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
    public class airlinesairportsController : Controller
    {
        // GET: airlinesairports
        public ActionResult Index()
        {
            return View();
        }


        [Route("~/airlines-airports/allegiant.aspx/")]
        public ActionResult allegiant()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airlines-airports/bos-airport.aspx/")]
        public ActionResult bosairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airlines-airports/copa.aspx/")]
        public ActionResult copa()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airlines-airports/delta.aspx/")]
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

        [Route("~/airlines-airports/denver-airport.aspx/")]
        public ActionResult denverairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airlines-airports/dfw-airport.aspx/")]
        public ActionResult dfwairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airlines-airports/fll-airport.aspx/")]
        public ActionResult fllairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airlines-airports/frankfurt-airport.aspx/")]
        public ActionResult frankfurtairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airlines-airports/frontier.aspx/")]
        public ActionResult frontier()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airlines-airports/jetblue.aspx/")]
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


        [Route("~/airlines-airports/jfk-airport.aspx/")]
        public ActionResult jfkairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airlines-airports/laguardia-airport.aspx/")]
        public ActionResult laguardiaairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airlines-airports/lax-airport.aspx/")]
        public ActionResult laxairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airlines-airports/mci-airport.aspx/")]
        public ActionResult mciairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airlines-airports/mia-airport.aspx/")]
        public ActionResult miaairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airlines-airports/newark-airport.aspx/")]
        public ActionResult newarkairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airlines-airports/ord-airport.aspx/")]
        public ActionResult ordairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airlines-airports/san-diego-airport.aspx/")]
        public ActionResult sandiegoairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airlines-airports/sea-airport.aspx/")]
        public ActionResult seaairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/airlines-airports/sfo-airport.aspx/")]
        public ActionResult sfoairport()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airlines-airports/singapore.aspx/")]
        public ActionResult singapore()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airlines-airports/southwest.aspx/")]
        public ActionResult southwest()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/airlines-airports/spirit.aspx/")]
        public ActionResult spirit()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
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