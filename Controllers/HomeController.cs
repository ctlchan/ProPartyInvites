using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult RsvpForm()
    {
        return View();
    }
}
