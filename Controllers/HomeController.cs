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
        int habitacion=Escape.GetEstadoJuego();
        return View($"Habitacion{habitacion+1}");
    }

    public IActionResult Habitacion(int sala, string clave){
        int habitacion = Escape.GetEstadoJuego();
        if (sala!=habitacion){
            return View($"Habitacion{habitacion+1}");
        }
        else if (Escape.ResolverSala(sala, clave)){
            if(habitacion<5){
                return View($"Habitacion{habitacion+1}");
            }
            else{
                return View($"Habitacion{5}");
            }
        }
        else{
            ViewBag.MensajeError = "La clave es incorrecta";
        }
        return View();
    }

    public IActionResult Creditos(){
        return View();
    }
}
