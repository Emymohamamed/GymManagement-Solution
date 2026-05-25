using GymManagement.DAL.Models;

namespace GymManagement.Models
{
    public class Plan:BaseEntity
    {
     
 
           
            
            public string Name { get; set; } = null!;
            public string Description { get; set; } = default!;
            public int DurationDays { get; set; }
            public decimal Price { get; set; }
            public bool IsActive { get; set; }   // soft-delete flag
        }
    }

