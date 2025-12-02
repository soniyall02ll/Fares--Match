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
    public class BusController : Controller
    {
        // GET: Bus
        public ActionResult Index()
        {
            return View();
        }


        [Route("~/bus-tickets-from-houston-to-dallas/")]
        public ActionResult busticketsfromhoustontodallas()
        {
            return View();
        }

        [Route("~/bus-tickets-to-houston/")]
        public ActionResult busticketstohouston()
        {
            return View();
        }


        [Route("~/bus-tickets-to-indianapolis/")]
        public ActionResult busticketstoindianapolis()
        {
            return View();
        }


        [Route("~/bus-tickets-to-mexico/")]
        public ActionResult busticketstomexico()
        {
            return View();
        }


        [Route("~/bus-tickets-to-new-york/")]
        public ActionResult busticketstonewyork()
        {
            return View();
        }


        [Route("~/bus-tickets-from-boston-to-new-york/")]
        public ActionResult busticketsfrombostontonewyork()
        {
            return View();
        }


        [Route("~/bus-tickets-from-baltimore-to-new-york/")]
        public ActionResult busticketsfrombaltimoretonewyork()
        {
            return View();
        }


        [Route("~/bus-tickets-from-los-angeles-to-las-vegas/")]
        public ActionResult busticketsfromlosangelestolasvegas()
        {
            return View();
        }


        [Route("~/bus-tickets-from-new-york-to-philadelphia/")]
        public ActionResult busticketsfromnewyorktophiladelphia()
        {
            return View();
        }

        [Route("~/bus-tickets-from-new-york-to-atlanta/")]
        public ActionResult busticketsfromnewyorktoatlanta()
        {
            return View();
        }

        [Route("~/bus-tickets-from-new-york-to-atlantic-city/")]
        public ActionResult busticketsfromnewyorktoatlanticcity()
        {
            return View();
        }


        [Route("~/bus-tickets-to-miami/")]
        public ActionResult busticketstomiami()
        {
            return View();
        }


        [Route("~/bus-tickets-to-washington-dc/")]
        public ActionResult busticketstowashingtondc()
        {
            return View();
        }

        [Route("~/bus-tickets-from-houston-to-san-antonio/")]
        public ActionResult busticketsfromhoustontosanantonio()
        {
            return View();
        }

        [Route("~/bus-tickets-to-atlanta/")]
        public ActionResult busticketstoatlanta()
        {
            return View();
        }

        [Route("~/bus-tickets-to-dallas/")]
        public ActionResult busticketstodallas()
        {
            return View();
        }

        [Route("~/bus-tickets-to-vegas/")]
        public ActionResult busticketstovegas()
        {
            return View();
        }

        [Route("~/bus-tickets-to-chicago/")]
        public ActionResult busticketstochicago()
        {
            return View();
        }

        [Route("~/bus-tickets-from-chicago-to-indianapolis/")]
        public ActionResult busticketsfromchicagotoindianapolis()
        {
            return View();
        }

        [Route("~/bus-tickets-from-new-york-to-miami/")]
        public ActionResult busticketsfromnewyorktomiami()
        {
            return View();
        }

        [Route("~/bus-tickets-from-new-york-to-washington-dc/")]
        public ActionResult busticketsfromnewyorktowashingtondc()
        {
            return View();
        }

        [Route("~/bus-tickets-from-orlando-to-miami/")]
        public ActionResult busticketsfromorlandotomiami()
        {
            return View();
        }

        [Route("~/bus-tickets-from-philadelphia-to-washington-dc/")]
        public ActionResult busticketsfromphiladelphiatowashingtondc()
        {
            return View();
        }

        [Route("~/bus-tickets-to-philadelphia/")]
        public ActionResult busticketstophiladelphia()
        {
            return View();
        }
    }
}