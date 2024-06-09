using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public ViewResult RsvpForm()
    {
        return View();
    }

    [HttpPost]
    public ViewResult RsvpForm(GuestResponse guestResponse)
    {
        // Uses the static Repository class to store the filled-object
        Repository.AddResponse(guestResponse);
        // We can't invoke View() because we don't want to send it back to an empty form
        return View("Thanks", guestResponse);
    }
}
