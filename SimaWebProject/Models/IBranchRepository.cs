using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaWebProject.Models
{
    public interface IBranchRepository
    {
        IQueryable<Branch> Branches { get; }
    }
}
