using Microsoft.AspNetCore.Mvc;

namespace DataBroker_API.Controllers
{
    public class SeriesComicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
