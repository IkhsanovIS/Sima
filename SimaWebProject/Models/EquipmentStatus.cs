using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaWebProject.Models
{
    public class EquipmentStatus
    {
        public EquipmentStatus()
        {
            Equipments = new HashSet<Equipment>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }

        public ICollection<Equipment> Equipments { get; set; }

    }
}
