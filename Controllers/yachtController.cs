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
    public class yachtController : Controller
    {
        // GET: yacht
        public ActionResult Index()
        {
            return View();
        }


        [Route("~/yacht-rental-destin/")]
        public ActionResult yachtrentaldestin()
        {
            return View();
        }

        [Route("~/yacht-rental-detroit/")]
        public ActionResult yachtrentaldetroit()
        {
            return View();
        }


        [Route("~/yacht-rental-miami/")]
        public ActionResult yachtrentalmiami()
        {
            return View();
        }

        [Route("~/yacht-rental-san-diego/")]
        public ActionResult yachtrentalsandiego()
        {
            return View();
        }
    }
}