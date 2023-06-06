using health_and_fitness.Models;
using Microsoft.AspNetCore.Mvc;

namespace health_and_fitness.Controllers
{

   
    public class PedometerController : Controller
    {
        private readonly Context _Content;
        public PedometerController (Context cc)
        {
            _Content = cc;
        }

        public IActionResult Steps()
        {
            return View();
        }

        [HttpPost]
        public IActionResult StepsToCalories(TotalCaloriesBurned cc)

        {
            cc.date = DateTime.Now; 
            _Content.tables.Add(cc);
            _Content.SaveChanges();

            double TotalCaloriesBurned = cc.num * 0.04;
            return View(TotalCaloriesBurned);
        
    }
}
