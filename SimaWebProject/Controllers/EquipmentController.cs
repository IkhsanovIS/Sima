using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimaWebProject.Models;
using SimaWebProject.Models.ViewModels;

namespace SimaWebProject.Controllers
{
    public class EquipmentController : Controller
    {
        private IEquipmentRepository repository;

        public EquipmentController(IEquipmentRepository repository)
        {
            this.repository = repository;
        }

        public ViewResult Index()
        {
            List<EquipmentIndexViewModel> viewModels = new List<EquipmentIndexViewModel>();

            foreach (var equipment in repository.Equipments)
            {
                EquipmentIndexViewModel model = new EquipmentIndexViewModel();
                model.Id = equipment.Id;
                model.Name = equipment.Name;
                model.Number = equipment.Number;
                model.Status = equipment.EquipmentStatus?.Status;

                foreach (var muster in equipment.Musters)
                {
                    model.Muster = muster.Number;
                    model.ExpirationDate = muster.DateOfExpiration;
                    break;
                    //if (muster.DateOfIssue < DateTime.Now && muster.DateOfExpiration >= DateTime.Now)
                    //{
                    //    model.Muster = muster.Number;
                    //    model.ExpirationDate = muster.DateOfExpiration;
                    //    break;
                    //}
                }
                viewModels.Add(model);
            }

            return View(viewModels);
        
        }
    }
}
