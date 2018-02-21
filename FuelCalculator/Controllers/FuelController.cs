using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FuelCalculator.BusinessLogic;
using FuelCalculator.Models;

namespace FuelCalculator.Controllers
{
    public class FuelController : Controller
    {
       private FuelLogic _logic;
        public FuelController()
        {
            _logic = new FuelLogic();
        }
        
        // GET: Fuel
        public ActionResult CalculateFuelCons()
        {
            return View("~/ViewS/Fuel/CalculateFuelCons.cshtml");
        }

        [HttpPost]
        // POST: Fuel
        public ActionResult CalculateFuelCons(Fuel model)
        {
            if (model.Distance==null || model.FuelUsed == null)
            {
                return View(model);
            }
            _logic.CalcAvgConsumption(model);
            return View("Result", model);
        }

    }
}