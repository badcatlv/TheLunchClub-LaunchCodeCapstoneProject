using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace option4mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class InventoryController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }
    }
}
