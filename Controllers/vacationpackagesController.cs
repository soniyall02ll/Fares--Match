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
    public class vacationpackagesController : Controller
    {
        // GET: vacationpackages
        public ActionResult Index()
        {
            return View();
        }



        [Route("~/vacation-packages/bahamas.aspx/")]
        public ActionResult bahamas()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/cancun.aspx/")]
        public ActionResult cancun()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/chicago-hotels.aspx/")]
        public ActionResult chicagohotels()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/disneyland.aspx/")]
        public ActionResult disneyland()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/europe.aspx/")]
        public ActionResult europe()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/florida.aspx/")]
        public ActionResult florida()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/hawaii.aspx/")]
        public ActionResult hawaii()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/italy.aspx/")]
        public ActionResult italy()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/keywest.aspx/")]
        public ActionResult keywest()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/las-vegas.aspx/")]
        public ActionResult lasvegas()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/london.aspx/")]
        public ActionResult london()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/los-angeles.aspx/")]
        public ActionResult losangeles()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/maui.aspx/")]
        public ActionResult maui()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/miami.aspx/")]
        public ActionResult miami()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/new-orleans.aspx/")]
        public ActionResult neworleans()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/new-york.aspx/")]
        public ActionResult newyork()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/north-america.aspx/")]
        public ActionResult northamerica()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/orlando.aspx/")]
        public ActionResult orlando()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/paris.aspx/")]
        public ActionResult paris()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/punta-cana.aspx/")]
        public ActionResult puntacana()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/united-states-of-america.aspx/")]
        public ActionResult unitedstatesofamerica()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/belize.aspx/")]
        public ActionResult belize()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/cabo-san-lucas.aspx/")]
        public ActionResult cabosanlucas()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/costa-rica.aspx/")]
        public ActionResult costarica()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/greece.aspx/")]
        public ActionResult greece()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/iceland.aspx/")]
        public ActionResult iceland()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/ireland.aspx/")]
        public ActionResult ireland()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/jamaica.aspx/")]
        public ActionResult jamaica()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/japan.aspx/")]
        public ActionResult japan()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/bora-bora.aspx/")]
        public ActionResult borabora()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/branson.aspx/")]
        public ActionResult branson()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/family.aspx/")]
        public ActionResult family()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/mexico.aspx/")]
        public ActionResult mexico()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/aruba.aspx/")]
        public ActionResult aruba()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/bermuda.aspx/")]
        public ActionResult bermuda()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/puerto-rico.aspx/")]
        public ActionResult puertorico()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/germany.aspx/")]
        public ActionResult germany()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/european.aspx/")]
        public ActionResult european()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/spain.aspx/")]
        public ActionResult spain()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/bali.aspx/")]
        public ActionResult bali()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/colorado.aspx/")]
        public ActionResult colorado()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/turks-and-caicos.aspx/")]
        public ActionResult turksandcaicos()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/australia.aspx/")]
        public ActionResult australia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/kauai.aspx/")]
        public ActionResult kauai()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/dominican-republic.aspx/")]
        public ActionResult dominicanrepublic()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/vacation-packages/machu-picchu.aspx/")]
        public ActionResult machupicchu()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/vacation-packages/portugal.aspx/")]
        public ActionResult portugal()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/montana.aspx/")]
        public ActionResult montana()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/dubai.aspx/")]
        public ActionResult dubai()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/St-thomas.aspx/")]
        public ActionResult Stthomas()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/rome.aspx/")]
        public ActionResult rome()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/maldives.aspx/")]
        public ActionResult maldives()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/morocco.aspx/")]
        public ActionResult morocco()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/vacation-packages/gatlinburg/")]
        public ActionResult gatlinburg()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/california/")]
        public ActionResult california()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/grand-canyon/")]
        public ActionResult grandcanyon()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/luxury/")]
        public ActionResult luxury()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/maine/")]
        public ActionResult maine()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/nashville/")]
        public ActionResult nashville()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/tahiti/")]
        public ActionResult tahiti()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/yellowstone/")]
        public ActionResult yellowstone()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/africa/")]
        public ActionResult africa()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/croatia/")]
        public ActionResult croatia()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/honolulu/")]
        public ActionResult honolulu()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/myrtle-beach/")]
        public ActionResult myrtlebeach()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/san-diego/")]
        public ActionResult sandiego()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/cairns/")]
        public ActionResult cairns()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }


        [Route("~/vacation-packages/puerto-vallarta/")]
        public ActionResult puertovallarta()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }




        [Route("~/vacation-packages/pigeon-forge/")]
        public ActionResult pigeonforge()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/canada/")]
        public ActionResult canada()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/vacation-packages/chicago/")]
        public ActionResult chicago()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/fiji/")]
        public ActionResult fiji()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/new-zealand/")]
        public ActionResult newzealand()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/peru/")]
        public ActionResult peru()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/scotland/")]
        public ActionResult scotland()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/sedona/")]
        public ActionResult sedona()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/caribbean/")]
        public ActionResult caribbean()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/ecuador/")]
        public ActionResult ecuador()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/honeymoon/")]
        public ActionResult honeymoon()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }



        [Route("~/vacation-packages/niagara-falls/")]
        public ActionResult niagarafalls()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/oahu/")]
        public ActionResult oahu()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/panama/")]
        public ActionResult panama()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/solo/")]
        public ActionResult solo()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/switzerland/")]
        public ActionResult switzerland()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/tulum/")]
        public ActionResult tulum()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/wyoming/")]
        public ActionResult wyoming()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/cozumel/")]
        public ActionResult cozumel()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/finland/")]
        public ActionResult finland()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
            ViewBag.fromName = fromName;
            ViewBag.fromCode = fromCode;
            ViewBag.toName = toName;
            ViewBag.toCode = toCode;
            ViewBag.depDate = depDate;
            ViewBag.retDate = retDate;
            Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), "VIMAN");

            return View();


        }

        [Route("~/vacation-packages/virgin-islands/")]
        public ActionResult virginislands()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            List<Trustpilot> Trustpilot = Common.GetTrustpilot();
            ViewBag.Trustpilot = Trustpilot;

            DataSet ds = SqlHelper.ExecuteDataset("SELECT COUNT(Id) as NumRows FROM Trustpilot WHERE SiteCode='FlyGlobe'");
            int countReview = 0;
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                DataRow dr = ds.Tables[0].Rows[0];
                countReview = int.Parse(dr["NumRows"].ToString());
            }
            ViewBag.TotalReview = 40 + countReview;

            string flightWay = "", fromName = "", fromCode = "", toName = "", toCode = "", depDate = "", retDate = "";
            if (Request.Cookies["FlightSearch"] != null)
            {
                flightWay = Request.Cookies["FlightSearch"]["FlightWay"];
                fromCode = Request.Cookies["FlightSearch"]["FromCode"];
                Airport fromAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["FromCode"]);
                fromName = fromAirport.Code + "-" + fromAirport.Name + ", " + fromAirport.CityName;
                toCode = Request.Cookies["FlightSearch"]["ToCode"];
                Airport toAirport = Common.GetAirport(Request.Cookies["FlightSearch"]["ToCode"]);
                toName = toAirport.Code + "-" + toAirport.Name + ", " + toAirport.CityName;
                depDate = Request.Cookies["FlightSearch"]["DepDate"];
                if (flightWay == "RoundTrip")
                    retDate = Request.Cookies["FlightSearch"]["RetDate"];
            }

            ViewBag.flightWay = flightWay;
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