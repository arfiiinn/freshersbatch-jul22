using FootballDBF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballDBF.Controllers
{
    public class FootballLeagueController : Controller
    {
        FootballLeagueEntities DBContext = new FootballLeagueEntities();
        // GET: FootballLeague
        public ActionResult Index()
        {
            return View(DBContext.FootballLeagues.ToList());
        }

        public ActionResult WinningMatchList()
        { 
            IEnumerable<FootballLeague> query = DBContext.FootballLeagues.ToList().Where(result => result.Status == "Win");
            return View(query); 
        }

    }
}