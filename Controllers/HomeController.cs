using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalaDeEscape.Models;

namespace SalaDeEscape.Controllers;

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

    public IActionResult Tutorial(){
        return View();
    }

    public IActionResult Comenzar(){
        Escape.estadoJuego=1;
        int habitacion=Escape.GetEstadoJuego();
        return View($"habitacion{habitacion}");
    }

    public IActionResult Habitacion(int sala, string clave){
        int habitacion = Escape.GetEstadoJuego();
        if (sala!=habitacion){
            return View($"habitacion{habitacion}");
        }
        if (Escape.ResolverSala(sala, clave)){
            if(habitacion<5){
                return View($"habitacion{habitacion+1}");
            }
            else{
                return View("Victoria");
            }
        }
        else{
            ViewBag.MensajeError = "La clave es incorrecta";
            return View($"habitacion{habitacion}");
        }
    }

    public IActionResult Creditos(){
        return View();
    }
}
