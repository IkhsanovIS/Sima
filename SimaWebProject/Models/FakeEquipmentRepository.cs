using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaWebProject.Models
{
    public class FakeEquipmentRepository : IEquipmentRepository
    {
        public IQueryable<Equipment> Equipments => new List<Equipment>()
        {
            new Equipment {Name = "Скан", Number = "354q", BranchId = 1, DateOfManufacture = DateTime.Today },
            new Equipment {Name = "Толщиномер", Number = "па588", BranchId = 1, DateOfManufacture = DateTime.Today }
        }.AsQueryable();

    }
}
