﻿using Bussiness_Objects.Models;
using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class FeedbackRepo : GenericRepository<Feedback>, IFeedbackRepo
    {
        public FeedbackRepo() { }

        public FeedbackRepo(PawFundContext context) => _context = context;
    }
}
