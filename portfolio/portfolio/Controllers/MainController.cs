using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Resume()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Send(string FirstName, string LastName, string Email, string Subject, string Message)
        {
            return RedirectToAction("Contact");
        }

        public IActionResult Download()
        {
            return File("~/File/Jayannth Resume.pdf", "application/pdf", "Pamuru_Jayannth_Resume.pdf");
        }

        public IActionResult Experience()
        {
            return View();
        }
    }
}