using Microsoft.AspNetCore.Mvc;

namespace Course.Route.Controllers;

public class ProductsController : Controller
{
    [Route("products/{id}")]
    public IActionResult View(int id)
    {
        return View();
    }

    [Route("news/{year:int?}/{month:int?}")]
    public IActionResult News(int year, int month)
    {
        return View(new InternalDate { Year = year, Month = month });
    }

    public record InternalDate
    {
        public int Year { get; set; } = DateTime.Now.Year;
        public int Month { get; set; } = DateTime.Now.Month;
    }
}