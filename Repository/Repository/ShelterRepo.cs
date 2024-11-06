using Bussiness_Objects.Models;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class ShelterRepo: GenericRepository<Shelter>, IShelterRepo
    {
        public ShelterRepo() { }

        public ShelterRepo(PawFundContext context) => _context = context;
    }
}
