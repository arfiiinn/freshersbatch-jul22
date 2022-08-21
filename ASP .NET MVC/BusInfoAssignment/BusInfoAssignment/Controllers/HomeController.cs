using BusInfoAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusInfoAssignment.Controllers
{
    public class HomeController : Controller
    {
        PKRTravelsEntities DBContext = new PKRTravelsEntities();
        public ActionResult Index()
        {
            if (ModelState.IsValid) 
            {
                return View(DBContext.BusInfoes.ToList());
            }
            else
            {
                return View();
            }
            
        }

        public ActionResult AmountGreaterthan450()
        {
            if (ModelState.IsValid)
            {
                var query = DBContext.BusInfoes.Where(x => x.Amount > 450).ToList();
                List<BusInfo> busInfoList = query.AsEnumerable()
                                                 .Select(x=> new BusInfo
                                                 {
                                                   BoardingPoint = x.BoardingPoint,
                                                   TravelDate = x.TravelDate
                                                 }).ToList();
                return View(busInfoList);
            }
            else 
            {
                ViewBag.Message = "Error! Please try again later";
                return RedirectToAction("Index");
            }
            
        }

        public ActionResult Bus_View()
        {
            if (ModelState.IsValid)
            {
                var query = DBContext.BusInfoes.Where(x => x.Rating > 3).ToList();
                var busInfoList = query.AsEnumerable().Select(x=> new BusInfo
                {
                    BusID = x.BusID,
                    BoardingPoint = x.BoardingPoint,
                    Rating = x.Rating
                }).ToList();

                return View(busInfoList);
            }
            else
            {
                ViewBag.Message = "Error! Please try again later";
                return RedirectToAction("Index");
            }
        }

    }
}