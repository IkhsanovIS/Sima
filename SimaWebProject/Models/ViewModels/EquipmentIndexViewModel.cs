using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SimaWebProject.Models.ViewModels
{
    public class EquipmentIndexViewModel
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }
        public string Varification { get; set; }
        public string Muster { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = @"{0:dd'/'MM'/'yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Срок действия")]
        public DateTime? ExpirationDate { get; set; }




    }
}
