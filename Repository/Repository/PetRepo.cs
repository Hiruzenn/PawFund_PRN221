using Bussiness_Objects.Models;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class PetRepo : GenericRepository<Pet>, IPetRepo
    {
        public PetRepo() { }

        public PetRepo(PawFundContext context) => _context = context;
    }
}
