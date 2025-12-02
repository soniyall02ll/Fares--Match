using Newtonsoft.Json;
using SqlData.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Viman.Models;
using System.IO;
using Newtonsoft.Json.Serialization;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using System.Web.Razor.Parser.SyntaxTree;
using System.Web.UI.WebControls;



namespace Viman.Controllers
{
    public class FlightController : Controller
    {
        string tranId = String.Empty;
        string guid = String.Empty;
        string searchId = String.Empty;
        string out_id = String.Empty;
        string in_id = String.Empty;


        // GET: Flight
        public ActionResult Index()
        {
            List<Airline> airlineList = Common.GetAllAirline();
            ViewBag.airlineList = airlineList;

            return View();
        }

        public ActionResult Search11111111111()
        {
            Session["BookingID"] = null;
            try
            {
                FlightsSearch flightSearch = new FlightsSearch();

                flightSearch.SearchId = Common.GetId();
                flightSearch.FlightWay = (FlightWay)Convert.ToByte(Request.QueryString.Get("FlightWay"));
                flightSearch.From = Common.GetAirport(Request.QueryString.Get("From"));
                flightSearch.To = Common.GetAirport(Request.QueryString.Get("To"));
                flightSearch.DepDate = Convert.ToDateTime(Request.QueryString.Get("DepDate"));
                if (flightSearch.FlightWay == FlightWay.RoundTrip)
                    flightSearch.RetDate = Convert.ToDateTime(Request.QueryString.Get("RetDate"));
                flightSearch.Adult = Convert.ToInt32(Request.QueryString.Get("Adult"));
                flightSearch.Child = Convert.ToInt32(Request.QueryString.Get("Child"));
                flightSearch.Infant = Convert.ToInt32(Request.QueryString.Get("Infant"));
                flightSearch.FlightClass = (FlightClass)Convert.ToByte(Request.QueryString.Get("FlightClass"));
                flightSearch.Airline = Common.GetAirline(Request.QueryString.Get("Airline"));
                flightSearch.IsDirect = Convert.ToBoolean(Request.QueryString.Get("IsDirect"));
                flightSearch.IsFlexi = Convert.ToBoolean(Request.QueryString.Get("IsFlexi"));
                flightSearch.Currency = Request.QueryString.Get("Currency");
                flightSearch.SiteCode = Request.QueryString.Get("SiteCode");
                flightSearch.SourceMedia = Request.QueryString.Get("SourceMedia");
                flightSearch.IsDeepLink = true;
                flightSearch.ApiKey = Common.ApiKey;

                Session["FlightsResult"] = Common.SearchFlight(flightSearch);
                return Redirect("/flight/result");
            }
            catch (Exception)
            {
                return Redirect("/");
            }
        }



        [Route("~/flight/search/")]
        //[Route("~/flight/deepLink/")]
        public ActionResult Search()
        {
            if (Request.QueryString["QS"] == null)
            {
                string URLStr = Request.RawUrl;
                string QsStr = URLStr.Split('?')[1];
                string[] QsArr = QsStr.Split('&');
                string SiteCode = QsArr[0].Split('=')[1];
                string SourceMedia = QsArr[1].Split('=')[1];
                string From = QsArr[2].Split('=')[1];
                string To = QsArr[3].Split('=')[1];
                string DepDate = QsArr[4].Split('=')[1];
                string RetDate = QsArr[5].Split('=')[1];
                string Adult = QsArr[6].Split('=')[1];
                string Child = QsArr[7].Split('=')[1];
                string Infant = QsArr[8].Split('=')[1];
                string FlightWays = QsArr[9].Split('=')[1];
                string FlightClass = QsArr[10].Split('=')[1];
                string Airline = QsArr[11].Split('=')[1];
                string IsDirect = QsArr[12].Split('=')[1];
                string IsFlexi = QsArr[13].Split('=')[1];
                string sref = Request.QueryString["Compare"];
                if (sref == "true")
                {
                    Session["com"] = "true";
                }

                else
                {
                    Session["com"] = null;
                }
                // string sref = QsArr[14].Split('=')[1];
                string Currency = "GBP";//QsArr[14].Split('=')[1];
                string QS = SiteCode + "|" + SourceMedia + "|" + From + "|" + To + "|" + DepDate + "|" + RetDate + "|" + Adult + "|" + Child + "|" + Infant + "|" + FlightWays + "|" + FlightClass + "|" + Airline + "|" + IsDirect + "|" + IsFlexi + "|" + Currency;
                string QSStr = Common.Encrypt(QS);
                string newurl = Common.StaticURL + URLStr.Split('?')[0].Substring(1, URLStr.Split('?')[0].Length - 1) + "?qs=" + QSStr;
                return Redirect(newurl);

            }
            else
            {
                string decrypturl = Common.Decrypt(Request.QueryString["qs"].ToString());
                string[] QSArr = decrypturl.Split('|');


                try
                {


                    FlightsSearch flightSearch = new FlightsSearch();

                    flightSearch.SearchId = Common.GetId();
                    flightSearch.FlightWay = (FlightWay)Convert.ToByte(QSArr[9]);
                    flightSearch.From = Common.GetAirport(QSArr[2]);
                    flightSearch.To = Common.GetAirport(QSArr[3]);
                    flightSearch.DepDate = Convert.ToDateTime(QSArr[4]);
                    if (flightSearch.FlightWay == FlightWay.RoundTrip)
                        flightSearch.RetDate = Convert.ToDateTime(QSArr[5]);
                    flightSearch.Adult = Convert.ToInt32(QSArr[6]);
                    flightSearch.Child = Convert.ToInt32(QSArr[7]);
                    flightSearch.Infant = Convert.ToInt32(QSArr[8]);
                    flightSearch.FlightClass = (FlightClass)Convert.ToByte(QSArr[10]);
                    flightSearch.Airline = Common.GetAirline(QSArr[11]);
                    flightSearch.IsDirect = Convert.ToBoolean(QSArr[12]);
                    flightSearch.IsFlexi = Convert.ToBoolean(QSArr[13]);
                    flightSearch.Currency = QSArr[14];
                    flightSearch.SiteCode = QSArr[0];
                    flightSearch.SourceMedia = QSArr[1];

                    Session["SourceMedia"] = flightSearch.SourceMedia;
                    //flightSearch.IsDeepLink = true;



                    if (flightSearch.SourceMedia == "VIMAN")
                    {
                        flightSearch.IsDeepLink = true;
                    }
                    else
                    {
                        flightSearch.IsDeepLink = false;
                    }



                    // flightSearch.ApiKey = Common.ApiKey;

                    //flightSearch.ApiKey = Common.GetApiKey(flightSearch.SourceMedia);
                    //------------------------------------------
                    try
                    {
                        FlightsResult flightsResult = Common.SearchFlight(flightSearch);
                        Session["FlightsResult"] = flightsResult;
                        // save cookie
                        Response.Cookies["FlightSearch"]["FlightWay"] = flightsResult.FlightsSearch.FlightWay.ToString();
                        Response.Cookies["FlightSearch"]["FromCode"] = flightsResult.FlightsSearch.From.Code;
                        Response.Cookies["FlightSearch"]["ToCode"] = flightsResult.FlightsSearch.To.Code;
                        Response.Cookies["FlightSearch"]["DepDate"] = flightsResult.FlightsSearch.DepDate.ToString("dd-MM-yyyy");
                        Response.Cookies["FlightSearch"]["RetDate"] = "";
                        if (flightsResult.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                            Response.Cookies["FlightSearch"]["RetDate"] = flightsResult.FlightsSearch.RetDate.ToString("dd-MM-yyyy");
                        Response.Cookies["FlightSearch"].Expires = DateTime.Now.AddDays(1d);

                        List<Airline> airlineList = Common.GetAllAirline();
                        ViewBag.airlineList = airlineList;

                        ViewBag.flightWay = flightsResult.FlightsSearch.FlightWay.ToString();
                        ViewBag.fromName = flightsResult.FlightsSearch.From.Code + "-" + flightsResult.FlightsSearch.From.Name + ", " + flightsResult.FlightsSearch.From.CityName;
                        ViewBag.toName = flightsResult.FlightsSearch.To.Code + "-" + flightsResult.FlightsSearch.To.Name + ", " + flightsResult.FlightsSearch.To.CityName;
                        ViewBag.depDate = flightsResult.FlightsSearch.DepDate.ToString("dd-MM-yyyy");
                        ViewBag.retDate = "";
                        if (flightsResult.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                            ViewBag.retDate = flightsResult.FlightsSearch.RetDate.ToString("dd-MM-yyyy");
                        ViewBag.adult = flightsResult.FlightsSearch.Adult + "";
                        ViewBag.child = flightsResult.FlightsSearch.Child + "";
                        ViewBag.infant = flightsResult.FlightsSearch.Infant + "";
                        ViewBag.flightClass = flightsResult.FlightsSearch.FlightClass.ToString();

                        if (ViewBag.flightClass == "Economy")
                        {
                            ViewBag.fltClass = "4";
                        }
                        if (ViewBag.flightClass == "Premimum Economy")
                        {
                            ViewBag.fltClass = "3";
                        }
                        if (ViewBag.flightClass == "Business")
                        {
                            ViewBag.fltClass = "2";
                        }
                        if (ViewBag.flightClass == "First")
                        {
                            ViewBag.fltClass = "1";
                        }


                        ViewBag.airline = flightsResult.FlightsSearch.Airline.Code;
                        ViewBag.isDirect = (flightsResult.FlightsSearch.IsDirect) ? "1" : "0";
                        ViewBag.isFlexi = (flightsResult.FlightsSearch.IsFlexi) ? "1" : "0";

                        //try
                        //{

                        //    Common.SaveTrackSearch(flightSearch);

                        //}
                        //catch (Exception ex)
                        //{


                        //}
                        Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), flightsResult.FlightsSearch.SourceMedia);//Common.GetPhone("DEEPLINK", SiteCode.VIMAN.ToString(), flightsResult.FlightsSearch.SourceMedia);
                        if (flightsResult.FlightsList != null && flightsResult.FlightsList.Count > 0)
                        {
                            ViewBag.msg = "success";

                            // Session["SitePhone"] = Common.GetPhone("DEEPLINK", SiteCode.VIMAN.ToString(), flightsResult.FlightsSearch.SourceMedia);

                            FlightsResult newFlightsResult = Common.FillFlightPrice(flightsResult);
                            ViewBag.FilterData = JsonConvert.SerializeObject(Common.FilterFlight(newFlightsResult));
                            //ViewBag.newFlightsResult = JsonConvert.SerializeObject(newFlightsResult);


                            if (Session["com"] != null && Session["com"] != "")
                            {
                                string aa = Session["com"].ToString();
                                ViewBag.cc = "10";

                                if (aa == "true")
                                {
                                    newFlightsResult.MaxPrice = ((newFlightsResult.MaxPrice) - 10);
                                    newFlightsResult.MinPrice = ((newFlightsResult.MinPrice) - 10);

                                    for (int i = 0; i < newFlightsResult.AirlineExtra.Count; i++)
                                    {
                                        newFlightsResult.AirlineExtra[i].TotalCost = ((newFlightsResult.AirlineExtra[i].TotalCost) - 10);
                                    }

                                    for (int i = 0; i < newFlightsResult.BarExtra.Count; i++)
                                    {
                                        newFlightsResult.BarExtra[i].TotalCost = ((newFlightsResult.BarExtra[i].TotalCost) - 10);

                                    }


                                    for (int i = 0; i < newFlightsResult.FlightsList.Count; i++)
                                    {
                                        newFlightsResult.FlightsList[i].TotalCost = ((newFlightsResult.FlightsList[i].TotalCost) - 10);

                                    }
                                }
                            }

                            return View("result", newFlightsResult);
                        }
                        else
                        {
                            ViewBag.msg = "noresult";
                            return View("result", flightsResult);
                        }

                    }
                    catch (Exception e)
                    {
                        return Redirect("/");
                    }

                    //------------------------------------
                }
                catch (Exception e)
                {
                    return Redirect("/");
                }
            }



        }




        [Route("~/flight/deepLink/")]
        public ActionResult SearchKayak()
        {
            DeleteFiles(Server);
            if (Request.QueryString["QS"] == null)
            {
                string URLStr = Request.RawUrl;
                string QsStr = URLStr.Split('?')[1];
                string[] QsArr = QsStr.Split('&');
                string SiteCode = QsArr[0].Split('=')[1];
                string SourceMedia = "FARECOMPARE";//QsArr[1].Split('=')[1];
                string From = QsArr[2].Split('=')[1];
                string To = QsArr[3].Split('=')[1];
                string DepDate = QsArr[4].Split('=')[1];
                string RetDate = QsArr[5].Split('=')[1];
                string Adult = QsArr[6].Split('=')[1];
                string Child = QsArr[7].Split('=')[1];
                string Infant = QsArr[8].Split('=')[1];


                string FlightWays = QsArr[9].Split('=')[1];
                string FlightClass = QsArr[10].Split('=')[1];

                string Airline = QsArr[11].Split('=')[1];
                string IsDirect = QsArr[12].Split('=')[1];

                string IsFlexi = QsArr[13].Split('=')[1];
                // string sref = QsArr[14].Split('=')[1];
                string Currency = "GBP";//QsArr[14].Split('=')[1];


                Session["kayakclickid"] = Request.QueryString.Get("kayakclickid");

                Session["kayakclickid"] = "232d223";


                string QS = SiteCode + "|" + SourceMedia + "|" + From + "|" + To + "|" + DepDate + "|" + RetDate + "|" + Adult + "|" + Child + "|" + Infant + "|" + FlightWays + "|" + FlightClass + "|" + Airline + "|" + IsDirect + "|" + IsFlexi + "|" + Currency;
                string QSStr = Common.Encrypt(QS);
                string newurl = Common.StaticURL + URLStr.Split('?')[0].Substring(1, URLStr.Split('?')[0].Length - 1) + "?qs=" + QSStr;
                return Redirect(newurl);

            }
            else
            {
                string decrypturl = Common.Decrypt(Request.QueryString["qs"].ToString());
                string[] QSArr = decrypturl.Split('|');
                try
                {
                    FlightsSearch flightSearch = new FlightsSearch();
                    flightSearch.SearchId = Common.GetId();
                    flightSearch.FlightWay = (FlightWay)Convert.ToByte(QSArr[9]);
                    flightSearch.From = Common.GetAirport(QSArr[2]);
                    flightSearch.To = Common.GetAirport(QSArr[3]);
                    flightSearch.DepDate = Convert.ToDateTime(QSArr[4]);
                    if (flightSearch.FlightWay == FlightWay.RoundTrip)
                        flightSearch.RetDate = Convert.ToDateTime(QSArr[5]);
                    flightSearch.Adult = Convert.ToInt32(QSArr[6]);
                    flightSearch.Child = Convert.ToInt32(QSArr[7]);
                    flightSearch.Infant = Convert.ToInt32(QSArr[8]);
                    flightSearch.FlightClass = (FlightClass)Convert.ToByte(QSArr[10]);
                    flightSearch.Airline = Common.GetAirline(QSArr[11]);
                    flightSearch.IsDirect = Convert.ToBoolean(QSArr[12]);
                    flightSearch.IsFlexi = Convert.ToBoolean(QSArr[13]);
                    flightSearch.Currency = QSArr[14];
                    flightSearch.SiteCode = QSArr[0];
                    flightSearch.SourceMedia = "FARECOMPARE";//QSArr[1];

                    Session["SourceMedia"] = flightSearch.SourceMedia;
                    //flightSearch.IsDeepLink = true;



                    if (flightSearch.SourceMedia == "VIMAN")
                    {
                        flightSearch.IsDeepLink = true;
                    }
                    else
                    {
                        flightSearch.IsDeepLink = false;
                    }



                    // flightSearch.ApiKey = Common.ApiKey;

                    //flightSearch.ApiKey = Common.GetApiKey(flightSearch.SourceMedia);
                    //------------------------------------------
                    try
                    {
                        FlightsResult flightsResult = Common.SearchFlight(flightSearch);

                        System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Content\File\" + "Responce" + flightSearch.SearchId + ".json", JsonConvert.SerializeObject(flightsResult));

                        Session["FlightsResult"] = flightsResult;
                        // save cookie
                        Response.Cookies["FlightSearch"]["FlightWay"] = flightsResult.FlightsSearch.FlightWay.ToString();
                        Response.Cookies["FlightSearch"]["FromCode"] = flightsResult.FlightsSearch.From.Code;
                        Response.Cookies["FlightSearch"]["ToCode"] = flightsResult.FlightsSearch.To.Code;
                        Response.Cookies["FlightSearch"]["DepDate"] = flightsResult.FlightsSearch.DepDate.ToString("dd-MM-yyyy");
                        Response.Cookies["FlightSearch"]["RetDate"] = "";
                        if (flightsResult.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                            Response.Cookies["FlightSearch"]["RetDate"] = flightsResult.FlightsSearch.RetDate.ToString("dd-MM-yyyy");
                        Response.Cookies["FlightSearch"].Expires = DateTime.Now.AddDays(1d);

                        List<Airline> airlineList = Common.GetAllAirline();
                        ViewBag.airlineList = airlineList;

                        ViewBag.flightWay = flightsResult.FlightsSearch.FlightWay.ToString();
                        ViewBag.fromName = flightsResult.FlightsSearch.From.Code + "-" + flightsResult.FlightsSearch.From.Name + ", " + flightsResult.FlightsSearch.From.CityName;
                        ViewBag.toName = flightsResult.FlightsSearch.To.Code + "-" + flightsResult.FlightsSearch.To.Name + ", " + flightsResult.FlightsSearch.To.CityName;
                        ViewBag.depDate = flightsResult.FlightsSearch.DepDate.ToString("dd-MM-yyyy");
                        ViewBag.retDate = "";
                        if (flightsResult.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                            ViewBag.retDate = flightsResult.FlightsSearch.RetDate.ToString("dd-MM-yyyy");
                        ViewBag.adult = flightsResult.FlightsSearch.Adult + "";
                        ViewBag.child = flightsResult.FlightsSearch.Child + "";
                        ViewBag.infant = flightsResult.FlightsSearch.Infant + "";
                        ViewBag.flightClass = flightsResult.FlightsSearch.FlightClass.ToString();
                        ViewBag.airline = flightsResult.FlightsSearch.Airline.Code;
                        ViewBag.isDirect = (flightsResult.FlightsSearch.IsDirect) ? "1" : "0";
                        ViewBag.isFlexi = (flightsResult.FlightsSearch.IsFlexi) ? "1" : "0";

                        if (flightsResult.FlightsSearch.SourceMedia == "FARECOMPARE")
                        {
                            string ReturnDate = "";

                            if (flightsResult.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                            {
                                ReturnDate = flightsResult.FlightsSearch.RetDate.ToString("dd/MM/yyyy");
                            }

                            string sqlqq = "INSERT INTO ClickDetails(Class,MarkupType,AdultFare,AdultTax,ChildFare,ChildTax,InfantFare,InfantTax,Airline,FromAirport,ToAirport,DepartureDate,ReturnDate,IP,Jetcost,Date) VALUES('" + flightsResult.FlightsSearch.FlightClass + "',''," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + "," + 0 + ",'','" + flightsResult.FlightsSearch.From.Code + "','" + flightsResult.FlightsSearch.To.Code + "','" + flightsResult.FlightsSearch.DepDate.ToString("dd/MM/yyyy") + "','" + ReturnDate + "','" + Common.GetLocalIP() + "','cheapflights',GETDATE())";
                            int ckk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionString, CommandType.Text, sqlqq);
                        }

                        //try
                        //{

                        //    Common.SaveTrackSearch(flightSearch);

                        //}
                        //catch (Exception ex)
                        //{


                        //}
                        Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), flightsResult.FlightsSearch.SourceMedia);//Common.GetPhone("DEEPLINK", SiteCode.VIMAN.ToString(), flightsResult.FlightsSearch.SourceMedia);
                        if (flightsResult.FlightsList != null && flightsResult.FlightsList.Count > 0)
                        {
                            ViewBag.msg = "success";

                            // Session["SitePhone"] = Common.GetPhone("DEEPLINK", SiteCode.VIMAN.ToString(), flightsResult.FlightsSearch.SourceMedia);

                            FlightsResult newFlightsResult = Common.FillFlightPrice(flightsResult);
                            ViewBag.FilterData = JsonConvert.SerializeObject(Common.FilterFlight(newFlightsResult));
                            //ViewBag.newFlightsResult = JsonConvert.SerializeObject(newFlightsResult);

                            return View("resultK", newFlightsResult);
                        }
                        else
                        {
                            ViewBag.msg = "noresult";
                            return View("resultK", flightsResult);
                        }

                    }
                    catch (Exception e)
                    {
                        return Redirect("/");
                    }

                    //------------------------------------
                }
                catch (Exception e)
                {
                    return Redirect("/");
                }
            }
        }


