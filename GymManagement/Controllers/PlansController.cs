using GymManagement.DAL.Repositories.Classes;
using GymManagement.DAL.Repositories.Interfaces;
using GymManagement.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace GymManagement.Controllers
{
    public class PlansController : Controller
    {
      //  private readonly GymDbContext context = new GymDbContext();
      private readonly  IPlanRepository _PlanRepository;
        //index
        public PlansController(IPlanRepository  planRepository)

        {
            _PlanRepository = planRepository;
        }
            
        public async Task<IActionResult> Index(CancellationToken ct =default)
        {
            // var Plans = await context.Plans.ToListAsync();
         var plans= await _PlanRepository.GetAllAsync (ct :ct);
            return View(plans);
        }
        public async Task<IActionResult> Details(int id,CancellationToken ct=default)
        {
            //var plan = await context.Plans.FirstOrDefaultAsync(p => p.Id == id);

            var Plan = await _PlanRepository.GetByIdsyc(id,ct);
            if (Plan is null) return RedirectToAction(nameof(Index));
            return View(Plan);

                    
                    


}
    } 

}