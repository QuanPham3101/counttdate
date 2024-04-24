using countdate.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace countdate.Controllers
{
        public class DateController : Controller
    {
        
        public IActionResult Index()
        {
            DateTime startDate = new DateTime(2023, 11, 24);
            DateTime endDate = DateTime.Now;

            DateCalculator model = new DateCalculator();
            model.Calculate(startDate, endDate);

            return View(model);
        }

    }
}