        [HttpGet]
        public ActionResult Itinerary()
        {
            // sample metasearch redirect format
            // flight/itinerary/?SourceMedia=DEALCHECKER&From=LON&To=SYD&DepDate=2018-04-26&RetDate=2018-05-15&Adult=1&Child=0&Infant=0&FlightWay=RoundTrip&FlightClass=Economy&Airline=&IsDirect=false&IsFlexi=false&Currency=GBP&TranId=s1v654sdf198r84g5t9821sg64r
            try
            {
                string searchId = Request.QueryString.Get("SearchId");
                string tranId = Request.QueryString.Get("TranId");

                FlightsResult flightsResult = Common.GetItineraryFlight(searchId);
                Flights bookFlight = new Flights();
                Session["FlightsResult"] = flightsResult;

                bookFlight = flightsResult.FlightsList.Where(f => f.FlightId.Equals(tranId)).FirstOrDefault();

                FlightsBooking flightsBooking = new FlightsBooking();
                flightsBooking.SearchId = flightsResult.FlightsSearch.SearchId;
                flightsBooking.BookingId = Common.GetBookingId("TFG");
                flightsBooking.Flights = bookFlight;
                flightsBooking.FlightsSearch = flightsResult.FlightsSearch;
                flightsBooking.SiteCode = SiteCode.VIMAN.ToString();
                flightsBooking.SourceMedia = flightsResult.FlightsSearch.SourceMedia;
                flightsBooking.TranscationStatus = "new";

                flightsResult.FlightsSearch.IsDeepLink = false;
                if (flightsBooking.SourceMedia == "TRAVOLIC")
                {
                    Session["redirectID"] = Request.QueryString.Get("redirectID");
                }


                // Common.SaveClick("metasearch", flightsResult.FlightsSearch.SourceMedia, Request.Url.AbsoluteUri, flightsResult.FlightsSearch);

                //try
                //{

                //    Common.SaveTrackSearch(flightsBooking.FlightsSearch);

                //}
                //catch (Exception ex)
                //{


                //}

                //flightsBooking = Common.CheckFare(flightsBooking);
                flightsBooking = Common.CheckFareMAN(flightsBooking);
                // Session["SitePhone"] = Common.GetPhone("metasearch", SiteCode.VIMAN.ToString(), flightsResult.FlightsSearch.SourceMedia);
                Session["SitePhone"] = Common.GetPhone("META", SiteCode.VIMAN.ToString(), flightsResult.FlightsSearch.SourceMedia);
                Session["FlightsBook"] = flightsBooking;

                return Redirect("/flight/booking");
            }
            catch (Exception ex)
            {
                return Redirect("/");
            }
        }

        [HttpGet]
        public ActionResult Enquiry()
        {
            try
            {
                if (Session["FlightsResult"] != null)
                {
                    FlightsResult flightsResult = Session["FlightsResult"] as FlightsResult;

                    if (flightsResult.FlightsList != null && flightsResult.FlightsList.Count > 0)
                    {
                        Flights bookFlight = new Flights();

                        // find flight from session
                        if (Request.QueryString.Get("flightId") != null)
                        {
                            string flight_id = Request.QueryString.Get("flightId");
                            string out_id = Request.QueryString.Get("outId");
                            string in_id = Request.QueryString.Get("inId");

                            if (flightsResult.FlightsSearch.FlightWay == FlightWay.OneWay)
                                bookFlight = flightsResult.FlightsList.Where(f => f.Outbound[0].SagementRef.Equals(out_id)).FirstOrDefault();
                            else
                                bookFlight = flightsResult.FlightsList.Where(f => f.Outbound[0].SagementRef.Equals(out_id) && f.Inbound[0].SagementRef.Equals(in_id)).FirstOrDefault();
                        }

                        if (bookFlight != null && bookFlight.Outbound.Count > 0)
                        {
                            FlightsBooking flightsBooking = new FlightsBooking();
                            flightsBooking.SearchId = flightsResult.FlightsSearch.SearchId;
                            flightsBooking.BookingId = Common.GetEnquiryId("VME");
                            flightsBooking.Flights = bookFlight;
                            flightsBooking.FlightsSearch = flightsResult.FlightsSearch;
                            flightsBooking.SiteCode = SiteCode.VIMAN.ToString();
                            flightsBooking.SourceMedia = flightsResult.FlightsSearch.SourceMedia;
                            flightsBooking.TranscationStatus = "new";
                            flightsBooking.FlightsFare = bookFlight.FlightFare;

                            Session["FlightsBook"] = flightsBooking;

                            return View(flightsBooking);
                        }
                        else
                        {
                            return Redirect("/flight/result");
                        }
                    }
                    else
                    {
                        return Redirect("/");
                    }
                }
                else
                {
                    return Redirect("/");
                }
            }
            catch (Exception)
            {
                return Redirect("/");
            }
        }

