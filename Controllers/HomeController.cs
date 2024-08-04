using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP06_Berihogr_AguileraS.Models;

namespace TP06_Berihogr_AguileraS.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Game()
    {
        return View();
    }

    public IActionResult Historia()
    {
        return View();
    }

    public IActionResult PasarTurno(int[] movimientosJugador)
    {
        int[] resultados = new int[3];
        ViewBag.vidasNorte = Mechanics.vidaNorte;
        ViewBag.vidasNorte = Mechanics.vidaCentro;
        ViewBag.vidasNorte = Mechanics.vidaSur;
        if (Mechanics.vidaDesembarco != 4)
        {
            ViewBag.vidasNorte = Mechanics.vidaDesembarco;
        }
        resultados = Mechanics.CombatResult(movimientosJugador);
        return View("Game");
    }

    public IActionResult Nombres(string pagina)
    {
        ViewBag.nombres = true;
        if (pagina == "Menú Principal")
        {
            pagina = "Index";
        }
        return View(pagina);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
