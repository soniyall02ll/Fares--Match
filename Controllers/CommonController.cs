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
    public class CommonController : Controller
    {
        // GET: Common
        public ActionResult Aboutus()
        {
            return View();
        }

        public ActionResult Contactus()
        {
            return View();
        }
        public ActionResult Termsconditions()
        {
            return View();
        }
        public ActionResult Privacypolicy()
        {
            return View();
        }
        public ActionResult Cookiepolicy()
        {
            return View();
        }
        public ActionResult Airlinecontacts()
        {
            return View();
        }
        public ActionResult Onlinecheckin()
        {
            return View();
        }

        public ActionResult ErrorPage()
        {
            return View();
        }
        public ActionResult Flights()
        {
            return View();
        }

        public ActionResult Hotels()
        {
            return View();
        }
        public ActionResult Holidayenquiry()
        {
            return View();
        }
    }
}