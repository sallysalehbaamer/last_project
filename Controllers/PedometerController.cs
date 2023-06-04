using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using my_final_project.Models;

namespace my_final_project.Controllers
{
    public class PedometerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Steps()
        {
            return View();
        }
        [HttpPost]
        public IActionResult StepsToCalories(post post)
        {
            double TotalCaloriesBurned = post.Steps * (0.04);
            ViewBag.TotalCaloriesBurned2 = TotalCaloriesBurned;
            return View();
        }
    }
}
