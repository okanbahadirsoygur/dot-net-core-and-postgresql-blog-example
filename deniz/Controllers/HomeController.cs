using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using deniz.Models;

namespace deniz.Controllers;

public class HomeController : Controller
{
 

    public IActionResult Index()
    {


        return View();
    }

    [HttpGet]
    [Route("/login")]
    public IActionResult login()
    {

        String kadi = HttpContext.Request.Query["kadi"].ToString();
        String sifre = HttpContext.Request.Query["sifre"].ToString();

        ViewBag.kadi = kadi;
        ViewBag.sifre = sifre;
        return View();

    }//func

    [HttpPost]
    [Route("/login")]
    public IActionResult loginPost()
    {
        String ad = HttpContext.Request.Form["kadi"];
        String sifre = HttpContext.Request.Form["sifre"];


        return Redirect("/login?kadi="+ad+"&sifre="+sifre);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    
    [HttpGet]
    [Route("/register")]
    public IActionResult Register()
    {
        return View();
    }

  
}

