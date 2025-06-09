using Microsoft.AspNetCore.Mvc;
using SMBigNumbersLab.Models;
using System.Reflection;

namespace SMBigNumbersLab2.Controllers
{
    public class LabController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Power()
        {
            Power model = new Power();
            return View("Power", model);
        }
        [HttpPost]
        public IActionResult GetPowerResult(Power model)
        {       
        
            if (ModelState.IsValid)
            {
                Number rez = (new Number(model.Number1)) ^ (new Number(model.Number2));
                model.Result = rez.ToStringFormated();
            }
            return View("Power", model);            
        }
        public IActionResult Fibonacci()
        {
            Fibonacci model = new Fibonacci();
            return View("FibonacciMain", model);
        }
        [HttpPost]
        public IActionResult GetResultFibonacci(Fibonacci model)
        {
            if (ModelState.IsValid)
            {
                model.GetResult();
            }
            return View("FibonacciMain", model);
        }
    }
}
