using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaWebProject.Models
{
    public class FakeEquipmentRepositoryWrapper :IEquipmentRepositoryWrapper
    {
        private IEquipmentRepository equipmentRepository;
        private IBranchRepository branchRepository;

        public IBranchRepository BranchRepository{
            get {
                if (branchRepository == null)  branchRepository = new FakeBranchRepository(); 
                return branchRepository;
            }
        }

        public IEquipmentRepository EquipmentRepository {
            get {
                if (equipmentRepository == null) equipmentRepository = new FakeEquipmentRepository();
                return equipmentRepository;
            }
        }
    }

}
