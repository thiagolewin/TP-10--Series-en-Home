using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Series.Models;

namespace Series.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.Series = BD.ListarSeries();
        return View();
    }
    public List<Actor> Actor(int idSerie){

        return BD.ListarActores(idSerie);
    }
    public Serie Descripcion(int idSerie){

        return BD.Descripcion(idSerie);
    }
      public List<Temporada> Temporada(int idSerie){

        return BD.Temporada(idSerie);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
