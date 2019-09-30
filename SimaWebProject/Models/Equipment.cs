using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaWebProject.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        public int? BranchId { get; set; }
        public Branch Branch { get; set; }

        public DateTime? DateOfManufacture { get; set; }


    }
}
