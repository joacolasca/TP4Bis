using Microsoft.AspNetCore.Mvc;
using TP4_Bis.Models;
namespace TP4_Bis.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.ListaPaises = Info.ListarPaises();
        return View("Index");
    }
    public IActionResult DetallePais(string pais)
    {
        ViewBag.Pais = Info.DetallePais(pais);
        return View("DetallePais");
    }
}
