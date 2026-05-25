using GymManagement.DAL.Repositories.Interfaces;
using GymManagement.DbContexts;
using GymManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Repositories.Classes
{
    public class PlanRepository : IPlanRepository
    {private readonly GymDbContext context;
        public PlanRepository(GymDbContext context)
        {
            context= context ;
        }
        public async Task<IEnumerable<Plan>> GetAllAsync(bool tracking = false, CancellationToken ct = default)

            => tracking ?await context.Plans.ToListAsync(ct): await context.Plans.AsNoTracking().ToListAsync(ct);
            
        
        public async Task<Plan> GetByIdsyc(int id, CancellationToken ct = default)
        => await context.Plans.FirstOrDefaultAsync(p => p.Id == id, ct);
        public async Task<int> AddAsync(Plan plan, CancellationToken ct = default)
        { 
         await context.Plans.AddAsync(plan, ct);
            return await context.SaveChangesAsync(ct);
        }
        public async Task<int> UpdateAsync(Plan plan, CancellationToken ct = default)
        {
             context.Plans.Update(plan);
            return await context.SaveChangesAsync(ct);
        }
        public async Task<int> DeleteAsync(Plan plan, CancellationToken ct = default)
        {
            context.Plans.Remove(plan);
            return await context.SaveChangesAsync(ct);
        }
    }
}
    