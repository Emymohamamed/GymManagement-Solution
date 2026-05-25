using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagement.DAL.Models
{
    internal class HealthRecourd:BaseEntity
    {
      public decimal MyProperty { get; set; }
        public decimal Hight { get; set; }
        public decimal Wight { get; set; }
        public string BloodType { get; set; }
        public string ? Note { get; set; }
    }
}
