﻿using Bussiness_Objects.Models;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class HealthCheckRepo : GenericRepository<HealthCheck>, IHealthCheckRepo
    {
        public HealthCheckRepo() { }

        public HealthCheckRepo(PawFundContext context) => _context = context;
    }
}