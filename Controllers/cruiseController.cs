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
    public class cruiseController : Controller
    {
        // GET: cruise
        public ActionResult Index()
        {
            return View();
        }


        [Route("~/boston-to-bermuda-cruise.aspx/")]
        public ActionResult bostontobermudacruise()
        {
            return View();
        }

        [Route("~/cruises-to-mexico.aspx/")]
        public ActionResult cruisestomexico()
        {
            return View();
        }


        [Route("~/cruises-to-jamaica.aspx/")]
        public ActionResult cruisestojamacia()
        {
            return View();
        }


        [Route("~/cruises-to-puerto-rico.aspx/")]
        public ActionResult cruisestopuertorico()
        {
            return View();
        }


        [Route("~/cruises-to-iceland.aspx/")]
        public ActionResult cruisestoiceland()
        {
            return View();
        }


        [Route("~/cruises-to-virgin-islands.aspx/")]
        public ActionResult cruisestovirginislands()
        {
            return View();
        }


        [Route("~/cruises-from-california-to-hawaii.aspx/")]
        public ActionResult cruisesfromcaliforniatohawaii()
        {
            return View();
        }


        [Route("~/cruises-to-bermuda.aspx/")]
        public ActionResult cruisestobermuda()
        {
            return View();
        }


        [Route("~/royal-caribbean-cruises.aspx/")]
        public ActionResult royalcaribbeancruises()
        {
            return View();
        }


        [Route("~/cruises-to-turks-and-caicos.aspx/")]
        public ActionResult cruisestoturksandcaicos()
        {
            return View();
        }

        [Route("~/cruises-from-baltimore.aspx/")]
        public ActionResult cruisesfrombaltimore()
        {
            return View();
        }


        [Route("~/cruises-to-greece.aspx/")]
        public ActionResult cruisestogreece()
        {
            return View();
        }


        [Route("~/cruises-to-greenland.aspx/")]
        public ActionResult cruisestogreenland()
        {
            return View();
        }


        [Route("~/new-york-to-bermuda-cruise.aspx/")]
        public ActionResult newyorktobermudacruise()
        {
            return View();
        }



        [Route("~/cruises-from-miami-to-bahamas.aspx/")]
        public ActionResult cruisesfrommiamitobahamas()
        {
            return View();
        }


        [Route("~/cruises-from-seattle-to-alaska.aspx/")]
        public ActionResult cruisesfromseattletoalaska()
        {
            return View();
        }


        [Route("~/cruises-to-hawaii.aspx/")]
        public ActionResult cruisestohawaii()
        {
            return View();
        }


        [Route("~/cruises-to-st-thomas.aspx/")]
        public ActionResult cruisestostthomas()
        {
            return View();
        }

        [Route("~/cruises-from-florida-to-bahamas.aspx/")]
        public ActionResult cruisesfromfloridatobahamas()
        {
            return View();
        }


        [Route("~/cruises-to-dominican-republic.aspx/")]
        public ActionResult cruisestodominicanrepublic()
        {
            return View();
        }


        [Route("~/cruises-from-long-beach.aspx/")]
        public ActionResult cruisesfromlongbeach()
        {
            return View();
        }

        [Route("~/cruises-from-norfolk.aspx/")]
        public ActionResult cruisesfromnorfolk()
        {
            return View();
        }

        [Route("~/cruises-from-maui.aspx/")]
        public ActionResult cruisesfrommaui()
        {
            return View();
        }

        [Route("~/cruises-from-port-canaveral.aspx/")]
        public ActionResult cruisesfromportcanaveral()
        {
            return View();
        }

        [Route("~/cruises-from-san-francisco.aspx/")]
        public ActionResult cruisesfromsanfrancisco()
        {
            return View();
        }

        [Route("~/cruises-from-charleston.aspx/")]
        public ActionResult cruisesfromcharleston()
        {
            return View();
        }


        [Route("~/cruises-from-san-diego.aspx/")]
        public ActionResult cruisesfromsandiego()
        {
            return View();
        }

        [Route("~/cruises-from-los-angeles.aspx/")]
        public ActionResult cruisesfromlosangeles()
        {
            return View();
        }


        [Route("~/carnival-vista-cruise-cancellation/")]
        public ActionResult carnivalvistacruisecancellation()
        {
            return View();
        }

        [Route("~/cruises-from-miami/")]
        public ActionResult cruisesfrommiami()
        {
            return View();
        }


        [Route("~/cruises-from-florida/")]
        public ActionResult cruisesfromflorida()
        {
            return View();
        }

        [Route("~/cruises-from-california/")]
        public ActionResult cruisesfromcalifornia()
        {
            return View();
        }

        [Route("~/cruises-from-fort-lauderdale/")]
        public ActionResult cruisesfromfortlauderdale()
        {
            return View();
        }


        [Route("~/cruises-from-tampa/")]
        public ActionResult cruisesfromtampa()
        {
            return View();
        }

        [Route("~/brooklyn-cruise-terminal/")]
        public ActionResult brooklyncruiseterminal()
        {
            return View();
        }


        [Route("~/cruises-from-galveston/")]
        public ActionResult cruisesfromgalveston()
        {
            return View();
        }


        [Route("~/cruises-from-new-york/")]
        public ActionResult cruisesfromnewyork()
        {
            return View();
        }


        [Route("~/manhattan-cruise-terminal/")]
        public ActionResult manhattancruiseterminal()
        {
            return View();
        }

        [Route("~/carnival-cruise-deals/")]
        public ActionResult carnivalcruisedeals()
        {
            return View();
        }


        [Route("~/cruises-from-new-orleans/")]
        public ActionResult cruisesfromneworleans()
        {
            return View();
        }

        [Route("~/alaska-cruise-from-seattle/")]
        public ActionResult alaskacruisefromseattle()
        {
            return View();
        }

        [Route("~/cruises-from-boston/")]
        public ActionResult cruisesfromboston()
        {
            return View();
        }


        [Route("~/holland-america-cruise/")]
        public ActionResult hollandamericacruise()
        {
            return View();
        }


        [Route("~/norwegian-cruise-line-antarctica/")]
        public ActionResult norwegiancruiselineantarctica()
        {
            return View();
        }

        [Route("~/royal-caribbean-alaska-cruise-cancel/")]
        public ActionResult royalcaribbeanalaskacruisecancel()
        {
            return View();
        }

    }
}