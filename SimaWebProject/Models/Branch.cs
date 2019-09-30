using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaWebProject.Models
{
    public class Branch
    {
        public Branch()
        {
            Equipments = new HashSet<Equipment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Equipment> Equipments { get; set; }
    }
}
