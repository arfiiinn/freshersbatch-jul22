using BusInfoAssignment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusInfoAssignment.Controllers
{
    public class PKRTravelsController : Controller
    {

        PKRTravelsEntities DBContext = new PKRTravelsEntities();
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to PKR Travels";
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create(FormCollection bus)
        {
            if (ModelState.IsValid) { 
            string BoardingPoint = bus["BoardingPoint"];
            DateTime TravelDate = Convert.ToDateTime(bus["TravelDate"]);
            decimal Amount = Convert.ToDecimal(bus["Amount"]);
            int Rating = Convert.ToInt32(bus["Rating"]);

            var query = DBContext.AddBusDetails(BoardingPoint,TravelDate,Amount,Rating);
            if(query >=1)
                {
                    DBContext.SaveChanges();
                    ViewBag.Message = "Data Inserted Succesfully!";
                    ViewBag.Property = "green";
                }

            return View();
            }
            else
            {
                ViewBag.ErrorMessage = "Insertion Unsuccessful!";
                return RedirectToAction("Index");
            }
        }
        public ActionResult BoardingPointMUM()
        {
            if (ModelState.IsValid)
            {
                var query = DBContext.BusInfoes.Where(x => x.BoardingPoint == "MUM").ToList();
                return View(query);
            }
            else
            {
                ViewBag.ErrorMessage = "Error Occurred!";
                return RedirectToAction("Index");
            }
        }
    }
}