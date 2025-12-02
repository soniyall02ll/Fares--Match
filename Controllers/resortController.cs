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
    public class resortController : Controller
    {
        // GET: resort
        public ActionResult Index()
        {
            return View();
        }


        [Route("~/kalahari-resorts/")]
        public ActionResult kalahariresorts()
        {
            return View();
        }


        [Route("~/resorts-world-las-vegas/")]
        public ActionResult resortsworldlasvegas()
        {
            return View();
        }

        [Route("~/camelback-resort/")]
        public ActionResult camelbackresort()
        {
            return View();
        }


        [Route("~/crystal-springs-resort/")]
        public ActionResult crystalspringsresort()
        {
            return View();
        }


        [Route("~/evermore-orlando-resort/")]
        public ActionResult evermoreorlandoresort()
        {
            return View();
        }

        [Route("~/jade-mountain-resort/")]
        public ActionResult jademountainresort()
        {
            return View();
        }

        [Route("~/talking-stick-resort/")]
        public ActionResult talkingstickresort()
        {
            return View();
        }
    }
}