        [HttpPost]
        public string SendEnquiry(FormCollection FormColl)
        {
            try
            {
                if (Session["FlightsBook"] != null)
                {
                    FlightsBooking bookFlights = Session["FlightsBook"] as FlightsBooking;

                    if (bookFlights != null)
                    {
                        // save data into DB
                        string en_name = FormColl["en_name"];
                        string en_email = FormColl["en_email"];
                        string en_phone = FormColl["en_phone"];
                        string en_message = FormColl["en_message"];

                        SqlParameter[] commandParameters2 = new SqlParameter[12];
                        commandParameters2[0] = new SqlParameter("@refno", SqlDbType.VarChar, 50) { Value = bookFlights.BookingId };
                        commandParameters2[1] = new SqlParameter("@name", SqlDbType.VarChar, 50) { Value = en_name };
                        commandParameters2[2] = new SqlParameter("@email", SqlDbType.VarChar, 50) { Value = en_email };
                        commandParameters2[3] = new SqlParameter("@phone", SqlDbType.VarChar, 50) { Value = en_phone };
                        commandParameters2[4] = new SqlParameter("@message", SqlDbType.VarChar) { Value = en_message };
                        commandParameters2[5] = new SqlParameter("@flightresult", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights) };
                        commandParameters2[6] = new SqlParameter("@ip", SqlDbType.VarChar, 50) { Value = Common.GetLocalIP() };
                        commandParameters2[7] = new SqlParameter("@status", SqlDbType.VarChar, 50) { Value = "new" };
                        commandParameters2[8] = new SqlParameter("@timestamp", SqlDbType.DateTime) { Value = DateTime.Now };

                        DataSet ds2 = SqlHelper.ExecuteDataset("INSERT INTO FlightsEnquiry(RefNo,Name,Email,Phone,Message,FlightResult,Ip,Status,Timestamp) VALUES(@refno,@name,@email,@phone,@message,@flightresult,@ip,@status,@timestamp) SELECT SCOPE_IDENTITY()", commandParameters2);

                        // insert booking data
                        bookFlights.TranscationId = Common.GetId();
                        bookFlights.BookingId = Common.GetBookingId("VMB");
                        bookFlights.FullName = en_name;
                        bookFlights.Email = en_email;
                        bookFlights.PhoneNo = en_phone;
                        bookFlights.IsHotel = "0";
                        bookFlights.PassengerDetail = new List<PassengerDetail>();
                        bookFlights.BookerDetail = new BookerDetail();

                        SqlParameter[] commandParameters = new SqlParameter[26];
                        commandParameters[0] = new SqlParameter("@bookingid", SqlDbType.VarChar, 50) { Value = bookFlights.BookingId };
                        commandParameters[1] = new SqlParameter("@searchid", SqlDbType.VarChar, 50) { Value = bookFlights.SearchId };
                        commandParameters[2] = new SqlParameter("@transcationid", SqlDbType.VarChar, 50) { Value = bookFlights.TranscationId };
                        commandParameters[3] = new SqlParameter("@pnrno", SqlDbType.VarChar, 50) { Value = bookFlights.PNRNo };
                        commandParameters[4] = new SqlParameter("@fullname", SqlDbType.VarChar, 50) { Value = bookFlights.FullName };
                        commandParameters[5] = new SqlParameter("@email", SqlDbType.VarChar, 50) { Value = bookFlights.Email };
                        commandParameters[6] = new SqlParameter("@phoneno", SqlDbType.VarChar, 50) { Value = bookFlights.PhoneNo };
                        commandParameters[7] = new SqlParameter("@flightssearch", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.FlightsSearch) };
                        commandParameters[8] = new SqlParameter("@flights", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.Flights) };
                        commandParameters[9] = new SqlParameter("@bookerdetail", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.BookerDetail) };
                        commandParameters[10] = new SqlParameter("@passengerdetail", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.PassengerDetail) };
                        commandParameters[11] = new SqlParameter("@paymentdetail", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.PaymentDetail) };
                        commandParameters[12] = new SqlParameter("@sagepaydetail", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.SagepayDetail) };
                        commandParameters[13] = new SqlParameter("@sitecode", SqlDbType.VarChar, 50) { Value = bookFlights.SiteCode };
                        commandParameters[14] = new SqlParameter("@sourcemedia", SqlDbType.VarChar, 50) { Value = bookFlights.SourceMedia };
                        commandParameters[15] = new SqlParameter("@flightsfare", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.FlightsFare) };
                        commandParameters[16] = new SqlParameter("@paymentstatus", SqlDbType.VarChar, 50) { Value = "unpaid" };
                        commandParameters[17] = new SqlParameter("@worldresponse", SqlDbType.VarChar) { Value = bookFlights.WorldResponse };
                        commandParameters[18] = new SqlParameter("@ishotel", SqlDbType.Int) { Value = int.Parse(bookFlights.IsHotel) };
                        commandParameters[19] = new SqlParameter("@ip", SqlDbType.VarChar, 50) { Value = Common.GetLocalIP() };
                        commandParameters[20] = new SqlParameter("@status", SqlDbType.VarChar, 50) { Value = "enquiry" };
                        commandParameters[21] = new SqlParameter("@timestamp", SqlDbType.DateTime) { Value = DateTime.Now };

                        DataSet ds = SqlHelper.ExecuteDataset("INSERT INTO FlightsBooking(BookingId,SearchId,TranscationId,PNRNo,FullName,Email,PhoneNo,FlightsSearch,Flights,BookerDetail,PassengerDetail,PaymentDetail,SagepayDetail,SiteCode,SourceMedia,FlightsFare,PaymentStatus,WorldResponse,IsHotel,Ip,Status,Timestamp) VALUES(@bookingid,@searchid,@transcationid,@pnrno,@fullname,@email,@phoneno,@flightssearch,@flights,@bookerdetail,@passengerdetail,@paymentdetail,@sagepaydetail,@sitecode,@sourcemedia,@flightsfare,@paymentstatus,@worldresponse,@ishotel,@ip,@status,@timestamp) SELECT SCOPE_IDENTITY()", commandParameters);


                        // send email
                        //EmailClass objEmailClass = new EmailClass();
                        //objEmailClass.MailTo = en_email;
                        //objEmailClass.MailCC = Common.WebsiteCC;
                        //StringBuilder sbMaiBody = new StringBuilder();
                        //sbMaiBody.Append("Dear " + en_name + ",<br/><br/>Thank you for your enquiry with viman.co.uk. Please find your details as below, one of our agents will contact you soon regarding the same.<br/><br/>");
                        //sbMaiBody.Append("<b>Quote Reference :</b> #" + bookFlights.BookingId + "<br/>");
                        //sbMaiBody.Append("<b>Name :</b> " + en_name + "<br/>");
                        //sbMaiBody.Append("<b>Email :</b> " + en_email + "<br/>");
                        //sbMaiBody.Append("<b>Phone :</b> " + en_phone + "<br/>");
                        //sbMaiBody.Append("<b>Message :</b> " + en_message + "<br/><br/>Many Thanks & Regards,<br/><br/>Viman <br/>Website: www.viman.co.uk <br/>Tel.: 0203 745 4455 <br/>");

                        //objEmailClass.SendCommonEmail("New flight enquiry detail Ref:#" + bookFlights.BookingId, sbMaiBody.ToString());

                        return "success";
                    }
                    else
                    {
                        return "error";
                    }
                }
                else
                {
                    return "error";
                }
            }
            catch (Exception)
            {
                return "error";
            }
        }

        public ActionResult Result()
        {
            Session["BookingID"] = null;

            try
            {
                if (Session["FlightsResult"] != null)
                {
                    FlightsResult flightsResult = Session["FlightsResult"] as FlightsResult;

                    // save cookie
                    Response.Cookies["FlightSearch"]["FlightWay"] = flightsResult.FlightsSearch.FlightWay.ToString();
                    Response.Cookies["FlightSearch"]["FromCode"] = flightsResult.FlightsSearch.From.Code;
                    Response.Cookies["FlightSearch"]["ToCode"] = flightsResult.FlightsSearch.To.Code;
                    Response.Cookies["FlightSearch"]["DepDate"] = flightsResult.FlightsSearch.DepDate.ToString("dd-MM-yyyy");
                    Response.Cookies["FlightSearch"]["RetDate"] = "";
                    if (flightsResult.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                        Response.Cookies["FlightSearch"]["RetDate"] = flightsResult.FlightsSearch.RetDate.ToString("dd-MM-yyyy");
                    Response.Cookies["FlightSearch"].Expires = DateTime.Now.AddDays(1d);

                    List<Airline> airlineList = Common.GetAllAirline();
                    ViewBag.airlineList = airlineList;

                    ViewBag.flightWay = flightsResult.FlightsSearch.FlightWay.ToString();
                    ViewBag.fromName = flightsResult.FlightsSearch.From.Code + "-" + flightsResult.FlightsSearch.From.Name + ", " + flightsResult.FlightsSearch.From.CityName;
                    ViewBag.toName = flightsResult.FlightsSearch.To.Code + "-" + flightsResult.FlightsSearch.To.Name + ", " + flightsResult.FlightsSearch.To.CityName;
                    ViewBag.depDate = flightsResult.FlightsSearch.DepDate.ToString("dd-MM-yyyy");
                    ViewBag.retDate = "";
                    if (flightsResult.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                        ViewBag.retDate = flightsResult.FlightsSearch.RetDate.ToString("dd-MM-yyyy");
                    ViewBag.adult = flightsResult.FlightsSearch.Adult + "";
                    ViewBag.child = flightsResult.FlightsSearch.Child + "";
                    ViewBag.infant = flightsResult.FlightsSearch.Infant + "";
                    ViewBag.flightClass = flightsResult.FlightsSearch.FlightClass.ToString();
                    ViewBag.airline = flightsResult.FlightsSearch.Airline.Code;
                    ViewBag.isDirect = (flightsResult.FlightsSearch.IsDirect) ? "1" : "0";
                    ViewBag.isFlexi = (flightsResult.FlightsSearch.IsFlexi) ? "1" : "0";

                    if (flightsResult.FlightsList != null && flightsResult.FlightsList.Count > 0)
                    {
                        ViewBag.msg = "success";
                        FlightsResult newFlightsResult = Common.FillFlightPrice(flightsResult);
                        ViewBag.FilterData = JsonConvert.SerializeObject(Common.FilterFlight(newFlightsResult));
                        //ViewBag.newFlightsResult = JsonConvert.SerializeObject(newFlightsResult);
                        return View(newFlightsResult);
                    }
                    else
                    {
                        ViewBag.msg = "noresult";
                        return View(flightsResult);
                    }
                }
                else
                {
                    return Redirect("/");
                }
            }
            catch (Exception)
            {
                return Redirect("/");
            }
        }

        [HttpGet]
        public ActionResult PreBooking()
        {
            try
            {
                if (Session["FlightsResult"] != null)
                {
                    FlightsResult flightsResult = Session["FlightsResult"] as FlightsResult;

                    if (flightsResult.FlightsList != null && flightsResult.FlightsList.Count > 0)
                    {
                        Flights bookFlight = new Flights();

                        // find flight from session
                        if (Request.QueryString.Get("searchId") != null)
                        {
                            string search_id = Request.QueryString.Get("searchId");
                            string tran_id = Request.QueryString.Get("tranId");

                            bookFlight = flightsResult.FlightsList.Where(f => f.FlightId.Equals(tran_id)).FirstOrDefault();
                        }
                        else if (Request.QueryString.Get("flightId") != null)
                        {
                            string flight_id = Request.QueryString["flightId"].ToString();
                            string out_id = Request.QueryString["outId"].ToString();
                            string in_id = Request.QueryString["inId"].ToString();

                            if (flightsResult.FlightsSearch.FlightWay == FlightWay.OneWay)
                                bookFlight = flightsResult.FlightsList.Where(f => f.Outbound[0].SagementRef.Equals(out_id) && f.IsDeal == false).FirstOrDefault();
                            else
                                bookFlight = flightsResult.FlightsList.Where(f => f.Outbound[0].SagementRef.Equals(out_id) && f.Inbound[0].SagementRef.Equals(in_id) && f.IsDeal == false).FirstOrDefault();
                        }

                        // redirect booking page
                        if (bookFlight != null && bookFlight.Outbound.Count > 0)
                        {
                            FlightsBooking flightsBooking = new FlightsBooking();
                            flightsBooking.SearchId = flightsResult.FlightsSearch.SearchId;
                            flightsBooking.BookingId = Common.GetBookingId("VMB");
                            flightsBooking.Flights = bookFlight;
                            flightsBooking.FlightsSearch = flightsResult.FlightsSearch;
                            flightsBooking.SiteCode = SiteCode.VIMAN.ToString();
                            flightsBooking.SourceMedia = flightsResult.FlightsSearch.SourceMedia;
                            flightsBooking.TranscationStatus = "new";

                            //flightsBooking = Common.CheckFare(flightsBooking);
                            flightsBooking = Common.CheckFareMAN(flightsBooking);



                            if (!flightsBooking.TranscationStatus.Equals("error"))
                            {
                                ViewBag.flightSearch = flightsResult.FlightsSearch;
                                Session["FlightsBook"] = flightsBooking;

                                return Redirect("/flight/booking");
                            }
                            else
                            {
                                return Redirect("/flight/result");
                            }
                        }
                        else
                        {
                            return Redirect("/flight/result");
                        }
                    }
                    else
                    {
                        return Redirect("/");
                    }
                }
                else
                {
                    return Redirect("/");
                }
            }
            catch (Exception)
            {
                return Redirect("/");
            }
        }

        public ActionResult Booking()
        {
            try
            {
                if (Session["FlightsBook"] != null)
                {
                    string ass = Session["FlightsBook"].ToString();
                    FlightsBooking bookFlights = Session["FlightsBook"] as FlightsBooking;

                    if (bookFlights != null)
                    {

                        ViewBag.flightWay = bookFlights.FlightsSearch.FlightWay.ToString();
                        ViewBag.fromName = bookFlights.FlightsSearch.From.Code + "-" + bookFlights.FlightsSearch.From.Name + ", " + bookFlights.FlightsSearch.From.CityName;
                        ViewBag.toName = bookFlights.FlightsSearch.To.Code + "-" + bookFlights.FlightsSearch.To.Name + ", " + bookFlights.FlightsSearch.To.CityName;
                        ViewBag.depDate = bookFlights.FlightsSearch.DepDate.ToString("MM-dd-yyyy");
                        ViewBag.retDate = "";
                        if (bookFlights.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                            ViewBag.retDate = bookFlights.FlightsSearch.RetDate.ToString("MM-dd-yyyy");
                        ViewBag.adult = bookFlights.FlightsSearch.Adult + "";
                        ViewBag.child = bookFlights.FlightsSearch.Child + "";
                        ViewBag.infant = bookFlights.FlightsSearch.Infant + "";
                        ViewBag.flightClass = bookFlights.FlightsSearch.FlightClass.ToString();
                        ViewBag.airline = bookFlights.FlightsSearch.Airline.Code;
                        ViewBag.isDirect = (bookFlights.FlightsSearch.IsDirect) ? "1" : "0";
                        ViewBag.isFlexi = (bookFlights.FlightsSearch.IsFlexi) ? "1" : "0";

                        ViewBag.countryList = Common.GetAllCountry();
                        //ViewBag.stateList = Common.GetUSState();

                        ViewBag.flightSearch = bookFlights.FlightsSearch;
                        ViewBag.flights = bookFlights.Flights;
                        ViewBag.SagepayLive = Common.GetSetting("sagepay-live");
                        ViewBag.JetcostSagepay = Common.GetSetting("jetcost-sagepay");
                        ViewBag.Deeplink = bookFlights.Flights.DeepLink;
                        ViewBag.IsDeepLink = bookFlights.FlightsSearch.IsDeepLink;
                        //bookFlights.FlightsFare.GrandTotal = (bookFlights.FlightsFare.AdultFare + bookFlights.FlightsFare.AdultTax) + (bookFlights.FlightsFare.ChildFare + bookFlights.FlightsFare.ChildTax) + (bookFlights.FlightsFare.Infant + bookFlights.FlightsFare.InfantTax);

                        string ipadd = Common.GetLocalIP();
                        //string Sqlquery = "SELECT Timestamp FROM FlightsBooking where ip = '" + ipadd + "' and (Deeplink LIKE '%From=" + bookFlights.FlightsSearch.From.Code.ToUpper() + "%' AND  Deeplink LIKE '%To=" + bookFlights.FlightsSearch.To.Code.ToUpper() + "%' AND  Deeplink LIKE  '%DepDate=" + bookFlights.FlightsSearch.DepDate.ToString("yyyy-MM-dd") + "%' AND Deeplink LIKE '%RetDate=" + bookFlights.FlightsSearch.RetDate.ToString("yyyy-MM-dd") + "%')  and  [Timestamp]>GETDATE()-2";
                        string Sqlquery = "SELECT Timestamp FROM FlightsBooking where ip = '" + ipadd + "' and FromCity='" + bookFlights.FlightsSearch.From.CityCode + "'  and  ToCity='" + bookFlights.FlightsSearch.To.CityCode + "' and  DepDate= '" + bookFlights.FlightsSearch.DepDate.ToString("yyyy-MM-dd") + "' AND  RetDate= '" + bookFlights.FlightsSearch.RetDate.ToString("yyyy-MM-dd") + "'  and  [Timestamp]>GETDATE()-2";
                        //DataTable dt = SqlHelperData.ExecuteDataset(SqlHelperData.ConnectionString, CommandType.Text, Sqlquery).Tables[0];

                        DataTable dt = SqlHelper.ExecuteDataset(Sqlquery, null).Tables[0];

                        if (dt != null && dt.Rows.Count > 0)
                        {
                            bookFlights.FlightsFare.AdultFare = bookFlights.FlightsFare.AdultFare + 100;
                            bookFlights.FlightsFare.ChildFare = bookFlights.FlightsFare.ChildFare + 100;
                            bookFlights.FlightsFare.InfantFare = bookFlights.FlightsFare.InfantFare + 100;
                            bookFlights.FlightsFare.GrandTotal = (bookFlights.FlightsFare.AdultFare + bookFlights.FlightsFare.AdultTax) + (bookFlights.FlightsFare.ChildFare + bookFlights.FlightsFare.ChildTax) + (bookFlights.FlightsFare.Infant + bookFlights.FlightsFare.InfantTax);
                        }

                        ViewBag.isFlexi = (bookFlights.FlightsSearch.IsFlexi) ? "1" : "0";
                        string alb = bookFlights.SourceMedia.ToString();


                        Session["SourceMedia"] = alb;

                        if (Session["SourceMedia"].ToString() != "VIMAN")
                        {
                            string ReturnDate = "";
                            string Class = bookFlights.Flights.Outbound[0].BookingCode;
                            if (bookFlights.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                            {
                                ReturnDate = bookFlights.FlightsSearch.RetDate.ToString("dd/MM/yyyy");
                                Class = bookFlights.Flights.Outbound[0].BookingCode + " " + bookFlights.Flights.Inbound[0].BookingCode;
                            }
                            string MarkupType = bookFlights.FlightsFare.MarkupType;
                            if (MarkupType == "")
                            {
                                MarkupType = "Available";
                            }
                            if (bookFlights.Flights.FlightFare.AdultTax == 0)
                            {
                                MarkupType = "Replace";
                            }





                            string sqlqq = "INSERT INTO ClickDetails(Class,MarkupType,AdultFare,AdultTax,ChildFare,ChildTax,InfantFare,InfantTax,Airline,FromAirport,ToAirport,DepartureDate,ReturnDate,IP,Jetcost,Date) VALUES('" + Class + "', '" + MarkupType + "'," + bookFlights.Flights.FlightFare.AdultFare + "," + bookFlights.Flights.FlightFare.AdultTax + "," + bookFlights.Flights.FlightFare.ChildFare + "," + bookFlights.Flights.FlightFare.ChildTax + "," + bookFlights.Flights.FlightFare.InfantFare + "," + bookFlights.Flights.FlightFare.InfantTax + ",'" + bookFlights.Flights.Airline.Code + "','" + bookFlights.FlightsSearch.From.Code + "','" + bookFlights.FlightsSearch.To.Code + "','" + bookFlights.FlightsSearch.DepDate.ToString("dd/MM/yyyy") + "','" + ReturnDate + "','" + Common.GetLocalIP() + "','" + Session["SourceMedia"].ToString() + "',GETDATE())";
                            int ckk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionString, CommandType.Text, sqlqq);
                        }

                        return View(bookFlights);
                    }
                    else
                    {
                        return Redirect("/");
                    }
                }
                else
                {
                    return Redirect("/");
                }
            }
            catch (Exception e)
            {
                return Redirect("/");
            }
        }




        public ActionResult BookingC(string SearchId, string flightId, string outId, string inId, int? Cnt)
        {
            return RedirectToAction("BookingK", "Flight", new { SearchId = SearchId, flightId = flightId, outId = outId, inId = inId, Cnt = Cnt });
        }


        public ActionResult BookingK(string SearchId, string flightId, string outId, string inId, int? Cnt)  //public ActionResult Booking(FormCollection frm)
        {
            FlightsBooking flightsBooking = new FlightsBooking();
            try
            {

                string ipadd = Common.GetLocalIP();
                guid = SearchId.ToString();
                searchId = flightId.ToString();



                string response = String.Empty;


                response = System.IO.File.ReadAllText(Server.MapPath(@"~/Content/File/Responce" + guid + ".json"));

                var sr = JsonConvert.DeserializeObject(response);
                FlightsResult flightsResult = JsonConvert.DeserializeObject<FlightsResult>(response, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver(), DateTimeZoneHandling = DateTimeZoneHandling.Local });



                Flights bookFlight = new Flights();


                if (flightsResult.FlightsSearch.FlightWay == FlightWay.OneWay)
                {
                    out_id = outId.ToString();

                    bookFlight = flightsResult.FlightsList.Where(f => f.Outbound[0].SagementRef.Equals(out_id) && f.IsDeal == false).FirstOrDefault();
                }
                else
                {
                    out_id = outId.ToString();
                    in_id = inId.ToString();
                    bookFlight = flightsResult.FlightsList.Where(f => f.Outbound[0].SagementRef.Equals(out_id) && f.Inbound[0].SagementRef.Equals(in_id) && f.IsDeal == false).FirstOrDefault();
                }


                flightsBooking.SearchId = flightsResult.FlightsSearch.SearchId;
                flightsBooking.BookingId = Common.GetBookingId("VMB");
                flightsBooking.Flights = bookFlight;
                flightsBooking.FlightsSearch = flightsResult.FlightsSearch;
                flightsBooking.SiteCode = SiteCode.VIMAN.ToString();
                flightsBooking.SourceMedia = flightsResult.FlightsSearch.SourceMedia;

                flightsBooking.FlightsFare = bookFlight.FlightFare;
                flightsBooking.TranscationStatus = "new";

                flightsResult.FlightsSearch.IsDeepLink = false;


                string alb = flightsBooking.SourceMedia.ToString();



                if (alb == "JETCOST")
                {
                    string ReturnDate = "";
                    string Class = bookFlight.Outbound[0].BookingCode;
                    if (flightsResult.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                    {
                        ReturnDate = flightsResult.FlightsSearch.RetDate.ToString("dd/MM/yyyy");
                        Class = bookFlight.Outbound[0].BookingCode + " " + bookFlight.Inbound[0].BookingCode;
                    }
                    string MarkupType = bookFlight.FlightFare.MarkupType;
                    if (MarkupType == "")
                    {
                        MarkupType = "Available";
                    }
                    if (bookFlight.FlightFare.AdultTax == 0)
                    {
                        MarkupType = "Replace";
                    }
                    string sqlqq = "INSERT INTO ClickDetails(Class,MarkupType,AdultFare,AdultTax,ChildFare,ChildTax,InfantFare,InfantTax,Airline,FromAirport,ToAirport,DepartureDate,ReturnDate,IP,Jetcost,Date) VALUES('" + Class + "','" + MarkupType + "'," + bookFlight.FlightFare.AdultFare + "," + bookFlight.FlightFare.AdultTax + "," + bookFlight.FlightFare.ChildFare + "," + bookFlight.FlightFare.ChildTax + "," + bookFlight.FlightFare.InfantFare + "," + bookFlight.FlightFare.InfantTax + ",'" + bookFlight.Airline.Code + "','" + flightsResult.FlightsSearch.From.Code + "','" + flightsResult.FlightsSearch.To.Code + "','" + flightsResult.FlightsSearch.DepDate.ToString("dd/MM/yyyy") + "','" + ReturnDate + "','" + Common.GetLocalIP() + "','" + alb + "',GETDATE())";
                    int ckk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionString, CommandType.Text, sqlqq);
                }
                System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + @"\Content\File\" + "flightsBooking" + guid + ".json", JsonConvert.SerializeObject(flightsBooking));

                return View(flightsBooking);
            }
            catch (Exception ex)
            {
                return View(flightsBooking);
            }
        }



        [HttpPost]
        public string BookingAlert(FormCollection FormColl)
        {
            try
            {
                if (Session["FlightsBook"] != null)
                {
                    FlightsBooking bookFlights = Session["FlightsBook"] as FlightsBooking;


                    string Airline = bookFlights.Flights.Outbound[0].Airline.Code;

                    string Amt = bookFlights.FlightsFare.GrandTotal.ToString();

                    string Pax = "A :" + bookFlights.FlightsSearch.Adult.ToString() + " C :" + bookFlights.FlightsSearch.Child.ToString() + " I :" + bookFlights.FlightsSearch.Infant.ToString();

                    string ReturnDate = "";
                    StringBuilder sbMaiBody = new StringBuilder();
                    sbMaiBody.Append("Reservation Alert,<br/><br/>");
                    sbMaiBody.Append("<b>Flight</b> : " + bookFlights.FlightsSearch.From.CityName + " to " + bookFlights.FlightsSearch.To.CityName + "<br/>");
                    sbMaiBody.Append("Departure Date   : " + bookFlights.FlightsSearch.DepDate.ToString("dd/MM/yyyy") + "<br/>");
                    if (bookFlights.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                    {
                        Airline = bookFlights.Flights.Outbound[0].Airline.Code + "-" + bookFlights.Flights.Inbound[0].Airline.Code;
                        sbMaiBody.Append("Return Date   : " + bookFlights.FlightsSearch.RetDate.ToString("dd/MM/yyyy") + "<br/><br/><br/>");
                        ReturnDate = bookFlights.FlightsSearch.RetDate.ToString("dd/MM/yyyy");
                    }

                    sbMaiBody.Append("Name : " + FormColl["FULLname"] + "<br/>");
                    sbMaiBody.Append("Phone      : " + FormColl["Phone"] + "<br/>");
                    sbMaiBody.Append("Email      : " + FormColl["Email"] + "<br/>");
                    sbMaiBody.Append("IP      : " + Common.GetLocalIP() + "<br/>");
                    sbMaiBody.Append("Source Media  : " + Session["SourceMedia"].ToString() == "VIMAN" ? "Faresmatch" : Session["SourceMedia"].ToString() + "<br/>");




                    sbMaiBody.Append("<br/>Many Thanks & Regards,<br/><br/>Faresmatch <br/>Website: www.Faresmatch.co.uk <br/>Tel.: +1-888-5469-579 <br/>");
                    //objEmailClass.SendCommonEmail("Reservation alert from flightoffice.co.uk", sbMaiBody.ToString());

                    string sqlqq = "INSERT INTO BookingAlert(Flight,DepartureDate,ReturnDate,Name,Phone,Email,IP,SourceMedia,AlertFor,CreateDate,Airline,Amt,NoPax,SearchId,TranscationId) VALUES('" + bookFlights.FlightsSearch.From.CityCode + " to " + bookFlights.FlightsSearch.To.CityCode + "','" + bookFlights.FlightsSearch.DepDate.ToString("dd/MM/yyyy") + "','" + ReturnDate + "','" + FormColl["FULLname"] + "','" + FormColl["Phone"] + "','" + FormColl["Email"] + "','" + Common.GetLocalIP() + "','" + (Session["SourceMedia"].ToString() == "VIMAN" ? "Faresmatch" : Session["SourceMedia"].ToString()) + "','Faresmatch',GETDATE(),'" + Airline + "','" + Amt + "','" + Pax + "','" + bookFlights.FlightsSearch.SearchId + "','" + bookFlights.BookingId + "')";
                    int ckk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionStringFlightoffice, CommandType.Text, sqlqq);

                    //Common.SendEmail("shane@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("scott@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("robinson@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("matthew@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("volter@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("jose@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("Patterson@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("Karry@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("robinson @flightoffice.co.uk", "Flight Office Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("Monu@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("adam@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("angela@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                    //Common.SendEmail("rahul@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString()); ;
                    // Common.SendEmailNew("mishralakshman75@gmail.com", "Faresmatch (US) Alert new", sbMaiBody.ToString());


                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

            return "success";
        }


        [HttpPost]
        public string BookingAlertK(FormCollection FormColl)
        {
            try
            {

                string guid = FormColl["hsearchId"];
                string flightsBooking = String.Empty;
                flightsBooking = System.IO.File.ReadAllText(Server.MapPath(@"~/Content/File/flightsBooking" + guid + ".json"));
                FlightsBooking bookFlights = JsonConvert.DeserializeObject<FlightsBooking>(flightsBooking, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver(), DateTimeZoneHandling = DateTimeZoneHandling.Local });

                string Airline = bookFlights.Flights.Outbound[0].Airline.Code;
                string Amt = bookFlights.FlightsFare.GrandTotal.ToString();
                string Pax = "A :" + bookFlights.FlightsSearch.Adult.ToString() + " C :" + bookFlights.FlightsSearch.Child.ToString() + " I :" + bookFlights.FlightsSearch.Infant.ToString();


                string ReturnDate = "";
                StringBuilder sbMaiBody = new StringBuilder();
                sbMaiBody.Append("Reservation Alert,<br/><br/>");
                sbMaiBody.Append("<b>Flight</b> : " + bookFlights.FlightsSearch.From.CityName + " to " + bookFlights.FlightsSearch.To.CityName + "<br/>");
                sbMaiBody.Append("Departure Date   : " + bookFlights.FlightsSearch.DepDate.ToString("dd/MM/yyyy") + "<br/>");
                if (bookFlights.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                {
                    Airline = bookFlights.Flights.Outbound[0].Airline.Code + "-" + bookFlights.Flights.Inbound[0].Airline.Code;
                    sbMaiBody.Append("Return Date   : " + bookFlights.FlightsSearch.RetDate.ToString("dd/MM/yyyy") + "<br/><br/><br/>");
                    ReturnDate = bookFlights.FlightsSearch.RetDate.ToString("dd/MM/yyyy");
                }

                sbMaiBody.Append("Name : " + FormColl["FULLname"] + "<br/>");
                sbMaiBody.Append("Phone      : " + FormColl["Phone"] + "<br/>");
                sbMaiBody.Append("Email      : " + FormColl["Email"] + "<br/>");
                sbMaiBody.Append("IP      : " + Common.GetLocalIP() + "<br/>");
                sbMaiBody.Append("Source Media  : " + bookFlights.FlightsSearch.SourceMedia.ToString() == "VIMAN" ? "Faresmatch" : bookFlights.FlightsSearch.SourceMedia.ToString() + "<br/>");




                sbMaiBody.Append("<br/>Many Thanks & Regards,<br/><br/>Faresmatch <br/>Website: www.Faresmatch.co.uk <br/>Tel.: +1-888-5469-579 <br/>");
                //objEmailClass.SendCommonEmail("Reservation alert from flightoffice.co.uk", sbMaiBody.ToString());

                //string sqlqq = "INSERT INTO BookingAlert(Flight,DepartureDate,ReturnDate,Name,Phone,Email,IP,SourceMedia,AlertFor,CreateDate,Airline,Amt,NoPax) VALUES('" + bookFlights.FlightsSearch.From.CityCode + " to " + bookFlights.FlightsSearch.To.CityCode + "','" + bookFlights.FlightsSearch.DepDate.ToString("dd/MM/yyyy") + "','" + ReturnDate + "','" + FormColl["FULLname"] + "','" + FormColl["Phone"] + "','" + FormColl["Email"] + "','" + Common.GetLocalIP() + "','" + (Session["SourceMedia"].ToString() == "VIMAN" ? "Faresmatch" : Session["SourceMedia"].ToString()) + "','Faresmatch',GETDATE(),'" + Airline + "','" + Amt + "','" + Pax + "')";
                string sqlqq = "INSERT INTO BookingAlert(Flight,DepartureDate,ReturnDate,Name,Phone,Email,IP,SourceMedia,AlertFor,CreateDate,Airline,Amt,NoPax,SearchId,TranscationId) VALUES('" + bookFlights.FlightsSearch.From.CityCode + " to " + bookFlights.FlightsSearch.To.CityCode + "','" + bookFlights.FlightsSearch.DepDate.ToString("dd/MM/yyyy") + "','" + ReturnDate + "','" + FormColl["FULLname"] + "','" + FormColl["Phone"] + "','" + FormColl["Email"] + "','" + Common.GetLocalIP() + "','" + (bookFlights.FlightsSearch.SourceMedia.ToString() == "VIMAN" ? "Faresmatch" : bookFlights.FlightsSearch.SourceMedia.ToString()) + "','Faresmatch',GETDATE(),'" + Airline + "','" + Amt + "','" + Pax + "','" + bookFlights.FlightsSearch.SearchId + "','" + bookFlights.BookingId + "')";
                int ckk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionStringFlightoffice, CommandType.Text, sqlqq);

                //Common.SendEmail("shane@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("scott@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("robinson@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("matthew@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("volter@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("jose@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("Patterson@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("Karry@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("robinson @flightoffice.co.uk", "Flight Office Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("Monu@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("adam@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("angela@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString());
                //Common.SendEmail("rahul@flightoffice.co.uk", "Faresmatch (US) Booking Alert", sbMaiBody.ToString()); ;
                //Common.SendEmailNew("mishralakshman75@gmail.com", "Faresmatch (US) Alert new", sbMaiBody.ToString());
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

            return "success";
        }


        [HttpPost]
        public ActionResult Payment(FormCollection FormColl)
        {
            var hdnFreeChangeAmt = string.IsNullOrEmpty(FormColl["hdnFreeChangeAmt"].ToString()) ? 0 : Convert.ToDecimal(FormColl["hdnFreeChangeAmt"]);
            var hdnFinalfare = string.IsNullOrEmpty(FormColl["hdnFinalfare"].ToString()) ? 0 : Convert.ToDecimal(FormColl["hdnFinalfare"]);
            try
            {
                Session["BookingID"] = null;

                if (Session["FlightsBook"] != null)
                {
                    FlightsBooking bookFlights = Session["FlightsBook"] as FlightsBooking;

                    if (Session["BookingID"] == null)
                    {
                        Session["BookingID"] = Common.GetBookingId("TFG");
                        DataTable dtxc = SqlData.Data.SqlHelperData.ExecuteDataset(SqlData.Data.SqlHelperData.ConnectionStringFlightoffice, CommandType.Text, "SELECT TOP 1 SUBSTRING(BookingId,4,6) BookingId FROM FlightsBooking ORDER BY Id DESC").Tables[0];
                        string max_id = (int.Parse(dtxc.Rows[0]["BookingId"].ToString()) + 1) + "";
                        Session["BookingID"] = "TFG" + max_id.PadLeft(6, '0');
                    }
                    bookFlights.BookingId = Session["BookingID"].ToString();
                    if (bookFlights != null)
                    {
                        bookFlights.TranscationId = Common.GetId();
                        string str = FormColl["radio_gender_" + 1];
                        string str2 = FormColl["radio_gender"];
                        bookFlights.FullName = FormColl["title_1"] + " " + FormColl["fname_1"] + " " + FormColl["lname_1"];
                        bookFlights.Email = FormColl["email"];
                        bookFlights.PhoneNo = FormColl["phone"];
                        bookFlights.IsHotel = (string.IsNullOrEmpty(FormColl["hotel_chk"])) ? "0" : FormColl["hotel_chk"];
                        BagsPrice bagPrice = new BagsPrice();

                        bagPrice.BagsPcs = (string.IsNullOrEmpty(FormColl["hdnBaggagePcs"])) ? "0" : FormColl["hdnBaggagePcs"];
                        bagPrice.BagsPcsPrice = float.Parse(FormColl["hdnBaggagePrice"] == null ? "0" : FormColl["hdnBaggagePrice"]);

                        bookFlights.BagPrice = bagPrice;
                        bookFlights.BookerDetail = new BookerDetail()
                        {
                            Gender = FormColl["radio_gender_" + 1],
                            Title = FormColl["title_1"],
                            FirstName = FormColl["fname_1"],
                            LastName = FormColl["lname_1"],
                            Address1 = FormColl["address"],
                            Address2 = "",
                            City = FormColl["city"],
                            Country = FormColl["countryCode"],
                            PostCode = FormColl["postcode"],
                            PhoneNo = FormColl["phone"],
                            Email = FormColl["email"],
                        };
                        int pass_cnt = 0;
                        bookFlights.PassengerDetail = new List<PassengerDetail>();
                        for (int i = 1; i <= bookFlights.FlightsSearch.Adult; i++)
                        {
                            pass_cnt++;
                            string adtP = FormColl["pYear_" + pass_cnt] + "-" + FormColl["pMonth_" + pass_cnt] + "-" + FormColl["pDay_" + pass_cnt];
                            //string adtP =  Convert.ToString(  FormColl["pDay_" + pass_cnt]);
                            bookFlights.PassengerDetail.Add(new PassengerDetail()
                            {
                                TravelerNo = pass_cnt,
                                PassengerType = PassengerType.Adult,
                                Gender = FormColl["radio_gender_" + pass_cnt],
                                Title = FormColl["title_" + pass_cnt],
                                FirstName = FormColl["fname_" + pass_cnt],
                                LastName = FormColl["lname_" + pass_cnt],
                                //DOB = Convert.ToDateTime(dob_str[2] + "-" + dob_str[1] + "-" + dob_str[0]),
                                //DOB = Convert.ToDateTime(FormColl["pDay_" + pass_cnt]),
                                DOB = Convert.ToDateTime(FormColl["pYear_" + pass_cnt] + "-" + FormColl["pMonth_" + pass_cnt] + "-" + FormColl["pDay_" + pass_cnt]),
                            });
                        }
                        for (int i = 1; i <= bookFlights.FlightsSearch.Child; i++)
                        {
                            pass_cnt++;
                            string chdP = FormColl["pYear_" + pass_cnt] + "-" + FormColl["pMonth_" + pass_cnt] + "-" + FormColl["pDay_" + pass_cnt];
                            //string[] dob_str = FormColl["dob_" + pass_cnt].Split('-');
                            //string chdP = FormColl["pDay_" + pass_cnt];
                            bookFlights.PassengerDetail.Add(new PassengerDetail()
                            {
                                TravelerNo = pass_cnt,
                                PassengerType = PassengerType.Child,
                                Gender = FormColl["radio_gender_" + pass_cnt],
                                Title = FormColl["title_" + pass_cnt],
                                FirstName = FormColl["fname_" + pass_cnt],
                                LastName = FormColl["lname_" + pass_cnt],
                                //DOB = Convert.ToDateTime(dob_str[2] + "-" + dob_str[1] + "-" + dob_str[0]),
                                //DOB = Convert.ToDateTime(FormColl["pDay_" + pass_cnt]),
                                DOB = Convert.ToDateTime(FormColl["pYear_" + pass_cnt] + "-" + FormColl["pMonth_" + pass_cnt] + "-" + FormColl["pDay_" + pass_cnt]),
                            });
                        }
                        for (int i = 1; i <= bookFlights.FlightsSearch.Infant; i++)
                        {
                            pass_cnt++;
                            //string[] dob_str = FormColl["dob_" + pass_cnt].Split('-');
                            //string infP = FormColl["pDay_" + pass_cnt];
                            string infP = FormColl["pYear_" + pass_cnt] + "-" + FormColl["pMonth_" + pass_cnt] + "-" + FormColl["pDay_" + pass_cnt];
                            bookFlights.PassengerDetail.Add(new PassengerDetail()
                            {
                                TravelerNo = pass_cnt,
                                PassengerType = PassengerType.Infant,
                                Gender = FormColl["radio_gender_" + pass_cnt],
                                Title = FormColl["title_" + pass_cnt],
                                FirstName = FormColl["fname_" + pass_cnt],
                                LastName = FormColl["lname_" + pass_cnt],
                                //DOB = Convert.ToDateTime(dob_str[2] + "-" + dob_str[1] + "-" + dob_str[0]),
                                //DOB = Convert.ToDateTime(FormColl["pDay_" + pass_cnt]),
                                DOB = Convert.ToDateTime(FormColl["pYear_" + pass_cnt] + "-" + FormColl["pMonth_" + pass_cnt] + "-" + FormColl["pDay_" + pass_cnt]),
                            });
                        }

                        if (FormColl["cc_number"] != null)
                        {
                            bookFlights.SagepayDetail = new SagepayDetail()
                            {
                                BookingId = bookFlights.BookingId,
                                TranscationId = bookFlights.TranscationId,
                                CardType = FormColl["cardType"],
                                CardHolderName = FormColl["cc_name"],
                                CardNumber = FormColl["cc_number"],
                                CVV = FormColl["cc_cvv"],
                                ExpiryDate = FormColl["cc_exp"],
                                CryptVal = "",
                                Last4Digits = FormColl["cc_number"].Length == 16 ? FormColl["cc_number"].Substring(12, 4) : string.Empty,
                            };

                            ViewBag.PayResponse = "Inhouse Redirect";

                        }
                        else
                        {
                            // generate sagepayment variable
                            var cryptValue = SagepayPaymentHelper.BuildPaymentResponse(JsonConvert.SerializeObject(bookFlights), "flightBooking", bookFlights.TranscationId);

                            if (cryptValue.Equals(""))
                            {
                                ViewBag.PayResponse = "Payment Error";
                            }
                            else
                            {
                                bookFlights.SagepayDetail = new SagepayDetail()
                                {
                                    BookingId = bookFlights.BookingId,
                                    TranscationId = bookFlights.TranscationId,
                                    CryptVal = cryptValue
                                };

                                ViewBag.PayResponse = cryptValue;
                            }
                        }

                        ViewBag.FlightId = bookFlights.TranscationId;

                        // Common.WriteLog("TranscationId :" + ViewBag.FlightId.ToString());
                        InsertBookingDetails(bookFlights, hdnFreeChangeAmt.ToString(), hdnFinalfare.ToString());



                        // ViewBag.Amt = hdnFinalfare.ToString();

                        //string[] Amt = hdnFinalfare.ToString().Split('.');
                        //if (Amt.Length > 1)
                        //{
                        //    string MainAmt = Amt[0] + Amt[1];
                        //    ViewBag.Amt = MainAmt;
                        //}
                        //else
                        //{
                        //    ViewBag.Amt = hdnFinalfare.ToString();
                        //}

                        //ViewBag.PhNo = FormColl["phone"];
                        //ViewBag.PostCode = FormColl["postcode"];
                        //ViewBag.Address = FormColl["address"];
                        //ViewBag.email = FormColl["email"];
                        //DataTable dtxc = SqlData.Data.SqlHelperData.ExecuteDataset(SqlData.Data.SqlHelperData.ConnectionString, CommandType.Text, "select SUBSTRING(PaymentId,2,130) PaymentId from PaymentDetail order by id desc").Tables[0];
                        //int PayId = 0;
                        //PayId = Convert.ToInt32(dtxc.Rows[0]["PaymentId"].ToString()) + 1;
                        //ViewBag.PaymentId = "K" + PayId.ToString();
                        //// Country = FormColl["countryCode"],
                        //string sqlqq = "INSERT INTO PaymentDetail(PaymentId,Amount,date) VALUES('" + ViewBag.PaymentId + "'," + ViewBag.Amt + ",GETDATE())";
                        //int ckk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionString, CommandType.Text, sqlqq);


                        // booking session expire
                        //Session["FlightsBook"] = null;
                        //Session["FlightsResult"] = null;
                        //Session["BookingID"] = null;


                        return Redirect("/flight/Card?bRef=" + bookFlights.TranscationId);
                        //if (sagePayFlag)
                        //    return Redirect("/flight/Card?bRef=" + bookFlights.TranscationId);
                        //else
                        //    return Redirect("/flight/cancel?ref=" + bookFlights.TranscationId);
                    }
                    else
                    {
                        ViewBag.PayResponse = "Session Error";
                    }
                }
                else
                {
                    ViewBag.PayResponse = "Session Error";
                }
            }
            catch (Exception e)
            {
                ViewBag.PayResponse = "Server Error";
                ViewBag.PayResponseError = e.Message.ToString();
                return RedirectToAction("Card", "Flight", new { error = e.Message });
            }

            return RedirectToAction("Card", "Flight", new { error = "Unknown error occurred." });

            //return View();
        }


        [HttpPost]
        public ActionResult PaymentUpd(FormCollection FormColl)
        {
            var hdnFreeChangeAmt = string.IsNullOrEmpty(FormColl["hdnFreeChangeAmt"].ToString()) ? 0 : Convert.ToDecimal(FormColl["hdnFreeChangeAmt"]);
            var hdnFinalfare = string.IsNullOrEmpty(FormColl["hdnFinalfare"].ToString()) ? 0 : Convert.ToDecimal(FormColl["hdnFinalfare"]);
            try
            {
                Session["BookingID"] = null;

                if (Session["FlightsBook"] != null)
                {
                    FlightsBooking bookFlights = Session["FlightsBook"] as FlightsBooking;

                    //bookFlights.BookingId = Common.GetBookingId("VMB");

                    var cnv_add = bookFlights.FlightsSearch.DepDate.ToString("MM-dd-yyyy");
                    var cnv_adc =  bookFlights.FlightsSearch.To.Code;
                    var cnv_aoc = bookFlights.FlightsSearch.From.Code;
                    var cnv_anm = bookFlights.FlightsSearch.Airline.Code;
                    var cnv_acc = bookFlights.FlightsSearch.FlightClass.ToString();
                    var cnv_cu = "$";

                    if (bookFlights != null)
                    {
                        //bookFlights.TranscationId = Common.GetId();
                        //Booking table Insertion


                        if (FormColl["cc_number"] != null)
                        {
                            bookFlights.SagepayDetail = new SagepayDetail()
                            {
                                BookingId = bookFlights.BookingId,
                                TranscationId = bookFlights.TranscationId,
                                CardType = FormColl["cardType"],
                                CardHolderName = FormColl["cc_name"],
                                CardNumber = FormColl["cc_number"],
                                CVV = FormColl["securityCode"],
                                ExpiryDate = FormColl["cc_expMM"] + "/" + FormColl["cc_expMM"],
                                CryptVal = "",
                                Last4Digits = FormColl["cc_number"].Length == 16 ? FormColl["cc_number"].Substring(12, 4) : string.Empty,
                            };

                            ViewBag.PayResponse = "Inhouse Redirect";

                        }
                        else
                        {
                            // generate sagepayment variable
                            var cryptValue = SagepayPaymentHelper.BuildPaymentResponse(JsonConvert.SerializeObject(bookFlights), "flightBooking", bookFlights.TranscationId);

                            if (cryptValue.Equals(""))
                            {
                                ViewBag.PayResponse = "Payment Error";
                            }
                            else
                            {
                                bookFlights.SagepayDetail = new SagepayDetail()
                                {
                                    BookingId = bookFlights.BookingId,
                                    TranscationId = bookFlights.TranscationId,
                                    CryptVal = cryptValue
                                };

                                ViewBag.PayResponse = cryptValue;
                            }
                        }

                        ViewBag.FlightId = bookFlights.TranscationId;

                        // Common.WriteLog("TranscationId :" + ViewBag.FlightId.ToString());
                        UpdateBookingDetails(bookFlights, hdnFreeChangeAmt.ToString(), hdnFinalfare.ToString());

                        // ViewBag.Amt = hdnFinalfare.ToString();
                        //string[] Amt = hdnFinalfare.ToString().Split('.');
                        //if (Amt.Length > 1)
                        //{
                        //    string MainAmt = Amt[0] + Amt[1];
                        //    ViewBag.Amt = MainAmt;
                        //}
                        //else
                        //{
                        //    ViewBag.Amt = hdnFinalfare.ToString();
                        //}

                        //ViewBag.PhNo = FormColl["phone"];
                        //ViewBag.PostCode = FormColl["postcode"];
                        //ViewBag.Address = FormColl["address"];
                        //ViewBag.email = FormColl["email"];
                        //DataTable dtxc = SqlData.Data.SqlHelperData.ExecuteDataset(SqlData.Data.SqlHelperData.ConnectionString, CommandType.Text, "select SUBSTRING(PaymentId,2,130) PaymentId from PaymentDetail order by id desc").Tables[0];
                        //int PayId = 0;
                        //PayId = Convert.ToInt32(dtxc.Rows[0]["PaymentId"].ToString()) + 1;
                        //ViewBag.PaymentId = "K" + PayId.ToString();
                        //// Country = FormColl["countryCode"],
                        //string sqlqq = "INSERT INTO PaymentDetail(PaymentId,Amount,date) VALUES('" + ViewBag.PaymentId + "'," + ViewBag.Amt + ",GETDATE())";
                        //int ckk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionString, CommandType.Text, sqlqq);

                        // booking session expire
                       

                        return Redirect("/flight/Confirm?ref=" + bookFlights.TranscationId  + "&cnv_atf=" + hdnFinalfare + "&cnv_cu=" +"USD");
                    }
                    else
                    {
                        ViewBag.PayResponse = "Session Error";
                    }
                }
                else
                {
                    ViewBag.PayResponse = "Session Error";
                }
            }
            catch (Exception e)
            {
                ViewBag.PayResponse = "Server Error";
                ViewBag.PayResponseError = e.Message.ToString();
            }

            return View();
        }

        [HttpPost]
        public ActionResult PaymentUpdK(FormCollection FormColl)
        {
            var hdnFreeChangeAmt = string.IsNullOrEmpty(FormColl["hdnFreeChangeAmt"].ToString()) ? 0 : Convert.ToDecimal(FormColl["hdnFreeChangeAmt"]);
            var hdnFinalfare = string.IsNullOrEmpty(FormColl["hdnFinalfare"].ToString()) ? 0 : Convert.ToDecimal(FormColl["hdnFinalfare"]);
            try
            {
                Session["BookingID"] = null;

                string guid = FormColl["hsearchId"];
                string flightsBooking = String.Empty;
                flightsBooking = System.IO.File.ReadAllText(Server.MapPath(@"~/Content/File/flightsBooking" + guid + ".json"));
                FlightsBooking bookFlights = JsonConvert.DeserializeObject<FlightsBooking>(flightsBooking, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver(), DateTimeZoneHandling = DateTimeZoneHandling.Local });


                if (bookFlights != null)
                {
                    //bookFlights.BookingId = Common.GetBookingId("VMB");

                    if (bookFlights != null)
                    {
                        bookFlights.TranscationId = Common.GetTranscationId(guid);
                        //Booking table Insertion

                        if (FormColl["cc_number"] != null)
                        {
                            bookFlights.SagepayDetail = new SagepayDetail()
                            {
                                BookingId = bookFlights.BookingId,
                                TranscationId = bookFlights.TranscationId,
                                CardType = FormColl["cardType"],
                                CardHolderName = FormColl["cc_name"],
                                CardNumber = FormColl["cc_number"],
                                CVV = FormColl["securityCode"],
                                ExpiryDate = FormColl["cc_expMM"] + "/" + FormColl["cc_expMM"],
                                CryptVal = "",
                                Last4Digits = FormColl["cc_number"].Length == 16 ? FormColl["cc_number"].Substring(12, 4) : string.Empty,
                            };

                            ViewBag.PayResponse = "Inhouse Redirect";

                        }
                        else
                        {
                            // generate sagepayment variable
                            var cryptValue = SagepayPaymentHelper.BuildPaymentResponse(JsonConvert.SerializeObject(bookFlights), "flightBooking", bookFlights.TranscationId);

                            if (cryptValue.Equals(""))
                            {
                                ViewBag.PayResponse = "Payment Error";
                            }
                            else
                            {
                                bookFlights.SagepayDetail = new SagepayDetail()
                                {
                                    BookingId = bookFlights.BookingId,
                                    TranscationId = bookFlights.TranscationId,
                                    CryptVal = cryptValue
                                };

                                ViewBag.PayResponse = cryptValue;
                            }
                        }

                        ViewBag.FlightId = bookFlights.TranscationId;

                        // Common.WriteLog("TranscationId :" + ViewBag.FlightId.ToString());
                        UpdateBookingDetails(bookFlights, hdnFreeChangeAmt.ToString(), hdnFinalfare.ToString());

                        // ViewBag.Amt = hdnFinalfare.ToString();
                        //string[] Amt = hdnFinalfare.ToString().Split('.');
                        //if (Amt.Length > 1)
                        //{
                        //    string MainAmt = Amt[0] + Amt[1];
                        //    ViewBag.Amt = MainAmt;
                        //}
                        //else
                        //{
                        //    ViewBag.Amt = hdnFinalfare.ToString();
                        //}

                        //ViewBag.PhNo = FormColl["phone"];
                        //ViewBag.PostCode = FormColl["postcode"];
                        //ViewBag.Address = FormColl["address"];
                        //ViewBag.email = FormColl["email"];
                        //DataTable dtxc = SqlData.Data.SqlHelperData.ExecuteDataset(SqlData.Data.SqlHelperData.ConnectionString, CommandType.Text, "select SUBSTRING(PaymentId,2,130) PaymentId from PaymentDetail order by id desc").Tables[0];
                        //int PayId = 0;
                        //PayId = Convert.ToInt32(dtxc.Rows[0]["PaymentId"].ToString()) + 1;
                        //ViewBag.PaymentId = "K" + PayId.ToString();
                        //// Country = FormColl["countryCode"],
                        //string sqlqq = "INSERT INTO PaymentDetail(PaymentId,Amount,date) VALUES('" + ViewBag.PaymentId + "'," + ViewBag.Amt + ",GETDATE())";
                        //int ckk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionString, CommandType.Text, sqlqq);

                        // booking session expire


                        return Redirect("/flight/ConfirmK?ref=" + bookFlights.TranscationId);
                    }
                    else
                    {
                        ViewBag.PayResponse = "Session Error";
                    }
                }
                else
                {
                    ViewBag.PayResponse = "Session Error";
                }
            }
            catch (Exception e)
            {
                ViewBag.PayResponse = "Server Error";
                ViewBag.PayResponseError = e.Message.ToString();
            }

            return View();
        }

        [HttpPost]
        public ActionResult PaymentK_old(FormCollection FormColl)
        {
            var hdnFreeChangeAmt = string.IsNullOrEmpty(FormColl["hdnFreeChangeAmt"].ToString()) ? 0 : Convert.ToDecimal(FormColl["hdnFreeChangeAmt"]);
            var hdnFinalfare = string.IsNullOrEmpty(FormColl["hdnFinalfare"].ToString()) ? 0 : Convert.ToDecimal(FormColl["hdnFinalfare"]);
            try
            {
                string guid = FormColl["hsearchId"];
                string flightsBooking = String.Empty;
                flightsBooking = System.IO.File.ReadAllText(Server.MapPath(@"~/Content/File/flightsBooking" + guid + ".json"));
                FlightsBooking bookFlights = JsonConvert.DeserializeObject<FlightsBooking>(flightsBooking, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver(), DateTimeZoneHandling = DateTimeZoneHandling.Local });

                DataTable dtxc = SqlData.Data.SqlHelperData.ExecuteDataset(SqlData.Data.SqlHelperData.ConnectionStringFlightoffice, CommandType.Text, "SELECT TOP 1 SUBSTRING(BookingId,4,6) BookingId FROM FlightsBooking ORDER BY Id DESC").Tables[0];
                string max_id = (int.Parse(dtxc.Rows[0]["BookingId"].ToString()) + 1) + "";
                Session["BookingID"] = "TFG" + max_id.PadLeft(6, '0');



                //bookFlights.BookingId = Common.GetBookingId("VMB");
                bookFlights.BookingId = Session["BookingID"].ToString();
                if (bookFlights != null)
                {
                    bookFlights.TranscationId = Common.GetId();
                    bookFlights.FullName = FormColl["title_1"] + " " + FormColl["fname_1"] + " " + FormColl["lname_1"];
                    bookFlights.Email = FormColl["email"];
                    bookFlights.PhoneNo = FormColl["phone"];
                    bookFlights.IsHotel = (string.IsNullOrEmpty(FormColl["hotel_chk"])) ? "0" : FormColl["hotel_chk"];
                    BagsPrice bagPrice = new BagsPrice();

                    bagPrice.BagsPcs = (string.IsNullOrEmpty(FormColl["hdnBaggagePcs"])) ? "0" : FormColl["hdnBaggagePcs"];
                    bagPrice.BagsPcsPrice = float.Parse(FormColl["hdnBaggagePrice"] == null ? "0" : FormColl["hdnBaggagePrice"]);

                    bookFlights.BagPrice = bagPrice;
                    //Session["SearchIP"] = Common.SearchIP(bookFlights.SearchId);
                    bookFlights.BookerDetail = new BookerDetail()
                    {
                        Title = FormColl["title_1"],
                        FirstName = FormColl["fname_1"],
                        LastName = FormColl["lname_1"],
                        Address1 = FormColl["address"],
                        Address2 = "",
                        City = FormColl["city"],
                        Country = FormColl["countryCode"],
                        PostCode = FormColl["postcode"],
                        PhoneNo = FormColl["phone"],
                        Email = FormColl["email"],
                    };
                    int pass_cnt = 0;
                    bookFlights.PassengerDetail = new List<PassengerDetail>();
                    for (int i = 1; i <= bookFlights.FlightsSearch.Adult; i++)
                    {
                        pass_cnt++;
                        string[] dob_str = FormColl["dob_" + pass_cnt].Split('-');
                        bookFlights.PassengerDetail.Add(new PassengerDetail()
                        {
                            TravelerNo = pass_cnt,
                            PassengerType = PassengerType.Adult,
                            Title = FormColl["title_" + pass_cnt],
                            FirstName = FormColl["fname_" + pass_cnt],
                            LastName = FormColl["lname_" + pass_cnt],
                            DOB = Convert.ToDateTime(dob_str[2] + "-" + dob_str[1] + "-" + dob_str[0]),
                        });
                    }
                    for (int i = 1; i <= bookFlights.FlightsSearch.Child; i++)
                    {
                        pass_cnt++;
                        string[] dob_str = FormColl["dob_" + pass_cnt].Split('-');
                        bookFlights.PassengerDetail.Add(new PassengerDetail()
                        {
                            TravelerNo = pass_cnt,
                            PassengerType = PassengerType.Child,
                            Title = FormColl["title_" + pass_cnt],
                            FirstName = FormColl["fname_" + pass_cnt],
                            LastName = FormColl["lname_" + pass_cnt],
                            DOB = Convert.ToDateTime(dob_str[2] + "-" + dob_str[1] + "-" + dob_str[0]),
                        });
                    }
                    for (int i = 1; i <= bookFlights.FlightsSearch.Infant; i++)
                    {
                        pass_cnt++;
                        string[] dob_str = FormColl["dob_" + pass_cnt].Split('-');
                        bookFlights.PassengerDetail.Add(new PassengerDetail()
                        {
                            TravelerNo = pass_cnt,
                            PassengerType = PassengerType.Infant,
                            Title = FormColl["title_" + pass_cnt],
                            FirstName = FormColl["fname_" + pass_cnt],
                            LastName = FormColl["lname_" + pass_cnt],
                            DOB = Convert.ToDateTime(dob_str[2] + "-" + dob_str[1] + "-" + dob_str[0]),
                        });
                    }



                    if (!string.IsNullOrEmpty(FormColl["signup_chk"]))
                    {
                        string curr_sess = Common.GetId();

                        SqlParameter[] commandParameters = new SqlParameter[7];
                        commandParameters[0] = new SqlParameter("@name", SqlDbType.VarChar, 50) { Value = bookFlights.BookerDetail.FirstName + " " + bookFlights.BookerDetail.LastName };
                        commandParameters[1] = new SqlParameter("@email", SqlDbType.VarChar, 50) { Value = bookFlights.BookerDetail.Email };
                        commandParameters[2] = new SqlParameter("@sess", SqlDbType.VarChar, 50) { Value = curr_sess };
                        commandParameters[3] = new SqlParameter("@sitecode", SqlDbType.VarChar, 50) { Value = SiteCode.VIMAN.ToString() };
                        commandParameters[4] = new SqlParameter("@status", SqlDbType.VarChar, 50) { Value = "deactive" };
                        commandParameters[5] = new SqlParameter("@ip", SqlDbType.VarChar, 50) { Value = Common.GetLocalIP() };


                        try
                        {
                            DataSet ds2 = SqlHelperData.ExecuteDataset(SqlHelperData.ConnectionStringTrack, CommandType.Text, "SELECT COUNT(1) FROM Newslatter WHERE Status='active' AND SiteCode='" + bookFlights.SiteCode + "' AND Email='" + bookFlights.BookerDetail.Email.Replace("'", "''") + "'");

                            if (ds2 != null && ds2.Tables[0].Rows[0][0].ToString() == "0")
                            {
                                // DataSet ds = SqlHelper.ExecuteDataset("INSERT INTO Newslatter(SiteCode,Name,Email,Sess,Ip,Status) VALUES(@sitecode,@name,@email,@sess,@ip,@status) SELECT SCOPE_IDENTITY()", commandParameters);
                                string sqlq = "INSERT INTO Newslatter(SiteCode,Name,Email,Sess,Ip,Status) VALUES('" + bookFlights.SiteCode + "','" + bookFlights.BookerDetail.FirstName + " " + bookFlights.BookerDetail.LastName + "','" + bookFlights.BookerDetail.Email + "','" + curr_sess + "','" + Common.GetLocalIP() + "','deactive')";
                                int ck = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionStringTrack, CommandType.Text, sqlq);

                                // send email to user

                                EmailClass objEmailClass = new EmailClass();
                                objEmailClass.MailTo = bookFlights.BookerDetail.Email;
                                objEmailClass.MailBCC = "";
                                StringBuilder sbMaiBody = new StringBuilder();
                                sbMaiBody.Append("<table align=\"center\" style=\"width: 500px; border: 1px solid #000; text-align: center; font-family: sans-serif;\">");
                                sbMaiBody.Append("<tr><td style=\"text-align: center; padding: 10px;\"><a href=\"https://Faresmatch.co.uk\" target=\"_blank\">");
                                sbMaiBody.Append("<img src=\"https://www.Faresmatch.co.uk/Content/images/logo_.png\" width=\"60%;\"></a></td></tr><tr><td>");
                                sbMaiBody.Append("<p style=\"margin: 0px; font-size:25px; line-height: 30px; \">Thankyou for subscribing to <br/><strong style=\"font-size: 18px;\">");
                                sbMaiBody.Append("Flightoffice Newslatter</strong></p><p style=\"font-size: 12px; color: #666; margin: 0px;padding:0px 10%; margin-top: 15px;\">");
                                sbMaiBody.Append("An email has been sent to you that contain a verification link. Please click this \"verify\" link to complete your subscription</p></td></tr>");
                                sbMaiBody.Append("<tr><td style=\"padding:0px 0px 15px 0px;\"><a href=\"https://www.Faresmatch.co.uk/subscribe/?key=" + curr_sess + "\" ");
                                sbMaiBody.Append("target =\"_blank\" style=\"background:#0e753e; padding: 10px; text-decoration: none; color:white; margin: 15px 0px; border-radius: 5px; display: inline-block;\"> ");
                                sbMaiBody.Append("Verify Your Email</a></td></tr><tr style=\"text-align: center\"><td ><p style=\"width: 20%; border-top: 1px solid #000; display: inline-block; margin-top: 0px;\" > ");
                                sbMaiBody.Append("</p></td></tr><tr><td style=\"font-size: 18px; font-weight: 700;\">Want to get in sooner?</td></tr><tr><td><p style=\"margin-bottom: 0px;\">");
                                sbMaiBody.Append("Recommend to your friends using our social</p></td></tr><tr><td style=\"padding:  15px 0px;\"><a href=\"https://twitter.com/mover\" target=\"_blank\" ");
                                sbMaiBody.Append("style =\"text-decoration: none; margin-right: 10px; display: inline-block; background: #f6921d; padding: 10px; border-radius: 50px; \">");
                                sbMaiBody.Append("<img src=\"http://www.Faresmatch.co.uk/Media/Newslatter/Twitternew.png\" width=\"20px\" style=\"position: relative; top:3px;\"></a>");
                                sbMaiBody.Append("<a href=\"https://www.facebook.com/www.Faresmatch.co.uk/\" target=\"_blank\" style=\"text-decoration: none; margin-right: 10px; display: inline-block;");
                                sbMaiBody.Append("background: #f6921d; padding: 10px; border-radius: 50px; \"><img src=\"http://Faresmatch.co.uk/Media/Newslatter/fb_icon_325x325.png\" width=\"20px\" ");
                                sbMaiBody.Append("style =\"position: relative; top:3px;\"></a><a href=\"https://in.linkedin.com/company/travelopedia-ltd\" target=\"_blank\" style=\"text-decoration: none; ");
                                sbMaiBody.Append("margin -right: 10px; display: inline-block; background: #f6921d; padding: 10px; border-radius: 50px; \"><img src=\"http://Faresmatch.co.uk/Media/Newslatter/Linkedin.png\" ");
                                sbMaiBody.Append("width =\"20px\" style=\"position: relative; top:1px;\"></a></td></tr><tr><td style=\"background: #f7f7f7;  border-top: 1px solid #bbb;\">");
                                sbMaiBody.Append("<p style=\"font-size: 12px;margin-bottom: 5px;\">Copyright &copy; 2019 flightoffice.co.uk. All right reserved.</p><p style=\"text-align: center; font-size: 11px; margin-top: 0px;\">");
                                sbMaiBody.Append("<a href=\"mailto:booking@faresmatch.com\" target=\"_blank\" style=\"text-decoration: none; color:#666;\">info@viman.co.uk</a> &nbsp;|&nbsp; ");
                                sbMaiBody.Append("<a href=\"https://www.Faresmatch.co.uk\" target=\"_blank\" style=\"text-decoration: none; color:#666;\">viman.co.uk</a> &nbsp;|&nbsp; ");
                                sbMaiBody.Append("<a href=\"https://www.Faresmatch.co.uk/unsubscribe/?key=" + curr_sess + "\" target=\"_blank\" style=\"text-decoration: none; color:#666;\">unsubscribe</a></p></td></tr></table>");
                                //objEmailClass.SendCommonEmail("Subscribe to booking@faresmatch.com", sbMaiBody.ToString());
                            }
                        }
                        catch (Exception ex)
                        {

                        }

                    }

                    if (FormColl["cc_number"] != null)
                    {
                        bookFlights.SagepayDetail = new SagepayDetail()
                        {
                            BookingId = bookFlights.BookingId,
                            TranscationId = bookFlights.TranscationId,
                            CardType = FormColl["cardType"],
                            CardHolderName = FormColl["cc_name"],
                            CardNumber = FormColl["cc_number"],
                            CVV = FormColl["cc_cvv"],
                            ExpiryDate = FormColl["cc_exp"],
                            CryptVal = "",
                            Last4Digits = FormColl["cc_number"].Length == 16 ? FormColl["cc_number"].Substring(12, 4) : string.Empty,
                        };

                        ViewBag.PayResponse = "Inhouse Redirect";

                    }
                    else
                    {
                        // generate sagepayment variable
                        var cryptValue = SagepayPaymentHelper.BuildPaymentResponse(JsonConvert.SerializeObject(bookFlights), "flightBooking", bookFlights.TranscationId);

                        if (cryptValue.Equals(""))
                        {
                            ViewBag.PayResponse = "Payment Error";
                        }
                        else
                        {
                            bookFlights.SagepayDetail = new SagepayDetail()
                            {
                                BookingId = bookFlights.BookingId,
                                TranscationId = bookFlights.TranscationId,
                                CryptVal = cryptValue
                            };

                            ViewBag.PayResponse = cryptValue;
                        }
                    }

                    ViewBag.FlightId = bookFlights.TranscationId;

                    // Common.WriteLog("TranscationId :" + ViewBag.FlightId.ToString());
                    InsertBookingDetails(bookFlights, hdnFreeChangeAmt.ToString(), hdnFinalfare.ToString());

                    // booking session expire
                    Session["FlightsBook"] = null;
                    Session["FlightsResult"] = null;
                    Session["BookingID"] = null;
                }
                else
                {
                    ViewBag.PayResponse = "Session Error";
                }

            }
            catch (Exception e)
            {
                ViewBag.PayResponse = "Server Error";
                ViewBag.PayResponseError = e.Message.ToString();
            }

            return View();
        }

        [HttpPost]
        public ActionResult PaymentK(FormCollection FormColl)
        {
            var hdnFreeChangeAmt = string.IsNullOrEmpty(FormColl["hdnFreeChangeAmt"].ToString()) ? 0 : Convert.ToDecimal(FormColl["hdnFreeChangeAmt"]);
            var hdnFinalfare = string.IsNullOrEmpty(FormColl["hdnFinalfare"].ToString()) ? 0 : Convert.ToDecimal(FormColl["hdnFinalfare"]);


            try
            {
                string guid = FormColl["hsearchId"];
                string flightsBooking = String.Empty;
                flightsBooking = System.IO.File.ReadAllText(Server.MapPath(@"~/Content/File/flightsBooking" + guid + ".json"));
                FlightsBooking bookFlights = JsonConvert.DeserializeObject<FlightsBooking>(flightsBooking, new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver(), DateTimeZoneHandling = DateTimeZoneHandling.Local });

                DataTable dtxc = SqlData.Data.SqlHelperData.ExecuteDataset(SqlData.Data.SqlHelperData.ConnectionStringFlightoffice, CommandType.Text, "SELECT TOP 1 SUBSTRING(BookingId,4,6) BookingId FROM FlightsBooking ORDER BY Id DESC").Tables[0];
                string max_id = (int.Parse(dtxc.Rows[0]["BookingId"].ToString()) + 1) + "";
                Session["BookingID"] = "TFG" + max_id.PadLeft(6, '0');


                //bookFlights.BookingId = Common.GetBookingId("VMB");
                bookFlights.BookingId = Session["BookingID"].ToString();

                if (bookFlights != null)
                {
                    bookFlights.TranscationId = Common.GetId();
                    bookFlights.FullName = FormColl["title_1"] + " " + FormColl["fname_1"] + " " + FormColl["lname_1"];
                    bookFlights.Email = FormColl["email"];
                    bookFlights.PhoneNo = FormColl["phone"];
                    bookFlights.IsHotel = (string.IsNullOrEmpty(FormColl["hotel_chk"])) ? "0" : FormColl["hotel_chk"];
                    BagsPrice bagPrice = new BagsPrice();

                    bagPrice.BagsPcs = (string.IsNullOrEmpty(FormColl["hdnBaggagePcs"])) ? "0" : FormColl["hdnBaggagePcs"];
                    bagPrice.BagsPcsPrice = float.Parse(FormColl["hdnBaggagePrice"] == null ? "0" : FormColl["hdnBaggagePrice"]);

                    bookFlights.BagPrice = bagPrice;

                    bookFlights.BookingId = Session["BookingID"].ToString();
                    if (bookFlights != null)
                    {
                        bookFlights.TranscationId = Common.GetId();
                        string str = FormColl["radio_gender_" + 1];
                        string str2 = FormColl["radio_gender"];
                        bookFlights.FullName = FormColl["title_1"] + " " + FormColl["fname_1"] + " " + FormColl["lname_1"];
                        bookFlights.Email = FormColl["email"];
                        bookFlights.PhoneNo = FormColl["phone"];
                        bookFlights.IsHotel = (string.IsNullOrEmpty(FormColl["hotel_chk"])) ? "0" : FormColl["hotel_chk"];

                        bagPrice.BagsPcs = (string.IsNullOrEmpty(FormColl["hdnBaggagePcs"])) ? "0" : FormColl["hdnBaggagePcs"];
                        bagPrice.BagsPcsPrice = float.Parse(FormColl["hdnBaggagePrice"] == null ? "0" : FormColl["hdnBaggagePrice"]);

                        bookFlights.BagPrice = bagPrice;
                        bookFlights.BookerDetail = new BookerDetail()
                        {
                            Title = FormColl["radio_gender_" + 1], //FormColl["title_1"],
                            FirstName = FormColl["fname_1"],
                            LastName = FormColl["lname_1"],
                            Address1 = FormColl["address"],
                            Address2 = "",
                            City = FormColl["city"],
                            Country = FormColl["countryCode"],
                            PostCode = FormColl["postcode"],
                            PhoneNo = FormColl["phone"],
                            Email = FormColl["email"],
                        };
                        int pass_cnt = 0;
                        bookFlights.PassengerDetail = new List<PassengerDetail>();
                        for (int i = 1; i <= bookFlights.FlightsSearch.Adult; i++)
                        {
                            pass_cnt++;
                            string adtP = FormColl["pYear_" + pass_cnt] + "-" + FormColl["pMonth_" + pass_cnt] + "-" + FormColl["pDay_" + pass_cnt];
                            bookFlights.PassengerDetail.Add(new PassengerDetail()
                            {
                                TravelerNo = pass_cnt,
                                PassengerType = PassengerType.Adult,
                                Title = FormColl["radio_gender_" + 1],//FormColl["title_" + pass_cnt],
                                FirstName = FormColl["fname_" + pass_cnt],
                                LastName = FormColl["lname_" + pass_cnt],
                                //DOB = Convert.ToDateTime(dob_str[2] + "-" + dob_str[1] + "-" + dob_str[0]),
                                DOB = Convert.ToDateTime(FormColl["pYear_" + pass_cnt] + "-" + FormColl["pMonth_" + pass_cnt] + "-" + FormColl["pDay_" + pass_cnt]),
                            });
                        }
                        for (int i = 1; i <= bookFlights.FlightsSearch.Child; i++)
                        {
                            pass_cnt++;
                            string[] dob_str = FormColl["dob_" + pass_cnt].Split('-');
                            bookFlights.PassengerDetail.Add(new PassengerDetail()
                            {
                                TravelerNo = pass_cnt,
                                PassengerType = PassengerType.Child,
                                Title = FormColl["radio_gender_" + 1], //FormColl["title_" + pass_cnt],
                                FirstName = FormColl["fname_" + pass_cnt],
                                LastName = FormColl["lname_" + pass_cnt],
                                //DOB = Convert.ToDateTime(dob_str[2] + "-" + dob_str[1] + "-" + dob_str[0]),
                                DOB = Convert.ToDateTime(FormColl["pYear_" + pass_cnt] + "-" + FormColl["pMonth_" + pass_cnt] + "-" + FormColl["pDay_" + pass_cnt]),
                            });
                        }
                        for (int i = 1; i <= bookFlights.FlightsSearch.Infant; i++)
                        {
                            pass_cnt++;
                            string[] dob_str = FormColl["dob_" + pass_cnt].Split('-');
                            bookFlights.PassengerDetail.Add(new PassengerDetail()
                            {
                                TravelerNo = pass_cnt,
                                PassengerType = PassengerType.Infant,
                                Title = FormColl["radio_gender_" + 1],//FormColl["title_" + pass_cnt],
                                FirstName = FormColl["fname_" + pass_cnt],
                                LastName = FormColl["lname_" + pass_cnt],
                                //DOB = Convert.ToDateTime(dob_str[2] + "-" + dob_str[1] + "-" + dob_str[0]),
                                DOB = Convert.ToDateTime(FormColl["pYear_" + pass_cnt] + "-" + FormColl["pMonth_" + pass_cnt] + "-" + FormColl["pDay_" + pass_cnt]),
                            });
                        }

                        if (FormColl["cc_number"] != null)
                        {
                            bookFlights.SagepayDetail = new SagepayDetail()
                            {
                                BookingId = bookFlights.BookingId,
                                TranscationId = bookFlights.TranscationId,
                                CardType = FormColl["cardType"],
                                CardHolderName = FormColl["cc_name"],
                                CardNumber = FormColl["cc_number"],
                                CVV = FormColl["cc_cvv"],
                                ExpiryDate = FormColl["cc_exp"],
                                CryptVal = "",
                                Last4Digits = FormColl["cc_number"].Length == 16 ? FormColl["cc_number"].Substring(12, 4) : string.Empty,
                            };

                            ViewBag.PayResponse = "Inhouse Redirect";

                        }
                        else
                        {
                            // generate sagepayment variable
                            var cryptValue = SagepayPaymentHelper.BuildPaymentResponse(JsonConvert.SerializeObject(bookFlights), "flightBooking", bookFlights.TranscationId);

                            if (cryptValue.Equals(""))
                            {
                                ViewBag.PayResponse = "Payment Error";
                            }
                            else
                            {
                                bookFlights.SagepayDetail = new SagepayDetail()
                                {
                                    BookingId = bookFlights.BookingId,
                                    TranscationId = bookFlights.TranscationId,
                                    CryptVal = cryptValue
                                };

                                ViewBag.PayResponse = cryptValue;
                            }
                        }

                        ViewBag.FlightId = bookFlights.TranscationId;

                        // Common.WriteLog("TranscationId :" + ViewBag.FlightId.ToString());
                        InsertBookingDetails(bookFlights, hdnFreeChangeAmt.ToString(), hdnFinalfare.ToString());



                        // ViewBag.Amt = hdnFinalfare.ToString();

                        //string[] Amt = hdnFinalfare.ToString().Split('.');
                        //if (Amt.Length > 1)
                        //{
                        //    string MainAmt = Amt[0] + Amt[1];
                        //    ViewBag.Amt = MainAmt;
                        //}
                        //else
                        //{
                        //    ViewBag.Amt = hdnFinalfare.ToString();
                        //}

                        //ViewBag.PhNo = FormColl["phone"];
                        //ViewBag.PostCode = FormColl["postcode"];
                        //ViewBag.Address = FormColl["address"];
                        //ViewBag.email = FormColl["email"];
                        //DataTable dtxc = SqlData.Data.SqlHelperData.ExecuteDataset(SqlData.Data.SqlHelperData.ConnectionString, CommandType.Text, "select SUBSTRING(PaymentId,2,130) PaymentId from PaymentDetail order by id desc").Tables[0];
                        //int PayId = 0;
                        //PayId = Convert.ToInt32(dtxc.Rows[0]["PaymentId"].ToString()) + 1;
                        //ViewBag.PaymentId = "K" + PayId.ToString();
                        //// Country = FormColl["countryCode"],
                        //string sqlqq = "INSERT INTO PaymentDetail(PaymentId,Amount,date) VALUES('" + ViewBag.PaymentId + "'," + ViewBag.Amt + ",GETDATE())";
                        //int ckk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionString, CommandType.Text, sqlqq);


                        // booking session expire
                        //Session["FlightsBook"] = null;
                        //Session["FlightsResult"] = null;
                        //Session["BookingID"] = null;


                        return Redirect("/flight/CardK?bRef=" + bookFlights.TranscationId);
                        //if (sagePayFlag)
                        //    return Redirect("/flight/Card?bRef=" + bookFlights.TranscationId);
                        //else
                        //    return Redirect("/flight/cancel?ref=" + bookFlights.TranscationId);
                    }
                    else
                    {
                        ViewBag.PayResponse = "Session Error";
                    }
                }
                else
                {
                    ViewBag.PayResponse = "Session Error";
                }
            }
            catch (Exception e)
            {
                ViewBag.PayResponse = "Server Error";
                ViewBag.PayResponseError = e.Message.ToString();
            }

            return View();
        }



        public int InsertBookingDetails(FlightsBooking bookFlights, string hdnFreeChangeAmt, string hdnFinalfare)
        {

            bookFlights.PNRNo = "";
            bookFlights.WorldResponse = "";
            SqlParameter[] commandParameters = new SqlParameter[30];
            commandParameters[0] = new SqlParameter("@bookingid", SqlDbType.VarChar, 50) { Value = bookFlights.BookingId };
            commandParameters[1] = new SqlParameter("@searchid", SqlDbType.VarChar, 50) { Value = bookFlights.SearchId };
            commandParameters[2] = new SqlParameter("@transcationid", SqlDbType.VarChar, 50) { Value = bookFlights.TranscationId };
            commandParameters[3] = new SqlParameter("@pnrno", SqlDbType.VarChar, 50) { Value = bookFlights.PNRNo };
            commandParameters[4] = new SqlParameter("@fullname", SqlDbType.VarChar, 50) { Value = bookFlights.FullName };
            commandParameters[5] = new SqlParameter("@email", SqlDbType.VarChar, 50) { Value = bookFlights.Email };
            commandParameters[6] = new SqlParameter("@phoneno", SqlDbType.VarChar, 50) { Value = bookFlights.PhoneNo };
            commandParameters[7] = new SqlParameter("@flightssearch", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.FlightsSearch) };
            commandParameters[8] = new SqlParameter("@flights", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.Flights) };
            commandParameters[9] = new SqlParameter("@bookerdetail", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.BookerDetail) };
            commandParameters[10] = new SqlParameter("@passengerdetail", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.PassengerDetail) };
            commandParameters[11] = new SqlParameter("@paymentdetail", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.PaymentDetail) };
            commandParameters[12] = new SqlParameter("@sagepaydetail", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.SagepayDetail) };
            commandParameters[13] = new SqlParameter("@sitecode", SqlDbType.VarChar, 50) { Value = bookFlights.SiteCode == "VIMAN" ? "Faresmatch" : "Faresmatch" };
            commandParameters[14] = new SqlParameter("@sourcemedia", SqlDbType.VarChar, 50) { Value = bookFlights.SourceMedia == "VIMAN" ? "Faresmatch" : bookFlights.SourceMedia };
            commandParameters[15] = new SqlParameter("@flightsfare", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.FlightsFare) };
            commandParameters[16] = new SqlParameter("@paymentstatus", SqlDbType.VarChar, 50) { Value = "unpaid" };
            commandParameters[17] = new SqlParameter("@worldresponse", SqlDbType.VarChar) { Value = bookFlights.WorldResponse };
            commandParameters[18] = new SqlParameter("@ishotel", SqlDbType.Int) { Value = int.Parse(bookFlights.IsHotel) };
            commandParameters[19] = new SqlParameter("@ip", SqlDbType.VarChar, 50) { Value = Common.GetLocalIP() };
            commandParameters[20] = new SqlParameter("@status", SqlDbType.VarChar, 50) { Value = "new" };
            commandParameters[21] = new SqlParameter("@timestamp", SqlDbType.DateTime) { Value = DateTime.Now };
            commandParameters[22] = new SqlParameter("@depdate", SqlDbType.Date) { Value = bookFlights.FlightsSearch.DepDate };
            commandParameters[23] = new SqlParameter("@retdate", SqlDbType.Date) { Value = bookFlights.FlightsSearch.RetDate };
            commandParameters[24] = new SqlParameter("@deeplink", SqlDbType.VarChar) { Value = bookFlights.Flights.DeepLink };
            commandParameters[25] = new SqlParameter("@BagsPrice", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.BagPrice) };
            commandParameters[26] = new SqlParameter("@FreeChangeAmt", SqlDbType.Decimal) { Value = JsonConvert.SerializeObject(Convert.ToDecimal(hdnFreeChangeAmt)) };
            commandParameters[27] = new SqlParameter("@FinalTotalAmt", SqlDbType.Decimal) { Value = JsonConvert.SerializeObject(Convert.ToDecimal(hdnFinalfare)) };

            commandParameters[28] = new SqlParameter("@FromCity", SqlDbType.VarChar, 50) { Value = bookFlights.FlightsSearch.From.CityCode };
            commandParameters[29] = new SqlParameter("@ToCity", SqlDbType.VarChar, 50) { Value = bookFlights.FlightsSearch.To.CityCode };

            // DataSet ds = SqlHelper.ExecuteDataset("INSERT INTO FlightsBooking(BookingId,SearchId,TranscationId,PNRNo,FullName,Email,PhoneNo,FlightsSearch,DepDate,RetDate,Flights,BookerDetail,PassengerDetail,PaymentDetail,SagepayDetail,SiteCode,SourceMedia,FlightsFare,PaymentStatus,WorldResponse,IsHotel,Ip,Status,Timestamp,DeepLink,BagsPrice,FreeChangeAmt,FinalTotalAmt) VALUES(@bookingid,@searchid,@transcationid,@pnrno,@fullname,@email,@phoneno,@flightssearch,@depdate,@retdate,@flights,@bookerdetail,@passengerdetail,@paymentdetail,@sagepaydetail,@sitecode,@sourcemedia,@flightsfare,@paymentstatus,@worldresponse,@ishotel,@ip,@status,@timestamp,@deeplink,@BagsPrice,@FreeChangeAmt,@FinalTotalAmt) SELECT SCOPE_IDENTITY()", commandParameters);
            string SqlQuery = "INSERT INTO FlightsBooking(BookingId, SearchId, TranscationId, PNRNo, FullName, Email, PhoneNo, FlightsSearch, DepDate, RetDate, Flights, BookerDetail, PassengerDetail, PaymentDetail, SagepayDetail, SiteCode, SourceMedia, FlightsFare, PaymentStatus, WorldResponse, IsHotel, Ip, Status, Timestamp, DeepLink, BagsPrice, FreeChangeAmt, FinalTotalAmt,FromCity,ToCity) VALUES(@bookingid, @searchid, @transcationid, null, @fullname, @email, @phoneno, @flightssearch, @depdate, @retdate, @flights, @bookerdetail, @passengerdetail, @paymentdetail, @sagepaydetail, @sitecode, @sourcemedia, @flightsfare, @paymentstatus, @worldresponse, @ishotel, @ip, @status, @timestamp, @deeplink, @BagsPrice, @FreeChangeAmt, @FinalTotalAmt,@FromCity,@ToCity)";
            DataTable dt = SqlHelperData.ExecuteDataset(SqlHelperData.ConnectionString, CommandType.Text, "SELECT BookingId From FlightsBooking where BookingId='" + bookFlights.BookingId + "' ").Tables[0];
            if (dt.Rows.Count > 0)
            {//update entry
                SqlQuery = "Update FlightsBooking SET BookingId=@bookingid, SearchId=@searchid, TranscationId=@transcationid, PNRNo=null, FullName=@fullname, Email=@email, PhoneNo=@phoneno, FlightsSearch=@flightssearch, DepDate=@depdate, RetDate=@retdate, Flights=@flights, BookerDetail=@bookerdetail, PassengerDetail=@passengerdetail, PaymentDetail=@paymentdetail, SagepayDetail=@sagepaydetail, SiteCode=@sitecode, SourceMedia=@sourcemedia, FlightsFare=@flightsfare, PaymentStatus=@paymentstatus, WorldResponse=@worldresponse, IsHotel=@ishotel, Ip=@ip, Status=@status, Timestamp=@timestamp, DeepLink=@deeplink, BagsPrice=@BagsPrice, FreeChangeAmt=@FreeChangeAmt, FinalTotalAmt=@FinalTotalAmt,FromCity=@FromCity,ToCity=@ToCity WHERE BookingID=@bookingid";
                //SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionString, CommandType.Text, "DELETE From FlightsBooking where BookingId='" + bookFlights.BookingId + "' ");
            }
            //delete booking alert
            SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionString, CommandType.Text, "delete from BookingAlert where Searchid='" + bookFlights.SearchId + "'");

            int chk = 0;//SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionStringFlightoffice, CommandType.Text, SqlQuery, commandParameters);
            //Common.WriteLog("Insertbooking", "BOOKONG");
            try
            {
                chk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionStringFlightoffice, CommandType.Text, SqlQuery, commandParameters);
            }
            catch (Exception ex)
            {
                //Common.WriteLog("Insertbooking", ex.ToString());
            }
            Notification(bookFlights.TranscationId);
            //DataTable dt1 = SqlHelper.ExecuteDataset(SqlQuery, commandParameters).Tables[0];

            //if (dt.Rows.Count > 0)
            //{
            //    chk = 1;
            //}
            //EmailClass objEmailClass = new EmailClass();
            //string ReturnDate = "";
            //objEmailClass.MailTo = Common.WebsiteCC;
            //string Source = Session["SourceMedia"].ToString();
            //if (Source == "")
            //{
            //    Source = "JETCOST";
            //}
            //StringBuilder sbMaiBody = new StringBuilder();
            //sbMaiBody.Append("Booking Alert,<br/><br/>");
            //sbMaiBody.Append("<b>Flight</b> : " + bookFlights.FlightsSearch.From.CityName + " to " + bookFlights.FlightsSearch.To.CityName + "<br/>");
            //sbMaiBody.Append("Departure Date   : " + bookFlights.FlightsSearch.DepDate.ToString("dd/MM/yyyy") + "<br/>");
            //if (bookFlights.FlightsSearch.FlightWay == FlightWay.RoundTrip)
            //{
            //    sbMaiBody.Append("Return Date   : " + bookFlights.FlightsSearch.RetDate.ToString("dd/MM/yyyy") + "<br/><br/><br/>");
            //    ReturnDate = bookFlights.FlightsSearch.RetDate.ToString("dd/MM/yyyy");
            //}
            //sbMaiBody.Append("Name : " + bookFlights.FullName + "<br/>");
            //sbMaiBody.Append("Phone      : " + bookFlights.PhoneNo + "<br/>");
            //sbMaiBody.Append("Email      : " + bookFlights.Email + "<br/>");
            //sbMaiBody.Append("IP      : " + Common.GetLocalIP() + "<br/>");
            //sbMaiBody.Append("Source Media  : " + Source + "<br/>");
            //sbMaiBody.Append("<br/>Many Thanks & Regards,<br/><br/>VIMAN <br/>Website: www.viman.co.uk <br/>Tel.: 0203 745 4455 <br/>");
            ////objEmailClass.SendCommonEmail("Reservation alert from viman.co.uk", sbMaiBody.ToString());
            //string sqlqq = "INSERT INTO BookingAlert(Flight,DepartureDate,ReturnDate,Name,Phone,Email,IP,SourceMedia,AlertFor,CreateDate) VALUES('" + bookFlights.FlightsSearch.From.CityName + " to " + bookFlights.FlightsSearch.To.CityName + "','" + bookFlights.FlightsSearch.DepDate.ToString("dd/MM/yyyy") + "','" + ReturnDate + "','" + bookFlights.FullName + "','" + bookFlights.PhoneNo + "','" + bookFlights.Email + "','" + Common.GetLocalIP() + "','" + Session["SourceMedia"] + "','Viman',GETDATE())";
            //int ckk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionStringFlightoffice, CommandType.Text, sqlqq);
            //string msg = Common.SendEmailNew("Lakshman@flightoffice.co.uk", "Viman Booking Alert", sbMaiBody.ToString());
            //Common.SendEmailNew("amit@viman.co.uk", "Viman Booking Alert", sbMaiBody.ToString());
            //Common.SendEmailNew("matthew@flightoffice.co.uk", "Viman Booking Alert", sbMaiBody.ToString());
            //Common.SendEmailNew("arjun@flightoffice.co.uk", "Viman Booking Alert", sbMaiBody.ToString());
            //Common.SendEmailNew("stella@flightoffice.co.uk", "Viman Booking Alert", sbMaiBody.ToString());

            return chk;

        }


        public int UpdateBookingDetails(FlightsBooking bookFlights, string hdnFreeChangeAmt, string hdnFinalfare)
        {

            bookFlights.PNRNo = "";
            bookFlights.WorldResponse = "";
            SqlParameter[] commandParameters = new SqlParameter[4];
            commandParameters[0] = new SqlParameter("@bookingid", SqlDbType.VarChar, 50) { Value = bookFlights.BookingId };
            commandParameters[1] = new SqlParameter("@searchid", SqlDbType.VarChar, 50) { Value = bookFlights.SearchId };
            commandParameters[2] = new SqlParameter("@transcationid", SqlDbType.VarChar, 50) { Value = bookFlights.TranscationId };
            commandParameters[3] = new SqlParameter("@sagepaydetail", SqlDbType.VarChar) { Value = JsonConvert.SerializeObject(bookFlights.SagepayDetail) };

            DataTable dt = SqlHelperData.ExecuteDataset(SqlHelperData.ConnectionString, CommandType.Text, "SELECT BookingId From FlightsBooking where BookingId='" + bookFlights.BookingId + "' ").Tables[0];

            string SqlQuery = "";
            if (dt.Rows.Count > 0)
            {//update entry
                SqlQuery = "Update FlightsBooking SET SagepayDetail='" + JsonConvert.SerializeObject(bookFlights.SagepayDetail) + "' WHERE BookingID='" + bookFlights.BookingId + "' and SearchId='" + bookFlights.SearchId + "'";

            }
            int chk = 0;//SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionStringFlightoffice, CommandType.Text, SqlQuery, commandParameters);            
            try
            {
                chk = SqlHelperData.ExecuteNonQuery(SqlHelperData.ConnectionStringFlightoffice, CommandType.Text, SqlQuery, commandParameters);
            }
            catch (Exception ex)
            {
                //Common.WriteLog("Insertbooking", ex.ToString());
            }
            return chk;

        }


        public ActionResult Notification(string sds)
        {
            string bookingRef = "";
            try
            {
                string paymentPath = "", paymentMode = "";
                FlightsBooking flightsBooking = null;
                bool sagePayFlag = true;
                BagsPrice bogsPrice1 = new BagsPrice();
                if (sds != null)//if (Request.QueryString["ref"] != null)
                {
                    paymentMode = "paid";
                    bookingRef = sds;//Request.QueryString["ref"];

                    flightsBooking = Common.GetFlightByIdFlightoffice(bookingRef);  //Common.GetFlightById(bookingRef);
                    bogsPrice1.BagsPcs = flightsBooking.BagPrice.BagsPcs;
                    bogsPrice1.BagsPcsPrice = flightsBooking.BagPrice.BagsPcsPrice;
                }
                else
                {
                    var paymentResponse = SagepayPaymentHelper.GetPaymentResponse(Request.QueryString["crypt"]);
                    string[] paymentStatus = paymentResponse.StatusDetail.Split(':');
                    bookingRef = paymentResponse.VendorTxCode;

                    flightsBooking = Common.GetFlightByIdFlightoffice(bookingRef); //Common.GetFlightById(bookingRef);

                    if (!paymentStatus[0].Trim().Equals("0000"))
                    {
                        sagePayFlag = false;
                    }
                    else
                    {
                        paymentMode = "paid";

                        flightsBooking.SagepayDetail = new SagepayDetail()
                        {
                            VendorTxCode = paymentResponse.VendorTxCode,
                            BankAuthCode = paymentResponse.BankAuthCode,
                            CardType = paymentResponse.CardType.ToString(),
                            CVV = paymentResponse.Cavv,
                            Last4Digits = paymentResponse.Last4Digits,
                            ExpiryDate = paymentResponse.ExpiryDate,
                            TxAuthNo = paymentResponse.TxAuthNo.ToString(),
                            VpsTxId = paymentResponse.VpsTxId,
                            BookingId = flightsBooking.SagepayDetail.BookingId,
                            TranscationId = flightsBooking.SagepayDetail.TranscationId,
                            CryptVal = flightsBooking.SagepayDetail.CryptVal
                        };
                    }
                }

                // send email
                string ticketBody = "<table cellpadding=\"5px\" width=\"100%\"><tr><td style=\"width:50%;\"><img src=\"https://faresmatch.com/fmimages/logo.png\" width=\"150px\" /></td><td style=\"text-align:right;\" width=\"50%\">26 Tackford Road,<br/> COVENTRY CV6 7HT, England <br/><b>Phone:</b> <a href=\"tel:+18009183039\" style=\"color:#FF6B35;\">+1 8009183039</a><br/><b>Email:</b><a href=\"mailto:booking@faresmatch.com\" style=\"color:#FF6B35;\">booking@faresmatch.com</a></td></tr></table>";
                ticketBody += "<table cellpadding=\"5px\" width=\"100%\" style=\"background: #065471;width:100%;padding: 5px 0;border-radius: 5px;margin: 5px 0;\"><tr><td style=\"text-align:center; color:#fff;\">Faresmatch</td><td style=\"text-align:center; color:#fff;\">Faresmatch</td><td style=\"text-align:center; color:#fff;\">Faresmatch</td><td style=\"text-align:center; color:#fff;\">Faresmatch</td><td style=\"text-align:center; color:#fff;\">Faresmatch</td><td style=\"text-align:center; color:#fff;\">Faresmatch</td><td style=\"text-align:center; color:#fff;\">Faresmatch</td></tr></table>";
                ticketBody += "<table cellpadding=\"5px\" width=\"100%\"><tr><td style=\"border:1px solid #999; background-color:#f1f1f1; width:100%;padding: 10px;border-radius: 10px !important;\"><b>Dear " + flightsBooking.BookerDetail.Title + " " + flightsBooking.BookerDetail.FirstName + " " + flightsBooking.BookerDetail.LastName + ",</b><br/><br/> Thank you for booking with Faresmatch.co.uk. Your booking is yet not confirmed due to some dynamic changes in the availability.Please contact our support team on <a href=\"tel:+18009183039\" style=\"color:#FF6B35;\">+1 8009183039</a> for details.Please note that we cannot guarantee the prices shown here until your tickets have been issued, your payment has been cleared and you receive your final booking confirmation email.To confirm the booking please contact one of our team member: <b>Email: <a href=\"mailto:booking@faresmatch.com\" style=\"color:#FF6B35;\">booking@faresmatch.com</a> Tel: <a href=\"tel:+18009183039\" style=\"color:#FF6B35;\">+1 8009183039</a> .</b></td></tr></table>";
                ticketBody += "<table cellpadding=\"5px\" width=\"100%\" style=\"padding: 10px; border-radius: 10px; border: 1px solid #999; background-color:#f1f1f1;margin: 5px 0;\"><tr><td style=\"font-weight:bold;\" width=\"150\">Booking Ref: </td><td>" + flightsBooking.BookingId + "</td><td style=\"font-weight:bold;\">Airline :</td><td>" + flightsBooking.Flights.Airline.Name + "</td></tr><tr><td style=\"font-weight:bold;\">Travel Way :</td><td>" + flightsBooking.FlightsSearch.FlightWay.ToString() + "</td><td style=\"font-weight:bold;\">Cabin :</td><td>" + flightsBooking.FlightsSearch.FlightClass.ToString() + "</td></tr><tr><td style=\"font-weight:bold;\">Departure Date :</td><td>" + flightsBooking.Flights.Outbound[0].DepartureDate.ToString("dd MMM, yyyy HH:mm") + "</td>";
                if (flightsBooking.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                {
                    ticketBody += "<td style=\"font-weight:bold;\">Return Date :</td><td>" + flightsBooking.Flights.Inbound[0].DepartureDate.ToString("dd MMM, yyyy HH:mm") + "</td>";
                }
                ticketBody += "</tr></table>";
                ticketBody += "<table cellpadding=\"5px\" width=\"100%\" style=\"padding: 10px; border-radius: 10px; border: 1px solid #999; background-color:#f1f1f1;\"><tr><td style=\"width:25%;font-weight:bold;\">Passenger</td><td style=\"width:25%;text-align:center; font-weight:bold;\">Qty</td><td style=\"width:25%;text-align:center; font-weight:bold;\">Price</td><td style=\"width:25%;text-align:right; font-weight:bold;\">Total</td></tr><tr><td>Adults</td><td style=\"text-align:center;\">" + flightsBooking.FlightsSearch.Adult + "</td><td style=\"text-align:center;\">" + Common.Currency + (flightsBooking.FlightsFare.AdultFare + flightsBooking.FlightsFare.AdultTax + flightsBooking.FlightsFare.AdultMarkup).ToString("0.00") + "</td><td style=\"text-align:right;\">" + Common.Currency + (flightsBooking.FlightsFare.Adult * (flightsBooking.FlightsFare.AdultFare + flightsBooking.FlightsFare.AdultTax + flightsBooking.FlightsFare.AdultMarkup)).ToString("0.00") + "</td></tr>";
                if (flightsBooking.FlightsSearch.Child > 0)
                {
                    ticketBody += "<tr><td>Childs</td><td style=\"text-align:center;\">" + flightsBooking.FlightsSearch.Child + "</td><td style=\"text-align:center;\">" + Common.Currency + (flightsBooking.FlightsFare.ChildFare + flightsBooking.FlightsFare.ChildTax + flightsBooking.FlightsFare.ChildMarkup).ToString("0.00") + "</td><td style=\"text-align:right;\">" + Common.Currency + (flightsBooking.FlightsFare.Child * (flightsBooking.FlightsFare.ChildFare + flightsBooking.FlightsFare.ChildTax + flightsBooking.FlightsFare.ChildMarkup)).ToString("0.00") + "</td></tr>";
                }
                if (flightsBooking.FlightsSearch.Infant > 0)
                {
                    ticketBody += "<tr><td>Infant</td><td style=\"text-align:center;\">" + flightsBooking.FlightsSearch.Infant + "</td><td style=\"text-align:center;\">" + Common.Currency + (flightsBooking.FlightsFare.InfantFare + flightsBooking.FlightsFare.InfantTax + flightsBooking.FlightsFare.InfantMarkup).ToString("0.00") + "</td><td style=\"text-align:right;\">" + Common.Currency + (flightsBooking.FlightsFare.Infant * (flightsBooking.FlightsFare.InfantFare + flightsBooking.FlightsFare.InfantTax + flightsBooking.FlightsFare.InfantMarkup)).ToString("0.00") + "</td></tr>";
                }
                ticketBody += "<tr><td style=\"font-weight:bold; font-size:16px; padding: 5px 10px; border-radius: 5px 0 0 5px; background:#d7d7d7;\">Total Paid :</td><td style=\"font-weight:bold; font-size:16px;border-radius: 0 5px 5px 0; background:#d7d7d7;text-align:right;padding: 5px 10px;\" colspan=\"3\">" + Common.Currency + ((flightsBooking.FlightsFare.GrandTotal).ToString("0.00")) + "</td></tr></table>";
                ticketBody += "<table cellpadding=\"5px\" width=\"100%\" style=\"margin:5px 0;border:1px solid #999; background-color:#f1f1f1;border-radius: 10px;padding: 10px;margin: 5px 0;\"><tr><td colspan=\"2\" style=\"font-weight:bold; background:#d7d7d7; padding:5px 10px; font-size:18px;border-radius: 5px;\">Passenger Detail</td></tr><tr><th style=\"text-align: left;width: 50%;\">Full Name</th><th style=\"text-align: left;width: 50%;\">Date of Birth</th></tr>";
                foreach (PassengerDetail paxItem in flightsBooking.PassengerDetail)
                {
                    ticketBody += "<tr><td>" + paxItem.Title + " " + paxItem.FirstName + " " + paxItem.LastName + "</td><td>" + paxItem.DOB.ToString("dd-MM-yyyy") + "</td></tr>";
                }
                ticketBody += "</table><table cellpadding=\"5px\" width=\"100%\" style=\"border: 1px solid #999; background-color:#f1f1f1;border-radius: 10px;padding: 10px;\"><tr><td colspan=\"3\" style=\"font-weight:bold; background:#d7d7d7; padding:5px 10px; font-size:18px;border-radius: 5px;\">Contact Details</td></tr><tr><td style=\"font-weight:bold;width:33%;\">Address</td><td style=\"font-weight:bold;width:33%;\">Phone :</td><td style=\"font-weight:bold;width:33%;\">Email :</td></tr><tr><td>" + flightsBooking.BookerDetail.Address1 + ", " + flightsBooking.BookerDetail.City + ", " + flightsBooking.BookerDetail.Country + " - " + flightsBooking.BookerDetail.PostCode + "</td><td>" + flightsBooking.BookerDetail.PhoneNo + "</td><td>" + flightsBooking.BookerDetail.Email + "</td></tr></table>";
                ticketBody += "<table cellpadding=\"5px\" width=\"100%\" style=\"margin: 5px 0;background:#f1f1f1;border: 1px solid #999;padding: 10px;border-radius: 10px;\"><tr><td style=\"font-size:18px; border-bottom:1px dashed #bbb; font-weight:bold;\">OUTBOUND</td><td style=\"border-bottom:1px dashed #bbb;\">" + flightsBooking.Flights.Outbound[0].FromAirport.Code + "<br/> <span style=\"font-size:12px;\">" + flightsBooking.Flights.Outbound[0].FromAirport.CityName + "</span></td><td style=\"border-bottom:1px dashed #bbb; text-align:center;\"><img src=\"https://www.faresmatch.com/Content/images/airplane.png\" width=\"20px\" /></td><td style=\"border-bottom:1px dashed #bbb;text-align:right;\">" + flightsBooking.Flights.Outbound[flightsBooking.Flights.Outbound.Count - 1].ToAirport.Code + " <br/> <span style=\"font-size:12px;\">" + flightsBooking.Flights.Outbound[flightsBooking.Flights.Outbound.Count - 1].ToAirport.CityName + "</span></td><td style=\"border-bottom:1px dashed #bbb;\"></td></tr>";
                ticketBody += "<tr><td style=\"font-size:14px; font-weight:bold;\">" + flightsBooking.Flights.Outbound[0].DepartureDate.ToString("FFF dd MMM, yyyy") + "</td><td></td><td style=\"text-align:center;\"></td><td style=\"text-align:right;\"></td><td style=\"font-size:14px; text-align:right; font-weight:bold;\">Duration: " + (Math.Floor(double.Parse(flightsBooking.Flights.Outbound[flightsBooking.Flights.Outbound.Count - 1].TotalTime) / 60)) + "h " + (double.Parse(flightsBooking.Flights.Outbound[flightsBooking.Flights.Outbound.Count - 1].TotalTime) % 60) + "m </td></tr>";
                int mm = 0;
                foreach (FlightsSegment outSegment in flightsBooking.Flights.Outbound)
                {
                    mm++;
                    if (mm != 1)
                    {
                        double stop_time = double.Parse(Common.GetTime(flightsBooking.Flights.Outbound[mm - 1].DepartureDate, flightsBooking.Flights.Outbound[mm - 2].ArrivalDate) + "");
                        ticketBody += "<tr><td style=\"text-align:center;font-size:12px; border-top:1px dashed #bbb; border-bottom:1px dashed #bbb;\" width=\"100%\" colspan =\"5\"> Stop-Over: " + (Math.Floor(stop_time / 60)) + " Hrs. " + (Math.Floor(stop_time % 60)) + " Mins CHANGE OF PLANE REQUIRED.</td></tr>";
                    }
                    ticketBody += "<tr><td style=\"font-size:14px;\"><img src=\"https://images.kiwi.com/airlines/64x64/" + outSegment.Airline.Code + ".png\" style =\"float:left; padding-right:5px;width: 20px;\" /> " + outSegment.Airline.Code + "-" + outSegment.FlightNo + "<br/>" + outSegment.Airline.Name + ((!string.IsNullOrEmpty(outSegment.OperatingAirline.Code)) ? "<br/>Operated by " + outSegment.OperatingAirline.Name : "") + " </td><td><span style=\"font-size:18px;\">" + outSegment.DepartureDate.ToString("HH:mm") + " " + outSegment.FromAirport.Code + "</span> <br/><span style=\"font-size:9px;\">" + outSegment.DepartureDate.ToString("dd MMM") + " " + outSegment.FromTerminal + " " + outSegment.FromAirport.Name + "</span></td><td style=\"text-align:center;\"></td><td style=\"text-align:right;\"><span style=\"font-size:18px;\">" + outSegment.ArrivalDate.ToString("HH:mm") + " " + outSegment.ToAirport.Code + "</span> <br/><span style=\"font-size:9px;\">" + outSegment.ArrivalDate.ToString("dd MMM") + " " + outSegment.ToTerminal + " " + outSegment.ToAirport.Name + "</span></td><td style=\"font-size:12px;text-align:right;\"><br/><img src=\"https://www.faresmatch.com/Content/images/ticket.png\" width =\"12px\" height =\"12px\" /><span> " + outSegment.CabinClass + " </span></td></tr>";
                }
                ticketBody += "</table>";
                if (flightsBooking.FlightsSearch.FlightWay == FlightWay.RoundTrip)
                {
                    ticketBody += "<table cellpadding=\"5px\" width=\"100%\" style=\"background:#f1f1f1;border: 1px solid #999;padding: 10px;border-radius: 10px;\"><tr><td style=\"font-size:20px; border-bottom:1px dashed #bbb; font-weight:bold;\">INBOUND</td><td style=\"border-bottom:1px dashed #bbb;\">" + flightsBooking.Flights.Inbound[0].FromAirport.Code + "<br/> <span style=\"font-size:12px;\">" + flightsBooking.Flights.Inbound[0].FromAirport.CityName + " </span></td><td style=\"border-bottom:1px dashed #bbb; text-align:center;\"><img src=\"https://www.faresmatch.com/Content/images/airplane.png\" width=\"20px\" /></td><td style=\"border-bottom:1px dashed #bbb;text-align:right;\">" + flightsBooking.Flights.Inbound[flightsBooking.Flights.Inbound.Count - 1].ToAirport.Code + " <br/> <span style=\"font-size:12px;\">" + flightsBooking.Flights.Inbound[flightsBooking.Flights.Inbound.Count - 1].ToAirport.CityName + "</span></td><td style=\"border-bottom:1px dashed #bbb;\"></td></tr>";
                    ticketBody += "<tr><td style=\"font-size:14px; font-weight:bold;\">" + flightsBooking.Flights.Inbound[0].DepartureDate.ToString("FFF dd MMM, yyyy") + "</td><td></td><td style=\"text-align:center;\"></td><td style=\"text-align:right;\"></td><td style=\"font-size:14px; text-align:right; font-weight:bold;\">Duration: " + (Math.Floor(double.Parse(flightsBooking.Flights.Inbound[flightsBooking.Flights.Inbound.Count - 1].TotalTime) / 60)) + "h " + (double.Parse(flightsBooking.Flights.Inbound[flightsBooking.Flights.Inbound.Count - 1].TotalTime) % 60) + "m</td></tr>";
                    int nn = 0;
                    foreach (FlightsSegment inSegment in flightsBooking.Flights.Inbound)
                    {
                        nn++;
                        if (nn != 1)
                        {
                            double stop_time = double.Parse(Common.GetTime(flightsBooking.Flights.Inbound[nn - 1].DepartureDate, flightsBooking.Flights.Inbound[nn - 1].ArrivalDate) + "");
                            ticketBody += "<tr><td style=\"text-align:center;font-size:12px; border-top:1px dashed #bbb; border-bottom:1px dashed #bbb;\" width=\"100%\" colspan=\"5\"> Stop-Over: " + (Math.Floor(stop_time / 60)) + " Hrs. " + (Math.Floor(stop_time % 60)) + " Mins CHANGE OF PLANE REQUIRED.</td></tr>";
                        }
                        ticketBody += "<tr><td style=\"font-size:14px;\"><img src=\"https://images.kiwi.com/airlines/64x64/" + inSegment.Airline.Code + ".png\" style=\"float:left;width:20px; padding-right:5px;\" />" + inSegment.Airline.Code + "-" + inSegment.FlightNo + "<br/>" + inSegment.Airline.Name + ((!string.IsNullOrEmpty(inSegment.OperatingAirline.Code)) ? "<br/>Operated by " + inSegment.OperatingAirline.Name : "") + "</td><td><span style=\"font-size:18px;\">" + inSegment.DepartureDate.ToString("HH:mm") + " " + inSegment.FromAirport.Code + "</span> <br/><span style=\"font-size:9px;\">" + inSegment.DepartureDate.ToString("dd MMM") + " " + inSegment.FromTerminal + " " + inSegment.FromAirport.Name + "</span></td><td style=\"text-align:center;\"></td><td style=\"text-align:right;\"><span style=\"font-size:18px;\">" + inSegment.ArrivalDate.ToString("HH:mm") + " " + inSegment.ToAirport.Code + "</span> <br/><span style=\"font-size:9px;\">" + inSegment.ArrivalDate.ToString("dd MMM") + " " + inSegment.ToTerminal + " " + inSegment.ToAirport.Name + "</span></td><td style=\"font-size:12px;text-align:right;\"><br/><img src=\"" + Common.WebsiteURL + "Content/images/ticket.png\" width=\"12px\" height=\"12px\" /><span>" + inSegment.CabinClass + "</span></td></tr>";
                    }
                    ticketBody += "</table>";
                }

                ticketBody += "<table cellpadding=\"5px\" width=\"100%\" style=\"margin:5px 0;border:1px solid #999; background-color:#f1f1f1;border-radius: 10px;padding: 10px;\"><tr><td style=\"font-weight:bold; background:#d7d7d7; padding:5px 10px; font-size:18px;border-radius: 5px;\" colspan=\"4\">Cabin Baggage</td><td style=\"font-weight:bold; background:#d7d7d7;font-size:18px; padding:5px 10px;border-radius: 5px;\" colspan=\"4\">Checked Baggage</td></tr><tr><th width=\"12.5%\" align=\"left\">Qty</th><th width=\"12.5%\" align=\"left\">Size</th><th width=\"12.5%\" align=\"left\">Weight</th><th width=\"12.5%\" align=\"left\">Cost</th><th width=\"12.5%\" align=\"left\">Qty</th><th width=\"12.5%\" align=\"left\">Size</th><th width=\"12.5%\" align=\"left\">Weight</th><th width=\"12.5%\" align=\"left\">Cost</th></tr><tr><td>1</td><td></td><td>7 Kg</td><td>£0</td><td>" + flightsBooking.BagPrice.BagsPcs + "</td><td></td><td>7 Kg</td><td>£" + flightsBooking.BagPrice.BagsPcsPrice + "</td></tr></table>";
                ticketBody += "<table cellpadding=\"5px\" width=\"100%\" style=\"border:1px solid #999;line-height: 1.7; background-color:#f1f1f1;border-radius: 10px;padding: 10px;\"><tr><td><span style=\"font-weight:bold; font-size:18px; \">Fare Rules</span><br/>By proceeding to book your flights with us, you are agreeing to the following fare rules and conditions. If for any reason you do not agree with any part of the below conditions, you should must not proceed with your booking. By proceeding you are agreeing to these terms of service:<br/>Changes are only permitted in certain specific circumstances and charges will apply. Please contact us if you need a ticket that can be changed so that we can advise you of any applicable fees or charges.<br/>Whilst we will process all bookings as per your requirements, Please bear in mind that airlines can change your flight schedule and departure time at any time prior to your departure.<br/>All fares and most taxes are non-refundable. If you no show for your flight and do not cancel your booking ( 48 hours to 72 hours) before departure then there is no refund.<br/>Tickets are for use of the named person only. They may not be transferred to anyone else and name changes are not permitted.<br/>Passengers need to be at the airport 3 hours prior to the departure as tickets could not be refunded or changed because of a no show at the airport.<br/>Once you have made your booking, you will receive your flight confirmation by E-mail. Please note that this acknowledgement is not your E-Ticket confirmation that will be sent to you later. If you experience any problems with your booking, please do not rebook as this may result in two bookings being made and duplicate payments being taken. Be patient and we will contact you as soon as possible to assist you further.<br/>If for any reason you have not received an acknowledgement email or booking confirmation from us within six hours of booking, please contact our sales team on +18 009183039. Please ensure that you check your junk and spam mailboxes prior to contacting us as emails can end up here depending on your spam filter settings.<br/>For all flights We request that you contact your airline in the local country 72 hours prior to departure and please make sure that your flights departure are on time. We will not be responsible for any costs or inconvenience caused by short notice schedule changes and cancellations.<br/><hr/><br/>Your tickets will be issued and sent by e-mail within 48 hours subject to confirmation of your payment. If you bypassed Verified by Visa authentication additional documentation may be requested to confirm your identity.<br/>Please check that all of the flight and / or accommodation information shown on your itinerary are correct, any errors discovered after departure may carry penalties to be corrected.<br/>The responsibility to ensure that you have the correct and valid travel document along with the necessary visa for your final destination, as well as any transit destinations, is yours; we strongly suggest that you check with the relevant embassy Faresmatch.co.uk can not be held liable for refusal by the airline to board you or any financial loss due to incorrect passport and/or visa documents.<br/>We suggest that you Check-In a minimum of 3 hours prior to departure. On-line check in facilities may be available for your airline, please check in on line where possible as some carriers do charge for airport check in. Always select and pre-pay for checked baggage (if not included) prior to arrival at the airport as additional airport fees may apply. Please refer to the airlines website for further details or contact our customer services.<br/><b>In the event of a schedule change by the airline, we will make every effort to contact you by e-mail or by phone which you have given us on making the booking. Sometimes, it may not be possible to contact you, So, we strongly recommend that you contact your airline locally at your destination 72 hours prior to departure to reconfirm your flight departure time and do provide your local contact for airline to contact you in case of any delays or changes in your flight departure time.</b><br/>To query any of the details on this itinerary/receipt please contact us at booking@faresmatch.com or by phone+1-800-918-3039. If you wish to cancel and apply for a refund please e-mail us at booking@faresmatch.com; all refunds are subject to the terms and conditions as set by your airline and/or hotel.</td></tr></table>";

                string emailSubject = "New flight booking reservation detail Ref:#" + flightsBooking.BookingId;
                Common.SendEmailWithPdf(flightsBooking.Email, emailSubject, ticketBody);

                string adminTicketBody = "Hello admin,<br/><br/><b>New booking detail as below</b><br/><br/><b>Customer Name :</b> " + flightsBooking.FullName + "<br/><b>Booking Info :</b> " + flightsBooking.FlightsSearch.From.Code + " - " + flightsBooking.FlightsSearch.To.Code + ", " + flightsBooking.Flights.Airline.Code + "<br/><b>Payment :</b> " + Common.UcFirst(paymentMode) + "<br/>";
                if (sagePayFlag)
                    return Redirect("/flight/Card?bRef=" + bookingRef);
                else
                    return Redirect("/flight/cancel?ref=" + bookingRef);
            }
            catch (Exception)
            {
                return Redirect("/flight/cancel?ref=" + bookingRef);
            }
        }

        public ActionResult Card(string bRef)
        {
            string bookingRef = bRef;//Request.QueryString["ref"];
            if (!string.IsNullOrEmpty(bookingRef))
            {
                FlightsBooking flightsBooking = Common.GetFlightByIdFlightoffice(bookingRef); //Common.GetFlightById(bookingRef);
                if (flightsBooking.SourceMedia == "TRAVOLIC")
                {
                    string partner_code = "Faresmatch";
                    string redirectID = Session["redirectID"].ToString(); //flightsBooking.FlightsSearch.SearchId;
                    string price = Math.Round(flightsBooking.FlightsFare.GrandTotal, 2).ToString();
                    string currency = "USD";
                    string confirmationId = flightsBooking.BookingId;
                    string ApiURL = @"https://api.travolic.site/tr/flights/" + partner_code + "/pixel/?redirectID=" + redirectID + "&price=" + price + "&currency=" + currency + "&confirmation=" + confirmationId + "";
                    //string ApiURL = @"https://api.travolic.com/tr/flights/" + partner_code + "/pixel/?redirectID=" + redirectID + "&price=" + price + "&currency=" + currency + "&confirmation=" + confirmationId + "";
                    ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                    WebRequest myWebRequest = WebRequest.Create(ApiURL);
                    WebResponse myWebResponse = myWebRequest.GetResponse();
                    Stream ReceiveStream = myWebResponse.GetResponseStream();
                }

                if (flightsBooking.SourceMedia == "FARECOMPARE")
                {
                    string dtt = DateTime.Now.ToString();

                    string partner_code = Session["kayakclickid"].ToString(); //"S2SEXAMPLE";
                    string kayakclickid = Session["kayakclickid"].ToString(); //flightsBooking.FlightsSearch.SearchId;
                    string price = Math.Round(flightsBooking.FlightsFare.GrandTotal, 2).ToString();

                    string prc = Math.Round(flightsBooking.FlightsFare.GrandTotal * 10 / 100, 2).ToString();
                    string currency = "USD";
                    string confirmationId = flightsBooking.BookingId;

                    //string ApiURL = "https://www.kayak.com/s/s2s/confirm?" + "partnercode=" + partner_code + "&bookingid=" + confirmationId + "&bookedon=2023-10-10T19:20:30+01:00" + "&price=" + price + "&currency=USD" + "&kayakcommission=" + prc + "&commissioncurrency=USD" + "&kayakclickid=" + kayakclickid + "&bookingtype=flight";

                    DateTime bookigdt = DateTime.Now.Date;

                    string ApiURL = "https://www.kayak.com/s/s2s/confirm?" + "partnercode=" + partner_code + "&bookingid=" + confirmationId + "&bookedon=" + bookigdt + "&price=" + price + "&currency=USD" + "&kayakcommission=" + prc + "&commissioncurrency=USD" + "&kayakclickid=" + kayakclickid + "&bookingtype=flight";
                    ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                    WebRequest myWebRequest = WebRequest.Create(ApiURL);
                    WebResponse myWebResponse = myWebRequest.GetResponse();
                    Stream ReceiveStream = myWebResponse.GetResponseStream();
                }

                ViewBag.flights = flightsBooking.Flights;
                ViewBag.flightSearch = flightsBooking.FlightsSearch;

                return View(flightsBooking);
            }
            else
            {
                return Redirect("/");
            }
        }

        public ActionResult CardK(string bRef)
        {
            string bookingRef = bRef;//Request.QueryString["ref"];
            if (!string.IsNullOrEmpty(bookingRef))
            {
                FlightsBooking flightsBooking = Common.GetFlightByIdFlightoffice(bookingRef); //Common.GetFlightById(bookingRef);
                if (flightsBooking.SourceMedia == "TRAVOLIC")
                {
                    string partner_code = "Faresmatch";
                    string redirectID = Session["redirectID"].ToString(); //flightsBooking.FlightsSearch.SearchId;
                    string price = Math.Round(flightsBooking.FlightsFare.GrandTotal, 2).ToString();
                    string currency = "USD";
                    string confirmationId = flightsBooking.BookingId;
                    string ApiURL = @"https://api.travolic.site/tr/flights/" + partner_code + "/pixel/?redirectID=" + redirectID + "&price=" + price + "&currency=" + currency + "&confirmation=" + confirmationId + "";
                    //string ApiURL = @"https://api.travolic.com/tr/flights/" + partner_code + "/pixel/?redirectID=" + redirectID + "&price=" + price + "&currency=" + currency + "&confirmation=" + confirmationId + "";
                    ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                    WebRequest myWebRequest = WebRequest.Create(ApiURL);
                    WebResponse myWebResponse = myWebRequest.GetResponse();
                    Stream ReceiveStream = myWebResponse.GetResponseStream();
                }

                if (flightsBooking.SourceMedia == "FARECOMPARE")
                {
                    string dtt = DateTime.Now.ToString();

                    string str = Session["kayakclickid"].ToString();

                    string partner_code = Session["kayakclickid"].ToString(); //"S2SEXAMPLE";
                    string kayakclickid = Session["kayakclickid"].ToString(); //flightsBooking.FlightsSearch.SearchId;
                    string price = Math.Round(flightsBooking.FlightsFare.GrandTotal, 2).ToString();
                    string prc = Math.Round(flightsBooking.FlightsFare.GrandTotal * 10 / 100, 2).ToString();
                    string currency = "USD";
                    string confirmationId = flightsBooking.BookingId;
                    //string ApiURL = "https://www.kayak.com/s/s2s/confirm?" + "partnercode=" + partner_code + "&bookingid=" + confirmationId + "&bookedon=2023-10-10T19:20:30+01:00" + "&price=" + price + "&currency=USD" + "&kayakcommission=" + prc + "&commissioncurrency=USD" + "&kayakclickid=" + kayakclickid + "&bookingtype=flight";

                    DateTime bookigdt = DateTime.Now.Date;
                    string ApiURL = "https://www.kayak.com/s/s2s/confirm?" + "partnercode=" + partner_code + "&bookingid=" + confirmationId + "&bookedon=" + bookigdt + "&price=" + price + "&currency=USD" + "&kayakcommission=" + prc + "&commissioncurrency=USD" + "&kayakclickid=" + kayakclickid + "&bookingtype=flight";
                    ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                    WebRequest myWebRequest = WebRequest.Create(ApiURL);
                    WebResponse myWebResponse = myWebRequest.GetResponse();
                    Stream ReceiveStream = myWebResponse.GetResponseStream();
                }

                ViewBag.flights = flightsBooking.Flights;
                ViewBag.flightSearch = flightsBooking.FlightsSearch;

                return View(flightsBooking);
            }
            else
            {
                return Redirect("/");
            }
        }

        public ActionResult Confirm()
        {
            string bookingRef = Request.QueryString["ref"];
            if (!string.IsNullOrEmpty(bookingRef))
            {
                FlightsBooking flightsBooking = Common.GetFlightByIdFlightoffice(bookingRef); //Common.GetFlightById(bookingRef);
                if (flightsBooking.SourceMedia == "TRAVOLIC")
                {
                    string partner_code = "Faresmatch";
                    string redirectID = Session["redirectID"].ToString(); //flightsBooking.FlightsSearch.SearchId;
                    string price = Math.Round(flightsBooking.FlightsFare.GrandTotal, 2).ToString();
                    string currency = "USD";
                    string confirmationId = flightsBooking.BookingId;
                    string ApiURL = @"https://api.travolic.site/tr/flights/" + partner_code + "/pixel/?redirectID=" + redirectID + "&price=" + price + "&currency=" + currency + "&confirmation=" + confirmationId + "";
                    //string ApiURL = @"https://api.travolic.com/tr/flights/" + partner_code + "/pixel/?redirectID=" + redirectID + "&price=" + price + "&currency=" + currency + "&confirmation=" + confirmationId + "";
                    ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                    WebRequest myWebRequest = WebRequest.Create(ApiURL);
                    WebResponse myWebResponse = myWebRequest.GetResponse();
                    Stream ReceiveStream = myWebResponse.GetResponseStream();
                }

                if (flightsBooking.SourceMedia == "FARECOMPARE")
                {
                    string dtt = DateTime.Now.ToString();

                    string partner_code = Session["kayakclickid"].ToString(); //"S2SEXAMPLE";
                    string kayakclickid = Session["kayakclickid"].ToString(); //flightsBooking.FlightsSearch.SearchId;
                    string price = Math.Round(flightsBooking.FlightsFare.GrandTotal, 2).ToString();

                    string prc = Math.Round(flightsBooking.FlightsFare.GrandTotal * 10 / 100, 2).ToString();
                    string currency = "USD";
                    string confirmationId = flightsBooking.BookingId;

                    //string ApiURL = "https://www.kayak.com/s/s2s/confirm?" + "partnercode=" + partner_code + "&bookingid=" + confirmationId + "&bookedon=2023-10-10T19:20:30+01:00" + "&price=" + price + "&currency=USD" + "&kayakcommission=" + prc + "&commissioncurrency=USD" + "&kayakclickid=" + kayakclickid + "&bookingtype=flight";

                    DateTime bookigdt = DateTime.Now.Date;

                    string ApiURL = "https://www.kayak.com/s/s2s/confirm?" + "partnercode=" + partner_code + "&bookingid=" + confirmationId + "&bookedon=" + bookigdt + "&price=" + price + "&currency=USD" + "&kayakcommission=" + prc + "&commissioncurrency=USD" + "&kayakclickid=" + kayakclickid + "&bookingtype=flight";
                    ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                    WebRequest myWebRequest = WebRequest.Create(ApiURL);
                    WebResponse myWebResponse = myWebRequest.GetResponse();
                    Stream ReceiveStream = myWebResponse.GetResponseStream();
                }

                ViewBag.flights = flightsBooking.Flights;
                ViewBag.flightSearch = flightsBooking.FlightsSearch;

                return View(flightsBooking);
            }
            else
            {
                return Redirect("/");
            }
        }

        public ActionResult ConfirmK()
        {
            string bookingRef = Request.QueryString["Ref"];
            if (!string.IsNullOrEmpty(bookingRef))
            {
                FlightsBooking flightsBooking = Common.GetFlightByIdFlightoffice(bookingRef); //Common.GetFlightById(bookingRef);
                ViewBag.flights = flightsBooking.Flights;
                ViewBag.flightSearch = flightsBooking.FlightsSearch;

                return View(flightsBooking);
            }
            else
            {
                return Redirect("/");
            }
        }
        public ActionResult Cancel()
        {
            string bookingRef = Request.QueryString["ref"];
            if (!string.IsNullOrEmpty(bookingRef))
            {
                FlightsBooking flightsBooking = Common.GetFlightByIdFlightoffice(bookingRef); //Common.GetFlightById(bookingRef);

                return View(flightsBooking);
            }
            else
            {
                return Redirect("/");
            }
        }


        public static void DeleteFiles(HttpServerUtilityBase Server)
        {




            //HttpServerUtilityBase Server;
            string[] files = Directory.GetFiles(Server.MapPath("~/Content/File/"));
            int iCnt = 0;

            foreach (string file in files)
            {
                FileInfo info = new FileInfo(file);
                info.Refresh();
                if (info.LastWriteTime <= DateTime.Now.AddDays(-1))
                {
                    info.Delete();
                    iCnt += 1;
                }

                // WriteLog("Delete File", "Total " + iCnt, "", "");
            }
        }

    }
}