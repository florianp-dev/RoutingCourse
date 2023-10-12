using Microsoft.AspNetCore.Mvc;

namespace Course.Route.Controllers;

public class VoituresController : Controller
{
    // GET
    public IActionResult Accueil()
    {
        return View();
    }

    [Route("/search/category/{category:alpha}")]
    public IActionResult Search(string category)
    {
        return View("Search", category);
    }

    [Route("details/{id:positiveinteger}")]
    public IActionResult Details(int id)
    {
        return View();
    }
}