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
    public class activityController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [Route("~/big-island-helicopter-tours/")]
        public ActionResult bigislandhelicoptertours()
        {
            return View();
        }


        [Route("~/hawaii-helicopter-tours/")]
        public ActionResult hawaiihelicoptertours()
        {
            return View();
        }


        [Route("~/juneau-helicopter-tours/")]
        public ActionResult juneauhelicoptertours()
        {
            return View();
        }


        [Route("~/niagara-falls-helicopter-tours/")]
        public ActionResult niagarafallshelicoptertours()
        {
            return View();
        }

        [Route("~/branson-helicopter-tours/")]
        public ActionResult bransonhelicoptertours()
        {
            return View();
        }

        [Route("~/orlando-helicopter-tours/")]
        public ActionResult orlandohelicoptertours()
        {
            return View();
        }

        [Route("~/alaska-helicopter-tours/")]
        public ActionResult alaskahelicoptertours()
        {
            return View();
        }


        [Route("~/grand-canyon-helicopter-tours/")]
        public ActionResult grandcanyonhelicoptertours()
        {
            return View();
        }

        [Route("~/maui-helicopter-tours/")]
        public ActionResult mauihelicoptertours()
        {
            return View();
        }


        [Route("~/oahu-helicopter-tours/")]
        public ActionResult oahuhelicoptertours()
        {
            return View();
        }

        [Route("~/kauai-helicopter-tours/")]
        public ActionResult kauaihelicoptertours()
        {
            return View();
        }

        [Route("~/chicago-helicopter-tours/")]
        public ActionResult chicagohelicoptertours()
        {
            return View();
        }

        [Route("~/las-vegas-helicopter-tours/")]
        public ActionResult lasvegashelicoptertours()
        {
            return View();
        }

        [Route("~/new-york-helicopter-tours/")]
        public ActionResult newyorkhelicoptertours()
        {
            return View();
        }


        [Route("~/atlanta-helicopter-tours/")]
        public ActionResult atlantahelicoptertours()
        {
            return View();
        }

        [Route("~/san-diego-helicopter-tours/")]
        public ActionResult sandiegohelicoptertours()
        {
            return View();
        }


        [Route("~/seattle-helicopter-tours/")]
        public ActionResult seattlehelicoptertours()
        {
            return View();
        }

        [Route("~/dallas-helicopter-tours/")]
        public ActionResult dallashelicoptertours()
        {
            return View();
        }

        [Route("~/los-angeles-helicopter-tours/")]
        public ActionResult losangeleshelicoptertours()
        {
            return View();
        }


        [Route("~/boston-helicopter-tours/")]
        public ActionResult bostonhelicoptertours()
        {
            return View();
        }



        [Route("~/honolulu-helicopter-tours/")]
        public ActionResult honoluluhelicoptertours()
        {
            return View();
        }


        [Route("~/manhattan-helicopter-tours/")]
        public ActionResult manhattanhelicoptertours()
        {
            return View();
        }


        [Route("~/miami-helicopter-tours/")]
        public ActionResult miamihelicoptertours()
        {
            return View();
        }


        [Route("~/detroit-helicopter-tours/")]
        public ActionResult detroithelicoptertours()
        {
            return View();
        }


        [Route("~/san-antonio-helicopter-tours/")]
        public ActionResult sanantoniohelicoptertours()
        {
            return View();
        }


        [Route("~/destin-helicopter-tours/")]
        public ActionResult destinhelicoptertours()
        {
            return View();
        }


        [Route("~/hoover-dam-helicopter-tours/")]
        public ActionResult hooverdamhelicoptertours()
        {
            return View();
        }


        [Route("~/nashville-helicopter-tours/")]
        public ActionResult nashvillehelicoptertours()
        {
            return View();
        }

        [Route("~/sedona-helicopter-tours/")]
        public ActionResult sedonahelicoptertours()
        {
            return View();
        }

        [Route("~/kona-helicopter-tours/")]
        public ActionResult konahelicoptertours()
        {
            return View();
        }

        [Route("~/glacier-landing-helicopter-tours/")]
        public ActionResult glacierlandinghelicoptertours()
        {
            return View();
        }

        [Route("~/flynyon-helicopter-tours/")]
        public ActionResult flynyonhelicoptertours()
        {
            return View();
        }

        [Route("~/vegas-to-grand-canyon-helicopter-tours/")]
        public ActionResult vegastograndcanyonhelicoptertours()
        {
            return View();
        }

        [Route("~/san-francisco-helicopter-tours/")]
        public ActionResult sanfranciscohelicoptertours()
        {
            return View();
        }

        [Route("~/mauna-loa-helicopter-tours/")]
        public ActionResult maunaloahelicoptertours()
        {
            return View();
        }

        [Route("~/maverick-helicopter-tours/")]
        public ActionResult maverickhelicoptertours()
        {
            return View();
        }

        [Route("~/myrtle-beach-helicopter-tours/")]
        public ActionResult myrtlebeachhelicoptertours()
        {
            return View();
        }

        [Route("~/napali-coast-helicopter-tours/")]
        public ActionResult napalicoasthelicoptertours()
        {
            return View();
        }

        [Route("~/scenic-helicopter-tours/")]
        public ActionResult scenichelicoptertours()
        {
            return View();
        }


        [Route("~/alamo-helicopter-tours/")]
        public ActionResult alamohelicoptertours()
        {
            return View();
        }


        [Route("~/anchorage-helicopter-tours/")]
        public ActionResult anchoragehelicoptertours()
        {
            return View();
        }


        [Route("~/austin-helicopter-tours/")]
        public ActionResult austinhelicoptertours()
        {
            return View();
        }


        [Route("~/hilo-helicopter-tours/")]
        public ActionResult hilohelicoptertours()
        {
            return View();
        }


        [Route("~/mount-rushmore-helicopter-tours/")]
        public ActionResult mountrushmorehelicoptertours()
        {
            return View();
        }


        [Route("~/blue-hawaiian-helicopter-tours/")]
        public ActionResult bluehawaiianhelicoptertours()
        {
            return View();
        }


        [Route("~/chattanooga-helicopter-tours/")]
        public ActionResult chattanoogahelicoptertours()
        {
            return View();
        }

        [Route("~/gatlinburg-helicopter-tours/")]
        public ActionResult gatlinburghelicoptertours()
        {
            return View();
        }

        [Route("~/maryland-helicopter-tours/")]
        public ActionResult marylandhelicoptertours()
        {
            return View();
        }

        [Route("~/houston-helicopter-tours/")]
        public ActionResult houstonhelicoptertours()
        {
            return View();
        }

        [Route("~/pigeon-forge-helicopter-tours/")]
        public ActionResult pigeonforgehelicoptertours()
        {
            return View();
        }

        [Route("~/newport-helicopter-tours/")]
        public ActionResult newporthelicoptertours()
        {
            return View();
        }

        [Route("~/colorado-helicopter-tours/")]
        public ActionResult coloradohelicoptertours()
        {
            return View();
        }


        [Route("~/charlotte-helicopter-tours/")]
        public ActionResult charlottehelicoptertours()
        {
            return View();
        }

        [Route("~/new-orleans-helicopter-tours/")]
        public ActionResult neworleanshelicoptertours()
        {
            return View();
        }

        [Route("~/dubai-helicopter-tours/")]
        public ActionResult dubaihelicoptertours()
        {
            return View();
        }

        [Route("~/denver-helicopter-tours/")]
        public ActionResult denverhelicoptertours()
        {
            return View();
        }


        [Route("~/kissimmee-helicopter-tours/")]
        public ActionResult kissimmeehelicoptertours()
        {
            return View();
        }

        [Route("~/philadelphia-helicopter-tours/")]
        public ActionResult philadelphiahelicoptertours()
        {
            return View();
        }

        [Route("~/key-west-helicopter-tours/")]
        public ActionResult keywesthelicoptertours()
        {
            return View();
        }

        [Route("~/washington-dc-helicopter-tours/")]
        public ActionResult washingtondchelicoptertours()
        {
            return View();
        }
    }
}