using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace option4mvc.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
