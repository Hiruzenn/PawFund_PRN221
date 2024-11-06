using Bussiness_Objects.Models;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class UserRepo : GenericRepository<User>, IUserRepo
    {
        public UserRepo() { }

        public UserRepo(PawFundContext context) => _context = context;
    }
}
