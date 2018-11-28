using Microsoft.AspNetCore.Mvc;
using JobBoard.Models;

namespace JobBoard.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost("JobBoard")]
        public ActionResult JobBoard(string title, string description, Contacts contactObject)
        {
            Contacts jobPostContact = new Contacts(contactName, contactPhone);
            JobOpening myJobPost = new JobOpening(title, description, jobPostContact);
            return View(myJobPost);
        }

    }
}

