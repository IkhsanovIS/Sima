using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaWebProject.Models
{
    public class Muster
    {
        public Muster()
        {
            Equipments = new HashSet<Equipment>();
        }

        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfExpiration { get; set; }

        public ICollection<Equipment> Equipments {get;set;}



    }
}
