using Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IUnitOfWork : IDisposable
    {
        IAdoptionRequestRepo AdoptionRequestRepo { get; }
        IEventRepo EventRepo { get; }
        IFeedbackRepo FeedbackRepo { get; }
        IHealthCheckRepo HealthCheckRepo { get; }
        INotificationRepo NotificationRepo { get; }
        IPetRepo petRepo { get; }
        IShelterRepo shelterRepo { get; }
        IUserRepo userRepo { get; }
        IVolunteerTaskRepo volunteerTaskRepo { get; }
    }
}
