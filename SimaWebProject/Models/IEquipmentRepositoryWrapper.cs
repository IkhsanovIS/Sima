using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaWebProject.Models
{
    interface IEquipmentRepositoryWrapper
    {
        IEquipmentRepository EquipmentRepository { get; }
        IBranchRepository BranchRepository { get;}
    }
}
