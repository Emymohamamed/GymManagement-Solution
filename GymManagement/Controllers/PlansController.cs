using GymManagement.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GymManagement.Controllers
{
    public class PlansController : Controller
    {
        private readonly GymDbContext context = new GymDbContext();
        //index
        public async Task<IActionResult> Index()
        {
            var Plans = await context.Plans.ToListAsync();
            return View(Plans);
        }
        public async Task<IActionResult> Details(int id)
        {
            var plan = await context.Plans.FirstOrDefaultAsync(p => p.Id == id);
            if (plan is null) return RedirectToAction(nameof(Index));
            return View(plan);

                    
                    


}
    } 

}