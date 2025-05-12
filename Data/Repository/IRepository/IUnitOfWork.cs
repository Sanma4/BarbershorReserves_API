using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IAdressRepository Adress { get; }
        IBookingRepository Booking { get; }
        IBookingDetailsRepository BookingDetails { get; }
        IClientRepository Client { get; }
        IEmployeeRepository Employee { get; }
        IEmployeeCategoryRepository EmployeeCategory { get; }
        IPromotionRepository Promotion { get; }
        IReviewRepository Review { get; }
        IScheduleRepository Schedule { get; }
        IServiceRepository Service { get; }
        IServiceCategoryRepository ServiceCategory { get; }

        void SaveChangesAsync();

    }
}
