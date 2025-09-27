using Microsoft.AspNetCore.Mvc;

namespace testingApplication.Controllers;


public class RouteController : Controller
{

    public ActionResult Index()
    {

        return View("~/Views/Home/Index.cshtml");
    }

    public ActionResult About()
    {
        return View("~/Views/Home/About.cshtml");
    }


    public ActionResult Login()
    {

        return View("~/Views/Auth/Login.cshtml");

    }

    public ActionResult Register()
    {

        return View("~/Views/Auth/Register.cshtml");


    }



}


