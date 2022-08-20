using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FootballAssignment.Models;

namespace FootballAssignment.Controllers
{
    public class FootballLeagueforEFsController : Controller
    {
        private FootballLeagueRepository db = new FootballLeagueRepository();

        // GET: FootballLeagueforEFs
        public ActionResult Index()
        {
            return View(db.FootballLeagueforEFs.ToList());
        }

        // GET: FootballLeagueforEFs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FootballLeagueforEF footballLeagueforEF = db.FootballLeagueforEFs.Find(id);
            if (footballLeagueforEF == null)
            {
                return HttpNotFound();
            }
            return View(footballLeagueforEF);
        }

        // GET: FootballLeagueforEFs/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MatchId,TeamName1,TeamName2,Status,WinningTeam,Points")] FootballLeagueforEF footballLeagueforEF)
        {
            if (ModelState.IsValid)
            {
                db.FootballLeagueforEFs.Add(footballLeagueforEF);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(footballLeagueforEF);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
