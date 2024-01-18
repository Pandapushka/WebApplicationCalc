using Microsoft.AspNetCore.Mvc;
using WebCalc.LogicRepository;

namespace WebCalc.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalcController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(1);
        }
        [HttpPost]
        [Route("Sum")]
        public IActionResult Sum(double a, double b)
        {
            return Ok(SimpleCalc.Sum(a, b));
        }
        [HttpPost]
        [Route("Division")]
        public IActionResult Division(double a, double b)
        {
            return Ok(SimpleCalc.Division(a, b));
        }
        [HttpPost]
        [Route("Subtraction")]
        public IActionResult Subtraction(double a, double b)
        {
            return Ok(SimpleCalc.Subtraction(a, b));
        }
        [HttpPost]
        [Route("Multiplication")]
        public IActionResult Multiplication(double a, double b)
        {
            return Ok(SimpleCalc.Multiplication(a, b));
        }
        [HttpPost]
        [Route("Pow")]
        public IActionResult Pow(double a, double b)
        {
            return Ok(SimpleCalc.Pow(a, b));
        }
        [HttpPost]
        [Route("Root")]
        public IActionResult Root(double a, double b)
        {
            return Ok(SimpleCalc.Root(a, b));
        }
        [HttpPost]
        [Route("CalcExpression")]
        public IActionResult CalcExpression(string a)
        {
            return Ok(AdvancedCalc.CalcExpression(a));
        }

    }
}
