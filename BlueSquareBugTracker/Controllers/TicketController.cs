using BlueSquareBugTracker.Data;
using BlueSquareBugTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace BlueSquareBugTracker.Controllers
{
    public class TicketController : Controller
    {
        private readonly ILogger<TicketController> _logger;
        private readonly AppDbContext _dbContext;
        public TicketController(ILogger<TicketController> logger,AppDbContext appDbContext)
        {
            _logger = logger;
            _dbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(TicketFormViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Index");
        }
    }
}
