using Microsoft.AspNetCore.Mvc;

namespace Activity_2_Basic_Routing.Controllers
{
    public class OperationController : Controller
    {
        //localhost:7021/operation/add/10/2
        public IActionResult Add(int num1, int num2)
        {
            if (num1 == default || num2 == default)
            {
                return Content("Both numbers must be provided.");
            }
            else
            {
                return Content($"{num1} + {num2} is equal to {num1 + num2}");
            }
        }

        //localhost:7021/operation/subtract/10/2
        public IActionResult Subtract(int num1, int num2)
        {
            if (num1 == default || num2 == default)
            {
                return Content("Both numbers must be provided.");
            }
            else
            {
                return Content($"{num1} - {num2} is equal to {num1 - num2}");
            }
        }

        //localhost:7021/operation/multiply/10/2
        public IActionResult Multiply(int num1, int num2)
        {
            if (num1 == default || num2 == default)
            {
                return Content("Both numbers must be provided.");
            }
            else
            {
                return Content($"{num1} * {num2} is equal to {num1 * num2}");
            }
        }

        //localhost:7021/operation/divide/10/2
        public IActionResult Divide(int num1, int num2)
        {
            if (num2 == default)
            {
                return Content("Both numbers must be provided and zero is invalid second number.");
            }
            else
            {
                float result = (float)num1 / (float)num2;
                return Content($"{num1} / {num2} is equal to {result}");
            }
           
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
