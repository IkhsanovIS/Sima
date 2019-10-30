using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimaWebProject.Models
{
    public class FakeBranchRepository :IBranchRepository
    {
        public IQueryable<Branch> Branches => new List<Branch>()
        {
            new Branch { Id = 1, Name = "Казань"},
            new Branch {  Id = 2, Name = "Москва"},
            new Branch {  Id = 3, Name = "Санкт-Петербург"},
        }.AsQueryable();

    }
}
