using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using option4mvc.Data;
using option4mvc.Models;
using option4mvc.Models.CartModels;

namespace option4mvc.Controllers
{
    public class CartsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CartsController(ApplicationDbContext context)
        {
            _context = context;
        }

        /*public IActionResult Index ()
        {
            List<Cart> carts = _context.Cart.ToList();

            return View(carts);
        }*/

        // GET: Carts
        public async Task<IActionResult> Index()
        {
            if (_context.Cart != null)
            {
                return View(await _context.Cart.ToListAsync());
            } else
            {
                return Problem("Entity set 'ApplicationDbContext.Cart'  is null.");
            }
        }
       
    }
}
