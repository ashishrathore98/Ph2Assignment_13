using Assignment13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment13.Controllers
{
    public class CricketController : Controller
    {
        List<Cricket> listCricket = new List<Cricket>()
        {
            new Cricket() {TeamId=1,TeamName="India",NoWc=2},
            new Cricket() {TeamId=2,TeamName="Australia", NoWc=4},
            new Cricket() {TeamId=3,TeamName="West Indies", NoWc = 2},
            new Cricket() {TeamId=4,TeamName="England", NoWc = 1},

};
        // GET: Cricket
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ICC Men's Cricket World Cup Qualifier ";

            ViewBag.noC = listCricket.Count;

            return View(listCricket);
        }


    }
}