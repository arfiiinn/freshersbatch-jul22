using FootballAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace FootballAssignment.Controllers
{
    public class FootballLeagueController : Controller
    {
        FootballLeagueContext FootballLeagueContextObject = new FootballLeagueContext();

        public ActionResult Details()
        {
            ModelState.Clear();
            return View(FootballLeagueContextObject.Details());
        }

        public ActionResult WinningTeamNames()
        {
            ModelState.Clear();
            return View(FootballLeagueContextObject.DisplayWinningTeamNames());
        }

        public ActionResult TeamNameisJapan()
        {
            ModelState.Clear();
            return View(FootballLeagueContextObject.TeamNameisJapan());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Create(FootballLeague fbl)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    if (FootballLeagueContextObject.AddMatchResult(fbl))
                    {
                        ViewBag.Message = "Match Details Added Successfully";
                        ModelState.Clear();
                    }
                    
                }
                return RedirectToAction("Details");

            }
            catch
            {
                return View();
            }
        }
    }
}