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
            new Equipment {Name = "Скан", Number = "354q", BranchId = 1, DateOfManufacture = DateTime.Today,
                EquipmentStatus = new EquipmentStatus{Name = "Исправен", Status = "ИИ"},
                Musters = new List<Muster>{ new Muster { Number = "num001", DateOfExpiration = DateTime.Today},
                                            new Muster { Number = "num002", DateOfExpiration = DateTime.Today},
                                            new Muster { Number = "num003", DateOfExpiration = DateTime.Today } } },

            new Equipment {Name = "Толщиномер", Number = "еук784", BranchId = 1, DateOfManufacture = DateTime.Today,
                                EquipmentStatus = new EquipmentStatus{Name = "Исправен", Status = "ИИ"},
                Musters = new List<Muster>{ new Muster { Number = "num001", DateOfExpiration = DateTime.Today},
                                            new Muster { Number = "num002", DateOfExpiration = DateTime.Today},
                                            new Muster { Number = "num003", DateOfExpiration = DateTime.Today } } },

            new Equipment {Name = "УШС", Number = "фыу588", BranchId = 1, DateOfManufacture = DateTime.Today,
                                EquipmentStatus = new EquipmentStatus{Name = "Исправен", Status = "ИИ"},
                Musters = new List<Muster>{ new Muster { Number = "num001", DateOfExpiration = DateTime.Today},
                                            new Muster { Number = "num002", DateOfExpiration = DateTime.Today},
                                            new Muster { Number = "num003", DateOfExpiration = DateTime.Today } } },

            new Equipment {Name = "Линейка", Number = "про74", BranchId = 1, DateOfManufacture = DateTime.Today,
                                EquipmentStatus = new EquipmentStatus{Name = "Исправен", Status = "ИИ"},
                Musters = new List<Muster>{ new Muster { Number = "num001", DateOfExpiration = DateTime.Today},
                                            new Muster { Number = "num002", DateOfExpiration = DateTime.Today},
                                            new Muster { Number = "num003", DateOfExpiration = DateTime.Today } } },

            new Equipment {Name = "Толщиномер", Number = "47889", BranchId = 1, DateOfManufacture = DateTime.Today,
                                EquipmentStatus = new EquipmentStatus{Name = "Исправен", Status = "ИИ"},
                Musters = new List<Muster>{ new Muster { Number = "num001", DateOfExpiration = DateTime.Today},
                                            new Muster { Number = "num002", DateOfExpiration = DateTime.Today},
                                            new Muster { Number = "num003", DateOfExpiration = DateTime.Today } } }
        }.AsQueryable();

    }
}
