using Newtonsoft.Json;
using ProjetAeroport.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetAeroport.Controllers
{
    public class HomeController : Controller
    {   
        public ActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string Entrant(string jour)
        {

            List<Vol> t = VolDAO.FetchByType("Entrant", jour);
            string json = JsonConvert.SerializeObject(t);

            return json;
        }
        public string Sortant(string jour)
        {

            List<Vol> t = VolDAO.FetchByType("Sortant",jour);
            string json = JsonConvert.SerializeObject(t);

            return json;
        }
        public ActionResult Suivre() {


            return View();

        }
    }
}