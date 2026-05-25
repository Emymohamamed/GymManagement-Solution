using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Models
{
    public class Address : GymUser
    {
        public string? BuildingNumber { get; set; }
        public string ? Street { get; set; }
        public string ? City { get; set; }

        public bool Equals(Address? other)
        {
            throw new NotImplementedException();
        }
    }
}
