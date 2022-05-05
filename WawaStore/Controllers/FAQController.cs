using Microsoft.AspNetCore.Mvc;

namespace WawaStore.Controllers
{
    public class FAQController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
