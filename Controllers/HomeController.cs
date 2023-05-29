using bilet_5.DAL;
using bilet_5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bilet_5.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {

        List<TeamMember>teamMembers=_appDbContext.Members.ToList();
            
            return View(teamMembers);
        }

        
    }
}