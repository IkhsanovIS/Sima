using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaWebProject.Models
{
    public interface IEquipmentRepository
    {
        IQueryable<Equipment> Equipments { get; }
    }
}
