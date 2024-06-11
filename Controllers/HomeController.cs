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
        // ModelState is built into base class Controller - details the outcome of the model binding process
        if (ModelState.IsValid) 
        {
            // Uses the static Repository class to store the filled-object
            Repository.AddResponse(guestResponse);
            // We can't invoke View() because we don't want to send it back to an empty form
            return View("Thanks", guestResponse);
        } 
        // Razor has access to validation details - loading the default view will display validation errors as necessary
        else
            return View();
    }
    [HttpGet]
    public ViewResult ListResponses()
    {
        return View(Repository.Responses
                .Where(r => r.WillAttend == true));
    }
}
