using Bussiness_Objects.Models;
using Repository.IRepository;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UnitOfWork : IUnitOfWork
    {
        private IAdoptionRequestRepo _adoptionRequestrepo;
        private IEventRepo _eventrepo;
        private IFeedbackRepo _feedbackrepo;
        private IHealthCheckRepo _healthcheckrepo;
        private INotificationRepo _notificationrepo;
        private IPetRepo _petrepo;
        private IShelterRepo _shelterrepo;
        private IUserRepo _userrepo;
        private IVolunteerTaskRepo _volunteertaskrepo;

        private PawFundContext _context;

        public UnitOfWork()
        {
            _adoptionRequestrepo ??= new AdoptionRequestRepo();
            _eventrepo ??= new EventRepo();
            _feedbackrepo ??= new FeedbackRepo();
            _healthcheckrepo ??= new HealthCheckRepo();
            _notificationrepo ??= new NotificationRepo();
            _petrepo ??= new PetRepo();
            _shelterrepo ??= new ShelterRepo();
            _userrepo ??= new UserRepo();
            _volunteertaskrepo ??= new VolunteerTaskRepo();
        }

        public IAdoptionRequestRepo AdoptionRequestRepo
        {
            get
            {
                return _adoptionRequestrepo ??= new AdoptionRequestRepo(_context);
            }
        }
        public IEventRepo EventRepo
        {
            get
            {
                return _eventrepo ??= new EventRepo(_context);
            }
        }
        public IFeedbackRepo FeedbackRepo
        {
            get
            {
                return _feedbackrepo ??= new FeedbackRepo(_context);
            }
        }
        public IHealthCheckRepo HealthCheckRepo
        {
            get
            {
                return  _healthcheckrepo ??= new HealthCheckRepo(_context);
            }
        }
        public INotificationRepo NotificationRepo
        {
            get
            {
                return _notificationrepo ??= new NotificationRepo(_context);
            }
        }
        public IPetRepo petRepo
        {
            get
            {
                return _petrepo ??= new PetRepo(_context);
            }
        }
        public IShelterRepo shelterRepo
        {
            get
            {
                return _shelterrepo ??= new ShelterRepo(_context);
            }
        }
        public IUserRepo userRepo
        {
            get
            {
                return _userrepo ??= new UserRepo(_context);
            }
        }
        public IVolunteerTaskRepo volunteerTaskRepo
        {
            get
            {
                return _volunteertaskrepo ??= new VolunteerTaskRepo(_context);
            }
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
