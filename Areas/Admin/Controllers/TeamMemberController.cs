using bilet_5.DAL;
using bilet_5.Models;
using Microsoft.AspNetCore.Mvc;

namespace bilet_5.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamMemberController : Controller
    {
        private readonly AppDbContext _appdbContext;
      public TeamMemberController(AppDbContext appdbContext)
        {
            _appdbContext = appdbContext;
        }

        public IActionResult Index()
        {
            List<TeamMember> teamMembers = _appdbContext.Members.ToList();

            return View(teamMembers);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
          TeamMember teamMember= _appdbContext.Members.Find(id);
            if (teamMember == null) { return NotFound(); }


            _appdbContext.Members.Remove(teamMember);
            _appdbContext.SaveChanges();
            
            return RedirectToAction("Index");
        }
           
        }
    
}
