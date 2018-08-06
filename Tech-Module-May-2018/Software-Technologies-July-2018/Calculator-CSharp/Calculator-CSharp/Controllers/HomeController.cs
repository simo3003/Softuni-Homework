using Calculator_CSharp.Models;
using Microsoft.AspNetCore.Mvc;

namespace Calculator_CSharp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        [HttpPost]
        public IActionResult Calculate(Calculator calculator)
        {
            calculator.CalculateResult();

            return RedirectToAction("Index", calculator);
        }
    }
}
