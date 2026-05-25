using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; } = null!;
        // varchar(20)

        // Navigation: a category groups many sessions
        public ICollection<Session> Sessions { get; set; }
            = new List<Session>();
       
    }
}
