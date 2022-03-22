using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cars.Models;

namespace Cars.Controllers;

public class CarsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}