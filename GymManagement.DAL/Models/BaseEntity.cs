using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
       public Gender Gender { get; set; }
        public Address Address { get; set; }


    }
}
